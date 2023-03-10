
namespace zeamart_tokohijab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_zeamart = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_jenis = new System.Windows.Forms.Label();
            this.label_stok = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_jenis = new System.Windows.Forms.TextBox();
            this.tb_stok = new System.Windows.Forms.TextBox();
            this.label_harga = new System.Windows.Forms.Label();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_nama_edit = new System.Windows.Forms.TextBox();
            this.tb_jenis_edit = new System.Windows.Forms.TextBox();
            this.tb_stok_edit = new System.Windows.Forms.TextBox();
            this.tb_harga_edit = new System.Windows.Forms.TextBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_zeamart.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(746, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tambah Data Koleksi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_zeamart
            // 
            this.panel_zeamart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_zeamart.Controls.Add(this.label2);
            this.panel_zeamart.Location = new System.Drawing.Point(13, 13);
            this.panel_zeamart.Name = "panel_zeamart";
            this.panel_zeamart.Size = new System.Drawing.Size(743, 31);
            this.panel_zeamart.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(293, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toko Hijab Zeamart";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(13, 80);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(74, 15);
            this.label_nama.TabIndex = 4;
            this.label_nama.Text = "Nama hijab :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 5;
            // 
            // label_jenis
            // 
            this.label_jenis.AutoSize = true;
            this.label_jenis.Location = new System.Drawing.Point(13, 109);
            this.label_jenis.Name = "label_jenis";
            this.label_jenis.Size = new System.Drawing.Size(74, 15);
            this.label_jenis.TabIndex = 6;
            this.label_jenis.Text = "Jenis bahan :";
            // 
            // label_stok
            // 
            this.label_stok.AutoSize = true;
            this.label_stok.Location = new System.Drawing.Point(13, 137);
            this.label_stok.Name = "label_stok";
            this.label_stok.Size = new System.Drawing.Size(36, 15);
            this.label_stok.TabIndex = 7;
            this.label_stok.Text = "Stok :";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(93, 77);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(167, 23);
            this.tb_nama.TabIndex = 8;
            // 
            // tb_jenis
            // 
            this.tb_jenis.Location = new System.Drawing.Point(93, 106);
            this.tb_jenis.Name = "tb_jenis";
            this.tb_jenis.Size = new System.Drawing.Size(167, 23);
            this.tb_jenis.TabIndex = 9;
            // 
            // tb_stok
            // 
            this.tb_stok.Location = new System.Drawing.Point(93, 135);
            this.tb_stok.Name = "tb_stok";
            this.tb_stok.Size = new System.Drawing.Size(167, 23);
            this.tb_stok.TabIndex = 10;
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.Location = new System.Drawing.Point(13, 165);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(45, 15);
            this.label_harga.TabIndex = 11;
            this.label_harga.Text = "Harga :";
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(93, 164);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(167, 23);
            this.tb_harga.TabIndex = 12;
            this.tb_harga.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 13;
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_tambah.Location = new System.Drawing.Point(93, 198);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(108, 26);
            this.btn_tambah.TabIndex = 15;
            this.btn_tambah.Text = "Tambah Koleksi";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 17;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_edit.Location = new System.Drawing.Point(551, 227);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Edit Koleksi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nama hijab :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Jenis bahan :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Stok :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Harga :";
            // 
            // tb_nama_edit
            // 
            this.tb_nama_edit.Location = new System.Drawing.Point(437, 111);
            this.tb_nama_edit.Name = "tb_nama_edit";
            this.tb_nama_edit.Size = new System.Drawing.Size(189, 23);
            this.tb_nama_edit.TabIndex = 31;
            // 
            // tb_jenis_edit
            // 
            this.tb_jenis_edit.Location = new System.Drawing.Point(437, 140);
            this.tb_jenis_edit.Name = "tb_jenis_edit";
            this.tb_jenis_edit.Size = new System.Drawing.Size(189, 23);
            this.tb_jenis_edit.TabIndex = 32;
            // 
            // tb_stok_edit
            // 
            this.tb_stok_edit.Location = new System.Drawing.Point(437, 169);
            this.tb_stok_edit.Name = "tb_stok_edit";
            this.tb_stok_edit.Size = new System.Drawing.Size(189, 23);
            this.tb_stok_edit.TabIndex = 33;
            this.tb_stok_edit.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_harga_edit
            // 
            this.tb_harga_edit.Location = new System.Drawing.Point(437, 198);
            this.tb_harga_edit.Name = "tb_harga_edit";
            this.tb_harga_edit.Size = new System.Drawing.Size(189, 23);
            this.tb_harga_edit.TabIndex = 34;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(92, 256);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(351, 23);
            this.tb_search.TabIndex = 35;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "Cari koleksi :";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(437, 82);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(189, 23);
            this.tb_id.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(357, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "Id :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.tb_harga_edit);
            this.Controls.Add(this.tb_stok_edit);
            this.Controls.Add(this.tb_jenis_edit);
            this.Controls.Add(this.tb_nama_edit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.label_harga);
            this.Controls.Add(this.tb_stok);
            this.Controls.Add(this.tb_jenis);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label_stok);
            this.Controls.Add(this.label_jenis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.panel_zeamart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_zeamart.ResumeLayout(false);
            this.panel_zeamart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_zeamart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_jenis;
        private System.Windows.Forms.Label label_stok;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_jenis;
        private System.Windows.Forms.TextBox tb_stok;
        private System.Windows.Forms.Label label_harga;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_koleksi;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_nama_edit;
        private System.Windows.Forms.TextBox tb_jenis_edit;
        private System.Windows.Forms.TextBox tb_stok_edit;
        private System.Windows.Forms.TextBox tb_harga_edit;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label12;
    }
}

