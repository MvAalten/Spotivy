using System;
using System.Collections.Generic;

public class Artist
{
    public string Naam { get; private set; }
    public List<Album> Albums { get; private set; }
    public List<Song> Songs { get; private set; }

    /**
     * Creates a new Artist with the specified name and a list of albums.
     */
    public Artist(string naam, List<Album> albums)
    {
        Naam = naam;
        Albums = albums;
        Songs = new List<Song>();
    }

    public void AddSong(Song song)
    {
        throw new NotImplementedException();
    }

    public void AddAlbum(Album album)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
