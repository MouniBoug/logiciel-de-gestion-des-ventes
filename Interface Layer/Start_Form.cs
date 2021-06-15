using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;

namespace LGV.Interface_Layer
{
    public partial class Start_Form : SplashScreen
    {
        // init
        DB_LGVEntities db = new DB_LGVEntities();
        TB_Users tb_users = new TB_Users();
        Main main = new Main();
        Interface_Layer.login_Form login = new Interface_Layer.login_Form();

        public Start_Form()
        {
            InitializeComponent();
            //this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        

        private void Start_Form_Load(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_users = db.TB_Users.Where(x => x.User_State == "True").FirstOrDefault();
            if (tb_users != null)
            {
                main.lb_username.Text = tb_users.User_Name;
                main.lb_role.Text = tb_users.User_Role;
                main.Show();

            }
            else
            {
                login.Show();
            }
            this.Hide();
            timer1.Enabled = false;
        }


        
         
         
    }
}