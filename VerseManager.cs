using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BeerSong
{
    internal class VerseManager
    {

        private IVerse[] verses;
        private VerseIndexChecker indexChecker;

        public VerseManager()
        {
            this.indexChecker = new VerseIndexChecker();
            PopulateVerseList();
        }

        private void PopulateVerseList()
        {
            this.verses = new VerseListCreator().VerseList().ToArray();
        }

        public IVerse Verse(int verseIndex)
        {
            if (this.indexChecker.IndexIsValid(verseIndex))
                return ValidVerse(verseIndex);
            throw new BeerSongException(this.indexChecker.InvalidIndexMessage(verseIndex));
        }

        private IVerse ValidVerse(int verseIndex)
        {
            return this.verses[verseIndex];
        }
    }
}
