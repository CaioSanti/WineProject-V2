using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MainProject
{
    public partial class frmDashboard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthRect,
            int nHeightEllipse
        );
        public frmDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnConsulta.Height;
            pnlNav.Top = btnConsulta.Top;
            pnlNav.Left = btnConsulta.Left;
            btnConsulta.BackColor = Color.FromArgb(94, 65, 150);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Favor, verificar se todos os campos foram preenchidos", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Produto Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnConsulta.Height;
            pnlNav.Top = btnConsulta.Top;
            pnlNav.Left = btnConsulta.Left;
            btnConsulta.BackColor = Color.FromArgb(94, 65, 150);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCadastro.Height;
            pnlNav.Top = btnCadastro.Top;
            btnCadastro.BackColor = Color.FromArgb(94, 65, 150);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFinanceiro.Height;
            pnlNav.Top = btnFinanceiro.Top;
            btnFinanceiro.BackColor = Color.FromArgb(94, 65, 150);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnConfig.Height;
            pnlNav.Top = btnConfig.Top;
            btnConfig.BackColor = Color.FromArgb(94, 65, 150);
        }

        private void btnConsulta_Leave(object sender, EventArgs e)
        {
            btnConsulta.BackColor = Color.FromArgb(116, 86, 174);
        }

        private void btnCadastro_Leave(object sender, EventArgs e)
        {
            btnCadastro.BackColor = Color.FromArgb(116, 86, 174);
        }

        private void btnFinanceiro_Leave(object sender, EventArgs e)
        {
            btnFinanceiro.BackColor = Color.FromArgb(116, 86, 174);
        }

        private void btnConfig_Leave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(116, 86, 174);
        }
    }
}
