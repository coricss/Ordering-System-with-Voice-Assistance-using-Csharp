namespace CHOWKING
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotAm = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btnShanghai = new System.Windows.Forms.Button();
            this.btnCS = new System.Windows.Forms.Button();
            this.btnPCF = new System.Windows.Forms.Button();
            this.btnPCL = new System.Windows.Forms.Button();
            this.btnYCSC = new System.Windows.Forms.Button();
            this.btnSSPL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoid = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNone = new System.Windows.Forms.RadioButton();
            this.rdPWD = new System.Windows.Forms.RadioButton();
            this.rdSC = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timee = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datee = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toggle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.Location = new System.Drawing.Point(584, 307);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(69, 41);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "ORDER";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtPay
            // 
            this.txtPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay.Location = new System.Drawing.Point(782, 263);
            this.txtPay.MaxLength = 9;
            this.txtPay.Multiline = true;
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(114, 27);
            this.txtPay.TabIndex = 3;
            this.txtPay.Tag = "";
            this.txtPay.Text = "0.00";
            this.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPay_MouseClick);
            this.txtPay.MouseEnter += new System.EventHandler(this.txtPay_MouseEnter);
            this.txtPay.MouseLeave += new System.EventHandler(this.txtPay_MouseLeave);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.AutoSize = true;
            this.txtSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSubTotal.Location = new System.Drawing.Point(856, 390);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(40, 20);
            this.txtSubTotal.TabIndex = 4;
            this.txtSubTotal.Text = "0.00";
            // 
            // txtChange
            // 
            this.txtChange.AutoSize = true;
            this.txtChange.BackColor = System.Drawing.Color.Transparent;
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(856, 446);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(40, 20);
            this.txtChange.TabIndex = 5;
            this.txtChange.Text = "0.00";
            // 
            // txtQuan
            // 
            this.txtQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuan.Location = new System.Drawing.Point(684, 264);
            this.txtQuan.Multiline = true;
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(44, 27);
            this.txtQuan.TabIndex = 6;
            this.txtQuan.Text = "0";
            this.txtQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuan_MouseClick);
            this.txtQuan.MouseEnter += new System.EventHandler(this.txtQuan_MouseEnter);
            this.txtQuan.MouseLeave += new System.EventHandler(this.txtQuan_MouseLeave);
            this.txtQuan.MouseHover += new System.EventHandler(this.txtQuan_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(622, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(739, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cash:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.food,
            this.quant,
            this.totalprice});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(601, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(300, 198);
            this.dataGridView1.TabIndex = 9;
            // 
            // food
            // 
            this.food.HeaderText = "Food Ordered";
            this.food.Name = "food";
            this.food.ReadOnly = true;
            this.food.Width = 99;
            // 
            // quant
            // 
            this.quant.HeaderText = "Quantity";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            this.quant.Width = 99;
            // 
            // totalprice
            // 
            this.totalprice.HeaderText = "Total Price";
            this.totalprice.Name = "totalprice";
            this.totalprice.ReadOnly = true;
            this.totalprice.Width = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(754, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sub Total: ₱";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(766, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Change: ₱";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(701, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Vat Amount 12%: ₱";
            // 
            // txtVat
            // 
            this.txtVat.AutoSize = true;
            this.txtVat.BackColor = System.Drawing.Color.Transparent;
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(856, 416);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(40, 20);
            this.txtVat.TabIndex = 14;
            this.txtVat.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(727, 477);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Total Amount: ₱";
            // 
            // txtTotAm
            // 
            this.txtTotAm.AutoSize = true;
            this.txtTotAm.BackColor = System.Drawing.Color.Transparent;
            this.txtTotAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotAm.ForeColor = System.Drawing.Color.Red;
            this.txtTotAm.Location = new System.Drawing.Point(856, 477);
            this.txtTotAm.Name = "txtTotAm";
            this.txtTotAm.Size = new System.Drawing.Size(40, 20);
            this.txtTotAm.TabIndex = 16;
            this.txtTotAm.Text = "0.00";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Enabled = false;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(584, 433);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(69, 41);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "RESET";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btnShanghai
            // 
            this.btnShanghai.BackColor = System.Drawing.SystemColors.Control;
            this.btnShanghai.BackgroundImage = global::CHOWKING.Properties.Resources.shanghai_lauriat;
            this.btnShanghai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShanghai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShanghai.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnShanghai.FlatAppearance.BorderSize = 2;
            this.btnShanghai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShanghai.ForeColor = System.Drawing.Color.Transparent;
            this.btnShanghai.Location = new System.Drawing.Point(67, 40);
            this.btnShanghai.Name = "btnShanghai";
            this.btnShanghai.Size = new System.Drawing.Size(137, 130);
            this.btnShanghai.TabIndex = 0;
            this.btnShanghai.UseVisualStyleBackColor = false;
            this.btnShanghai.Click += new System.EventHandler(this.btnShanghai_Click);
            this.btnShanghai.MouseLeave += new System.EventHandler(this.btnShanghai_MouseLeave);
            this.btnShanghai.MouseHover += new System.EventHandler(this.btnShanghai_MouseHover);
            // 
            // btnCS
            // 
            this.btnCS.BackColor = System.Drawing.Color.Transparent;
            this.btnCS.BackgroundImage = global::CHOWKING.Properties.Resources.chinese_style_pork_chop;
            this.btnCS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCS.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCS.FlatAppearance.BorderSize = 2;
            this.btnCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCS.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCS.Location = new System.Drawing.Point(255, 40);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(137, 130);
            this.btnCS.TabIndex = 1;
            this.btnCS.UseVisualStyleBackColor = false;
            this.btnCS.Click += new System.EventHandler(this.button2_Click);
            this.btnCS.MouseLeave += new System.EventHandler(this.btnCS_MouseLeave);
            this.btnCS.MouseHover += new System.EventHandler(this.btnCS_MouseHover);
            // 
            // btnPCF
            // 
            this.btnPCF.BackColor = System.Drawing.Color.Transparent;
            this.btnPCF.BackgroundImage = global::CHOWKING.Properties.Resources.pork_chao_fan1;
            this.btnPCF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPCF.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPCF.FlatAppearance.BorderSize = 2;
            this.btnPCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCF.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPCF.Location = new System.Drawing.Point(422, 40);
            this.btnPCF.Name = "btnPCF";
            this.btnPCF.Size = new System.Drawing.Size(137, 130);
            this.btnPCF.TabIndex = 2;
            this.btnPCF.UseVisualStyleBackColor = false;
            this.btnPCF.Click += new System.EventHandler(this.btnPCF_Click);
            this.btnPCF.MouseLeave += new System.EventHandler(this.btnPCF_MouseLeave);
            this.btnPCF.MouseHover += new System.EventHandler(this.btnPCF_MouseHover);
            // 
            // btnPCL
            // 
            this.btnPCL.BackColor = System.Drawing.Color.Transparent;
            this.btnPCL.BackgroundImage = global::CHOWKING.Properties.Resources.pork_chop_lauriat1;
            this.btnPCL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPCL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPCL.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPCL.FlatAppearance.BorderSize = 2;
            this.btnPCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPCL.Location = new System.Drawing.Point(67, 196);
            this.btnPCL.Name = "btnPCL";
            this.btnPCL.Size = new System.Drawing.Size(137, 130);
            this.btnPCL.TabIndex = 3;
            this.btnPCL.UseVisualStyleBackColor = false;
            this.btnPCL.Click += new System.EventHandler(this.btnPCL_Click);
            this.btnPCL.MouseLeave += new System.EventHandler(this.btnPCL_MouseLeave);
            this.btnPCL.MouseHover += new System.EventHandler(this.btnPCL_MouseHover);
            // 
            // btnYCSC
            // 
            this.btnYCSC.BackColor = System.Drawing.Color.Transparent;
            this.btnYCSC.BackgroundImage = global::CHOWKING.Properties.Resources.yang_chow1;
            this.btnYCSC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYCSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYCSC.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnYCSC.FlatAppearance.BorderSize = 2;
            this.btnYCSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYCSC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYCSC.Location = new System.Drawing.Point(255, 196);
            this.btnYCSC.Name = "btnYCSC";
            this.btnYCSC.Size = new System.Drawing.Size(137, 130);
            this.btnYCSC.TabIndex = 4;
            this.btnYCSC.UseVisualStyleBackColor = false;
            this.btnYCSC.Click += new System.EventHandler(this.btnYCSC_Click);
            this.btnYCSC.MouseLeave += new System.EventHandler(this.btnYCSC_MouseLeave);
            this.btnYCSC.MouseHover += new System.EventHandler(this.btnYCSC_MouseHover);
            // 
            // btnSSPL
            // 
            this.btnSSPL.BackColor = System.Drawing.Color.Transparent;
            this.btnSSPL.BackgroundImage = global::CHOWKING.Properties.Resources.sweet_and_sour;
            this.btnSSPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSSPL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSSPL.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSSPL.FlatAppearance.BorderSize = 2;
            this.btnSSPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSPL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSSPL.Location = new System.Drawing.Point(422, 196);
            this.btnSSPL.Name = "btnSSPL";
            this.btnSSPL.Size = new System.Drawing.Size(137, 130);
            this.btnSSPL.TabIndex = 5;
            this.btnSSPL.UseVisualStyleBackColor = false;
            this.btnSSPL.Click += new System.EventHandler(this.btnSSPL_Click);
            this.btnSSPL.MouseLeave += new System.EventHandler(this.btnSSPL_MouseLeave);
            this.btnSSPL.MouseHover += new System.EventHandler(this.btnSSPL_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "₱165";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "₱105";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "₱55";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "₱178";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "₱110";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "₱150";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHOWKING.Properties.Resources.chow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::CHOWKING.Properties.Resources.chow;
            this.pictureBox1.Location = new System.Drawing.Point(219, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoid.Enabled = false;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.ForeColor = System.Drawing.Color.White;
            this.btnVoid.Location = new System.Drawing.Point(584, 374);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(69, 41);
            this.btnVoid.TabIndex = 19;
            this.btnVoid.Text = "VOID";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rdNone);
            this.groupBox1.Controls.Add(this.rdPWD);
            this.groupBox1.Controls.Add(this.rdSC);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(705, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 85);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount";
            // 
            // rdNone
            // 
            this.rdNone.AutoSize = true;
            this.rdNone.Location = new System.Drawing.Point(27, 54);
            this.rdNone.Name = "rdNone";
            this.rdNone.Size = new System.Drawing.Size(51, 17);
            this.rdNone.TabIndex = 2;
            this.rdNone.TabStop = true;
            this.rdNone.Text = "None";
            this.rdNone.UseVisualStyleBackColor = true;
            this.rdNone.CheckedChanged += new System.EventHandler(this.rdNone_CheckedChanged);
            // 
            // rdPWD
            // 
            this.rdPWD.AutoSize = true;
            this.rdPWD.Location = new System.Drawing.Point(27, 36);
            this.rdPWD.Name = "rdPWD";
            this.rdPWD.Size = new System.Drawing.Size(51, 17);
            this.rdPWD.TabIndex = 1;
            this.rdPWD.TabStop = true;
            this.rdPWD.Text = "PWD";
            this.rdPWD.UseVisualStyleBackColor = true;
            this.rdPWD.CheckedChanged += new System.EventHandler(this.rdPWD_CheckedChanged);
            // 
            // rdSC
            // 
            this.rdSC.AutoSize = true;
            this.rdSC.Location = new System.Drawing.Point(27, 19);
            this.rdSC.Name = "rdSC";
            this.rdSC.Size = new System.Drawing.Size(89, 17);
            this.rdSC.TabIndex = 0;
            this.rdSC.TabStop = true;
            this.rdSC.Text = "Senior Citizen";
            this.rdSC.UseVisualStyleBackColor = true;
            this.rdSC.CheckedChanged += new System.EventHandler(this.rdSC_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(584, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.Visible = false;
            // 
            // timee
            // 
            this.timee.AutoSize = true;
            this.timee.BackColor = System.Drawing.Color.Transparent;
            this.timee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timee.ForeColor = System.Drawing.Color.Yellow;
            this.timee.Location = new System.Drawing.Point(873, 8);
            this.timee.Name = "timee";
            this.timee.Size = new System.Drawing.Size(47, 20);
            this.timee.TabIndex = 22;
            this.timee.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // datee
            // 
            this.datee.AutoSize = true;
            this.datee.BackColor = System.Drawing.Color.Transparent;
            this.datee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datee.ForeColor = System.Drawing.Color.Yellow;
            this.datee.Location = new System.Drawing.Point(36, 8);
            this.datee.Name = "datee";
            this.datee.Size = new System.Drawing.Size(48, 20);
            this.datee.TabIndex = 23;
            this.datee.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toggle);
            this.groupBox2.Location = new System.Drawing.Point(881, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 85);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View History";
            // 
            // toggle
            // 
            this.toggle.BackgroundImage = global::CHOWKING.Properties.Resources.toggle1;
            this.toggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggle.Location = new System.Drawing.Point(16, 30);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(58, 32);
            this.toggle.TabIndex = 0;
            this.toggle.TabStop = false;
            this.toggle.Click += new System.EventHandler(this.toggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CHOWKING.Properties.Resources.background_chowking;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 749);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.datee);
            this.Controls.Add(this.timee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotAm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSSPL);
            this.Controls.Add(this.btnYCSC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPCL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPCF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnShanghai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.btnTotal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1035, 788);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1035, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chowking Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label txtSubTotal;
        private System.Windows.Forms.Label txtChange;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn food;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtVat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtTotAm;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btnShanghai;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnPCF;
        private System.Windows.Forms.Button btnPCL;
        private System.Windows.Forms.Button btnYCSC;
        private System.Windows.Forms.Button btnSSPL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPWD;
        private System.Windows.Forms.RadioButton rdSC;
        private System.Windows.Forms.RadioButton rdNone;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label timee;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox toggle;
    }
}

