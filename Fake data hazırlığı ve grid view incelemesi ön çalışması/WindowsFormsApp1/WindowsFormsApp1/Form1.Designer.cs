namespace WindowsFormsApp1
{
    partial class frmMusteri
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
            this.grpMusteriListesi = new System.Windows.Forms.GroupBox();
            this.dtgMusteriListesi = new System.Windows.Forms.DataGridView();
            this.grpMusteriListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusteriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMusteriListesi
            // 
            this.grpMusteriListesi.Controls.Add(this.dtgMusteriListesi);
            this.grpMusteriListesi.Location = new System.Drawing.Point(13, 12);
            this.grpMusteriListesi.Name = "grpMusteriListesi";
            this.grpMusteriListesi.Size = new System.Drawing.Size(1495, 372);
            this.grpMusteriListesi.TabIndex = 0;
            this.grpMusteriListesi.TabStop = false;
            this.grpMusteriListesi.Text = "Müşteri Listesi";
            // 
            // dtgMusteriListesi
            // 
            this.dtgMusteriListesi.AllowUserToAddRows = false;
            this.dtgMusteriListesi.AllowUserToDeleteRows = false;
            this.dtgMusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMusteriListesi.Location = new System.Drawing.Point(21, 21);
            this.dtgMusteriListesi.Name = "dtgMusteriListesi";
            this.dtgMusteriListesi.ReadOnly = true;
            this.dtgMusteriListesi.RowTemplate.Height = 24;
            this.dtgMusteriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMusteriListesi.Size = new System.Drawing.Size(1453, 331);
            this.dtgMusteriListesi.TabIndex = 1;
            this.dtgMusteriListesi.DoubleClick += new System.EventHandler(this.dtgMusteriListesi_DoubleClick);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 419);
            this.Controls.Add(this.grpMusteriListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMusteriListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusteriListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMusteriListesi;
        private System.Windows.Forms.DataGridView dtgMusteriListesi;
    }
}

