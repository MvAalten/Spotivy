using System;
using System.Collections.Generic;
public interface iPlayable { }

public class Client
{
    public iPlayable CurrentlyPlaying { get; set; }
    public int CurrentTime { get; set; }
    public bool Playing { get; set; }
    public bool Shuffle { get; set; }
    public bool Repeat { get; set; }
    private SuperUser ActiveUser { get; set; }
    private List<Album> AllAlbums { get; set; }
    private List<Song> AllSongs { get; set; }
    private List<Person> AllUsers { get; set; }

    public Client(List<Person> persons, List<Album> albums, List<Song> songs)
    {
        throw new NotImplementedException();
    }

    public void SetActiveUser(Person person)
    {
        throw new NotImplementedException();
    }

    public void ShowAllAlbums()
    {
        throw new NotImplementedException();
    }

    /**
     * Prints artist of a selected album
     *
     * If there are no artists that are equal to the albums count throw error.
     */
    public void SelectAlbum(int index)
    {
        if (index >= 1 && index <= AllAlbums.Count)
        {
            Album selectedAlbum = AllAlbums[index - 1];
            Console.WriteLine(selectedAlbum.ShowArtists());
        }
        else
        {
            Console.WriteLine("Invalid album selection.");
        }
    }

    public void ShowAllSongs()
    {
        throw new NotImplementedException();
    }

    public void SelectSong(int index)
    {
        throw new NotImplementedException();
    }

    /**
     * For every user print out a user
     */
    public void ShowAllUsers()
    {
        Console.WriteLine("=== ALL USERS ===");
        for (int i = 0; i < AllUsers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {AllUsers[i]}");
        }
    }

     /**
     * Displays a users profile name, friends and playlists based on the given index
     * If the index is invalid, shows an error message.
     */
    public void SelectUser(int index)
    {
        if (index >= 1 && index <= AllUsers.Count)
        {
            Person selectedUser = AllUsers[index - 1];
            Console.WriteLine($"=== USER PROFILE ===");
            Console.WriteLine($"Name: {selectedUser.Name}");
            Console.WriteLine();
            Console.WriteLine(selectedUser.ShowFriends());
            Console.WriteLine();
            Console.WriteLine(selectedUser.ShowPlaylists());
        }
        else
        {
            Console.WriteLine("Invalid user selection.");
        }
    }    

    public void ShowUserPlaylists()
    {
        throw new NotImplementedException();
    }

    public void SelectUserPlaylist(int index)
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        throw new NotImplementedException();
    }

    public void Pause()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

    public void NextSong()
    {
        throw new NotImplementedException();
    }

    public void SetShuffle(bool shuffle)
    {
        throw new NotImplementedException();
    }

    public void SetRepeat(bool repeat)
    {
        throw new NotImplementedException();
    }

    public void CreatePlaylist(string name)
    {
        throw new NotImplementedException();
    }

    public void ShowPlaylists()
    {
        throw new NotImplementedException();
    }

    public void SelectPlaylist(int index)
    {
        throw new NotImplementedException();
    }

    public void RemovePlaylist(int index)
    {
        throw new NotImplementedException();
    }

    public void AddToPlaylist(int index)
    {
        throw new NotImplementedException();
    }

    public void ShowSongsInPlaylist()
    {
        throw new NotImplementedException();
    }

    public void RemoveFromPlaylist(int index)
    {
        throw new NotImplementedException();
    }

    public void ShowFriends()
    {
        throw new NotImplementedException();
    }

    public void SelectFriend(int index)
    {
        throw new NotImplementedException();
    }

    public void AddFriend(int index)
    {
        throw new NotImplementedException();
    }

    public void RemoveFriend(int index)
    {
        throw new NotImplementedException();
    }
}
