
namespace LGV.Interface_Layer
{
    partial class Sales_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Form));
            this.panel_category = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSale_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale_Client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale_Qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale_Tprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_search = new System.Windows.Forms.TextBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.panel_category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_category
            // 
            this.panel_category.Controls.Add(this.gridControl1);
            this.panel_category.Controls.Add(this.panel1);
            this.panel_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_category.Location = new System.Drawing.Point(0, 0);
            this.panel_category.Name = "panel_category";
            this.panel_category.Size = new System.Drawing.Size(1030, 720);
            this.panel_category.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(LGV.TB_Sales);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1030, 607);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSale_Name,
            this.colSale_Client,
            this.colSale_Price,
            this.colSale_Qt,
            this.colSale_Tprice,
            this.colSale_Date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSale_Name
            // 
            this.colSale_Name.Caption = "Nom du produit";
            this.colSale_Name.FieldName = "Sale_Name";
            this.colSale_Name.Name = "colSale_Name";
            this.colSale_Name.Visible = true;
            this.colSale_Name.VisibleIndex = 0;
            // 
            // colSale_Client
            // 
            this.colSale_Client.Caption = "Client";
            this.colSale_Client.FieldName = "Sale_Client";
            this.colSale_Client.Name = "colSale_Client";
            this.colSale_Client.Visible = true;
            this.colSale_Client.VisibleIndex = 1;
            // 
            // colSale_Price
            // 
            this.colSale_Price.Caption = "Prix";
            this.colSale_Price.FieldName = "Sale_Price";
            this.colSale_Price.Name = "colSale_Price";
            this.colSale_Price.Visible = true;
            this.colSale_Price.VisibleIndex = 2;
            // 
            // colSale_Qt
            // 
            this.colSale_Qt.Caption = "Quantité";
            this.colSale_Qt.FieldName = "Sale_Qt";
            this.colSale_Qt.Name = "colSale_Qt";
            this.colSale_Qt.Visible = true;
            this.colSale_Qt.VisibleIndex = 3;
            // 
            // colSale_Tprice
            // 
            this.colSale_Tprice.Caption = "Prix total";
            this.colSale_Tprice.FieldName = "Sale_Tprice";
            this.colSale_Tprice.Name = "colSale_Tprice";
            this.colSale_Tprice.Visible = true;
            this.colSale_Tprice.VisibleIndex = 4;
            // 
            // colSale_Date
            // 
            this.colSale_Date.Caption = "Date";
            this.colSale_Date.FieldName = "Sale_Date";
            this.colSale_Date.Name = "colSale_Date";
            this.colSale_Date.Visible = true;
            this.colSale_Date.VisibleIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.edit_search);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 607);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 113);
            this.panel1.TabIndex = 2;
            // 
            // edit_search
            // 
            this.edit_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_search.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_search.Location = new System.Drawing.Point(619, 33);
            this.edit_search.Name = "edit_search";
            this.edit_search.Size = new System.Drawing.Size(324, 40);
            this.edit_search.TabIndex = 2;
            this.edit_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Location = new System.Drawing.Point(949, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(60, 40);
            this.btn_search.TabIndex = 1;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            this.btn_update.Location = new System.Drawing.Point(416, 22);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(126, 59);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Rafraîchir";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_delete.ImageOptions.SvgImage")));
            this.btn_delete.Location = new System.Drawing.Point(280, 22);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(130, 59);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.Enabled = false;
            this.btn_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_edit.ImageOptions.SvgImage")));
            this.btn_edit.Location = new System.Drawing.Point(152, 22);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(122, 59);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Modifier";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(24, 22);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 59);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Ajouter";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Sales_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.panel_category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Form";
            this.Text = "Category_Form";
            this.panel_category.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_category;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox edit_search;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSale_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSale_Client;
        private DevExpress.XtraGrid.Columns.GridColumn colSale_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colSale_Qt;
        private DevExpress.XtraGrid.Columns.GridColumn colSale_Tprice;
        private DevExpress.XtraGrid.Columns.GridColumn colSale_Date;
    }
}