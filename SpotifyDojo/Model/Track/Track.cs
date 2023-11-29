namespace SpotifyDojo.Model.Track;

public abstract class Track
{
    public string Name { get; private set; }
    public int LengthInSeconds { get; private set; }
    public int NumberOfTimesPlayed { get; private set; }
    
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