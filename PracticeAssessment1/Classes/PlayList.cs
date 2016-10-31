using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeAssessment1.Classes
{
    public class PlayList : IEnumerable
    {
        // Auto-Implemented Property
        public string PlayListName { get; set; }

        private List<MusicFile> playList;

        // Read-Only Property
        public List<MusicFile> PlayLists { get { return playList; } }

        public PlayList(string playListName)
        {
            PlayListName = playListName;
            playList = new List<MusicFile>();
        }

        public bool addANewTrack(MusicFile newMusic)
        {
            bool canBeAdded = false;
            if (PlayLists.Count == 0)
            {
                canBeAdded = true;
            }
            else {
                for (int i = 0; i < PlayLists.Count; i++)
                {
                    if (PlayLists[i].Artist == newMusic.Artist && PlayLists[i].Title == newMusic.Title)
                    {
                        canBeAdded = false;
                        throw new ArgumentException("Track is already contained in playlist");
                    }
                    else
                    {
                        canBeAdded = true;
                    }
                }
            }

            if (canBeAdded)
            {
                playList.Add(newMusic);
            }
            return canBeAdded;
        }

        public List<MusicFile> this[Genre genreIn]
        {
            get
            {
                List<MusicFile> genreList = new List<MusicFile>();

                for(int i = 0; i < PlayLists.Count; i++)
                {
                    if(PlayLists[i].Genre == genreIn)
                    {
                        genreList.Add(PlayLists[i]);
                    }
                }
                return genreList;
            }
        }

        // Allows the class to be foreached over
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)playList).GetEnumerator();
        }
    }
}
