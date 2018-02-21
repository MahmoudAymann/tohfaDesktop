using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Tohfa
{
    public partial class Suppliers : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd;
        DataTable dataTable;

        int codeNumber = 0;
        public Suppliers()
        {
            InitializeComponent();
            loadDataIntoGridView1();
        }

       private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Supplier";
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

        }

        private void resizeGridView1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "كود";
            dataGridView1.Columns[2].HeaderText = "الاسم";
            dataGridView1.Columns[3].HeaderText = "رقم";
            dataGridView1.Columns[4].HeaderText = "عنوان";

            dataGridView1.Columns[0].Visible = false;

        }//end resizeGridView1

        private void Suppliers_Load(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
        }

        private void buttonNew_Suppliers_Click(object sender, EventArgs e)
        {
            
            groupBox2.Visible = true;

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
            newCode = "S" + codeNumber;
            textBoxCode.Text = newCode;
        }//end button New

        private string getLastCode()
        {
            if (isHasRows())
            {
                con.Open();
                string sqlquery = "SELECT TOP 1 code FROM Supplier ORDER BY id DESC";
                SqlCommand command = new SqlCommand(sqlquery, con);
                string value = command.ExecuteScalar().ToString();
                con.Close();
                return value;
            }
            else
            {
                MessageBox.Show("is has row false");
                return "S0";
                
            }
        }

        private bool isHasRows()
        {
            con.Open();
            string sqlquery = "SELECT * FROM Supplier";
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

        private void buttonAdd_Suppliers_Click(object sender, EventArgs e)
        {
            insertIntoDB();
            loadDataIntoGridView1();
            clearFields();
        }

        private void clearFields()
        {
            textBoxAddress.Clear();
            textBoxCode.Clear();
            textBoxName.Clear();
            textBoxPhone.Clear();
        }

        private void insertIntoDB()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Supplier (code, name, phone, address) VALUES(@code, @name, @phone, @address)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()

        private void buttonDelete_Suppliers_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string value;
                int i = dataGridView1.CurrentCell.RowIndex;
                value = dataGridView1.Rows[i].Cells[1].Value.ToString(); //get code

                deleteRecordFromDatabase(value);
                MessageBox.Show(value);

                loadDataIntoGridView1();
            }
            else
                MessageBox.Show("اختر للمسح");
        }

        private void deleteRecordFromDatabase(string value)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "DELETE FROM Supplier WHERE code = @code";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", value);
            cmd.ExecuteNonQuery();
            con.Close();

            loadDataIntoGridView1();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit_Suppliers.Text == "تعديل")
            {
                buttonEdit_Suppliers.Text = "الغاء التعديل";
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int i;
                    i = dataGridView1.SelectedCells[0].RowIndex;
                    groupBox2.Text = "ستقوم بتعديل بيانات المورد رقم: " + dataGridView1.Rows[i].Cells[1].Value.ToString();
                    textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    textBoxAddress.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    textBoxPhone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

                    buttonEditApprove_Suppliers.Enabled = true;
                    buttonAdd_Suppliers.Enabled = false;

                    groupBox2.ForeColor = Color.Red;
                    groupBox2.Visible = true;
                }
                else
                    MessageBox.Show("اختر مورد للتعديل");
            }
            else if (buttonEdit_Suppliers.Text == "الغاء التعديل")
            {
                buttonEdit_Suppliers.Text = "تعديل";
                groupBox2.Text = "";
                buttonAdd_Suppliers.Enabled = true;
                groupBox2.Visible = false;
                groupBox2.ForeColor = Color.Black;
            }
        }

        private void editFunction()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            try
            {
                string sqlquery = "UPDATE Supplier SET code = @code, " +
                    " name = @name, phone = @phone, address = @address WHERE code=@code";

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("لا يوجد مورد بهذا الرقم");
            }
        }

        private void buttonEditApprove_Click(object sender, EventArgs e)
        {
            editFunction();
            loadDataIntoGridView1();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonEdit_Suppliers.Text == "تعديل")
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBoxAddress.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxPhone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            }
            else 
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                groupBox2.Text = "ستقوم بتعديل بيانات المورد رقم: " + dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBoxAddress.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxPhone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
    }//end class Suppliers
}//edn namespace 