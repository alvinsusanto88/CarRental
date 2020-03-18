using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FrmCarDetail : Form
    {
        private Car Result;

        public FrmCarDetail()
        {
            InitializeComponent();
            Result = new Car();
        }

        public FrmCarDetail(Car data)
        {
            InitializeComponent();
            Result = data;
            txtBrand.Text = data.Brand;
            txtModel.Text = data.Model;
            txtColor.Text = data.Color;
            txtRegNumber.Text = data.RegistrationNumber;
            txtYear.Text = data.Year.ToString();
            txtRent.Text = data.Rent.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public Car GetResult()
        {
            return Result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool bCanSave = true;

            //add some validation
            if (!Helper.IsNumeric(txtYear.Text))
            {
                MessageBox.Show("Year should be filled with number");
                bCanSave = false;
            }

            if (!Helper.IsNumeric(txtRent.Text))
            {
                MessageBox.Show("Rent rate should be filled with number");
                bCanSave = false;
            }

            if (bCanSave)
            {
                Result.Brand = txtBrand.Text;
                Result.Model = txtModel.Text;
                Result.Color = txtColor.Text;
                Result.RegistrationNumber = txtRegNumber.Text;
                Result.Year = Convert.ToInt32(txtYear.Text);
                Result.Rent = Convert.ToDouble(txtRent.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
