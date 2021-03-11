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

        private void buttonEnterClick(object sender, EventArgs e)
        {
            textBoxResults.Text = String.Empty;

            if (IsCarValid(comboBoxMake.Text, textBoxModel.Text, numericUpDownYear.Value, textBoxPrice.Text))
            {
                Car newCarToAdd = new Car(comboBoxMake.Text, textBoxModel.Text, numericUpDownYear.Value, textBoxPrice.Text, checkBoxNewStatus.Checked);

                if (selectedIndex >= 0)
                {
                    carList[selectedIndex] = newCarToAdd;
                }
                else
                {
                    carList.Add(newCarToAdd);
                }
                PopulateListView(carList);
                SetDefaults();
            }
        }
    }
}
