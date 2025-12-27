# 📖 C#單元十：庫存管理系統與進階報表（SQL 進階查詢）

---

## 🎯 單元目標

- ✅ 建立庫存管理系統所需的資料表
- ✅ 實作庫存JOIN查詢功能JOIN

---

## 📋 單元一：建立庫存管理系統所需的資料表

本單元將在 `DB_TEST` 資料庫中建立庫存管理系統所需的資料表。
共6個資料表：

1. FactoryTbl（廠商主檔）
2. ProductTbl（商品主檔）
3. InputHeadTbl（進貨單頭）
4. InputDetailTbl（進貨單身）
5. OutputHeadTbl（出貨單頭）
6. OutputDetailTbl（出貨單身）

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


INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('F001', '台積電');
INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('F002', '聯發科技');
INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('F003', '台達電');
INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('F004', '鴻海');
INSERT INTO FactoryTbl (chFactNo, chFactName) VALUES ('F005', '仁寶');


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


INSERT INTO ProductTbl (chProdNo, chProdName, chUnit, rlStockQty, rlInpPrice, rlSellPrice, chCreatDateTime) VALUES ('P001', 'iPhone 17 Pro', '片', 100, 250, 400, '11412020000');
INSERT INTO ProductTbl (chProdNo, chProdName, chUnit, rlStockQty, rlInpPrice, rlSellPrice, chCreatDateTime) VALUES ('P002', 'SAMSUNG Galaxy S25', '片', 100, 200, 300, '11412020000');
INSERT INTO ProductTbl (chProdNo, chProdName, chUnit, rlStockQty, rlInpPrice, rlSellPrice, chCreatDateTime) VALUES ('P003', 'Google Pixel 8', '顆', 100, 200, 300, '11412020000');



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



