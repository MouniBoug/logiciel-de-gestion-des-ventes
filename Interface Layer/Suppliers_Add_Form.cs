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
    public partial class Suppliers_Add_Form : Form
    {
        // Initialiser
        DB_LGVEntities db = new DB_LGVEntities();
        TB_Supp tb_supp = new TB_Supp();
        Business_Layer.Methods methods = new Business_Layer.Methods();

        public int id;

        public Suppliers_Add_Form()
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
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.Supp_Name = edit_name.Text;
                    tb_supp.Supp_Phone = edit_phone.Text;
                    tb_supp.Supp_Email = edit_email.Text;
                    tb_supp.Supp_Image = methods.convert_byte();
                    db.TB_Supp.Add(tb_supp);
                    db.SaveChanges();
                    toast.txt_caption.Text = "Un nouvelle fournisseur a été ajoutée";
                    toast.Show();
                    //db = new DB_LGVEntities();
                    //category_form.gridControl1.DataSource = db.TB_Category.ToList();
                    this.Close();
                    
                }
                else
                {
                    // Modifier
                    // Ajouter
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.ID = id;
                    tb_supp.Supp_Name = edit_name.Text;
                    tb_supp.Supp_Phone = edit_phone.Text;
                    tb_supp.Supp_Email = edit_email.Text;
                    tb_supp.Supp_Image = methods.convert_byte();
                    db.Entry(tb_supp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "Le fournisseur a été modifiée";
                    toast.Show();
                    //db = new DB_LGVEntities();
                    //category_form.gridControl1.DataSource = db.TB_Category.ToList();
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
