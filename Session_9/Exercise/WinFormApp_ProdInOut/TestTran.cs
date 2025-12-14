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
    public partial class TestTran : Form
    {
        public TestTran()
        {
            InitializeComponent();
        }
        string strConnString = @"data source=localhost;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";

        private void btnTranTest_Click(object sender, EventArgs e)
        {

            // 資料庫連線
            using (SqlConnection sqlConn = new SqlConnection(strConnString))
            {
                // 開啟連線
                sqlConn.Open();
                // 建立 SqlCommand 物件
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    // 設定連線
                    sqlCmd.Connection = sqlConn;
                    // 開始交易
                    sqlCmd.Transaction = sqlConn.BeginTransaction();
                    try
                    {
                        // 共要做兩件事 1. 插入ProductTbl 2. 插入FactoryTbl

                        // 插入ProductTbl 新增一筆資料
                        sqlCmd.CommandText = "INSERT INTO ProductTbl (chProdNo, chProdName, chUnit, rlStockQty, rlInpPrice, rlSellPrice, chCreatDateTime) VALUES ('T001', '交易測試iPhone 17 Pro Max', '片', 100, 200, 300, '11412022130')";
                        Console.WriteLine("準備執行新增一筆資料到 ProductTbl");
                        sqlCmd.ExecuteNonQuery();
                        // 插入FactoryTbl 新增一筆資料
                        sqlCmd.CommandText = "INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('T002', '交易測試公司')";
                        Console.WriteLine("準備執行新增一筆資料到 FactoryTbl");
                        sqlCmd.ExecuteNonQuery();

                        // update chFactNo	chFactName   F001      	台積電  
                        sqlCmd.CommandText = "UPDATE FactoryTbl SET chFactName = '交易測試台積電' WHERE chFactNo = 'F001'";
                        Console.WriteLine("準備執行更新一筆資料到 FactoryTbl");
                        sqlCmd.ExecuteNonQuery();





                        Console.WriteLine("能走到這一步，已經執行成功 但還沒交易成功，也就是一切還不算，若要確定將變更確定，需要執行Commit");
                        sqlCmd.Transaction.Commit();


                        MessageBox.Show("交易成功");
                        Console.WriteLine("走到這一步，交易成功");
                    }
                    catch (Exception ex)
                    {
                        sqlCmd.Transaction.Rollback();
                        Console.WriteLine("走到這一步，因為跳出例外錯誤，所以一切回滾");
                        MessageBox.Show("交易失敗，已回滾，原因：" + ex.Message);

                    }
                }
            }
        }
    }
}
