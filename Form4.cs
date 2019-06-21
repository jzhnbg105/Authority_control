using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            try
            {
                //                XmlReader xmlFile;
                //                xmlFile = XmlReader.Create("Utility.xml", new XmlReaderSettings());
                //                OleDbDataAdapter dataAdapter;
                //                dataAdapter = new OleDbDataAdapter("select * from Function");
                DataSet ds = new DataSet();
                ds.ReadXml("Utility.xml");
                //                dataAdapter.Fill(ds, "Function");
                //                ds.AcceptChanges();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Function";

                //                DataSet changes = ds.GetChanges();
                //                if (changes != null)
                //                {
                //                    int updatedRows = dataAdapter.Update(changes);
                //                    ds.AcceptChanges();
                //                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataSet dataSet = (DataSet)dataGridView1.DataSource;
            dataSet.WriteXml("Utility.xml");
        }

    }
}
