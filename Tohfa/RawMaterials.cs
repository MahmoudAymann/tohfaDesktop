using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tohfa
{
    public partial class RawMaterials : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd;
        DataTable dataTable;
        int codeNumber = 0;
        public RawMaterials()
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
                cmd.CommandText = "SELECT * FROM RawMaterial";
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
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "كود";
            dataGridView1.Columns[2].HeaderText = "الاسم";
            dataGridView1.Columns[3].HeaderText = "النوع";
            dataGridView1.Columns[4].HeaderText = "السماكة";
            dataGridView1.Columns[5].HeaderText = "اللون";
            dataGridView1.Columns[6].HeaderText = "السعر لكل متر مربع";
            dataGridView1.Columns[7].HeaderText = "السعر لكل سم مربع";

            dataGridView1.Columns[0].Visible = false;


        }//end resizeGridView1

        private void buttonNew_Row_Click(object sender, EventArgs e)
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
            newCode = "M" + codeNumber;
            textBoxCode.Text = newCode;
        }

        private string getLastCode()
        {
            if (isHasRows())
            {
                con.Open();
                string sqlquery = "SELECT TOP 1 code FROM RawMaterial ORDER BY id DESC";
                SqlCommand command = new SqlCommand(sqlquery, con);
                string value = command.ExecuteScalar().ToString();
                con.Close();
                return value;
            }
            else
            {
                return "M0";
            }
        }

        private bool isHasRows()
        {
            con.Open();
            string sqlquery = "SELECT * FROM RawMaterial";
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

        private void buttonAdd_Row_Click(object sender, EventArgs e)
        {
            insertIntoDB();
            loadDataIntoGridView1();
            clearFields();
        }

        private void clearFields()
        {
            textBoxCode.Clear();
            comboBox1.SelectedIndex = -1;
            textBoxThickness.Clear();
            textBoxColor.Clear();
        }

        private void insertIntoDB()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO RawMaterial (code, name, kind, thickness, color, metrCost, cantiCost) VALUES (@code, @name, @kind, @thikness, @color, @metrCost, @cantiCost)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@kind", comboBox1.Text);
                cmd.Parameters.AddWithValue("@thikness", textBoxThickness.Text);
                cmd.Parameters.AddWithValue("@color", textBoxColor.Text);
                cmd.Parameters.AddWithValue("@metrCost", textBoxMetrCost.Text);
                cmd.Parameters.AddWithValue("@cantiCost", textBoxCantiCost.Text);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()

        private void textBoxMetrCost_Leave(object sender, EventArgs e)
        {
           
            if (textBoxMetrCost.Text != "")
            {
                string metrText = textBoxMetrCost.Text;
                string cantiText = textBoxCantiCost.Text;

                double metrNumber = double.Parse(metrText);
                double cantiNumber = double.Parse(cantiText);

                cantiNumber = (metrNumber / 10000);
                cantiText = cantiNumber.ToString();
 
                textBoxCantiCost.Text = cantiText;
            }
        }

        private void textBoxMetrCost_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMetrCost.Text != "")
            {
                string metrText = textBoxMetrCost.Text;
                string cantiText = textBoxCantiCost.Text;

                double metrNumber = double.Parse(metrText);
                double cantiNumber = double.Parse(cantiText);

                cantiNumber = (metrNumber / 10000);
                cantiText = cantiNumber.ToString();

                textBoxCantiCost.Text = cantiText;
            }
        }

        private void buttonDelete_Row_Click(object sender, EventArgs e)
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
                MessageBox.Show("اختر للمسح");
        }
 
        private void deleteRecordFromDatabase(string value)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "DELETE FROM RawMaterial WHERE id = @id";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", value);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;

        }

        private string getMaterialKindCode(int textVal) {
            switch (textVal) {
                case 0:
                    return "W";
                case 1:
                    return "A";
                    
                case 2:
                    return "DC";
                    
                case 3:
                    return "R";
                    
                case 4:
                    return "C";
                    
                case 5:
                    return "G";
                    
                case 6:
                    return "S";

                default:
                    return "";
            }
        }

        private void textBoxThickness_Leave(object sender, EventArgs e)
        {         
            createName();
        }

        private void createName() {
            textBoxName.Text = getAlpha(textBoxCode.Text) + getMaterialKindCode(comboBox1.SelectedIndex)
                + textBoxThickness.Text + "-" + getNumber(textBoxCode.Text);
        }

        private string getAlpha(string text)
        {
            string mystr = Regex.Replace(text, @"\d", "");
            return mystr;
        }

        private string getNumber(string number) {

            string mynumber = Regex.Replace(number, @"\D", "");
            return mynumber;

        }

        private void textBoxThickness_TextChanged(object sender, EventArgs e)
        {
            createName();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            createName();
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            createName();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit_Row.Text == "تعديل")
            {
                buttonEdit_Row.Text = "الغاء التعديل";
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int i;
                    i = dataGridView1.SelectedCells[0].RowIndex;
                    groupBox2.Text = "ستقوم بتعديل بيانات الخامة رقم: " + dataGridView1.Rows[i].Cells[1].Value.ToString();
                    textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    comboBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    textBoxThickness.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    textBoxColor.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    textBoxMetrCost.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    textBoxCantiCost.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

                    buttonEditApprove_Row.Enabled = true;
                    buttonAdd_Row.Enabled = false;

                    groupBox2.ForeColor = Color.Red;
                    groupBox2.Visible = true;
                }
                else
                    MessageBox.Show("اختر الخامة للتعديل");
            }
            else if (buttonEdit_Row.Text == "الغاء التعديل")
            {
                buttonEdit_Row.Text = "تعديل";
                groupBox2.Text = "";
                buttonAdd_Row.Enabled = true;
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
                string sqlquery = "UPDATE RawMaterial SET code = @code, " +
                    " name = @name, kind = @kind, thickness = @thickness, color=@color, metrCost=@metrCost, cantiCost=@cantiCost WHERE code=@code";

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@kind", comboBox1.Text);
                cmd.Parameters.AddWithValue("@thickness", textBoxThickness.Text);
                cmd.Parameters.AddWithValue("@color", textBoxColor.Text);
                cmd.Parameters.AddWithValue("@metrCost", textBoxMetrCost.Text);
                cmd.Parameters.AddWithValue("@cantiCost", textBoxCantiCost.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("لا يوجد خامة بهذا الرقم");
            }
        }

        private void buttonEditApprove_Click(object sender, EventArgs e)
        {
            editFunction();
            loadDataIntoGridView1();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonEdit_Row.Text == "تعديل")
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBoxThickness.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxColor.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBoxMetrCost.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                textBoxCantiCost.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

            }
            else
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                groupBox2.Text = "ستقوم بتعديل بيانات الخامة رقم: " + dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBoxThickness.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxColor.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBoxMetrCost.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                textBoxCantiCost.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

            }
        }

    }
}
