using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    public class Playlist : SongCollection
    {
        public string Title { get; }
        public Person Owner { get; }
        private List<IPlayable> playables;

        // Constructor to create a new playlist
        public Playlist(Person owner, string title)
        {
            Owner = owner;
            Title = title;
            playables = new List<IPlayable>();
        }

        public void AddPlayable(IPlayable playable)
        {
            playables.Add(playable);
        }

        public void Remove(IPlayable playable)
        {
            playables.Remove(playable);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
