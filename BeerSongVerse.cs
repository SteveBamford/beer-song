using System;
using System.Collections.Generic;
using System.Text;

namespace BeerSong
{
    internal class BeerSongVerse : IBeerSongVerse
    {
        public BeerSongVerse(int verseIndex)
        {
            Index = verseIndex;
            CreateText(verseIndex);
        }

        public int Index { get; private set; }
        public string Text { get; private set; }

        private void CreateText(int verseIndex)
        {
            var textCreator = new BeerSongVerseTextCreator();
            Text = textCreator.GetVerseText(verseIndex);
        }
    }
}
