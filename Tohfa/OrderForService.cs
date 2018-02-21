using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tohfa
{
    public partial class OrderForService : Form
    {
        #region connection string
        
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd;
        DataTable dataTable;
        #endregion

        //global var
        string mCM;

        public OrderForService()
        {
            InitializeComponent();
            textBoxDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
            fillComboBoxAgent();
            fillComboBoxRawMaterial();
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
                con.Close();
                MessageBox.Show(exc.Message);
            }
        }
        
        private void fillComboBoxRawMaterial()
        {
            string query = "select name from RawMaterial";
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
                    comboBoxRawName.Items.Add(col);
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
                cmd.CommandText = "SELECT * FROM OrderForService";
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
            dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "كود";
            dataGridView1.Columns[2].HeaderText = "عميل";
            dataGridView1.Columns[3].HeaderText = "الخامة";
            dataGridView1.Columns[4].HeaderText = "الطول";
            dataGridView1.Columns[5].HeaderText = "العرض";
            dataGridView1.Columns[6].HeaderText = "سعر الخامة";
            dataGridView1.Columns[7].HeaderText = "وقت الماكينة";
            dataGridView1.Columns[8].HeaderText = "نوع العمل";
            dataGridView1.Columns[9].HeaderText = "سعر الماكينة";
            dataGridView1.Columns[10].HeaderText = "الاجمالى";
            dataGridView1.Columns[11].HeaderText = "التاريخ";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[11].Visible = false;

        }//end resizeGridView1

        private void buttonNew_OrServ_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            createNewCode();
        }

        int codeNumber = 0;
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
            newCode = "OS" + codeNumber;
            textBoxCode.Text = newCode;
        }//end createNewCode

        private string getLastCode()
        {
            if (isHasRows())
            {
                con.Open();
                string sqlquery = "SELECT TOP 1 code FROM OrderForService ORDER BY id DESC";
                SqlCommand command = new SqlCommand(sqlquery, con);
                string value = command.ExecuteScalar().ToString();
                con.Close();
                return value;
            }
            else
            {
                return "OS0";

            }
        }//end getLastCode

        private bool isHasRows()
        {
            con.Open();
            string sqlquery = "SELECT * FROM OrderForService";
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

        private void buttonAdd_OrServ_Click(object sender, EventArgs e)
        {
            insertIntoDB();
            loadDataIntoGridView1();
            clearFields();
        }

        private void clearFields()
        {
            comboBoxAgent.SelectedIndex = -1;
            comboBoxRawName.SelectedIndex = -1;
            
            textBoxLength.Clear();
            textBoxWidth.Clear();
            textBoxMaterialPrice.Clear();
            textBoxTime.Clear();
            comboBoxWorkKind.SelectedIndex = -1;
            textBoxMachinePrice.Clear();
            textBoxTotal.Clear();
        }

        private void insertIntoDB()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO OrderForService VALUES(@code, @agent, @materialName," +
                    " @length, @width,@materialPrice,@time,@workKind, @machinePrice, @total,@date)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@agent", comboBoxAgent.Text);
                cmd.Parameters.AddWithValue("@materialName", comboBoxRawName.Text);
                cmd.Parameters.AddWithValue("@length", textBoxLength.Text);
                cmd.Parameters.AddWithValue("@width", textBoxWidth.Text);
                cmd.Parameters.AddWithValue("@materialPrice", textBoxMaterialPrice.Text);
                cmd.Parameters.AddWithValue("@time", textBoxTime.Text);
                cmd.Parameters.AddWithValue("@workKind", comboBoxWorkKind.Text);
                cmd.Parameters.AddWithValue("@machinePrice", textBoxMachinePrice.Text);
                cmd.Parameters.AddWithValue("@total", textBoxTotal.Text);
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
        
        private void buttonLoad_OrServ_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
        }
        
        private void comboBoxAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string agentName = comboBoxAgent.Text;
            //getAgentKind(agentName);
        }

        private int getAgentKind()
        {

            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            cmd = new SqlCommand();
            cmd.CommandText = "SELECT kind FROM Agent WHERE name=@name";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", comboBoxAgent.Text);

           string  agentKind = cmd.ExecuteScalar().ToString();
            
            switch (agentKind)
            {
                case "قطاعى":
                    con.Close();
                    return 0;

                case "خاص":
                    con.Close();
                    return 1;

                case "جملة":
                    con.Close();
                    return 2;

                case "نصف جملة":
                    con.Close();
                    return 3;
                default:
                    con.Close();
                    MessageBox.Show("switch agentkind error");
                    return -1;
            }
            
        }
        
        private void comboBoxWorkKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxTime.Text != "" && comboBoxAgent.SelectedIndex > -1)
            {
                setMachinePrice(comboBoxWorkKind.SelectedIndex, textBoxTime.Text);
            }
            else
                MessageBox.Show("تأكد من ادخال العميل");

            sumToTotal(textBoxMachinePrice.Text,textBoxMaterialPrice.Text);
        }
        
        private void setMachinePrice(int workKind, string time)
        {
            switch (workKind)
            {
                case 0://قطع
                    double number = double.Parse(getCutValue());
                    double time_num = double.Parse(time);
                    double res = number * time_num;
                    textBoxMachinePrice.Text = res.ToString();
                    break;

                case 1://حفر
                    double numberr = double.Parse(getDigValue());
                    double time_numr = double.Parse(time);
                    double resr = numberr * time_numr;
                    textBoxMachinePrice.Text = resr.ToString();
                    break;

                case 2: //قطع وحفر
                    double numberrr = double.Parse(getDigCutValue());
                    double time_numrr = double.Parse(time);
                    double resrr = numberrr * time_numrr;
                    textBoxMachinePrice.Text = resrr.ToString();
                    break;
            }
        }

  


        private string getDigValue()
        {
            switch (getAgentKind())
            {
                case 0: //قطاعى
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DigLocal FROM CurrencyConfig";
                    string resLocal = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resLocal;

                case 1: //خاص
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DigSpecial FROM CurrencyConfig";
                    string resSpecial = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resSpecial;

                case 2: //جملة
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DigManufactory FROM CurrencyConfig";
                    string resManufacture = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resManufacture;

                case 3: //نصف جملة
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DigHalfManufactory FROM CurrencyConfig";
                    string resHalfManufacture = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resHalfManufacture;

                default:
                    con.Close();
                    return "error getting dig value";
            }
        }

        private string getDigCutValue()
        {
            switch (getAgentKind())
            {
                case 0: //قطاعى
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DigCutLocal FROM CurrencyConfig";
                    string resLocal = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resLocal;

                case 1: //خاص
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DigCutSpecial FROM CurrencyConfig";
                    string resSpecial = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resSpecial;

                case 2: //جملة
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DigCutManufactory FROM CurrencyConfig";
                    string resManufacture = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resManufacture;

                case 3: //نصف جملة
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DigCutHalfManufactory FROM CurrencyConfig";
                    string resHalfManufacture = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resHalfManufacture;

                default:
                    con.Close();
                    return "error getting dig value";
            }
        }

        private string getCutValue()
        {
            switch (getAgentKind()) {
                case 0: //قطاعى
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT CutLocal FROM CurrencyConfig";
                    string resLocal = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resLocal;

                case 1: //خاص
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT CutSpecial FROM CurrencyConfig";
                    string resSpecial = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resSpecial;

                case 2: //جملة
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT CutManufactory FROM CurrencyConfig";
                    string resManufacture = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resManufacture;

                case 3: //نصف جملة
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT CutHalfManufactory FROM CurrencyConfig";
                    string resHalfManufacture = cmd.ExecuteScalar().ToString();
                    con.Close();
                    return resHalfManufacture;

                default:
                    con.Close();
                    return "error getting cut value";
            }
        }

        private void comboBoxRawName_SelectedIndexChanged(object sender, EventArgs e)
        { 
            mCM =  getCantiMeterPriceForProduct(comboBoxRawName.Text);

            if (textBoxWidth.Text != "" & textBoxLength.Text !="")
            {
                setMaterialPrice(mCM, textBoxLength.Text, textBoxWidth.Text);
            }

            sumToTotal(textBoxMaterialPrice.Text, textBoxMachinePrice.Text);
        }

        private void setMaterialPrice(string canti, string length, string width)
        {
            double CM_Number, length_Number, width_Number;
            CM_Number = double.Parse(canti);
            length_Number = double.Parse(length);
            width_Number = double.Parse(width);

            double res = CM_Number * length_Number * width_Number;
            textBoxMaterialPrice.Text = res.ToString();

        }
        
        private string getCantiMeterPriceForProduct(string text)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT cantiCost FROM RawMaterial WHERE name=@name";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name",text);
            string res = cmd.ExecuteScalar().ToString();
            con.Close();
            return res;
        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLength.Text != "" && textBoxWidth.Text != "")
            {
                if (comboBoxRawName.SelectedIndex > -1)
                    setMaterialPrice(mCM, textBoxLength.Text, textBoxWidth.Text);
                else
                    MessageBox.Show("ادخل نوع الخامة");
            }

            sumToTotal(textBoxMaterialPrice.Text, textBoxMachinePrice.Text);
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {

            if (textBoxLength.Text != "" && textBoxWidth.Text != "")
            {
                if (comboBoxRawName.SelectedIndex > -1)
                    setMaterialPrice(mCM, textBoxLength.Text, textBoxWidth.Text);
                else
                    MessageBox.Show("ادخل نوع الخامة");
            }
            sumToTotal(textBoxMaterialPrice.Text, textBoxMachinePrice.Text);

        }

        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxWorkKind.SelectedIndex > -1 && textBoxTime.Text != "")
            {
                setMachinePrice(comboBoxWorkKind.SelectedIndex, textBoxTime.Text);
            }
            sumToTotal(textBoxMaterialPrice.Text, textBoxMachinePrice.Text);
        }

        private void sumToTotal(string txt1,string txt2) {
            if (comboBoxWorkKind.SelectedIndex > -1 && textBoxTime.Text != "" &&
                textBoxLength.Text != "" && textBoxWidth.Text != "" && comboBoxRawName.SelectedIndex > -1)
            {
                double num1 = double.Parse(txt1);
                double num2 = double.Parse(txt2);

                double res = num1 + num2;
                textBoxTotal.Text = res.ToString();
            }
        }//end sumToTotal

        private void buttonDelete_OrServ_Click(object sender, EventArgs e)
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
        }//end 

        private void deleteRecordFromDatabase(string value)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            string sqlquery = "DELETE FROM OrderForService WHERE code = @code";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", value);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
