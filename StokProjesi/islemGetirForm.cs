using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                
                using (SqlCommand sqCommand = new SqlCommand("IslemGetirAscProc", _conn))
                {
                    sqCommand.CommandType = CommandType.StoredProcedure;
                    sqCommand.Parameters.Add("@PRCODE", SqlDbType.VarChar).Value = cbProductSelect.ValueMember.ToString();
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
                        MessageBox.Show("Can not open connection ! ");
                    }
                }
            }
        }

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
                    cbProductSelect.Items.Add(sqlReader["MalAdi"].ToString());
                    cbProductSelect.ValueMember = sqlReader["MalKodu"].ToString();
                    cbProductSelect.DisplayMember = sqlReader["MalAdi"].ToString();
                }

                sqlReader.Close();
            }
        }
    }
}
