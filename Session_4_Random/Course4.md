
# 🪨✂️ 剪刀石頭布遊戲 (C# WinForms 教學)

## 🎯 教學目標
- 學會使用 C# Windows Forms 製作剪刀石頭布遊戲
- 熟悉按鈕事件、隨機電腦出拳、結果判斷
- 培養事件驅動程式設計與邏輯判斷能力

---

## 🧱 介面設計

### 元件配置

| 元件類型 | 名稱 | 文字 | 用途 |
|-----------|-------|------|------|
| Label | `lblTitle` | 剪刀、石頭、布 | 顯示標題 |
| Label | `lblPlay` | 剪刀或石頭或布 | 顯示選擇項目 |
| RadioButton | `rdoScissors` | 剪刀 | 玩家選擇剪刀 |
| RadioButton | `rdoRock` | 石頭 | 玩家選擇石頭 |
| RadioButton | `rdoPaper` | 布 | 玩家選擇布 |
| Button | `btnDraw` | 開獎 | 開始遊戲 |
| Label | `lblResult` | （空白） | 顯示結果 |

---

## ƒ函式 (Function)

```csharp
[存取修飾詞] [回傳型別] 函式名稱([參數列表])
{
    // 函式內的程式碼
    return 結果; // 若回傳型別不是 void
}
```

🔹 範例 1：無回傳函式

```csharp
// 顯示問候訊息
public void SayHello()
{
    MessageBox.Show("Hello World!");
}
```

🔹 範例 2：有回傳值函式

```csharp
// 計算兩數加總
private string Compare(int a, int b)
{
    if (a > b)
    {
        return "a大於b";
    }
    else if (a < b )
    {
        return "a小於b";
    }
    else
    {
        return "a等於b";
    }
}
```

🔹 範例 3：使用函式

```csharp
SayHello();         // 呼叫無回傳函式
String result = Add(3,5); // 呼叫有回傳值函式
MessageBox.Show(result.ToString()); // 
```


## 🧩 程式碼範例

```csharp
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinRock_Paper_Scissors
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void btnDraw_Click(object sender, EventArgs e)
		{

            Random random = new Random();
			string splayerChoice = "";


			if (rdoScissors.Checked == true)
			{
                splayerChoice = rdoScissors.Text;

            }
			else if (rdoRock.Checked == true)
			{
                splayerChoice = rdoRock.Text;
            }
			else if (rdoPaper.Checked == true)
			{
                splayerChoice = rdoPaper.Text;
            }
			else
			{
                MessageBox.Show("請先選您要出的項目", "提示");
                return;
            }

			// 電腦隨機選擇
			string[] options = { "剪刀", "石頭", "布" };
			string computerChoice = options[random.Next(options.Length)];

			// 比賽結果
			string result = GetResult(splayerChoice, computerChoice);

			if (result.ToString().Trim() == "平手")
			{
				lblResult.BackColor = Color.Blue;
			}
            else if (result.ToString().Trim() == "你贏了！")
            {
                lblResult.BackColor = Color.Lime;
            }
            else if (result.ToString().Trim() == "你輸了！")
            {
                lblResult.BackColor = Color.Red;
            }
            
			// 顯示結果
			lblResult.Text = "你出：" + splayerChoice+"　電腦出：" + computerChoice + "\n結果：" + result;

		}
		private string GetResult(string player, string computer)
		{
			if (player == computer) return "平手";

			if ((player == "剪刀" && computer == "布") ||
				(player == "石頭" && computer == "剪刀") ||
				(player == "布" && computer == "石頭"))
			{
				return "你贏了！";
			}
			else
			{
				return "你輸了！";
			}
		}

        private void rdoScissors_CheckedChanged(object sender, EventArgs e)
        {
			if (rdoScissors.Checked == true)
			{
				lblPlay.Text = rdoScissors.Text;
			}
        }

        private void rdoRock_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRock.Checked == true)
            {
                lblPlay.Text = rdoRock.Text;
            }
        }

        private void rdoPaper_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPaper.Checked == true)
            {
                lblPlay.Text = rdoPaper.Text;
            }
        }
    }
}

```

---
## 🏠 課堂小測驗一：猜大小1~6

## 🧱 介面設計

### 元件配置

| 元件類型 | 名稱 | 文字 | 用途 |
|-----------|-------|------|------|
| Label | `lblTitle` | 剪刀、石頭、布 | 顯示標題 |
| Label | `lblPlay` | 剪刀或石頭或布 | 顯示選擇項目 |
| Label | `lblResult` | （空白） | 顯示結果 |
| RadioButton | `rdoBig` | 猜大 | 玩家選擇猜大 |
| RadioButton | `rdoSmall` | 猜小 | 玩家選擇猜小|
| Button | `btnDraw` | 開獎 | 開始遊戲 |

規則:
- 電腦隨機出1~6的數字
- 1-3 猜小 4-6猜大
- 玩家猜大猜小
- 如果猜中就贏了
- 如果猜錯就輸了
