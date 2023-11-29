using SpotifyDojo.Model.Enum;
using SpotifyDojo.Model.Track;

namespace SpotifyDojo.Model.Album;

public class Album
{
    public string Name { get; private set; }
    public MusicStyle Style { get; private set; }
    public List<Song> Songs { get; private set; }

    public Album(string name, MusicStyle style)
    {
        Name = Name;
        Style = style;
        Songs = new List<Song>();
    }
}