using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace RestaurantAppDesktop
{
    public partial class DishForm : Form
    {

        public DishForm()
        {
            InitializeComponent();
        }

        public DishForm(Dishes d)
        {
            InitializeComponent();

            nameTextBox.Text = d.Name;
            descriptionTextBox.Text = d.Description;
            priceTextBox.Text = d.Price.ToString();
            dish = d;
        }

        Dishes dish = null;

        private void addDishCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addDishDoneButton_Click(object sender, EventArgs e)
        {
            
            if (dish == null)
            {
                Dishes addedDish = new Dishes();

                addedDish.Name = nameTextBox.Text;
                addedDish.Description = descriptionTextBox.Text;
                addedDish.Price = Convert.ToDecimal(priceTextBox.Text);

                RequestHelper.makePostRequest("http://localhost:51894/api/dishes", addedDish);
                MessageBox.Show("Dish added");
            }
            else
            {
                Dishes editedDish = dish;

                editedDish.Name = nameTextBox.Text;
                editedDish.Description = descriptionTextBox.Text;
                editedDish.Price = Convert.ToDecimal(priceTextBox.Text);

                RequestHelper.makePutRequest("http://localhost:51894/api/dishes", editedDish);
                MessageBox.Show("Dish edited");
            }

            Close();

        }
    }
}
