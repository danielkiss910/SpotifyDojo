namespace SpotifyDojo.Model.Author;

public interface IAuthor
{
    string Name { get; set; }
    List<Track.Track> GetTracks();
}