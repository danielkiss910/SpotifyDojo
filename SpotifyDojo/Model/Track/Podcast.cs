namespace SpotifyDojo.Model.Track;

public class Podcast : Track
{
    public int SeasonNumber { get; private set; }
    public int TrackNumber { get; private set; }
    
    public Podcast(string name, int seasonNumber, int trackNumber, int lengthInSeconds)
        : base(name, lengthInSeconds)
    {
        SeasonNumber = seasonNumber;
        TrackNumber = trackNumber;
    }
}