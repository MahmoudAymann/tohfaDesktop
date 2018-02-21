using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tohfa
{
    public partial class CurrencyConfig : Form
    {
        
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd;

        public CurrencyConfig()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM CurrencyConfig";
            SqlDataReader oReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(oReader);

            foreach (DataRow row in dt.Rows)
            {
                textBoxCutSpecial.Text = row["CutSpecial"].ToString();
                textBoxDigSpecial.Text = row["DigSpecial"].ToString();
                textBoxDigCutSpecial.Text = row["DigCutSpecial"].ToString();

                textBoxCutLocal.Text = row["CutLocal"].ToString();
                textBoxDigLocal.Text = row["DigLocal"].ToString();
                textBoxCutDigLocal.Text = row["DigCutLocal"].ToString();

                textBoxCutManufactory.Text = row["CutManufactory"].ToString();
                textBoxDigManufactory.Text = row["DigManufactory"].ToString();
                textBoxDigCutManufactory.Text = row["DigCutManufactory"].ToString();

                textBoxCutHalfManufactory.Text = row["CutHalfManufactory"].ToString();
                textBoxDigHalfManufactory.Text = row["DigHalfManufactory"].ToString();
                textBoxCutDigHalfManufactory.Text = row["DigCutHalfManufactory"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteRecords();
            insertIntoDataBase();
            loadData();
        }

        private void insertIntoDataBase()
        {

            con.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO CurrencyConfig (DigSpecial, CutSpecial, DigCutSpecial," +
                                                          "DigLocal, CutLocal, DigCutLocal," +
                                                          "DigManufactory, CutManufactory, DigCutManufactory," +
                                                          "DigHalfManufactory, CutHalfManufactory, DigCutHalfManufactory) VALUES " +
                                                          "(@DigSpecial, @CutSpecial, @DigCutSpecial," +
                                                          "@DigLocal, @CutLocal, @DigCutLocal," +
                                                          "@DigManufactory, @CutManufactory, @DigCutManufactory," +
                                                          "@DigHalfManufactory, @CutHalfManufactory, @DigCutHalfManufactory)";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DigSpecial",textBoxDigSpecial.Text);
            cmd.Parameters.AddWithValue("@CutSpecial", textBoxCutSpecial.Text);
            cmd.Parameters.AddWithValue("@DigCutSpecial", textBoxDigCutSpecial.Text);
            cmd.Parameters.AddWithValue("@DigLocal", textBoxDigLocal.Text);
            cmd.Parameters.AddWithValue("@CutLocal", textBoxCutLocal.Text);
            cmd.Parameters.AddWithValue("@DigCutLocal", textBoxCutDigLocal.Text);
            cmd.Parameters.AddWithValue("@DigManufactory", textBoxDigManufactory.Text);
            cmd.Parameters.AddWithValue("@CutManufactory", textBoxCutManufactory.Text);
            cmd.Parameters.AddWithValue("@DigCutManufactory", textBoxDigCutManufactory.Text);
            cmd.Parameters.AddWithValue("@DigHalfManufactory", textBoxDigHalfManufactory.Text);
            cmd.Parameters.AddWithValue("@CutHalfManufactory", textBoxCutHalfManufactory.Text);
            cmd.Parameters.AddWithValue("@DigCutHalfManufactory", textBoxCutDigHalfManufactory.Text);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("تم الحفظ");
        }

        private void deleteRecords()
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "TRUNCATE TABLE CurrencyConfig";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }//end delete records
    }
}
