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

        public string GetVerseText(int index)
        {
            return $"{GetVerseFirstLineText(index)}\n{GetVerseSecondLineText(index)}\n";
        }

        public string GetVerseFirstLineText(int index)
        {
            if (this.indexChecker.IsIndexValid(index))
                if (this.indexChecker.IsIndexGeneric(index))
                    return GetGenericFirstLineText(index);
                else
                    return GetNonGenericFirstLineText(index);
            else
                throw new BeerSongException(this.indexChecker.GetInvalidIndexMessage(index));
        }

        public string GetVerseSecondLineText(int index)
        {
            if (this.indexChecker.IsIndexValid(index))
                if (this.indexChecker.IsIndexGeneric(index))
                    return GetGenericSecondLineText(index);
                else
                    return GetNonGenericSecondLineText(index);
            else
                throw new BeerSongException(this.indexChecker.GetInvalidIndexMessage(index));
        }

        private string GetNonGenericSecondLineText(int index)
        {
            return this.nonGenericLineCreator.GetNonGenericSecondLine(index);
        }

        private string GetGenericSecondLineText(int index)
        {
            return $"Take one down and pass it around, {index - 1} bottles of beer on the wall.";
        }

        private string GetNonGenericFirstLineText(int index)
        {
            return this.nonGenericLineCreator.GetNonGenericFirstLine(index);
        }

        private string GetGenericFirstLineText(int index)
        {
            return $"{index} bottles of beer on the wall, {index} bottles of beer.";
        }
    }
}
