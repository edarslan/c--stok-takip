namespace stoktakip
{
    partial class frmÜrünListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnvarolanekle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.alıştxt = new System.Windows.Forms.TextBox();
            this.satıştxt = new System.Windows.Forms.TextBox();
            this.miktartxt = new System.Windows.Forms.TextBox();
            this.ürünadıtxt = new System.Windows.Forms.TextBox();
            this.kategoritxt = new System.Windows.Forms.TextBox();
            this.barkodnotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbarkodnoara = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.combokategori = new System.Windows.Forms.ComboBox();
            this.combomarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmarkagüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnvarolanekle
            // 
            this.btnvarolanekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvarolanekle.Location = new System.Drawing.Point(157, 432);
            this.btnvarolanekle.Name = "btnvarolanekle";
            this.btnvarolanekle.Size = new System.Drawing.Size(144, 33);
            this.btnvarolanekle.TabIndex = 24;
            this.btnvarolanekle.Text = "Güncelle";
            this.btnvarolanekle.UseVisualStyleBackColor = true;
            this.btnvarolanekle.Click += new System.EventHandler(this.btnvarolanekle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(29, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(41, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(67, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "Miktarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(48, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(458, 541);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(442, 501);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Kategori";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(27, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Barkod NO";
            // 
            // markatxt
            // 
            this.markatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markatxt.Location = new System.Drawing.Point(167, 219);
            this.markatxt.Name = "markatxt";
            this.markatxt.ReadOnly = true;
            this.markatxt.Size = new System.Drawing.Size(143, 30);
            this.markatxt.TabIndex = 28;
            // 
            // alıştxt
            // 
            this.alıştxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alıştxt.Location = new System.Drawing.Point(167, 333);
            this.alıştxt.Name = "alıştxt";
            this.alıştxt.Size = new System.Drawing.Size(143, 30);
            this.alıştxt.TabIndex = 27;
            // 
            // satıştxt
            // 
            this.satıştxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satıştxt.Location = new System.Drawing.Point(167, 371);
            this.satıştxt.Name = "satıştxt";
            this.satıştxt.Size = new System.Drawing.Size(143, 30);
            this.satıştxt.TabIndex = 26;
            // 
            // miktartxt
            // 
            this.miktartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktartxt.Location = new System.Drawing.Point(167, 295);
            this.miktartxt.Name = "miktartxt";
            this.miktartxt.Size = new System.Drawing.Size(143, 30);
            this.miktartxt.TabIndex = 25;
            // 
            // ürünadıtxt
            // 
            this.ürünadıtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünadıtxt.Location = new System.Drawing.Point(167, 257);
            this.ürünadıtxt.Name = "ürünadıtxt";
            this.ürünadıtxt.Size = new System.Drawing.Size(143, 30);
            this.ürünadıtxt.TabIndex = 23;
            // 
            // kategoritxt
            // 
            this.kategoritxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoritxt.Location = new System.Drawing.Point(167, 181);
            this.kategoritxt.Name = "kategoritxt";
            this.kategoritxt.ReadOnly = true;
            this.kategoritxt.Size = new System.Drawing.Size(143, 30);
            this.kategoritxt.TabIndex = 22;
            // 
            // barkodnotxt
            // 
            this.barkodnotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodnotxt.Location = new System.Drawing.Point(167, 143);
            this.barkodnotxt.Name = "barkodnotxt";
            this.barkodnotxt.Size = new System.Drawing.Size(143, 30);
            this.barkodnotxt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(421, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "BarkodNo\'ya Göre Ara";
            // 
            // txtbarkodnoara
            // 
            this.txtbarkodnoara.Location = new System.Drawing.Point(677, 33);
            this.txtbarkodnoara.Name = "txtbarkodnoara";
            this.txtbarkodnoara.Size = new System.Drawing.Size(124, 22);
            this.txtbarkodnoara.TabIndex = 37;
            this.txtbarkodnoara.TextChanged += new System.EventHandler(this.txtbarkodnoara_TextChanged);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(1059, 104);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(87, 37);
            this.btnsil.TabIndex = 38;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // combokategori
            // 
            this.combokategori.FormattingEnabled = true;
            this.combokategori.Location = new System.Drawing.Point(549, 497);
            this.combokategori.Name = "combokategori";
            this.combokategori.Size = new System.Drawing.Size(162, 24);
            this.combokategori.TabIndex = 39;
            this.combokategori.SelectedIndexChanged += new System.EventHandler(this.combokategori_SelectedIndexChanged);
            // 
            // combomarka
            // 
            this.combomarka.FormattingEnabled = true;
            this.combomarka.Location = new System.Drawing.Point(549, 545);
            this.combomarka.Name = "combomarka";
            this.combomarka.Size = new System.Drawing.Size(162, 24);
            this.combomarka.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Kategori";
            // 
            // btnmarkagüncelle
            // 
            this.btnmarkagüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmarkagüncelle.Location = new System.Drawing.Point(740, 501);
            this.btnmarkagüncelle.Name = "btnmarkagüncelle";
            this.btnmarkagüncelle.Size = new System.Drawing.Size(144, 65);
            this.btnmarkagüncelle.TabIndex = 43;
            this.btnmarkagüncelle.Text = "Marka Güncelle";
            this.btnmarkagüncelle.UseVisualStyleBackColor = true;
            this.btnmarkagüncelle.Click += new System.EventHandler(this.btnmarkagüncelle_Click);
            // 
            // frmÜrünListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1158, 617);
            this.Controls.Add(this.btnmarkagüncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combomarka);
            this.Controls.Add(this.combokategori);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.txtbarkodnoara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvarolanekle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.alıştxt);
            this.Controls.Add(this.satıştxt);
            this.Controls.Add(this.miktartxt);
            this.Controls.Add(this.ürünadıtxt);
            this.Controls.Add(this.kategoritxt);
            this.Controls.Add(this.barkodnotxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmÜrünListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmÜrünListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnvarolanekle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox markatxt;
        private System.Windows.Forms.TextBox alıştxt;
        private System.Windows.Forms.TextBox satıştxt;
        private System.Windows.Forms.TextBox miktartxt;
        private System.Windows.Forms.TextBox ürünadıtxt;
        private System.Windows.Forms.TextBox kategoritxt;
        private System.Windows.Forms.TextBox barkodnotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbarkodnoara;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.ComboBox combokategori;
        private System.Windows.Forms.ComboBox combomarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmarkagüncelle;
    }
}