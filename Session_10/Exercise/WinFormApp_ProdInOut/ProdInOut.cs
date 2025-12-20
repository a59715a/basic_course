using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormApp_ProdInOut
{
    public partial class ProdInOut : Form
    {
        public ProdInOut()
        {
            InitializeComponent();
        }
        // 資料庫連線字串
        string strConnString = @"data source=localhost;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";

        // 取得現在時間的13碼（民國年月日時分秒：yyyMMddhhmmss）
        private string GetDateToDate13()
        {
            // 取得現在時間
            DateTime now = DateTime.Now;
            // 取得民國年
            int rocYear = now.Year - 1911;
            // 回傳民國年月日時分秒的13碼 例如: 1141204203059
            return $"{rocYear:000}{now.Month:00}{now.Day:00}{now.Hour:00}{now.Minute:00}{now.Second:00}";
        }

        // 廠商代號離開事件
        private void txtInpFactNo_Leave(object sender, EventArgs e)
        {
            // 如果廠商代號為空，則不執行
            if (txtInpFactNo.Text.Trim() == "") return;

            // 轉換為大寫並去除空白
            txtInpFactNo.Text = txtInpFactNo.Text.Trim().ToUpper();

            // 嘗試執行
            try
            {
                // 建立資料庫連線
                using (SqlConnection mySqlConn = new SqlConnection(strConnString))
                {
                    // 開啟連線
                    mySqlConn.Open();

                    // 建立 SQL 查詢字串
                    string strSQL = "select * from FactoryTbl where chFactNo = '" + txtInpFactNo.Text.Trim() + "' ";
                    // 建立 SqlCommand 物件
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, mySqlConn))
                    {
                        // 建立 DataTable 物件
                        DataTable dtTbl = new DataTable();
                        // 執行 SQL 查詢並將結果載入 DataTable
                        dtTbl.Load(sqlCmd.ExecuteReader());
                        // 如果 DataTable 中沒有資料，則顯示錯誤訊息
                        if (dtTbl.Rows.Count == 0)
                        {
                            // 顯示錯誤訊息
                            MessageBox.Show("查無此廠商代號資料" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                            // 將焦點移到廠商代號欄位
                            txtInpFactNo.Focus();
                            return;
                        }

                        // 設定廠商名稱
                        txtFactName.Text = dtTbl.Rows[0]["chFactName"].ToString().Trim();

                        // 設定廠商代號顏色為紅色
                        txtInpFactNo.ForeColor = Color.Red;
                        // 設定廠商代號為唯讀
                        txtInpFactNo.ReadOnly = true;
                        // 設定廠商名稱顏色為紅色
                        txtFactName.ForeColor = Color.Red;

                    }   //using SqlCommand 結束
                }       //SqlConnection 結束
            }
            // 捕捉例外錯誤
            catch (Exception ex)
            {
                // 顯示例外錯誤訊息
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInpClear_Click(object sender, EventArgs e)
        {

            txtInpFactNo.Text = "";
            txtInpFactNo.ReadOnly = false;
            txtInpFactNo.ForeColor = System.Drawing.Color.Black;
            txtFactName.Text = "";
            txtFactName.ForeColor = System.Drawing.Color.Black;

            txtInpProdNo.Text = "";
            txtProdName.Text = "";

            txtInpPrice.Text = "";
            txtInpQty.Text = "";
            lblAmt.Text = "";
            txtInpUnit.Text = "";
        }

        // 廠商代號按下Enter事件
        private void txtInpFactNo_KeyDown(object sender, KeyEventArgs e)
        {
            // 如果按下Enter鍵，則跳到下一個欄位(Tab鍵)
            if (e.KeyCode == Keys.Enter)
            {
                // 跳到下一個欄位(Tab鍵)
                SendKeys.Send("{Tab}");
            }
        }

        // 確認按鈕按下事件
        private void btnInpOK_Click(object sender, EventArgs e)
        {
            // 如果產品代號為空，則不執行
            if (txtInpProdNo.Text.Trim() == "") return;

            // 轉換為大寫並去除空白
            txtInpProdNo.Text = txtInpProdNo.Text.Trim().ToUpper();

            try
            {
                // 建立資料庫連線
                using (SqlConnection mySqlConn = new SqlConnection(strConnString))
                {
                    // 開啟連線
                    mySqlConn.Open();

                    // 建立 SQL 查詢字串
                    // 1. 檢查廠商代號是否存在
                    string strSQL = "select * from FactoryTbl where chFactNo = '" + txtInpFactNo.Text.Trim() + "' ";
                    // 建立 SqlCommand 物件
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, mySqlConn))
                    {
                        // 建立 DataTable 物件
                        DataTable dtTbl = new DataTable();
                        // 執行 SQL 查詢並將結果載入 DataTable
                        dtTbl.Load(sqlCmd.ExecuteReader());
                        // 如果 DataTable 中沒有資料，則顯示錯誤訊息
                        if (dtTbl.Rows.Count == 0)
                        {
                            // 顯示錯誤訊息
                            MessageBox.Show("查無此廠商代號" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                            // 將焦點移到廠商代號欄位
                            return;
                        }
                    }
                    // 2. 檢查產品代號是否存在
                    strSQL = "select * from ProductTbl where chProdNo = '" + txtInpProdNo.Text.Trim() + "' ";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, mySqlConn))
                    {
                        // 建立 DataTable 物件
                        DataTable dtTbl = new DataTable();
                        // 執行 SQL 查詢並將結果載入 DataTable
                        dtTbl.Load(sqlCmd.ExecuteReader());
                        // 如果 DataTable 中沒有資料，則顯示錯誤訊息
                        if (dtTbl.Rows.Count == 0)
                        {
                            // 設定產品名稱
                            txtProdName.Text = dtTbl.Rows[0]["chProdName"].ToString().Trim();
                            // 顯示錯誤訊息
                            MessageBox.Show("查無此產品代號" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                            // 將焦點移到產品代號欄位
                            txtInpProdNo.Focus();
                            return;
                        }
                    }

                    // 3. 檢查單價不可為【 0 及空白 】
                    if (txtInpPrice.Text.Trim() == "" || txtInpPrice.Text.Trim() == "0")
                    {
                        MessageBox.Show("單價不可為【 0 及空白 】" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                        txtInpPrice.Focus();
                        return;
                    }

                    // 檢查單價是否為數字
                    // 宣告變數 用來儲存轉換後單價的數值
                    decimal mDeciNumber = 0;
                    // 檢查單價是否為數字
                    bool mDeciFlag = decimal.TryParse(txtInpPrice.Text.Trim(), out mDeciNumber);
                    // 檢查單價是否為數字
                    if (mDeciFlag == false)
                    {
                        MessageBox.Show("單價只可為數字【 0-9 . - 】等" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                        txtInpPrice.Focus();
                        return;
                    }
                    // 4. 檢查進貨數量不可為【 0 及空白 】
                    if (txtInpQty.Text.Trim() == "" || txtInpQty.Text.Trim() == "0")
                    {
                        MessageBox.Show("進貨數量不可為【 0 及空白 】" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                        txtInpQty.Focus();
                        return;
                    }
                    // 檢查進貨數量是否為數字
                    mDeciNumber = 0;
                    // 檢查進貨數量是否為數字
                    mDeciFlag = decimal.TryParse(txtInpQty.Text.Trim(), out mDeciNumber);
                    // 檢查進貨數量是否為數字
                    if (mDeciFlag == false)
                    {
                        MessageBox.Show("進貨數量只可為數字【 0-9 . - 】等" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                        txtInpQty.Focus();
                        return;
                    }

                    //新增至DataGridView
                    DgvInp.Rows.Add(txtInpProdNo.Text.Trim(), txtProdName.Text.Trim(), txtInpPrice.Text.Trim(), txtInpQty.Text.Trim(), lblAmt.Text.Trim(), txtInpUnit.Text.Trim());
                    // 檢查進貨日期時間是否為空
                    if (txtInpDateTime.Text.Trim() == "")
                    {
                        // 取得現在時間的13碼
                        string tmpDate = GetDateToDate13();
                        // 設定進貨日期時間
                        txtInpDateTime.Text = tmpDate.Substring(0, 7) + "-" + tmpDate.Substring(7, 6);
                    }
                    // 清除5個欄位
                    txtInpProdNo.Text = "";
                    txtProdName.Text = "";

                    txtInpPrice.Text = "";
                    txtInpQty.Text = "";
                    lblAmt.Text = "";
                    txtInpUnit.Text = "";

                    // 將焦點移到產品代號欄位
                    txtInpProdNo.Focus();

                }       //SqlConnection 結束
            }
            // 捕捉例外錯誤
            catch (Exception ex)
            {
                // 顯示例外錯誤訊息
                MessageBox.Show(ex.Message);
            }
        }

        // 單張儲存按鈕按下事件   整張訂單儲存到資料庫
        private void btnSaveInpDgv_Click(object sender, EventArgs e)
        {
            // 如果DataGridView中沒有資料，則不執行
            if (DgvInp.Rows.Count == 0) return;

            // 如果產品代號、單價、進貨數量為空，則顯示錯誤訊息
            if (txtInpProdNo.Text.Trim() != "" || txtInpPrice.Text.Trim() != "" || txtInpQty.Text.Trim() != "")
            {
                MessageBox.Show("螢幕上尚未未完成的輸入資料" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                return;
            }
            // 建立資料庫連線
            using (SqlConnection mySqlConn = new SqlConnection(strConnString))
            {
                try
                {
                    mySqlConn.Open();

                    // 開始交易
                    SqlTransaction myTransaction = mySqlConn.BeginTransaction();
                    // 嘗試執行
                    try
                    {
                        // 準備進貨日期時間字串 民國年月日時分秒：yyyMMddhhmmss
                        string inpDateTime = txtInpDateTime.Text.Substring(0, 7) + txtInpDateTime.Text.Substring(8, 6);
                        string factNo = txtInpFactNo.Text.Trim();
                        decimal mInpTotAmt = 0;

                        // 在迴圈外建立共用的 SqlCommand 物件
                        SqlCommand sqlCmd = new SqlCommand();
                        // 設定 SqlCommand 的 Connection
                        sqlCmd.Connection = mySqlConn;
                        // 設定 SqlCommand 的 Transaction
                        sqlCmd.Transaction = myTransaction;

                        // 迴圈處理 DataGridView 中的每一筆資料
                        for (int i = 0; i < DgvInp.Rows.Count; i++)
                        {
                            // 取得 DataGridView 中的資料
                            string prodNo = DgvInp.Rows[i].Cells["ProdNo"].Value.ToString().Trim();
                            string inpPrice = DgvInp.Rows[i].Cells["InpPrice"].Value.ToString().Trim();
                            string inpQty = DgvInp.Rows[i].Cells["InpQty"].Value.ToString().Trim();
                            string inpAmt = DgvInp.Rows[i].Cells["InpAmt"].Value.ToString().Trim();

                            // 累加總金額
                            mInpTotAmt = mInpTotAmt + decimal.Parse(inpAmt);

                            // 1. 新增進貨單身（InputDetailTbl）
                            string strSQL = "INSERT INTO InputDetailTbl (chInpDateTime, chFactNo, chProdNo, rlInpPrice, rlInpQty, rlInpAmt) " +
                                           "VALUES ('" + inpDateTime + "', '" + factNo + "', '" + prodNo + "', " +
                                           inpPrice + ", " + inpQty + ", " + inpAmt + ")";

                            sqlCmd.CommandText = strSQL;
                            sqlCmd.ExecuteNonQuery();

                            // 2. 更新商品庫存主檔的庫存數量
                            strSQL = "UPDATE ProductTbl SET rlStockQty = rlStockQty + " + inpQty +
                                     " WHERE chProdNo = '" + prodNo + "'";

                            sqlCmd.CommandText = strSQL;
                            sqlCmd.ExecuteNonQuery();
                        }

                        // 3. 新增進貨單頭（InputHeadTbl）
                        string insertHeadSQL = "INSERT INTO InputHeadTbl (chInpDateTime, chFactNo, rlInpTotAmt) " +
                                              "VALUES ('" + inpDateTime + "', '" + factNo + "', " + Convert.ToString(mInpTotAmt) + ")";

                        sqlCmd.CommandText = insertHeadSQL;
                        sqlCmd.ExecuteNonQuery();

                        // 確認交易
                        myTransaction.Commit();
                        // 顯示訊息
                        MessageBox.Show("按任一鍵繼續!", "匯入成功!!");
                        // 清除按鈕按下事件
                        btnInpClear_Click(null, null);
                        // 清除DataGridView中的資料
                        DgvInp.Rows.Clear();
                        // 清除進貨日期時間
                        txtInpDateTime.Text = "";
                    }
                    catch (Exception ex)
                    {
                        // 回滾交易
                        myTransaction.Rollback();
                        // 顯示例外錯誤訊息
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    //外層的Exception 只為抓取connection Error; 其他的Error幾乎都在內層Exception的範圍內
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // 當表單激活時，將焦點移到廠商代號欄位
        private void ProdInOut_Activated(object sender, EventArgs e)
        {
            txtInpFactNo.Focus();
        }

        // 產品代號按下Enter事件
        private void txtProdNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        // 單價按下Enter事件
        private void txtInpPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        // 進貨數量按下Enter事件
        private void txtInpQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        // 檢查產品代號是否存在並即時顯示產品名稱、單價、數量、單位
        private void txtProdNo_Leave(object sender, EventArgs e)
        {
            if (txtInpProdNo.Text.Trim() == "") return;

            //txtProdNo.Text = txtProdNo.Text.ToUpper();

            try
            {
                using (SqlConnection mySqlConn = new SqlConnection(strConnString))
                {
                    // 開啟連線
                    mySqlConn.Open();

                    string strSQL = "select * from ProductTbl where chProdNo = '" + txtInpProdNo.Text.Trim() + "' ";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, mySqlConn))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sqlCmd.ExecuteReader());
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("查無此產品代號資料" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                            txtInpProdNo.Focus();
                            return;
                        }

                        txtProdName.Text = dt.Rows[0]["chProdName"].ToString().Trim();                                       //產品名稱
                        if (txtInpPrice.Text.Trim() == "") txtInpPrice.Text = dt.Rows[0]["rlInpPrice"].ToString().Trim();    //進貨(參考)單價
                        if (txtInpQty.Text.Trim() == "") txtInpQty.Text = "0";                                                  //進貨數量
                        if (txtInpUnit.Text.Trim() == "") txtInpUnit.Text = dt.Rows[0]["chUnit"].ToString().Trim();                //單位
                    }   //using SqlCommand End
                }       //SqlConnection using End
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        // 檢查單價是否為數字並即時計算單項金額
        private void txtInpPrice_Leave(object sender, EventArgs e)
        {
            //單價為空白及0, 先不擋
            if (txtInpPrice.Text.Trim() == "" || txtInpPrice.Text.Trim() == "0")
            {
                lblAmt.Text = "";
                return;
            }

            decimal mDeciNumber = 0;
            bool mDeciFlag = decimal.TryParse(txtInpPrice.Text.Trim(), out mDeciNumber);
            if (mDeciFlag == false)
            {
                MessageBox.Show("單價只可為數字【 0-9 . - 】等" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                lblAmt.Text = "";
                txtInpPrice.Focus();
                return;
            }

            if (txtInpQty.Text.Trim() != "" && txtInpQty.Text.Trim() != "0")
            {
                lblAmt.Text = Convert.ToString(mDeciNumber * decimal.Parse(txtInpQty.Text.Trim()));
            }
        }

        // 檢查進貨數量是否為數字並即時計算單項金額
        private void txtInpQty_Leave(object sender, EventArgs e)
        {
            //進貨數量為空白及0, 先不擋
            if (txtInpQty.Text.Trim() == "" || txtInpQty.Text.Trim() == "0")
            {
                lblAmt.Text = "";
                return;
            }

            decimal mDeciNumber = 0;
            bool mDeciFlag = decimal.TryParse(txtInpQty.Text.Trim(), out mDeciNumber);
            if (mDeciFlag == false)
            {
                MessageBox.Show("進貨數量只可為數字【 0-9 . - 】等" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                lblAmt.Text = "";
                txtInpQty.Focus();
                return;
            }

            if (txtInpPrice.Text.Trim() != "" && txtInpPrice.Text.Trim() != "0")
            {
                lblAmt.Text = Convert.ToString(mDeciNumber * decimal.Parse(txtInpPrice.Text.Trim()));
            }
        }

        // 清除DataGridView中的資料
        private void btnClearInpDgv_Click(object sender, EventArgs e)
        {
            if (DgvInp.RowCount == 0) return;

            DialogResult myResult = MessageBox.Show("確定要將底下單張資料都清除?", "敬請再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                DgvInp.Rows.Clear();
                txtInpDateTime.Text = "";
                MessageBox.Show("按任一鍵離開!", "清除成功");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInpQty_Click(object sender, EventArgs e)
        {
            txtInpQty.SelectAll();
        }

        private void btnInpDetailQuery_Click(object sender, EventArgs e)
        {
            // 步驟一：驗證日期格式
            if (txtInpDetailSDate.Text.Length != 7 || txtInpDetailEDate.Text.Length != 7)
            {
                MessageBox.Show("起迄日期需為7碼日期, eg.1141201" + "\r\n\r\n" + "按任一鍵離開!", "日期錯誤!!!");
                txtInpDetailSDate.Focus();
                return;
            }

            // 步驟二：設定游標為等待狀態，並初始化總金額標籤
            this.Cursor = Cursors.WaitCursor;
            lblInpDetailTotAmt.Text = "";
            lblInpDetailTotAmt.Visible = false;
            try
            {
                using (SqlConnection mySqlConn = new SqlConnection(strConnString))
                {
                    mySqlConn.Open();

                    // ---------------------------------------------
                    // 請學生實作：撰寫 SQL 查詢語句
                    // ---------------------------------------------
                    string strSQL = @"請學生實作";

                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, mySqlConn))
                    {
                        // 執行查詢並載入 DataTable
                        DataTable dt = new DataTable();
                        dt.Load(sqlCmd.ExecuteReader());

                        // 步驟五：檢查是否有查詢結果
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("查詢區間內無進貨資料。" + "\r\n\r\n" + "按任一鍵離開!", "查無資料，敬請確認！！！");
                            this.Cursor = Cursors.Default;
                            return;
                        }

                        // ---------------------------------------------
                        // 請學生實作：將 DataTable 綁定到 DataGridView
                        // ---------------------------------------------




                        // ---------------------------------------------
                        // 請學生實作：計算DataGridView總金額，並顯示在lblInpDetailTotAmt標籤中
                        // ---------------------------------------------
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }




        private void btnInpDetailClear_Click(object sender, EventArgs e)
        {
            lblInpDetailTotAmt.Text = "";
            lblInpDetailTotAmt.Visible = false;

            dgvInpDetailReport.DataSource = null;
        }
        private void btnTranTest_Click(object sender, EventArgs e)
        {
            TestTran tranTestForm = new TestTran();
            tranTestForm.ShowDialog();
        }

        private void btnDataGridView_Click(object sender, EventArgs e)
        {
            TestDataGridView testDataGridView = new TestDataGridView();
            testDataGridView.ShowDialog();
        }

        private void txtOutFactNo_Leave(object sender, EventArgs e)
        {
            if (txtOutFactNo.Text.Trim() == "") return;
            txtOutFactNo.Text = txtOutFactNo.Text.Trim().ToUpper();
            try
            {
                // 建立資料庫連線
                using (SqlConnection mySqlConn = new SqlConnection(strConnString))
                {
                    mySqlConn.Open();
                    string strSQL = "select * from FactoryTbl where chFactNo = '" + txtOutFactNo.Text.Trim() + "' ";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, mySqlConn))
                    {
                        DataTable dtTbl = new DataTable();
                        dtTbl.Load(sqlCmd.ExecuteReader());
                        if (dtTbl.Rows.Count == 0)
                        {
                            MessageBox.Show("查無此廠商代號資料" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                            txtOutFactNo.Focus();
                            return;
                        }
                        txtOutFactName.Text = dtTbl.Rows[0]["chFactName"].ToString().Trim();
                        txtOutFactNo.ForeColor = Color.Red;
                        txtOutFactNo.ReadOnly = true;
                        txtOutFactName.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtOutProdNo_Leave(object sender, EventArgs e)
        {
            if (txtOutProdNo.Text.Trim() == "") return;
            try
            {
                using (SqlConnection mySqlConn = new SqlConnection(strConnString))
                {
                    mySqlConn.Open();
                    string strSQL = "select * from ProductTbl where chProdNo = '" + txtOutProdNo.Text.Trim() + "' ";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, mySqlConn))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sqlCmd.ExecuteReader());
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("查無此產品代號資料" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                            txtOutProdNo.Focus();
                            return;
                        }
                        txtOutProdName.Text = dt.Rows[0]["chProdName"].ToString().Trim();
                        if (txtOutPrice.Text.Trim() == "") txtOutPrice.Text = dt.Rows[0]["rlSellPrice"].ToString().Trim();
                        if (txtOutQty.Text.Trim() == "") txtOutQty.Text = "0";
                        if (txtOutUnit.Text.Trim() == "") txtOutUnit.Text = dt.Rows[0]["chUnit"].ToString().Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtOutPrice_Leave(object sender, EventArgs e)
        {
            if (txtOutPrice.Text.Trim() == "" || txtOutPrice.Text.Trim() == "0")
            {
                lblOutAmt.Text = "";
                return;
            }
            decimal mDeciNumber = 0;
            bool mDeciFlag = decimal.TryParse(txtOutPrice.Text.Trim(), out mDeciNumber);
            if (mDeciFlag == false)
            {
                MessageBox.Show("單價只可為數字【 0-9 . - 】等" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                lblOutAmt.Text = "";
                txtOutPrice.Focus();
                return;
            }
            if (txtOutQty.Text.Trim() != "" && txtOutQty.Text.Trim() != "0")
            {
                lblOutAmt.Text = Convert.ToString(mDeciNumber * decimal.Parse(txtOutQty.Text.Trim()));
            }
        }

        private void txtOutQty_Leave(object sender, EventArgs e)
        {
            if (txtOutQty.Text.Trim() == "" || txtOutQty.Text.Trim() == "0")
            {
                lblOutAmt.Text = "";
                return;
            }
            decimal mDeciNumber = 0;
            bool mDeciFlag = decimal.TryParse(txtOutQty.Text.Trim(), out mDeciNumber);
            if (mDeciFlag == false)
            {
                MessageBox.Show("出貨數量只可為數字【 0-9 . - 】等" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                lblOutAmt.Text = "";
                txtOutQty.Focus();
                return;
            }
            if (txtOutPrice.Text.Trim() != "" && txtOutPrice.Text.Trim() != "0")
            {
                lblOutAmt.Text = Convert.ToString(mDeciNumber * decimal.Parse(txtOutPrice.Text.Trim()));
            }
        }

        // 確認按鈕按下事件（出貨系統）
        private void btnOutOK_Click(object sender, EventArgs e)
        {
            if (txtOutProdNo.Text.Trim() == "") return;
            txtOutProdNo.Text = txtOutProdNo.Text.Trim().ToUpper();
            try
            {
                using (SqlConnection mySqlConn = new SqlConnection(strConnString))
                {
                    mySqlConn.Open();
                    string strSQL = "select * from FactoryTbl where chFactNo = '" + txtOutFactNo.Text.Trim() + "' ";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, mySqlConn))
                    {
                        DataTable dtTbl = new DataTable();
                        dtTbl.Load(sqlCmd.ExecuteReader());
                        if (dtTbl.Rows.Count == 0)
                        {
                            MessageBox.Show("查無此廠商代號" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                            return;
                        }
                    }
                    strSQL = "select * from ProductTbl where chProdNo = '" + txtOutProdNo.Text.Trim() + "' ";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, mySqlConn))
                    {
                        DataTable dtTbl = new DataTable();
                        dtTbl.Load(sqlCmd.ExecuteReader());
                        if (dtTbl.Rows.Count == 0)
                        {
                            MessageBox.Show("查無此產品代號" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                            txtOutProdNo.Focus();
                            return;
                        }
                    }
                    if (txtOutPrice.Text.Trim() == "" || txtOutPrice.Text.Trim() == "0")
                    {
                        MessageBox.Show("單價不可為【 0 及空白 】" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                        txtOutPrice.Focus();
                        return;
                    }
                    decimal mDeciNumber = 0;
                    bool mDeciFlag = decimal.TryParse(txtOutPrice.Text.Trim(), out mDeciNumber);
                    if (mDeciFlag == false)
                    {
                        MessageBox.Show("單價只可為數字【 0-9 . - 】等" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                        txtOutPrice.Focus();
                        return;
                    }
                    if (txtOutQty.Text.Trim() == "" || txtOutQty.Text.Trim() == "0")
                    {
                        MessageBox.Show("出貨數量不可為【 0 及空白 】" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                        txtOutQty.Focus();
                        return;
                    }
                    mDeciNumber = 0;
                    mDeciFlag = decimal.TryParse(txtOutQty.Text.Trim(), out mDeciNumber);
                    if (mDeciFlag == false)
                    {
                        MessageBox.Show("出貨數量只可為數字【 0-9 . - 】等" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                        txtOutQty.Focus();
                        return;
                    }
                    strSQL = "select rlStockQty from ProductTbl where chProdNo = '" + txtOutProdNo.Text.Trim() + "' ";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, mySqlConn))
                    {
                        decimal currentStock = Convert.ToDecimal(sqlCmd.ExecuteScalar());
                        decimal outQty = decimal.Parse(txtOutQty.Text.Trim());

                        // 檢查本次出貨數量是否超過庫存（假設一張單同一個產品只會有一筆）
                        if (currentStock < outQty)
                        {
                            MessageBox.Show("商品 " + txtOutProdNo.Text.Trim() + " 庫存不足！" + "\r\n" +
                                          "目前庫存：" + currentStock + "\r\n" +
                                          "本次出貨數量：" + outQty + "\r\n\r\n" +
                                          "按任一鍵離開!", "敬請確認");
                            txtOutQty.Focus();
                            return;
                        }
                    }

                    DgvOut.Rows.Add(txtOutProdNo.Text.Trim(), txtOutProdName.Text.Trim(), txtOutPrice.Text.Trim(), txtOutQty.Text.Trim(), lblOutAmt.Text.Trim(), txtOutUnit.Text.Trim());
                    if (txtOutDateTime.Text.Trim() == "")
                    {
                        string tmpDate = GetDateToDate13();
                        txtOutDateTime.Text = tmpDate.Substring(0, 7) + "-" + tmpDate.Substring(7, 6);
                    }
                    txtOutProdNo.Text = "";
                    txtOutProdName.Text = "";

                    txtOutPrice.Text = "";
                    txtOutQty.Text = "";
                    lblOutAmt.Text = "";
                    txtOutUnit.Text = "";

                    txtOutProdNo.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOutClear_Click(object sender, EventArgs e)
        {

            txtOutFactNo.Text = "";
            txtOutFactNo.ReadOnly = false;
            txtOutFactNo.ForeColor = System.Drawing.Color.Black;
            txtOutFactName.Text = "";
            txtOutFactName.ForeColor = System.Drawing.Color.Black;

            txtOutProdNo.Text = "";
            txtOutProdName.Text = "";

            txtOutPrice.Text = "";
            txtOutQty.Text = "";
            lblOutAmt.Text = "";
            txtOutUnit.Text = "";
        }

        private void btnClearOutDgv_Click(object sender, EventArgs e)
        {
            if (DgvOut.RowCount == 0) return;

            DialogResult myResult = MessageBox.Show("確定要將底下單張資料都清除?", "敬請再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                DgvOut.Rows.Clear();
                txtOutDateTime.Text = "";
                MessageBox.Show("按任一鍵離開!", "清除成功");
            }

        }

        private void btnSaveOutDgv_Click(object sender, EventArgs e)
        {
            // 如果DataGridView中沒有資料，則不執行
            if (DgvOut.Rows.Count == 0) return;

            // 如果產品代號、單價、出貨數量為空，則顯示錯誤訊息
            if (txtOutProdNo.Text.Trim() != "" || txtOutPrice.Text.Trim() != "" || txtOutQty.Text.Trim() != "")
            {
                MessageBox.Show("螢幕上尚未未完成的輸入資料" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
                return;
            }
            // 建立資料庫連線
            using (SqlConnection mySqlConn = new SqlConnection(strConnString))
            {
                try
                {
                    mySqlConn.Open();

                    // 開始交易
                    SqlTransaction myTransaction = mySqlConn.BeginTransaction();
                    // 嘗試執行
                    try
                    {
                        // 準備出貨日期時間字串 民國年月日時分秒：yyyMMddhhmmss
                        string outDateTime = txtOutDateTime.Text.Substring(0, 7) + txtOutDateTime.Text.Substring(8, 6);
                        string factNo = txtOutFactNo.Text.Trim();
                        decimal mOutTotAmt = 0;

                        // 在迴圈外建立共用的 SqlCommand 物件
                        SqlCommand sqlCmd = new SqlCommand();
                        sqlCmd.Connection = mySqlConn;
                        // 設定 SqlCommand 的 Transaction
                        sqlCmd.Transaction = myTransaction;

                        // 迴圈處理 DataGridView 中的每一筆資料
                        for (int i = 0; i < DgvOut.Rows.Count; i++)
                        {
                            // 取得 DataGridView 中的資料
                            string prodNo = DgvOut.Rows[i].Cells["OutProdNo"].Value.ToString().Trim();
                            string outPrice = DgvOut.Rows[i].Cells["OutPrice"].Value.ToString().Trim();
                            string outQty = DgvOut.Rows[i].Cells["OutQty"].Value.ToString().Trim();
                            string outAmt = DgvOut.Rows[i].Cells["OutAmt"].Value.ToString().Trim();

                            // 累加總金額
                            mOutTotAmt = mOutTotAmt + decimal.Parse(outAmt);

                            // 1. 新增出貨單身（OutputDetailTbl）
                            string strSQL = "INSERT INTO OutputDetailTbl (chOutpDateTime, chFactNo, chProdNo, rlOutpPrice, rlQty, rlOutpAmt) " +
                                           "VALUES ('" + outDateTime + "', '" + factNo + "', '" + prodNo + "', " +
                                           outPrice + ", " + outQty + ", " + outAmt + ")";

                            sqlCmd.CommandText = strSQL;
                            sqlCmd.ExecuteNonQuery();

                            // 2. 更新商品庫存主檔的庫存數量（減少庫存）
                            strSQL = "UPDATE ProductTbl SET rlStockQty = rlStockQty - " + outQty +
                                     " WHERE chProdNo = '" + prodNo + "'";

                            sqlCmd.CommandText = strSQL;
                            sqlCmd.ExecuteNonQuery();
                        }

                        // 3. 新增出貨單頭（OutputHeadTbl）
                        string insertHeadSQL = "INSERT INTO OutputHeadTbl (chOutpDateTime, chFactNo, rlOutpTotAmt) " +
                                              "VALUES ('" + outDateTime + "', '" + factNo + "', " + Convert.ToString(mOutTotAmt) + ")";

                        sqlCmd.CommandText = insertHeadSQL;
                        sqlCmd.ExecuteNonQuery();

                        // 確認交易
                        myTransaction.Commit();
                        // 顯示訊息
                        MessageBox.Show("按任一鍵繼續!", "匯入成功!!");
                        // 清除按鈕按下事件
                        btnOutClear_Click(null, null);
                        // 清除DataGridView中的資料
                        DgvOut.Rows.Clear();
                        // 清除出貨日期時間
                        txtOutDateTime.Text = "";
                    }
                    catch (Exception ex)
                    {
                        // 回滾交易
                        myTransaction.Rollback();
                        // 顯示例外錯誤訊息
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    //外層的Exception 只為抓取connection Error; 其他的Error幾乎都在內層Exception的範圍內
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
