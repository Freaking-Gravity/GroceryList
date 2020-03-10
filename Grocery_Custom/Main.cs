using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Custom
{
    public partial class MDI_Parent : Form
    {
        public MDI_Parent()
        {
            InitializeComponent();
        }
        Grocery_List_MDI grocery_List_MDI;
        Savings_MDI savings_Calc;
        Coupons_MDI coupons;
        Settings_MDI settings;
        private void Open_Menu_Click(object sender, EventArgs e)
        {
            Menu.Visible = true;


        }


        private void Grocery_Button_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            grocery_List_MDI = new Grocery_List_MDI();
            grocery_List_MDI.MdiParent = this;
            grocery_List_MDI.Dock = DockStyle.Fill;
            grocery_List_MDI.grocery = grocery_List_MDI;
            grocery_List_MDI.Show();
            //Hide
            if(coupons != null)
            {
                coupons.Hide();
            }
            if(savings_Calc != null)
            {
                savings_Calc.Hide();
            }
            if (settings != null)
            {
                settings.Hide();
            }


        }

        private void Coupons_Tab_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            coupons = new Coupons_MDI();
            coupons.MdiParent = this;
            coupons.Dock = DockStyle.Fill;
            coupons.Show();
            //Hide
            if (grocery_List_MDI != null)
            {
                grocery_List_MDI.Hide();
            }
            if (savings_Calc != null)
            {
                savings_Calc.Hide();
            }
            if (settings != null)
            {
                settings.Hide();
            }
        }

        private void Savings_Tab_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            savings_Calc = new Savings_MDI();
            savings_Calc.MdiParent = this;
            savings_Calc.Dock = DockStyle.Fill;
            savings_Calc.Show();
            //Hide
            if (grocery_List_MDI != null)
            {
                grocery_List_MDI.Hide();
            }
            if (coupons != null)
            {
                coupons.Hide();
            }
            if (settings != null)
            {
                settings.Hide();
            }

        }

        private void Settings_Tab_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            settings = new Settings_MDI();
            settings.MdiParent = this;
            settings.Dock = DockStyle.Fill;
            settings.Show();
            //Hide
            if (grocery_List_MDI != null)
            {
                grocery_List_MDI.Hide();
            }
            if (coupons != null)
            {
                coupons.Hide();
            }
            if (savings_Calc != null)
            {
                savings_Calc.Hide();
            }


        }

        private void MDI_Parent_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
        }
    }
}
