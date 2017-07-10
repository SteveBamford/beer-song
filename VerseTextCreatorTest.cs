using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace BeerSong
{
    public class VerseTextCreatorTest
    {
        [Fact]
        public void First_line_of_first_generic_verse()
        {
            int index = 99;
            var expected = $"{index} bottles of beer on the wall, {index} bottles of beer.";
            var sut = new VerseTextCreator();

            Assert.Equal(expected, sut.GetVerseFirstLineText(index));
        }

        [Fact]
        public void Second_line_of_first_generic_verse()
        {
            int index = 99;
            var expected = $"Take one down and pass it around, {index - 1} bottles of beer on the wall.";
            var sut = new VerseTextCreator();

            Assert.Equal(expected, sut.GetVerseSecondLineText(index));
        }

        [Fact]
        public void First_line_of_last_generic_verse()
        {
            int index = 3;
            var expected = $"{index} bottles of beer on the wall, {index} bottles of beer.";
            var sut = new VerseTextCreator();

            Assert.Equal(expected, sut.GetVerseFirstLineText(index));
        }

        [Fact]
        public void Second_line_of_last_generic_verse()
        {
            int index = 3;
            var expected = $"Take one down and pass it around, {index - 1} bottles of beer on the wall.";
            var sut = new VerseTextCreator();

            Assert.Equal(expected, sut.GetVerseSecondLineText(index));
        }

        [Fact]
        public void First_line_of_first_non_generic_verse()
        {
            var expected =
                "2 bottles of beer on the wall, 2 bottles of beer.";
            var sut = new VerseTextCreator();

            Assert.Equal(expected, sut.GetVerseFirstLineText(2));
        }

        [Fact]
        public void Second_line_of_first_non_generic_verse()
        {
            var expected =
                "Take one down and pass it around, 1 bottle of beer on the wall.";
            var sut = new VerseTextCreator();

            Assert.Equal(expected, sut.GetVerseSecondLineText(2));
        }

    }
}
