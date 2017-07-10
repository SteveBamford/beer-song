using System;
using System.Collections.Generic;

namespace BeerSong
{
    internal class BeerSongVerseCreator
    {

        internal IEnumerable<IBeerSongVerse> GetVerseList()
        {
            List<IBeerSongVerse> verseList = new List<IBeerSongVerse>();

            for (int index = BeerSongIndexChecker.MINIMUM_VERSE_INDEX; index <= BeerSongIndexChecker.MAXIMUM_VERSE_INDEX; index++)
            {
                verseList.Add(new BeerSongVerse(index));
            }
            return verseList;
        }

    }
}