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
            this.button1 = new System.Windows.Forms.Button();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "İkinci formu Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.lblBilgi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBilgi.Location = new System.Drawing.Point(124, 37);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(194, 34);
            this.lblBilgi.TabIndex = 1;
            this.lblBilgi.Text = "İkinci form üzerine yazılmasını\r\n istediğiniz metni giriniz";
            // 
            // txtBilgi
            // 
            this.txtBilgi.Location = new System.Drawing.Point(86, 85);
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(265, 22);
            this.txtBilgi.TabIndex = 2;
            this.txtBilgi.Text = "Bir metin giriniz";
            this.txtBilgi.Enter += new System.EventHandler(this.txtBilgi_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 253);
            this.Controls.Add(this.txtBilgi);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birinci Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.TextBox txtBilgi;
    }
}

