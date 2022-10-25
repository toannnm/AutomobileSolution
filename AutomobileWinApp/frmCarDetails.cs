using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Repository;


namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; } //False : Insert, True : Update
        public Car CarInfo { get; set; }
        private void lbCarID_Click(object sender, EventArgs e)
        {
        }

        private void lbCarName_Click(object sender, EventArgs e)
        {
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {
        }

        private void lbManufacturer_Click(object sender, EventArgs e)
        {
        }

        private void lbReleaseYear_Click(object sender, EventArgs e)
        {

        }

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 6;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) //Update mode
            {
                //Show car to perform updating
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
            }
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                if (InsertOrUpdate == false)
                {
                    CarRepository.InsertCar(car);
                }
                else
                {
                    CarRepository.UpdateCar(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }//end btnSave_C1ick


        private void cboManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
