namespace SpotifyDojo.Model.Track;

public abstract class Track
{
    public string Name { get; set; }
    public int LengthInSeconds { get; set; }
    public int NumberOfTimesPlayed { get; set; }
    
    protected Track(string name, int lengthInSeconds)
    {
        Name = name;
        LengthInSeconds = lengthInSeconds;
        NumberOfTimesPlayed = 0; // increment later
    }

    public void Play()
    {
        NumberOfTimesPlayed++;
    }
}