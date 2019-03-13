using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{
    class Libary
    {
        //the list that will contain all the books
        public List<Book> theLibary = new List<Book>();

        public Stack userLent = new Stack();

        #region Books in Libary
        Book Metro = new Book(1, "Metro 2033", "Dmitry Glukhovsky");
        Book DummyBook = new Book(2, "C# for Dummies", "Some guy named Steve");
        Book TheLastWish = new Book(3, "The Last Wish", "Andrzej Sapkowski");
        Book SwordOfDestiny = new Book(4, "Sword of Destiny", "Andrzej Sapkowski");
        Book BloodOfElves = new Book(5, "Blood of Elves", "Andrzej Sapkowski");
        Book TimeOfContempt = new Book(6, "Time of Contempt", "Andrzej Sapkowski");
        Book BaptismOfFire = new Book(7, "Baptism of Fire", "Andrzej Sapkowski");
        Book TheTowerOfSwallows = new Book(8, "The Tower of Swallows", "Andrzej Sapkowski");
        Book LadyOfTheLake = new Book(9, "Lady of the Lake", "Andrzej Sapkowski");
        Book SeasonOfStorms = new Book(10, "Season of Stroms", "Andrzej Sapkowski");
        #endregion


        /// <summary>
        /// puts the books into theLibary
        /// </summary>
        public Libary()
        {
            theLibary.Add(Metro);
            theLibary.Add(DummyBook);
            theLibary.Add(TheLastWish);
            theLibary.Add(SwordOfDestiny);
            theLibary.Add(BloodOfElves);
            theLibary.Add(TimeOfContempt);
            theLibary.Add(BaptismOfFire);
            theLibary.Add(TheTowerOfSwallows);
            theLibary.Add(LadyOfTheLake);
            theLibary.Add(SeasonOfStorms);
        }

        public void AddToStack(byte input)
        {

            foreach (Book b in theLibary)
            {
                if (b.Id == input)
                {
                    userLent.Push(b);
                    theLibary.Remove(b);
                }
            }


        }

    }
}
