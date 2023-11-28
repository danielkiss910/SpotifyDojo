namespace SpotifyDojo.Model.Track;

public class Song : Track
{
    public string Lyrics { get; set; }
    
    public Song(string name, int lengthInSeconds, string lyrics) 
        : base(name, lengthInSeconds)
    {
        Lyrics = lyrics;
    }
}