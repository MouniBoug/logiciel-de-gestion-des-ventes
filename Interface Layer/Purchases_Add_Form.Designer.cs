
namespace LGV.Interface_Layer
{
    partial class Purchases_Add_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchases_Add_Form));
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.edit_supplier = new System.Windows.Forms.ComboBox();
            this.edit_category = new System.Windows.Forms.ComboBox();
            this.edit_details = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edit_trev = new System.Windows.Forms.Label();
            this.edit_tsell = new System.Windows.Forms.Label();
            this.edit_tbuy = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edit_qt = new DevExpress.XtraEditors.SpinEdit();
            this.edit_sell = new System.Windows.Forms.TextBox();
            this.edit_buy = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_qt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(12, 662);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(162, 59);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Ajouter";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.edit_supplier);
            this.groupBox1.Controls.Add(this.edit_category);
            this.groupBox1.Controls.Add(this.edit_details);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edit_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edit_name);
            this.groupBox1.Controls.Add(this.label0);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 417);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations essentielles";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(188, 224);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(68, 23);
            this.linkLabel2.TabIndex = 28;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ajouter";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(188, 173);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 23);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ajouter";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // edit_supplier
            // 
            this.edit_supplier.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.edit_supplier.FormattingEnabled = true;
            this.edit_supplier.Location = new System.Drawing.Point(262, 224);
            this.edit_supplier.Name = "edit_supplier";
            this.edit_supplier.Size = new System.Drawing.Size(304, 34);
            this.edit_supplier.TabIndex = 26;
            // 
            // edit_category
            // 
            this.edit_category.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.edit_category.FormattingEnabled = true;
            this.edit_category.Location = new System.Drawing.Point(262, 168);
            this.edit_category.Name = "edit_category";
            this.edit_category.Size = new System.Drawing.Size(304, 34);
            this.edit_category.TabIndex = 27;
            // 
            // edit_details
            // 
            this.edit_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_details.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_details.Location = new System.Drawing.Point(161, 284);
            this.edit_details.Multiline = true;
            this.edit_details.Name = "edit_details";
            this.edit_details.Size = new System.Drawing.Size(405, 103);
            this.edit_details.TabIndex = 25;
            this.edit_details.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edit_details.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(6, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Détails";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(6, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fournisseur";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Catégory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // edit_type
            // 
            this.edit_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_type.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.edit_type.Location = new System.Drawing.Point(262, 111);
            this.edit_type.Name = "edit_type";
            this.edit_type.Size = new System.Drawing.Size(304, 33);
            this.edit_type.TabIndex = 21;
            this.edit_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // edit_name
            // 
            this.edit_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_name.Location = new System.Drawing.Point(262, 54);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(304, 33);
            this.edit_name.TabIndex = 19;
            this.edit_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label0
            // 
            this.label0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.Color.Gray;
            this.label0.Location = new System.Drawing.Point(6, 54);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(142, 26);
            this.label0.TabIndex = 18;
            this.label0.Text = "Nom du poduit";
            this.label0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label0.Click += new System.EventHandler(this.label0_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edit_trev);
            this.groupBox2.Controls.Add(this.edit_tsell);
            this.groupBox2.Controls.Add(this.edit_tbuy);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(664, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 417);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // edit_trev
            // 
            this.edit_trev.AutoSize = true;
            this.edit_trev.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_trev.ForeColor = System.Drawing.Color.DarkOrange;
            this.edit_trev.Location = new System.Drawing.Point(151, 319);
            this.edit_trev.Name = "edit_trev";
            this.edit_trev.Size = new System.Drawing.Size(36, 42);
            this.edit_trev.TabIndex = 19;
            this.edit_trev.Text = "0";
            // 
            // edit_tsell
            // 
            this.edit_tsell.AutoSize = true;
            this.edit_tsell.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_tsell.ForeColor = System.Drawing.Color.DarkOrange;
            this.edit_tsell.Location = new System.Drawing.Point(151, 205);
            this.edit_tsell.Name = "edit_tsell";
            this.edit_tsell.Size = new System.Drawing.Size(36, 42);
            this.edit_tsell.TabIndex = 19;
            this.edit_tsell.Text = "0";
            // 
            // edit_tbuy
            // 
            this.edit_tbuy.AutoSize = true;
            this.edit_tbuy.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_tbuy.ForeColor = System.Drawing.Color.DarkOrange;
            this.edit_tbuy.Location = new System.Drawing.Point(151, 95);
            this.edit_tbuy.Name = "edit_tbuy";
            this.edit_tbuy.Size = new System.Drawing.Size(36, 42);
            this.edit_tbuy.TabIndex = 19;
            this.edit_tbuy.Text = "0";
            this.edit_tbuy.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(67, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 33);
            this.label10.TabIndex = 18;
            this.label10.Text = "Bénéfices totaux";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(67, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 33);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ventes (prix total)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(67, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "Achats (prix total)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edit_qt);
            this.groupBox3.Controls.Add(this.edit_sell);
            this.groupBox3.Controls.Add(this.edit_buy);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 198);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ventes et achats";
            // 
            // edit_qt
            // 
            this.edit_qt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edit_qt.Location = new System.Drawing.Point(262, 135);
            this.edit_qt.Name = "edit_qt";
            this.edit_qt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.edit_qt.Properties.Appearance.Options.UseFont = true;
            this.edit_qt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edit_qt.Size = new System.Drawing.Size(304, 32);
            this.edit_qt.TabIndex = 21;
            this.edit_qt.EditValueChanged += new System.EventHandler(this.edit_qt_EditValueChanged);
            // 
            // edit_sell
            // 
            this.edit_sell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_sell.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_sell.Location = new System.Drawing.Point(262, 93);
            this.edit_sell.Name = "edit_sell";
            this.edit_sell.Size = new System.Drawing.Size(304, 33);
            this.edit_sell.TabIndex = 20;
            this.edit_sell.Text = "0";
            this.edit_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edit_sell.TextChanged += new System.EventHandler(this.edit_sell_TextChanged);
            // 
            // edit_buy
            // 
            this.edit_buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_buy.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_buy.Location = new System.Drawing.Point(262, 44);
            this.edit_buy.Name = "edit_buy";
            this.edit_buy.Size = new System.Drawing.Size(304, 33);
            this.edit_buy.TabIndex = 20;
            this.edit_buy.Text = "0";
            this.edit_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edit_buy.TextChanged += new System.EventHandler(this.edit_buy_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(7, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 26);
            this.label14.TabIndex = 19;
            this.label14.Text = "Quantité";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(6, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 26);
            this.label13.TabIndex = 19;
            this.label13.Text = "Prix de vente (unique)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(6, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 26);
            this.label12.TabIndex = 19;
            this.label12.Text = "Prix d\'achat (unique)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Purchases_Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1029, 733);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Purchases_Add_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Purchases_Add_Form_Activated);
            this.Load += new System.EventHandler(this.Purchases_Add_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_qt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox edit_details;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edit_type;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox edit_sell;
        public System.Windows.Forms.TextBox edit_buy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox edit_supplier;
        public System.Windows.Forms.ComboBox edit_category;
        public System.Windows.Forms.Label edit_trev;
        public System.Windows.Forms.Label edit_tsell;
        public System.Windows.Forms.Label edit_tbuy;
        public DevExpress.XtraEditors.SpinEdit edit_qt;
    }
}