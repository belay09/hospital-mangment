﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HospitalManagement
{
    public partial class AdminManage : Form
    {
        public AdminManage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = connectionCls.openConnection();
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Employe.EmployeID,Employe.FirstName,Employe.LastName,Employe.mobile,EmployeDetail.Aprove FROM Employe INNER JOIN EmployeDetail ON EmployeDetail.EmployeID = employe.EmployeID ", conn);
            try

            {

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                BindingSource bsource = new BindingSource();

                bsource.DataSource = dt;

                dataGridView1.DataSource = bsource;

            }
            catch (Exception ec)

            {

                MessageBox.Show(ec.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = connectionCls.openConnection();

            conn.Open();
            SqlCommand cmd = new SqlCommand("exec AproveAccaunt @aprove=@apr,@ID=@id;", conn);
            cmd.Parameters.AddWithValue("apr", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("id", textBox2.Text);
            cmd.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
