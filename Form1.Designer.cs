namespace Pr2_Magazin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProduse = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugareProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsExistentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanzareProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricVanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareCategoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaCategoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.cautareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.actualizeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizareClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduse
            // 
            this.dgvProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduse.Location = new System.Drawing.Point(12, 27);
            this.dgvProduse.Name = "dgvProduse";
            this.dgvProduse.Size = new System.Drawing.Size(688, 293);
            this.dgvProduse.TabIndex = 1;
            this.dgvProduse.DoubleClick += new System.EventHandler(this.vanzareProdusToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProdusToolStripMenuItem,
            this.vanzareProdusToolStripMenuItem,
            this.istoricVanzariToolStripMenuItem,
            this.vizualizareProduseToolStripMenuItem,
            this.vizualizareCategoriiToolStripMenuItem,
            this.cautareProduseToolStripMenuItem,
            this.actualizareClientiToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adaugareProdusToolStripMenuItem
            // 
            this.adaugareProdusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produsNouToolStripMenuItem,
            this.produsExistentToolStripMenuItem});
            this.adaugareProdusToolStripMenuItem.Name = "adaugareProdusToolStripMenuItem";
            this.adaugareProdusToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.adaugareProdusToolStripMenuItem.Text = "Adaugare Produs";
            this.adaugareProdusToolStripMenuItem.Click += new System.EventHandler(this.adaugareProdusToolStripMenuItem_Click);
            // 
            // produsNouToolStripMenuItem
            // 
            this.produsNouToolStripMenuItem.Name = "produsNouToolStripMenuItem";
            this.produsNouToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produsNouToolStripMenuItem.Text = "Produs Nou";
            this.produsNouToolStripMenuItem.Click += new System.EventHandler(this.produsNouToolStripMenuItem_Click);
            // 
            // produsExistentToolStripMenuItem
            // 
            this.produsExistentToolStripMenuItem.Name = "produsExistentToolStripMenuItem";
            this.produsExistentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produsExistentToolStripMenuItem.Text = "Produs Existent";
            this.produsExistentToolStripMenuItem.Click += new System.EventHandler(this.produsExistentToolStripMenuItem_Click);
            // 
            // vanzareProdusToolStripMenuItem
            // 
            this.vanzareProdusToolStripMenuItem.Name = "vanzareProdusToolStripMenuItem";
            this.vanzareProdusToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.vanzareProdusToolStripMenuItem.Text = "Produse Disponibile";
            this.vanzareProdusToolStripMenuItem.Click += new System.EventHandler(this.vanzareProdusToolStripMenuItem_Click);
            // 
            // istoricVanzariToolStripMenuItem
            // 
            this.istoricVanzariToolStripMenuItem.Name = "istoricVanzariToolStripMenuItem";
            this.istoricVanzariToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.istoricVanzariToolStripMenuItem.Text = "Istoric Vanzari";
            this.istoricVanzariToolStripMenuItem.Click += new System.EventHandler(this.istoricVanzariToolStripMenuItem_Click);
            // 
            // vizualizareProduseToolStripMenuItem
            // 
            this.vizualizareProduseToolStripMenuItem.Name = "vizualizareProduseToolStripMenuItem";
            this.vizualizareProduseToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.vizualizareProduseToolStripMenuItem.Text = "Vizualizare Produse";
            this.vizualizareProduseToolStripMenuItem.Click += new System.EventHandler(this.vizualizareProduseToolStripMenuItem_Click);
            // 
            // vizualizareCategoriiToolStripMenuItem
            // 
            this.vizualizareCategoriiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaCategoriiToolStripMenuItem});
            this.vizualizareCategoriiToolStripMenuItem.Name = "vizualizareCategoriiToolStripMenuItem";
            this.vizualizareCategoriiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.vizualizareCategoriiToolStripMenuItem.Text = "Categorii";
            this.vizualizareCategoriiToolStripMenuItem.Click += new System.EventHandler(this.vizualizareCategoriiToolStripMenuItem_Click);
            // 
            // adaugaCategoriiToolStripMenuItem
            // 
            this.adaugaCategoriiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.toolStripTextBox3});
            this.adaugaCategoriiToolStripMenuItem.Name = "adaugaCategoriiToolStripMenuItem";
            this.adaugaCategoriiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaCategoriiToolStripMenuItem.Text = "Adauga Categorii";
            this.adaugaCategoriiToolStripMenuItem.Click += new System.EventHandler(this.adaugaCategoriiToolStripMenuItem_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "Enter name above";
            // 
            // cautareProduseToolStripMenuItem
            // 
            this.cautareProduseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.actualizeazaToolStripMenuItem});
            this.cautareProduseToolStripMenuItem.Name = "cautareProduseToolStripMenuItem";
            this.cautareProduseToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.cautareProduseToolStripMenuItem.Text = "Cautare produse";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Enter name/ID";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // actualizeazaToolStripMenuItem
            // 
            this.actualizeazaToolStripMenuItem.Name = "actualizeazaToolStripMenuItem";
            this.actualizeazaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizeazaToolStripMenuItem.Text = "Actualizeaza";
            this.actualizeazaToolStripMenuItem.Click += new System.EventHandler(this.actualizeazaToolStripMenuItem_Click);
            // 
            // actualizareClientiToolStripMenuItem
            // 
            this.actualizareClientiToolStripMenuItem.Name = "actualizareClientiToolStripMenuItem";
            this.actualizareClientiToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.actualizareClientiToolStripMenuItem.Text = "Actualizare Clienti";
            this.actualizareClientiToolStripMenuItem.Click += new System.EventHandler(this.actualizareClientiToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romanaToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.germanyToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // romanaToolStripMenuItem
            // 
            this.romanaToolStripMenuItem.Name = "romanaToolStripMenuItem";
            this.romanaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.romanaToolStripMenuItem.Text = "Romana";
            this.romanaToolStripMenuItem.Click += new System.EventHandler(this.romanaToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // germanyToolStripMenuItem
            // 
            this.germanyToolStripMenuItem.Name = "germanyToolStripMenuItem";
            this.germanyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.germanyToolStripMenuItem.Text = "Deutsch";
            this.germanyToolStripMenuItem.Click += new System.EventHandler(this.germanyToolStripMenuItem_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(824, 27);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 38);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dgvProduse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProduse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem adaugareProdusToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem vanzareProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricVanzariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareCategoriiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareProduseToolStripMenuItem;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolStripMenuItem produsNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsExistentToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem actualizeazaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adaugaCategoriiToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        public System.Windows.Forms.ToolStripMenuItem actualizareClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanyToolStripMenuItem;
    }
}

