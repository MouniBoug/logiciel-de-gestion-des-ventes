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
    public partial class login_Form : Form
    {
        // Initialiser
        DB_LGVEntities db = new DB_LGVEntities();
        TB_Users tb_users = new TB_Users();
        Main main = new Main();

        public login_Form()
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

            // 
            if (edit_name.Text == "")
            {
                dialogue.Width = this.Width;
                dialogue.txt_caption.Text = "Le nom d'utilisateur est obligatoire";
                dialogue.Show();
            }
            else
            {
                // Connexion
                tb_users = db.TB_Users.Where(x => x.User_Name == edit_name.Text && x.User_Pass == edit_pass.Text).FirstOrDefault();

                if (tb_users != null)
                {
                    tb_users.User_State = "True";
                    db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
                    main.lb_username.Text = tb_users.User_Name;
                    main.lb_role.Text = tb_users.User_Role;
                    main.Enabled = true;
                    db.SaveChanges();
                    main.Show(); 
                    this.Close();

                }
                else
                {
                    MessageBox.Show("échec de connexion");
                }


            }

        }

        private void login_Form_Load(object sender, EventArgs e)
        {
            main.Enabled = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

