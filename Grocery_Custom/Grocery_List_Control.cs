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
    public partial class Grocery_List_Object : UserControl
    {
        public decimal Tax = 0.073m;
        public decimal Price = 0.00m;
        public string Name = "???";
        public string Object_ID;
        public decimal Item_Quant = 1;
        public Grocery_List_Object()
        {
            InitializeComponent();

        }

        private void Item_Picture_MouseDoubleClick(object sender, MouseEventArgs e) //  Use to change the picture
        {
            DialogResult result;
            OpenFileDialog openFile = new OpenFileDialog();
            result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                Item_Picture.Image = Image.FromFile(openFile.FileName);
            }
            else
            {

            }
        } // End change picture 

        private void Item_Quantity_Control_ValueChanged(object sender, EventArgs e)
        {
            Total_Cost_Label.Text = $"{TotalCalc(Price, Tax, Item_Quantity_Control.Value):C}";
            Item_Quant = Item_Quantity_Control.Value;
        }

        private void Grocery_List_Object_Load(object sender, EventArgs e)
        {
           // Item_Quantity_Control.Value = Item_Quant;
            Item_Name.Text = Name;
            Cost_Label.Text = $"{Price.ToString():C}";
            Total_Cost_Label.Text = $"{TotalCalc(Price, Tax, Item_Quantity_Control.Value):C}";

        }
        public decimal TotalCalc(decimal price, decimal tax, decimal quant)
        {
            decimal total;

            total = price * quant;
            total = total + (total * tax);

            return total;
        }

        private void Item_Delete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
