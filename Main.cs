using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGV
{
    public partial class Main : Form
    {
        // Initialisation les forms
        Interface_Layer.Home_Form home_form = new Interface_Layer.Home_Form();
        Interface_Layer.Category_Form category_form = new Interface_Layer.Category_Form();
        Interface_Layer.Suppliers_Form suppliers_form = new Interface_Layer.Suppliers_Form();
        Interface_Layer.Purchases_Form purchases_form = new Interface_Layer.Purchases_Form();
        Interface_Layer.Clients_Form clients_form = new Interface_Layer.Clients_Form();
        Interface_Layer.Sales_Form sales_form = new Interface_Layer.Sales_Form();
        
        Interface_Layer.Users_Form users_form = new Interface_Layer.Users_Form();
        
        DB_LGVEntities db = new DB_LGVEntities();
        TB_Users tb_users = new TB_Users();



        public Main()
        {
            InitializeComponent();
        }

        // Charger la page d'accueil
        private void LGV_Load(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(home_form.panel_home);
            // Définir le rôle
            if (lb_role.Text == "Administrateur")
            {
                btn_users.Enabled = true;
            }
            else
            {
                btn_users.Enabled = false;
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(home_form.panel_home);

        }

        private void panel_topbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // simpleButton5_Click Réduction du menu
        private void btn_menuCollapse_Click(object sender, EventArgs e)
        {
            if (panel_navbar.Width == 250)
            {
                panel_navbar.Width = 50;
                panel_picNavbar.Visible = false;
                panel_headerNavbar.Height = 175;
            } else
            {
                panel_navbar.Width = 250;
                panel_picNavbar.Visible = true;
                panel_headerNavbar.Height = 215;
            }
        }

        // fermer le programme
        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Minimiser le programme
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Maximiser le programme
        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            
        }

        // Charger la page des categories
        private void btn_category_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(category_form.panel_category);
            db = new DB_LGVEntities();
            // category_form.gridControl1.DataSource = db.TB_Category.ToList();
            lb_titlePage.Text = "Categories";

        }

        // Charger la page des Fournisseurs
        private void btn_supp_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(suppliers_form.panel_category);
            db = new DB_LGVEntities();
            lb_titlePage.Text = "Fournisseurs";
        }

        // Charger la page des achats
        private void btn_purshases_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(purchases_form.panel_category);
            db = new DB_LGVEntities();
            lb_titlePage.Text = "Achats";
        }

        // Charger la page des Clients
        private void btn_clients_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(clients_form.panel_category);
            db = new DB_LGVEntities();
            lb_titlePage.Text = "Clients";
        }


        // Charger la page des Ventes
        private void btn_sales_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(sales_form.panel_category);
            db = new DB_LGVEntities();
            lb_titlePage.Text = "Ventes";
        }

       /* private void btn_report_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(report_form.panel_category);
            lb_titlePage.Text = "Rapports";
        }*/

        private void btn_users_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();
            panel_container.Controls.Add(users_form.panel_category);
            lb_titlePage.Text = "Utilisateurs";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

            Interface_Layer.login_Form login = new Interface_Layer.login_Form();
            tb_users = db.TB_Users.Where(x => x.User_State == "True").FirstOrDefault();
            tb_users.User_State = "False";
            db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            this.Enabled = false;
            login.Show();
            this.Hide();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
