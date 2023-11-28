namespace SpotifyDojo;

public interface IAuthor
{
    string Name { get; set; }
    List<Track> GetTracks();
}