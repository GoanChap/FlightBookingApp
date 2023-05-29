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
    public partial class BookingSummary : Form
    {
        public BookingSummary()
        {
            InitializeComponent();
        }

        private void BookingSummary_Load(object sender, EventArgs e)
        {
            fullNameLabel.Text = MainForm.FullName;
            departureCityLabel.Text = MainForm.Departure_City;
            destinationCityLabel.Text = MainForm.Destination_City;
            tripDatesLabel.Text = MainForm.Trip_dates;
            docNumLabel.Text = MainForm.Doc_num;
            docExpiryLabel.Text = MainForm.Doc_expiry_date;
            baggageWeightLabel.Text = MainForm.Baggage_Weight.ToString();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
