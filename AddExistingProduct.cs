using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2_Magazin
{
    public partial class AddExistingProduct : Form
    {
        public AddExistingProduct()
        {
            InitializeComponent();
            populeazaaDGV();
        }

        private void lblDenumire_Click(object sender, EventArgs e)
        {

        }
        private async void populeazaaDGV()
        {
            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                var res = await Task.Run(() =>
                    from p in dbc.Produse
                    where p.Cantitate > 0
                    select new
                    {
                        p.ID,
                        p.Denumire,
                        p.Descriere,
                        p.DataIntrare,
                        p.DataExpirare,
                        p.DataIesire,
                        p.Cantitate
                        
                    }
                );

                dgvExistingProducts.DataSource = res.ToList();
            }
        }

        private void dgvExistingProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            int cantitateAdaugata = 0;



            int idProdus = 0;

            int.TryParse(txtCantitate.Text, out cantitateAdaugata);
            int.TryParse(txtId.Text, out idProdus);






            if (string.IsNullOrEmpty(txtCantitate.Text) )
            {
                MessageBox.Show("Introduceti o cantitate valida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }

            if (string.IsNullOrEmpty(txtId.Text) )
            {
                MessageBox.Show("Introduceti un ID valid al produsului!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                var produs = await Task.Run(() =>
                    dbc.Produse.FirstOrDefault(p => p.ID == idProdus)
                );

                if (produs != null)
                {
                    produs.Cantitate += cantitateAdaugata;

                    await Task.Run(() => dbc.SaveChanges());

                    MessageBox.Show("Cantitatea a fost actualizata cu succes. ", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populeazaaDGV();
                }
                else
                {
                    MessageBox.Show("Produsul cu acest ID nu a fost gasit în baza de date.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
