using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainForm : Form
    {
        public List<Car> Cars;

        public MainForm()
        {
            InitializeComponent();
            InitializeData();
            InitializeListView();
            PopulateListView();
        }

        //function to initialize list view
        public void InitializeListView()
        {
            listViewCar.Scrollable = true;
            listViewCar.View = View.Details;
            ColumnHeader header1 = new ColumnHeader();
            ColumnHeader header2 = new ColumnHeader();
            ColumnHeader header3 = new ColumnHeader();
            ColumnHeader header4 = new ColumnHeader();
            ColumnHeader header5 = new ColumnHeader();
            ColumnHeader header6 = new ColumnHeader();
            ColumnHeader header7 = new ColumnHeader();
            header1.Text = "Brand";
            header2.Text = "Model";
            header3.Text = "Color";
            header4.Text = "Reg. Number";
            header5.Text = "Year";
            header6.Text = "Rent Price";
            header7.Text = "Day Rent";
            header1.Name = "col1";
            header2.Name = "col2";
            header3.Name = "col3";
            header4.Name = "col4";
            header5.Name = "col5";
            header6.Name = "col6";
            header7.Name = "col7";
            header1.Width = 75;
            header2.Width = 75;
            header3.Width = 75;
            header4.Width = 75;
            header5.Width = 75;
            header6.Width = 75;
            header7.Width = 75;
            listViewCar.Columns.Add(header1);
            listViewCar.Columns.Add(header2);
            listViewCar.Columns.Add(header3);
            listViewCar.Columns.Add(header4);
            listViewCar.Columns.Add(header5);
            listViewCar.Columns.Add(header6);
            listViewCar.Columns.Add(header7);
        }

        //function to populate and refresh list view
        public void PopulateListView()
        {
            listViewCar.Items.Clear();
            ListViewItem item;
            foreach (Car temp in Cars)
            {
                string[] carData = { temp.Brand, temp.Model, temp.Color, temp.RegistrationNumber, temp.Year.ToString(), temp.Rent.ToString(), temp.DayRent.ToString() };
                item = new ListViewItem(carData);
                if (temp.DayRent > 0)
                {
                    item.BackColor = Color.Yellow;
                    item.ForeColor = Color.Red;
                }
                listViewCar.Items.Add(item);
            }
        }

        //function to add new car information
        public void btnAddCar_Click(object sender, System.EventArgs e)
        {
            FrmCarDetail formCarDetail = new FrmCarDetail();
            if (formCarDetail.ShowDialog(this) == DialogResult.OK)
            {
                Cars.Add(formCarDetail.GetResult());
                PopulateListView();
            }
        }

        //function to edit car information
        public void btnEditCar_Click(object sender, System.EventArgs e)
        {
            if (listViewCar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select car data that want to be edited");
            }
            else
            {
                FrmCarDetail formCarDetail = new FrmCarDetail(Cars[listViewCar.SelectedItems[0].Index]);
                if (formCarDetail.ShowDialog(this) == DialogResult.OK)
                {
                    Cars[listViewCar.SelectedItems[0].Index] = formCarDetail.GetResult();
                    PopulateListView();
                }
            }
        }

        //function to delete car from list
        public void btnDeleteCar_Click(object sender, System.EventArgs e)
        {
            if (listViewCar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select car data that want to be deleted");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure want to delete this data?", "Confirmation", buttons);
                if (result == DialogResult.Yes)
                {
                    Cars.RemoveAt(listViewCar.SelectedItems[0].Index);
                    PopulateListView();
                }
            }
        }

        //function to populate initial data for the list
        public void InitializeData()
        {
            Cars = new List<Car>();
            Cars.Add(new Car("Nissan", "Juke", "Red", "B1234AFL", 2016, 1000000));
            Cars.Add(new Car("Nissan", "Elgrand", "Yellow", "B1235AFL", 2016, 2000000));
            Cars.Add(new Car("Toyota", "Alphard", "Black", "B1LA", 2019, 3000000));
            Cars.Add(new Car("Toyota", "Alphard", "White", "B2LA", 2019, 3000000));
        }

        //function to Rent selected car
        public void btnRentCar_Click(object sender, System.EventArgs e)
        {
            if (listViewCar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select car data that want to be rented");
            }
            else
            {
                FrmCarRent formCarRent = new FrmCarRent();
                if (formCarRent.ShowDialog(this) == DialogResult.OK)
                {
                    Cars[listViewCar.SelectedItems[0].Index].DayRent = formCarRent.SavedDays;
                    PopulateListView();
                }
            }
        }

        //function to cancel selected rented car
        public void btnUnrentCar_Click(object sender, System.EventArgs e)
        {
            if (listViewCar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select car data that want to be unrented");
            }
            else
            {
                Cars[listViewCar.SelectedItems[0].Index].DayRent = 0;
                PopulateListView();
            }
        }

        //function to calculate total rent that needs to be paid
        public void btnCalculateRent_Click(object sender, System.EventArgs e)
        {
            txtTotalRent.Text = CalculateRent().ToString();
        }

        public double CalculateRent()
        {
            double totalRent = 0;
            double singleCarRent = 0;
            foreach (Car temp in Cars.Where(o => o.DayRent > 0))
            {
                singleCarRent = temp.Rent * temp.DayRent;
                if (temp.DayRent >= 3)
                {
                    singleCarRent = singleCarRent * 95 / 100;
                }

                if (temp.Year < 2010)
                {
                    singleCarRent = singleCarRent * 93 / 100;
                }

                totalRent += singleCarRent;
            }

            if (Cars.Where(o => o.DayRent > 0).Count() > 1)
            {
                totalRent = totalRent * 90 / 100;
            }

            return totalRent;
        }
    }
}
