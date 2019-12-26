namespace WindowsFormsApp1
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
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnPreziceMedie = new System.Windows.Forms.Button();
            this.btnMediePeste8 = new System.Windows.Forms.Button();
            this.btnZiBuna = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtMedie = new System.Windows.Forms.TextBox();
            this.txtMatricol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblMedie = new System.Windows.Forms.Label();
            this.lblMedie8 = new System.Windows.Forms.Label();
            this.lblZiBuna = new System.Windows.Forms.Label();
            this.btnStergere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(200, 302);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(123, 23);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "Adauga student";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnPreziceMedie
            // 
            this.btnPreziceMedie.Location = new System.Drawing.Point(600, 355);
            this.btnPreziceMedie.Name = "btnPreziceMedie";
            this.btnPreziceMedie.Size = new System.Drawing.Size(123, 23);
            this.btnPreziceMedie.TabIndex = 1;
            this.btnPreziceMedie.Text = "Prezice Media";
            this.btnPreziceMedie.UseVisualStyleBackColor = true;
            this.btnPreziceMedie.Click += new System.EventHandler(this.btnPreziceMedie_Click);
            // 
            // btnMediePeste8
            // 
            this.btnMediePeste8.Location = new System.Drawing.Point(600, 385);
            this.btnMediePeste8.Name = "btnMediePeste8";
            this.btnMediePeste8.Size = new System.Drawing.Size(162, 23);
            this.btnMediePeste8.TabIndex = 2;
            this.btnMediePeste8.Text = "Prezice medie peste 8";
            this.btnMediePeste8.UseVisualStyleBackColor = true;
            this.btnMediePeste8.Click += new System.EventHandler(this.btnMediePeste8_Click);
            // 
            // btnZiBuna
            // 
            this.btnZiBuna.Location = new System.Drawing.Point(600, 415);
            this.btnZiBuna.Name = "btnZiBuna";
            this.btnZiBuna.Size = new System.Drawing.Size(123, 23);
            this.btnZiBuna.TabIndex = 3;
            this.btnZiBuna.Text = "Prezice zi buna";
            this.btnZiBuna.UseVisualStyleBackColor = true;
            this.btnZiBuna.Click += new System.EventHandler(this.btnZiBuna_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(13, 42);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 4;
            // 
            // txtMedie
            // 
            this.txtMedie.Location = new System.Drawing.Point(12, 68);
            this.txtMedie.Name = "txtMedie";
            this.txtMedie.Size = new System.Drawing.Size(100, 22);
            this.txtMedie.TabIndex = 5;
            // 
            // txtMatricol
            // 
            this.txtMatricol.Location = new System.Drawing.Point(12, 14);
            this.txtMatricol.Name = "txtMatricol";
            this.txtMatricol.Size = new System.Drawing.Size(100, 22);
            this.txtMatricol.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Medie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "NrMatricol";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(200, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(562, 260);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblMedie
            // 
            this.lblMedie.AutoSize = true;
            this.lblMedie.Location = new System.Drawing.Point(265, 361);
            this.lblMedie.Name = "lblMedie";
            this.lblMedie.Size = new System.Drawing.Size(0, 17);
            this.lblMedie.TabIndex = 11;
            // 
            // lblMedie8
            // 
            this.lblMedie8.AutoSize = true;
            this.lblMedie8.Location = new System.Drawing.Point(265, 391);
            this.lblMedie8.Name = "lblMedie8";
            this.lblMedie8.Size = new System.Drawing.Size(0, 17);
            this.lblMedie8.TabIndex = 12;
            // 
            // lblZiBuna
            // 
            this.lblZiBuna.AutoSize = true;
            this.lblZiBuna.Location = new System.Drawing.Point(265, 418);
            this.lblZiBuna.Name = "lblZiBuna";
            this.lblZiBuna.Size = new System.Drawing.Size(0, 17);
            this.lblZiBuna.TabIndex = 13;
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(345, 301);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(122, 23);
            this.btnStergere.TabIndex = 14;
            this.btnStergere.Text = "Sterge student";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.lblZiBuna);
            this.Controls.Add(this.lblMedie8);
            this.Controls.Add(this.lblMedie);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatricol);
            this.Controls.Add(this.txtMedie);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnZiBuna);
            this.Controls.Add(this.btnMediePeste8);
            this.Controls.Add(this.btnPreziceMedie);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnPreziceMedie;
        private System.Windows.Forms.Button btnMediePeste8;
        private System.Windows.Forms.Button btnZiBuna;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtMedie;
        private System.Windows.Forms.TextBox txtMatricol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblMedie;
        private System.Windows.Forms.Label lblMedie8;
        private System.Windows.Forms.Label lblZiBuna;
        private System.Windows.Forms.Button btnStergere;
    }
}

