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
            fillSuppliersComboBox();
            textBoxDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

        private void fillSuppliersComboBox()
        {
            string query = "select name from Supplier";
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
                    comboBoxSuppliers.Items.Add(col);
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
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "كود";
            dataGridView1.Columns[2].HeaderText = "الاسم";
            dataGridView1.Columns[3].HeaderText = "النوع";
            dataGridView1.Columns[4].HeaderText = "السماكة";
            dataGridView1.Columns[5].HeaderText = "اللون";

            dataGridView1.Columns[6].HeaderText = "سعر القطاعى متر مربع";
            dataGridView1.Columns[7].HeaderText = "سعر القطاعى سم مربع";

            dataGridView1.Columns[8].HeaderText = "سعر الخاص متر مربع";
            dataGridView1.Columns[9].HeaderText = "سعر الخاص سم مربع";

            dataGridView1.Columns[10].HeaderText = "سعر الجملة متر مربع";
            dataGridView1.Columns[11].HeaderText = "سعر الجملة  سم مربع";

            dataGridView1.Columns[12].HeaderText = "سعر نص جملة متر مربع";
            dataGridView1.Columns[13].HeaderText = "سعر نص جملة سم مربع";
            dataGridView1.Columns[14].HeaderText = "اسم المورد";
            dataGridView1.Columns[15].HeaderText = "الكمية";



            dataGridView1.Columns[0].Visible = false;


        }//end resizeGridView1

        private void buttonNew_Row_Click(object sender, EventArgs e)
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
            addPriceToStoreDataBase();
            loadDataIntoGridView1();
            clearFields();
        }

        private void addPriceToStoreDataBase()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Store (cost, costKind, date, category) " +
                    "VALUES (@cost, @costKind, @date, @category)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@cost", textBoxPrice.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text+" :شراء خامة");
                cmd.Parameters.AddWithValue("@date", textBoxDate.Text);
                cmd.Parameters.AddWithValue("@category", "cost");


                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private double  getLastCostFromStoreDB()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            string sqlquery = "SELECT cost FROM Store WHERE costKind=@costKind";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@costKind", textBoxName.Text + " :شراء خامة");
            String res = command.ExecuteScalar().ToString();
            con.Close();
            return double.Parse(res);
        }

        private void clearFields()
        {
            createNewCode();
            comboBoxKind.SelectedIndex = -1;
            textBoxThickness.Clear();
            textBoxColor.Clear();

            textBoxLocalMetrCost.Text = "";
            textBoxSpecialMetrCost.Text = "";
            textBoxManufactureMetrCost.Text = "";
            textBoxHalfManuMetrCost.Text = "";

            textBoxQuantity.Text = "";
            textBoxPrice.Text = "";
        }

        private void enableTextBoxes(bool isEnabled) {
            textBoxCode.Enabled = isEnabled;
            comboBoxKind.Enabled = isEnabled;
            textBoxThickness.Enabled = isEnabled;
            textBoxName.Enabled = isEnabled;
            textBoxColor.Enabled = isEnabled;
            comboBoxSuppliers.Enabled = isEnabled;
            textBoxQuantity.Enabled = isEnabled;
            textBoxPrice.Enabled = isEnabled;
        }

        private void insertIntoDB()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO RawMaterial (code, name, kind, thickness, color," +
                    "metrLocalCost, cantiLocalCost," +
                    "metrSpecialCost,cantiSpecialCost," +
                    "metrManufactureCost,cantiManufactureCost," +
                    "metrHalfManuCost,cantiHalfManuCost,supplier, quantity, price) " +
                    "VALUES (@code, @name, @kind, @thikness, @color," +
                    "@metrLocalCost, @cantiLocalCost," +
                    "@metrSpecialCost, @cantiSpecialCost," +
                    "@metrManufactureCost, @cantiManufactureCost," +
                    "@metrHalfManuCost, @cantiHalfManuCost,@supplier,@quantity, @price)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@kind", comboBoxKind.Text);
                cmd.Parameters.AddWithValue("@thikness", textBoxThickness.Text);
                cmd.Parameters.AddWithValue("@color", textBoxColor.Text);

                cmd.Parameters.AddWithValue("@metrLocalCost", textBoxLocalMetrCost.Text);
                cmd.Parameters.AddWithValue("@cantiLocalCost", textBoxLocalCantiCost.Text);

                cmd.Parameters.AddWithValue("@metrSpecialCost", textBoxSpecialMetrCost.Text);
                cmd.Parameters.AddWithValue("@cantiSpecialCost", textBoxSpecialCantiCost.Text);

                cmd.Parameters.AddWithValue("@metrManufactureCost", textBoxManufactureMetrCost.Text);
                cmd.Parameters.AddWithValue("@cantiManufactureCost", textBoxManufactureCantiCost.Text);

                cmd.Parameters.AddWithValue("@metrHalfManuCost", textBoxHalfManuMetrCost.Text);
                cmd.Parameters.AddWithValue("@cantiHalfManuCost", textBoxHalfManuMetrCost.Text);
                cmd.Parameters.AddWithValue("@supplier", comboBoxSuppliers.Text);
                cmd.Parameters.AddWithValue("@quantity", textBoxQuantity.Text);
                cmd.Parameters.AddWithValue("@price", textBoxPrice.Text);
                
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()
        
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
            string sqlquery = "DELETE FROM RawMaterial WHERE code = @code";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", value);
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
            textBoxName.Text = getAlpha(textBoxCode.Text) + getMaterialKindCode(comboBoxKind.SelectedIndex)
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
                    comboBoxKind.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    textBoxThickness.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    textBoxColor.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

                    textBoxLocalMetrCost.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    textBoxLocalCantiCost.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

                    textBoxSpecialMetrCost.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    textBoxSpecialCantiCost.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();

                    textBoxManufactureMetrCost.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                    textBoxManufactureCantiCost.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();

                    textBoxHalfManuMetrCost.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                    textBoxHalfManufCantiCost.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
                    comboBoxSuppliers.Text = dataGridView1.Rows[i].Cells[14].Value.ToString();
                    textBoxQuantity.Text = dataGridView1.Rows[i].Cells[15].Value.ToString();
                    textBoxPrice.Text = dataGridView1.Rows[i].Cells[16].Value.ToString();


                    buttonEditApprove_Row.Enabled = true;
                    buttonAdd_Row.Enabled = false;

                    groupBox2.ForeColor = Color.Red;
                    groupBox2.Visible = true;
                    buttonShowAddingQuantity.Visible = false;
                    groupBox6.Visible = false;
                    groupBox7.Visible = false;
                    buttonAddQuantity.Visible = false;
                    enableTextBoxes(true);
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
                buttonShowAddingQuantity.Visible = true;
                clearFields();
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
                    " name = @name, kind=@kind, thickness = @thickness, color = @color," +
                    " metrLocalCost=@metrLocalCost, cantiLocalCost = @cantiLocalCost," +
                    "metrSpecialCost=@metrSpecialCost, cantiSpecialCost = @cantiSpecialCost," +
                    "metrManufactureCost=@metrManufactureCost, cantiManufactureCost=@cantiManufactureCost," +
                    "metrHalfManuCost=@metrHalfManuCost, cantiHalfManuCost=@cantiHalfManuCost , quantity=@quantity, price=@price " +
                    "WHERE code=@code";

                cmd = new SqlCommand(sqlquery, con);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@kind", comboBoxKind.Text);
                cmd.Parameters.AddWithValue("@thickness", textBoxThickness.Text);
                cmd.Parameters.AddWithValue("@color", textBoxColor.Text);

                cmd.Parameters.AddWithValue("@metrLocalCost", textBoxLocalMetrCost.Text);
                cmd.Parameters.AddWithValue("@cantiLocalCost", textBoxLocalCantiCost.Text);

                cmd.Parameters.AddWithValue("@metrSpecialCost", textBoxSpecialMetrCost.Text);
                cmd.Parameters.AddWithValue("@cantiSpecialCost", textBoxSpecialCantiCost.Text);

                cmd.Parameters.AddWithValue("@metrManufactureCost", textBoxManufactureMetrCost.Text);
                cmd.Parameters.AddWithValue("@cantiManufactureCost", textBoxManufactureCantiCost.Text);

                cmd.Parameters.AddWithValue("@metrHalfManuCost", textBoxHalfManuMetrCost.Text);
                cmd.Parameters.AddWithValue("@cantiHalfManuCost", textBoxHalfManufCantiCost.Text);
                cmd.Parameters.AddWithValue("@quantity", textBoxQuantity.Text);
                cmd.Parameters.AddWithValue("@price", textBoxPrice.Text);

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
            groupBox2.ForeColor = Color.Black;
            groupBox2.Text = "";
            clearFields();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonEdit_Row.Text == "تعديل")
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                comboBoxKind.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBoxThickness.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxColor.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

                textBoxLocalMetrCost.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                textBoxLocalCantiCost.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

                textBoxSpecialMetrCost.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                textBoxSpecialCantiCost.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();

                textBoxManufactureMetrCost.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                textBoxManufactureCantiCost.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();

                textBoxHalfManuMetrCost.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                textBoxHalfManufCantiCost.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
                comboBoxSuppliers.Text = dataGridView1.Rows[i].Cells[14].Value.ToString();
                textBoxQuantity.Text = dataGridView1.Rows[i].Cells[15].Value.ToString();
                textBoxPrice.Text = dataGridView1.Rows[i].Cells[16].Value.ToString();


                buttonShowAddingQuantity.Visible = true;
            }
            else
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                groupBox2.Text = "ستقوم بتعديل بيانات الخامة رقم: " + dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                comboBoxKind.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBoxThickness.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxColor.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

                textBoxLocalMetrCost.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                textBoxLocalCantiCost.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

                textBoxSpecialMetrCost.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                textBoxSpecialCantiCost.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();

                textBoxManufactureMetrCost.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                textBoxManufactureCantiCost.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();

                textBoxHalfManuMetrCost.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                textBoxHalfManufCantiCost.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
                comboBoxSuppliers.Text = dataGridView1.Rows[i].Cells[14].Value.ToString();
                textBoxQuantity.Text = dataGridView1.Rows[i].Cells[15].Value.ToString();
                textBoxPrice.Text = dataGridView1.Rows[i].Cells[16].Value.ToString();

                buttonShowAddingQuantity.Visible = true;
            }
        }

        private void textBoxLocalMetrCost_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLocalMetrCost.Text != "")
            {
                string metrText = textBoxLocalMetrCost.Text;
                string cantiText = textBoxLocalCantiCost.Text;

                double metrNumber = double.Parse(metrText);
                double cantiNumber = double.Parse(cantiText);

                cantiNumber = (metrNumber / 10000);
                cantiText = cantiNumber.ToString();

                textBoxLocalCantiCost.Text = cantiText;
            }
            else
            textBoxLocalCantiCost.Text = "0";
        }

        private void textBoxSpecialMetrCost_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSpecialMetrCost.Text != "")
            {
                string metrText = textBoxSpecialMetrCost.Text;
                string cantiText = textBoxSpecialCantiCost.Text;

                double metrNumber = double.Parse(metrText);
                double cantiNumber = double.Parse(cantiText);

                cantiNumber = (metrNumber / 10000);
                cantiText = cantiNumber.ToString();

                textBoxSpecialCantiCost.Text = cantiText;
            }
            else
                textBoxSpecialCantiCost.Text = "0";
        }

        private void textBoxManufactureMetrCost_TextChanged(object sender, EventArgs e)
        {
            if (textBoxManufactureMetrCost.Text != "")
            {
                string metrText = textBoxManufactureMetrCost.Text;
                string cantiText = textBoxManufactureCantiCost.Text;

                double metrNumber = double.Parse(metrText);
                double cantiNumber = double.Parse(cantiText);

                cantiNumber = (metrNumber / 10000);
                cantiText = cantiNumber.ToString();

                textBoxManufactureCantiCost.Text = cantiText;
            }else
                textBoxManufactureCantiCost.Text = "0";
        }

        private void textBoxHalfManuMetrCost_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHalfManuMetrCost.Text != "")
            {
                string metrText = textBoxHalfManuMetrCost.Text;
                string cantiText = textBoxHalfManufCantiCost.Text;

                double metrNumber = double.Parse(metrText);
                double cantiNumber = double.Parse(cantiText);

                cantiNumber = (metrNumber / 10000);
                cantiText = cantiNumber.ToString();

                textBoxHalfManufCantiCost.Text = cantiText;
            }
            else
                textBoxHalfManufCantiCost.Text = "0";

        }

        private void textBoxThickness_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private double getQuantityFromRawMaterial(string code)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "SELECT quantity FROM RawMaterial WHERE code=@code";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@code", code);
            String res = command.ExecuteScalar().ToString();
            con.Close();
            return double.Parse(res);
        }

        private double getPriceFromRawMaterial(string code)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "SELECT price FROM RawMaterial WHERE code=@code";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@code", code);
            String res = command.ExecuteScalar().ToString();
            con.Close();
            return double.Parse(res);
        }

        private void buttonShowAddingQuantity_Click(object sender, EventArgs e)
        {
            enableTextBoxes(false);
            groupBox6.Visible = true;
            groupBox7.Visible = true;
            buttonAddQuantity.Visible = true;
        }

        private void buttonAddQuantity_Click(object sender, EventArgs e)
        {
            if (textBoxNewQuantity.Text != "" && textBoxNewPrice.Text != "")
            {
                
                double oldQ = getQuantityFromRawMaterial(textBoxCode.Text);
                double newQ = double.Parse(textBoxNewQuantity.Text);

                double resQ = oldQ + newQ;

                double oldP = getPriceFromRawMaterial(textBoxCode.Text);
                double newP = double.Parse(textBoxPrice.Text);

                double resP = oldP + newP;
                
                updateQuantityAndPriceFromMaterial(resQ, resP);
                loadDataIntoGridView1();
            }
        }

        private void updateQuantityAndPriceFromMaterial(double quantity, double price)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            string sqlquery = "UPDATE RawMaterial SET quantity=@quantity, price=@price WHERE code=@code";
            cmd = new SqlCommand(sqlquery, con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@price",price);

            cmd.ExecuteNonQuery();
            con.Close();

            //double oldP = getLastCostFromStoreDB();
            //double newP = double.Parse(textBoxNewPrice.Text);

            //double resP = oldP + newP;
           
            updatePriceFromStore(price,textBoxName.Text + " :شراء خامة");
        }

        private void updatePriceFromStore(double price,string costKind)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            string sqlquery = "UPDATE Store SET cost=@cost WHERE costKind=@costKind";
            cmd = new SqlCommand(sqlquery, con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cost", price);
            cmd.Parameters.AddWithValue("@costKind", costKind);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}