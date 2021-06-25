using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SessiaBaryshev;

namespace SessiaBaryshev
{
    public class Object
    {
        public string nameObject { get; set; }
        public string ownerName { get; set; }
        public string dateInLibrary { get; set; } //year, month, day
        public Object(string nameObj, string nameOwner, string dateinlibrary)
        {
            nameObject = nameObj;
            ownerName = nameOwner;
            dateInLibrary = dateinlibrary;
        }
    }

    public class Book : Object
    {
        public string Author { get; set;}
        public string Illustrator { get; set; }
        public string Publisher { get; set; } = "";
        public int bornYear { get; set; }

        public Book(string nameObj, string nameOwner, string dateInLibrary, string author, string illustrator, string publisher, int bornyear) : base(nameObj,nameOwner,dateInLibrary)
        {
            Author = author;
            Illustrator = illustrator;
            Publisher = publisher;
            bornYear = bornyear;
        }
        public Book(string nameObj, string nameOwner, string dateInLibrary, string author, string publisher, int bornyear) : base(nameObj, nameOwner, dateInLibrary)
        {
            Author = author;
            Publisher = publisher;
            bornYear = bornyear;
        }

    }

        public class Pazzle : Object
        {
        public int valueElements { get; set; }
        public string company { get; set; }

        public Pazzle(string nameObj, string nameOwner, string dateInLibrary, int valueelements, string company) : base(nameObj, nameOwner, dateInLibrary)
        {

        }
    }

        public class tableGame : Object
        {
        public string Developer { get; set; }
        public string GamePlay { get; set; }
        public string valuePeople { get; set; }

        public tableGame(string nameObj, string nameOwner, string dateInLibrary, string developer, string gameplay, string valuepeople) : base(nameObj, nameOwner, dateInLibrary)
        {
            Developer = developer;
            GamePlay = gameplay;
            string valuePeople = valuepeople;
        }
    }
}
