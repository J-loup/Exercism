class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int elapsedTime)
    {
        return ExpectedMinutesInOven() - elapsedTime;
    }

    public int PreparationTimeInMinutes(int layer)
    {
        return layer * 2;
    }

    public int ElapsedTimeInMinutes(int layer, int elapsedTime)
    {
        return PreparationTimeInMinutes(layer) + elapsedTime;
    }
}
