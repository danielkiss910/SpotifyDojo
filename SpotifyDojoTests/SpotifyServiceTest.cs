using SpotifyDojo.Model.Album;
using SpotifyDojo.Model.Author;
using SpotifyDojo.Model.Enum;
using SpotifyDojo.Model.Track;
using SpotifyDojo.Service;

namespace SpotifyDojoTests;

public class SpotifyServiceTest
{
    [Test]
    public void SearchByTrackNameTest()
    {
        var songAuthor1 = new SongAuthor("SongAuthor1");
        var album1 = new Album("Album1", MusicStyle.Pop);
        
        album1.Songs.Add(new Song("Song1", 180, "Lyrics of Song1"));
        album1.Songs.Add(new Song("Song2", 200, "Lyrics of Song2"));
        album1.Songs.Add(new Song("Song3", 220, "Lyrics of Song3"));
        songAuthor1.Albums.Add(album1);
        
        var podcastAuthor1 = new PodcastAuthor("PodcastAuthor1");
        
        podcastAuthor1.Podcasts.Add(new Podcast("Podcast1", 1, 1, 300));
        podcastAuthor1.Podcasts.Add(new Podcast("Podcast2", 1, 2, 320));
        podcastAuthor1.Podcasts.Add(new Podcast("Podcast3", 2, 1, 340));
        
        var spotifyService = new SpotifyService(new List<IAuthor> { songAuthor1, podcastAuthor1 });
        
        Assert.That(spotifyService.SearchByTrackName("Song2").Count, Is.EqualTo(1));
        Assert.That(spotifyService.SearchByTrackName("Song22").Count, Is.EqualTo(0));
    }
}