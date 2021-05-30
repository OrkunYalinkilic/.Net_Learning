namespace ReflectionFormApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObje = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lts_ctors = new System.Windows.Forms.ListBox();
            this.lst_mtds = new System.Windows.Forms.ListBox();
            this.lst_props = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetir);
            this.groupBox1.Controls.Add(this.txtObje);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(902, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lütfen bilgi almak istediğiniz class\'ın tam adını giriniz:";
            // 
            // txtObje
            // 
            this.txtObje.Location = new System.Drawing.Point(7, 24);
            this.txtObje.Name = "txtObje";
            this.txtObje.Size = new System.Drawing.Size(722, 24);
            this.txtObje.TabIndex = 0;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(735, 18);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(110, 37);
            this.btnGetir.TabIndex = 1;
            this.btnGetir.Text = "GETIR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lts_ctors);
            this.groupBox2.Location = new System.Drawing.Point(13, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 456);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CTOR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_props);
            this.groupBox3.Location = new System.Drawing.Point(301, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 456);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lst_mtds);
            this.groupBox4.Location = new System.Drawing.Point(589, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 456);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Methods";
            // 
            // lts_ctors
            // 
            this.lts_ctors.FormattingEnabled = true;
            this.lts_ctors.ItemHeight = 18;
            this.lts_ctors.Location = new System.Drawing.Point(6, 23);
            this.lts_ctors.Name = "lts_ctors";
            this.lts_ctors.Size = new System.Drawing.Size(269, 418);
            this.lts_ctors.TabIndex = 0;
            // 
            // lst_mtds
            // 
            this.lst_mtds.FormattingEnabled = true;
            this.lst_mtds.ItemHeight = 18;
            this.lst_mtds.Location = new System.Drawing.Point(7, 23);
            this.lst_mtds.Name = "lst_mtds";
            this.lst_mtds.Size = new System.Drawing.Size(269, 418);
            this.lst_mtds.TabIndex = 0;
            // 
            // lst_props
            // 
            this.lst_props.FormattingEnabled = true;
            this.lst_props.ItemHeight = 18;
            this.lst_props.Location = new System.Drawing.Point(6, 23);
            this.lst_props.Name = "lst_props";
            this.lst_props.Size = new System.Drawing.Size(269, 418);
            this.lst_props.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 554);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Reflection With Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox txtObje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lts_ctors;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_props;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lst_mtds;
    }
}

