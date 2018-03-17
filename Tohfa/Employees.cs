using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tohfa
{
    public partial class Employees : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd;
        DataTable dataTable;

        int codeNumber = 0;

        public Employees()
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
                cmd.CommandText = "SELECT * FROM Employee";
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

            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "كود";
            dataGridView1.Columns[2].HeaderText = "الاسم";
            dataGridView1.Columns[3].HeaderText = "رقم";
            dataGridView1.Columns[4].HeaderText = "عنوان";
            dataGridView1.Columns[5].HeaderText = "القسم";
            dataGridView1.Columns[6].HeaderText = "المهنة";
            
            dataGridView1.Columns[0].Visible = false;
        }

        private void buttonNew_Emp_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            createNewCode();
        }

        private string getLastCode()
        {
            if (isHasRows())
            {
                con.Open();
                string sqlquery = "SELECT TOP 1 code FROM Employee ORDER BY id DESC";
                SqlCommand command = new SqlCommand(sqlquery, con);
                string value = command.ExecuteScalar().ToString();
                con.Close();
                return value;
            }
            else
            {
                return "S0";

            }
        }

        private bool isHasRows()
        {
            con.Open();
            string sqlquery = "SELECT * FROM Employee";
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

        private void buttonAdd_Emp_Click(object sender, EventArgs e)
        {
            insertIntoDB();
            loadDataIntoGridView1();
            clearFields();
        }

        private void clearFields()
        {
            createNewCode();
            textBoxName.Clear();
            textBoxPhone.Clear();
            comboBox1.SelectedIndex = -1;
            textBoxJob.Clear();
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
            newCode = "E" + codeNumber;
            textBoxCode.Text = newCode;
        }

        private void insertIntoDB()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Employee (code, name, phone, address, department, job) " +
                    "VALUES(@code, @name, @phone, @address, @department, @job)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("@department", comboBox1.Text);
                cmd.Parameters.AddWithValue("@job", textBoxJob.Text);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()

        private void buttonDelete_Emp_Click(object sender, EventArgs e)
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
                MessageBox.Show("اختر عميل للمسح");
        }

        private void deleteRecordFromDatabase(string value)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "DELETE FROM Employee WHERE code = @code";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", value);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void buttonLoad_Emp_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Text == "تعديل")
            {
                buttonEdit.Text = "الغاء التعديل";
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int i;
                    i = dataGridView1.SelectedCells[0].RowIndex;
                    groupBox2.Text = "ستقوم بتعديل بيانات الموظف رقم: " + dataGridView1.Rows[i].Cells[1].Value.ToString();
                    textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    textBoxAddress.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    textBoxPhone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

                    buttonEditApprove.Enabled = true;
                    buttonAdd_Emp.Enabled = false;

                    groupBox2.ForeColor = Color.Red;
                    groupBox2.Visible = true;
                }
                else
                    MessageBox.Show("اختر الموظف للتعديل");
            }
            else if (buttonEdit.Text == "الغاء التعديل")
            {
                buttonEdit.Text = "تعديل";
                groupBox2.Text = "";
                buttonAdd_Emp.Enabled = true;
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
                string sqlquery = "UPDATE Employee SET code = @code, " +
                    " name = @name, phone = @phone, department = @department, job=@job WHERE code=@code";

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@department", comboBox1.Text);
                cmd.Parameters.AddWithValue("@job", textBoxJob.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("لا يوجد الموظف بهذا الرقم");
            }
        }

        private void buttonEditApprove_Click(object sender, EventArgs e)
        {
            editFunction();
            loadDataIntoGridView1();
            groupBox2.ForeColor = Color.Black;
            groupBox2.Text = "";
            clearFields();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonEdit.Text == "تعديل")
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBoxAddress.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxPhone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBoxJob.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

            }
            else
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                groupBox2.Text = "ستقوم بتعديل بيانات الموظف رقم: " + dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBoxAddress.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxPhone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBoxJob.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
    }
}