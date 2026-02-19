//Main
Console.Write("Songs to add: ");
int n = Convert.ToInt32(Console.ReadLine());

Song[] playlist = new Song[n];
int index = 1;
string t;
string a;
double d;
for (int i = 0; i < playlist.Length; i++)
{
    
        Console.WriteLine("\nSong #{0}", index);
        Console.Write("Title: ");
        t = Console.ReadLine();
        Console.Write("Artist: ");
        a = Console.ReadLine();
    try
    {
        Console.Write("Duration (minutes): ");
        d = Convert.ToDouble(Console.ReadLine());
    }
    catch (FormatException ex)
    {
        d = 0;
    }

    if (string.IsNullOrWhiteSpace(t) && string.IsNullOrWhiteSpace(t)) { 
        Song song = new Song();
        playlist[i] = song;
        index++;
        continue;
    }
    else
    {
        Song song = new Song(t, a, d);
        playlist[i] = song;
        index++;
    }
}

double durationTotal = 0;
Console.WriteLine("\n \t\t    ===  ||  MY PLAYLIST ||  === ");
//Console.WriteLine("Title \t\t\tArtist \t\t\tTime");
Console.WriteLine($"{"Title",-30} {"Artist",-30} {"Duration",8:F2}");
Console.WriteLine("-------------------------------------------------------------------------");
foreach (Song song in playlist)
{
    durationTotal += song.getDuration();
    song.DisplaySong();
}

Console.WriteLine("\nTotal Duration: {0:F2} mins", durationTotal);
Console.WriteLine("Average Duration: {0:F2} mins", durationTotal/n);

Console.WriteLine("\nPress Enter to exit...");
Console.ReadLine();

class Song
{
    private string title;
    private string artist;
    private double duration;

    public Song()
    {
        title = "Unknown";
        artist = "Unknown";
        duration = 0;
    }

    public Song(string title, string artist, double duration)
    {
        this.artist = artist;
        this.title = title;
        this.duration = duration;
    }

    public Song(string title, string artist) : this(title, artist, 0)
    {
    }

    public double getDuration()
    {
        return duration;
    }
    public void DisplaySong()
    {
        Console.WriteLine($"{title,-30} {artist,-30} {duration,8:F2}");
    }
}
