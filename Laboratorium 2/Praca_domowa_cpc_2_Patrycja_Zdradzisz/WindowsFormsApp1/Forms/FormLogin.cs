using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataBase;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Repository _repository = new Repository();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            bool logged = _repository.Login(login, password);

            if (logged)
            {
                Program.Logged = true;
                Program.User = login;
                Close();
            }

            MessageBox.Show("Niepoprawny login lub hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
