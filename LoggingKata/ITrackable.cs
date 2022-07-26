namespace LoggingKata
{
    public interface ITrackable
    {
        string Name { get; set; }
        object name { get; set; }
        Point Location { get; set; }
    }
}