using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Grocery_Custom
{
    public partial class Grocery_List_MDI : Form
    {
       
        // Starting list position
        int x_pos = 55, y_pos = 22;
        decimal grand_Total = 0.00m;
        Grocery_List_MDI grocery_List_MDI;
        List<Grocery_List_Object> list_Memory = new List<Grocery_List_Object>();
        private FileStream inNout;
        private BinaryFormatter formatter = new BinaryFormatter();
        public Grocery_List_MDI()
        {
            InitializeComponent();
        }
       public Grocery_List_MDI grocery
        {
            set
            {
                grocery_List_MDI = value;
            }
        }

        private void Grocery_List_MDI_Load(object sender, EventArgs e)
        {

        }

        private void Add_Item_Button_Click(object sender, EventArgs e)
        {
            Grocery_List_Menu.Visible = false;
            Name_Parse.Clear();
            Price_Parse.Clear();
            PopBoxMKII.Visible = true;

            
        }


        //ADD THE ITEM
        protected void AddItem()
        {
            int index = Controls.OfType<Grocery_List_Object>().ToList().Count + 1;
            CreateItem("list_item" + index, y_pos);
        }

        public string name_box;
        public decimal price_box;
        private void Add_List(object sender, EventArgs e)
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

            AddItem();
            PopBoxMKII.Visible = false;
        }


        private void CreateItem(string id, int location_Y)
        {
            Grocery_List_Object gl = new Grocery_List_Object();

            gl.Location = new Point(x_pos, location_Y);
            gl.Object_ID = id;
            gl.Name = name_box;
            gl.Price = price_box;
            list_Memory.Add(gl);
            Controls.Add(gl);



            y_pos = (y_pos + 22 + 177);
            //Other stuff
            grand_Total += gl.Price + (gl.Price * gl.Tax);
            Grand_Total_Price_Label.Text = $"{grand_Total:C}";

        } //END ADD

        // SAVE AND LOAD
        private void Save_Button_Click(object sender, EventArgs e)
        {
            Grocery_List_Menu.Visible = false;
            MessageBox.Show("Saving...");
           
            inNout = new FileStream("Grocery_List", FileMode.OpenOrCreate, FileAccess.Write);
            foreach (var item in list_Memory)
            {
                Grocery_Memory gm = new Grocery_Memory(item);

                formatter.Serialize(inNout, gm);
            }
            inNout.Close();

        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            Grocery_List_Menu.Visible = false;
            inNout = new FileStream("Grocery_List", FileMode.Open, FileAccess.Read);
            try
            {

                while(inNout.Position != inNout.Length)
                {
                    Grocery_Memory gm = (Grocery_Memory)formatter.Deserialize(inNout);
                    Grocery_List_Object gl = new Grocery_List_Object();
                    gl.Location = new Point(x_pos, y_pos);
                    gl.Object_ID = gm.Object_ID;
                    gl.Name = gm.Item_Name;
                    gl.Price = gm.Price;
                    gl.Item_Quant = gm.Item_Quantity;
                    list_Memory.Add(gl);
                    Controls.Add(gl);
                    //Spot change
                    y_pos = (y_pos + 22 + 177);
                    grand_Total += gl.Price + (gl.Price * gl.Tax);
                    Grand_Total_Price_Label.Text = $"{grand_Total:C}";
                    
                }
                inNout.Close();
            }
            catch(SerializationException)
            {
                MessageBox.Show("There is no list to be loaded from");
            }
            
        } //END SAVE LOAD

        private void Open_List_Tab_Click(object sender, EventArgs e)
        {
            Grocery_List_Menu.Visible = true;
        }

        private void Grocery_List_MDI_Click(object sender, EventArgs e)
        {
            Grocery_List_Menu.Visible = false;
        }




        
        private void Grocery_List_MDI_ControlRemoved(object sender, ControlEventArgs e)
        {
            // Reset Y position value

            grand_Total = 0.0m;
            foreach (Grocery_List_Object grocery in this.Controls.OfType<Grocery_List_Object>())
            {
                y_pos = (y_pos - 199);//199 or 398
                grocery.Location = new Point(x_pos, (y_pos));
                grand_Total += grocery.Price + (grocery.Price * grocery.Tax);
            }
            Grand_Total_Price_Label.Text = $"{grand_Total:C}";

        }


    }
}
