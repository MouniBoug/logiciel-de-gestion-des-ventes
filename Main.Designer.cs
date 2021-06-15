
namespace LGV
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_topbar = new System.Windows.Forms.Panel();
            this.lb_titlePage = new System.Windows.Forms.Label();
            this.btn_min = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_logout = new DevExpress.XtraEditors.SimpleButton();
            this.btn_max = new DevExpress.XtraEditors.SimpleButton();
            this.panel_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new DevExpress.XtraEditors.SimpleButton();
            this.btn_category = new DevExpress.XtraEditors.SimpleButton();
            this.btn_supp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_purshases = new DevExpress.XtraEditors.SimpleButton();
            this.btn_clients = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sales = new DevExpress.XtraEditors.SimpleButton();
            this.btn_users = new DevExpress.XtraEditors.SimpleButton();
            this.panel_headerNavbar = new System.Windows.Forms.Panel();
            this.panel_picNavbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_menuCollapse = new DevExpress.XtraEditors.SimpleButton();
            this.panel_container = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_topbar.SuspendLayout();
            this.panel_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_headerNavbar.SuspendLayout();
            this.panel_picNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_topbar
            // 
            this.panel_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panel_topbar.Controls.Add(this.lb_titlePage);
            this.panel_topbar.Controls.Add(this.btn_min);
            this.panel_topbar.Controls.Add(this.btn_close);
            this.panel_topbar.Controls.Add(this.btn_logout);
            this.panel_topbar.Controls.Add(this.btn_max);
            this.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topbar.Location = new System.Drawing.Point(250, 0);
            this.panel_topbar.Name = "panel_topbar";
            this.panel_topbar.Size = new System.Drawing.Size(1030, 53);
            this.panel_topbar.TabIndex = 0;
            this.panel_topbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_topbar_Paint);
            // 
            // lb_titlePage
            // 
            this.lb_titlePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlePage.AutoSize = true;
            this.lb_titlePage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlePage.ForeColor = System.Drawing.Color.Silver;
            this.lb_titlePage.Location = new System.Drawing.Point(427, 14);
            this.lb_titlePage.Name = "lb_titlePage";
            this.lb_titlePage.Size = new System.Drawing.Size(75, 26);
            this.lb_titlePage.TabIndex = 6;
            this.lb_titlePage.Text = "Accueil";
            this.lb_titlePage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_min.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_min.ImageOptions.SvgImage")));
            this.btn_min.Location = new System.Drawing.Point(885, 11);
            this.btn_min.Name = "btn_min";
            this.btn_min.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_min.Size = new System.Drawing.Size(34, 29);
            this.btn_min.TabIndex = 2;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_close.ImageOptions.SvgImage")));
            this.btn_close.Location = new System.Drawing.Point(985, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(34, 29);
            this.btn_close.TabIndex = 3;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_logout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_logout.ImageOptions.SvgImage")));
            this.btn_logout.Location = new System.Drawing.Point(835, 11);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_logout.Size = new System.Drawing.Size(34, 29);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_max.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_max.ImageOptions.SvgImage")));
            this.btn_max.Location = new System.Drawing.Point(935, 11);
            this.btn_max.Name = "btn_max";
            this.btn_max.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_max.Size = new System.Drawing.Size(34, 29);
            this.btn_max.TabIndex = 5;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // panel_navbar
            // 
            this.panel_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panel_navbar.Controls.Add(this.flowLayoutPanel1);
            this.panel_navbar.Controls.Add(this.panel_headerNavbar);
            this.panel_navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_navbar.Location = new System.Drawing.Point(0, 0);
            this.panel_navbar.Name = "panel_navbar";
            this.panel_navbar.Size = new System.Drawing.Size(250, 720);
            this.panel_navbar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_home);
            this.flowLayoutPanel1.Controls.Add(this.btn_category);
            this.flowLayoutPanel1.Controls.Add(this.btn_supp);
            this.flowLayoutPanel1.Controls.Add(this.btn_purshases);
            this.flowLayoutPanel1.Controls.Add(this.btn_clients);
            this.flowLayoutPanel1.Controls.Add(this.btn_sales);
            this.flowLayoutPanel1.Controls.Add(this.btn_users);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 215);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 505);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_home.Appearance.Options.UseFont = true;
            this.btn_home.Appearance.Options.UseForeColor = true;
            this.btn_home.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_home.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_home.ImageOptions.SvgImage")));
            this.btn_home.Location = new System.Drawing.Point(3, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_home.Size = new System.Drawing.Size(247, 46);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "Accueil";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_category
            // 
            this.btn_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_category.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_category.Appearance.Options.UseFont = true;
            this.btn_category.Appearance.Options.UseForeColor = true;
            this.btn_category.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_category.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_category.ImageOptions.SvgImage")));
            this.btn_category.Location = new System.Drawing.Point(3, 55);
            this.btn_category.Name = "btn_category";
            this.btn_category.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_category.Size = new System.Drawing.Size(247, 46);
            this.btn_category.TabIndex = 5;
            this.btn_category.Text = "Catégories";
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_supp
            // 
            this.btn_supp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supp.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supp.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_supp.Appearance.Options.UseFont = true;
            this.btn_supp.Appearance.Options.UseForeColor = true;
            this.btn_supp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_supp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_supp.ImageOptions.SvgImage")));
            this.btn_supp.Location = new System.Drawing.Point(3, 107);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_supp.Size = new System.Drawing.Size(247, 46);
            this.btn_supp.TabIndex = 6;
            this.btn_supp.Text = "Fournisseurs";
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // btn_purshases
            // 
            this.btn_purshases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_purshases.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purshases.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_purshases.Appearance.Options.UseFont = true;
            this.btn_purshases.Appearance.Options.UseForeColor = true;
            this.btn_purshases.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_purshases.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_purshases.ImageOptions.SvgImage")));
            this.btn_purshases.Location = new System.Drawing.Point(3, 159);
            this.btn_purshases.Name = "btn_purshases";
            this.btn_purshases.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_purshases.Size = new System.Drawing.Size(247, 46);
            this.btn_purshases.TabIndex = 7;
            this.btn_purshases.Text = "Achats";
            this.btn_purshases.Click += new System.EventHandler(this.btn_purshases_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clients.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clients.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_clients.Appearance.Options.UseFont = true;
            this.btn_clients.Appearance.Options.UseForeColor = true;
            this.btn_clients.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_clients.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_clients.ImageOptions.SvgImage")));
            this.btn_clients.Location = new System.Drawing.Point(3, 211);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_clients.Size = new System.Drawing.Size(247, 46);
            this.btn_clients.TabIndex = 8;
            this.btn_clients.Text = "Clients";
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sales.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_sales.Appearance.Options.UseFont = true;
            this.btn_sales.Appearance.Options.UseForeColor = true;
            this.btn_sales.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_sales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sales.ImageOptions.SvgImage")));
            this.btn_sales.Location = new System.Drawing.Point(3, 263);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_sales.Size = new System.Drawing.Size(247, 46);
            this.btn_sales.TabIndex = 9;
            this.btn_sales.Text = "Ventes";
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_users
            // 
            this.btn_users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_users.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_users.Appearance.Options.UseFont = true;
            this.btn_users.Appearance.Options.UseForeColor = true;
            this.btn_users.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_users.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_users.ImageOptions.SvgImage")));
            this.btn_users.Location = new System.Drawing.Point(3, 315);
            this.btn_users.Name = "btn_users";
            this.btn_users.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_users.Size = new System.Drawing.Size(247, 46);
            this.btn_users.TabIndex = 11;
            this.btn_users.Text = "Utilisateurs";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // panel_headerNavbar
            // 
            this.panel_headerNavbar.Controls.Add(this.panel_picNavbar);
            this.panel_headerNavbar.Controls.Add(this.panel1);
            this.panel_headerNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_headerNavbar.Location = new System.Drawing.Point(0, 0);
            this.panel_headerNavbar.Name = "panel_headerNavbar";
            this.panel_headerNavbar.Size = new System.Drawing.Size(250, 215);
            this.panel_headerNavbar.TabIndex = 0;
            // 
            // panel_picNavbar
            // 
            this.panel_picNavbar.Controls.Add(this.pictureBox1);
            this.panel_picNavbar.Controls.Add(this.lb_role);
            this.panel_picNavbar.Controls.Add(this.lb_username);
            this.panel_picNavbar.Location = new System.Drawing.Point(38, 0);
            this.panel_picNavbar.Name = "panel_picNavbar";
            this.panel_picNavbar.Size = new System.Drawing.Size(212, 215);
            this.panel_picNavbar.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_role
            // 
            this.lb_role.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(153)))), ((int)(((byte)(61)))));
            this.lb_role.Location = new System.Drawing.Point(0, 170);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(209, 23);
            this.lb_role.TabIndex = 6;
            this.lb_role.Text = "Admin";
            this.lb_role.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_username
            // 
            this.lb_username.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.Silver;
            this.lb_username.Location = new System.Drawing.Point(0, 147);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(212, 23);
            this.lb_username.TabIndex = 6;
            this.lb_username.Text = "Bouguelaa Mounir";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_menuCollapse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 215);
            this.panel1.TabIndex = 1;
            // 
            // btn_menuCollapse
            // 
            this.btn_menuCollapse.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_menuCollapse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_menuCollapse.ImageOptions.SvgImage")));
            this.btn_menuCollapse.Location = new System.Drawing.Point(12, 11);
            this.btn_menuCollapse.Name = "btn_menuCollapse";
            this.btn_menuCollapse.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_menuCollapse.Size = new System.Drawing.Size(26, 28);
            this.btn_menuCollapse.TabIndex = 4;
            this.btn_menuCollapse.Click += new System.EventHandler(this.btn_menuCollapse_Click);
            // 
            // panel_container
            // 
            this.panel_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel_container.Location = new System.Drawing.Point(250, 59);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1030, 661);
            this.panel_container.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel_topbar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_topbar);
            this.Controls.Add(this.panel_navbar);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.LGV_Load);
            this.panel_topbar.ResumeLayout(false);
            this.panel_topbar.PerformLayout();
            this.panel_navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_headerNavbar.ResumeLayout(false);
            this.panel_picNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_topbar;
        private System.Windows.Forms.Panel panel_navbar;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Label lb_titlePage;
        private DevExpress.XtraEditors.SimpleButton btn_min;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_logout;
        private DevExpress.XtraEditors.SimpleButton btn_max;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_headerNavbar;
        private DevExpress.XtraEditors.SimpleButton btn_menuCollapse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_home;
        private DevExpress.XtraEditors.SimpleButton btn_category;
        private DevExpress.XtraEditors.SimpleButton btn_supp;
        private DevExpress.XtraEditors.SimpleButton btn_purshases;
        private DevExpress.XtraEditors.SimpleButton btn_clients;
        private DevExpress.XtraEditors.SimpleButton btn_sales;
        private DevExpress.XtraEditors.SimpleButton btn_users;
        private System.Windows.Forms.Panel panel_picNavbar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Label lb_role;
        public System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Timer timer1;
    }
}

