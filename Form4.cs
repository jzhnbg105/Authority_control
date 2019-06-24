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
using System.IO;
using System.Security;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public DataSet ds = new DataSet();
        public Form4()
        {
            InitializeComponent();
            try
            {
                //                XmlReader xmlFile;
                //                xmlFile = XmlReader.Create("Utility.xml", new XmlReaderSettings());
                //                OleDbDataAdapter dataAdapter;
                //                dataAdapter = new OleDbDataAdapter("select * from Function");
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
        private void Button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            Thread t = new Thread((ThreadStart)(() => {
                OpenFileDialog saveFileDialog1 = new OpenFileDialog();

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = @"O:\ACTCOM\Reserving\Documentation\Working Files\ZHJ";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
//                        DataRow newRow = ds.Tables[0].NewRow();
                        ds.Tables[0].Rows.Add(dataGridView1.Rows.Count, Path.GetFileName(filePath), filePath,
                            Path.GetExtension(filePath).Replace(".", ""), System.IO.File.GetAccessControl(filePath).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString(),
                        File.GetCreationTime(filePath), File.GetLastWriteTime(filePath));
                        //                        dataGridView1.Rows.Add(dataGridView1.Rows.Count, filePath.GetFileName(filePath))
                        //Read the contents of the file into a stream
                        //                        var fileStream = openFileDialog.OpenFile();

                        //                        using (StreamReader reader = new StreamReader(fileStream))
                        //                        {
                        //                            fileContent = reader.ReadToEnd();
                        //                        }
                    }
                }
            }));
        
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
            dataGridView1.Update();
            dataGridView1.Refresh();

            //                MessageBox.Show(Path.GetFileName(filePath));
        }


    }
}
