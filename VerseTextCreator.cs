using System;
using System.Collections.Generic;
using System.Text;

namespace BeerSong
{
    internal class VerseTextCreator
    {
        private VerseIndexChecker indexChecker;
        private VerseNonGenericLineCreator nonGenericLineCreator;

        public VerseTextCreator()
        {
            this.indexChecker = new VerseIndexChecker();
            this.nonGenericLineCreator = new VerseNonGenericLineCreator();
        }

        public string VerseLines(int index)
        {
            return $"{VerseFirstLine(index)}\n{VerseSecondLine(index)}\n";
        }

        public string VerseFirstLine(int index)
        {
            if (this.indexChecker.IndexIsValid(index))
                if (this.indexChecker.IndexIsForAGenericVerse(index))
                    return GenericVerseFirstLine(index);
                else
                    return NonGenericVerseFirstLine(index);
            else
                throw new BeerSongException(this.indexChecker.InvalidIndexMessage(index));
        }

        public string VerseSecondLine(int index)
        {
            if (this.indexChecker.IndexIsValid(index))
                if (this.indexChecker.IndexIsForAGenericVerse(index))
                    return GenericVerseSecondLine(index);
                else
                    return NonGenericVerseSecondLine(index);
            else
                throw new BeerSongException(this.indexChecker.InvalidIndexMessage(index));
        }

        private string NonGenericVerseSecondLine(int index)
        {
            return this.nonGenericLineCreator.NonGenericVerseSecondLine(index);
        }

        private string GenericVerseSecondLine(int index)
        {
            return $"Take one down and pass it around, {index - 1} bottles of beer on the wall.";
        }

        private string NonGenericVerseFirstLine(int index)
        {
            return this.nonGenericLineCreator.NonGenericVerseFirstLine(index);
        }

        private string GenericVerseFirstLine(int index)
        {
            return $"{index} bottles of beer on the wall, {index} bottles of beer.";
        }
    }
}
