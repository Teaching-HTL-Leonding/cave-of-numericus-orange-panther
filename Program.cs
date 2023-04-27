const int NUMBER_OF_STONES = 20;
var randomNumbers = GenerateRandomArray();
Array.Sort(randomNumbers);
double averageDistane = CalculateAverageDistance(randomNumbers);
Console.WriteLine($"average distance: {averageDistane}");

int[] GenerateRandomArray()
{
    //var rand = new Random(4711);
    var randomNumbers = new int[20];
    for (int i = 0; i < NUMBER_OF_STONES; i++)
    {
        randomNumbers[i] = Random.Shared.Next(1, 101);
        //randomNumbers[i] = rand.Next(1, 101);
    }
    return randomNumbers;
}

double CalculateAverageDistance(int[] numbers)
{
    var distances = new int[numbers.Length - 1];
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        distances[i] = numbers[i + 1] - numbers[i];
    }
    return distances.Average();
}

