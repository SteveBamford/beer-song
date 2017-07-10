using System;
using System.Collections.Generic;

namespace BeerSong
{
    internal class VerseNonGenericLineCreator
    {
        private Dictionary<int, string> nonGenericFirstLines;
        private Dictionary<int, string> nonGenericSecondLines;

        public VerseNonGenericLineCreator()
        {
            CreateNonGenericFirstLinesDictionary();
            CreateNonGenericSecondLinesDictionary();
        }

        private void CreateNonGenericSecondLinesDictionary()
        {
            this.nonGenericFirstLines = new Dictionary<int, string>();
            this.nonGenericFirstLines.Add(2, "2 bottles of beer on the wall, 2 bottles of beer.");
            this.nonGenericFirstLines.Add(1, "1 bottle of beer on the wall, 1 bottle of beer.");
            this.nonGenericFirstLines.Add(0, "No more bottles of beer on the wall, no more bottles of beer.");
        }

        private void CreateNonGenericFirstLinesDictionary()
        {
            this.nonGenericSecondLines = new Dictionary<int, string>();
            this.nonGenericSecondLines.Add(2, "Take one down and pass it around, 1 bottle of beer on the wall.");
            this.nonGenericSecondLines.Add(1, "Take it down and pass it around, no more bottles of beer on the wall.");
            this.nonGenericSecondLines.Add(0, "Go to the store and buy some more, 99 bottles of beer on the wall.");
        }

        public string NonGenericVerseFirstLine(int index)
        {
            if (this.nonGenericFirstLines.ContainsKey(index))
                return this.nonGenericFirstLines[index];
            throw new BeerSongException($"No non-generic first line defined for index {index}");
        }

        public string NonGenericVerseSecondLine(int index)
        {
            if (this.nonGenericSecondLines.ContainsKey(index))
                return this.nonGenericSecondLines[index];
            throw new BeerSongException($"No non-generic second line defined for index {index}");
        }
    }
}