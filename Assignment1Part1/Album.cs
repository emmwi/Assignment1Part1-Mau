
using System;


class Album
{
    private string albumName;
    private string artistName;
    private int numOfTracks; 

    private void AddAlbumInformation()
    {
        Console.Write("What's the name of your favorite album? ");
         albumName = Console.ReadLine();

        Console.Write("What's the name of an artist or band? ");
        artistName = Console.ReadLine();

        Console.Write("How many tracks does your favorite album have? ");
        string trackInput = Console.ReadLine();
        numOfTracks= int.Parse(trackInput);
    }

    private void ReadAlbumInformation() 
    {
        Console.WriteLine($"Album name: {albumName}");
        Console.WriteLine($"Favorite Artist/Band: {artistName}");
        Console.WriteLine($"Number of tracks for album: {numOfTracks}");
        Console.WriteLine($"Enjoy listening!");
    }

    public void Start() 
    {
        AddAlbumInformation();
        ReadAlbumInformation();

    }
}