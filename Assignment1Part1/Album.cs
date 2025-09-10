
using System;


public class Album
{
    private string albumName;
    private string artistName;
    private int numOfTracks;

    /// <summary>
    /// Method that take input from user¨.
    /// If the variable we want to use doesn't have the same type as input (string) we save it in a new variable that we later pars in to correct type. 
    /// </summary>
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
    //method that reads the input-information back when user has entered all of the information/input needed. 
    private void ReadAlbumInformation() 
    {
        Console.WriteLine($"Album name: {albumName}");
        Console.WriteLine($"Favorite Artist/Band: {artistName}");
        Console.WriteLine($"Number of tracks for album: {numOfTracks}");
        Console.WriteLine($"Enjoy listening!");
    }

    //public method used to start using the class later in main-method. 
    public void Start() 
    {
        AddAlbumInformation();
        ReadAlbumInformation();

    }
}