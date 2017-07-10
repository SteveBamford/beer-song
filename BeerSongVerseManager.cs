using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BeerSong
{
    internal class BeerSongVerseManager
    {

        private IBeerSongVerse[] _verses;
        private BeerSongIndexChecker _indexChecker;

        public BeerSongVerseManager()
        {
            _indexChecker = new BeerSongIndexChecker();
            PopulateVerseList();
        }

        private void PopulateVerseList()
        {
            _verses = new BeerSongVerseCreator().GetVerseList().ToArray();
        }

        public IBeerSongVerse GetVerse(int verseIndex)
        {
            if (_indexChecker.IsIndexValid(verseIndex))
                return GetValidVerse(verseIndex);
            throw new BeerSongException(_indexChecker.GetInvalidIndexMessage(verseIndex));
        }

        private IBeerSongVerse GetValidVerse(int verseIndex)
        {
            return _verses[verseIndex];
        }
    }
}
