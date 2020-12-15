
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
            this.LARS = new System.Windows.Forms.Button();
            this.btnStan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDagenVanDeWeek
            // 
            this.cmbDagenVanDeWeek.FormattingEnabled = true;
            this.cmbDagenVanDeWeek.Location = new System.Drawing.Point(64, 60);
            this.cmbDagenVanDeWeek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDagenVanDeWeek.Name = "cmbDagenVanDeWeek";
            this.cmbDagenVanDeWeek.Size = new System.Drawing.Size(303, 24);
            this.cmbDagenVanDeWeek.TabIndex = 0;
            this.cmbDagenVanDeWeek.SelectedIndexChanged += new System.EventHandler(this.cmbDagenVanDeWeek_SelectedIndexChanged);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(64, 112);
            this.btnWhile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnDoWhile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnFor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tbTafel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTafel.Multiline = true;
            this.tbTafel.Name = "tbTafel";
            this.tbTafel.Size = new System.Drawing.Size(195, 170);
            this.tbTafel.TabIndex = 4;
            // 
            // tbTafelVan
            // 
            this.tbTafelVan.Location = new System.Drawing.Point(64, 219);
            this.tbTafelVan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTafelVan.Name = "tbTafelVan";
            this.tbTafelVan.Size = new System.Drawing.Size(99, 22);
            this.tbTafelVan.TabIndex = 5;
            // 
            // LARS
            // 
            this.LARS.Location = new System.Drawing.Point(145, 340);
            this.LARS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LARS.Name = "LARS";
            this.LARS.Size = new System.Drawing.Size(100, 28);
            this.LARS.TabIndex = 6;
            this.LARS.Text = "HAAI";
            this.LARS.UseVisualStyleBackColor = true;
            this.LARS.Click += new System.EventHandler(this.LARS_Click);
            // 
            // btnStan
            // 
            this.btnStan.Location = new System.Drawing.Point(64, 249);
            this.btnStan.Name = "btnStan";
            this.btnStan.Size = new System.Drawing.Size(99, 23);
            this.btnStan.TabIndex = 7;
            this.btnStan.Text = "Stan";
            this.btnStan.UseVisualStyleBackColor = true;
            this.btnStan.Click += new System.EventHandler(this.btnStan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 449);
            this.Controls.Add(this.btnStan);
            this.Controls.Add(this.LARS);
            this.Controls.Add(this.tbTafelVan);
            this.Controls.Add(this.tbTafel);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.cmbDagenVanDeWeek);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button LARS;
        private System.Windows.Forms.Button btnStan;
    }
}

