using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using LGV.EIL;

namespace LGV.Interface_Layer
{
    public partial class Purchases_Form  : Form
    {
        DB_LGVEntities db = new DB_LGVEntities();
        TB_Purchases tb_purchases = new TB_Purchases();
        Business_Layer.Methods methods = new Business_Layer.Methods();
        int id;

        public Purchases_Form()
        {
            InitializeComponent();

            
            LGV.DB_LGVEntities dbContext = new LGV.DB_LGVEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Purchases.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Purchases.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Interface_Layer.Purchases_Add_Form add_form = new Interface_Layer.Purchases_Add_Form();
            add_form.id = 0;
            add_form.btn_add.Text = "Ajouter";
            add_form.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialogue dialogue = new Dialogue();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

            if(id > 0)
            {
                try
                {

                    var result = MessageBox.Show("Opération du supprimer", "Etes-vous sûr de cette opération", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        tb_purchases = db.TB_Purchases.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tb_purchases).State = EntityState.Deleted;
                        db.SaveChanges();
                        toast.txt_caption.Text = "Achat a été supprimé";
                        toast.Show();                     
                        update_data();
                    }
                }
                catch
                {
                    
                }
            }
            else
            {
                dialogue.txt_caption.Text = "Il n'y a aucune fournisseur à supprimer";
                dialogue.Width = this.Width;
                dialogue.Show();
            }

            
            
        }

        private void update_data()
        {
            db = new DB_LGVEntities();
            gridControl1.DataSource = db.TB_Purchases.ToList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_data();

        }

        // Modifier
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Interface_Layer.Purchases_Add_Form add_form = new Interface_Layer.Purchases_Add_Form();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            tb_purchases = db.TB_Purchases.Where(x => x.ID == id).FirstOrDefault();
            add_form.edit_name.Text = tb_purchases.Purchase_Name;
            add_form.edit_type.Text = tb_purchases.Purchase_Type;
            add_form.edit_category.Text = tb_purchases.Purchase_Category;
            add_form.edit_supplier.Text = tb_purchases.Purchase_Supplier;
            add_form.edit_details.Text = tb_purchases.Purchase_Details;
            add_form.edit_buy.Text = tb_purchases.Purchase__Buy.ToString();
            add_form.edit_sell.Text = tb_purchases.Purchase_Sale.ToString();
            add_form.edit_qt.Text = tb_purchases.Purchase_Qt.ToString();
            add_form.edit_tbuy.Text = tb_purchases.Purchase_Tbuy.ToString();
            add_form.edit_sell.Text = tb_purchases.Purchase_Tsell.ToString();
            add_form.edit_trev.Text = tb_purchases.Purchase_Trev.ToString();
 
            add_form.id = id;
            add_form.btn_add.Text = "Modifier";
            add_form.Show();

           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = edit_search.Text;
            gridControl1.DataSource = db.TB_Purchases.Where(x => x.Purchase_Name.Contains(_search) ||
                                                            x.Purchase_Type.Contains(_search) || 
                                                            x.Purchase_Category.Contains(_search)).ToList();
        }
    }
}
