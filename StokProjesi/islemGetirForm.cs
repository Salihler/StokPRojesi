using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace StokProjesi
{
    public partial class islemGetirForm : Form
    {
        private SqlConnection _conn;

        public islemGetirForm()
        {
            InitializeComponent();
            PopulateDropDown();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            using (_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString))
            {
                vgData.DataSource = null;
                vgData.DefaultView.PopulateColumns();

                using (SqlCommand sqCommand = new SqlCommand("IslemGetirAscProc", _conn))
                {
                    sqCommand.CommandType = CommandType.StoredProcedure;
                    sqCommand.Parameters.Add("@PRCODE", SqlDbType.VarChar).Value = cbProductSelect.SelectedItem;
                    sqCommand.Parameters.Add("@STARTDATE ", SqlDbType.Int).Value = Convert.ToInt32(dtpStartingDate.Value.ToOADate());
                    sqCommand.Parameters.Add("@ENDDATE", SqlDbType.Int).Value = Convert.ToInt32(dtpEndingDate.Value.ToOADate());

                    try
                    {
                        if (sqCommand.Connection.State == ConnectionState.Closed)
                        {
                            sqCommand.Connection.Open();
                        }

                        SqlDataReader sqlReader = sqCommand.ExecuteReader();

                        vgData.DataSource = sqlReader;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        //Form yüklendiğinde dropdown menüyü doldurur.
        private void PopulateDropDown()
        {
            using (_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString))
            {
                SqlCommand sqlCmd = new SqlCommand("select * from STK", _conn);

                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }

                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    cbProductSelect.Items.Add(sqlReader["MalKodu"].ToString());
                }

                sqlReader.Close();
            }
        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";

                if (DialogResult.OK == saveDialog.ShowDialog())
                {
                    string path = saveDialog.FileName;
                    vgData.ExportToXlsx(path);
                }
            }
        }
    }
}
