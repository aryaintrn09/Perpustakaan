using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Perpustakaan
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;database=PerpustakaanDB;user=root;password=;";

        public Form1()
        {
            InitializeComponent();
            SetPlaceholderText();
            InitializeDataGridView();
        }

        private void SetPlaceholderText()
        {
            txtJudul.Text = "Judul Buku";
            txtPenulis.Text = "Penulis";
            txtTahunTerbit.Text = "Tahun Terbit";
            txtTahunTerbit.ForeColor = System.Drawing.Color.Gray;
            txtJudul.ForeColor = System.Drawing.Color.Gray;
            txtPenulis.ForeColor = System.Drawing.Color.Gray;
        }

        private void InitializeDataGridView()
        {
            dataGridViewBuku.Columns.Add("Judul", "Judul Buku");
            dataGridViewBuku.Columns.Add("Penulis", "Nama Penulis");
            dataGridViewBuku.Columns.Add("TahunTerbit", "Tahun Terbit");
        }

        private void txtJudul_Enter(object sender, EventArgs e)
        {
            if (txtJudul.Text == "Judul Buku")
            {
                txtJudul.Text = "";
                txtJudul.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtJudul_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJudul.Text))
            {
                SetPlaceholderText();
            }
        }

        private void txtPenulis_Enter(object sender, EventArgs e)
        {
            if (txtPenulis.Text == "Penulis")
            {
                txtPenulis.Text = "";
                txtPenulis.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPenulis_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPenulis.Text))
            {
                SetPlaceholderText();
            }
        }

        private void txtTahunTerbit_Enter(object sender, EventArgs e)
        {
            if (txtTahunTerbit.Text == "Tahun Terbit")
            {
                txtTahunTerbit.Text = "";
                txtTahunTerbit.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTahunTerbit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTahunTerbit.Text))
            {
                SetPlaceholderText();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJudul.Text) ||
                string.IsNullOrWhiteSpace(txtPenulis.Text) ||
                string.IsNullOrWhiteSpace(txtTahunTerbit.Text) ||
                txtJudul.Text == "Judul Buku" ||
                txtPenulis.Text == "Penulis" ||
                txtTahunTerbit.Text == "Tahun Terbit")
            {
                MessageBox.Show("Semua kolom harus diisi.");
                return;
            }

            int tahunTerbit;
            if (!int.TryParse(txtTahunTerbit.Text, out tahunTerbit))
            {
                MessageBox.Show("Tahun terbit harus berupa angka yang valid.");
                return;
            }


            SaveBookToDatabase(txtJudul.Text, txtPenulis.Text, tahunTerbit);


            dataGridViewBuku.Rows.Add(txtJudul.Text, txtPenulis.Text, tahunTerbit);


            txtJudul.Clear();
            txtPenulis.Clear();
            txtTahunTerbit.Clear();
            SetPlaceholderText();
        }

        private void SaveBookToDatabase(string judul, string penulis, int tahunTerbit)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Buku (Judul, Penulis, TahunTerbit) VALUES (@Judul, @Penulis, @TahunTerbit)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Judul", judul);
                cmd.Parameters.AddWithValue("@Penulis", penulis);
                cmd.Parameters.AddWithValue("@TahunTerbit", tahunTerbit);
                cmd.ExecuteNonQuery();
            }
        }
    }
}