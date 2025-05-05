namespace Pr2_Magazin
{
    partial class AddExistingProduct
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
            this.dgvExistingProducts = new System.Windows.Forms.DataGridView();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExistingProducts
            // 
            this.dgvExistingProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistingProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvExistingProducts.Name = "dgvExistingProducts";
            this.dgvExistingProducts.Size = new System.Drawing.Size(534, 303);
            this.dgvExistingProducts.TabIndex = 0;
            this.dgvExistingProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExistingProducts_CellContentClick);
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(712, 106);
            this.txtCantitate.Multiline = true;
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(52, 21);
            this.txtCantitate.TabIndex = 7;
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(624, 109);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(49, 13);
            this.lblCantitate.TabIndex = 6;
            this.lblCantitate.Text = "Cantitate";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(712, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 20);
            this.txtId.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(624, 61);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(49, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "IdProdus";
            this.lblId.Click += new System.EventHandler(this.lblDenumire_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(627, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adauga-Produs";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddExistingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvExistingProducts);
            this.Name = "AddExistingProduct";
            this.Text = "AddExistingProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExistingProducts;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAdd;
    }
}