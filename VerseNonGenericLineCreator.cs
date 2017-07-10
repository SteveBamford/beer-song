using System;
using System.Collections.Generic;

namespace BeerSong
{
    internal class VerseNonGenericLineCreator
    {
        private Dictionary<int, string> _nonGenericFirstLines;
        private Dictionary<int, string> _nonGenericSecondLines;

        public VerseNonGenericLineCreator()
        {
            CreateNonGenericFirstLinesDictionary();
            CreateNonGenericSecondLinesDictionary();
        }

        private void CreateNonGenericSecondLinesDictionary()
        {
            _nonGenericFirstLines = new Dictionary<int, string>();
            _nonGenericFirstLines.Add(2, "2 bottles of beer on the wall, 2 bottles of beer.");
            _nonGenericFirstLines.Add(1, "1 bottle of beer on the wall, 1 bottle of beer.");
            _nonGenericFirstLines.Add(0, "No more bottles of beer on the wall, no more bottles of beer.");
        }

        private void CreateNonGenericFirstLinesDictionary()
        {
            _nonGenericSecondLines = new Dictionary<int, string>();
            _nonGenericSecondLines.Add(2, "Take one down and pass it around, 1 bottle of beer on the wall.");
            _nonGenericSecondLines.Add(1, "Take it down and pass it around, no more bottles of beer on the wall.");
            _nonGenericSecondLines.Add(0, "Go to the store and buy some more, 99 bottles of beer on the wall.");
        }

        public string GetNonGenericFirstLine(int index)
        {
            if (_nonGenericFirstLines.ContainsKey(index))
                return _nonGenericFirstLines[index];
            throw new BeerSongException($"No non-generic first line defined for index {index}");
        }

        public string GetNonGenericSecondLine(int index)
        {
            if (_nonGenericSecondLines.ContainsKey(index))
                return _nonGenericSecondLines[index];
            throw new BeerSongException($"No non-generic second line defined for index {index}");
        }
    }
}