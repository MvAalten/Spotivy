using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    public class Playlist : SongCollection
    {
        public Person Owner { get; private set; }

        public Playlist(Person owner, string title)
            : base(title)
        {
            throw new NotImplementedException();
        }

        public void Add(IPlayable playable)
        {
            throw new NotImplementedException();
        }

        public void Remove(IPlayable playable)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
