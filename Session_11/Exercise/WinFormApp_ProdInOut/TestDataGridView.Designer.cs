namespace WinFormApp_ProdInOut
{
    partial class TestDataGridView
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
            this.btnSelectFactDataSourse = new System.Windows.Forms.Button();
            this.dgvFact = new System.Windows.Forms.DataGridView();
            this.chFactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chFactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFactAddRow = new System.Windows.Forms.Button();
            this.btnFactClear = new System.Windows.Forms.Button();
            this.btnFactPrint = new System.Windows.Forms.Button();
            this.dgvFact2 = new System.Windows.Forms.DataGridView();
            this.btnSelectFactFor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFact2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFactDataSourse
            // 
            this.btnSelectFactDataSourse.Location = new System.Drawing.Point(0, 358);
            this.btnSelectFactDataSourse.Name = "btnSelectFactDataSourse";
            this.btnSelectFactDataSourse.Size = new System.Drawing.Size(75, 59);
            this.btnSelectFactDataSourse.TabIndex = 0;
            this.btnSelectFactDataSourse.Text = "Select資料DataSourse";
            this.btnSelectFactDataSourse.UseVisualStyleBackColor = true;
            this.btnSelectFactDataSourse.Click += new System.EventHandler(this.btnSelectFactDataSourse_Click);
            // 
            // dgvFact
            // 
            this.dgvFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chFactNo,
            this.chFactName});
            this.dgvFact.Location = new System.Drawing.Point(16, 96);
            this.dgvFact.Name = "dgvFact";
            this.dgvFact.RowTemplate.Height = 24;
            this.dgvFact.Size = new System.Drawing.Size(314, 242);
            this.dgvFact.TabIndex = 1;
            // 
            // chFactNo
            // 
            this.chFactNo.HeaderText = "廠商代號";
            this.chFactNo.Name = "chFactNo";
            // 
            // chFactName
            // 
            this.chFactName.HeaderText = "廠商姓名";
            this.chFactName.Name = "chFactName";
            // 
            // btnFactAddRow
            // 
            this.btnFactAddRow.Location = new System.Drawing.Point(24, 28);
            this.btnFactAddRow.Name = "btnFactAddRow";
            this.btnFactAddRow.Size = new System.Drawing.Size(79, 47);
            this.btnFactAddRow.TabIndex = 2;
            this.btnFactAddRow.Text = "新增資料列";
            this.btnFactAddRow.UseVisualStyleBackColor = true;
            this.btnFactAddRow.Click += new System.EventHandler(this.btnFactAddRow_Click);
            // 
            // btnFactClear
            // 
            this.btnFactClear.Location = new System.Drawing.Point(261, 28);
            this.btnFactClear.Name = "btnFactClear";
            this.btnFactClear.Size = new System.Drawing.Size(69, 47);
            this.btnFactClear.TabIndex = 5;
            this.btnFactClear.Text = "清除";
            this.btnFactClear.UseVisualStyleBackColor = true;
            this.btnFactClear.Click += new System.EventHandler(this.btnFactClear_Click);
            // 
            // btnFactPrint
            // 
            this.btnFactPrint.Location = new System.Drawing.Point(192, 28);
            this.btnFactPrint.Name = "btnFactPrint";
            this.btnFactPrint.Size = new System.Drawing.Size(63, 47);
            this.btnFactPrint.TabIndex = 6;
            this.btnFactPrint.Text = "讀取資料印出來";
            this.btnFactPrint.UseVisualStyleBackColor = true;
            this.btnFactPrint.Click += new System.EventHandler(this.btnFactPrint_Click);
            // 
            // dgvFact2
            // 
            this.dgvFact2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFact2.Location = new System.Drawing.Point(81, 358);
            this.dgvFact2.Name = "dgvFact2";
            this.dgvFact2.RowTemplate.Height = 24;
            this.dgvFact2.Size = new System.Drawing.Size(248, 165);
            this.dgvFact2.TabIndex = 7;
            // 
            // btnSelectFactFor
            // 
            this.btnSelectFactFor.Location = new System.Drawing.Point(109, 28);
            this.btnSelectFactFor.Name = "btnSelectFactFor";
            this.btnSelectFactFor.Size = new System.Drawing.Size(77, 47);
            this.btnSelectFactFor.TabIndex = 0;
            this.btnSelectFactFor.Text = "Select資料";
            this.btnSelectFactFor.UseVisualStyleBackColor = true;
            this.btnSelectFactFor.Click += new System.EventHandler(this.btnSelectFactFor_Click);
            // 
            // TestDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 589);
            this.Controls.Add(this.dgvFact2);
            this.Controls.Add(this.btnFactPrint);
            this.Controls.Add(this.btnFactClear);
            this.Controls.Add(this.btnFactAddRow);
            this.Controls.Add(this.dgvFact);
            this.Controls.Add(this.btnSelectFactFor);
            this.Controls.Add(this.btnSelectFactDataSourse);
            this.Name = "TestDataGridView";
            this.Text = "TestDataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFact2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFactDataSourse;
        private System.Windows.Forms.DataGridView dgvFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn chFactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chFactName;
        private System.Windows.Forms.Button btnFactAddRow;
        private System.Windows.Forms.Button btnFactClear;
        private System.Windows.Forms.Button btnFactPrint;
        private System.Windows.Forms.DataGridView dgvFact2;
        private System.Windows.Forms.Button btnSelectFactFor;
    }
}