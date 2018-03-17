using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tohfa
{
    public partial class Products : Form
    {
        //image
        String strFilePath = "";
        Image DefaultImage;
        Byte[] ImageByteArray = new byte[] { };

        //connection string
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd;
        DataTable dataTable;

        int codeNumber = 0;

        public Products()
        {
            InitializeComponent();
            DefaultImage = pictureBox1.Image;
            loadDataIntoDGV1();
            fillComboBoxDepartment();
            fillComboBoxMaterial();
        }

        private void fillComboBoxDepartment()
        {
            string query = "select name from Department";
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
                    comboBoxDepartment.Items.Add(col);
                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }//end fillComboBoxDepartment()

        private void fillComboBoxMaterial()
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
                    comboBoxMaterial.Items.Add(col);
                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }//end fillComboBoxDepartment()
        
        private void loadDataIntoDGV1()
        {

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Product";
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
            dataGridView1.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "كود";
            dataGridView1.Columns[2].HeaderText = "القسم";
            dataGridView1.Columns[3].HeaderText = "الإسم";
            dataGridView1.Columns[4].HeaderText = "الطول";
            dataGridView1.Columns[5].HeaderText = "العرض";
            dataGridView1.Columns[6].HeaderText = "الارتفاع";
            dataGridView1.Columns[7].HeaderText = "الخامة";
            dataGridView1.Columns[8].HeaderText = "نوع العمل";
            dataGridView1.Columns[9].HeaderText = "اللون";
            dataGridView1.Columns[10].HeaderText = "وقت الماكينة";
            dataGridView1.Columns[11].HeaderText = "سعر الخامة";
            dataGridView1.Columns[12].HeaderText = "سعر الماكينة";
            dataGridView1.Columns[13].HeaderText = "الإجمالى";
            dataGridView1.Columns[14].HeaderText = "الصورة";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[14].Visible = false;
        }

        void Clear()
        {
            pictureBox1.Image = DefaultImage;
            strFilePath = "";

            createNewCode();
            //comboBoxDepartment.SelectedIndex = -1;
            textBoxName.Clear();

            textBoxLength.Clear();
            textBoxWidth.Clear();
            textBoxHeight.Clear();
            //comboBoxMaterial.SelectedIndex = -1;
            textBoxColor.Clear();
            textBoxTime.Text = "0";
            textBoxMaterialPrice.Text = "0";
            textBoxMachinePrice.Text = "0";

        }

        private void buttonAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strFilePath = ofd.FileName;
                pictureBox1.Image = new Bitmap(strFilePath);
                if (textBoxName.Text.Trim().Length == 0)//Auto-Fill title if is empty
                    textBoxName.Text = Path.GetFileName(strFilePath);
            }
        }

        private void buttonNew_Product_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            Clear();
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
            newCode = "P" + codeNumber;
            textBoxCode.Text = newCode;
        }

        private string getLastCode()
        {
            if (isHasRows())
            {
                con.Open();
                string sqlquery = "SELECT TOP 1 code FROM Product ORDER BY id DESC";
                SqlCommand command = new SqlCommand(sqlquery, con);
                string value = command.ExecuteScalar().ToString();
                con.Close();
                return value;
            }
            else
            {
                return "P0";

            }
        }

        private bool isHasRows()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "SELECT * FROM Product";
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

        private void buttonAdd_Product_Click(object sender, EventArgs e)
        {
            if (strFilePath == "")
            {
                if (ImageByteArray.Length != 0)
                    ImageByteArray = new byte[] { };
            }
            else
            {
                Image temp = new Bitmap(strFilePath);
                MemoryStream strm = new MemoryStream();
                temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                ImageByteArray = strm.ToArray();
            }

            if (con.State == ConnectionState.Closed)
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Product VALUES(@code,@department," +
                "@name, @length, @width, @height, @rawMaterial, " +
                "@kind, @color, @time, @materialPrice, @machinePrice, @totalPrice, @image)";
            cmd.Connection = con;
            cmd.Parameters.Clear(); //veryImportant
            cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
            cmd.Parameters.AddWithValue("@department", comboBoxDepartment.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@length", textBoxLength.Text);
            cmd.Parameters.AddWithValue("@width", textBoxWidth.Text);
            cmd.Parameters.AddWithValue("@height", textBoxHeight.Text);
            cmd.Parameters.AddWithValue("@rawMaterial", comboBoxMaterial.Text);
            cmd.Parameters.AddWithValue("@kind", comboBoxWorkKind.Text);
            cmd.Parameters.AddWithValue("@color", textBoxColor.Text);
            cmd.Parameters.AddWithValue("@time", textBoxTime.Text);
            cmd.Parameters.AddWithValue("@materialPrice", textBoxMaterialPrice.Text);
            cmd.Parameters.AddWithValue("@machinePrice", textBoxMachinePrice.Text);
            cmd.Parameters.AddWithValue("@totalPrice", textBoxTotal.Text);
            cmd.Parameters.AddWithValue("@image", ImageByteArray);

            cmd.ExecuteNonQuery();
            Clear();
            con.Close();
            loadDataIntoDGV1();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonEdit.Text == "تعديل")
            {                
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    textBoxCode.Text = row.Cells[1].Value.ToString();
                    comboBoxDepartment.Text = row.Cells[2].Value.ToString();
                    textBoxName.Text = row.Cells[3].Value.ToString();
                    textBoxLength.Text = row.Cells[4].Value.ToString();
                    textBoxWidth.Text = row.Cells[5].Value.ToString();
                    textBoxHeight.Text = row.Cells[6].Value.ToString();
                    comboBoxMaterial.Text = row.Cells[7].Value.ToString();
                    comboBoxWorkKind.Text = row.Cells[8].Value.ToString();
                    textBoxColor.Text = row.Cells[9].Value.ToString();
                    textBoxTime.Text = row.Cells[10].Value.ToString();
                    textBoxMaterialPrice.Text = row.Cells[11].Value.ToString();
                    textBoxMachinePrice.Text = row.Cells[12].Value.ToString();

                    textBoxTotal.Text = row.Cells[13].Value.ToString();

                    byte[] ImageArray = (byte[])row.Cells[14].Value;
                    if (ImageArray.Length == 0)
                        pictureBox1.Image = DefaultImage;
                    else
                    {
                        ImageByteArray = ImageArray;
                        pictureBox1.Image = Image.FromStream(new MemoryStream(ImageArray));
                    }
                }//end if
            else
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                groupBox2.Text = "ستقوم بتعديل بيانات المنتج رقم: " + row.Cells[1].Value.ToString();
                textBoxCode.Text = row.Cells[1].Value.ToString();
                comboBoxDepartment.Text = row.Cells[2].Value.ToString();
                textBoxName.Text = row.Cells[3].Value.ToString();
                textBoxLength.Text = row.Cells[4].Value.ToString();
                textBoxWidth.Text = row.Cells[5].Value.ToString();
                textBoxHeight.Text = row.Cells[6].Value.ToString();
                comboBoxMaterial.Text = row.Cells[7].Value.ToString();
                comboBoxWorkKind.Text = row.Cells[8].Value.ToString();
                textBoxColor.Text = row.Cells[9].Value.ToString();
                textBoxTime.Text = row.Cells[10].Value.ToString();
                textBoxMaterialPrice.Text = row.Cells[11].Value.ToString();
                textBoxMachinePrice.Text = row.Cells[12].Value.ToString();

                textBoxTotal.Text = row.Cells[13].Value.ToString();

                byte[] ImageArray = (byte[])row.Cells[14].Value;
                if (ImageArray.Length == 0)
                    pictureBox1.Image = DefaultImage;
                else
                {
                    ImageByteArray = ImageArray;
                    pictureBox1.Image = Image.FromStream(new MemoryStream(ImageArray));
                }
            }//end else

        }

        private void buttonLoad_Product_Click(object sender, EventArgs e)
        {
            loadDataIntoDGV1();
        }

        #region textBoxEvents
        private void textBoxLength_Leave(object sender, EventArgs e)
        {
            double f;
            if (double.TryParse(textBoxLength.Text, out f))
            {
                // success! Use f here
                textBoxLength.Text = f.ToString();
            }
            else
                MessageBox.Show("enter a valid format");

        }

        private void textBoxWidth_Leave(object sender, EventArgs e)
        {
            double f;
            if (double.TryParse(textBoxWidth.Text, out f))
            {
                // success! Use f here
                textBoxWidth.Text = f.ToString();
            }
            else
                MessageBox.Show("enter a valid format");

        }

        private void textBoxHeight_Leave(object sender, EventArgs e)
        {
            double f;
            if (double.TryParse(textBoxHeight.Text, out f))
            {
                // success! Use f here
                textBoxHeight.Text = f.ToString();
            }
            else
                MessageBox.Show("enter a valid format");
        }

        private void textBoxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void textBoxMachinePrice_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMachinePrice.Text != "" || textBoxMachinePrice.Text == "0")
            {
                if (textBoxMaterialPrice.Text != "")
                {
                    textBoxTotal.Text = (double.Parse(textBoxMachinePrice.Text) +
                        double.Parse(textBoxMaterialPrice.Text)).ToString();
                }
            }
            else {
                textBoxTotal.Text = "0";
            }
        }

        private void textBoxMaterialPrice_TextChanged(object sender, EventArgs e)
        {

            if (textBoxMaterialPrice.Text != "" || textBoxMaterialPrice.Text == "0")
            {
                if (textBoxMachinePrice.Text != "")
                {
                    textBoxTotal.Text = (double.Parse(textBoxMaterialPrice.Text) +
                        double.Parse(textBoxMachinePrice.Text)).ToString();
                }
            }
            else
            {
                textBoxTotal.Text = "0";
            }
        }

        private void buttonDelete_Product_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string value;
                int i = dataGridView1.CurrentCell.RowIndex;
                value = dataGridView1.Rows[i].Cells[1].Value.ToString(); //get code

                deleteRecordFromDatabase(value);

                loadDataIntoDGV1();
            }
            else
                MessageBox.Show("اختر منتج للمسح");

        }

        private void deleteRecordFromDatabase(string value)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "DELETE FROM Product WHERE code = @code";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", value);
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
                    groupBox2.Text = "ستقوم بتعديل بيانات المنتج رقم: " + dataGridView1.Rows[i].Cells[1].Value.ToString();
                    textBoxCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    comboBoxDepartment.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    textBoxName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    textBoxLength.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    textBoxWidth.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    textBoxHeight.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    comboBoxMaterial.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    comboBoxWorkKind.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    textBoxColor.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                    textBoxTime.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                    textBoxMaterialPrice.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
                    textBoxMachinePrice.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();

                    textBoxTotal.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();

                    byte[] ImageArray = (byte[])dataGridView1.Rows[i].Cells[14].Value;
                    if (ImageArray.Length == 0)
                        pictureBox1.Image = DefaultImage;
                    else
                    {
                        ImageByteArray = ImageArray;
                        pictureBox1.Image = Image.FromStream(new MemoryStream(ImageArray));
                    }

                    buttonEditApprove.Enabled = true;
                    buttonAdd_Product.Enabled = false;

                    groupBox2.ForeColor = Color.Red;
                    groupBox2.Visible = true;
                }
                else
                    MessageBox.Show("اختر المنتج للتعديل");
            }
            else if (buttonEdit.Text == "الغاء التعديل")
            {
                buttonEdit.Text = "تعديل";
                groupBox2.Text = "";
                buttonAdd_Product.Enabled = true;
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
                if (strFilePath == "")
                {
                    if (ImageByteArray.Length != 0)
                        ImageByteArray = new byte[] { };
                }
                else
                {
                    Image temp = new Bitmap(strFilePath);
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ImageByteArray = strm.ToArray();
                }

                string sqlquery = "UPDATE Product SET code=@code, department=@department," +
                "name=@name, length=@length, width=@width, height=@height, rawMaterial=@rawMaterial, " +
                "kind=@kind, color=@color, time=@time, materialPrice=@materialPrice, machinePrice=@machinePrice, totalPrice=@totalPrice, image=@image WHERE code=@code";

                cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("@department", comboBoxDepartment.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@length", textBoxLength.Text);
                cmd.Parameters.AddWithValue("@width", textBoxWidth.Text);
                cmd.Parameters.AddWithValue("@height", textBoxHeight.Text);
                cmd.Parameters.AddWithValue("@rawMaterial", comboBoxMaterial.Text);
                cmd.Parameters.AddWithValue("@kind", comboBoxWorkKind.Text);
                cmd.Parameters.AddWithValue("@color", textBoxColor.Text);
                cmd.Parameters.AddWithValue("@time", textBoxTime.Text);
                cmd.Parameters.AddWithValue("@materialPrice", textBoxMaterialPrice.Text);
                cmd.Parameters.AddWithValue("@machinePrice", textBoxMachinePrice.Text);
                cmd.Parameters.AddWithValue("@totalPrice", textBoxTotal.Text);
                cmd.Parameters.AddWithValue("@image", ImageByteArray);
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
            loadDataIntoDGV1();
            groupBox2.ForeColor = Color.Black;
            groupBox2.Text = "";
        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaterial.SelectedIndex > -1)
            {
                string value = comboBoxMaterial.Text;
                getMaterialPrice(value);
            }
        }

        private void getMaterialPrice(String valName)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
        
            string sqlquery = "SELECT cantiLocalCost FROM RawMaterial WHERE name=@name";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@name", valName);
            textBoxMaterialPrice.Text = command.ExecuteScalar().ToString();
            con.Close();
        }

        private void checkBoxOpenText_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOpenText.Checked)
            {
                textBoxMaterialPrice.ReadOnly = true;
            }
            else
                textBoxMaterialPrice.ReadOnly = false;
        }

        private void comboBoxWorkKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWorkKind.SelectedIndex > -1)
            {
                switch (comboBoxWorkKind.SelectedIndex)
                {
                    case 0: //kat3
                        if (con.State != ConnectionState.Open)
                        {
                            con.Close();
                            con.Open();
                        }
                        string sqlquery = "SELECT CutLocal FROM CurrencyConfig";
                        SqlCommand command = new SqlCommand(sqlquery, con);
                        string text = command.ExecuteScalar().ToString();
                        double txt_num = double.Parse(text);
                        double time = double.Parse(textBoxTime.Text);
                        string res = (txt_num * time).ToString();
                        textBoxMachinePrice.Text = res;
                        con.Close();
                        break;
                    case 1: //7afr
                        if (con.State != ConnectionState.Open)
                        {
                            con.Close();
                            con.Open();
                        }
                        string sqlquery2 = "SELECT DigLocal FROM CurrencyConfig";
                        cmd = new SqlCommand(sqlquery2, con);
                       string text1 = cmd.ExecuteScalar().ToString();
                        double txt_num1 = double.Parse(text1);
                        double time1 = double.Parse(textBoxTime.Text);
                        string res1 = (txt_num1 * time1).ToString();
                        textBoxMachinePrice.Text = res1;
                        con.Close();
                        break;
                    case 2: // both of them
                        if (con.State != ConnectionState.Open)
                        {
                            con.Close();
                            con.Open();
                        }
                        string sqlquery3 = "SELECT DigCutLocal FROM CurrencyConfig";
                        cmd = new SqlCommand(sqlquery3, con);
                        string text2 = cmd.ExecuteScalar().ToString();
                        double txt_num2 = double.Parse(text2);
                        double time2 = double.Parse(textBoxTime.Text);
                        string res2 = (txt_num2 * time2).ToString();
                        textBoxMachinePrice.Text = res2;
                        con.Close();
                        break;
                    default:
                        break;
                }//end switch
                
            }//end if
        }//end 

        private void getMachinePrice() {

        }

        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxWorkKind.SelectedIndex> -1)
            {
                switch (comboBoxWorkKind.SelectedIndex)
                {
                    case 0: //kat3
                        if (con.State != ConnectionState.Open)
                        {
                            con.Close();
                            con.Open();
                        }
                        string sqlquery = "SELECT CutLocal FROM CurrencyConfig";
                        SqlCommand command = new SqlCommand(sqlquery, con);
                        string text = command.ExecuteScalar().ToString();
                        double txt_num = double.Parse(text);
                        double time = double.Parse(textBoxTime.Text);
                        string res = (txt_num * time).ToString();
                        textBoxMachinePrice.Text = res;
                        con.Close();
                        break;
                    case 1: //7afr
                        if (con.State != ConnectionState.Open)
                        {
                            con.Close();
                            con.Open();
                        }
                        string sqlquery2 = "SELECT DigLocal FROM CurrencyConfig";
                        cmd = new SqlCommand(sqlquery2, con);
                        string text1 = cmd.ExecuteScalar().ToString();
                        double txt_num1 = double.Parse(text1);
                        double time1 = double.Parse(textBoxTime.Text);
                        string res1 = (txt_num1 * time1).ToString();
                        textBoxMachinePrice.Text = res1;
                        con.Close();
                        break;
                    case 2: // both of them
                        if (con.State != ConnectionState.Open)
                        {
                            con.Close();
                            con.Open();
                        }
                        string sqlquery3 = "SELECT DigCutLocal FROM CurrencyConfig";
                        cmd = new SqlCommand(sqlquery3, con);
                        string text2 = cmd.ExecuteScalar().ToString();
                        double txt_num2 = double.Parse(text2);
                        double time2 = double.Parse(textBoxTime.Text);
                        string res2 = (txt_num2 * time2).ToString();
                        textBoxMachinePrice.Text = res2;
                        con.Close();
                        break;
                    default:
                        break;
                }//end switch
            }
        }
    }
}//end namespace