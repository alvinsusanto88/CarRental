using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FrmCarRent : Form
    {
        private int _savedDays;
        public int SavedDays
        {
            get => _savedDays;
            set => _savedDays = value;
        }

        public FrmCarRent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool bCanSave = true;

            //add some validation
            if (!Helper.IsNumeric(txtDays.Text))
            {
                MessageBox.Show("Data should be filled with number");
                bCanSave = false;
            }

            if (bCanSave)
            {
                SavedDays = Convert.ToInt32(txtDays.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
