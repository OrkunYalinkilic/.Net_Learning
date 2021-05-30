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
            this.btnUret = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.lblMayin = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(610, 114);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(205, 161);
            this.btnUret.TabIndex = 0;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(578, 500);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(625, 293);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 29);
            this.label.TabIndex = 2;
            this.label.Text = "SKOR";
            // 
            // lblMayin
            // 
            this.lblMayin.AutoSize = true;
            this.lblMayin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMayin.Location = new System.Drawing.Point(722, 331);
            this.lblMayin.Name = "lblMayin";
            this.lblMayin.Size = new System.Drawing.Size(27, 29);
            this.lblMayin.TabIndex = 3;
            this.lblMayin.Text = "0";
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labell.Location = new System.Drawing.Point(625, 331);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(91, 29);
            this.labell.TabIndex = 4;
            this.labell.Text = "MAYIN";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(715, 293);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(81, 29);
            this.lblSkor.TabIndex = 5;
            this.lblSkor.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 541);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.labell);
            this.Controls.Add(this.lblMayin);
            this.Controls.Add(this.label);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnUret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblMayin;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Label lblSkor;
    }
}

