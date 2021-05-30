namespace ExcelOkuWinApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDosyaYol = new System.Windows.Forms.TextBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdExcelListe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExcelListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Yol";
            // 
            // txtDosyaYol
            // 
            this.txtDosyaYol.Location = new System.Drawing.Point(20, 31);
            this.txtDosyaYol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDosyaYol.Name = "txtDosyaYol";
            this.txtDosyaYol.Size = new System.Drawing.Size(563, 22);
            this.txtDosyaYol.TabIndex = 1;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(592, 27);
            this.btnSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(137, 28);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.BtnSec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdExcelListe);
            this.groupBox1.Location = new System.Drawing.Point(20, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(739, 523);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel İçerik";
            // 
            // grdExcelListe
            // 
            this.grdExcelListe.AllowUserToAddRows = false;
            this.grdExcelListe.AllowUserToDeleteRows = false;
            this.grdExcelListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExcelListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdExcelListe.Location = new System.Drawing.Point(4, 19);
            this.grdExcelListe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdExcelListe.Name = "grdExcelListe";
            this.grdExcelListe.ReadOnly = true;
            this.grdExcelListe.RowHeadersWidth = 51;
            this.grdExcelListe.Size = new System.Drawing.Size(731, 500);
            this.grdExcelListe.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.txtDosyaYol);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Oku ve Yorumla";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExcelListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDosyaYol;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdExcelListe;
    }
}

