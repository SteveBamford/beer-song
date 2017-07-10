using System;
using System.Collections.Generic;
using System.Text;

namespace BeerSong
{
    internal class VerseIndexChecker
    {
        internal const int MINIMUM_GENERIC_INDEX = 3;
        internal const int MAXIMUM_GENERIC_INDEX = 99;
        internal const int MINIMUM_VERSE_INDEX = 0;
        internal const int MAXIMUM_VERSE_INDEX = 99;

        internal string GetInvalidIndexMessage(int verseIndex)
        {
            if (!IsIndexValid(verseIndex))
                return $"Invalid verse index {verseIndex} (should be >= {MINIMUM_VERSE_INDEX} and <= {MAXIMUM_VERSE_INDEX})";
            return "";
        }

        internal bool IsIndexValid(int verseIndex)
        {
            return verseIndex >= MINIMUM_VERSE_INDEX && verseIndex <= MAXIMUM_VERSE_INDEX;
        }

        internal bool AreIndecesInCorrectOrder(int begin, int end)
        {
            return begin <= end;
        }

        internal string GetIndecesNotInCorrectOrderMessage(int begin, int end)
        {
            if (!AreIndecesInCorrectOrder(begin, end))
                return $"Verse indexes in wrong order ({begin} must be <= {end})";
            return "";
        }

        internal bool IsIndexGeneric(int verseIndex)
        {
            return verseIndex >= MINIMUM_GENERIC_INDEX && verseIndex <= MAXIMUM_GENERIC_INDEX;
        }

    }
}
