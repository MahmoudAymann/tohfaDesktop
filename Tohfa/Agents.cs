using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Tohfa
{
    public partial class Agents : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd;
        DataTable dataTable;

        int codeNumber = 0;

        public Agents()
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
                cmd.CommandText = "SELECT * FROM Agent";
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
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "كود";
            dataGridView1.Columns[2].HeaderText = "النوع";
            dataGridView1.Columns[3].HeaderText = "الاسم";
            dataGridView1.Columns[4].HeaderText = "رقم";
            dataGridView1.Columns[5].HeaderText = "عنوان";

            dataGridView1.Columns[0].Visible = false;

        }//end resizeGridView1

        private void buttonNew_Agent_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

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
            newCode = "A" + codeNumber;
            textBoxCode.Text = newCode;
        }

        private string getLastCode()
        {
            if (isHasRows())
            {
                con.Open();
                string sqlquery = "SELECT TOP 1 code FROM Agent ORDER BY id DESC";
                SqlCommand command = new SqlCommand(sqlquery, con);
                string value = command.ExecuteScalar().ToString();
                con.Close();
                return value;
            }
            else
            {
                return "A0";

            }
        }

        private bool isHasRows()
        {
            con.Open();
            string sqlquery = "SELECT * FROM Agent";
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

        private void buttonAdd_Agent_Click(object sender, EventArgs e)
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
            comboBoxKind.SelectedIndex= -1;
            textBoxPhone.Clear();
        }

        private void insertIntoDB()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Agent (code, name, kind, phone, address) VALUES (@code, @name, @kind, @phone, @address)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@kind", comboBoxKind.Text);
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

        private void buttonDelete_Agent_Click(object sender, EventArgs e)
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
            string sqlquery = "DELETE FROM Agent WHERE code = @code";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", value);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void buttonLoad_Agent_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
        }

       
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonEdit_Agent.Text == "تعديل")
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                comboBoxKind.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBoxAddress.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBoxPhone.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            }
            else
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                groupBox2.Text = "ستقوم بتعديل بيانات المورد رقم: " + 
                    dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                comboBoxKind.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBoxAddress.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBoxPhone.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void buttonEdit_Agent_Click(object sender, EventArgs e)
        {
            if (buttonEdit_Agent.Text == "تعديل")
            {
                buttonEdit_Agent.Text = "الغاء التعديل";
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int i;
                    i = dataGridView1.SelectedCells[0].RowIndex;
                    groupBox2.Text = "ستقوم بتعديل بيانات العميل رقم: " + dataGridView1.Rows[i].Cells[1].Value.ToString();
                    textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    comboBoxKind.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    textBoxName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    textBoxPhone.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    textBoxAddress.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();


                    buttonEditApprove_Agent.Enabled = true;
                    buttonAdd_Agent.Enabled = false;

                    groupBox2.ForeColor = Color.Red;
                    groupBox2.Visible = true;
                }
                else
                    MessageBox.Show("اختر العميل للتعديل");
            }
            else if (buttonEdit_Agent.Text == "الغاء التعديل")
            {
                buttonEdit_Agent.Text = "تعديل";
                groupBox2.Text = "";
                buttonAdd_Agent.Enabled = true;
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
                string sqlquery = "UPDATE Agent SET code = @code, " +
                    " name = @name, phone = @phone, address = @address, kind=@kind WHERE code=@code";

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@kind", comboBoxKind.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("لا يوجد عميل بهذا الرقم");
            }
        }

        private void buttonEditApprove_Agent_Click(object sender, EventArgs e)
        {
            editFunction();
            loadDataIntoGridView1();
            groupBox2.ForeColor = Color.Black;
            groupBox2.Text = "";
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}