namespace WinRock_Paper_Scissors
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.rdoRock = new System.Windows.Forms.RadioButton();
			this.rdoScissors = new System.Windows.Forms.RadioButton();
			this.rdoPaper = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.btnDraw = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblPlay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.LightSalmon;
			this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
			this.lblTitle.Location = new System.Drawing.Point(237, 32);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(267, 61);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "剪刀石頭布";
			// 
			// rdoRock
			// 
			this.rdoRock.AutoSize = true;
			this.rdoRock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.rdoRock.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rdoRock.Location = new System.Drawing.Point(312, 133);
			this.rdoRock.Name = "rdoRock";
			this.rdoRock.Size = new System.Drawing.Size(112, 51);
			this.rdoRock.TabIndex = 15;
			this.rdoRock.TabStop = true;
			this.rdoRock.Text = "石頭";
			this.rdoRock.UseVisualStyleBackColor = false;
			this.rdoRock.CheckedChanged += new System.EventHandler(this.rdoRock_CheckedChanged);
			// 
			// rdoScissors
			// 
			this.rdoScissors.AutoSize = true;
			this.rdoScissors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.rdoScissors.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rdoScissors.Location = new System.Drawing.Point(187, 133);
			this.rdoScissors.Name = "rdoScissors";
			this.rdoScissors.Size = new System.Drawing.Size(112, 51);
			this.rdoScissors.TabIndex = 14;
			this.rdoScissors.TabStop = true;
			this.rdoScissors.Text = "剪刀";
			this.rdoScissors.UseVisualStyleBackColor = false;
			this.rdoScissors.CheckedChanged += new System.EventHandler(this.rdoScissors_CheckedChanged);
			// 
			// rdoPaper
			// 
			this.rdoPaper.AutoSize = true;
			this.rdoPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.rdoPaper.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rdoPaper.Location = new System.Drawing.Point(447, 133);
			this.rdoPaper.Name = "rdoPaper";
			this.rdoPaper.Size = new System.Drawing.Size(75, 51);
			this.rdoPaper.TabIndex = 17;
			this.rdoPaper.TabStop = true;
			this.rdoPaper.Text = "布";
			this.rdoPaper.UseVisualStyleBackColor = false;
			this.rdoPaper.CheckedChanged += new System.EventHandler(this.rdoPaper_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label5.Location = new System.Drawing.Point(644, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 19);
			this.label5.TabIndex = 18;
			this.label5.Text = "結果為電腦隨機產生";
			// 
			// btnDraw
			// 
			this.btnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnDraw.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDraw.Location = new System.Drawing.Point(163, 241);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(440, 53);
			this.btnDraw.TabIndex = 19;
			this.btnDraw.Text = "開獎";
			this.btnDraw.UseVisualStyleBackColor = false;
			this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.BackColor = System.Drawing.Color.Lime;
			this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblResult.ForeColor = System.Drawing.SystemColors.Control;
			this.lblResult.Location = new System.Drawing.Point(216, 312);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(56, 45);
			this.lblResult.TabIndex = 20;
			this.lblResult.Text = "    ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Lime;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(12, 312);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(197, 47);
			this.label6.TabIndex = 21;
			this.label6.Text = "開獎結果：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Lime;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(172, 212);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 26);
			this.label2.TabIndex = 22;
			this.label2.Text = "你選擇的是：";
			// 
			// lblPlay
			// 
			this.lblPlay.AutoSize = true;
			this.lblPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblPlay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblPlay.Location = new System.Drawing.Point(312, 212);
			this.lblPlay.Name = "lblPlay";
			this.lblPlay.Size = new System.Drawing.Size(200, 24);
			this.lblPlay.TabIndex = 23;
			this.lblPlay.Text = "這邊呈現您選擇的選項";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblPlay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnDraw);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.rdoPaper);
			this.Controls.Add(this.rdoRock);
			this.Controls.Add(this.rdoScissors);
			this.Controls.Add(this.lblTitle);
			this.Name = "Form1";
			this.Text = "剪刀石頭布";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.RadioButton rdoRock;
		private System.Windows.Forms.RadioButton rdoScissors;
		private System.Windows.Forms.RadioButton rdoPaper;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnDraw;
		private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlay;
    }
}

