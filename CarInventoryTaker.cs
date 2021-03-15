using System;
using System.Collections.Generic;
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

        private void buttonEnterClick(object sender, EventArgs e)
        {
            textBoxResults.Text = String.Empty;

            if (IsCarValid())
            {
                Car newCarToAdd = new Car(comboBoxMake.Text, textBoxModel.Text, Convert.ToInt32(numericUpDownYear.Value),
                    Convert.ToDecimal(textBoxPrice.Text), checkBoxNewStatus.Checked);

                if (selectedIndex >= 0)
                {
                    carList[selectedIndex] = newCarToAdd;
                }
                else
                {
                    carList.Add(newCarToAdd);
                }
                PopulateListView(carList);
            }
        }

        private void buttonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void buttonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void CarSelected(object sender, EventArgs e)
        {
            if (listViewCarDetails.Items.Count > 0 && listViewCarDetails.FocusedItem != null)
            {
                comboBoxMake.Text = listViewCarDetails.FocusedItem.SubItems[2].Text;
                textBoxModel.Text = listViewCarDetails.FocusedItem.SubItems[3].Text;
                numericUpDownYear.Value = Convert.ToDecimal(listViewCarDetails.FocusedItem.SubItems[4].Text);
                textBoxPrice.Text = listViewCarDetails.FocusedItem.SubItems[5].Text;
                checkBoxNewStatus.Checked = listViewCarDetails.FocusedItem.Checked;

                selectedIndex = listViewCarDetails.FocusedItem.Index;
            }
            else
            {
                selectedIndex = -1;
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

                isAutomated = true;
                carItem.Checked = newCar.NewStatus;

                carItem.SubItems.Add(Convert.ToString(newCar.Id));
                carItem.SubItems.Add(newCar.Make);
                carItem.SubItems.Add(newCar.Model);
                carItem.SubItems.Add(Convert.ToString(newCar.Year));
                carItem.SubItems.Add(Convert.ToString(newCar.Price));

                listViewCarDetails.Items.Add(carItem);

                isAutomated = false;
            }
        }

        private bool IsCarValid()
        {
            bool isValid = true;

            if (textBoxModel.Text == string.Empty)
            {
                isValid &= false;
                textBoxResults.Text = "Please enter a car model.\n";
            }
            if (comboBoxMake.Text == string.Empty)
            {
                isValid &= false;
                textBoxResults.Text = "Please select a brand of car.\n";
            }

            return isValid;
        }
    }
}
