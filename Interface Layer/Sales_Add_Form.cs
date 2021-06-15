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
    public partial class Sales_Add_Form : Form
    {
        // Initialiser
        DB_LGVEntities db = new DB_LGVEntities();
        TB_Purchases tb_purchases = new TB_Purchases();
        TB_Sales tb_sale = new TB_Sales();
        Business_Layer.Methods methods = new Business_Layer.Methods();
        double qtp, qtn, qtr;

        public int id;

        public Sales_Add_Form()
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
            qtp = Convert.ToDouble(txt_qt.Text);
            qtn = Convert.ToDouble(edit_qt.Text);
            qtr = qtp - qtn;

            if (edit_name.Text == "")
            {
                dialogue.Width = this.Width;
                dialogue.txt_caption.Text = "Le nom du produit est obligatoire";
                dialogue.Show();
            } 
            else
            {
                if (id == 0)
                {
                    // Ajouter
                    if (qtr >= 0)
                    {
                        tb_sale.Sale_Name = edit_name.Text;
                        tb_sale.Sale_Client = edit_client.Text;
                        tb_sale.Sale_Price = Convert.ToDouble(edit_sell.Text);
                        tb_sale.Sale_Qt = Convert.ToDouble(edit_qt.Text);
                        tb_sale.Sale_Tprice = (Convert.ToDouble(edit_qt.Text) * Convert.ToDouble(edit_sell.Text));
                        tb_sale.Sale_Date = DateTime.Now;
                        db.TB_Sales.Add(tb_sale);
                        tb_purchases.Purchase_Qt = qtr;

                        db.Entry(tb_purchases).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.txt_caption.Text = "Une nouvelle vente a été effectué";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        label1.Visible = true;
                    }
                   
                    
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void edit_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_purchases = db.TB_Purchases.Where(x => x.Purchase_Name == edit_name.Text).FirstOrDefault();
            txt_buy.Text = tb_purchases.Purchase__Buy.ToString();
            txt_sale.Text = tb_purchases.Purchase_Sale.ToString();
            txt_qt.Text = tb_purchases.Purchase_Qt.ToString();
            edit_sell.Text = tb_purchases.Purchase_Sale.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void edit_tsell_Click(object sender, EventArgs e)
        {

        }

        private void Purchases_Add_Form_Load(object sender, EventArgs e)
        {

        }

        private void Purchases_Add_Form_Activated(object sender, EventArgs e)
        {
            var result1 = db.TB_Purchases.Select(x => x.Purchase_Name).ToList();
            var result2 = db.TB_Clients.Select(x => x.Supp_Name).ToList();
            edit_name.DataSource = result1;
            edit_client.DataSource = result2;

            AutoCompleteStringCollection acsc1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acsc2 = new AutoCompleteStringCollection();
            acsc1.AddRange(result1.ToArray());
            acsc2.AddRange(result2.ToArray());
            edit_name.AutoCompleteCustomSource = acsc1;
            edit_client.AutoCompleteCustomSource = acsc2;

            


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          

            Interface_Layer.Purchases_Add_Form add_form = new Interface_Layer.Purchases_Add_Form();
            add_form.id = 0;
            add_form.btn_add.Text = "Ajouter";
            add_form.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Interface_Layer.Clients_Add_Form add_form = new Interface_Layer.Clients_Add_Form();
            add_form.id = 0;
            add_form.btn_add.Text = "Ajouter";
            add_form.Show();
        }

        // Calculation des achats
        private void pro_calculations()
        {
            /*sell = Convert.ToDouble(edit_sell.Text);
            //buy = Convert.ToDouble(edit_buy.Text);
            qt = Convert.ToDouble(edit_qt.Value);
            tsell = sell * qt;
            tbuy = buy * qt;
            trev = tsell - tbuy;
            txt_sale.Text = tsell.ToString();
            txt_buy.Text = tbuy.ToString();
            txt_qt.Text = trev.ToString();*/
        }
    }
}
