using System;
using System.Collections.Generic;

namespace dz7
{
    // это вот я задание с песня пыталась сделать, пока не убрала методы, был вот такой кошмар, за час я так и не разобралась, что ему не нравится(((
      
    public class Song
    {
        private string name;
        private string author;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Author
        {
            get => author;
            set => author = value;
        }
        Song prev;
        public void SetName(string songName);
        { 
            name=songName;
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
        public override bool Equals(Song otherSong)
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
