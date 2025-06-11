using Spotivy.Classes;
using System;
using System.Collections.Generic;

public class Album : SongCollection
{
    public List<Artist> Artists { get; private set; }

    public Album(List<Artist> artists, string title, List<Song> songs)
        : base(title)
    {
        throw new NotImplementedException();
    }

    public string ShowArtists()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
