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
    public partial class Settings_MDI : Form
    {
        public Settings_MDI()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

                Test_Label.Font = new Font(Test_Label.Font.FontFamily, Test_Label.Font.SizeInPoints + (float)numericUpDown1.Value);

        }
    }
}
