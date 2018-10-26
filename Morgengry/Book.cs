using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book
    {
        string ItemId { get; set; }
        string Title { get; set; }
        double Price { get; set; }
        



        public Book(string inItemId, string inTitle, double inPrice)
        {
            ItemId = inItemId;
            Title = inTitle;
            Price = inPrice;
        }
        public Book(string inItemId, string inTitle):
            this(inItemId, inTitle, 0)
        { }
        public Book (string inItemId):
            this(inItemId, "", 0)
        { }

        public override string ToString()
        {
            return ("ItemId: " + ItemId + ", Title: " + Title + ", Price: " + Price);
        }
    }
}
