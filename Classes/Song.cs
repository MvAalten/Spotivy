using System;
using System.Collections.Generic;

public class Song : IPlayable
{
    public string Title { get; private set; }
    public List<Artist> Artists { get; private set; }
    public Genre SongGenre { get; private set; }
    public int Time { get; private set; }
    /**
     * Creates a song with the specified title, artists, duration, and genre.
     */
    public Song(string title, List<Artist> artists, int duur, Genre genre)
    {
        Title = title;
        Artists = artists;
        Time = Time;
        SongGenre = genre;

        foreach (var artist in artists)
        {
            artist.AddSong(this);
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

    public void Next()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
    /**
     * Returns the length of the song.
     */
    public int Length
    {
        get
        {
            return Time;
        }
    }
    /**
     * Returns title, artists, genre, and duration of the song.
     */
    public override string ToString()
    {
        // Gets a list of all artist names andn puts them all into one string diveded by a comma.
        var artistNames = string.Join(", ", Artists.ConvertAll(a => a.Naam));
        return $"{Title} by {artistNames} [{SongGenre}] - {Time}s";
    }
}
