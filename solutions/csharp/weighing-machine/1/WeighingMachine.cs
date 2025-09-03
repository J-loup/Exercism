class WeighingMachine (int precision)
{
    private int precision = precision;
    public int Precision { get => precision; }

    private double weight;
    public double Weight
    {
        get => weight;
        set
        {
            weight = value < 0 ? throw new ArgumentOutOfRangeException("Weight can't be negative") : value;
        }
    }

    private double tareAdjustment = 5.0;
    public double TareAdjustment { set => tareAdjustment = value; }

    public string DisplayWeight
    {
        get { return String.Format("{0:F" + precision + "} kg", weight-tareAdjustment); }
    }

}
