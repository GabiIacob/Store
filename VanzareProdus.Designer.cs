namespace Pr2_Magazin
{
    partial class VanzareProdus
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
            this.btnVanzare = new System.Windows.Forms.Button();
            this.cbxProduse = new System.Windows.Forms.ComboBox();
            this.lblProduse = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.tbxCantitate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVanzare
            // 
            this.btnVanzare.Location = new System.Drawing.Point(444, 68);
            this.btnVanzare.Name = "btnVanzare";
            this.btnVanzare.Size = new System.Drawing.Size(136, 89);
            this.btnVanzare.TabIndex = 28;
            this.btnVanzare.Text = "Trading";
            this.btnVanzare.UseVisualStyleBackColor = true;
            this.btnVanzare.Click += new System.EventHandler(this.btnVanzare_Click);
            // 
            // cbxProduse
            // 
            this.cbxProduse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxProduse.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxProduse.FormattingEnabled = true;
            this.cbxProduse.Location = new System.Drawing.Point(198, 93);
            this.cbxProduse.Name = "cbxProduse";
            this.cbxProduse.Size = new System.Drawing.Size(204, 21);
            this.cbxProduse.TabIndex = 29;
            this.cbxProduse.SelectedIndexChanged += new System.EventHandler(this.cbxProduse_SelectedIndexChanged);
            // 
            // lblProduse
            // 
            this.lblProduse.AutoSize = true;
            this.lblProduse.Location = new System.Drawing.Point(106, 93);
            this.lblProduse.Name = "lblProduse";
            this.lblProduse.Size = new System.Drawing.Size(46, 13);
            this.lblProduse.TabIndex = 30;
            this.lblProduse.Text = "Produse";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(106, 144);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(74, 13);
            this.lblCantitate.TabIndex = 31;
            this.lblCantitate.Text = "Cantitate(max)";
            // 
            // tbxCantitate
            // 
            this.tbxCantitate.Location = new System.Drawing.Point(198, 141);
            this.tbxCantitate.Name = "tbxCantitate";
            this.tbxCantitate.Size = new System.Drawing.Size(147, 20);
            this.tbxCantitate.TabIndex = 32;
            // 
            // VanzareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVanzare);
            this.Controls.Add(this.tbxCantitate);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblProduse);
            this.Controls.Add(this.cbxProduse);
            this.Name = "VanzareProdus";
            this.Text = "VanzareProdus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVanzare;
        private System.Windows.Forms.ComboBox cbxProduse;
        private System.Windows.Forms.Label lblProduse;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox tbxCantitate;
    }
}