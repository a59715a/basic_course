using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeSample1_5Function
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            cboSex.Items.Clear();
            cboSex.Items.Add("0.女");
            cboSex.Items.Add("1.男");
            // 初始化時，更新存檔和刪除按鈕設為不可見
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {

            // 如果 txtID TextBox 的內容為空，則顯示訊息 查詢時身分證字號不可為空白 並按任一鍵離開
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("查詢時身分證字號不可為空白", "輸入錯誤!");
                return;
            }

            try
            {
                // 將游標設為等待狀態
                this.Cursor = Cursors.WaitCursor;

                // 宣告字串變數：連線字串
                // 連線字串 格式為 "data source=資料庫伺服器位址;initial catalog=資料庫名稱; user id=使用者名稱;password=密碼;MultipleActiveResultSets=true"
                string sqlConnString = @"data source=localhost;initial catalog=DB_TEST; user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                // 使用 using 宣告 連線物件 物件　SqlConnection sql_Conn
                using (SqlConnection sql_Conn = new SqlConnection())
                {
                    // 設定 資料庫連線物件 sql_Conn　的 連線字串屬性 ConnectionString 為 sqlConnString
                    sql_Conn.ConnectionString = sqlConnString;
                    // 開啟資料庫連線 
                    sql_Conn.Open();
                    // 宣告字串變數：SQL 指令 查詢 AddressBookTbl 資料表中 chID 欄位等於 txtID.Text.Trim() 的資料 抓第一筆
                    string strSQL = "select Top 1 * from AddressBookTbl where chID = '" + txtID.Text.Trim() + "' ";
                    // 使用 using 宣告 SqlCommand 物件   此物件用於執行SQL指令 sqlcmd
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        // 設定 SqlCommand 物件的 SQL 指令
                        sqlcmd.CommandText = strSQL;
                        // 設定 SqlCommand 物件的連線物件
                        sqlcmd.Connection = sql_Conn;
                        // 執行 SQL 指令 並將結果存入 DataTable 物件 dt
                        DataTable dt = new DataTable();
                        dt.Load(sqlcmd.ExecuteReader());
                        // 如果 dt 物件的資料筆數為 0，則顯示訊息 查無此身分證字號資料 並按任一鍵離開
                        if (dt.Rows.Count == 0)
                        {
                            // 顯示訊息 查無此身分證字號資料 並按任一鍵離開
                            // 格式為 MessageBox.Show("內容", "標題");
                            MessageBox.Show("查無此身分證字號資料", "查不到資料");
                            // 跳出此function
                            return;
                        }

                        // 如果 dt 裡面有資料，則將資料顯示在 TextBox 中
                        // 將 dt 物件的 chID 欄位資料顯示在 txtID TextBox 中
                        txtID.Text = dt.Rows[0]["chID"].ToString().Trim();
                        // 將 dt 物件的 chName 欄位資料顯示在 txtName TextBox 中
                        txtName.Text = dt.Rows[0]["chName"].ToString().Trim();
                        // 將 dt 物件的 chBirthday 欄位資料顯示在 txtBirthday TextBox 中
                        txtBirthday.Text = dt.Rows[0]["chBirthday"].ToString().Trim();
                        // 如果 dt 物件的 chSex 欄位資料為 0，則將 cboSex 的 SelectedIndex 設為 0 ，如果為 1，則將 cboSex 的 SelectedIndex 設為 1，如果為其他，則將 cboSex 的 Text 設為 dt 物件的 chSex 欄位資料
                        // 先將 cboSex 的 SelectedIndex 設為 -1 ，表示沒有選擇任何選項
                        cboSex.SelectedIndex = -1;
                        if (dt.Rows[0]["chSex"].ToString().Trim() == "0")
                        {
                            cboSex.SelectedIndex = 0;
                        }
                        else if (dt.Rows[0]["chSex"].ToString().Trim() == "1")
                        {
                            cboSex.SelectedIndex = 1;
                        }
                        else
                        {
                            cboSex.Text = dt.Rows[0]["chSex"].ToString().Trim();
                        }

                        // 將 dt 物件的 chTel 欄位資料顯示在 txtTel TextBox 中
                        txtTel.Text = dt.Rows[0]["chTel"].ToString().Trim();
                        // 將 dt 物件的 chAddress 欄位資料顯示在 txtAddress TextBox 中
                        txtAddress.Text = dt.Rows[0]["chAddress"].ToString().Trim();

                        // 設定 txtID TextBox 的 Enabled 屬性為 false ，因為已經查詢到資料，所以不能修改ID
                        txtID.Enabled = false;
                        // 查詢成功後，隱藏新增、查詢按鈕，顯示更新存檔和刪除按鈕
                        btnAdd.Visible = false;
                        btnQuery.Visible = false;
                        btnUpdate.Visible = true;
                        btnDelete.Visible = true;

                    }   //using SqlCommand sqlcmd End
                }       //using SqlConnection sql_Conn End
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message, "錯誤");
            }
            finally
            {
                // finally 區塊 ，用於最後執行，無論是否發生錯誤，都會執行
                // 將游標設為預設狀態
                this.Cursor = Cursors.Default;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 如果 txtID TextBox 的內容為空，則顯示訊息 身分證字號不可為空白 並按任一鍵離開
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("身分證字號不可為空白", "輸入錯誤!");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //宣告:字串變數 ; 並給予內容: MSSQL連線字串
                string sqlConnString = @"data source=localhost;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                using (SqlConnection sql_Conn = new SqlConnection())
                {
                    sql_Conn.ConnectionString = sqlConnString;
                    sql_Conn.Open();   //真正去連線資料庫
                    string strSQL = "select * from AddressBookTbl where chID = '" + txtID.Text.Trim() + "' ";
                    // 使用 using 宣告 SqlCommand 物件 sqlcmd ，並設定 SQL 指令為 strSQL ，連線物件為 sql_Conn
                    using (SqlCommand sqlcmd = new SqlCommand(strSQL, sql_Conn))
                    {

                        // 先查詢 是否存在此身分證字號的資料

                        DataTable dt = new DataTable();     //宣告以及產生物件                            
                        dt.Load(sqlcmd.ExecuteReader());        //真正去執行sqlcmd 的 SQL指令
                        // 如果 dt 物件的資料筆數大於 0，則顯示訊息 此身分證字號已經存在 並按任一鍵離開
                        if (dt.Rows.Count > 0)
                        {
                            // 將游標設為預設狀態
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("此身分證字號已經存在", "資料已存在");
                            return;
                        }


                        // 新增資料到資料庫
                        // 組裝insert SQL 指令
                        string insertSQL = "INSERT INTO AddressBookTbl (chID, chName, chBirthday, chSex, chTel, chAddress) VALUES ('" +
                            txtID.Text.ToString().Trim() + "', '" +
                            txtName.Text.ToString().Trim() + "', '" +
                            txtBirthday.Text.ToString().Trim() + "', '" +
                            cboSex.Text.ToString().Trim().Substring(0, 1) + "', '" + //性別欄位只取第一個字元  從index 0 開始取 取1個字元
                            txtTel.Text.ToString().Trim() + "', '" +
                            txtAddress.Text.ToString().Trim() + "')";
                        // 設定 SqlCommand 物件的 SQL 指令
                        sqlcmd.CommandText = insertSQL;
                        // 執行 SQL 指令 並將結果存入 DataTable 物件 dt
                        sqlcmd.ExecuteNonQuery();     //更新資料庫
                        // 設定 txtID TextBox 的 Enabled 屬性為 false ，因為已經新增資料，所以不能修改ID
                        txtID.Enabled = false;
                        // 將游標設為預設狀態
                        this.Cursor = Cursors.Default;
                        // 顯示訊息 新增成功 並按任一鍵離開
                        MessageBox.Show("資料已新增成功", "成功");
                        // 呼叫 查詢 按鈕事件，顯示剛新增的資料
                        btnQuery_Click(null, null);
                    } //SqlCommand using End
                }     //SqlConnection using End 
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message, "錯誤");
            }
            finally
            {
                // finally 區塊 ，用於最後執行，無論是否發生錯誤，都會執行
                // 將游標設為預設狀態
                this.Cursor = Cursors.Default;
            }
        }
        // 清除 TextBox 的內容
        private void btnClear_Click(object sender, EventArgs e)
        {
            // 將所有欄位內容清空
            txtID.Text = "";
            txtName.Text = "";
            txtBirthday.Text = "";
            cboSex.Text = "";
            txtTel.Text = "";
            txtAddress.Text = "";
            // 重置 txtID TextBox 的狀態 ，設 Enabled 屬性為 true ，可以輸入內容
            txtID.Enabled = true;
            // 恢復新增和查詢按鈕的可見狀態
            btnAdd.Visible = true;
            btnQuery.Visible = true;
            // 隱藏更新存檔和刪除按鈕
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        // 當輸入狀態由 txtID TextBox 離開時，將 txtID TextBox 的內容轉換為大寫
        private void txtID_Leave(object sender, EventArgs e)
        {
            // 將 txtID TextBox 的內容轉換為大寫
            txtID.Text = txtID.Text.ToUpper();
        }

        // 更新存檔按鈕
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 如果 txtID TextBox 的內容為空，則顯示訊息 更新時身分證字號不可為空白 並按任一鍵離開
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("更新時身分證字號不可為空白", "輸入錯誤!");
                return;
            }

            try
            {
                // 將游標設為等待狀態
                this.Cursor = Cursors.WaitCursor;

                // 宣告字串變數：連線字串
                string sqlConnString = @"data source=localhost;initial catalog=DB_TEST; user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                // 使用 using 宣告 連線物件 物件　SqlConnection sql_Conn
                using (SqlConnection sql_Conn = new SqlConnection())
                {
                    // 設定 資料庫連線物件 sql_Conn　的 連線字串屬性 ConnectionString 為 sqlConnString
                    sql_Conn.ConnectionString = sqlConnString;
                    // 開啟資料庫連線 
                    sql_Conn.Open();
                    // 宣告字串變數：SQL 指令 查詢 AddressBookTbl 資料表中 chID 欄位等於 txtID.Text.Trim() 的資料
                    string strSQL = "select * from AddressBookTbl where chID = '" + txtID.Text.Trim() + "' ";
                    // 使用 using 宣告 SqlCommand 物件   此物件用於執行SQL指令 sqlcmd
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        // 設定 SqlCommand 物件的 SQL 指令
                        sqlcmd.CommandText = strSQL;
                        // 設定 SqlCommand 物件的連線物件
                        sqlcmd.Connection = sql_Conn;
                        // 執行 SQL 指令 並將結果存入 DataTable 物件 dt
                        DataTable dt = new DataTable();
                        dt.Load(sqlcmd.ExecuteReader());
                        // 如果 dt 物件的資料筆數為 0，則顯示訊息 查無此身分證字號資料，無法更新 並按任一鍵離開
                        if (dt.Rows.Count == 0)
                        {
                            // 將游標設為預設狀態
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("查無此身分證字號資料，無法更新", "查不到資料");
                            // 跳出此function
                            return;
                        }

                        // 如果 dt 裡面有資料，則組裝 UPDATE SQL 指令並執行
                        // 組裝 UPDATE SQL 指令
                        string updateSQL = "UPDATE AddressBookTbl SET " +
                            "chName = '" + txtName.Text.ToString().Trim() + "', " +
                            "chBirthday = '" + txtBirthday.Text.ToString().Trim() + "', " +
                            "chSex = '" + cboSex.Text.ToString().Trim().Substring(0, 1) + "', " +  // 性別欄位只取第一個字元
                            "chTel = '" + txtTel.Text.ToString().Trim() + "', " +
                            "chAddress = '" + txtAddress.Text.ToString().Trim() + "' " +
                            "WHERE chID = '" + txtID.Text.ToString().Trim() + "'";
                        // 設定 SqlCommand 物件的 SQL 指令
                        sqlcmd.CommandText = updateSQL;
                        // 執行 SQL 指令
                        sqlcmd.ExecuteNonQuery();
                        // 將游標設為預設狀態
                        this.Cursor = Cursors.Default;
                        // 顯示訊息 資料已更新成功 並按任一鍵離開
                        MessageBox.Show("資料已更新成功", "成功");
                        // 呼叫 查詢 按鈕事件，顯示剛更新的資料
                        btnQuery_Click(null, null);
                    }   //using SqlCommand sqlcmd End
                }       //using SqlConnection sql_Conn End
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message, "錯誤");
            }
            finally
            {
                // finally 區塊 ，用於最後執行，無論是否發生錯誤，都會執行
                // 將游標設為預設狀態
                this.Cursor = Cursors.Default;
            }
        }

        // 刪除按鈕
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 如果 txtID TextBox 的內容為空，則顯示訊息 刪除時身分證字號不可為空白 並按任一鍵離開
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("刪除時身分證字號不可為空白", "輸入錯誤!");
                return;
            }

            // 顯示確認對話框
            DialogResult result = MessageBox.Show(
                "確定要刪除此筆資料嗎？",
                "確認刪除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // 如果使用者選擇「否」，則不執行刪除
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                // 將游標設為等待狀態
                this.Cursor = Cursors.WaitCursor;

                // 宣告字串變數：連線字串
                string sqlConnString = @"data source=localhost;initial catalog=DB_TEST; user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                // 使用 using 宣告 連線物件 物件　SqlConnection sql_Conn
                using (SqlConnection sql_Conn = new SqlConnection())
                {
                    // 設定 資料庫連線物件 sql_Conn　的 連線字串屬性 ConnectionString 為 sqlConnString
                    sql_Conn.ConnectionString = sqlConnString;
                    // 開啟資料庫連線 
                    sql_Conn.Open();
                    // 宣告字串變數：SQL 指令 查詢 AddressBookTbl 資料表中 chID 欄位等於 txtID.Text.Trim() 的資料
                    string strSQL = "select Top 1 * from AddressBookTbl where chID = '" + txtID.Text.Trim() + "' ";
                    // 使用 using 宣告 SqlCommand 物件   此物件用於執行SQL指令 sqlcmd
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        // 設定 SqlCommand 物件的 SQL 指令
                        sqlcmd.CommandText = strSQL;
                        // 設定 SqlCommand 物件的連線物件
                        sqlcmd.Connection = sql_Conn;
                        // 執行 SQL 指令 並將結果存入 DataTable 物件 dt
                        DataTable dt = new DataTable();
                        dt.Load(sqlcmd.ExecuteReader());
                        // 如果 dt 物件的資料筆數為 0，則顯示訊息 查無此身分證字號資料，無法刪除 並按任一鍵離開
                        if (dt.Rows.Count == 0)
                        {
                            // 將游標設為預設狀態
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("查無此身分證字號資料，無法刪除", "查不到資料");
                            // 跳出此function
                            return;
                        }

                        // 如果 dt 裡面有資料，則組裝 DELETE SQL 指令並執行
                        // 組裝 DELETE SQL 指令
                        string deleteSQL = "DELETE FROM AddressBookTbl WHERE chID = '" + txtID.Text.ToString().Trim() + "'";
                        // 設定 SqlCommand 物件的 SQL 指令
                        sqlcmd.CommandText = deleteSQL;
                        // 執行 SQL 指令
                        sqlcmd.ExecuteNonQuery();
                        // 將游標設為預設狀態
                        this.Cursor = Cursors.Default;
                        // 顯示訊息 資料已刪除成功 並按任一鍵離開
                        MessageBox.Show("資料已刪除成功", "成功");
                        // 清除所有欄位
                        btnClear_Click(null, null);
                    }   //using SqlCommand sqlcmd End
                }       //using SqlConnection sql_Conn End
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message, "錯誤");
            }
            finally
            {
                // finally 區塊 ，用於最後執行，無論是否發生錯誤，都會執行
                // 將游標設為預設狀態
                this.Cursor = Cursors.Default;
            }
        }

        // 結束程式
        private void btnEnd_Click(object sender, EventArgs e)
        {
            // 關閉程式
            this.Close();
        }

    }
}
