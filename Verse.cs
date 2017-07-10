using System;
using System.Collections.Generic;
using System.Text;

namespace BeerSong
{
    internal class Verse : IVerse
    {
        public Verse(int verseIndex)
        {
            Index = verseIndex;
            CreateText(verseIndex);
        }

        public int Index { get; private set; }
        public string Text { get; private set; }

        private void CreateText(int verseIndex)
        {
            var textCreator = new VerseTextCreator();
            Text = textCreator.VerseLines(verseIndex);
        }
    }
}
