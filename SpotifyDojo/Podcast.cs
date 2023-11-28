namespace SpotifyDojo;

public class Podcast : Track
{
    public int SeasonNumber { get; set; }
    public int TrackNumber { get; set; }
    
    public Podcast(string name, int seasonNumber, int trackNumber, int lengthInSeconds)
        : base(name, lengthInSeconds)
    {
        SeasonNumber = seasonNumber;
        TrackNumber = trackNumber;
    }
}