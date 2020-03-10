using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Custom
{
    public partial class PopBox : UserControl
    {
        public PopBox()
        {
            InitializeComponent();
        }
        int x_pos = 55, y_pos = 22;
        public string name_box;
        public decimal price_box;

        private void confirm_Button_Click(object sender, EventArgs e)
        {
            name_box = Name_Parse.Text;
            try
            {
                price_box = decimal.Parse(Price_Parse.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a numeric price.");
            }
            Visible = false;
            Name_Parse.Clear();
            Price_Parse.Clear();

            AddItem();
        }
        protected void AddItem()
        {
            int index = Controls.OfType<Grocery_List_Object>().ToList().Count + 1;
            CreateItem("list_item" + index, y_pos);
        }


        private void CreateItem(string id, int location_Y)
        {
            Grocery_List_Object gl = new Grocery_List_Object();
            gl.Location = new Point(x_pos, location_Y);
            //gl.Name = id;
            gl.Price = price_box;
            gl.Name = name_box;
            Controls.Add(gl);
            y_pos = (y_pos + 22 + 177);
        }
    }
}
