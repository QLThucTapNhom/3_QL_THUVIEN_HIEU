namespace QL_THUVIEN2
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpn1madg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttqlnvxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.bttthemmoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnLammoi);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.btthoat);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.bttqlnvxoa);
            this.panel1.Controls.Add(this.btsua);
            this.panel1.Controls.Add(this.bttthemmoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 458);
            this.panel1.TabIndex = 1;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(334, 99);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(180, 26);
            this.txtten.TabIndex = 30;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(334, 42);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(180, 26);
            this.txtma.TabIndex = 29;
            // 
            // btthoat
            // 
            this.btthoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btthoat.Location = new System.Drawing.Point(472, 179);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(74, 41);
            this.btthoat.TabIndex = 27;
            this.btthoat.Text = "Thoát";
            this.btthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dgvpn1madg});
            this.dgv.Location = new System.Drawing.Point(11, 226);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(534, 223);
            this.dgv.TabIndex = 8;
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTL";
            this.Column1.HeaderText = "Mã Loại";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvpn1madg
            // 
            this.dgvpn1madg.DataPropertyName = "TenTL";
            this.dgvpn1madg.HeaderText = "Tên Loại";
            this.dgvpn1madg.Name = "dgvpn1madg";
            // 
            // bttqlnvxoa
            // 
            this.bttqlnvxoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttqlnvxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttqlnvxoa.Location = new System.Drawing.Point(28, 165);
            this.bttqlnvxoa.Name = "bttqlnvxoa";
            this.bttqlnvxoa.Size = new System.Drawing.Size(134, 55);
            this.bttqlnvxoa.TabIndex = 26;
            this.bttqlnvxoa.Text = "Xóa";
            this.bttqlnvxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttqlnvxoa.UseVisualStyleBackColor = false;
            this.bttqlnvxoa.Click += new System.EventHandler(this.bttqlnvxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btsua.Location = new System.Drawing.Point(28, 94);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(134, 62);
            this.btsua.TabIndex = 24;
            this.btsua.Text = "Sửa";
            this.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttthemmoi
            // 
            this.bttthemmoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttthemmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttthemmoi.Location = new System.Drawing.Point(29, 25);
            this.bttthemmoi.Name = "bttthemmoi";
            this.bttthemmoi.Size = new System.Drawing.Size(133, 56);
            this.bttthemmoi.TabIndex = 23;
            this.bttthemmoi.Text = "Thêm";
            this.bttthemmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttthemmoi.UseVisualStyleBackColor = false;
            this.bttthemmoi.Click += new System.EventHandler(this.bttthemmoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(224, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thể Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(224, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thể Loại";
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLammoi.Location = new System.Drawing.Point(439, 133);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 40);
            this.btnLammoi.TabIndex = 31;
            this.btnLammoi.Text = "Mới";
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.BtnLammoi_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 458);
            this.Controls.Add(this.panel1);
            this.Name = "Category";
            this.Text = "The Loai Sach";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bttqlnvxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button bttthemmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpn1madg;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button btnLammoi;
    }
}