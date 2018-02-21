using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Tohfa
{
    public partial class Department : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd;
        DataTable dataTable;

        public Department()
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
                cmd.CommandText = "SELECT * FROM Department";
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
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].HeaderText = "كود";
            dataGridView1.Columns[1].HeaderText = "إسم القسم";
            
        }//end resizeGridView1

        private void buttonNew_Dept_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            clearFields();
        }

        private void buttonAdd_Dept_Click(object sender, EventArgs e)
        {
            insertIntoDB();
            loadDataIntoGridView1();
            clearFields();
        }

        private void clearFields()
        {
            textBoxName.Clear();
        }

        private void insertIntoDB()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Department VALUES(@name)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()
        private void buttonLoad_Dept_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
        }

        private void buttonDelete_Dept_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string value;
                int i = dataGridView1.CurrentCell.RowIndex;
                value = dataGridView1.Rows[i].Cells[0].Value.ToString(); //get code

                deleteRecordFromDatabase(value);

                loadDataIntoGridView1();
            }
            else
                MessageBox.Show("اختر للمسح");
        }//end button delete

        private void deleteRecordFromDatabase(string value)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "DELETE FROM Department WHERE id = @id";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", value);
            cmd.ExecuteNonQuery();
            con.Close();
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
                    groupBox2.Text = "ستقوم بتعديل بيانات المنتج رقم: " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                    textBoxName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    
                    buttonEditApprove.Enabled = true;
                    buttonAdd_Dept.Enabled = false;

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
                buttonAdd_Dept.Enabled = true;
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
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;

                string sqlquery = "UPDATE Department SET name = @name WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("لا يوجد المنتج بهذا الرقم");
            }
        }

        private void buttonEditApprove_Click(object sender, EventArgs e)
        {
            editFunction();
            loadDataIntoGridView1();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonEdit.Text == "تعديل")
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                textBoxName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            }
            else
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                groupBox2.Text = "ستقوم بتعديل بيانات القسم رقم: " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            }
        }

    }
}
