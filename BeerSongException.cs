using System;
using System.Collections.Generic;
using System.Text;

namespace BeerSong
{
    public class BeerSongException : Exception
    {
        public BeerSongException(string message) : base(message)
        {
        }
    }
}
