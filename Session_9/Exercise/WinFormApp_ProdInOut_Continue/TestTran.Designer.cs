namespace WinFormApp_ProdInOut
{
    partial class TestTran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTranTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTranTest
            // 
            this.btnTranTest.Location = new System.Drawing.Point(88, 65);
            this.btnTranTest.Name = "btnTranTest";
            this.btnTranTest.Size = new System.Drawing.Size(126, 61);
            this.btnTranTest.TabIndex = 1;
            this.btnTranTest.Text = "測試交易";
            this.btnTranTest.UseVisualStyleBackColor = true;
            this.btnTranTest.Click += new System.EventHandler(this.btnTranTest_Click);
            // 
            // TranTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTranTest);
            this.Name = "TranTest";
            this.Text = "TranTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTranTest;
    }
}