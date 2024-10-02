using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Stuff
{
    public partial class frmExcel : Form
    {
        public frmExcel()
        {
            InitializeComponent();
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            openFileExcel.InitialDirectory = @"C:\"; //--"C:\\";
            openFileExcel.Filter = "Excel File|*.xls;*.xlsx";
            openFileExcel.FilterIndex = 1;
            this.openFileExcel.ShowDialog();
            if (this.openFileExcel.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.openFileExcel.FileName;
                txtBoxfilePath.Text = fileName;
                string con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
                con = string.Format(con, fileName, "yes");
                OleDbConnection excelconnection = new OleDbConnection(con);
                excelconnection.Open();
                DataTable exdt = excelconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string excelsheet = exdt.Rows[0]["TABLE_NAME"].ToString();
                OleDbCommand com = new OleDbCommand("Select * from [" + excelsheet + "]", excelconnection);
                OleDbDataAdapter oda = new OleDbDataAdapter(com);
                DataTable mainexdt = new DataTable();
                oda.Fill(mainexdt);
                excelconnection.Close();
                dataGridView1.DataSource = mainexdt;

            }

        }

       
    }
}
