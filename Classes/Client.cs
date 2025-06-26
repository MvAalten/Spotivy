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
        if (ActiveUser != null && index >= 0 && index < ActiveUser.Playlists.Count)
        {
            var selected = ActiveUser.Playlists[index];
            Console.WriteLine("Selected playlist: " + selected.Title);
        }
    }
/**
     * Plays currently selected song
     *
     * If song is selected the song plays.
     * The song plays untill the song duration is over
     *
     * If track is finished, playing = false.
     *
     * If function is called upon without a song being given print "No track selected to play.".
     *
     * End of Play Track ticket.
     *
     * Start of View Currently Playing Track Ticket
     *
     * Print song data for song if its a single song
     *
     * Print song data if it's in a playlist.
 */
public void Play()
{
    if (CurrentlyPlaying != null)
    {
        Playing = true;

        // Plays a song from Song.
        if (CurrentlyPlaying is Song song)
        {
            // For single songs.
            Console.WriteLine($"Title: {song.Title}");
            Console.WriteLine($"Artist: {song.Artists}");
            Console.WriteLine($"Duration: {song.Length} seconds");
            
            int songLength = song.Length;
            CurrentTime = 0;

            // The song plays until the song duration is over*
            while (CurrentTime < songLength && Playing)
            {
                // Simulate 1 second of playback
                Thread.Sleep(1000); 
                CurrentTime++;
            }

            // If track is finished, playing = false.
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
            // For playlists.
            for (int i = 0; i < playlist.Playables.Count && Playing; i++)
            {
                var track = playlist.Playables[i];
                if (track is Song playlistSong)
                {
                    Console.WriteLine($"Title: {playlistSong.Title}");
                    Console.WriteLine($"Artist: {playlistSong.Artists}");
                    Console.WriteLine($"Duration: {playlistSong.Length} seconds");
                    
                    int songLength = playlistSong.Length;
                    CurrentTime = 0;

                    while (CurrentTime < songLength && Playing)
                    {
                        // +1 second every second.
                        Thread.Sleep(1000);
                        CurrentTime++;
                    }

                    if (Playing)
                    {
                        Console.WriteLine("Track finished playing.");
                    }
                }
            }

            // If track is finished, playing = false.
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
