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
    public partial class Coupons_MDI : Form
    {
        public Coupons_MDI()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //SEND TO COSTCO
            System.Diagnostics.Process.Start("https://www.costco.com/warehouse-savings.html");
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            //SEND TO SMITHS
            System.Diagnostics.Process.Start("https://www.smithsfoodanddrug.com/cl/coupons/");
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            //SEND TO WALMART
            System.Diagnostics.Process.Start("https://www.walmart.com/store/3789/ogden-ut/coupons");
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            //SEND TO TARGET
            System.Diagnostics.Process.Start("https://www.target.com/");
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            //SEND TO WHOLE FOODS
            System.Diagnostics.Process.Start("https://www.wholefoodsmarket.com/sales-flyer?store-id=10280");
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            //SEND TO ALBERTSONS
            System.Diagnostics.Process.Start("https://coupons.albertsons.com/weeklyad/?s=");
        }

        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            //SEND TO TRADER JOES
            System.Diagnostics.Process.Start("https://www.traderjoes.com/fearless-flyer");
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            //SEND TO PETSMART
            System.Diagnostics.Process.Start("https://www.petsmart.com/sale/?utm_source=bing&utm_medium=search&utm_term=petsmart%20coupons|412|600275|76965841505263&utm_content=General%3ESale%3EExact&utm_campaign=US_Enterprise_Search_Near%3EBrand_PetSmart_DT_nv&utm_source=bing&utm_medium=cpc&utm_campaign=US_Enterprise_Search_Near%3EBrand_PetSmart_DT_nv&utm_term=petsmart%20coupons&utm_content=General%3ESale%3EExact");
        }

        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            //SEND TO FRESH MARKET
            System.Diagnostics.Process.Start("https://freshmarketstores.com/coupons");
        }
    }
}
