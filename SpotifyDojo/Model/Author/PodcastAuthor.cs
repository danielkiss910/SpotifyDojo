using SpotifyDojo.Model.Track;

namespace SpotifyDojo.Model.Author;

public class PodcastAuthor : IAuthor
{
    public string Name { get; set; }
    public List<Podcast> Podcasts { get; set; }

    public PodcastAuthor(string name)
    {
        Name = name;
        Podcasts = new List<Podcast>();
    }

    public List<Track.Track> GetTracks()
    {
        return Podcasts.Cast<Track.Track>().ToList();
    }
}
/*
1. Podcasts property holds a list of Podcast objects
2. Podcast is subclass of Track - so list of Podcast objects is directly cast to List<Track>
3. ToList() converts the IEnumerable from Cast into a List<Track>
*/