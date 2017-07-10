using System;
using System.Text;

namespace BeerSong
{
    public class BeerSong
    {
        private BeerSongIndexChecker _indexChecker;
        private BeerSongVerseManager _verseManager;

        public BeerSong()
        {
            _verseManager = new BeerSongVerseManager();
            _indexChecker = new BeerSongIndexChecker();
        }

        public string Verse(int number)
        {
            return _verseManager.GetVerse(number).Text;
        }

        public string Verses(int begin, int end)
        {
            StringBuilder verseBuilder = new StringBuilder();
            CheckBeginAndEndValid(begin, end);
            for (int index = begin; index <= end; index ++)
            {
                verseBuilder.AppendLine(Verse(index));
            }
            return verseBuilder.ToString();
        }

        private void CheckBeginAndEndValid(int begin, int end)
        {
            if (_indexChecker.AreIndecesInCorrectOrder(begin, end))
                throw new BeerSongException(_indexChecker.GetIndecesNotInCorrectOrderMessage(begin, end));
        }
    }
}