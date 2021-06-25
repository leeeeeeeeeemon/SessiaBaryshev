using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessiaBaryshev
{
    class Object
    {
        public string nameObject;
        public string ownerName;
        public DateTime dateInLibrary; //year, month, day
    }

        class Book : Object
        {
            public string Author;
            public string Illustrator;
            public string Publisher;
            public int bornYear;
        }

        class Puzzle : Object
        {
            public int valueElements;
            public string company;
        }

        class tableGame : Object
        {
            public string developer;
            public string gameplay;
            public string valuePeople;
        }
}
