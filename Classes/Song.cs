using System;
using System.Collections.Generic;

public class Song : IPlayable
{
    public string Title { get; private set; }

    public List<Artist> Artists { get; private set; }

    public Genre SongGenre { get; private set; }

    public int Duur { get; private set; }

    public Song(string title, List<Artist> artists, int duur, Genre genre)
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

    public void Next()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

    public int Length
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public override string ToString()
    {
        // When songs are made put the data here to complete View track artist issue
        throw new NotImplementedException();
    }
}
