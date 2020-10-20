using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void addButton_Click(object sender, EventArgs e)
        {

            // initialize field variables
            string category;
            string genre;
            string name;
            string artist;
            decimal price;
            int quantity;

            // grab text from form
            category = categoryTextBox.Text;
            genre = genreTextBox.Text;
            name = nameTextBox.Text;
            artist = artistTextBox.Text;
            price = Convert.ToDecimal(priceTextBox.Text);
            quantity = Convert.ToInt32(quantityTextBox.Text);
            Inventory item1 = new Inventory(category, genre, name, artist, price, quantity);
            MessageBox.Show(string.Format("Added {0}, {1}, {2}, {3}, {4}, with quantity of {5}.", item1.Category, item1.Genre, item1.Name, item1.Artist, item1.Price, item1.Quantity));
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
          
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void reorderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
