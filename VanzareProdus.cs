using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2_Magazin
{
    [Table("IstoricVanzari")]
    public partial class VanzareProdus : Form
    {
        private string produsSelectat;

        public VanzareProdus(string produs)
        {
            InitializeComponent();
            produsSelectat = produs;
            PopuleazaComboBoxProduse();
        }

        private async void PopuleazaComboBoxProduse()
        {

            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                var produse = await Task.Run(() =>
                    dbc.Produse.Select(p => p.Denumire).ToList()
                );

                cbxProduse.DataSource = produse;





                if (!string.IsNullOrEmpty(produsSelectat))
                {
                    if (produse.Contains(produsSelectat))
                    {
                        cbxProduse.SelectedItem = produsSelectat;
                    }
                    else
                    {
                        MessageBox.Show("Produs selectat nu se afla in lista!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    cbxProduse.SelectedIndex = 0;
                }
            }
        }

        private async void cbxProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProduse.SelectedItem != null)
            {


                string selectedProduct = cbxProduse.SelectedItem.ToString();

                using (ProdusDbContext dbc = new ProdusDbContext())
                {


                    var produs = await Task.Run(() =>
                        dbc.Produse.FirstOrDefault(p => p.Denumire == selectedProduct)
                    );

                    if (produs != null)
                    {
                        tbxCantitate.Text = produs.Cantitate.ToString();
                    }
                }

            }
        }

        private async void btnVanzare_Click(object sender, EventArgs e)
        {
            if (cbxProduse.SelectedItem == null)
            {
                MessageBox.Show("Selectati un produs din lista.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedProduct = cbxProduse.SelectedItem.ToString();
            int cantitateVanduta;

            if (!int.TryParse(tbxCantitate.Text, out cantitateVanduta) || cantitateVanduta <= 0)
            {
                MessageBox.Show("Introdu o cantitate valida", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                var produs = await Task.Run(() =>
                    dbc.Produse.FirstOrDefault(p => p.Denumire == selectedProduct)
                );

                if (produs != null)
                {
                    if (produs.Cantitate >= cantitateVanduta)
                    {
                        produs.Cantitate -= cantitateVanduta;
                        await Task.Run(() => dbc.SaveChanges());
                        MessageBox.Show("Tranzactie efectuata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopuleazaComboBoxProduse();

                        var istoricVanzare = new IstoricVanzari
                        {
                            IdProdus = produs.ID,
                            Cantitate = cantitateVanduta
                        };

                        dbc.IstoricVanzari.Add(istoricVanzare);
                        await Task.Run(() => dbc.SaveChanges());

                        string username = Users.CurrentUsername;

                        var user = dbc.users.FirstOrDefault(u => u.Username == username);

                        if (user != null)
                        {
                            if (user.Produs == selectedProduct)
                            {
                                user.Cantitate += cantitateVanduta;
                            }
                            else
                            {
                                
                                var newUserProduct = new Users
                                {
                                    Username = username,
                                    Produs = selectedProduct,
                                    Password="1",
                                    Cantitate = cantitateVanduta
                                };

                                dbc.users.Add(newUserProduct); 
                            }
                        }
                        

                        await Task.Run(() => dbc.SaveChanges());

                        if (produs.Cantitate == 0)
                        {
                            dbc.Produse.Remove(produs);
                            await Task.Run(() => dbc.SaveChanges());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Stoc insuficient", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Produsul selectat nu a fost gasit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
