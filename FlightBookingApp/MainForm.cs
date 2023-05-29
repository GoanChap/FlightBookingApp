using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingApp
{
    public partial class MainForm : Form
    {
        public static string FullName;
        public static string Destination_City;
        public static string Departure_City;
        public static string Trip_dates;
        public static string Doc_num;
        public static string Doc_expiry_date;
        public static decimal Baggage_Weight;
        public MainForm()
        {
            InitializeComponent();
        }

        private void passportRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var selectedRadioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            //updateLabelsinForm(selectedRadioButton, );
            //create a list to store all labels that get updated and then run them through a fn when need to be updated
            docExpiryDateLabel.Text = docExpiryDateLabel.Text.Replace(docExpiryDateLabel.Text, selectedRadioButton.Text + docExpiryDateLabel.Text.Substring(docExpiryDateLabel.Text.Length - 13));
            docIssueDateLabel.Text = docIssueDateLabel.Text.Replace(docIssueDateLabel.Text, selectedRadioButton.Text + docIssueDateLabel.Text.Substring(docIssueDateLabel.Text.Length - 12));
            travelDocNumberLabel.Text = travelDocNumberLabel.Text.Replace(travelDocNumberLabel.Text, selectedRadioButton.Text + travelDocNumberLabel.Text.Substring(travelDocNumberLabel.Text.Length - 5));
        }

        private void issueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            expiryDateTimePicker.MinDate = issueDateTimePicker.Value;
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            FullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;
            Destination_City = toTextBox.Text;
            Departure_City = fromTextBox.Text;
            Trip_dates = chooseDatesMonthCalendar.SelectionStart.Date.ToString("dd/MM/yyyy") 
                    + " to " + chooseDatesMonthCalendar.SelectionEnd.Date.ToString("dd/MM/yyyy");
            Doc_num = docNumberTextBox.Text;
            Doc_expiry_date = expiryDateTimePicker.Value.Date.ToString("dd/MM/yyyy");
            Baggage_Weight = baggageWeightNumericUpDown.Value;
            this.Hide();
            using (BookingSummary bs = new BookingSummary())
                bs.ShowDialog();
            this.Close();
        }
    }
}
