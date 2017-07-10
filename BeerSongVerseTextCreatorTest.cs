using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace BeerSong
{
    public class BeerSongVerseTextCreatorTest
    {
        [Fact]
        public void First_line_of_first_generic_verse()
        {
            var expected =
                "99 bottles of beer on the wall, 99 bottles of beer.";
            var sut = new BeerSongVerseTextCreator();

            Assert.Equal(expected, sut.GetVerseFirstLineText(99));
        }

        [Fact]
        public void Second_line_of_first_generic_verse()
        {
            var expected =
                "Take one down and pass it around, 98 bottles of beer on the wall.";
            var sut = new BeerSongVerseTextCreator();

            Assert.Equal(expected, sut.GetVerseSecondLineText(99));
        }
    }
}
