﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Responsi2Junpro
{
    public partial class FormHome : Form
    {
        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi2";
        private DataTable dt;
        private static NpgsqlCommand cmd;
        private static NpgsqlDataReader rd;
        private string sql = "";
        private DataGridViewRow r;

        private Karyawan newKaryawan;
        private string id_karyawan;
        private string nama_dep;

        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            this.conn = new NpgsqlConnection(connstring);
            newKaryawan = new Karyawan();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                this.conn.Open();
                dgvData.DataSource = null;
                sql = @"select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            newKaryawan.Nama = tbNama.Text;
            newKaryawan.ID_Dep = int.Parse(tbDep.Text);
            try
            {
                conn.Open();

                sql = @"select * from st_insert(:_nama,:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", newKaryawan.Nama);
                cmd.Parameters.AddWithValue("_id_dep", newKaryawan.ID_Dep);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Success", " Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    LoadData();
                    tbNama.Text = tbDep.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            newKaryawan.ID_Karyawan = id_karyawan;
            newKaryawan.Nama = tbNama.Text;
            newKaryawan.ID_Dep = int.Parse(tbDep.Text);
            newKaryawan.Nama_Dep = nama_dep;

            if (r == null)
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                conn.Open();
                sql = @"select * from st_update:(:_id_karyawan,:_nama,:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", newKaryawan.ID_Karyawan);
                cmd.Parameters.AddWithValue("_nama", newKaryawan.Nama);
                cmd.Parameters.AddWithValue("_id_dep", newKaryawan.ID_Dep);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Success", " Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    LoadData();
                    tbNama.Text = tbDep.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            newKaryawan.ID_Karyawan = id_karyawan;
            newKaryawan.Nama = tbNama.Text;
            newKaryawan.ID_Dep = int.Parse(tbDep.Text);
            newKaryawan.Nama_Dep = nama_dep;

            if (r == null)
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (MessageBox.Show("Apakah yakin ingin menghapus", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    sql = @"select * from st_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", newKaryawan.ID_Karyawan);
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Success", " Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        LoadData();
                        tbNama.Text = tbDep.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                id_karyawan = r.Cells["id_karyawan"].Value.ToString();
                tbNama.Text = r.Cells["_nama"].Value.ToString();
                tbDep.Text = r.Cells["_id_dep"].Value.ToString();
                nama_dep = r.Cells["_nama_dep"].Value.ToString();
            }
        }
    }
}
