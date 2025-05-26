using System;
using System.Collections.Generic;

public class Artist
{
    public string Naam { get; private set; }

    public List<Album> Albums { get; private set; }

    public List<Song> Songs { get; private set; }

    public Artist(string naam, List<Album> albums)
    {
        throw new NotImplementedException();
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
