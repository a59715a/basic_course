using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp_ProdInOut
{
    public partial class TestDataGridView : Form
    {
        public TestDataGridView()
        {
            InitializeComponent();
        }



        private void btnFactAddRow_Click(object sender, EventArgs e)
        {
            dgvFact.Rows.Add("F000", "測試資料");
        }

        private void btnFactClear_Click(object sender, EventArgs e)
        {
            dgvFact.Rows.Clear();
            dgvFact2.DataSource = null;
        }



        private void btnFactPrint_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvFact.Rows.Count; i++)
            {
                if (dgvFact.Rows[i].IsNewRow) continue; // 若是最後一行的空白列，則跳過不列印
                Console.WriteLine("廠商編號：" + dgvFact.Rows[i].Cells["chFactNo"].Value.ToString() +
                                                     "，廠商名稱：" + dgvFact.Rows[i].Cells["chFactName"].Value.ToString());
            }
            Console.WriteLine("總列數（含空白列）：" + dgvFact.Rows.Count);
        }

        private void btnSelectFactDataSourse_Click(object sender, EventArgs e)
        {
            string strConnString = @"data source=localhost;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
            using (SqlConnection sqlConn = new SqlConnection(strConnString))
            {
                sqlConn.Open();
                string strSQL = "SELECT chFactNo as '廠商代號唷' ,chFactName as '這是廠商名稱' FROM FactoryTbl";
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(strSQL, sqlConn))
                {
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dgvFact2.DataSource = dt;
                }
            }
        }

        private void btnSelectFactFor_Click(object sender, EventArgs e)
        {
            string strConnString = @"data source=localhost;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
            using (SqlConnection sqlConn = new SqlConnection(strConnString))
            {
                sqlConn.Open();
                string strSQL = "SELECT chFactNo,chFactName  FROM FactoryTbl";
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, sqlConn))
                {
                    DataTable dt = new DataTable();
                    dt.Load(sqlCmd.ExecuteReader());
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgvFact.Rows.Add(dt.Rows[i]["chFactNo"].ToString(), dt.Rows[i]["chFactName"].ToString());
                    }
                }
            }
        }


    }
}
