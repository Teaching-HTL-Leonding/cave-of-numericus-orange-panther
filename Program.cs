const int NUMBER_OF_STONES = 1_000_000;
const int MIN_RANDOM = 1;
const int MAX_RANDOM = 1_000_000_000 + 1;

var randomNumbers = GenerateRandomArray();
// Array.Sort(randomNumbers);
QuickSort(ref randomNumbers, 0, NUMBER_OF_STONES - 1);
double averageDistane = CalculateAverageDistance(randomNumbers);
Console.WriteLine($"average distance: {averageDistane:n5}");

int[] GenerateRandomArray()
{
    var rand = new Random(4711);
    var randomNumbers = new int[NUMBER_OF_STONES];
    for (int i = 0; i < NUMBER_OF_STONES; i++)
    {
        // randomNumbers[i] = Random.Shared.Next(MIN_RANDOM, MAX_RANDOM);
        randomNumbers[i] = rand.Next(MIN_RANDOM, MAX_RANDOM);
    }
    return randomNumbers;
}

double CalculateAverageDistance(int[] numbers)
{
    var distances = new int[NUMBER_OF_STONES - 1];
    for (int i = 0; i < NUMBER_OF_STONES - 1; i++)
    {
        distances[i] = numbers[i + 1] - numbers[i];
    }
    return distances.Average();
}

void BubbleSort(ref int[] numbers)
{
    for (int i = 0; i < NUMBER_OF_STONES - 1; i++)
    {
        for (int j = 0; j < NUMBER_OF_STONES - 1; j++) //++ erhöht die Variable
        {
            if (numbers[j] > numbers[j + 1])
            {
                (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
            }
        }
    }
}

void QuickSort(ref int[] numbers, int left, int right)
{
    if (left < right)
    {
        int partitionIndex = Partition(ref numbers, left, right);
        QuickSort(ref numbers, left, partitionIndex - 1);
        QuickSort(ref numbers, partitionIndex + 1, right);
    }
}

int Partition(ref int[] numbers, int left, int right)
{
    int pivot = numbers[right];
    int i = left - 1;

    for (int j = left; j < right; j++)
    {
        if (numbers[j] <= pivot)
        {
            i++;
            (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
        }
    }

    (numbers[i + 1], numbers[right]) = (numbers[right], numbers[i + 1]);
    return i + 1;

}



