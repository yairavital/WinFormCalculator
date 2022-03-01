using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTirgul
{
    internal class Book
    {
        private string Chapter { get; set; }    
        private string Author { get; set; }
        private string [] Pages { get; set; }

        public Book(string chapter, string author)
        {
            Chapter = chapter;
            Author = author;
        }
        public string this[int index]
        {
            get
            {
                return Pages[index];
            }
            set
            {
                if (index <= Pages.Length)
                {
                 
                    Pages[index] = value;

                }
                else
                {
                for(int i = 0; i < Pages.Length; i++)
                    {
                        if (Pages[i] == null)
                            Pages[i] = value;
                    }

                }




            }

            
        }
    }
}
