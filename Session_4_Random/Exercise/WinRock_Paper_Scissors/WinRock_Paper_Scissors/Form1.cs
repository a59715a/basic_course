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
