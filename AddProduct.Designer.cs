namespace Pr2_Magazin
{
    partial class AddProduct
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
            this.lblDenumire = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.lblDataIntrare = new System.Windows.Forms.Label();
            this.dtpDataIntrare = new System.Windows.Forms.DateTimePicker();
            this.dtpDataIesire = new System.Windows.Forms.DateTimePicker();
            this.lblDataIesire = new System.Windows.Forms.Label();
            this.dtpDataExpirare = new System.Windows.Forms.DateTimePicker();
            this.lblDataExpirare = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.nudCantitate = new System.Windows.Forms.NumericUpDown();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lblidCategorie = new System.Windows.Forms.Label();
            this.nudidCategorie = new System.Windows.Forms.NumericUpDown();
            this.dgvCategorii = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudidCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorii)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(90, 37);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(52, 13);
            this.lblDenumire.TabIndex = 0;
            this.lblDenumire.Text = "Denumire";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(232, 37);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 20);
            this.txtDenumire.TabIndex = 1;
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(232, 83);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(373, 52);
            this.txtDescriere.TabIndex = 3;
            this.txtDescriere.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Location = new System.Drawing.Point(90, 83);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(52, 13);
            this.lblDescriere.TabIndex = 2;
            this.lblDescriere.Text = "Descriere";
            this.lblDescriere.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDataIntrare
            // 
            this.lblDataIntrare.AutoSize = true;
            this.lblDataIntrare.Location = new System.Drawing.Point(93, 171);
            this.lblDataIntrare.Name = "lblDataIntrare";
            this.lblDataIntrare.Size = new System.Drawing.Size(60, 13);
            this.lblDataIntrare.TabIndex = 4;
            this.lblDataIntrare.Text = "DataIntrare";
            // 
            // dtpDataIntrare
            // 
            this.dtpDataIntrare.Location = new System.Drawing.Point(232, 165);
            this.dtpDataIntrare.Name = "dtpDataIntrare";
            this.dtpDataIntrare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataIntrare.TabIndex = 6;
            // 
            // dtpDataIesire
            // 
            this.dtpDataIesire.Location = new System.Drawing.Point(232, 209);
            this.dtpDataIesire.Name = "dtpDataIesire";
            this.dtpDataIesire.Size = new System.Drawing.Size(200, 20);
            this.dtpDataIesire.TabIndex = 8;
            // 
            // lblDataIesire
            // 
            this.lblDataIesire.AutoSize = true;
            this.lblDataIesire.Location = new System.Drawing.Point(93, 215);
            this.lblDataIesire.Name = "lblDataIesire";
            this.lblDataIesire.Size = new System.Drawing.Size(55, 13);
            this.lblDataIesire.TabIndex = 7;
            this.lblDataIesire.Text = "DataIesire";
            this.lblDataIesire.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dtpDataExpirare
            // 
            this.dtpDataExpirare.Location = new System.Drawing.Point(232, 255);
            this.dtpDataExpirare.Name = "dtpDataExpirare";
            this.dtpDataExpirare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataExpirare.TabIndex = 10;
            // 
            // lblDataExpirare
            // 
            this.lblDataExpirare.AutoSize = true;
            this.lblDataExpirare.Location = new System.Drawing.Point(93, 261);
            this.lblDataExpirare.Name = "lblDataExpirare";
            this.lblDataExpirare.Size = new System.Drawing.Size(68, 13);
            this.lblDataExpirare.TabIndex = 9;
            this.lblDataExpirare.Text = "DataExpirare";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(96, 310);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(49, 13);
            this.lblCantitate.TabIndex = 11;
            this.lblCantitate.Text = "Cantitate";
            // 
            // nudCantitate
            // 
            this.nudCantitate.Location = new System.Drawing.Point(232, 302);
            this.nudCantitate.Name = "nudCantitate";
            this.nudCantitate.Size = new System.Drawing.Size(200, 20);
            this.nudCantitate.TabIndex = 12;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(680, 83);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 13;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lblidCategorie
            // 
            this.lblidCategorie.AutoSize = true;
            this.lblidCategorie.Location = new System.Drawing.Point(96, 362);
            this.lblidCategorie.Name = "lblidCategorie";
            this.lblidCategorie.Size = new System.Drawing.Size(60, 13);
            this.lblidCategorie.TabIndex = 14;
            this.lblidCategorie.Text = "idCategorie";
            this.lblidCategorie.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // nudidCategorie
            // 
            this.nudidCategorie.Location = new System.Drawing.Point(232, 355);
            this.nudidCategorie.Name = "nudidCategorie";
            this.nudidCategorie.Size = new System.Drawing.Size(200, 20);
            this.nudidCategorie.TabIndex = 15;
            // 
            // dgvCategorii
            // 
            this.dgvCategorii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorii.Location = new System.Drawing.Point(548, 190);
            this.dgvCategorii.Name = "dgvCategorii";
            this.dgvCategorii.Size = new System.Drawing.Size(240, 150);
            this.dgvCategorii.TabIndex = 16;
            this.dgvCategorii.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorii_CellContentClick);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCategorii);
            this.Controls.Add(this.nudidCategorie);
            this.Controls.Add(this.lblidCategorie);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.nudCantitate);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.dtpDataExpirare);
            this.Controls.Add(this.lblDataExpirare);
            this.Controls.Add(this.dtpDataIesire);
            this.Controls.Add(this.lblDataIesire);
            this.Controls.Add(this.dtpDataIntrare);
            this.Controls.Add(this.lblDataIntrare);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.lblDenumire);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudidCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.Label lblDataIntrare;
        private System.Windows.Forms.DateTimePicker dtpDataIntrare;
        private System.Windows.Forms.DateTimePicker dtpDataIesire;
        private System.Windows.Forms.Label lblDataIesire;
        private System.Windows.Forms.DateTimePicker dtpDataExpirare;
        private System.Windows.Forms.Label lblDataExpirare;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.NumericUpDown nudCantitate;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label lblidCategorie;
        private System.Windows.Forms.NumericUpDown nudidCategorie;
        private System.Windows.Forms.DataGridView dgvCategorii;
    }
}