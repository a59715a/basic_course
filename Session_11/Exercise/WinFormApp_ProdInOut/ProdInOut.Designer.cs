namespace WinFormApp_ProdInOut
{
    partial class ProdInOut
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvInp = new System.Windows.Forms.DataGridView();
            this.ProdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InpPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InpQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InpAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInpDateTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearInpDgv = new System.Windows.Forms.Button();
            this.btnInpClear = new System.Windows.Forms.Button();
            this.btnSaveInpDgv = new System.Windows.Forms.Button();
            this.btnInpOK = new System.Windows.Forms.Button();
            this.txtInpUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInpQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInpPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtInpProdNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFactName = new System.Windows.Forms.TextBox();
            this.txtInpFactNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.DgvOut = new System.Windows.Forms.DataGridView();
            this.OutProdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtOutDateTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOutAmt = new System.Windows.Forms.Label();
            this.btnOutExit = new System.Windows.Forms.Button();
            this.btnClearOutDgv = new System.Windows.Forms.Button();
            this.btnOutClear = new System.Windows.Forms.Button();
            this.btnSaveOutDgv = new System.Windows.Forms.Button();
            this.btnOutOK = new System.Windows.Forms.Button();
            this.txtOutUnit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOutQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOutPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOutProdName = new System.Windows.Forms.TextBox();
            this.txtOutProdNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOutFactName = new System.Windows.Forms.TextBox();
            this.txtOutFactNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl_InpRpt = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panelInpDetailData = new System.Windows.Forms.Panel();
            this.dgvInpDetailReport = new System.Windows.Forms.DataGridView();
            this.panelInpDetailQuery = new System.Windows.Forms.Panel();
            this.lblInpDetailTotAmt = new System.Windows.Forms.Label();
            this.btnInpDetailQuery = new System.Windows.Forms.Button();
            this.btnInpDetailClear = new System.Windows.Forms.Button();
            this.txtInpDetailEDate = new System.Windows.Forms.TextBox();
            this.txtInpDetailSDate = new System.Windows.Forms.TextBox();
            this.txtInpDetailLabel2 = new System.Windows.Forms.TextBox();
            this.txtInpDetailLabel1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.panelInpMonthData = new System.Windows.Forms.Panel();
            this.dgvInpMonthReport = new System.Windows.Forms.DataGridView();
            this.panelInpMonthQuery = new System.Windows.Forms.Panel();
            this.lblInpMonthTotAmt = new System.Windows.Forms.Label();
            this.btnInpMonthQuery = new System.Windows.Forms.Button();
            this.btnInpMonthClear = new System.Windows.Forms.Button();
            this.txtInpMonthEDate = new System.Windows.Forms.TextBox();
            this.txtInpMonthSDate = new System.Windows.Forms.TextBox();
            this.txtInpMonthLabel2 = new System.Windows.Forms.TextBox();
            this.txtInpMonthLabel1 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl_OutRpt = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.panelOutDetailData = new System.Windows.Forms.Panel();
            this.dgvOutDetailReport = new System.Windows.Forms.DataGridView();
            this.panelOutDetailQuery = new System.Windows.Forms.Panel();
            this.lblOutDetailTotAmt = new System.Windows.Forms.Label();
            this.btnOutDetailQuery = new System.Windows.Forms.Button();
            this.btnOutDetailClear = new System.Windows.Forms.Button();
            this.txtOutDetailEDate = new System.Windows.Forms.TextBox();
            this.txtOutDetailSDate = new System.Windows.Forms.TextBox();
            this.txtOutDetailLabel2 = new System.Windows.Forms.TextBox();
            this.txtOutDetailLabel1 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.panelOutMonthData = new System.Windows.Forms.Panel();
            this.dgvOutMonthReport = new System.Windows.Forms.DataGridView();
            this.panelOutMonthQuery = new System.Windows.Forms.Panel();
            this.lblOutMonthTotAmt = new System.Windows.Forms.Label();
            this.btnOutMonthQuery = new System.Windows.Forms.Button();
            this.btnOutMonthClear = new System.Windows.Forms.Button();
            this.txtOutMonthEDate = new System.Windows.Forms.TextBox();
            this.txtOutMonthSDate = new System.Windows.Forms.TextBox();
            this.txtOutMonthLabel2 = new System.Windows.Forms.TextBox();
            this.txtOutMonthLabel1 = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.btnDataGridView = new System.Windows.Forms.Button();
            this.btnTranTest = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOut)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl_InpRpt.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panelInpDetailData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInpDetailReport)).BeginInit();
            this.panelInpDetailQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.panelInpMonthData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInpMonthReport)).BeginInit();
            this.panelInpMonthQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabControl_OutRpt.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.panelOutDetailData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutDetailReport)).BeginInit();
            this.panelOutDetailQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage11.SuspendLayout();
            this.panelOutMonthData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutMonthReport)).BeginInit();
            this.panelOutMonthQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage9);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1089, 644);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1081, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "進貨";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.DgvInp);
            this.panel2.Location = new System.Drawing.Point(32, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 293);
            this.panel2.TabIndex = 2;
            // 
            // DgvInp
            // 
            this.DgvInp.AllowUserToAddRows = false;
            this.DgvInp.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.DgvInp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdNo,
            this.ProdName,
            this.InpPrice,
            this.InpQty,
            this.InpAmt,
            this.Unit});
            this.DgvInp.Location = new System.Drawing.Point(40, 20);
            this.DgvInp.Name = "DgvInp";
            this.DgvInp.RowTemplate.Height = 24;
            this.DgvInp.Size = new System.Drawing.Size(943, 258);
            this.DgvInp.TabIndex = 0;
            // 
            // ProdNo
            // 
            this.ProdNo.HeaderText = "產品代號";
            this.ProdNo.Name = "ProdNo";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "產品名稱";
            this.ProdName.Name = "ProdName";
            this.ProdName.Width = 300;
            // 
            // InpPrice
            // 
            this.InpPrice.HeaderText = "進貨單價";
            this.InpPrice.Name = "InpPrice";
            // 
            // InpQty
            // 
            this.InpQty.HeaderText = "進貨數量";
            this.InpQty.Name = "InpQty";
            // 
            // InpAmt
            // 
            this.InpAmt.HeaderText = "金額";
            this.InpAmt.Name = "InpAmt";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "產品單位";
            this.Unit.Name = "Unit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.txtInpDateTime);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtFactName);
            this.panel1.Controls.Add(this.txtInpFactNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 292);
            this.panel1.TabIndex = 1;
            // 
            // txtInpDateTime
            // 
            this.txtInpDateTime.BackColor = System.Drawing.Color.Gainsboro;
            this.txtInpDateTime.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpDateTime.Location = new System.Drawing.Point(839, 21);
            this.txtInpDateTime.Name = "txtInpDateTime";
            this.txtInpDateTime.ReadOnly = true;
            this.txtInpDateTime.Size = new System.Drawing.Size(145, 30);
            this.txtInpDateTime.TabIndex = 202;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(702, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 201;
            this.label7.Text = "進貨日期時間";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblAmt);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnClearInpDgv);
            this.panel3.Controls.Add(this.btnInpClear);
            this.panel3.Controls.Add(this.btnSaveInpDgv);
            this.panel3.Controls.Add(this.btnInpOK);
            this.panel3.Controls.Add(this.txtInpUnit);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtInpQty);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtInpPrice);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtProdName);
            this.panel3.Controls.Add(this.txtInpProdNo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(40, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 216);
            this.panel3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(386, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "單項金額";
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.BackColor = System.Drawing.Color.LightGray;
            this.lblAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmt.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAmt.Location = new System.Drawing.Point(537, 118);
            this.lblAmt.Margin = new System.Windows.Forms.Padding(3, 0, 30, 0);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(2, 21);
            this.lblAmt.TabIndex = 18;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(799, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 25);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "結束";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearInpDgv
            // 
            this.btnClearInpDgv.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClearInpDgv.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearInpDgv.Location = new System.Drawing.Point(693, 185);
            this.btnClearInpDgv.Name = "btnClearInpDgv";
            this.btnClearInpDgv.Size = new System.Drawing.Size(100, 25);
            this.btnClearInpDgv.TabIndex = 16;
            this.btnClearInpDgv.Text = "單張清除";
            this.btnClearInpDgv.UseVisualStyleBackColor = false;
            this.btnClearInpDgv.Click += new System.EventHandler(this.btnClearInpDgv_Click);
            // 
            // btnInpClear
            // 
            this.btnInpClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInpClear.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInpClear.Location = new System.Drawing.Point(386, 185);
            this.btnInpClear.Name = "btnInpClear";
            this.btnInpClear.Size = new System.Drawing.Size(100, 25);
            this.btnInpClear.TabIndex = 8;
            this.btnInpClear.Text = "清螢幕";
            this.btnInpClear.UseVisualStyleBackColor = false;
            this.btnInpClear.Click += new System.EventHandler(this.btnInpClear_Click);
            // 
            // btnSaveInpDgv
            // 
            this.btnSaveInpDgv.BackColor = System.Drawing.Color.Gold;
            this.btnSaveInpDgv.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveInpDgv.Location = new System.Drawing.Point(587, 185);
            this.btnSaveInpDgv.Name = "btnSaveInpDgv";
            this.btnSaveInpDgv.Size = new System.Drawing.Size(100, 25);
            this.btnSaveInpDgv.TabIndex = 7;
            this.btnSaveInpDgv.Text = "單張儲存";
            this.btnSaveInpDgv.UseVisualStyleBackColor = false;
            this.btnSaveInpDgv.Click += new System.EventHandler(this.btnSaveInpDgv_Click);
            // 
            // btnInpOK
            // 
            this.btnInpOK.BackColor = System.Drawing.Color.Gold;
            this.btnInpOK.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInpOK.Location = new System.Drawing.Point(265, 185);
            this.btnInpOK.Name = "btnInpOK";
            this.btnInpOK.Size = new System.Drawing.Size(100, 25);
            this.btnInpOK.TabIndex = 6;
            this.btnInpOK.Text = "確定";
            this.btnInpOK.UseVisualStyleBackColor = false;
            this.btnInpOK.Click += new System.EventHandler(this.btnInpOK_Click);
            // 
            // txtInpUnit
            // 
            this.txtInpUnit.Enabled = false;
            this.txtInpUnit.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpUnit.Location = new System.Drawing.Point(265, 137);
            this.txtInpUnit.Name = "txtInpUnit";
            this.txtInpUnit.ReadOnly = true;
            this.txtInpUnit.Size = new System.Drawing.Size(101, 30);
            this.txtInpUnit.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Firebrick;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(158, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "產品單位";
            // 
            // txtInpQty
            // 
            this.txtInpQty.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpQty.Location = new System.Drawing.Point(265, 99);
            this.txtInpQty.Name = "txtInpQty";
            this.txtInpQty.Size = new System.Drawing.Size(100, 30);
            this.txtInpQty.TabIndex = 4;
            this.txtInpQty.Click += new System.EventHandler(this.txtInpQty_Click);
            this.txtInpQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInpQty_KeyDown);
            this.txtInpQty.Leave += new System.EventHandler(this.txtInpQty_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(156, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "進貨數量";
            // 
            // txtInpPrice
            // 
            this.txtInpPrice.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpPrice.Location = new System.Drawing.Point(265, 60);
            this.txtInpPrice.Name = "txtInpPrice";
            this.txtInpPrice.Size = new System.Drawing.Size(100, 30);
            this.txtInpPrice.TabIndex = 3;
            this.txtInpPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInpPrice_KeyDown);
            this.txtInpPrice.Leave += new System.EventHandler(this.txtInpPrice_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Firebrick;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(158, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "進貨單價";
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtProdName.Enabled = false;
            this.txtProdName.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProdName.Location = new System.Drawing.Point(386, 26);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.ReadOnly = true;
            this.txtProdName.Size = new System.Drawing.Size(474, 30);
            this.txtProdName.TabIndex = 8;
            // 
            // txtInpProdNo
            // 
            this.txtInpProdNo.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpProdNo.Location = new System.Drawing.Point(265, 24);
            this.txtInpProdNo.Name = "txtInpProdNo";
            this.txtInpProdNo.Size = new System.Drawing.Size(100, 30);
            this.txtInpProdNo.TabIndex = 2;
            this.txtInpProdNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdNo_KeyDown);
            this.txtInpProdNo.Leave += new System.EventHandler(this.txtProdNo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(118, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "進貨產品代號";
            // 
            // txtFactName
            // 
            this.txtFactName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFactName.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFactName.Location = new System.Drawing.Point(308, 23);
            this.txtFactName.Name = "txtFactName";
            this.txtFactName.ReadOnly = true;
            this.txtFactName.Size = new System.Drawing.Size(375, 30);
            this.txtFactName.TabIndex = 200;
            // 
            // txtInpFactNo
            // 
            this.txtInpFactNo.BackColor = System.Drawing.Color.White;
            this.txtInpFactNo.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpFactNo.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtInpFactNo.Location = new System.Drawing.Point(187, 21);
            this.txtInpFactNo.Name = "txtInpFactNo";
            this.txtInpFactNo.Size = new System.Drawing.Size(100, 30);
            this.txtInpFactNo.TabIndex = 1;
            this.txtInpFactNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInpFactNo_KeyDown);
            this.txtInpFactNo.Leave += new System.EventHandler(this.txtInpFactNo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "進貨廠商代號";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1081, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1081, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "出貨";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Goldenrod;
            this.panel8.Controls.Add(this.DgvOut);
            this.panel8.Location = new System.Drawing.Point(31, 325);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1018, 293);
            this.panel8.TabIndex = 3;
            // 
            // DgvOut
            // 
            this.DgvOut.AllowUserToAddRows = false;
            this.DgvOut.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.DgvOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutProdNo,
            this.OutProdName,
            this.OutPrice,
            this.OutQty,
            this.OutAmt,
            this.OutUnit});
            this.DgvOut.Location = new System.Drawing.Point(40, 20);
            this.DgvOut.Name = "DgvOut";
            this.DgvOut.RowTemplate.Height = 24;
            this.DgvOut.Size = new System.Drawing.Size(943, 258);
            this.DgvOut.TabIndex = 0;
            // 
            // OutProdNo
            // 
            this.OutProdNo.HeaderText = "產品代號";
            this.OutProdNo.Name = "OutProdNo";
            // 
            // OutProdName
            // 
            this.OutProdName.HeaderText = "產品名稱";
            this.OutProdName.Name = "OutProdName";
            this.OutProdName.Width = 300;
            // 
            // OutPrice
            // 
            this.OutPrice.HeaderText = "出貨單價";
            this.OutPrice.Name = "OutPrice";
            // 
            // OutQty
            // 
            this.OutQty.HeaderText = "出貨數量";
            this.OutQty.Name = "OutQty";
            // 
            // OutAmt
            // 
            this.OutAmt.HeaderText = "金額";
            this.OutAmt.Name = "OutAmt";
            // 
            // OutUnit
            // 
            this.OutUnit.HeaderText = "產品單位";
            this.OutUnit.Name = "OutUnit";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Goldenrod;
            this.panel6.Controls.Add(this.txtOutDateTime);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.txtOutFactName);
            this.panel6.Controls.Add(this.txtOutFactNo);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(31, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1018, 292);
            this.panel6.TabIndex = 2;
            // 
            // txtOutDateTime
            // 
            this.txtOutDateTime.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOutDateTime.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutDateTime.Location = new System.Drawing.Point(839, 21);
            this.txtOutDateTime.Name = "txtOutDateTime";
            this.txtOutDateTime.ReadOnly = true;
            this.txtOutDateTime.Size = new System.Drawing.Size(145, 30);
            this.txtOutDateTime.TabIndex = 202;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(702, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 21);
            this.label8.TabIndex = 201;
            this.label8.Text = "出貨日期時間";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightCoral;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.lblOutAmt);
            this.panel7.Controls.Add(this.btnOutExit);
            this.panel7.Controls.Add(this.btnClearOutDgv);
            this.panel7.Controls.Add(this.btnOutClear);
            this.panel7.Controls.Add(this.btnSaveOutDgv);
            this.panel7.Controls.Add(this.btnOutOK);
            this.panel7.Controls.Add(this.txtOutUnit);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.txtOutQty);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.txtOutPrice);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.txtOutProdName);
            this.panel7.Controls.Add(this.txtOutProdNo);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(40, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(943, 216);
            this.panel7.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(386, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "單項金額";
            // 
            // lblOutAmt
            // 
            this.lblOutAmt.AutoSize = true;
            this.lblOutAmt.BackColor = System.Drawing.Color.LightGray;
            this.lblOutAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutAmt.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOutAmt.Location = new System.Drawing.Point(487, 110);
            this.lblOutAmt.Name = "lblOutAmt";
            this.lblOutAmt.Size = new System.Drawing.Size(2, 21);
            this.lblOutAmt.TabIndex = 18;
            // 
            // btnOutExit
            // 
            this.btnOutExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOutExit.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOutExit.Location = new System.Drawing.Point(799, 185);
            this.btnOutExit.Name = "btnOutExit";
            this.btnOutExit.Size = new System.Drawing.Size(61, 25);
            this.btnOutExit.TabIndex = 17;
            this.btnOutExit.Text = "結束";
            this.btnOutExit.UseVisualStyleBackColor = false;
            // 
            // btnClearOutDgv
            // 
            this.btnClearOutDgv.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClearOutDgv.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearOutDgv.Location = new System.Drawing.Point(693, 185);
            this.btnClearOutDgv.Name = "btnClearOutDgv";
            this.btnClearOutDgv.Size = new System.Drawing.Size(100, 25);
            this.btnClearOutDgv.TabIndex = 16;
            this.btnClearOutDgv.Text = "單張清除";
            this.btnClearOutDgv.UseVisualStyleBackColor = false;
            this.btnClearOutDgv.Click += new System.EventHandler(this.btnClearOutDgv_Click);
            // 
            // btnOutClear
            // 
            this.btnOutClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOutClear.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOutClear.Location = new System.Drawing.Point(386, 185);
            this.btnOutClear.Name = "btnOutClear";
            this.btnOutClear.Size = new System.Drawing.Size(100, 25);
            this.btnOutClear.TabIndex = 8;
            this.btnOutClear.Text = "清螢幕";
            this.btnOutClear.UseVisualStyleBackColor = false;
            this.btnOutClear.Click += new System.EventHandler(this.btnOutClear_Click);
            // 
            // btnSaveOutDgv
            // 
            this.btnSaveOutDgv.BackColor = System.Drawing.Color.Gold;
            this.btnSaveOutDgv.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveOutDgv.Location = new System.Drawing.Point(587, 185);
            this.btnSaveOutDgv.Name = "btnSaveOutDgv";
            this.btnSaveOutDgv.Size = new System.Drawing.Size(100, 25);
            this.btnSaveOutDgv.TabIndex = 7;
            this.btnSaveOutDgv.Text = "單張儲存";
            this.btnSaveOutDgv.UseVisualStyleBackColor = false;
            this.btnSaveOutDgv.Click += new System.EventHandler(this.btnSaveOutDgv_Click);
            // 
            // btnOutOK
            // 
            this.btnOutOK.BackColor = System.Drawing.Color.Gold;
            this.btnOutOK.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOutOK.Location = new System.Drawing.Point(265, 185);
            this.btnOutOK.Name = "btnOutOK";
            this.btnOutOK.Size = new System.Drawing.Size(100, 25);
            this.btnOutOK.TabIndex = 6;
            this.btnOutOK.Text = "確定";
            this.btnOutOK.UseVisualStyleBackColor = false;
            this.btnOutOK.Click += new System.EventHandler(this.btnOutOK_Click);
            // 
            // txtOutUnit
            // 
            this.txtOutUnit.Enabled = false;
            this.txtOutUnit.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutUnit.Location = new System.Drawing.Point(265, 137);
            this.txtOutUnit.Name = "txtOutUnit";
            this.txtOutUnit.ReadOnly = true;
            this.txtOutUnit.Size = new System.Drawing.Size(101, 30);
            this.txtOutUnit.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Firebrick;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(158, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 15;
            this.label11.Text = "產品單位";
            // 
            // txtOutQty
            // 
            this.txtOutQty.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutQty.Location = new System.Drawing.Point(265, 99);
            this.txtOutQty.Name = "txtOutQty";
            this.txtOutQty.Size = new System.Drawing.Size(100, 30);
            this.txtOutQty.TabIndex = 4;
            this.txtOutQty.Leave += new System.EventHandler(this.txtOutQty_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Firebrick;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(156, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 12;
            this.label12.Text = "出貨數量";
            // 
            // txtOutPrice
            // 
            this.txtOutPrice.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutPrice.Location = new System.Drawing.Point(265, 60);
            this.txtOutPrice.Name = "txtOutPrice";
            this.txtOutPrice.Size = new System.Drawing.Size(100, 30);
            this.txtOutPrice.TabIndex = 3;
            this.txtOutPrice.Leave += new System.EventHandler(this.txtOutPrice_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Firebrick;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(158, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 21);
            this.label13.TabIndex = 9;
            this.label13.Text = "出貨單價";
            // 
            // txtOutProdName
            // 
            this.txtOutProdName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOutProdName.Enabled = false;
            this.txtOutProdName.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutProdName.Location = new System.Drawing.Point(386, 26);
            this.txtOutProdName.Name = "txtOutProdName";
            this.txtOutProdName.ReadOnly = true;
            this.txtOutProdName.Size = new System.Drawing.Size(474, 30);
            this.txtOutProdName.TabIndex = 8;
            // 
            // txtOutProdNo
            // 
            this.txtOutProdNo.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutProdNo.Location = new System.Drawing.Point(265, 24);
            this.txtOutProdNo.Name = "txtOutProdNo";
            this.txtOutProdNo.Size = new System.Drawing.Size(100, 30);
            this.txtOutProdNo.TabIndex = 2;
            this.txtOutProdNo.Leave += new System.EventHandler(this.txtOutProdNo_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Firebrick;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(118, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 21);
            this.label14.TabIndex = 6;
            this.label14.Text = "出貨產品代號";
            // 
            // txtOutFactName
            // 
            this.txtOutFactName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOutFactName.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutFactName.Location = new System.Drawing.Point(308, 23);
            this.txtOutFactName.Name = "txtOutFactName";
            this.txtOutFactName.ReadOnly = true;
            this.txtOutFactName.Size = new System.Drawing.Size(375, 30);
            this.txtOutFactName.TabIndex = 200;
            // 
            // txtOutFactNo
            // 
            this.txtOutFactNo.BackColor = System.Drawing.Color.White;
            this.txtOutFactNo.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutFactNo.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtOutFactNo.Location = new System.Drawing.Point(187, 21);
            this.txtOutFactNo.Name = "txtOutFactNo";
            this.txtOutFactNo.Size = new System.Drawing.Size(100, 30);
            this.txtOutFactNo.TabIndex = 1;
            this.txtOutFactNo.Leave += new System.EventHandler(this.txtOutFactNo_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Firebrick;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(40, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "出貨廠商代號";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Thistle;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1081, 618);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl_InpRpt);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1081, 618);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "進貨細項、月報";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl_InpRpt
            // 
            this.tabControl_InpRpt.Controls.Add(this.tabPage7);
            this.tabControl_InpRpt.Controls.Add(this.tabPage8);
            this.tabControl_InpRpt.Location = new System.Drawing.Point(90, 3);
            this.tabControl_InpRpt.Name = "tabControl_InpRpt";
            this.tabControl_InpRpt.SelectedIndex = 0;
            this.tabControl_InpRpt.Size = new System.Drawing.Size(893, 609);
            this.tabControl_InpRpt.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.panelInpDetailData);
            this.tabPage7.Controls.Add(this.panelInpDetailQuery);
            this.tabPage7.Controls.Add(this.pictureBox3);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(885, 583);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "進貨細項";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // panelInpDetailData
            // 
            this.panelInpDetailData.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelInpDetailData.Controls.Add(this.dgvInpDetailReport);
            this.panelInpDetailData.Location = new System.Drawing.Point(33, 126);
            this.panelInpDetailData.Name = "panelInpDetailData";
            this.panelInpDetailData.Size = new System.Drawing.Size(832, 438);
            this.panelInpDetailData.TabIndex = 2;
            // 
            // dgvInpDetailReport
            // 
            this.dgvInpDetailReport.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvInpDetailReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInpDetailReport.Location = new System.Drawing.Point(3, 14);
            this.dgvInpDetailReport.Name = "dgvInpDetailReport";
            this.dgvInpDetailReport.RowTemplate.Height = 24;
            this.dgvInpDetailReport.Size = new System.Drawing.Size(811, 325);
            this.dgvInpDetailReport.TabIndex = 1;
            // 
            // panelInpDetailQuery
            // 
            this.panelInpDetailQuery.BackColor = System.Drawing.Color.LightYellow;
            this.panelInpDetailQuery.Controls.Add(this.lblInpDetailTotAmt);
            this.panelInpDetailQuery.Controls.Add(this.btnInpDetailQuery);
            this.panelInpDetailQuery.Controls.Add(this.btnInpDetailClear);
            this.panelInpDetailQuery.Controls.Add(this.txtInpDetailEDate);
            this.panelInpDetailQuery.Controls.Add(this.txtInpDetailSDate);
            this.panelInpDetailQuery.Controls.Add(this.txtInpDetailLabel2);
            this.panelInpDetailQuery.Controls.Add(this.txtInpDetailLabel1);
            this.panelInpDetailQuery.Location = new System.Drawing.Point(33, 18);
            this.panelInpDetailQuery.Name = "panelInpDetailQuery";
            this.panelInpDetailQuery.Size = new System.Drawing.Size(823, 102);
            this.panelInpDetailQuery.TabIndex = 1;
            // 
            // lblInpDetailTotAmt
            // 
            this.lblInpDetailTotAmt.AutoSize = true;
            this.lblInpDetailTotAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInpDetailTotAmt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInpDetailTotAmt.ForeColor = System.Drawing.Color.Red;
            this.lblInpDetailTotAmt.Location = new System.Drawing.Point(65, 75);
            this.lblInpDetailTotAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInpDetailTotAmt.Name = "lblInpDetailTotAmt";
            this.lblInpDetailTotAmt.Size = new System.Drawing.Size(57, 18);
            this.lblInpDetailTotAmt.TabIndex = 6;
            this.lblInpDetailTotAmt.Text = "總金額";
            this.lblInpDetailTotAmt.Visible = false;
            // 
            // btnInpDetailQuery
            // 
            this.btnInpDetailQuery.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInpDetailQuery.Location = new System.Drawing.Point(507, 33);
            this.btnInpDetailQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnInpDetailQuery.Name = "btnInpDetailQuery";
            this.btnInpDetailQuery.Size = new System.Drawing.Size(139, 29);
            this.btnInpDetailQuery.TabIndex = 4;
            this.btnInpDetailQuery.Text = "進貨細項查詢";
            this.btnInpDetailQuery.UseVisualStyleBackColor = true;
            this.btnInpDetailQuery.Click += new System.EventHandler(this.btnInpDetailQuery_Click);
            // 
            // btnInpDetailClear
            // 
            this.btnInpDetailClear.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInpDetailClear.Location = new System.Drawing.Point(693, 34);
            this.btnInpDetailClear.Name = "btnInpDetailClear";
            this.btnInpDetailClear.Size = new System.Drawing.Size(80, 27);
            this.btnInpDetailClear.TabIndex = 5;
            this.btnInpDetailClear.Text = "清螢幕";
            this.btnInpDetailClear.UseVisualStyleBackColor = true;
            this.btnInpDetailClear.Click += new System.EventHandler(this.btnInpDetailClear_Click);
            // 
            // txtInpDetailEDate
            // 
            this.txtInpDetailEDate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpDetailEDate.Location = new System.Drawing.Point(359, 33);
            this.txtInpDetailEDate.Name = "txtInpDetailEDate";
            this.txtInpDetailEDate.Size = new System.Drawing.Size(105, 30);
            this.txtInpDetailEDate.TabIndex = 3;
            this.txtInpDetailEDate.Text = "1141231";
            // 
            // txtInpDetailSDate
            // 
            this.txtInpDetailSDate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpDetailSDate.Location = new System.Drawing.Point(216, 33);
            this.txtInpDetailSDate.Name = "txtInpDetailSDate";
            this.txtInpDetailSDate.Size = new System.Drawing.Size(105, 30);
            this.txtInpDetailSDate.TabIndex = 2;
            this.txtInpDetailSDate.Text = "1141201";
            // 
            // txtInpDetailLabel2
            // 
            this.txtInpDetailLabel2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpDetailLabel2.Location = new System.Drawing.Point(327, 33);
            this.txtInpDetailLabel2.Name = "txtInpDetailLabel2";
            this.txtInpDetailLabel2.ReadOnly = true;
            this.txtInpDetailLabel2.Size = new System.Drawing.Size(26, 30);
            this.txtInpDetailLabel2.TabIndex = 1;
            this.txtInpDetailLabel2.Text = "～";
            // 
            // txtInpDetailLabel1
            // 
            this.txtInpDetailLabel1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpDetailLabel1.Location = new System.Drawing.Point(65, 33);
            this.txtInpDetailLabel1.Name = "txtInpDetailLabel1";
            this.txtInpDetailLabel1.ReadOnly = true;
            this.txtInpDetailLabel1.Size = new System.Drawing.Size(145, 30);
            this.txtInpDetailLabel1.TabIndex = 0;
            this.txtInpDetailLabel1.Text = "查詢起迄日期:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(876, 577);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.panelInpMonthData);
            this.tabPage8.Controls.Add(this.panelInpMonthQuery);
            this.tabPage8.Controls.Add(this.pictureBox4);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(885, 583);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "月報";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // panelInpMonthData
            // 
            this.panelInpMonthData.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelInpMonthData.Controls.Add(this.dgvInpMonthReport);
            this.panelInpMonthData.Location = new System.Drawing.Point(33, 126);
            this.panelInpMonthData.Name = "panelInpMonthData";
            this.panelInpMonthData.Size = new System.Drawing.Size(832, 438);
            this.panelInpMonthData.TabIndex = 2;
            // 
            // dgvInpMonthReport
            // 
            this.dgvInpMonthReport.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvInpMonthReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInpMonthReport.Location = new System.Drawing.Point(3, 14);
            this.dgvInpMonthReport.Name = "dgvInpMonthReport";
            this.dgvInpMonthReport.RowTemplate.Height = 24;
            this.dgvInpMonthReport.Size = new System.Drawing.Size(811, 325);
            this.dgvInpMonthReport.TabIndex = 1;
            // 
            // panelInpMonthQuery
            // 
            this.panelInpMonthQuery.BackColor = System.Drawing.Color.LightYellow;
            this.panelInpMonthQuery.Controls.Add(this.lblInpMonthTotAmt);
            this.panelInpMonthQuery.Controls.Add(this.btnInpMonthQuery);
            this.panelInpMonthQuery.Controls.Add(this.btnInpMonthClear);
            this.panelInpMonthQuery.Controls.Add(this.txtInpMonthEDate);
            this.panelInpMonthQuery.Controls.Add(this.txtInpMonthSDate);
            this.panelInpMonthQuery.Controls.Add(this.txtInpMonthLabel2);
            this.panelInpMonthQuery.Controls.Add(this.txtInpMonthLabel1);
            this.panelInpMonthQuery.Location = new System.Drawing.Point(33, 18);
            this.panelInpMonthQuery.Name = "panelInpMonthQuery";
            this.panelInpMonthQuery.Size = new System.Drawing.Size(823, 102);
            this.panelInpMonthQuery.TabIndex = 1;
            // 
            // lblInpMonthTotAmt
            // 
            this.lblInpMonthTotAmt.AutoSize = true;
            this.lblInpMonthTotAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInpMonthTotAmt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInpMonthTotAmt.ForeColor = System.Drawing.Color.Red;
            this.lblInpMonthTotAmt.Location = new System.Drawing.Point(65, 75);
            this.lblInpMonthTotAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInpMonthTotAmt.Name = "lblInpMonthTotAmt";
            this.lblInpMonthTotAmt.Size = new System.Drawing.Size(57, 18);
            this.lblInpMonthTotAmt.TabIndex = 6;
            this.lblInpMonthTotAmt.Text = "總金額";
            this.lblInpMonthTotAmt.Visible = false;
            // 
            // btnInpMonthQuery
            // 
            this.btnInpMonthQuery.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInpMonthQuery.Location = new System.Drawing.Point(507, 33);
            this.btnInpMonthQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnInpMonthQuery.Name = "btnInpMonthQuery";
            this.btnInpMonthQuery.Size = new System.Drawing.Size(137, 29);
            this.btnInpMonthQuery.TabIndex = 4;
            this.btnInpMonthQuery.Text = "進貨月報查詢";
            this.btnInpMonthQuery.UseVisualStyleBackColor = true;
            this.btnInpMonthQuery.Click += new System.EventHandler(this.btnInpMonthQuery_Click);
            // 
            // btnInpMonthClear
            // 
            this.btnInpMonthClear.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInpMonthClear.Location = new System.Drawing.Point(693, 34);
            this.btnInpMonthClear.Name = "btnInpMonthClear";
            this.btnInpMonthClear.Size = new System.Drawing.Size(80, 27);
            this.btnInpMonthClear.TabIndex = 5;
            this.btnInpMonthClear.Text = "清螢幕";
            this.btnInpMonthClear.UseVisualStyleBackColor = true;
            this.btnInpMonthClear.Click += new System.EventHandler(this.btnInpMonthClear_Click);
            // 
            // txtInpMonthEDate
            // 
            this.txtInpMonthEDate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpMonthEDate.Location = new System.Drawing.Point(359, 33);
            this.txtInpMonthEDate.Name = "txtInpMonthEDate";
            this.txtInpMonthEDate.Size = new System.Drawing.Size(105, 30);
            this.txtInpMonthEDate.TabIndex = 3;
            this.txtInpMonthEDate.Text = "11412";
            // 
            // txtInpMonthSDate
            // 
            this.txtInpMonthSDate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpMonthSDate.Location = new System.Drawing.Point(216, 33);
            this.txtInpMonthSDate.Name = "txtInpMonthSDate";
            this.txtInpMonthSDate.Size = new System.Drawing.Size(105, 30);
            this.txtInpMonthSDate.TabIndex = 2;
            this.txtInpMonthSDate.Text = "11412";
            // 
            // txtInpMonthLabel2
            // 
            this.txtInpMonthLabel2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpMonthLabel2.Location = new System.Drawing.Point(327, 33);
            this.txtInpMonthLabel2.Name = "txtInpMonthLabel2";
            this.txtInpMonthLabel2.ReadOnly = true;
            this.txtInpMonthLabel2.Size = new System.Drawing.Size(26, 30);
            this.txtInpMonthLabel2.TabIndex = 1;
            this.txtInpMonthLabel2.Text = "～";
            // 
            // txtInpMonthLabel1
            // 
            this.txtInpMonthLabel1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInpMonthLabel1.Location = new System.Drawing.Point(65, 33);
            this.txtInpMonthLabel1.Name = "txtInpMonthLabel1";
            this.txtInpMonthLabel1.ReadOnly = true;
            this.txtInpMonthLabel1.Size = new System.Drawing.Size(145, 30);
            this.txtInpMonthLabel1.TabIndex = 0;
            this.txtInpMonthLabel1.Text = "查詢起迄日期:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(876, 577);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl_OutRpt);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1081, 618);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "出貨細項、月報";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl_OutRpt
            // 
            this.tabControl_OutRpt.Controls.Add(this.tabPage10);
            this.tabControl_OutRpt.Controls.Add(this.tabPage11);
            this.tabControl_OutRpt.Location = new System.Drawing.Point(90, 3);
            this.tabControl_OutRpt.Name = "tabControl_OutRpt";
            this.tabControl_OutRpt.SelectedIndex = 0;
            this.tabControl_OutRpt.Size = new System.Drawing.Size(893, 609);
            this.tabControl_OutRpt.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.panelOutDetailData);
            this.tabPage10.Controls.Add(this.panelOutDetailQuery);
            this.tabPage10.Controls.Add(this.pictureBox5);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(885, 583);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "出貨細項";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // panelOutDetailData
            // 
            this.panelOutDetailData.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelOutDetailData.Controls.Add(this.dgvOutDetailReport);
            this.panelOutDetailData.Location = new System.Drawing.Point(33, 126);
            this.panelOutDetailData.Name = "panelOutDetailData";
            this.panelOutDetailData.Size = new System.Drawing.Size(832, 438);
            this.panelOutDetailData.TabIndex = 2;
            // 
            // dgvOutDetailReport
            // 
            this.dgvOutDetailReport.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvOutDetailReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutDetailReport.Location = new System.Drawing.Point(3, 14);
            this.dgvOutDetailReport.Name = "dgvOutDetailReport";
            this.dgvOutDetailReport.RowTemplate.Height = 24;
            this.dgvOutDetailReport.Size = new System.Drawing.Size(811, 325);
            this.dgvOutDetailReport.TabIndex = 1;
            // 
            // panelOutDetailQuery
            // 
            this.panelOutDetailQuery.BackColor = System.Drawing.Color.LightYellow;
            this.panelOutDetailQuery.Controls.Add(this.lblOutDetailTotAmt);
            this.panelOutDetailQuery.Controls.Add(this.btnOutDetailQuery);
            this.panelOutDetailQuery.Controls.Add(this.btnOutDetailClear);
            this.panelOutDetailQuery.Controls.Add(this.txtOutDetailEDate);
            this.panelOutDetailQuery.Controls.Add(this.txtOutDetailSDate);
            this.panelOutDetailQuery.Controls.Add(this.txtOutDetailLabel2);
            this.panelOutDetailQuery.Controls.Add(this.txtOutDetailLabel1);
            this.panelOutDetailQuery.Location = new System.Drawing.Point(33, 18);
            this.panelOutDetailQuery.Name = "panelOutDetailQuery";
            this.panelOutDetailQuery.Size = new System.Drawing.Size(823, 102);
            this.panelOutDetailQuery.TabIndex = 1;
            // 
            // lblOutDetailTotAmt
            // 
            this.lblOutDetailTotAmt.AutoSize = true;
            this.lblOutDetailTotAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutDetailTotAmt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOutDetailTotAmt.ForeColor = System.Drawing.Color.Red;
            this.lblOutDetailTotAmt.Location = new System.Drawing.Point(65, 75);
            this.lblOutDetailTotAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutDetailTotAmt.Name = "lblOutDetailTotAmt";
            this.lblOutDetailTotAmt.Size = new System.Drawing.Size(57, 18);
            this.lblOutDetailTotAmt.TabIndex = 6;
            this.lblOutDetailTotAmt.Text = "總金額";
            this.lblOutDetailTotAmt.Visible = false;
            // 
            // btnOutDetailQuery
            // 
            this.btnOutDetailQuery.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOutDetailQuery.Location = new System.Drawing.Point(507, 33);
            this.btnOutDetailQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnOutDetailQuery.Name = "btnOutDetailQuery";
            this.btnOutDetailQuery.Size = new System.Drawing.Size(147, 29);
            this.btnOutDetailQuery.TabIndex = 4;
            this.btnOutDetailQuery.Text = "出貨細項查詢";
            this.btnOutDetailQuery.UseVisualStyleBackColor = true;
            this.btnOutDetailQuery.Click += new System.EventHandler(this.btnOutDetailQuery_Click);
            // 
            // btnOutDetailClear
            // 
            this.btnOutDetailClear.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOutDetailClear.Location = new System.Drawing.Point(693, 34);
            this.btnOutDetailClear.Name = "btnOutDetailClear";
            this.btnOutDetailClear.Size = new System.Drawing.Size(80, 27);
            this.btnOutDetailClear.TabIndex = 5;
            this.btnOutDetailClear.Text = "清螢幕";
            this.btnOutDetailClear.UseVisualStyleBackColor = true;
            this.btnOutDetailClear.Click += new System.EventHandler(this.btnOutDetailClear_Click);
            // 
            // txtOutDetailEDate
            // 
            this.txtOutDetailEDate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutDetailEDate.Location = new System.Drawing.Point(359, 33);
            this.txtOutDetailEDate.Name = "txtOutDetailEDate";
            this.txtOutDetailEDate.Size = new System.Drawing.Size(105, 30);
            this.txtOutDetailEDate.TabIndex = 3;
            this.txtOutDetailEDate.Text = "1141231";
            // 
            // txtOutDetailSDate
            // 
            this.txtOutDetailSDate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutDetailSDate.Location = new System.Drawing.Point(216, 33);
            this.txtOutDetailSDate.Name = "txtOutDetailSDate";
            this.txtOutDetailSDate.Size = new System.Drawing.Size(105, 30);
            this.txtOutDetailSDate.TabIndex = 2;
            this.txtOutDetailSDate.Text = "1141201";
            // 
            // txtOutDetailLabel2
            // 
            this.txtOutDetailLabel2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutDetailLabel2.Location = new System.Drawing.Point(327, 33);
            this.txtOutDetailLabel2.Name = "txtOutDetailLabel2";
            this.txtOutDetailLabel2.ReadOnly = true;
            this.txtOutDetailLabel2.Size = new System.Drawing.Size(26, 30);
            this.txtOutDetailLabel2.TabIndex = 1;
            this.txtOutDetailLabel2.Text = "～";
            // 
            // txtOutDetailLabel1
            // 
            this.txtOutDetailLabel1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutDetailLabel1.Location = new System.Drawing.Point(65, 33);
            this.txtOutDetailLabel1.Name = "txtOutDetailLabel1";
            this.txtOutDetailLabel1.ReadOnly = true;
            this.txtOutDetailLabel1.Size = new System.Drawing.Size(145, 30);
            this.txtOutDetailLabel1.TabIndex = 0;
            this.txtOutDetailLabel1.Text = "查詢起迄日期:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(876, 577);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.panelOutMonthData);
            this.tabPage11.Controls.Add(this.panelOutMonthQuery);
            this.tabPage11.Controls.Add(this.pictureBox6);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(885, 583);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "月報";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // panelOutMonthData
            // 
            this.panelOutMonthData.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelOutMonthData.Controls.Add(this.dgvOutMonthReport);
            this.panelOutMonthData.Location = new System.Drawing.Point(33, 126);
            this.panelOutMonthData.Name = "panelOutMonthData";
            this.panelOutMonthData.Size = new System.Drawing.Size(832, 438);
            this.panelOutMonthData.TabIndex = 2;
            // 
            // dgvOutMonthReport
            // 
            this.dgvOutMonthReport.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvOutMonthReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutMonthReport.Location = new System.Drawing.Point(3, 14);
            this.dgvOutMonthReport.Name = "dgvOutMonthReport";
            this.dgvOutMonthReport.RowTemplate.Height = 24;
            this.dgvOutMonthReport.Size = new System.Drawing.Size(811, 325);
            this.dgvOutMonthReport.TabIndex = 1;
            // 
            // panelOutMonthQuery
            // 
            this.panelOutMonthQuery.BackColor = System.Drawing.Color.LightYellow;
            this.panelOutMonthQuery.Controls.Add(this.lblOutMonthTotAmt);
            this.panelOutMonthQuery.Controls.Add(this.btnOutMonthQuery);
            this.panelOutMonthQuery.Controls.Add(this.btnOutMonthClear);
            this.panelOutMonthQuery.Controls.Add(this.txtOutMonthEDate);
            this.panelOutMonthQuery.Controls.Add(this.txtOutMonthSDate);
            this.panelOutMonthQuery.Controls.Add(this.txtOutMonthLabel2);
            this.panelOutMonthQuery.Controls.Add(this.txtOutMonthLabel1);
            this.panelOutMonthQuery.Location = new System.Drawing.Point(33, 18);
            this.panelOutMonthQuery.Name = "panelOutMonthQuery";
            this.panelOutMonthQuery.Size = new System.Drawing.Size(823, 102);
            this.panelOutMonthQuery.TabIndex = 1;
            // 
            // lblOutMonthTotAmt
            // 
            this.lblOutMonthTotAmt.AutoSize = true;
            this.lblOutMonthTotAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutMonthTotAmt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOutMonthTotAmt.ForeColor = System.Drawing.Color.Red;
            this.lblOutMonthTotAmt.Location = new System.Drawing.Point(65, 75);
            this.lblOutMonthTotAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutMonthTotAmt.Name = "lblOutMonthTotAmt";
            this.lblOutMonthTotAmt.Size = new System.Drawing.Size(57, 18);
            this.lblOutMonthTotAmt.TabIndex = 6;
            this.lblOutMonthTotAmt.Text = "總金額";
            this.lblOutMonthTotAmt.Visible = false;
            // 
            // btnOutMonthQuery
            // 
            this.btnOutMonthQuery.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOutMonthQuery.Location = new System.Drawing.Point(507, 33);
            this.btnOutMonthQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnOutMonthQuery.Name = "btnOutMonthQuery";
            this.btnOutMonthQuery.Size = new System.Drawing.Size(137, 29);
            this.btnOutMonthQuery.TabIndex = 4;
            this.btnOutMonthQuery.Text = "出貨月報查詢";
            this.btnOutMonthQuery.UseVisualStyleBackColor = true;
            this.btnOutMonthQuery.Click += new System.EventHandler(this.btnOutMonthQuery_Click);
            // 
            // btnOutMonthClear
            // 
            this.btnOutMonthClear.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOutMonthClear.Location = new System.Drawing.Point(693, 34);
            this.btnOutMonthClear.Name = "btnOutMonthClear";
            this.btnOutMonthClear.Size = new System.Drawing.Size(80, 27);
            this.btnOutMonthClear.TabIndex = 5;
            this.btnOutMonthClear.Text = "清螢幕";
            this.btnOutMonthClear.UseVisualStyleBackColor = true;
            this.btnOutMonthClear.Click += new System.EventHandler(this.btnOutMonthClear_Click);
            // 
            // txtOutMonthEDate
            // 
            this.txtOutMonthEDate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutMonthEDate.Location = new System.Drawing.Point(359, 33);
            this.txtOutMonthEDate.Name = "txtOutMonthEDate";
            this.txtOutMonthEDate.Size = new System.Drawing.Size(105, 30);
            this.txtOutMonthEDate.TabIndex = 3;
            this.txtOutMonthEDate.Text = "11412";
            // 
            // txtOutMonthSDate
            // 
            this.txtOutMonthSDate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutMonthSDate.Location = new System.Drawing.Point(216, 33);
            this.txtOutMonthSDate.Name = "txtOutMonthSDate";
            this.txtOutMonthSDate.Size = new System.Drawing.Size(105, 30);
            this.txtOutMonthSDate.TabIndex = 2;
            this.txtOutMonthSDate.Text = "11412";
            // 
            // txtOutMonthLabel2
            // 
            this.txtOutMonthLabel2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutMonthLabel2.Location = new System.Drawing.Point(327, 33);
            this.txtOutMonthLabel2.Name = "txtOutMonthLabel2";
            this.txtOutMonthLabel2.ReadOnly = true;
            this.txtOutMonthLabel2.Size = new System.Drawing.Size(26, 30);
            this.txtOutMonthLabel2.TabIndex = 1;
            this.txtOutMonthLabel2.Text = "～";
            // 
            // txtOutMonthLabel1
            // 
            this.txtOutMonthLabel1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutMonthLabel1.Location = new System.Drawing.Point(65, 33);
            this.txtOutMonthLabel1.Name = "txtOutMonthLabel1";
            this.txtOutMonthLabel1.ReadOnly = true;
            this.txtOutMonthLabel1.Size = new System.Drawing.Size(145, 30);
            this.txtOutMonthLabel1.TabIndex = 0;
            this.txtOutMonthLabel1.Text = "查詢起迄日期:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(876, 577);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1081, 618);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "基本資料維護";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.btnDataGridView);
            this.tabPage9.Controls.Add(this.btnTranTest);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1081, 618);
            this.tabPage9.TabIndex = 6;
            this.tabPage9.Text = "其他";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // btnDataGridView
            // 
            this.btnDataGridView.Location = new System.Drawing.Point(63, 64);
            this.btnDataGridView.Name = "btnDataGridView";
            this.btnDataGridView.Size = new System.Drawing.Size(126, 61);
            this.btnDataGridView.TabIndex = 0;
            this.btnDataGridView.Text = "DataGridView";
            this.btnDataGridView.UseVisualStyleBackColor = true;
            this.btnDataGridView.Click += new System.EventHandler(this.btnDataGridView_Click);
            // 
            // btnTranTest
            // 
            this.btnTranTest.Location = new System.Drawing.Point(236, 64);
            this.btnTranTest.Name = "btnTranTest";
            this.btnTranTest.Size = new System.Drawing.Size(126, 61);
            this.btnTranTest.TabIndex = 0;
            this.btnTranTest.Text = "Transaction";
            this.btnTranTest.UseVisualStyleBackColor = true;
            this.btnTranTest.Click += new System.EventHandler(this.btnTranTest_Click);
            // 
            // ProdInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 650);
            this.Controls.Add(this.tabControl);
            this.Name = "ProdInOut";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.ProdInOut_Activated);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOut)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl_InpRpt.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.panelInpDetailData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInpDetailReport)).EndInit();
            this.panelInpDetailQuery.ResumeLayout(false);
            this.panelInpDetailQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.panelInpMonthData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInpMonthReport)).EndInit();
            this.panelInpMonthQuery.ResumeLayout(false);
            this.panelInpMonthQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabControl_OutRpt.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.panelOutDetailData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutDetailReport)).EndInit();
            this.panelOutDetailQuery.ResumeLayout(false);
            this.panelOutDetailQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.panelOutMonthData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutMonthReport)).EndInit();
            this.panelOutMonthQuery.ResumeLayout(false);
            this.panelOutMonthQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInpFactNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtInpUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInpQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInpPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtInpProdNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFactName;
        private System.Windows.Forms.DataGridView DgvInp;
        private System.Windows.Forms.Button btnSaveInpDgv;
        private System.Windows.Forms.Button btnInpOK;
        private System.Windows.Forms.Button btnInpClear;
        private System.Windows.Forms.Button btnClearInpDgv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InpPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InpQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn InpAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInpDateTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl_InpRpt;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Panel panelInpDetailQuery;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelInpDetailData;
        private System.Windows.Forms.Button btnInpDetailClear;
        private System.Windows.Forms.TextBox txtInpDetailEDate;
        private System.Windows.Forms.TextBox txtInpDetailSDate;
        private System.Windows.Forms.TextBox txtInpDetailLabel2;
        private System.Windows.Forms.TextBox txtInpDetailLabel1;
        private System.Windows.Forms.DataGridView dgvInpDetailReport;
        private System.Windows.Forms.Button btnInpDetailQuery;
        private System.Windows.Forms.Label lblInpDetailTotAmt;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView DgvOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutProdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutUnit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtOutDateTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOutAmt;
        private System.Windows.Forms.Button btnOutExit;
        private System.Windows.Forms.Button btnClearOutDgv;
        private System.Windows.Forms.Button btnOutClear;
        private System.Windows.Forms.Button btnSaveOutDgv;
        private System.Windows.Forms.Button btnOutOK;
        private System.Windows.Forms.TextBox txtOutUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOutQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOutPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOutProdName;
        private System.Windows.Forms.TextBox txtOutProdNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOutFactName;
        private System.Windows.Forms.TextBox txtOutFactNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button btnTranTest;
        private System.Windows.Forms.Button btnDataGridView;
        private System.Windows.Forms.Panel panelInpMonthData;
        private System.Windows.Forms.DataGridView dgvInpMonthReport;
        private System.Windows.Forms.Panel panelInpMonthQuery;
        private System.Windows.Forms.Label lblInpMonthTotAmt;
        private System.Windows.Forms.Button btnInpMonthQuery;
        private System.Windows.Forms.Button btnInpMonthClear;
        private System.Windows.Forms.TextBox txtInpMonthEDate;
        private System.Windows.Forms.TextBox txtInpMonthSDate;
        private System.Windows.Forms.TextBox txtInpMonthLabel2;
        private System.Windows.Forms.TextBox txtInpMonthLabel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabControl tabControl_OutRpt;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Panel panelOutDetailData;
        private System.Windows.Forms.DataGridView dgvOutDetailReport;
        private System.Windows.Forms.Panel panelOutDetailQuery;
        private System.Windows.Forms.Label lblOutDetailTotAmt;
        private System.Windows.Forms.Button btnOutDetailQuery;
        private System.Windows.Forms.Button btnOutDetailClear;
        private System.Windows.Forms.TextBox txtOutDetailEDate;
        private System.Windows.Forms.TextBox txtOutDetailSDate;
        private System.Windows.Forms.TextBox txtOutDetailLabel2;
        private System.Windows.Forms.TextBox txtOutDetailLabel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Panel panelOutMonthData;
        private System.Windows.Forms.DataGridView dgvOutMonthReport;
        private System.Windows.Forms.Panel panelOutMonthQuery;
        private System.Windows.Forms.Label lblOutMonthTotAmt;
        private System.Windows.Forms.Button btnOutMonthQuery;
        private System.Windows.Forms.Button btnOutMonthClear;
        private System.Windows.Forms.TextBox txtOutMonthEDate;
        private System.Windows.Forms.TextBox txtOutMonthSDate;
        private System.Windows.Forms.TextBox txtOutMonthLabel2;
        private System.Windows.Forms.TextBox txtOutMonthLabel1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

