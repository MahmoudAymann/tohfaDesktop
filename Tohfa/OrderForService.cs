using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            if (checkBox1.Checked == true)
            {
                labelPaid.Visible = false;
                textBoxPaidd.Visible = false;
            }
            else
            {
                labelPaid.Visible = true;
                textBoxPaidd.Visible = true;
            }
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
            dataGridView1.Columns[10].HeaderText = "سعر الوحدة";
            dataGridView1.Columns[11].HeaderText = "التاريخ";
            dataGridView1.Columns[12].HeaderText = "العدد";
            dataGridView1.Columns[13].HeaderText = "اجمالى الكل";
            dataGridView1.Columns[14].HeaderText = "تم الدفع";



            dataGridView1.Columns[0].Visible = false;

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
            if (!labelQuantity.Visible)
            {
                string done;
                if (checkBox1.Checked)
                {
                    done = "نعم";
                    insertTORevenueYes();
                    insertIntoTotal();
                }
                else
                {
                    done = "لا";
                    insertTORevenueNo();
                    insertIntoTotal();
                }
                insertNewQuantityInRawMaterialDB();
                insertIntoDB(done);

                loadDataIntoGridView1();
                clearFields();
            }
            else {
                MessageBox.Show("افحص الطول والعرض المناسبين");
            }
        }

        private void insertNewQuantityInRawMaterialDB()
        {
            if (textBoxLength.Text != "" && textBoxWidth.Text != "")
            {
                double numlength = double.Parse(textBoxLength.Text);
                double numWidth = double.Parse(textBoxWidth.Text);
                double sum = numlength * numWidth;
                double oldQuantity = getQuantityFromRawMAterial(comboBoxRawName.Text);
                double res = oldQuantity - sum;

                updateQuantityInRawMaterialDB(res);
            }
        }

        private void updateQuantityInRawMaterialDB(double res)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            cmd.CommandText = "UPDATE RawMaterial SET quantity=@quantity WHERE name = @name";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@quantity", res);
            cmd.Parameters.AddWithValue("@name", comboBoxRawName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("done minus");
        }

        private void clearFields()
        {
            //comboBoxAgent.SelectedIndex = -1;
            //comboBoxRawName.SelectedIndex = -1;
            createNewCode();
            textBoxLength.Clear();
            textBoxWidth.Clear();
            textBoxMaterialPrice.Text = "0";
            textBoxTime.Clear();
            //comboBoxWorkKind.SelectedIndex = -1;
            textBoxMachinePrice.Text="0";
            textBoxTotal.Text = "0";
        }

        private void insertIntoDB(string done)
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO OrderForService VALUES(@code, @agent, @materialName," +
                    " @length, @width,@materialPrice,@time,@workKind, " +
                    "@machinePrice, @total,@date,@count,@totalAll,@check)";
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
                cmd.Parameters.AddWithValue("@count", textBoxCount.Text);
                cmd.Parameters.AddWithValue("@totalAll", textBoxAllTotal.Text);
                cmd.Parameters.AddWithValue("@check", done);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

        }//end insertData()
       private void insertTORevenueYes()  {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Revenue VALUES(@nameAgent, @total, @paid," +
                    " @change,@checkk)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@nameAgent", comboBoxAgent.Text);
                cmd.Parameters.AddWithValue("@total", textBoxAllTotal.Text);
                cmd.Parameters.AddWithValue("@paid", textBoxAllTotal.Text);
                cmd.Parameters.AddWithValue("@change", "0");
                cmd.Parameters.AddWithValue("@checkk", "نعم");

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//insertTORevenueYes

        private void insertIntoTotal() {
            //truncateTableFirst();
           string res = sumTotalNumbersFromRevenue();
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Total VALUES(@name, @total)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@name", comboBoxAgent.Text);
                cmd.Parameters.AddWithValue("@total", double.Parse(res));
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private string sumTotalNumbersFromRevenue()
        {
            string sumRes="0";
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            
            cmd.CommandText = "SELECT SUM(total) FROM Revenue WHERE nameAgent=@nameAgent";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nameAgent", comboBoxAgent.Text);
            SqlDataReader oReader = cmd.ExecuteReader();
            while (oReader.Read())
            {
                sumRes = oReader[0].ToString();
            }
            con.Close();
            return sumRes;
        }

        private void truncateTableFirst()
        {
            try
            {
                con.Open();
                cmd.CommandText = "TRUNCATE TABLE Total";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void insertTORevenueNo()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Revenue VALUES(@nameAgent, @total, @paid," +
                    " @change,@checkk)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@nameAgent", comboBoxAgent.Text);
                cmd.Parameters.AddWithValue("@total", textBoxAllTotal.Text);
                cmd.Parameters.AddWithValue("@paid", textBoxPaidd.Text);
                double total = double.Parse(textBoxAllTotal.Text);
                double priceres = double.Parse(textBoxPaidd.Text);

                string final = (total - priceres).ToString();
                cmd.Parameters.AddWithValue("@change", final);

                cmd.Parameters.AddWithValue("@checkk", "لا");

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLoad_OrServ_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
        }
        
        private void comboBoxAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAgent.SelectedIndex >-1)
            {
                getAgentKind();
            }
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
            if (comboBoxRawName.SelectedIndex >-1)
            {
                mCM = getRawMaterialCantiPriceDependingOnKind(comboBoxRawName.Text);
                if (textBoxWidth.Text != "" & textBoxLength.Text != "" && mCM !="-1")
                {
                    setMaterialPrice(mCM, textBoxLength.Text, textBoxWidth.Text);
                }
                sumToTotal(textBoxMaterialPrice.Text, textBoxMachinePrice.Text);
            }

        }

        private string getRawMaterialCantiPriceDependingOnKind(string text)
        {
            int agentKind;
            if (comboBoxAgent.SelectedIndex > -1)
            {
                agentKind = getAgentKind();
                switch (agentKind)
                {
                    case 0: //2ta3y
                        con.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT cantiLocalCost FROM RawMaterial WHERE name=@name";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@name", text);
                        string resLocal = cmd.ExecuteScalar().ToString();
                        con.Close();
                        return resLocal;

                    case 1: //5as
                        con.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT cantiSpecialCost FROM RawMaterial WHERE name=@name";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@name", text);
                        string resSpecial = cmd.ExecuteScalar().ToString();
                        con.Close();
                        return resSpecial;

                    case 2: // gomla
                        con.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT cantiManufactureCost FROM RawMaterial WHERE name=@name";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@name", text);
                        string resManufacture = cmd.ExecuteScalar().ToString();
                        con.Close();
                        return resManufacture;

                    case 3: //nos gomla
                        con.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT cantiHalfManuCost FROM RawMaterial WHERE name=@name";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@name", text);
                        string resHalfManu = cmd.ExecuteScalar().ToString();
                        con.Close();
                        return resHalfManu;

                    default:
                        return "-1";
                }//end switch
            }//end if

            else
            {
                MessageBox.Show("plz, pick an Agent First");
                return "-1";
            }
        }

        private void setMaterialPrice(string canti, string length, string width)
        {
            double CM_Number, length_Number, width_Number;
            CM_Number = double.Parse(canti);
          
            length_Number = double.Parse(length);
            width_Number = double.Parse(width);

            double res = CM_Number * length_Number * width_Number;
            textBoxMaterialPrice.Text = res.ToString();

            if (textBoxLength.Text !="" && textBoxWidth.Text !="")
            {
                if (comboBoxRawName.SelectedIndex > -1)
                {
                   double quantity = getQuantityFromRawMAterial(comboBoxRawName.Text);
                    if ((length_Number * width_Number) > quantity)
                    {
                        showNotifyLabel(quantity);
                    }
                    else
                    {
                        removeNotifyLabel();
                    }
                }
            }
        }

        private void removeNotifyLabel()
        {
            labelQuantity.Visible = false;
            labelQuantity.Text = "";
            labelQuantity.ForeColor = Color.Black;

            labelLength.ForeColor = Color.Black;
            labelWidth.ForeColor = Color.Black;
        }

        private double getQuantityFromRawMAterial(string name)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "SELECT quantity FROM RawMaterial WHERE name=@name";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@name", name);
            String res = command.ExecuteScalar().ToString();
            con.Close();
            return double.Parse(res);
        }

        private void showNotifyLabel(double quantity)
        {
            labelQuantity.Visible = true;
            labelQuantity.Text ="عفوا لديك كمية متوفرة الأن" +"="+quantity.ToString();
            labelQuantity.ForeColor = Color.Red;

            labelLength.ForeColor = Color.Red;
            labelWidth.ForeColor = Color.Red;
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

        private void textBoxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            setTotalPrice();
        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {
            setTotalPrice();
        }

        private void setTotalPrice()
        {
            if (textBoxCount.Text != "")
            {
                double onePrice = double.Parse(textBoxTotal.Text);
                double count = double.Parse(textBoxCount.Text);

                double res = onePrice * count;

                textBoxAllTotal.Text = res.ToString();

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                labelPaid.Visible = false;
                textBoxPaidd.Visible = false;
            }
            else
            {
                labelPaid.Visible = true;
                textBoxPaidd.Visible = true;
            }
        }
    }
}
