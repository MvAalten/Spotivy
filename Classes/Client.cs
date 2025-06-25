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

    /**Add commentMore actions
         * Plays currently selected song
         *
         * If song is selected the song plays.
         * The song plays untill the song duration is over
         *
         * If track is finished, playing = false.
         *
         * If function is called upon without a song being given print "No track selected to play.".
         */
    public void Play()
    {
        if (CurrentlyPlaying != null)
        {
            Playing = true;
            Console.WriteLine($"Now playing: {CurrentlyPlaying}");
            // Plays a song from Song('s)
            if (CurrentlyPlaying is Song song)
            {
                int songLength = song.Length;
                CurrentTime = 0;

                while (CurrentTime < songLength && Playing)
                {
                    // wait 1 second
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
