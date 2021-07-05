using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MainProject
{
    public partial class frmLogin : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-IHT48T9;Initial Catalog=LoginCharp;Integrated Security=True");
        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Select();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                frmDashboard dashboard = new frmDashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Favor, verificar informações de usuário e senha", "Usuário ou Senha Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*Connection.Open();
            string query = "SELECT * FROM TableLogin WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Connection);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                frmDashboard dashboard = new frmDashboard();
                this.Hide();
                dashboard.Show();
            }
            else 
            {
                MessageBox.Show("Usuário ou senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void checkboxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
