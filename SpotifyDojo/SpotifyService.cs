namespace SpotifyDojo;

public class SpotifyService
{
    private List<IAuthor> _authors;

    public SpotifyService(List<IAuthor> authors)
    {
        _authors = authors;
    }
    
    public List<Track> SearchByTrackName(string trackName)
}