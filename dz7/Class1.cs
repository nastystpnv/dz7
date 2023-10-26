using System.Xml.Linq;
using System.Collections.Generic;

namespace tumakov8
{
    public class Song
    {
        string name;
        string author;
        Song prev;
        public void SetName(string songName)
        {
            name = songName;
        }
        public void SetAuthor(string songAuthor)
        {
            author = songAuthor;
        }
        public void SetPreviousSong(Song previousSong)
        {
            prev = previousSong;
        }
        public string Title()
        {
            return $"{name} - {author}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song otherSong = (Song)obj;
            return this.name == otherSong.name && this.author == otherSong.author;

        }

    }
}