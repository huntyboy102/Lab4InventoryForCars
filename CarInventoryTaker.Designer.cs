
namespace Lab4InventoryForCars
{
    partial class FormCarInventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelNew = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.checkBoxNewStatus = new System.Windows.Forms.CheckBox();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.listViewCarDetails = new System.Windows.Forms.ListView();
            this.columnHeaderNewStatus = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMake = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderModel = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderYear = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMake
            // 
            this.labelMake.Location = new System.Drawing.Point(52, 9);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(39, 15);
            this.labelMake.TabIndex = 0;
            this.labelMake.Text = "&Make:";
            this.labelMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelModel
            // 
            this.labelModel.Location = new System.Drawing.Point(47, 40);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(44, 15);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "M&odel:";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Items.AddRange(new object[] {
            "Tesla",
            "Honda",
            "Subaru",
            "Ford",
            "Mazda",
            "Nissan",
            "Toyota"});
            this.comboBoxMake.Location = new System.Drawing.Point(107, 9);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMake.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxMake, "The ComboBox used to select the make of the car");
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(358, 503);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Closes the program");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExitClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(277, 503);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Resets the program");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonResetClick);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(196, 503);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 10;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Adds car to list viewer");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnterClick);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(107, 100);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 23);
            this.textBoxPrice.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxPrice, "The price of the car");
            // 
            // labelYear
            // 
            this.labelYear.Location = new System.Drawing.Point(59, 73);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 15);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "&Year:";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(55, 103);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 15);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "&Price:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNew
            // 
            this.labelNew.Location = new System.Drawing.Point(57, 132);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(34, 15);
            this.labelNew.TabIndex = 8;
            this.labelNew.Text = "&New:";
            this.labelNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(107, 40);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(121, 23);
            this.textBoxModel.TabIndex = 3;
            // 
            // checkBoxNewStatus
            // 
            this.checkBoxNewStatus.AutoSize = true;
            this.checkBoxNewStatus.Location = new System.Drawing.Point(107, 133);
            this.checkBoxNewStatus.Name = "checkBoxNewStatus";
            this.checkBoxNewStatus.Size = new System.Drawing.Size(103, 19);
            this.checkBoxNewStatus.TabIndex = 9;
            this.checkBoxNewStatus.Text = "Is the car new?";
            this.checkBoxNewStatus.UseVisualStyleBackColor = true;
            // 
            // textBoxResults
            // 
            this.textBoxResults.Enabled = false;
            this.textBoxResults.Location = new System.Drawing.Point(3, 363);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.Size = new System.Drawing.Size(430, 134);
            this.textBoxResults.TabIndex = 7;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(107, 71);
            this.numericUpDownYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1921,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.ReadOnly = true;
            this.numericUpDownYear.Size = new System.Drawing.Size(121, 23);
            this.numericUpDownYear.TabIndex = 13;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // listViewCarDetails
            // 
            this.listViewCarDetails.CheckBoxes = true;
            this.listViewCarDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNewStatus,
            this.columnHeaderID,
            this.columnHeaderMake,
            this.columnHeaderModel,
            this.columnHeaderYear,
            this.columnHeaderPrice});
            this.listViewCarDetails.FullRowSelect = true;
            this.listViewCarDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCarDetails.HideSelection = false;
            this.listViewCarDetails.Location = new System.Drawing.Point(3, 171);
            this.listViewCarDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewCarDetails.MultiSelect = false;
            this.listViewCarDetails.Name = "listViewCarDetails";
            this.listViewCarDetails.Size = new System.Drawing.Size(430, 186);
            this.listViewCarDetails.TabIndex = 14;
            this.listViewCarDetails.UseCompatibleStateImageBehavior = false;
            this.listViewCarDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNewStatus
            // 
            this.columnHeaderNewStatus.Text = "New";
            this.columnHeaderNewStatus.Width = 70;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 70;
            // 
            // columnHeaderMake
            // 
            this.columnHeaderMake.Text = "Make";
            this.columnHeaderMake.Width = 70;
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.Text = "Model";
            this.columnHeaderModel.Width = 70;
            // 
            // columnHeaderYear
            // 
            this.columnHeaderYear.Text = "Year";
            this.columnHeaderYear.Width = 70;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 70;
            // 
            // FormCarInventory
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(436, 538);
            this.Controls.Add(this.listViewCarDetails);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.checkBoxNewStatus);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelNew);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.comboBoxMake);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMake);
            this.Name = "FormCarInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.CheckBox checkBoxNewStatus;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.ListView listViewCarDetails;
        private System.Windows.Forms.ColumnHeader columnHeaderNewStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderMake;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.ColumnHeader columnHeaderYear;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
    }
}

