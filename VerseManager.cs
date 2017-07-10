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
            this.verses = new VerseListCreator().GetVerseList().ToArray();
        }

        public IVerse GetVerse(int verseIndex)
        {
            if (this.indexChecker.IsIndexValid(verseIndex))
                return GetValidVerse(verseIndex);
            throw new BeerSongException(this.indexChecker.GetInvalidIndexMessage(verseIndex));
        }

        private IVerse GetValidVerse(int verseIndex)
        {
            return this.verses[verseIndex];
        }
    }
}
