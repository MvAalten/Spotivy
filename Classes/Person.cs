using Spotivy.Classes;
using System;
using System.Collections.Generic;
// A person can have multiple playlists
public class Person
{
    public string Name { get; private set; }

    public List<Person> Friends { get; private set; }

    public List<Playlist> Playlists { get; private set; }

    public Person(string name)
    {
        Name = name;
        Friends = new List<Person>();
        Playlists = new List<Playlist>();    
    }
    /**
     * If you have no friends return
     *
     * If you have friends return friends number with the name
     */
    public string ShowFriends()
    {
        if (Friends.Count == 0)
        {
            return "No friends added yet.";
        }

        string friendsList = "Friends:\n";
        for (int i = 0; i < Friends.Count; i++)
        {
            friendsList += $"{i + 1}. {Friends[i].Name}\n";
        }
        return friendsList;
        
    }

    /**
     * If you have no playlists return
     *
     * If you have playlists return playlist number with the title
     */
    public string ShowPlaylists()
    {
        if (Playlists.Count == 0)
        {
            return "No playlists created yet.";
        }

        string playlistsList = "Playlists:\n";
        for (int i = 0; i < Playlists.Count; i++)
        {
            playlistsList += $"{i + 1}. {Playlists[i].Title}\n";
        }
        return playlistsList;
        
    }

public List<Playlist> SelectPlaylists()
    {
        return Playlists;
    }

    /**
     * returns profile name, Friends count and playlist count.
     */
    public override string ToString()
    {
        return $"Profile: {Name} | Friends: {Friends.Count} | Playlists: {Playlists.Count}";
    }
}
