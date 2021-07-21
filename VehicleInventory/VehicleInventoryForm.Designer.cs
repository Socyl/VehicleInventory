
using System.Collections.Generic;

namespace VehicleInventory
{
    partial class VehicleInventoryForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNewVehicle = new System.Windows.Forms.TabPage();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabNewVehicle.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabNewVehicle);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNewVehicle
            // 
            this.tabNewVehicle.Controls.Add(this.resultsTextBox);
            this.tabNewVehicle.Controls.Add(this.addButton);
            this.tabNewVehicle.Controls.Add(this.typeComboBox);
            this.tabNewVehicle.Controls.Add(this.label4);
            this.tabNewVehicle.Controls.Add(this.vinTextBox);
            this.tabNewVehicle.Controls.Add(this.licenseTextBox);
            this.tabNewVehicle.Controls.Add(this.label3);
            this.tabNewVehicle.Controls.Add(this.label2);
            this.tabNewVehicle.Controls.Add(this.label1);
            this.tabNewVehicle.Location = new System.Drawing.Point(4, 4);
            this.tabNewVehicle.Name = "tabNewVehicle";
            this.tabNewVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewVehicle.Size = new System.Drawing.Size(336, 417);
            this.tabNewVehicle.TabIndex = 0;
            this.tabNewVehicle.Text = "New Vehicle Form";
            this.tabNewVehicle.UseVisualStyleBackColor = true;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(19, 290);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(299, 81);
            this.resultsTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(112, 235);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 34);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButtonClick);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Sedan",
            "Truck"});
            this.typeComboBox.Location = new System.Drawing.Point(111, 178);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(182, 33);
            this.typeComboBox.TabIndex = 6;
            this.typeComboBox.Text = "Sedan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // vinTextBox
            // 
            this.vinTextBox.Location = new System.Drawing.Point(111, 130);
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.Size = new System.Drawing.Size(150, 31);
            this.vinTextBox.TabIndex = 4;
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.Location = new System.Drawing.Point(111, 92);
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.Size = new System.Drawing.Size(150, 31);
            this.licenseTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "License";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Vehicle Form";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.summaryTextBox);
            this.tabPage2.Controls.Add(this.inventoryListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventory List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Location = new System.Drawing.Point(31, 297);
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.ReadOnly = true;
            this.summaryTextBox.Size = new System.Drawing.Size(269, 100);
            this.summaryTextBox.TabIndex = 1;
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 25;
            this.inventoryListBox.Location = new System.Drawing.Point(31, 19);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(269, 254);
            this.inventoryListBox.TabIndex = 0;
            this.inventoryListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.inventoryListBox_MouseDoubleClick);
            // 
            // VehicleInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "VehicleInventoryForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabNewVehicle.ResumeLayout(false);
            this.tabNewVehicle.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNewVehicle;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vinTextBox;
        private System.Windows.Forms.TextBox licenseTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.ListBox inventoryListBox;

       

    }
}

