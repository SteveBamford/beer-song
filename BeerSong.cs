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
            CheckBeginAndEndValid(begin, end);
            return GetVersesText(begin, end);
        }

        private string GetVersesText(int begin, int end)
        {
            StringBuilder verseBuilder = new StringBuilder();
            for (int index = begin; index >= end; index--)
            {
                GetVerseText(begin, verseBuilder, index);
            }
            return verseBuilder.ToString();
        }

        private void GetVerseText(int begin, StringBuilder verseBuilder, int index)
        {
            if (index != begin)
                verseBuilder.Append("\n");
            verseBuilder.Append(Verse(index));
        }

        private void CheckBeginAndEndValid(int begin, int end)
        {
            if (_indexChecker.AreIndecesInCorrectOrder(begin, end))
                throw new BeerSongException(_indexChecker.GetIndecesNotInCorrectOrderMessage(begin, end));
        }
    }
}