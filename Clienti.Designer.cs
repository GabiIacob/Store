namespace Pr2_Magazin
{
    partial class Clienti
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
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUsernameDelete = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxPasswordNew = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbxUsernameNew = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUsernameOld = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(89, 66);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 0;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(169, 129);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(75, 23);
            this.btnActualizare.TabIndex = 1;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnStergere);
            this.groupBox1.Controls.Add(this.tbxUsernameDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 198);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete user. Enter username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            this.label2.UseWaitCursor = true;
            // 
            // tbxUsernameDelete
            // 
            this.tbxUsernameDelete.Location = new System.Drawing.Point(80, 40);
            this.tbxUsernameDelete.Name = "tbxUsernameDelete";
            this.tbxUsernameDelete.Size = new System.Drawing.Size(100, 20);
            this.tbxUsernameDelete.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxPasswordNew);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnActualizare);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.tbxUsernameNew);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxUsernameOld);
            this.groupBox2.Location = new System.Drawing.Point(389, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 198);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update user. Enter old username , new username and password too.";
            // 
            // tbxPasswordNew
            // 
            this.tbxPasswordNew.AutoSize = true;
            this.tbxPasswordNew.Location = new System.Drawing.Point(111, 87);
            this.tbxPasswordNew.Name = "tbxPasswordNew";
            this.tbxPasswordNew.Size = new System.Drawing.Size(82, 13);
            this.tbxPasswordNew.TabIndex = 10;
            this.tbxPasswordNew.Text = "Password(new):";
            this.tbxPasswordNew.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Username(new):";
            this.label6.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // tbxUsernameNew
            // 
            this.tbxUsernameNew.Location = new System.Drawing.Point(293, 37);
            this.tbxUsernameNew.Name = "tbxUsernameNew";
            this.tbxUsernameNew.Size = new System.Drawing.Size(100, 20);
            this.tbxUsernameNew.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username(old):";
            this.label4.UseWaitCursor = true;
            // 
            // tbxUsernameOld
            // 
            this.tbxUsernameOld.Location = new System.Drawing.Point(101, 37);
            this.tbxUsernameOld.Name = "tbxUsernameOld";
            this.tbxUsernameOld.Size = new System.Drawing.Size(100, 20);
            this.tbxUsernameOld.TabIndex = 3;
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Clienti";
            this.Text = "Clienti";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUsernameDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxUsernameOld;
        public System.Windows.Forms.Label tbxPasswordNew;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbxUsernameNew;
    }
}