namespace SpotifyDojo;

public class Album
{
    public string Name { get; set; }
    public MusicStyle Style { get; set; }
    public List<Song> Songs { get; set; }

    public Album(string name, MusicStyle style)
    {
        Name = Name;
        Style = style;
        Songs = new List<Song>();
    }
}