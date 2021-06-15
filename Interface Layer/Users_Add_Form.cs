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
    public partial class Users_Add_Form : Form
    {
        // Initialiser
        DB_LGVEntities db = new DB_LGVEntities();
        TB_Users tb_users = new TB_Users();
        Business_Layer.Methods methods = new Business_Layer.Methods();

        public int id;

        public Users_Add_Form()
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
                dialogue.txt_caption.Text = "Le nom d'utilisateur est obligatoire";
                dialogue.Show();
            } 
            else
            {
                if (id == 0)
                {
                    // Ajouter
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_users.User_Name = edit_name.Text;
                    tb_users.User_Pass = edit_pass.Text;
                    tb_users.User_Role = edit_role.Text;
                    tb_users.User_State = "False";
                    db.TB_Users.Add(tb_users);
                    db.SaveChanges();
                    toast.txt_caption.Text = "Un nouvel utilisateur a été ajouté";
                    toast.Show();
                    //db = new DB_LGVEntities();
                    //category_form.gridControl1.DataSource = db.TB_Category.ToList();
                    this.Close();
                    
                }
                else
                {
                    // Modifier
                    // Ajouter

                    tb_users.ID = id;
                    tb_users.User_Name = edit_name.Text;
                    tb_users.User_Pass = edit_pass.Text;
                    tb_users.User_Role = edit_role.Text;
                    tb_users.User_State = "False";
                    db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "L'utilisateur a été modifiée";
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

        
    }
}
