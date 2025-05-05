using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pr2_Magazin
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            AfiseazaCategorii();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private async void btnAdaugare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDenumire.Text))
            {
                MessageBox.Show("Denumirea nu poate fi goala ", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudCantitate.Value <= 0)
            {
                MessageBox.Show("Cantitatea trebuie sa fie mai mare decat 0", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudidCategorie.Value <= 0)
            {
                MessageBox.Show("Id-ul categoriei trebuie sa fie valid", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await AdaugaProdusAsync();
        }

        private async Task AdaugaProdusAsync()
        {
            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                Produs p = new Produs
                {
                    Denumire = txtDenumire.Text,
                    Descriere = txtDescriere.Text,
                    DataIntrare = dtpDataIntrare.Value.ToString(),
                    DataIesire = dtpDataIesire.Value.ToString(),
                    DataExpirare = dtpDataExpirare.Value.ToString(),
                    Cantitate = (int)nudCantitate.Value,
                    idCategorie = (int)nudidCategorie.Value
                };

                dbc.Produse.Add(p);
                await Task.Run(() => dbc.SaveChanges());

                this.Close();
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dgvCategorii_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void AfiseazaCategorii()
        {
            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                var res = await Task.Run(() =>
                    from p in dbc.CategoriiProduse
                    select new
                    {
                        p.Id,
                        p.Denumire
                    });

                dgvCategorii.DataSource = res.ToList();
            }
        }
    }
}
