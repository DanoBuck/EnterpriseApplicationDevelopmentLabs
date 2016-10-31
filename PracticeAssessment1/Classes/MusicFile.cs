using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Genre
{
    Pop,
    Rock,
    Dance,
    HipHop,
    Rap,
    Other
}

namespace PracticeAssessment1.Classes
{
    public class MusicFile : MediaFile
    {
        private string title;
        private string artist;
        private Genre genre;

        public string Title { get
            {
            return title;
            }
        }
        public string Artist
        {
            get { return artist; }
        }
        public Genre Genre
        {
            get
            {
                return genre;
            }
        }

        public MusicFile(string artistIn, string titleIn, Genre genreIn) : base("Music File")
        {
            if(artistIn == "" || artistIn == null
               || titleIn == "" || titleIn == null)
            {
                throw new ArgumentException("Values cannot be empty or null");
            }
            else
            {
                //FileName = "Music File";
                title = titleIn;
                artist = artistIn;
                genre = genreIn;
            }
        }

        public MusicFile(string artistIn, string titleIn) : base("Music File")
        {
            if (artistIn == "" || artistIn == null
                || titleIn == "" || titleIn == null)
            {
                throw new ArgumentException("Values cannot be empty or null");
            }
            else {
                title = titleIn;
                artist = artistIn;
                genre = Genre.Other;
            }
        }

        public override string ToString()
        {
            return "File Name: " + FileName + "\nTitle: " + Title + "\nArtist: " + Artist + "\nGenre: " + Genre;
        }
    }
}
