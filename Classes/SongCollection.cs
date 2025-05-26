using System;   
using System.Collections.Generic;

public class SongCollection
{
    public string Title { get; private set; }

    public List<IPlayable> Playables { get; private set; }

    public SongCollection(string title)
    {
        throw new NotImplementedException();
    }

    public string ShowPlayables()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
