using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //加法按鈕清空控制向

        //加法按鈕計算 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
			//字串相加
			txtAnswerA.Text = txtAdd1.Text + txtAdd2.Text;
			//介紹 .Trim()去除多餘空白
			txtAnswerA.Text = txtAdd1.Text.Trim() + txtAdd2.Text.Trim();

			// 介紹 int.TryParse 將數字的字串表示轉換成它的對等 32 位元帶正負號的整數。 傳回指示轉換是否成功的值。

			int iAdd1;
			int iAdd2;

			int.TryParse(txtAdd1.Text, out iAdd1);
			int.TryParse(txtAdd2.Text, out iAdd2);
			//數字相加後放回畫面上控制項txtAnswerA 因TextBox是需要放入String 所以要 .ToStrint()
			txtAnswerA.Text = (iAdd1 + iAdd2).ToString();

			//Convert強制轉型態 如沒增加錯誤判斷會造成 系統例外錯誤導致程式關閉
			try
			{
				txtAnswerA.Text = (Convert.ToInt16(txtAdd1.Text) + Convert.ToInt16(txtAdd2.Text)).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Console.WriteLine("錯誤訊息：" + ex.Message);
			}
			//Convert強制轉型態 如沒增加錯誤判斷會造成 系統例外錯誤導致程式關閉
			//         txtAnswerA.Text = (Convert.ToInt16(txtAdd1.Text) + Convert.ToInt16(txtAdd2.Text)).ToString();

			//Convert 相關介紹
			//| 型別 | 位元數(bit) | 位元組(byte) | 範圍                | 會佔的記憶體 |
			//         | -------------------   | --------- | --------------------| --------------------|
			//         | **Int16 / short       | 16 | 2    | -32,768 ~32,767     | 每個值佔 * *2 bytes |
			//         | **UInt16 / ushort     | 16 | 2    | 0 ~65,535           | 每個值佔 * *2 bytes |
			//         | **Int32 / int         | 32 | 4    | 約 - 21億 ~+21億    | 每個值佔 * *4 bytes |
			//         | **UInt32 / uint       | 32 | 4    | 0 ~42億             | 每個值佔 * *4 bytes |
			//         | **Int64 / long        | 64 | 8    | 約 ±9×10¹⁸          | 每個值佔 * *8 bytes |
			//         | **UInt64 / ulong      | 64 | 8    | 0 ~1.8×10¹⁹         | 每個值佔 * *8 bytes |


		}

		private void btnClearAdd_Click(object sender, EventArgs e)
        {
            txtAdd1.Clear();
            txtAdd2.Text = "";
            txtAnswerA.Text = "";
        }



        //---------暫時先不看-------------------
        private void txtAdd1_KeyPress(object sender, KeyPressEventArgs e)
        {

			//---------進階判斷 只能輸入數字方法一--------------------
            //因為鎖定只能輸入數字如果要移除(Backspace時)會無法輸入故判斷控制元件也能輸入
			//Char.IsNumber 判斷書入是否為數字
			//Char.IsControl 判斷是否為控制字元 ex: enter backspace
			//if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
   //         {
   //             e.Handled = true;//事件已處理--->這裡為消除非數字及控制項之字元
   //         }

        }

        private void txtAdd2_TextChanged(object sender, EventArgs e)
        {
            //Regex.IsMatch 運算式是否在輸入字串中尋找比對 是否符合條件
            //---------進階判斷 只能輸入數字方法二--------------------

   //         if (!Regex.IsMatch(txtAdd2.Text, @"^[0-9]*$"))
   //         {
   //             MessageBox.Show("請輸入數字");
   //             txtAdd2.Text = "";
			//}
        }
		private void txtAdd1_Leave(object sender, EventArgs e)
		{
			if (txtAdd1.Text.Trim() != "")
			{
				int iAdd2;
				if (int.TryParse(txtAdd1.Text, out iAdd2))
				{
					//doNothing
				}
				else
				{
					MessageBox.Show("你輸入的資料不是數字喔");
					txtAdd1.Text = "";
					txtAdd1.Focus();
				}
			}
		}
		private void txtAdd2_Leave(object sender, EventArgs e)
		{
			if (txtAdd2.Text.Trim() != "")
			{
				int iAdd2;
				if (int.TryParse(txtAdd2.Text, out iAdd2))
				{
					//doNothing
				}
				else
				{
					MessageBox.Show("你輸入的資料不是數字喔");
					txtAdd2.Text = "";
					txtAdd2.Focus();
				}
			}
		}

		/// <summary>
		/// 減法計算按鈕點擊事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCalculateSub_Click(object sender, EventArgs e)
		{
			//使用Conver.ToInt強制轉換如輸入非數字會發生例外錯誤 故請使用TryCatch
			try
			{
				txtAnswerSub.Text = (Convert.ToInt16(txtSub1.Text) - Convert.ToInt16(txtSub2.Text)).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				//Console.WriteLine("錯誤訊息：" + ex.Message);
			}
		}
		/// <summary>
		/// 減法清空控制項(TextBox)按鈕事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClearSub_Click(object sender, EventArgs e)
		{
			txtSub1.Text = "";
			txtSub2.Text = "";
			txtAnswerSub.Text = "";
		}
		/// <summary>
		/// 減法txtSub1 Leave事件 離開控制項時判斷
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtSub1_Leave(object sender, EventArgs e)
		{
			if (txtSub1.Text.Trim() != "")
			{
				int iAdd2;
				if (int.TryParse(txtSub1.Text, out iAdd2))
				{
					//doNothing
				}
				else
				{
					MessageBox.Show("你輸入的資料不是數字喔");
					txtSub1.Text = "";
					txtSub1.Focus();
				}
			}
		}
		/// <summary>
		/// 減法txtSub2 Leave事件 離開控制項時判斷
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtSub2_Leave(object sender, EventArgs e)
		{
			if (txtSub2.Text.Trim() != "")
			{
				int iAdd2;
				if (int.TryParse(txtSub2.Text, out iAdd2))
				{
					//doNothing
				}
				else
				{
					MessageBox.Show("你輸入的資料不是數字喔");
					txtSub2.Text = "";
					txtSub2.Focus();
				}
			}
		}

		private void btnClearMul_Click(object sender, EventArgs e)
		{
			txtMul1.Text = "";
			txtMul2.Text = "";
			txtAnswerMul.Text = "";
		}

		private void txtMul1_Leave(object sender, EventArgs e)
		{
			if (txtMul1.Text.Trim() != "")
			{
				int iAdd2;
				if (int.TryParse(txtMul1.Text, out iAdd2))
				{
					//doNothing
				}
				else
				{
					MessageBox.Show("你輸入的資料不是數字喔");
					txtMul1.Text = "";
					txtMul1.Focus();
				}
			}
		}

		private void txtMul2_Leave(object sender, EventArgs e)
		{
			if (txtMul2.Text.Trim() != "")
			{
				int iAdd2;
				if (int.TryParse(txtMul2.Text, out iAdd2))
				{
					//doNothing
				}
				else
				{
					MessageBox.Show("你輸入的資料不是數字喔");
					txtMul2.Text = "";
					txtMul2.Focus();
				}
			}
		}

		private void btnCalculateMul_Click(object sender, EventArgs e)
		{
			//使用Conver.ToInt強制轉換如輸入非數字會發生例外錯誤 故請使用TryCatch
			try
			{
				txtAnswerMul.Text = (Convert.ToInt16(txtMul1.Text) * Convert.ToInt16(txtMul2.Text)).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				//Console.WriteLine("錯誤訊息：" + ex.Message);
			}
		}

		private void btnClearDiv_Click(object sender, EventArgs e)
		{
			txtDiv1.Text = "";
			txtDiv2.Text = "";
			txtAnswerDiv.Text = "";
		}

		private void txtDiv1_Leave(object sender, EventArgs e)
		{
			if (txtDiv1.Text.Trim() != "")
			{
				int iAdd2;
				if (int.TryParse(txtDiv1.Text, out iAdd2))
				{
					//doNothing
				}
				else
				{
					MessageBox.Show("你輸入的資料不是數字喔");
					txtDiv1.Text = "";
					txtDiv1.Focus();
				}
			}
		}

		private void txtDiv2_Leave(object sender, EventArgs e)
		{
			if (txtDiv2.Text.Trim() != "")
			{
				int iAdd2;
				if (int.TryParse(txtDiv2.Text, out iAdd2))
				{
					//doNothing
				}
				else
				{
					MessageBox.Show("你輸入的資料不是數字喔");
					txtDiv2.Text = "";
					txtDiv2.Focus();
				}
			}
		}

		private void btnCalculateDiv_Click(object sender, EventArgs e)
		{
			
			//使用Conver.ToInt強制轉換如輸入非數字會發生例外錯誤 故請使用TryCatch
			try
			{
				txtAnswerDiv.Text = (Convert.ToInt16(txtDiv1.Text) / Convert.ToInt16(txtDiv2.Text)).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				//Console.WriteLine("錯誤訊息：" + ex.Message);
			}
		}

	}
}
