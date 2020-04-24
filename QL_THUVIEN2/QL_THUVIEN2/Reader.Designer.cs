namespace QL_THUVIEN2
{
    partial class Reader
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
            this.paneldg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvchitiet = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtgt = new System.Windows.Forms.TextBox();
            this.txtns = new System.Windows.Forms.DateTimePicker();
            this.bttxoa = new System.Windows.Forms.Button();
            this.bttsua = new System.Windows.Forms.Button();
            this.bttthemmoi = new System.Windows.Forms.Button();
            this.txtstd = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtttcnten = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.paneldg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldg
            // 
            this.paneldg.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paneldg.Controls.Add(this.label1);
            this.paneldg.Controls.Add(this.dgvds);
            this.paneldg.Controls.Add(this.groupBox1);
            this.paneldg.Controls.Add(this.button2);
            this.paneldg.Controls.Add(this.txtgt);
            this.paneldg.Controls.Add(this.txtns);
            this.paneldg.Controls.Add(this.bttxoa);
            this.paneldg.Controls.Add(this.bttsua);
            this.paneldg.Controls.Add(this.bttthemmoi);
            this.paneldg.Controls.Add(this.txtstd);
            this.paneldg.Controls.Add(this.txtdc);
            this.paneldg.Controls.Add(this.txtten);
            this.paneldg.Controls.Add(this.txtma);
            this.paneldg.Controls.Add(this.label19);
            this.paneldg.Controls.Add(this.label17);
            this.paneldg.Controls.Add(this.label16);
            this.paneldg.Controls.Add(this.label14);
            this.paneldg.Controls.Add(this.label13);
            this.paneldg.Controls.Add(this.txtttcnten);
            this.paneldg.Controls.Add(this.label11);
            this.paneldg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneldg.Location = new System.Drawing.Point(0, 0);
            this.paneldg.Name = "paneldg";
            this.paneldg.Size = new System.Drawing.Size(1030, 613);
            this.paneldg.TabIndex = 3;
            this.paneldg.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Danh Sách Độc Giả";
            // 
            // dgvds
            // 
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Location = new System.Drawing.Point(24, 236);
            this.dgvds.Name = "dgvds";
            this.dgvds.Size = new System.Drawing.Size(673, 247);
            this.dgvds.TabIndex = 29;
            this.dgvds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvds_CellClick);
            this.dgvds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvchitiet);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(711, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 272);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết mượn sách";
            // 
            // dgvchitiet
            // 
            this.dgvchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitiet.Location = new System.Drawing.Point(19, 25);
            this.dgvchitiet.Name = "dgvchitiet";
            this.dgvchitiet.Size = new System.Drawing.Size(225, 247);
            this.dgvchitiet.TabIndex = 0;
            this.dgvchitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchitiet_CellContentClick);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(718, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 59);
            this.button2.TabIndex = 26;
            this.button2.Text = "Thoát";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtgt
            // 
            this.txtgt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtgt.Location = new System.Drawing.Point(226, 151);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(178, 26);
            this.txtgt.TabIndex = 25;
            // 
            // txtns
            // 
            this.txtns.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtns.CalendarForeColor = System.Drawing.Color.White;
            this.txtns.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtns.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtns.CustomFormat = "dd-MM-yyyy";
            this.txtns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtns.Location = new System.Drawing.Point(622, 148);
            this.txtns.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(200, 26);
            this.txtns.TabIndex = 24;
            // 
            // bttxoa
            // 
            this.bttxoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttxoa.Location = new System.Drawing.Point(548, 521);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(106, 59);
            this.bttxoa.TabIndex = 22;
            this.bttxoa.Text = "Xóa";
            this.bttxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttxoa.UseVisualStyleBackColor = false;
            this.bttxoa.Click += new System.EventHandler(this.bttqlnvxoa_Click_1);
            // 
            // bttsua
            // 
            this.bttsua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttsua.Location = new System.Drawing.Point(367, 521);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(106, 59);
            this.bttsua.TabIndex = 20;
            this.bttsua.Text = "Sửa";
            this.bttsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttsua.UseVisualStyleBackColor = false;
            this.bttsua.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bttthemmoi
            // 
            this.bttthemmoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttthemmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttthemmoi.Location = new System.Drawing.Point(179, 521);
            this.bttthemmoi.Name = "bttthemmoi";
            this.bttthemmoi.Size = new System.Drawing.Size(129, 59);
            this.bttthemmoi.TabIndex = 19;
            this.bttthemmoi.Text = "Thêm";
            this.bttthemmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttthemmoi.UseVisualStyleBackColor = false;
            this.bttthemmoi.Click += new System.EventHandler(this.bttttcnluu_Click_1);
            // 
            // txtstd
            // 
            this.txtstd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtstd.Location = new System.Drawing.Point(622, 109);
            this.txtstd.Name = "txtstd";
            this.txtstd.Size = new System.Drawing.Size(200, 26);
            this.txtstd.TabIndex = 16;
            // 
            // txtdc
            // 
            this.txtdc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtdc.Location = new System.Drawing.Point(622, 74);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(200, 26);
            this.txtdc.TabIndex = 14;
            // 
            // txtten
            // 
            this.txtten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtten.Location = new System.Drawing.Point(226, 109);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(178, 26);
            this.txtten.TabIndex = 11;
            // 
            // txtma
            // 
            this.txtma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtma.Location = new System.Drawing.Point(226, 74);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(178, 26);
            this.txtma.TabIndex = 10;
            this.txtma.TextChanged += new System.EventHandler(this.txtma_TextChanged);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label19.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Maroon;
            this.label19.Location = new System.Drawing.Point(382, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(315, 24);
            this.label19.TabIndex = 8;
            this.label19.Text = "THÔNG TIN CHI TIẾT ĐỘC GIẢ";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(500, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 22);
            this.label17.TabIndex = 6;
            this.label17.Text = "Ngày sinh :";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(500, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 22);
            this.label16.TabIndex = 5;
            this.label16.Text = "SĐT :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(500, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 22);
            this.label14.TabIndex = 3;
            this.label14.Text = "Địa chỉ :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(119, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Giới tính :";
            // 
            // txtttcnten
            // 
            this.txtttcnten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtttcnten.AutoSize = true;
            this.txtttcnten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtttcnten.ForeColor = System.Drawing.Color.Black;
            this.txtttcnten.Location = new System.Drawing.Point(119, 109);
            this.txtttcnten.Name = "txtttcnten";
            this.txtttcnten.Size = new System.Drawing.Size(86, 22);
            this.txtttcnten.TabIndex = 1;
            this.txtttcnten.Text = "Tên ĐG :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(119, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã ĐG :";
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 612);
            this.Controls.Add(this.paneldg);
            this.Name = "Reader";
            this.Text = "Độc Giả";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.paneldg.ResumeLayout(false);
            this.paneldg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldg;
        private System.Windows.Forms.TextBox txtgt;
        private System.Windows.Forms.DateTimePicker txtns;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.Button bttsua;
        private System.Windows.Forms.Button bttthemmoi;
        private System.Windows.Forms.TextBox txtstd;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtttcnten;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvchitiet;
    }
}