// File: Person.cs
using Spotivy.Classes;
using System;
using System.Collections.Generic;

public class Person
{
    public string Naam { get; private set; }

    public List<Person> Friends { get; private set; }

    public List<Playlist> Playlists { get; private set; }

    public Person(string naam)
    {
        throw new NotImplementedException();
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
