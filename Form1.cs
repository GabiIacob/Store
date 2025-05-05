using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pr2_Magazin
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        

       
    
        
        private async void vanzareProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProduse.SelectedCells.Count > 0)
            {
                int rowIndex = dgvProduse.SelectedCells[0].RowIndex;
                var produsSelectat = dgvProduse.Rows[rowIndex].Cells["Denumire"].Value.ToString();

                using (ProdusDbContext dbc = new ProdusDbContext())
                {
                    var produs = await Task.Run(() =>
                        dbc.Produse.FirstOrDefault(p => p.Denumire.Equals(produsSelectat, StringComparison.OrdinalIgnoreCase))
                    );

                    if (produs != null)
                    {
                        VanzareProdus vanzareProdusForm = new VanzareProdus(produs.Denumire);
                        vanzareProdusForm.ShowDialog();
                    }
                    else


                    {
                        MessageBox.Show("Produsul nu a fost gasit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {


                MessageBox.Show("Selectati un produs din lista", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void istoricVanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = Users.CurrentUsername;  

            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                if (username.ToLower() == "gabi")
                {
                    var res = await Task.Run(() =>
                        from iv in dbc.IstoricVanzari
                        join p in dbc.Produse on iv.IdProdus equals p.ID
                        join c in dbc.CategoriiProduse on p.idCategorie equals c.Id
                        select new
                        {
                            iv.Id,
                            iv.IdProdus,
                            iv.Cantitate,
                            Categorie = c.Denumire
                        }
                    );

                    dgvProduse.DataSource = res.ToList();
                }
                else
                {
                    var res = await Task.Run(() =>
                        from u in dbc.users
                        where u.Username == Users.CurrentUsername && u.Cantitate>0
                        select new
                        {
                            u.Produs,
                            u.Cantitate
                        }
                    );

                    dgvProduse.DataSource = res.ToList();
                }
            }
        }


        private async void vizualizareCategoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                var res = await Task.Run(() =>
                    from p in dbc.CategoriiProduse
                    select new
                    {


                        p.Id,
                        p.Denumire
                    }
                );

                dgvProduse.DataSource = res.ToList();
            }
        }

        private async void vizualizareProduseToolStripMenuItem_Click(object sender, EventArgs e)
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
                        p.Cantitate,
                        p.idCategorie
                    }
                );

                dgvProduse.DataSource = res.ToList();
            }
        }

        private async void refreshButton_Click(object sender, EventArgs e)
        {
            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                await Task.Run(() =>
                {
                    var produseDeSters = dbc.Produse.Where(p => p.Cantitate == 0).ToList();
                    if (produseDeSters.Any())
                    {
                        dbc.Produse.RemoveRange(produseDeSters);
                        dbc.SaveChanges();
                    }
                });

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
                        p.Cantitate,
                        p.idCategorie
                    }
                );

                dgvProduse.DataSource = res.ToList();
            }
        }



        private void produsNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void produsExistentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExistingProduct ap = new AddExistingProduct();
            ap.ShowDialog();

        }
        private void adaugareProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private async void actualizeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = toolStripTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Introduceti un nume de produs sau un id .", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var dbc = new ProdusDbContext())
            {
                var result = await Task.Run(() =>
                {
                    if (int.TryParse(text, out int idCategorie))
                    {
                        return dbc.Produse
                                  .Where(p => p.idCategorie == idCategorie)
                                  .Select(p => new
                                  {
                                      p.ID,
                                      p.Denumire,
                                      p.Descriere,
                                      p.DataIntrare,
                                      p.DataExpirare,
                                      p.Cantitate,
                                      p.idCategorie
                                  }).ToList();
                    }
                    else
                    {
                        return dbc.Produse
                                  .Where(p => p.Denumire.Contains(text))
                                  .Select(p => new
                                  {
                                      p.ID,
                                      p.Denumire,
                                      p.Descriere,
                                      p.DataIntrare,
                                      p.DataExpirare,
                                      p.Cantitate,
                                      p.idCategorie
                                  })
                                  .ToList();
                    }
                });

                dgvProduse.DataSource = result;
            }
        }



        private async void adaugaCategoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string denumireCategorie = toolStripTextBox2.Text.Trim();
            if (string.IsNullOrWhiteSpace(denumireCategorie))
            {
                MessageBox.Show("Denumirea categoriei nu poate fi goala.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (ProdusDbContext dbc = new ProdusDbContext())
            {
                var categorieNoua = new CategorieProdus
                {
                    Denumire = denumireCategorie
                };

                await Task.Run(() =>
                {
                    dbc.CategoriiProduse.Add(categorieNoua);
                    dbc.SaveChanges();
                });

                MessageBox.Show("Categoria a fost adaugata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {

        }

        

        private void actualizareClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clienti form = new Clienti();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugareProdusToolStripMenuItem.Text = "Add Product";
            vanzareProdusToolStripMenuItem.Text = "Sell Product";
            istoricVanzariToolStripMenuItem.Text = "Sales History";
            vizualizareProduseToolStripMenuItem.Text = "View Products";
            vizualizareCategoriiToolStripMenuItem.Text = "View Categories";
            cautareProduseToolStripMenuItem.Text = "Search Products";
            actualizareClientiToolStripMenuItem.Text = "Update Clients";
            languageToolStripMenuItem.Text = "Language";
            produsNouToolStripMenuItem.Text = "New Product";
            produsExistentToolStripMenuItem.Text = "Existing Product";
            actualizeazaToolStripMenuItem.Text = "Update";
        }

        private void romanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugareProdusToolStripMenuItem.Text = "Adaugare Produs";
            vanzareProdusToolStripMenuItem.Text = "Vanzare Produs";
            istoricVanzariToolStripMenuItem.Text = "Istoric Vanzari";
            vizualizareProduseToolStripMenuItem.Text = "Vizualizare Produse";
            vizualizareCategoriiToolStripMenuItem.Text = "Vizualizare Categorii";
            cautareProduseToolStripMenuItem.Text = "Cautare Produse";
            actualizareClientiToolStripMenuItem.Text = "Actualizare Clienti";
            languageToolStripMenuItem.Text = "Limba";
            produsNouToolStripMenuItem.Text = "Produs Nou";
            produsExistentToolStripMenuItem.Text = "Produs Existent";
            actualizeazaToolStripMenuItem.Text = "Actualizeaza";
           
            
        }

        private void germanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugareProdusToolStripMenuItem.Text = "Produkt hinzufügen";
            vanzareProdusToolStripMenuItem.Text = "Produkt verkaufen";
            istoricVanzariToolStripMenuItem.Text = "Verkaufsverlauf";
            vizualizareProduseToolStripMenuItem.Text = "Produkte anzeigen";
            vizualizareCategoriiToolStripMenuItem.Text = "Kategorien anzeigen";
            cautareProduseToolStripMenuItem.Text = "Produkte suchen";
            actualizareClientiToolStripMenuItem.Text = "Kunden aktualisieren";
            languageToolStripMenuItem.Text = "Sprache";
            produsNouToolStripMenuItem.Text = "Neues Produkt";
            produsExistentToolStripMenuItem.Text = "Bestehendes Produkt";
            actualizeazaToolStripMenuItem.Text = "Aktualisieren";
            
            
        }




    }
}
