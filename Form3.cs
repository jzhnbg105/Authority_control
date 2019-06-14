using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace WindowsFormsApp1
{
    public partial class formPopup : Form
    {
        public formPopup()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Username = Username.Substring(Username.Length - 3);
            if (comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedItem.ToString().Trim())
                {
                    case "Login":
                        Form1 frm1 = new Form1();
                        frm1.Show();
                        frm1.Text = Username;
                        break;

                    case "Admin":
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        frm2.Text = Username;
                        break;

                    case "Navigation":
                        formPopup frmPopup = new formPopup();
                        frmPopup.Show();
                        frmPopup.Text = Username;
                        break;

                    case "Database":
                        Form4 frm4 = new Form4();
                        frm4.Show();
                        frm4.Text = Username;
                        break;

                }
                //Do something with the selected item
            }
        }
    }
}
