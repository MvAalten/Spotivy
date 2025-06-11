using Spotivy.Classes;
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
        if (person is SuperUser user)
        {
            ActiveUser = user;
        }
    }

    public void ShowAllAlbums()
    {
        throw new NotImplementedException();
    }

    public void SelectAlbum(int index)
    {
        throw new NotImplementedException();
    }

    public void ShowAllSongs()
    {
        throw new NotImplementedException();
    }

    public void SelectSong(int index)
    {
        throw new NotImplementedException();
    }

    public void ShowAllUsers()
    {
        throw new NotImplementedException();
    }

    public void SelectUser(int index)
    {
        throw new NotImplementedException();
    }

    public void ShowUserPlaylists()
    {
        throw new NotImplementedException();
    }

    public void SelectUserPlaylist(int index)
    {
        if (ActiveUser != null && index >= 0 && index < ActiveUser.Playlists.Count)
        {
            var selected = ActiveUser.Playlists[index];
            Console.WriteLine("Selected playlist: " + selected.Title);
        }
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

    public void CreatePlaylist(string title)
    {
        if (ActiveUser != null && !string.IsNullOrWhiteSpace(title))
        {
            var playlist = new Playlist(ActiveUser, title);
            ActiveUser.Playlists.Add(playlist);
        }
    }

    // Show all playlists of the active user
    public void ShowPlaylists()
    {
        ActiveUser?.ShowPlaylists();    
    }

    public void SelectPlaylist(int index)
    {
        throw new NotImplementedException();
    }

    public void RemovePlaylist(int index)
    {
        if (ActiveUser != null && index >= 0 && index < ActiveUser.Playlists.Count)
        {
            ActiveUser.Playlists.RemoveAt(index);
        }
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
