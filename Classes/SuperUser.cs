using Spotivy.Classes;
using System;

public class SuperUser : Person
{
    public SuperUser(string name)
        : base(name)
    {
        throw new NotImplementedException();
    }

    public void AddFriend(Person p)
    {
        throw new NotImplementedException();
    }

    public void RemoveFriend(Person p)
    {
        throw new NotImplementedException();
    }

    public Playlist CreatePlaylist(string name)
    {
        throw new NotImplementedException();
    }

    public void RemovePlaylist(int index)
    {
        throw new NotImplementedException();
    }

    public void AddToPlaylist(int index, IPlayable playable)
    {
        throw new NotImplementedException();
    }

    public void RemoveFromPlaylist(int index, IPlayable playable)
    {
        throw new NotImplementedException();
    }
}
