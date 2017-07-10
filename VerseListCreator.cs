using System;
using System.Collections.Generic;

namespace BeerSong
{
    internal class VerseListCreator
    {

        internal IEnumerable<IVerse> VerseList()
        {
            List<IVerse> verseList = new List<IVerse>();

            for (int index = VerseIndexChecker.MINIMUM_VERSE_INDEX; index <= VerseIndexChecker.MAXIMUM_VERSE_INDEX; index++)
            {
                verseList.Add(new Verse(index));
            }
            return verseList;
        }

    }
}