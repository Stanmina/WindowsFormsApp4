
namespace WindowsFormsApp4
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
            this.cmbDagenVanDeWeek = new System.Windows.Forms.ComboBox();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.tbTafel = new System.Windows.Forms.TextBox();
            this.tbTafelVan = new System.Windows.Forms.TextBox();
            this.btnLars = new System.Windows.Forms.Button();
            this.btnStan = new System.Windows.Forms.Button();
            this.btnEmiel = new System.Windows.Forms.Button();
            this.btnLuuk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDagenVanDeWeek
            // 
            this.cmbDagenVanDeWeek.FormattingEnabled = true;
            this.cmbDagenVanDeWeek.Location = new System.Drawing.Point(64, 60);
            this.cmbDagenVanDeWeek.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDagenVanDeWeek.Name = "cmbDagenVanDeWeek";
            this.cmbDagenVanDeWeek.Size = new System.Drawing.Size(303, 24);
            this.cmbDagenVanDeWeek.TabIndex = 0;
            this.cmbDagenVanDeWeek.SelectedIndexChanged += new System.EventHandler(this.cmbDagenVanDeWeek_SelectedIndexChanged);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(64, 112);
            this.btnWhile.Margin = new System.Windows.Forms.Padding(4);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(100, 28);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "While loop";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(64, 148);
            this.btnDoWhile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(100, 28);
            this.btnDoWhile.TabIndex = 2;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(64, 183);
            this.btnFor.Margin = new System.Windows.Forms.Padding(4);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(100, 28);
            this.btnFor.TabIndex = 3;
            this.btnFor.Text = "For loop";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // tbTafel
            // 
            this.tbTafel.Location = new System.Drawing.Point(172, 112);
            this.tbTafel.Margin = new System.Windows.Forms.Padding(4);
            this.tbTafel.Multiline = true;
            this.tbTafel.Name = "tbTafel";
            this.tbTafel.Size = new System.Drawing.Size(195, 170);
            this.tbTafel.TabIndex = 4;
            // 
            // tbTafelVan
            // 
            this.tbTafelVan.Location = new System.Drawing.Point(64, 219);
            this.tbTafelVan.Margin = new System.Windows.Forms.Padding(4);
            this.tbTafelVan.Name = "tbTafelVan";
            this.tbTafelVan.Size = new System.Drawing.Size(99, 22);
            this.tbTafelVan.TabIndex = 5;
            // 
            // btnLars
            // 
            this.btnLars.Location = new System.Drawing.Point(272, 290);
            this.btnLars.Margin = new System.Windows.Forms.Padding(4);
            this.btnLars.Name = "btnLars";
            this.btnLars.Size = new System.Drawing.Size(95, 23);
            this.btnLars.TabIndex = 6;
            this.btnLars.Text = "Lars";
            this.btnLars.UseVisualStyleBackColor = true;
            this.btnLars.Click += new System.EventHandler(this.LARS_Click);
            // 
            // btnStan
            // 
            this.btnStan.Location = new System.Drawing.Point(172, 289);
            this.btnStan.Name = "btnStan";
            this.btnStan.Size = new System.Drawing.Size(95, 23);
            this.btnStan.TabIndex = 7;
            this.btnStan.Text = "Stan";
            this.btnStan.UseVisualStyleBackColor = true;
            this.btnStan.Click += new System.EventHandler(this.btnStan_Click);
            // 
            // btnEmiel
            // 
            this.btnEmiel.Location = new System.Drawing.Point(172, 318);
            this.btnEmiel.Name = "btnEmiel";
            this.btnEmiel.Size = new System.Drawing.Size(95, 23);
            this.btnEmiel.TabIndex = 9;
            this.btnEmiel.Text = "Emiel";
            this.btnEmiel.UseVisualStyleBackColor = true;
            this.btnEmiel.Click += new System.EventHandler(this.btnEmiel_Click);
            // 
            // btnLuuk
            // 
            this.btnLuuk.Location = new System.Drawing.Point(272, 319);
            this.btnLuuk.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuk.Name = "btnLuuk";
            this.btnLuuk.Size = new System.Drawing.Size(95, 23);
            this.btnLuuk.TabIndex = 8;
            this.btnLuuk.Text = "Luuk";
            this.btnLuuk.UseVisualStyleBackColor = true;
            this.btnLuuk.Click += new System.EventHandler(this.btnLuuk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(272, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 449);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmiel);
            this.Controls.Add(this.btnLuuk);
            this.Controls.Add(this.btnStan);
            this.Controls.Add(this.btnLars);
            this.Controls.Add(this.tbTafelVan);
            this.Controls.Add(this.tbTafel);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.cmbDagenVanDeWeek);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDagenVanDeWeek;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.TextBox tbTafel;
        private System.Windows.Forms.TextBox tbTafelVan;
        private System.Windows.Forms.Button btnLars;
        private System.Windows.Forms.Button btnStan;
        private System.Windows.Forms.Button btnEmiel;
        private System.Windows.Forms.Button btnLuuk;
        private System.Windows.Forms.Button btnExit;
    }
}

