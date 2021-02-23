﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luthor.lib;
using System.Windows.Forms;

namespace Laundry
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                if (Auth.Login(txtUsername.Text, txtPassword.Text, "tb_user"))
                {
                    Form Dashboard = new FormDashboard();
                    this.Hide();
                    Dashboard.Show();
                } 
                else
                {
                    MessageBox.Show("Username atau password salah", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                }
            }
            else if (txtUsername.Text.Length == 0 && txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Masukan username dan password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Masukan username", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Masukan password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}