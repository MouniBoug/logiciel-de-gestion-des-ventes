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
    public partial class Category_Add_Form : Form
    {
        // Initialiser
        DB_LGVEntities db = new DB_LGVEntities();
        TB_Category tb_category = new TB_Category();
        Business_Layer.Methods methods = new Business_Layer.Methods();
        Interface_Layer.Category_Form category_form = new Interface_Layer.Category_Form();
        

        public int id;

        public Category_Add_Form()
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
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_category.Category_Name = edit_name.Text;
                    tb_category.Category_Cover = methods.convert_byte();
                    db.TB_Category.Add(tb_category);
                    db.SaveChanges();
                    toast.txt_caption.Text = "Une nouvelle catégorie a été ajoutée";
                    toast.Show();
                    db = new DB_LGVEntities();
                    category_form.gridControl1.DataSource = db.TB_Category.ToList();
                    this.Close();
                }
                else
                {
                    // Modifier
                    // Ajouter
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_category.Category_Name = edit_name.Text;
                    tb_category.ID = id;
                    tb_category.Category_Cover = methods.convert_byte();
                    db.Entry(tb_category).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "Une nouvelle catégorie a été modifiée";
                    toast.Show();
                    db = new DB_LGVEntities();
                    category_form.gridControl1.DataSource = db.TB_Category.ToList();
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
    }
}
