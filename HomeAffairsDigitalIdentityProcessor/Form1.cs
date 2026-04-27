using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize ComboBox items if not done in Designer
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            // Create the CitizenProfile object
            CitizenProfile profile = new CitizenProfile(
                txtName.Text,
                txtIDNumber.Text,
                cmbCitizenship.SelectedItem?.ToString() ?? "Not Selected"
            );

            // Get the validation message
            string validationStatus = profile.ValidateID();

            // Format the string for the Label
            lblSummary.Text = "--- CITIZEN PROFILE ---" + Environment.NewLine +
                              "Full Name: " + profile.FullName + Environment.NewLine +
                              "ID Number: " + profile.IDNumber + Environment.NewLine +
                              "Calculated Age: " + profile.Age + Environment.NewLine +
                              "Citizenship: " + profile.CitizenshipStatus + Environment.NewLine +
                              "Status: " + validationStatus + Environment.NewLine +
                              "Processed on: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        } // This was the missing bracket that caused the line 46 error!

        private void cmbCitizenship_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValidateID_Click(object sender, EventArgs e)
        {
            // 1. Create the profile object with current text box values
            CitizenProfile profile = new CitizenProfile(
                txtName.Text,
                txtIDNumber.Text,
                cmbCitizenship.SelectedItem?.ToString() ?? "Not Selected"
            );

            // 2. Run the validation logic and show the result in the label
            string result = profile.ValidateID();
            lblSummary.Text = result;

            // Optional: Change color based on result
            if (result.Contains("Successfully"))
            {
                lblSummary.ForeColor = Color.HotPink;
            }
            else
            {
                lblSummary.ForeColor = Color.Red;
            }
        }
    }

    // Move the class outside of the Form class, but keep it in the same namespace
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        public CitizenProfile(string name, string id, string citizenship)
        {
            FullName = name;
            IDNumber = id;
            CitizenshipStatus = citizenship;
            Age = CalculateAge(id);
        }

        private int CalculateAge(string id)
        {
            if (string.IsNullOrEmpty(id) || id.Length < 6) return 0;

            try
            {
                int yearPart = int.Parse(id.Substring(0, 2));
                int month = int.Parse(id.Substring(2, 2));
                int day = int.Parse(id.Substring(4, 2));

                // 2026 logic: 00-26 is 2000s, 27-99 is 1900s
                int fullYear = (yearPart <= 26) ? 2000 + yearPart : 1900 + yearPart;

                DateTime birthDate = new DateTime(fullYear, month, day);
                DateTime today = DateTime.Today;
                int age = today.Year - birthDate.Year;

                if (birthDate > today.AddYears(-age)) age--;
                return age;
            }
            catch { return 0; }
        }

        public string ValidateID()
        {
            if (string.IsNullOrEmpty(IDNumber) || IDNumber.Length != 13)
                return "Invalid: ID must be exactly 13 digits.";

            if (!long.TryParse(IDNumber, out _))
                return "Invalid: ID must be fully numeric.";

            if (Age <= 0)
                return "Invalid: Birth date in ID is invalid or future-dated.";

            return "ID Validated Successfully.";
        }
    }
}