using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tohfa
{
    public partial class OrderForProduct : Form
    {
        int codeNumber = 0;
        
        //connection string
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd;
        DataTable dataTable;

        public OrderForProduct()
        {
            InitializeComponent();
            textBoxDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
            fillComboBoxAgent();
            fillComboBoxProduct();
            loadDataIntoGridView1();
        }

        private void fillComboBoxAgent()
        {
            string query = "select name from Agent";
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;

            SqlDataReader sqlReader;
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Close();
                    con.Open();
                }
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    string col = sqlReader["name"].ToString();
                    comboBoxAgent.Items.Add(col);
                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void fillComboBoxProduct()
        {
            string query = "select name from Product";
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;

            SqlDataReader sqlReader;
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Close();
                    con.Open();
                }
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    string col = sqlReader["name"].ToString();
                    comboBoxProduct.Items.Add(col);
                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM OrderForProduct";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable;
                dataGridView1.DataSource = bSource;
                adapter.Update(dataTable);
                con.Close();

                resizeGridView1();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView1

        private void resizeGridView1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "كود";
            dataGridView1.Columns[2].HeaderText = "عميل";
            dataGridView1.Columns[3].HeaderText = "المنتج";
            dataGridView1.Columns[4].HeaderText = "الخامة";
            dataGridView1.Columns[5].HeaderText = "السماكة";
            dataGridView1.Columns[6].HeaderText = "اللون";
            dataGridView1.Columns[7].HeaderText = "وقت الماكينة";
            dataGridView1.Columns[8].HeaderText = "السعر";
            dataGridView1.Columns[9].HeaderText = "التاريخ";

            dataGridView1.Columns[0].Visible = false;



        }//end resizeGridView1

        private void buttonNew_OrEmp_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            clearFields();
            createNewCode();
        }

        private void createNewCode()
        {
            string newCode;

            Regex re = new Regex(@"\d+");
            Match m = re.Match(getLastCode());

            if (m.Success)
            {
                codeNumber = int.Parse(m.Value);
                codeNumber += 1;
            }
            else
            {
                MessageBox.Show("You didn't enter a string containing a number!");
            }
            newCode = "OP" + codeNumber;
            textBoxCode.Text = newCode;
        }

        private string getLastCode()
        {
            if (isHasRows())
            {
                con.Open();
                string sqlquery = "SELECT TOP 1 code FROM OrderForProduct ORDER BY id DESC";
                SqlCommand command = new SqlCommand(sqlquery, con);
                string value = command.ExecuteScalar().ToString();
                con.Close();
                return value;
            }
            else
            {
                return "OP0";

            }
        }

        private bool isHasRows()
        {
            con.Open();
            string sqlquery = "SELECT * FROM OrderForProduct";
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        private void buttonAdd_OrEmp_Click(object sender, EventArgs e)
        {
            insertIntoDB();
            loadDataIntoGridView1();
            clearFields();
        }

        private void clearFields()
        {
            textBoxCode.Clear();
            comboBoxAgent.SelectedIndex = -1;
            comboBoxProduct.SelectedIndex = -1;
            textBoxRawKind.Clear();
            textBoxThickness.Clear();
            textBoxColor.Clear();
            textBoxTime.Clear();
            textBoxPrice.Clear();
        }

        private void insertIntoDB()
        {
            
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO OrderForProduct VALUES(@code, @agent, @product, @rawKind," +
                    " @thickness, @color, @time, @price, @date)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@agent", comboBoxAgent.Text);
                cmd.Parameters.AddWithValue("@product", comboBoxProduct.Text);
                cmd.Parameters.AddWithValue("@rawKind", textBoxRawKind.Text);
                cmd.Parameters.AddWithValue("@Thickness", textBoxThickness.Text);
                cmd.Parameters.AddWithValue("@color", textBoxColor.Text);
                cmd.Parameters.AddWithValue("@time", textBoxTime.Text);
                cmd.Parameters.AddWithValue("@price", textBoxPrice.Text);
                cmd.Parameters.AddWithValue("@date", textBoxDate.Text);
                
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = comboBoxProduct.Text;
            getProductValues(value);
            string kind = textBoxRawKind.Text;
            getRawMaterialValue(kind);
        }
        
         private void getRawMaterialValue(string value)
         {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT thickness,kind FROM RawMaterial WHERE name=@name";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", value);

            SqlDataReader oReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(oReader);

            foreach (DataRow row in dt.Rows)
            {
                textBoxThickness.Text = row["thickness"].ToString();
                textBoxRawKind.Text = row["kind"].ToString();
            }
            con.Close();
        }

        private void getProductValues(string value)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT color, time, totalPrice ,rawMaterial FROM Product WHERE name=@name";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name",value);

            SqlDataReader oReader = cmd.ExecuteReader();
           
            DataTable dt = new DataTable();
            dt.Load(oReader);

            foreach (DataRow row in dt.Rows)
            {
                textBoxColor.Text = row["color"].ToString();
                textBoxTime.Text = row["time"].ToString();
                textBoxPrice.Text = row["totalPrice"].ToString();
                getRawMaterialValue(row["rawMaterial"].ToString());
            }
            con.Close();
        }

        private void buttonDelete_OrEmp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string value;
                int i = dataGridView1.CurrentCell.RowIndex;
                value = dataGridView1.Rows[i].Cells[1].Value.ToString(); //get code

                deleteRecordFromDatabase(value);

                loadDataIntoGridView1();
            }
            else
                MessageBox.Show("اختر طلب للمسح");
        }

        private void deleteRecordFromDatabase(string value)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "DELETE FROM OrderForProduct WHERE code = @code";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", value);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void buttonLoad_OrEmp_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
            MessageBox.Show("done");
        }
    }
}
