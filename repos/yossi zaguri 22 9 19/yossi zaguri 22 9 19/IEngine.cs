namespace yossi_zaguri_22_9_19
{
    public interface IEngine
    {
        int Delta { get; set; }
        string Manufacturer { get; set; }
        int MaxRPM { get; set; }
        int Volume { get; set; }

        int DecreaseRPM();
        int IncreaseRpm();
    }
}