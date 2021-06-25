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
        public string nameObject { get; protected set; }
        public string ownerName { get; protected set; }
        public string dateInLibrary { get; protected set; } //year, month, day
        public Object(string nameObj, string nameOwner, string dateinlibrary)
        {
            nameObject = nameObj;
            ownerName = nameOwner;
            dateInLibrary = dateinlibrary;
        }
    }

    public class Book : Object
    {
        public string Author { get; protected set; }
        public string Illustrator { get; protected set; }
        public string Publisher { get; protected set; } = "";
        public int bornYear { get; protected set; }

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
        public int valueElements { get; protected set; }
        public string company { get; protected set; }

        public Pazzle(string nameObj, string nameOwner, string dateInLibrary, int valueelements, string companY) : base(nameObj, nameOwner, dateInLibrary)
        {
            valueElements = valueelements;
            company = companY;
        }
    }

        public class tableGame : Object
        {
        public string Developer { get; protected set; }
        public string GamePlay { get; protected set; }
        public string valuePeople { get; protected set; }

        public tableGame(string nameObj, string nameOwner, string dateInLibrary, string developer, string gameplay, string valuepeople) : base(nameObj, nameOwner, dateInLibrary)
        {
            Developer = developer;
            GamePlay = gameplay;
            string valuePeople = valuepeople;
        }
    }
}
