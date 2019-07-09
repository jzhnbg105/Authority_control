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

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private void Form4_Load(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
        }

        private void InitializeOpenFileDialog()
        {
            Console.WriteLine("Pass");
            // Set the file dialog to filter for graphics files.
            openFileDialog1.InitialDirectory = @"O:\ACTCOM\Reserving\Documentation\Working Files\ZHJ";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|Excel Files|*.xls;*.xlsx;*.xlsm|All files (*.*)|*.*";

            // Allow the user to select multiple images.
            openFileDialog1.Title = "Select Files";
        }


        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataSet dataSet = (DataSet)dataGridView1.DataSource;
            dataSet.WriteXml("Utility.xml");
        }

        private void selectFiles()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;
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

            };

            //                MessageBox.Show(Path.GetFileName(filePath));
        }

        [Obsolete]
        private void Button1_Click(object sender, EventArgs e)
        {
            Thread threadGetFile = new Thread(new ThreadStart(selectFiles));
            threadGetFile.ApartmentState = ApartmentState.STA;
            threadGetFile.Start();
            threadGetFile.Join();
            dataGridView1.Update();
            dataGridView1.Refresh();

            //                MessageBox.Show(Path.GetFileName(filePath));
        }


    }
}
