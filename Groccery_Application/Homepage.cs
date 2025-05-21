using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;


namespace Groccery_Application
{
    public partial class Homepage : MaterialForm
    {
        public Homepage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
        MainConnection kn = new MainConnection();
        private void name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = "SELECT * FROM NhanVien WHERE MaNV = '"+name.Text+"'";
            int result = kn.crud_inquery(sql);
            if (result >= 0)
            {

            }
            else
            {

            }
        }
    }
}
