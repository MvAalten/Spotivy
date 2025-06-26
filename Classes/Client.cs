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
        throw new NotImplementedException();
    }

    public void Play()
    {
        if (CurrentlyPlaying != null)
        {
            Playing = true;
            if (CurrentlyPlaying is Song song)
            {
                Console.WriteLine($"Now playing: {CurrentlyPlaying}");
                int songLength = song.Length;
                CurrentTime = 0;
                while (CurrentTime < songLength && Playing)
                {
                    Thread.Sleep(1000);
                    CurrentTime++;
                }
                if (Playing)
                {
                    Console.WriteLine("Track finished playing.");
                    Playing = false;
                    CurrentTime = 0;
                }
            }
            else if (CurrentlyPlaying is SongCollection playlist)
            {
                Console.WriteLine($"Now playing playlist: {playlist.Title}");
                for (int i = 0; i < playlist.Playables.Count && Playing; i++)
                {
                    var track = playlist.Playables[i];
                    if (track is Song playlistSong)
                    {
                        Console.WriteLine($"Now playing: {playlistSong}");
                        int songLength = playlistSong.Length;
                        CurrentTime = 0;
                        while (CurrentTime < songLength && Playing)
                        {
                            Thread.Sleep(1000);
                            CurrentTime++;
                        }
                        if (Playing)
                        {
                            Console.WriteLine("Track finished playing.");
                        }
                    }
                }
                if (Playing)
                {
                    Console.WriteLine("Playlist finished playing.");
                    Playing = false;
                    CurrentTime = 0;
                }
            }
        }
        else
        {
            Console.WriteLine("No track selected to play.");
        }
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
