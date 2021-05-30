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
            this.components = new System.ComponentModel.Container();
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.urunResim = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunTanimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimYolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.AllowUserToAddRows = false;
            this.dgwUrunler.AllowUserToDeleteRows = false;
            this.dgwUrunler.AutoGenerateColumns = false;
            this.dgwUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.urunResim,
            this.urunTanimDataGridViewTextBoxColumn,
            this.resimYolDataGridViewTextBoxColumn});
            this.dgwUrunler.DataSource = this.urunBindingSource;
            this.dgwUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUrunler.Location = new System.Drawing.Point(0, 0);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.ReadOnly = true;
            this.dgwUrunler.RowTemplate.Height = 24;
            this.dgwUrunler.Size = new System.Drawing.Size(1107, 767);
            this.dgwUrunler.TabIndex = 0;
            this.dgwUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellContentClick);
            // 
            // urunResim
            // 
            this.urunResim.DataPropertyName = "urunResim";
            this.urunResim.HeaderText = "urunResim";
            this.urunResim.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.urunResim.Name = "urunResim";
            this.urunResim.ReadOnly = true;
            this.urunResim.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.urunResim.Width = 82;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 5F;
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "Ürün ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Width = 62;
            // 
            // urunTanimDataGridViewTextBoxColumn
            // 
            this.urunTanimDataGridViewTextBoxColumn.DataPropertyName = "urunTanim";
            this.urunTanimDataGridViewTextBoxColumn.HeaderText = "Ürün Tanım";
            this.urunTanimDataGridViewTextBoxColumn.Name = "urunTanimDataGridViewTextBoxColumn";
            this.urunTanimDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunTanimDataGridViewTextBoxColumn.Width = 111;
            // 
            // resimYolDataGridViewTextBoxColumn
            // 
            this.resimYolDataGridViewTextBoxColumn.DataPropertyName = "resimYol";
            this.resimYolDataGridViewTextBoxColumn.HeaderText = "Resim Yolu";
            this.resimYolDataGridViewTextBoxColumn.Name = "resimYolDataGridViewTextBoxColumn";
            this.resimYolDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimYolDataGridViewTextBoxColumn.Visible = false;
            this.resimYolDataGridViewTextBoxColumn.Width = 108;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataSource = typeof(WindowsFormsApp1.Urun);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 767);
            this.Controls.Add(this.dgwUrunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn urunResim;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunTanimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimYolDataGridViewTextBoxColumn;
    }
}

