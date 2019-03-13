using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{
    class Book
    {
        #region private properties
        private byte pId;
        private string pName;
        private string pAuthor;
        #endregion

        #region public properties
        public byte Id
        {
            get
            {
                return pId;
            }
            set
            {
                pId = value;
            }
        }
        public string Name
        {
            get
            {
                return pName;
            }
            set
            {
                pName = value;
            }
        }
        public string Author
        {
            get
            {
                return pAuthor;
            }
            set
            {
                pAuthor = value;
            }
        }
        #endregion

        /// <summary>
        /// used for creating new books
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="id"></param>
        public Book(byte id, string name, string author)
        {
            Id = pId;
            Name = pName;
            Author = pAuthor;
        }
    }
}
