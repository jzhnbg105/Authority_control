using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Username = Username.Substring(Username.Length - 3);
            if (comboBox1.SelectedItem != null)
            {
                //Do something with the selected item
                this.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            DataRow dr = dataSet.Tables[0].Rows[index];
            string vbscript = dr[2].ToString();
            string function_type = dr[3].ToString();
            Console.WriteLine(dr[2].ToString());
            switch (function_type)
            {
                case "vbs":
                    Process scriptProc = new Process();
                    scriptProc.StartInfo.FileName = Path.GetFileName(vbscript);
                    scriptProc.StartInfo.WorkingDirectory = Path.GetDirectoryName(vbscript);
                    scriptProc.Start();
//                    System.Diagnostics.Process.Start(@"cscript //B //Nologo C:\Users\zhj\Desktop\Important docs\Word_to_PDF.vbs");
                    Console.WriteLine("pass");
//                    Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));

//                    dynamic obj = Activator.CreateInstance(scriptType, false);
//                    obj.Language = "vbscript";
//                    string vbscript = "msgbox(\"test\")";
//                    obj.Eval(vbscript);
                    break;

            }
        }
    }
}
