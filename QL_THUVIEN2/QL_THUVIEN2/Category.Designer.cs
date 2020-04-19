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
            this.ten = new System.Windows.Forms.TextBox();
            this.ma = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpn1madg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttqlnvxoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttthemmoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.ten);
            this.panel1.Controls.Add(this.ma);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.bttqlnvxoa);
            this.panel1.Controls.Add(this.button1);
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
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(334, 91);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(180, 26);
            this.ten.TabIndex = 30;
            // 
            // ma
            // 
            this.ma.Location = new System.Drawing.Point(334, 22);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(180, 26);
            this.ma.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
           // this.button2.Image = global::QL_THUVIEN2.Properties.Resources.rewind1;
            this.button2.Location = new System.Drawing.Point(420, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 56);
            this.button2.TabIndex = 27;
            this.button2.Text = "Exit";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.Column1.HeaderText = "Category ID";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvpn1madg
            // 
            this.dgvpn1madg.DataPropertyName = "TenTL";
            this.dgvpn1madg.HeaderText = "Name";
            this.dgvpn1madg.Name = "dgvpn1madg";
            // 
            // bttqlnvxoa
            // 
            this.bttqlnvxoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
      //      this.bttqlnvxoa.Image = global::QL_THUVIEN2.Properties.Resources.window_remove;
            this.bttqlnvxoa.Location = new System.Drawing.Point(28, 165);
            this.bttqlnvxoa.Name = "bttqlnvxoa";
            this.bttqlnvxoa.Size = new System.Drawing.Size(134, 55);
            this.bttqlnvxoa.TabIndex = 26;
            this.bttqlnvxoa.Text = "Delete";
            this.bttqlnvxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttqlnvxoa.UseVisualStyleBackColor = true;
            this.bttqlnvxoa.Click += new System.EventHandler(this.bttqlnvxoa_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
         //   this.button1.Image = global::QL_THUVIEN2.Properties.Resources.window_edit;
            this.button1.Location = new System.Drawing.Point(28, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 62);
            this.button1.TabIndex = 24;
            this.button1.Text = "Edit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttthemmoi
            // 
            this.bttthemmoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
         //   this.bttthemmoi.Image = global::QL_THUVIEN2.Properties.Resources.window_add;
            this.bttthemmoi.Location = new System.Drawing.Point(29, 25);
            this.bttthemmoi.Name = "bttthemmoi";
            this.bttthemmoi.Size = new System.Drawing.Size(133, 56);
            this.bttthemmoi.TabIndex = 23;
            this.bttthemmoi.Text = "Add";
            this.bttthemmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttthemmoi.UseVisualStyleBackColor = true;
            this.bttthemmoi.Click += new System.EventHandler(this.bttthemmoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(224, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(224, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 458);
            this.Controls.Add(this.panel1);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bttqlnvxoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttthemmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.TextBox ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpn1madg;
    }
}