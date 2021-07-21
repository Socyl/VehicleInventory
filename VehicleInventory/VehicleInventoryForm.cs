using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleInventory
{
    public partial class VehicleInventoryForm : Form
    {

        private List<Vehicle> vehicles = new List<Vehicle>();

     
        public VehicleInventoryForm()
        {
            InitializeComponent();
        }

        private void tabNewVehicle_Click(object sender, EventArgs e)
        {

        }

        private void addButtonClick(object sender, EventArgs e)
        {
            if (typeComboBox.Text == "Sedan")
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = licenseTextBox.Text;
                sedan.VIN = vinTextBox.Text;
                vehicles.Add(sedan);

                //refresh list box
                inventoryListBox.DataSource = null;
                inventoryListBox.DataSource = vehicles;
                resultsTextBox.Text = "Successfully added sedan";
            }
            else if(typeComboBox.Text=="Truck")
            {
                Truck truck = new Truck(vinTextBox.Text, licenseTextBox.Text);
                vehicles.Add(truck);

                //refresh list box
                inventoryListBox.DataSource = null;
                inventoryListBox.DataSource = vehicles;
                resultsTextBox.Text = "Successfully added truck";
            }
        }

        private void inventoryListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vehicle vehicle = (Vehicle)inventoryListBox.SelectedItem;
            summaryTextBox.Text = vehicle.GetDescription();
        }
    }
}
