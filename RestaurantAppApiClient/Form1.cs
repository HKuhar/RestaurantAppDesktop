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

namespace RestaurantAppDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Dishes> currentDishesList = null;
        List<Order> currentOrdersList = null;

        ActiveCategory activeCategory;

        private void ordersButton_Click(object sender, EventArgs e) 
        {
            RefreshListBoxWithOrders();
        }

        private void dishesButton_Click(object sender, EventArgs e)
        {
            RefreshListBoxWithDishes();
        }

        private void addDishButton_Click(object sender, EventArgs e)
        {
            DishForm form = new DishForm();
            form.ShowDialog();
            currentDishesList = null;
            RefreshListBoxWithDishes();
        }

        private void deleteDishButton_Click(object sender, EventArgs e)
        {
            RequestHelper.MakeDeleteRequest("http://localhost:51894/api/dishes", GetSelectedDish().Id);
            currentDishesList = null;
            RefreshListBoxWithDishes();
        }

        private void editDishButton_Click(object sender, EventArgs e)
        {
            DishForm form = new DishForm(GetSelectedDish());
            form.ShowDialog();
            currentDishesList = null;
            RefreshListBoxWithDishes();
        }

        private void SetActiveDishesList()
        {
            if (currentDishesList == null)
            {
                string jsonResult = RequestHelper.makeGetRequest("http://localhost:51894/api/dishes");
                currentDishesList = JsonConvert.DeserializeObject<List<Dishes>>(jsonResult);
            }
        }

        private Dishes GetSelectedDish()
        {
            SetActiveDishesList();
            return currentDishesList[ListBox.SelectedIndex];
        }

        private Order GetSelectedOrder()
        {
            SetActiveOrdersList();
            return currentOrdersList[ListBox.SelectedIndex];
        }

        private void SetActiveOrdersList()
        {
            if (currentOrdersList == null)
            {
                string jsonResult = RequestHelper.makeGetRequest("http://localhost:51894/api/orders");
                currentOrdersList = JsonConvert.DeserializeObject<List<Order>>(jsonResult);
            }
        }

        private void RefreshListBoxWithOrders()
        {
            TextBox.Clear();
            ListBox.Items.Clear();

            SetActiveOrdersList();

            foreach (var item in currentOrdersList)
            {
                ListBox.Items.Add($"Id: {item.OrderId} Name: {item.Name}");
            }

            activeCategory = ActiveCategory.ORDERS;
        }

        private void RefreshListBoxWithDishes()
        {
            TextBox.Clear();
            ListBox.Items.Clear();

            SetActiveDishesList();

            foreach (var item in currentDishesList)
            {
                ListBox.Items.Add($"Id: {item.Id} Name: {item.Name}");
            }

            activeCategory = ActiveCategory.DISHES;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox.Clear();
            if (activeCategory == ActiveCategory.DISHES)
            {
                TextBox.Text += GetSelectedDish().ToString();
            }
            else if (activeCategory == ActiveCategory.ORDERS)
            {
                TextBox.Text += GetSelectedOrder().ToString();
            }
        }
    }

    enum ActiveCategory
    {
        ORDERS,
        DISHES
    }
}
