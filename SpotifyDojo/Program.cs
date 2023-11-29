using SpotifyDojo.Model.Album;
using SpotifyDojo.Model.Author;
using SpotifyDojo.Model.Enum;
using SpotifyDojo.Model.Track;
using SpotifyDojo.Service;

namespace SpotifyDojo;

class Program
{
    static void Main(string[] args)
    {
        // Create SongAuthor with Albums and Songs
        var songAuthor1 = new SongAuthor("SongAuthor1");
        var album1 = new Album("Album1", MusicStyle.Pop);
        
        album1.Songs.Add(new Song("Song1", 180, "Lyrics of Song1"));
        album1.Songs.Add(new Song("Song2", 200, "Lyrics of Song2"));
        album1.Songs.Add(new Song("Song3", 220, "Lyrics of Song3"));
        songAuthor1.Albums.Add(album1);
        
        
        // Create PodcastAuthor with Podcasts
        var podcastAuthor1 = new PodcastAuthor("PodcastAuthor1");
        
        podcastAuthor1.Podcasts.Add(new Podcast("Podcast1", 1, 1, 300));
        podcastAuthor1.Podcasts.Add(new Podcast("Podcast2", 1, 2, 320));
        podcastAuthor1.Podcasts.Add(new Podcast("Podcast3", 2, 1, 340));
        
        // Create SpotifyService and pass the list of authors
        var spotifyService = new SpotifyService(new List<IAuthor> { songAuthor1, podcastAuthor1 });
        
        spotifyService.Play("Song3");
        spotifyService.Play("Song3");
        spotifyService.Play("Song3");
        spotifyService.Play("Song3");
        spotifyService.Play("Song3");
        
        // Search for track by name
        var searchResults = spotifyService.SearchByTrackName("Song1");
        Console.WriteLine("\nTracks by SongAuthor1:");
        foreach (var track in searchResults)
        {
            Console.WriteLine(track.Name);
        }
        
        // List tracks by specific author
        var tracksByAuthor = spotifyService.ListTracksByAuthorName("SongAuthor1");
        Console.WriteLine("\nTracks by SongAuthor");
        foreach (var track in tracksByAuthor)
        {
            Console.WriteLine(track.Name);
        }
        
        // Get top listened tracks (need to simulate track plays)
        var topTracks = spotifyService.GetTopListenedTracks();
        Console.WriteLine("\nTop Listened Tracks");
        foreach (var track in topTracks)
        {
            Console.WriteLine($"{track.Name} - Played {track.NumberOfTimesPlayed} times");
        }
    }
}