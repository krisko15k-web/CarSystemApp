using System.Data;
using System.Data.SqlClient;

namespace CarSystemApp
{
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Winner\Documents\CarRentSystemDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillCombo()
        {
            Con.Open();
            string query = "select RegNum from CarTbl where Available = '" + "Yes" + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNum", typeof(string));
            dt.Load(rdr);
            CarRegCb.ValueMember = "RegNum";
            CarRegCb.DataSource = dt;
            Con.Close();
        }
        private void fillCust()
        {
            Con.Open();
            string query = "select CustId from CustTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(rdr);
            CustCb.ValueMember = "CustId";
            CustCb.DataSource = dt;
            Con.Close();
        }
        private void fetchCustName()
        {
            Con.Open();
            string query = "select * from CustTbl where CustId = " + CustCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CustNameTb.Text = dr["CustName"].ToString();
            }
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from RentTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void UpdateOnRent()
        {
            Con.Open();
            string query = "update CarTbl set Available = '" + "No" + "' where RegNum ='" + CarRegCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        private void UpdateOnRentDelete()
        {
            Con.Open();
            string query = "update CarTbl set Available = '" + "Yes" + "' where RegNum ='" + CarRegCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        private void Rent_Load(object sender, EventArgs e)
        {
            fillCombo();
            fillCust();
            populate();
        }

        private void CarRegCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CustCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FeeTb.Text == "")
            {
                MessageBox.Show("Missing Fealds");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into RentTbl values(" + IdTb.Text + ",'" + CarRegCb.SelectedValue.ToString() + "','" + CustNameTb.Text + "','" + FeeTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Rented");
                    Con.Close();
                    UpdateOnRent();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from RentTbl where RentId=" + IdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rent Deleted Successfully");
                    Con.Close();
                    populate();
                    UpdateOnRentDelete();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTb.Text = RentDGV.SelectedRows[0].Cells[0].Value.ToString();
            CarRegCb.SelectedValue = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustNameTb.Text = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
            FeeTb.Text = RentDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FeeTb.Text == "")
            {
                MessageBox.Show("Missing Fealds");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update RentTbl set CustName ='" + CustNameTb.Text + "',RentFee ='" + FeeTb.Text + "' where RentId =" + IdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rent Successfully Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
}
