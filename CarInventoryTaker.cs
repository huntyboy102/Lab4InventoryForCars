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
        private List<Car> carList = new List<Car>();
        private int selectedIndex = -1;
        private bool isAutomated = false;

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

        private void SetDefaults()
        {
            comboBoxMake.SelectedIndex = -1;
            textBoxModel.Clear();
            textBoxPrice.Clear();
            textBoxResults.Clear();
            numericUpDownYear.Value = 2021;
            checkBoxNewStatus.Checked = false;
            listViewCarDetails.SelectedItems.Clear();
            selectedIndex = -1;

            comboBoxMake.Focus();
        }

        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it's being done by the user.
            if (!isAutomated)
            {
                // Change the new value of the checkbox equal to the old state of the checkbox.
                e.NewValue = e.CurrentValue;
            }
        }

        private void PopulateListView(List<Car> carList)
        {
            listViewCarDetails.Items.Clear();

            foreach (Car newCar in carList)
            {
                ListViewItem carItem = new ListViewItem();

                carItem.SubItems.Add(newCar.make);
            }
        }

        private bool IsCarValid(string make, string model, int year, decimal price, bool newStatus)
        {
            bool isValid = true;

            if (make ==)
        }
    }
}
