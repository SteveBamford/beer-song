using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BeerSong
{
    internal class VerseManager
    {

        private IVerse[] _verses;
        private VerseIndexChecker _indexChecker;

        public VerseManager()
        {
            _indexChecker = new VerseIndexChecker();
            PopulateVerseList();
        }

        private void PopulateVerseList()
        {
            _verses = new VerseListCreator().GetVerseList().ToArray();
        }

        public IVerse GetVerse(int verseIndex)
        {
            if (_indexChecker.IsIndexValid(verseIndex))
                return GetValidVerse(verseIndex);
            throw new BeerSongException(_indexChecker.GetInvalidIndexMessage(verseIndex));
        }

        private IVerse GetValidVerse(int verseIndex)
        {
            return _verses[verseIndex];
        }
    }
}
