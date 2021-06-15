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
    public partial class Users_Form  : Form
    {
        DB_LGVEntities db = new DB_LGVEntities();
        TB_Users tb_users = new TB_Users();
        Business_Layer.Methods methods = new Business_Layer.Methods();
        int id;

        public Users_Form()
        {
            InitializeComponent();


            
            LGV.DB_LGVEntities dbContext = new LGV.DB_LGVEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Users.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Interface_Layer.Users_Add_Form add_form = new Interface_Layer.Users_Add_Form();
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
                        tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tb_users).State = EntityState.Deleted;
                        db.SaveChanges();
                        toast.txt_caption.Text = "L'utilisateur a été supprimé";
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
                dialogue.txt_caption.Text = "Il n'y a aucune utilisateur à supprimer";
                dialogue.Width = this.Width;
                dialogue.Show();
            }

            
            
        }

        private void update_data()
        {
            db = new DB_LGVEntities();
            gridControl1.DataSource = db.TB_Users.ToList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_data();

        }

        // Modifier
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Interface_Layer.Users_Add_Form add_form = new Interface_Layer.Users_Add_Form();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
            add_form.edit_name.Text = tb_users.User_Name;
            add_form.edit_pass.Text = tb_users.User_Pass;
            add_form.edit_role.Text = tb_users.User_Role;
    
            add_form.id = id;
            add_form.btn_add.Text = "Modifier";
            add_form.Show();

           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //var _search = edit_search.Text;
            //gridControl1.DataSource = db.TB_Purchases.Where(x => x.Purchase_Name.Contains(_search) ||
                                                          //  x.Purchase_Type.Contains(_search) || 
                                                           // x.Purchase_Category.Contains(_search)).ToList();
        }
    }
}
