using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGV.Interface_Layer
{
    public partial class Home_Form : Form
    {
        // init
        DB_LGVEntities db = new DB_LGVEntities();


        public Home_Form()
        {
            InitializeComponent();

            List<TB_Category> list_category = db.TB_Category.ToList();
            lb_category.Text = list_category.Count.ToString();

        }

        private void lb_titlePage_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Interface_Layer.Sales_Add_Form add_form = new Interface_Layer.Sales_Add_Form();
            add_form.id = 0;
            add_form.btn_add.Text = "Ajouter";
            add_form.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Interface_Layer.Purchases_Add_Form add_form = new Interface_Layer.Purchases_Add_Form();
            add_form.id = 0;
            add_form.btn_add.Text = "Ajouter";
            add_form.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Interface_Layer.Clients_Add_Form add_form = new Interface_Layer.Clients_Add_Form();
            add_form.id = 0;
            add_form.btn_add.Text = "Ajouter";
            add_form.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Interface_Layer.Suppliers_Add_Form add_form = new Interface_Layer.Suppliers_Add_Form();
            add_form.id = 0;
            add_form.btn_add.Text = "Ajouter";
            add_form.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Interface_Layer.Category_Add_Form add_form = new Interface_Layer.Category_Add_Form();
            add_form.id = 0;
            add_form.btn_add.Text = "Ajouter";
            add_form.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void update_data()
        {
            db = new DB_LGVEntities();
            //lb_category.Text = db.TB_Category.ToList();

            List<TB_Category> list_category = db.TB_Category.ToList();
            lb_category.Text = list_category.Count.ToString();

            List<TB_Clients> list_clients = db.TB_Clients.ToList();
            lb_clients.Text = list_clients.Count.ToString();


            List<TB_Purchases> list_buy = db.TB_Purchases.ToList();
            lb_buy.Text = list_buy.Count.ToString();

            List<TB_Sales> list_sale = db.TB_Sales.ToList();
            lb_sale.Text = list_sale.Count.ToString();

            List<TB_Supp> list_supp = db.TB_Supp.ToList();
            lb_supply.Text = list_supp.Count.ToString();

            List<TB_Users> list_users = db.TB_Users.ToList();
            lb_users.Text = list_users.Count.ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_data();
        }

        private void lb_category_Click(object sender, EventArgs e)
        {

        }
    }
}
