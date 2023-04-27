const int NUMBER_OF_STONES = 1_000_000;
const int MIN_VALUE = 1;
const int MAX_VALUE = 1_000_000_000 + 1;

Console.WriteLine($"average distance: {GetAverageDistance():n5}");

double GetAverageDistance()
{
    var rand = new Random(4711);
    double min = MAX_VALUE, max = MIN_VALUE, ran;

    for (int i = 0; i < NUMBER_OF_STONES; i++)
    {
        // ran = Random.Shared.Next(MIN_VALUE, MAX_VALUE);
        ran = rand.Next(MIN_VALUE, MAX_VALUE);
        if (ran < min) { min = ran; }
        if (ran > max) { max = ran; }
    }

    return (max - min) / (NUMBER_OF_STONES - 1);
}
