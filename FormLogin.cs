using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Pr2_Magazin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private string hash(string linie)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] input = Encoding.UTF8.GetBytes(linie);

            byte[] hash = sha256.ComputeHash(input);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)

            {
                sb.Append(b.ToString("x2"));
            }

            string criptat = sb.ToString();

            return criptat;



        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Introdu username si parola.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                bool userExist = dbc.users.Where(u => u.Username == username).Any();
                if (userExist)
                {
                    MessageBox.Show("Utilizator existent, alege alt nume.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string parolacuhash = hash(password);

                var newUser = new Users
                {
                    Username = username,
                    Password = parolacuhash,
                    Produs = string.Empty,
                    Cantitate = 0
                };

                dbc.users.Add(newUser);
                dbc.SaveChanges();
                MessageBox.Show("Cont creat cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbxUsername.Clear();


                tbxPassword.Clear();
            }
        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Introdu username si parola.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Trace.WriteLine("Login failed: Username or password is empty.");
                return;
            }

            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                var user = dbc.users.FirstOrDefault(u => u.Username == username);
                if (user == null)
                {
                    MessageBox.Show("Utilizatorul nu exista.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Trace.WriteLine("Login failed: User not found. Username: " + username);
                    return;
                }

                Users.CurrentUsername = user.Username;
                string parolacuhash = hash(password);
                Console.WriteLine(parolacuhash);
                if (user.Password.Equals(parolacuhash))  
                {
                    Trace.WriteLine("Login successful: User logged in. Username: " + username);

                    if (user.Username == "gabi")
                    {
                        Form1 form = new Form1();
                        form.vanzareProdusToolStripMenuItem.Text = "Vanzare produs";
                        form.ShowDialog();

                    }


                    else
                    {
                        Form1 form2 = new Form1();
                        form2.adaugareProdusToolStripMenuItem.Visible = false;
                        form2.adaugaCategoriiToolStripMenuItem.Visible = false;
                        form2.actualizareClientiToolStripMenuItem.Visible = false;
                        form2.vanzareProdusToolStripMenuItem.Text = "Cumpara produs";
                        form2.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Parola incorecta.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Trace.WriteLine("Login failed: Incorrect password. Username: " + username);
                }
            }
        }

    }
}