USE [DB_TEST]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OutputHeadTbl](
	[chOutpDateTime] [nchar](13) NOT NULL,
	[chFactNo] [nchar](10) NOT NULL,
	[rlOutpTotAmt] [real] NULL,
 CONSTRAINT [PK_OutputHeadTbl] PRIMARY KEY CLUSTERED 
(
	[chOutpDateTime] ASC,
	[chFactNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


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

 ![1765555699319](image/Course10/1765555699319.png)

---

## 📊 單元二：SQL 語法教學

### 📝 欄位別名（Alias）

使用 `AS` 關鍵字可以為欄位設定別名，讓查詢結果更容易閱讀：

以下為原始未使用別名的查詢結果

```sql
SELECT 
    chInpDateTime,
    chFactNo,
    chProdNo,
    rlInpQty,
    rlInpPrice,
    rlInpAmt
FROM InputDetailTbl
```

```sql
SELECT 
    chInpDateTime AS '進貨日期時間',
    chFactNo AS '廠商代號',
    chProdNo AS '商品編號',
    rlInpQty AS '進貨數量',
    rlInpPrice AS '進貨單價',
    rlInpAmt AS '進貨金額'
FROM InputDetailTbl
```

> 💡 **提示**：別名可以使用單引號或雙引號包起來，也可以不使用引號（如果別名不包含空格）。

#### 練習題：ProductTbl 資料表的欄位別名

請同學練習為 `ProductTbl` 資料表的所有欄位設定中文別名：
![1765692423203](image/Course10/1765692423203.png)

### 🎯 JOIN 的種類

SQL JOIN 用於結合兩個或多個資料表的資料。常見的 JOIN 種類包括：

![1765690364619](image/Course10/1765690364619.png)

JOIN  分為連結後的欄位呈現  (擴充欄位)、資料關係比對

### 📝 LEFT JOIN 深入講解

#### 2.1 LEFT JOIN 的撰寫方式

```sql
SELECT 
    左表.欄位1,
    左表.欄位2,

    右表.欄位1,
    右表.欄位2
FROM 左表
LEFT JOIN 右表 ON 左表.關聯欄位 = 右表.關聯欄位
```

#### 2.2 LEFT JOIN 的預期結果

- **左表的所有記錄都會被返回**
- 如果右表有匹配的記錄，則顯示右表的資料
- 如果右表沒有匹配的記錄，則右表的欄位顯示為 `NULL`

#### 2.2.1 範例：資料不全的情況

假設我們有以下情況：

- **交易明細表（InputDetailTbl）** 有 P001、P002、P003、P004 的商品記錄

```sql
INSERT INTO InputDetailTbl (chInpDateTime, chFactNo, chProdNo, rlInpQty, rlInpPrice, rlInpAmt) VALUES
('1141202153000', 'F001', 'P001', 10, 250, 2500),
('1141202153000', 'F001', 'P002', 20, 200, 4000),
('1141202153000', 'F001', 'P003', 15, 300, 4500),
('1141202153000', 'F001', 'P004', 5, 150, 750);
INSERT INTO InputHeadTbl (chInpDateTime, chFactNo, rlInpTotAmt) VALUES ('1141202153000', 'F001', 11750);
```

- **商品基本檔（ProductTbl）** 只有 P001、P002、P003 的商品資料（缺少 P004）

**交易明細表（InputDetailTbl）的資料：**

| chInpDateTime | chFactNo | chProdNo | rlInpQty | rlInpPrice | rlInpAmt |
| ------------- | -------- | -------- | -------- | ---------- | -------- |
| 11412021530   | F001     | P001     | 10       | 250        | 2500     |
| 11412021530   | F001     | P002     | 20       | 200        | 4000     |
| 11412021530   | F001     | P003     | 15       | 300        | 4500     |
| 11412021530   | F001     | P004     | 5        | 150        | 750      |

**商品基本檔（ProductTbl）的資料：**

| chProdNo | chProdName         | chUnit | rlStockQty | rlInpPrice | rlSellPrice |
| -------- | ------------------ | ------ | ---------- | ---------- | ----------- |
| P001     | iPhone 17 Pro      | 支     | 100        | 250        | 400         |
| P002     | SAMSUNG Galaxy S25 | 支     | 100        | 200        | 300         |
| P003     | iPad Pro           | 台     | 50         | 300        | 450         |

**使用 LEFT JOIN 查詢：**

```sql
SELECT 
    d.chProdNo AS '商品編號',
    p.chProdName AS '商品名稱',
    d.rlInpQty AS '進貨數量',
    d.rlInpPrice AS '進貨單價',
    d.rlInpAmt AS '進貨金額'
FROM InputDetailTbl d
LEFT JOIN ProductTbl p ON d.chProdNo = p.chProdNo
```

**LEFT JOIN 查詢結果：**

| 商品編號 | 商品名稱           | 進貨數量 | 進貨單價 | 進貨金額 |
| -------- | ------------------ | -------- | -------- | -------- |
| P001     | iPhone 17 Pro      | 10       | 250      | 2500     |
| P002     | SAMSUNG Galaxy S25 | 20       | 200      | 4000     |
| P003     | iPad Pro           | 15       | 300      | 4500     |
| *P004*   | *NULL*             | *5*      | *150*    | *750*    |

**重點說明：**

- ✅ **P001、P002、P003**：在商品基本檔中有對應資料，所以顯示商品名稱
- ⚠️ **P004**：在商品基本檔中**沒有**對應資料，所以商品名稱欄位顯示為 `NULL`
- ✅ **所有交易明細記錄都被保留**：即使 P004 在商品基本檔中不存在，交易明細的記錄仍然會被返回

這個範例清楚地展示了 LEFT JOIN 的特性：**即使右表（ProductTbl）沒有匹配的記錄，左表（InputDetailTbl）的所有記錄都會被返回**，這正是 LEFT JOIN 與 INNER JOIN 的最大差異。

#### 2.3 使用 INNER JOIN 的差異

如果我們使用 INNER JOIN，同樣以缺少 P004 為例：

**使用相同的資料表：**

- **交易明細表（InputDetailTbl）** 有 P001、P002、P003、P004 的商品記錄
- **商品基本檔（ProductTbl）** 只有 P001、P002、P003 的商品資料（缺少 P004）

**使用 INNER JOIN 查詢：**

```sql
SELECT 
    d.chProdNo AS '商品編號',
    p.chProdName AS '商品名稱',
    d.rlInpQty AS '進貨數量',
    d.rlInpPrice AS '進貨單價',
    d.rlInpAmt AS '進貨金額'
FROM InputDetailTbl d
INNER JOIN ProductTbl p ON d.chProdNo = p.chProdNo
```

**INNER JOIN 查詢結果：**

| 商品編號 | 商品名稱           | 進貨數量 | 進貨單價 | 進貨金額 |
| -------- | ------------------ | -------- | -------- | -------- |
| P001     | iPhone 17 Pro      | 10       | 250      | 2500     |
| P002     | SAMSUNG Galaxy S25 | 20       | 200      | 4000     |
| P003     | iPad Pro           | 15       | 300      | 4500     |

**重點說明：**

- ✅ **P001、P002、P003**：在商品基本檔中有對應資料，所以顯示商品名稱
- ❌ **P004**：在商品基本檔中**沒有**對應資料，**整筆記錄被過濾掉**，不會出現在查詢結果中
- ⚠️ **只返回有匹配的記錄**：INNER JOIN 只會返回兩個表中都有對應資料的記錄

**LEFT JOIN vs INNER JOIN 的差異比較：**

| 比較項目 | LEFT JOIN                 | INNER JOIN  |
| -------- | ------------------------- | ----------- |
| P001     | ✅ 顯示                    | ✅ 顯示      |
| P002     | ✅ 顯示                    | ✅ 顯示      |
| P003     | ✅ 顯示                    | ✅ 顯示      |
| P004     | ✅ 顯示（商品名稱為 NULL） | ❌**不顯示** |

這個範例清楚地展示了 INNER JOIN 的特性：**只返回兩個表中都有匹配的記錄，如果右表（ProductTbl）沒有匹配的記錄，左表（InputDetailTbl）的該筆記錄會被完全過濾掉**，這就是 INNER JOIN 與 LEFT JOIN 的最大差異。

#### 2.4 結果驗證

1. 在 SSMS 中執行 LEFT JOIN 的查詢
2. 觀察結果：所有進貨明細都會顯示
3. 在 SSMS 中執行 INNER JOIN 的查詢
4. 觀察結果：只顯示有對應商品的進貨明細
5. 比較兩者的差異

#### 📝 練習題：出貨單頭的 LEFT JOIN 查詢

請同學完成以下練習：
請分析每個欄位需要從哪個資料表取得資料，並寫出 SQL 查詢  以得到此圖內容的資料

![1765717019933](image/Course10/1765717019933.png)
