using SpotifyDojo.Model.Author;
using SpotifyDojo.Model.Track;

namespace SpotifyDojo.Service;

public class SpotifyService
{
    private List<IAuthor> _authors;

    public SpotifyService(List<IAuthor> authors)
    {
        _authors = authors;
    }

    public List<Track> SearchByTrackName(string trackName)
    {
        return _authors.SelectMany(author => author.GetTracks())
            .Where(track => track.Name.StartsWith(trackName, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
    /*
        1. SelectMany - flattens lists from all authors into single list
        2. .Where - filters flattened list to find where track name starts search string trackName
        3. StringComparison.OrdinalIgnoreCase - makes search case insensitive
        4. .ToList - converts result of LINQ query (IEnumerable<Track>) into List<Track>
    */

    public List<Track> ListTracksByAuthorName(string authorName)
    {
        var author =
            _authors.FirstOrDefault(author => author.Name.Equals(authorName, StringComparison.OrdinalIgnoreCase));
        return author?.GetTracks() ?? new List<Track>();
    }
    /*
        1. FirstOrDefault - searches first author whose name matches authorName.
            If no match found, returns null.
        2. author?.GetTracks() ?? new List<Track>();
            Null conditional operator (?.) to call GetTracks only if author is not null.
            If author is null, it returns a new empty list of tracks
    */

    public List<Track> GetTopListenedTracks(int count = 3)
    {
        return _authors.SelectMany(author => author.GetTracks())
            .OrderByDescending(track => track.NumberOfTimesPlayed)
            .Take(count)
            .ToList();
    }
    /*
        1. SelectMany - creates single list of tracks from all authors
        2. OrderByDescending - order tracks by NumberOfTimesPlayed in descending order (most played comes first)
        3. Take(count) - Takes the first 'count' of elements from the ordered list (3 in this case)
        4. Converts result into a List<Track>
    */

    public void Play(string trackName) // wrapper method
    {
        SearchByTrackName(trackName).First().Play(); // first - lista x elemet tudod lejatszani
    }
}