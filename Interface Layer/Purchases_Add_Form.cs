using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LGV.EIL;

namespace LGV.Interface_Layer
{
    public partial class Purchases_Add_Form : Form
    {
        // Initialiser
        DB_LGVEntities db = new DB_LGVEntities();
        TB_Purchases tb_purchases = new TB_Purchases();
        Business_Layer.Methods methods = new Business_Layer.Methods();
        double buy, sell, qt, tbuy, tsell, trev;

        public int id;

        public Purchases_Add_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Ajouter ou modifier
        private void btn_add_Click(object sender, EventArgs e)
        {
            
            Toast toast = new Toast();
            Dialogue dialogue = new Dialogue();

            // Vérifier si ajouter ou modifier
            if (edit_name.Text == "")
            {
                dialogue.Width = this.Width;
                dialogue.txt_caption.Text = "Le nom de la catégorie est obligatoire";
                dialogue.Show();
            } 
            else
            {
                if (id == 0)
                {
                    // Ajouter
                    tb_purchases.Purchase_Name = edit_name.Text;
                    tb_purchases.Purchase_Type = edit_type.Text;
                    tb_purchases.Purchase_Category = edit_category.Text;
                    tb_purchases.Purchase_Supplier = edit_supplier.Text;
                    tb_purchases.Purchase_Details = edit_category.Text;
                    tb_purchases.Purchase__Buy = Convert.ToDouble(edit_buy.Text);
                    tb_purchases.Purchase_Sale = Convert.ToDouble(edit_sell.Text);
                    tb_purchases.Purchase_Qt = Convert.ToDouble(edit_qt.Text);
                    tb_purchases.Purchase_Tbuy= Convert.ToDouble(edit_tbuy.Text);
                    tb_purchases.Purchase_Tsell = Convert.ToDouble(edit_tsell.Text);
                    tb_purchases.Purchase_Trev = Convert.ToDouble(edit_trev.Text);
                    db.TB_Purchases.Add(tb_purchases);
                    db.SaveChanges();
                    toast.txt_caption.Text = "Un nouvelle achat a été effectué";
                    toast.Show();         
                    this.Close();
                    
                }
                else
                {
                    // Modifier
                    tb_purchases.ID = id;
                    tb_purchases.Purchase_Name = edit_name.Text;
                    tb_purchases.Purchase_Type = edit_type.Text;
                    tb_purchases.Purchase_Category = edit_category.Text;
                    tb_purchases.Purchase_Supplier = edit_supplier.Text;
                    tb_purchases.Purchase_Details = edit_category.Text;
                    tb_purchases.Purchase__Buy = Convert.ToDouble(edit_buy.Text);
                    tb_purchases.Purchase_Sale = Convert.ToDouble(edit_sell.Text);
                    tb_purchases.Purchase_Qt = Convert.ToDouble(edit_qt.Text);
                    tb_purchases.Purchase_Tbuy = Convert.ToDouble(edit_tbuy.Text);
                    tb_purchases.Purchase_Tsell = Convert.ToDouble(edit_tsell.Text);
                    tb_purchases.Purchase_Trev = Convert.ToDouble(edit_trev.Text);
                    db.Entry(tb_purchases).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "Un nouvelle achat a été effectué";
                    toast.Show();
                    this.Close();

                }
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label0_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void edit_buy_TextChanged(object sender, EventArgs e)
        {
            pro_calculations();
        }

        private void edit_sell_TextChanged(object sender, EventArgs e)
        {
            pro_calculations();
        }

        private void edit_qt_EditValueChanged(object sender, EventArgs e)
        {
            pro_calculations();
        }

        private void label0_Click_1(object sender, EventArgs e)
        {

        }

        private void Purchases_Add_Form_Load(object sender, EventArgs e)
        {

        }

        private void Purchases_Add_Form_Activated(object sender, EventArgs e)
        {
            edit_category.DataSource = db.TB_Category.Select(x => x.Category_Name).ToList();
            edit_supplier.DataSource = db.TB_Supp.Select(x => x.Supp_Name).ToList();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Interface_Layer.Category_Add_Form add_form = new Interface_Layer.Category_Add_Form();
            add_form.id = 0;
            add_form.btn_add.Text = "Ajouter";
            add_form.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Interface_Layer.Suppliers_Add_Form add_form = new Interface_Layer.Suppliers_Add_Form();
            add_form.id = 0;
            add_form.btn_add.Text = "Ajouter";
            add_form.Show();
        }

        // Calculation des achats
        private void pro_calculations()
        {
            sell = Convert.ToDouble(edit_sell.Text);
            buy = Convert.ToDouble(edit_buy.Text);
            qt = Convert.ToDouble(edit_qt.Value);
            tsell = sell * qt;
            tbuy = buy * qt;
            trev = tsell - tbuy;
            edit_tsell.Text = tsell.ToString();
            edit_tbuy.Text = tbuy.ToString();
            edit_trev.Text = trev.ToString();
        }
    }
}
