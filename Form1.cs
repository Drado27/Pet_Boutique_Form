// Programmer: Domenick Rado
// Project: Lab 4-1
// Date: 06/23/2022
// Description: Form for calculating property types
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Add namespace to allow use of Streamwriter class

namespace Lab_4_1
{
    public partial class Form1 : Form
    {
        // Declare class level constants for tax rates and commission rates
        private const decimal STATE_SALES_TAX_RATE = 0.06m;
        private const decimal HILLSBOROUGH_SALES_TAX_RATE = 0.01m;
        private const decimal PASCO_SALES_TAX_RATE = 0m;
        private const decimal POLK_SALES_TAX_RATE = 0.005m;
        private const decimal RESIDENTIAL_COMMISSION_RATE = 0.06m;
        private const decimal COMMERCIAL_COMMISSION_RATE = 0.05m;

        // Declare class level variables for use in calculations of totals
        // NOTE: These declarations are being made at the class level not because
        // the variables are used in multiple methods, but rather, because this method
        // in which they are used (UpdateTotals) will be called multiple times during
        // a program run and it is unnecessary to delcare the same variables repeatedly
        private decimal propertyPrice = 0m;
        private decimal stateSalesTax = 0m;
        private decimal countySalesTax = 0m;
        private decimal commission = 0m;
        private decimal totalPrice = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        // Execute immediately upon program startup
        private void Form1_Load(object sender, EventArgs e)
        {
            // Display current date (reported by system clock) in sale date control
            salesDateMaskedTextbox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Disable save until property price is updated with value greater than zero
            saveButton.Enabled = false;
        }

        // Handle residential radio button's checked changed event
        // NOTE: Onle ONE radio button in this TWO-BUTTON radio button group
        // has to have its checkedchanged event handled (because wheneever
        // one button is checked, the other becomes unchcked; thus,
        // whenever either button is selected, this event handler runs)
        private void residentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // Call custom method to update calculated totals
        }

        // Handle Hillsborough radio button's checked changed event
        // NOTE: Only TWO radio buttons in this THREE-BUTTON radio button group
        // have to have their checkedchanged events handled (because whenever
        // one button is checked, the two other are unchecked; thus,
        // all three buttons can be accounted for with two button event handlers)
        private void hillsboroughRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // Call custom method to calculate totals
        }

        // Handle Pasco radio button's checked changed event
        // NOTE: Only TWO radio buttons in this THREE-BUTTON radio group
        // have to have their checkedchanged events handled (because whenever
        // one button is checked, the two other are unchecked; thus,
        // all three buttons can be accounted for with two button event handlers)
        private void pascoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // Call custom method to calculated totals
        }

        // Handle Property Price text box's text changed event
        // NOTE: This event handler runs each time the text in the text box is changed
        // (This event is not covered in textbook)
        private void propertyPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = false;  // Disable save button ( untile updatetotals method runs)
        }




        // Custom method to calculate total fields
        private void UpdateTotals()
        {
            // Read the price of the property entered by user
            // (TryParse method is used to handle null or non-numeric values)
            if (decimal.TryParse(propertyPriceTextbox.Text, out propertyPrice))
            {
                // Set property price variable equal to text property of text box
                propertyPrice = decimal.Parse(propertyPriceTextbox.Text);

                // Calculate state sales tax amount
                stateSalesTax = propertyPrice * STATE_SALES_TAX_RATE;

                // Calculate county sales tax amount based on county selected
                if (hillsboroughRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * HILLSBOROUGH_SALES_TAX_RATE;
                }
                else if (pascoRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * PASCO_SALES_TAX_RATE;
                }
                else if (polkRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * POLK_SALES_TAX_RATE;
                }

                // Calculate commission based on property type
                if (residentialRadioButton.Checked)
                {
                    commission = propertyPrice * RESIDENTIAL_COMMISSION_RATE;
                }
                else
                {
                    commission = propertyPrice * COMMERCIAL_COMMISSION_RATE;
                }

                // Calculate total price
                totalPrice = propertyPrice + stateSalesTax + countySalesTax + commission;

                // Format and display calculated numeric values with currency format
                stateTaxOutputLabel.Text = stateSalesTax.ToString("c");
                countyTaxOutputLabel.Text = countySalesTax.ToString("c");
                commissionOutputLabel.Text = commission.ToString("c");
                totalPriceOutputLabel.Text = totalPrice.ToString("c");

                if (propertyPrice > 0) // Verify that a price greater than zero has been entered
                {
                    saveButton.Enabled = true;
                }
            }
            else // If null or non-numeric value is entered for property price
            {
                MessageBox.Show("You must enter a numeric value for Property Price." +
                    "/nEnter digits only (no dollar sign) for Property Price.",
                    "Blank Value or Non-Numeric Character Entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                propertyPriceTextbox.Focus(); // Send focus to property price text box for correct
            }
        }

        // Custom method to clear form
        private void ClearForm()
        {
            // Clear controls and reset form to original state
            salesDateMaskedTextbox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            residentialRadioButton.Checked = true;
            hillsboroughRadioButton.Checked = true;
            propertyPriceTextbox.Text = "0.00";
            stateTaxOutputLabel.Text = "$0.00";
            countyTaxOutputLabel.Text = "$0.00";
            commissionOutputLabel.Text = "$0.00";
            totalPriceOutputLabel.Text = "$0.00";
            saveButton.Enabled = false; // Disable save button untl UpdateTotals method runs)
            propertyPriceTextbox.Focus(); // Send focus to property price text box
        }

        // Handle clear button's click event
        private void clearButton_Click_1(object sender, EventArgs e)
        {
            ClearForm(); // Call custom method to clear form
        }


        // Handle exit button's click event
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Call custom method to close form
        }
        // Handle Update Property Price button's click event
        private void updatePropertyPriceButton_Click_1(object sender, EventArgs e)
        {
            UpdateTotals(); // Call custom method to update calculated totals
            saveButton.Focus(); // Send focus to save button
        }
        // Handle Save button's click event
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            try // Write data to external text file
            {
                StreamWriter outputFile; // Declare Streamwriter object for use in writing file
                outputFile = File.AppendText("properties.txt"); // Specify file to write to
                // Write all data to file
                outputFile.WriteLine("Date: " + salesDateMaskedTextbox.Text);
                outputFile.WriteLine("Property Price: " + propertyPrice.ToString("c"));
                outputFile.WriteLine("State Sales Tax: " + stateSalesTax.ToString("c"));
                outputFile.WriteLine("County Sales Tax: " + countySalesTax.ToString("c"));
                outputFile.WriteLine("Commission: " + commission.ToString("c"));
                outputFile.WriteLine("Total Price: " + totalPrice.ToString("c"));
                outputFile.WriteLine(); // Write a blank line to file (to seperate properties)
                outputFile.Close(); // Close output file after writing data

                MessageBox.Show("Data successfully saved to file.", "Confirmation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); // Display confirmation message

                ClearForm(); // Call custom method to clear form
            }
            catch (Exception ex)
            {
                // Display message if error occurs when attempting to write file
                MessageBox.Show(ex.Message);
            }

        }
    }
}
   





      
               

