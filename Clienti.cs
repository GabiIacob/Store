using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2_Magazin
{
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();
        }

        private async void btnStergere_Click(object sender, EventArgs e)
        {
            string username = tbxUsernameDelete.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Introduceti username.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                var users = dbc.users.Where(u => u.Username == username).ToList();

                if (users.Any())
                {
                    foreach (var user in users)
                    {
                        dbc.users.Remove(user);
                    }

                    await Task.Run(() => dbc.SaveChanges());
                    MessageBox.Show("Conturile au fost sterse cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Utilizatorul nu exista", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private async void btnActualizare_Click(object sender, EventArgs e)
        {
            string oldUsername = tbxUsernameOld.Text.Trim();
            string newUsername = tbxUsernameNew.Text.Trim();
            string newPassword = textBox1.Text;


            if (string.IsNullOrEmpty(oldUsername) || string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Campuri goale", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                var users = dbc.users.Where(u => u.Username == oldUsername).ToList();
                if (users.Any())
                {
                    foreach (var user in users)
                    {
                        user.Username = newUsername;
                        string parolacuhash = hash(newPassword);
                        user.Password = parolacuhash;

                        Console.WriteLine($"Hash: {parolacuhash}");
                    }

                    await Task.Run(() => dbc.SaveChanges());
                    MessageBox.Show("Cont actualizat.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Utilizator neexistent", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
