using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4InventoryForCars
{
    public partial class FormCarInventory : Form
    {
        public FormCarInventory()
        {
            InitializeComponent();
        }



        private void buttonExitClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
