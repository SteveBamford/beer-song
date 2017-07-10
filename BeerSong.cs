using System;
using System.Text;

namespace BeerSong
{
    public class BeerSong
    {
        private VerseIndexChecker indexChecker;
        private VerseManager verseManager;

        public BeerSong()
        {
            this.verseManager = new VerseManager();
            this.indexChecker = new VerseIndexChecker();
        }

        public string Verse(int number)
        {
            return this.verseManager.Verse(number).Text;
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
            if (this.indexChecker.IndecesAreInTheCorrectOrder(begin, end))
                throw new BeerSongException(this.indexChecker.GetIndecesNotInCorrectOrderMessage(begin, end));
        }
    }
}