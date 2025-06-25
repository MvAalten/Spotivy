// File: Person.cs
using Spotivy.Classes;
using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; private set; }

    public List<Person> Friends { get; private set; }

    public List<Playlist> Playlists { get; private set; }

    public Person(string name)
    {
        Name = name;
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
        return Name;
    }
}
