/*
 * Name: Hunter Lovering
 * Date: 2021-03-14
 * Desc: This program accepts user information about cars, verifies the data and then stores it in a listview.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4InventoryForCars
{
    public partial class FormCarInventory : Form
    {
        // Declare the car list.
        private List<Car> carList = new List<Car>();
        // Declare class level variables.
        private int selectedIndex = -1;


        public FormCarInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the enter button is clicked this with add whatever is in the labels uptop to the listview down below.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnterClick(object sender, EventArgs e)
        {
            // Empty the results textbox.
            textBoxResults.Text = String.Empty;

            // Call the validation method and if the data is valid.
            if (IsCarValid())
            {
                // Create a new car to add using all the given data.
                Car newCarToAdd = new Car(comboBoxMake.Text, textBoxModel.Text, Convert.ToInt32(numericUpDownYear.Value),
                    Convert.ToDecimal(textBoxPrice.Text), checkBoxNewStatus.Checked);

                // If the index selected in greater than or equal to 0.
                if (selectedIndex >= 0)
                {
                    // Add the car information to the car list created at the start of the program at the index of whatever is selected.
                    carList[selectedIndex] = newCarToAdd;
                }
                // If the selected index is less than 0.
                else
                {
                    // Add the car to the list at the first usable index.
                    carList.Add(newCarToAdd);
                }
                // Call the PopulateListView function.
                PopulateListView(carList);
                // Call the reset function.
                SetDefaults();
            }
        }

        /// <summary>
        /// When the reset button is clicked, reset the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// When the exit button is clicked, close the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Set the input part of the form to its original state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetDefaults()
        {
            // Set the comboBoxMake index to -1.
            comboBoxMake.SelectedIndex = -1;
            // Clear all textboxes.
            textBoxModel.Clear();
            textBoxPrice.Clear();
            textBoxResults.Clear();
            // Set the numericUpDown to 2021. Apologies that it is hard wired in.
            numericUpDownYear.Value = 2021;
            // Set the checkbox status to false.
            checkBoxNewStatus.Checked = false;
            // Clear the listview selected items.
            listViewCarDetails.SelectedItems.Clear();
            // Set the default index to -1.
            selectedIndex = -1;

            // Set focus to the comboBox.
            comboBoxMake.Focus();
        }

        /// <summary>
        /// Populate the listview with the car details entered by the user.
        /// </summary>
        /// <param name="carList"></param>
        private void PopulateListView(List<Car> carList)
        {
            // Clear the list view items.
            listViewCarDetails.Items.Clear();

            // For each car in the cars details.
            foreach (Car newCar in carList)
            {
                // Create a new list item.
                ListViewItem carItem = new ListViewItem();

                // Add the new status to the car item.
                carItem.Checked = newCar.NewStatus;

                // Add all car data to the car item.
                carItem.SubItems.Add(Convert.ToString(newCar.Id));
                carItem.SubItems.Add(newCar.Make);
                carItem.SubItems.Add(newCar.Model);
                carItem.SubItems.Add(Convert.ToString(newCar.Year));
                carItem.SubItems.Add(Convert.ToString(newCar.Price));

                // Add all car items to listview.
                listViewCarDetails.Items.Add(carItem);
            }
        }

        /// <summary>
        /// Validate the data inputted by the user.
        /// </summary>
        /// <returns></returns>
        private bool IsCarValid()
        {
            // Declare class level variables.
            bool isValid = true;

            // If the textbox for the car price is empty.
            if (textBoxPrice.Text == String.Empty)
            {
                // Set focus to the price textbox.
                textBoxPrice.Focus();
                // Set is valid to false.
                isValid &= false;
                // Display a message for the user.
                textBoxResults.Text = "Please enter a numeric value in the price textbox.\n";
            }
            // If the textbox for the car model is empty.
            if (textBoxModel.Text == string.Empty)
            {
                // Set focus to the model textbox.
                textBoxModel.Focus();
                // Set is valid to false.
                isValid &= false;
                // Display a message for the user.
                textBoxResults.Text = "Please enter a car model.\n";
            }
            if (comboBoxMake.Text == string.Empty)
            {
                // Set focus to the make combobox.
                comboBoxMake.Focus();
                // Set is valid to false.
                isValid &= false;
                // Display a message for the user.
                textBoxResults.Text = "Please select a brand of car.\n";
            }

            // Return the isValid value.
            return isValid;
        }
    }
}
