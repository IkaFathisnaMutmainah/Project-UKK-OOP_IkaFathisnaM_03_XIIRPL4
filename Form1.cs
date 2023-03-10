using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace zeamart_tokohijab
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = connection.getConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        public DataTable getDatahijab()
        {
            //membaca datatable 
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM daftar_hijab", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public void filldataTable()
        {
            dataGridView1.DataSource = getDatahijab();

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            dataGridView1.Columns.Add(colEdit);

            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Text = "Delete";
            colDelete.Name = "";
            dataGridView1.Columns.Add(colDelete);
        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id := 0; UPDATE daftar_hijab SET id = @id := (@id+1); " +
                    "ALTER TABLE daftar_hijab AUTO_INCREMENT = 1;");
            script.Execute();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btn_tambah_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            //conn.open();
            try
            {

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO daftar_hijab(namahijab, jenisbahan, stok, harga) VALUE(@namahijab, @jenisbahan, @stok, @harga)";
                cmd.Parameters.AddWithValue("@namahijab", tb_nama.Text);
                cmd.Parameters.AddWithValue("@jenisbahan", tb_jenis.Text);
                cmd.Parameters.AddWithValue("@stok", tb_stok.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);
                
                cmd.ExecuteNonQuery();
                // long id = cmd.LastInsertId;
                koneksi.Close();

                dataGridView1.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {

            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

                tb_id.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
                tb_nama_edit.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
                tb_jenis_edit.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
                tb_stok_edit.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
                tb_harga_edit.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();

                tb_nama_edit.Enabled = true;
                tb_jenis_edit.Enabled = true;
                tb_stok_edit.Enabled = true;
                tb_harga_edit.Enabled = true;
                btn_edit.Enabled = true;
            }
            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;

                try
                {
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "DELETE FROM daftar_hijab WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[id].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus");
                    resetIncrement();
                    koneksi.Close();

                    dataGridView1.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();
                }

                catch (Exception ex)
                {

                }
            }
        }

        public void searchData (string ValueToFind)
        {
            string searchQuery = "SELECT * FROM daftar_hijab WHERE CONCAT(namahijab, jenisbahan, stok, harga) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {
            searchData(tb_search.Text);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            try
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "Update daftar_hijab SET namahijab = @namahijab, jenisbahan = @jenisbahan, stok = @stok, harga = @harga WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.Parameters.AddWithValue("@namahijab", tb_nama_edit.Text);
                cmd.Parameters.AddWithValue("@jenisbahan", tb_jenis_edit.Text);
                cmd.Parameters.AddWithValue("@stok", tb_stok_edit.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga_edit.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah");

                koneksi.Close();
                dataGridView1.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }

            catch (Exception ex)
            {

            }
        }
    }
}