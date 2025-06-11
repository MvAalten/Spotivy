using System;
using System.Collections.Generic;

public class SongCollection
{
    public string Title { get; private set; }
    public List<IPlayable> Playables { get; private set; }

    public SongCollection(string title)
    {
        Title = title;
        Playables = new List<IPlayable>();
    }
    /** 
    * Adds a playable track (song or album) to the playlist.
    */
    public void AddTrack(IPlayable track)
    {
        Playables.Add(track);
    }
    /** 
    * Returns a formatted string showing all playables in the playlist.
    */
    public string ShowPlayables()
    {
        if (Playables.Count == 0) return "Empty playlist";

        var result = "";
        foreach (var track in Playables)
        {
            result += track.ToString();
        }
        return result;
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
