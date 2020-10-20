using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2
{
    class Inventory
    {
        // declare fields
        private string itemCategory;
        private string itemGenre;
        private string itemName;
        private string itemArtist;
        private decimal itemPrice;
        private int itemQuantity;

        // item category
        public string Category
        {
            get { return itemCategory; }
            set { itemCategory = value; }
        }

        // item genre (if applicable)
        public string Genre
        {
            get { return itemGenre; }
            set { itemGenre = value; }
        }

        // item name
        public string Name
        {
            get { return itemName; }
            set { itemName = value; }
        }

        // item artist
        public string Artist
        {
            get { return itemArtist; }
            set { itemArtist = value; }
        }

        // item price
        public decimal Price
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        // item quantity
        public int Quantity
        {
            get { return itemQuantity; }
            set { itemQuantity = Quantity; }
        }


        // blank constructor
        public Inventory()
        {
            itemCategory = "None";
            itemGenre = "None";
            itemName = "None";
            itemArtist = "None";
            itemPrice = 0.00m;
            itemQuantity = 0;
        }

        // constructor with info
        public Inventory(string itemCategory, string itemGenre, string itemName, string itemArtist, decimal itemPrice, int itemQuantity)
        {
            this.itemCategory = itemCategory;
            this.itemGenre = itemGenre;
            this.itemName = itemName;
            this.itemArtist = itemArtist;
            this.itemPrice = itemPrice;
            this.itemQuantity = itemQuantity;
        }
    }
}
