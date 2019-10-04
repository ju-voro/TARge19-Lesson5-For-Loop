using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerSong
{
    class Program
    {
        static void Main(string[] args)
        {
            //BEER SONG URL - http://www.99-bottles-of-beer.net/lyrics.html

            for (int i = 99; i > 0; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer. \n Take one down and pass it around, {i-1} bottles of beer on the wall. ");
            }

            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. \n Go to the store and buy some more, 99 bottles of beer on the wall.");
            Console.ReadLine();
        }
    }
}
