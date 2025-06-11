using Spotivy.Classes;
using System;
using System.Collections.Generic;
// A person can have multiple playlists
public class Person
{
    public string Name { get; }
    public List<Playlist> Playlists { get; }

    public Person(string name)
    {
        Name = name;
        Playlists = new List<Playlist>();
    }

    public string ShowFriends()
    {
        throw new NotImplementedException();
    }

    public string ShowPlaylists()
    {
        throw new NotImplementedException();
    }

public List<Playlist> SelectPlaylists()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
