# 📖 C#單元九：出貨系統與報表（SQL JOIN 與 DataGridView 資料綁定）

---

## 🎯 單元目標

- ✅ 建立出貨系統所需的資料表
- ✅ 實作出貨表單功能（參考進貨系統架構）
- ✅ 了解 SQL JOIN 的種類與用法
- ✅ 深入理解 LEFT JOIN 的撰寫方式與結果
- ✅ 學會使用欄位別名（Alias）
- ✅ 完成進貨明細報表功能
- ✅ 完成出貨明細報表作業

---

## 📋 單元一：建立出貨系統所需的資料表

本單元將在 `DB_TEST` 資料庫中建立出貨系統所需的六個資料表。

### 🎯 資料表設計說明

出貨系統採用「單頭單身」的資料庫設計架構，與進貨系統類似：

- **單頭（Head）**：一張出貨單的基本資訊（出貨日期時間、廠商代號、總金額）
- **單身（Detail）**：一張出貨單的明細資料（商品代號、出貨數量、單價、金額）

**關係說明**：

- 一筆出貨單（單頭）對應多筆出貨明細（單身）
- 一筆出貨單只對應一個廠商
- 一筆出貨明細只對應一個商品

### 📝 資料表一：FactoryTbl（廠商主檔）

```sql
USE [DB_TEST]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FactoryTbl](
	[chFactNo] [char](10) NOT NULL,
	[chFactName] [char](100) NULL,
 CONSTRAINT [PK_FactoryTbl] PRIMARY KEY CLUSTERED 
(
	[chFactNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

#### 新增測試資料

```sql
INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('F001', '台積電');
INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('F002', '聯發科技');
INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('F003', '台達電');
INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('F004', '鴻海');
INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('F005', '仁寶');
```

### 📝 資料表二：ProductTbl（商品主檔）

```sql
USE [DB_TEST]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductTbl](
	[chProdNo] [char](7) NOT NULL,
	[chProdName] [char](100) NOT NULL,
	[chUnit] [char](4) NULL,
	[rlStockQty] [real] NULL,
	[rlInpPrice] [real] NULL,
	[rlSellPrice] [real] NULL,
	[chCreatDateTime] [char](11) NULL,
 CONSTRAINT [PK_ProductTbl] PRIMARY KEY CLUSTERED 
(
	[chProdNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

#### 新增測試資料

```sql
INSERT INTO ProductTbl (chProdNo, chProdName, chUnit, rlStockQty, rlInpPrice, rlSellPrice, chCreatDateTime) VALUES ('P001', 'iPhone 17 Pro', '支', 100, 250, 400, '11412021530');
INSERT INTO ProductTbl (chProdNo, chProdName, chUnit, rlStockQty, rlInpPrice, rlSellPrice, chCreatDateTime) VALUES ('P002', 'SAMSUNG Galaxy S25', '支', 100, 200, 300, '11412021440');
INSERT INTO ProductTbl (chProdNo, chProdName, chUnit, rlStockQty, rlInpPrice, rlSellPrice, chCreatDateTime) VALUES ('P003', 'Google Pixel 8', '支', 100, 200, 300, '11412022130');

```

### 📝 資料表三：InputHeadTbl（進貨單頭）

```sql
USE [DB_TEST]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InputHeadTbl](
	[chInpDateTime] [char](13) NOT NULL,
	[chFactNo] [char](10) NOT NULL,
	[rlInpTotAmt] [real] NULL,
 CONSTRAINT [PK_InputHeadTbl] PRIMARY KEY CLUSTERED 
(
	[chInpDateTime] ASC,
	[chFactNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

### 📝 資料表四：InputDetailTbl（進貨單身）

```sql
USE [DB_TEST]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InputDetailTbl](
	[chInpDateTime] [char](13) NOT NULL,
	[chFactNo] [char](10) NOT NULL,
	[chProdNo] [char](7) NOT NULL,
	[rlInpQty] [real] NULL,
	[rlInpPrice] [real] NULL,
	[rlInpAmt] [real] NULL,
 CONSTRAINT [PK_InputDetailTbl] PRIMARY KEY CLUSTERED 
(
	[chInpDateTime] ASC,
	[chFactNo] ASC,
	[chProdNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

### 📝 資料表五：OutputHeadTbl（出貨單頭）

```sql
USE [DB_TEST]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OutputHeadTbl](
	[chOutpDateTime] [char](13) NOT NULL,
	[chFactNo] [char](10) NOT NULL,
	[rlOutpTotAmt] [real] NULL,
 CONSTRAINT [PK_OutputHeadTbl] PRIMARY KEY CLUSTERED 
(
	[chOutpDateTime] ASC,
	[chFactNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

### 📝 資料表六：OutputDetailTbl（出貨單身）

```sql
USE [DB_TEST]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OutputDetailTbl](
	[chOutpDateTime] [char](13) NOT NULL,
	[chFactNo] [char](10) NOT NULL,
	[chProdNo] [char](7) NOT NULL,
	[rlQty] [real] NULL,
	[rlOutpPrice] [real] NULL,
	[rlOutpAmt] [real] NULL,
 CONSTRAINT [PK_OutputDetailTbl] PRIMARY KEY CLUSTERED 
(
	[chOutpDateTime] ASC,
	[chFactNo] ASC,
	[chProdNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

### ✅ 驗證資料表建立成功

1. 在「物件總管」中，展開 `DB_TEST` 資料庫
2. 展開「資料表」節點
3. 您應該會看到以下六個資料表：

   - `dbo.FactoryTbl`
   - `dbo.ProductTbl`
   - `dbo.InputHeadTbl`
   - `dbo.InputDetailTbl`
   - `dbo.OutputHeadTbl`
   - `dbo.OutputDetailTbl`
4. 如果沒有看到，請在「資料表」節點上按右鍵，選擇「重新整理」

   ![1765555699319](image/Course9/1765555699319.png)

---

## 💻 單元二：實作出貨表單

本單元將參考進貨系統的架構，實作出貨表單功能。

### 🎯 功能流程說明

1. **使用者輸入廠商代號** → 系統查詢並顯示廠商名稱
2. **使用者輸入商品代號** → 系統查詢並顯示商品資訊（名稱、單位、參考單價）
3. **使用者輸入出貨單價和數量** → 系統自動計算金額
4. **使用者按下「確定」按鈕** → 將資料新增到 DataGridView
5. **使用者按下「單張儲存」按鈕** → 將 DataGridView 中的資料儲存到資料庫

### 📝 步驟一：設計出貨系統介面(已完成)

1. 參考進貨系統的介面設計
2. 建立出貨系統表單
3. 加入 DataGridView 控制項
4. 設定 DataGridView 欄位（產品代號、產品名稱、出貨單價、出貨數量、金額、產品單位）

   ![1765635435154](image/Course9/1765635435154.png)

### 📝 步驟二：實作出貨單的操作

#### 2.1 廠商代號查詢功能

參考進貨系統的 `txtInpFactNo_Leave` 事件處理，實作出貨系統的 `txtOutFactNo_Leave` 事件處理。

```csharp
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
```

#### 2.2 商品代號查詢功能

參考進貨系統的 `txtInpProdNo_Leave` 事件處理，實作出貨系統的 `txtOutProdNo_Leave` 事件處理。
出貨單價通常使用商品的售價（`rlSellPrice`）。

```csharp
請同學練習實作  txtOutProdNo_Leave
```

#### 2.3 金額自動計算功能

參考進貨系統的 `txtInpPrice_Leave` 和 `txtInpQty_Leave` 事件處理，實作出貨系統的 `txtOutPrice_Leave` 和 `txtOutQty_Leave` 事件處理。

**出貨系統程式碼範例：**

```csharp
// 檢查單價是否為數字並即時計算單項金額
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

```

```csharp
txtOutQty_Leave 請同學練習實作
```

#### 2.4 新增資料到 DataGridView 功能

參考進貨系統的 `btnInpOK_Click` 事件處理，實作出貨系統的 `btnOutOK_Click` 事件處理。

記得檢查庫存數量是否足夠（出貨數量不能超過庫存數量）。

```csharp
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
                        // ExecuteScalar() 是把第一列第一欄的資料抓出來
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

                    // ---------------------------------------------------------------------------
					// 此處請同學實作新增資料至DataGridView
					// ---------------------------------------------------------------------------
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
```

#### 2.5 清螢幕功能

參考進貨系統的 `btnInpClear_Click` 事件處理，實作出貨系統的 `btnOutClear_Click` 事件處理。

```csharp
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
```

#### 2.6 單張清除功能

參考進貨系統的 `btnClearInpDgv_Click` 事件處理，實作出貨系統的 `btnClearOutDgv_Click` 事件處理。

```csharp
btnClearOutDgv_Click  請同學練習實作

```

### 📝 步驟三：實作出貨單儲存功能（含 SqlTransaction）

#### 3.1 使用 Transaction 確保資料一致性

參考進貨系統的 `btnSaveInpDgv_Click` 事件處理，實作出貨系統的 `btnSaveOutDgv_Click` 事件處理。
出貨單儲存需要同時處理多個資料表：

1. **新增出貨單頭**（OutputHeadTbl）
2. **新增出貨單身**（OutputDetailTbl）- 可能有多筆
3. **更新商品庫存**（ProductTbl）- **減少**庫存數量

但實際操作順序是

1. 新增出貨單身（OutputDetailTbl）
2. 更新商品庫存（ProductTbl）
3. 新增出貨單頭（OutputHeadTbl）

#### 3.2 實作步驟說明

請同學根據以下步驟，自行實作 `btnSaveOutDgv_Click` 事件處理：

**步驟 1：基本驗證**

```csharp
// 如果DataGridView中沒有資料，則不執行
if (DgvOut.Rows.Count == 0) return;

// 如果產品代號、單價、出貨數量為空，則顯示錯誤訊息
if (txtOutProdNo.Text.Trim() != "" || txtOutPrice.Text.Trim() != "" || txtOutQty.Text.Trim() != "")
{
    MessageBox.Show("螢幕上尚未未完成的輸入資料" + "\r\n\r\n" + "按任一鍵離開!", "敬請確認");
    return;
}
```

**步驟 2：建立資料庫連線並開始交易**

```csharp
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
            // ... 後續步驟在此實作
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
```

**步驟 3：準備基本變數**

```csharp
// 準備出貨日期時間字串 民國年月日時分秒：yyyMMddhhmmss
string outDateTime = txtOutDateTime.Text.Substring(0, 7) + txtOutDateTime.Text.Substring(8, 6);
string factNo = txtOutFactNo.Text.Trim();
decimal mOutTotAmt = 0;

// 在迴圈外建立共用的 SqlCommand 物件
SqlCommand sqlCmd = new SqlCommand();
sqlCmd.Connection = mySqlConn;
// 設定 SqlCommand 的 Transaction
sqlCmd.Transaction = myTransaction;
```

**步驟 4：迴圈處理 DataGridView 中的每一筆資料**

```csharp
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
  
    // ... 後續步驟在此實作
}
```

**步驟 5：新增出貨單身（OutputDetailTbl）**

```csharp
// 1. 新增出貨單身（OutputDetailTbl）
string strSQL = "INSERT INTO OutputDetailTbl (chOutpDateTime, chFactNo, chProdNo, rlOutpPrice, rlQty, rlOutpAmt) " +
               "VALUES ('" + outDateTime + "', '" + factNo + "', '" + prodNo + "', " +
               outPrice + ", " + outQty + ", " + outAmt + ")";

sqlCmd.CommandText = strSQL;
sqlCmd.ExecuteNonQuery();
```

**步驟 6：更新商品庫存主檔的庫存數量（減少庫存）**

```csharp
// 2. 更新商品庫存主檔的庫存數量（減少庫存）
strSQL = "UPDATE ProductTbl SET rlStockQty = rlStockQty - " + outQty +
         " WHERE chProdNo = '" + prodNo + "'";

sqlCmd.CommandText = strSQL;
sqlCmd.ExecuteNonQuery();
```

**步驟 7：新增出貨單頭（OutputHeadTbl）**

```csharp
// 3. 新增出貨單頭（OutputHeadTbl）
string insertHeadSQL = "INSERT INTO OutputHeadTbl (chOutpDateTime, chFactNo, rlOutpTotAmt) " +
                      "VALUES ('" + outDateTime + "', '" + factNo + "', " + Convert.ToString(mOutTotAmt) + ")";

sqlCmd.CommandText = insertHeadSQL;
sqlCmd.ExecuteNonQuery();
```

**步驟 8：確認交易並清除畫面**

```csharp
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
```

#### 3.3 完整程式碼範例（請同學練習實作）

請同學根據上述步驟，完成 `btnSaveOutDgv_Click` 事件處理的實作：

```csharp
請同學練習實作 btnSaveOutDgv_Click
```

### 💡 重點提示

- 出貨系統的架構與進貨系統類似，可以參考進貨系統的程式碼
- 出貨時，庫存數量應該**減少**（進貨時是增加）
- 出貨單價通常使用商品的售價（`rlSellPrice`）
- 記得檢查庫存數量是否足夠（出貨數量不能超過庫存數量）

---

## 🎓 本週重點回顧

### 資料表建立

- ✅ 建立出貨系統所需的六個資料表
- ✅ 熟悉「單頭單身」的資料庫設計架構

### 出貨系統實作

- ✅ 實作出貨表單功能（參考進貨系統架構）
- ✅ 出貨時庫存數量正確減少
- ✅ 使用 SqlTransaction 確保資料一致性

---
