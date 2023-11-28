namespace SpotifyDojo;

public class SongAuthor : IAuthor
{
    public string Name { get; set; }
    public List<Album> Albums { get; set; }

    public SongAuthor(string name)
    {
        Name = name;
        Albums = new List<Album>();
    }

    public List<Track> GetTracks()
    {
        return Albums.SelectMany(album => album.Songs).Cast<Track>().ToList();
    }
}
        /*
         POLYMORPHISM, LINQ
        1. List of Album objects, each album contains a list of Song objects
        2. LINQ SelectMany - flatten multiple lists into a single list 
            (here the list of songs from each album to a single list of songs)
        3. Cast to Track - Song inherits from Track, interface expects a List<Track> -
            so list of Song objects is cast to List<Track>
        4. ToList() converts the IEnumerable from SelectMany and Cast into a List<Track>
        */
