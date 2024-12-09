namespace Perpustakaan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.txtTahunTerbit = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewBuku = new System.Windows.Forms.DataGridView();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblPenulis = new System.Windows.Forms.Label();
            this.lblTahunTerbit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(142, 28);
            this.txtJudul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(226, 20);
            this.txtJudul.TabIndex = 0;
            this.txtJudul.Enter += new System.EventHandler(this.txtJudul_Enter);
            this.txtJudul.Leave += new System.EventHandler(this.txtJudul_Leave);
            // 
            // txtPenulis
            // 
            this.txtPenulis.Location = new System.Drawing.Point(142, 66);
            this.txtPenulis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPenulis.Name = "txtPenulis";
            this.txtPenulis.Size = new System.Drawing.Size(226, 20);
            this.txtPenulis.TabIndex = 1;
            this.txtPenulis.Enter += new System.EventHandler(this.txtPenulis_Enter);
            this.txtPenulis.Leave += new System.EventHandler(this.txtPenulis_Leave);
            // 
            // txtTahunTerbit
            // 
            this.txtTahunTerbit.Location = new System.Drawing.Point(142, 103);
            this.txtTahunTerbit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTahunTerbit.Name = "txtTahunTerbit";
            this.txtTahunTerbit.Size = new System.Drawing.Size(226, 20);
            this.txtTahunTerbit.TabIndex = 2;
            this.txtTahunTerbit.Enter += new System.EventHandler(this.txtTahunTerbit_Enter);
            this.txtTahunTerbit.Leave += new System.EventHandler(this.txtTahunTerbit_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 127);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Tambah Buku";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewBuku
            // 
            this.dataGridViewBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuku.Location = new System.Drawing.Point(9, 162);
            this.dataGridViewBuku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBuku.Name = "dataGridViewBuku";
            this.dataGridViewBuku.Size = new System.Drawing.Size(477, 140);
            this.dataGridViewBuku.TabIndex = 4;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(142, 15);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(35, 13);
            this.lblJudul.TabIndex = 5;
            this.lblJudul.Text = "Judul:";
            // 
            // lblPenulis
            // 
            this.lblPenulis.AutoSize = true;
            this.lblPenulis.Location = new System.Drawing.Point(142, 53);
            this.lblPenulis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPenulis.Name = "lblPenulis";
            this.lblPenulis.Size = new System.Drawing.Size(44, 13);
            this.lblPenulis.TabIndex = 6;
            this.lblPenulis.Text = "Penulis:";
            // 
            // lblTahunTerbit
            // 
            this.lblTahunTerbit.AutoSize = true;
            this.lblTahunTerbit.Location = new System.Drawing.Point(142, 90);
            this.lblTahunTerbit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTahunTerbit.Name = "lblTahunTerbit";
            this.lblTahunTerbit.Size = new System.Drawing.Size(71, 13);
            this.lblTahunTerbit.TabIndex = 7;
            this.lblTahunTerbit.Text = "Tahun Terbit:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 325);
            this.Controls.Add(this.dataGridViewBuku);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTahunTerbit);
            this.Controls.Add(this.txtTahunTerbit);
            this.Controls.Add(this.lblPenulis);
            this.Controls.Add(this.txtPenulis);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.txtJudul);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Aplikasi Perpustakaan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.TextBox txtTahunTerbit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewBuku;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPenulis;
        private System.Windows.Forms.Label lblTahunTerbit;
    }
}