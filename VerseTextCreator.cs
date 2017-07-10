using System;
using System.Collections.Generic;
using System.Text;

namespace BeerSong
{
    internal class VerseTextCreator
    {
        private VerseIndexChecker _indexChecker;
        private VerseNonGenericLineCreator _nonGenericLineCreator;

        public VerseTextCreator()
        {
            _indexChecker = new VerseIndexChecker();
            _nonGenericLineCreator = new VerseNonGenericLineCreator();
        }

        public string GetVerseText(int index)
        {
            return $"{GetVerseFirstLineText(index)}\n{GetVerseSecondLineText(index)}\n";
        }

        public string GetVerseFirstLineText(int index)
        {
            if (_indexChecker.IsIndexValid(index))
                if (_indexChecker.IsIndexGeneric(index))
                    return GetGenericFirstLineText(index);
                else
                    return GetNonGenericFirstLineText(index);
            else
                throw new BeerSongException(_indexChecker.GetInvalidIndexMessage(index));
        }

        public string GetVerseSecondLineText(int index)
        {
            if (_indexChecker.IsIndexValid(index))
                if (_indexChecker.IsIndexGeneric(index))
                    return GetGenericSecondLineText(index);
                else
                    return GetNonGenericSecondLineText(index);
            else
                throw new BeerSongException(_indexChecker.GetInvalidIndexMessage(index));
        }

        private string GetNonGenericSecondLineText(int index)
        {
            return _nonGenericLineCreator.GetNonGenericSecondLine(index);
        }

        private string GetGenericSecondLineText(int index)
        {
            return $"Take one down and pass it around, {index - 1} bottles of beer on the wall.";
        }

        private string GetNonGenericFirstLineText(int index)
        {
            return _nonGenericLineCreator.GetNonGenericFirstLine(index);
        }

        private string GetGenericFirstLineText(int index)
        {
            return $"{index} bottles of beer on the wall, {index} bottles of beer.";
        }
    }
}
