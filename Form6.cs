using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
//        private delegate void SafeCallDelegate(string text);
        public Form6()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        List<string> SelectedFiles = new List<string>();

        private void Form6_Load(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
        }

        private void InitializeOpenFileDialog()
        {
            Console.WriteLine("Pass");
            // Set the file dialog to filter for graphics files.
            openFileDialog1.InitialDirectory = Initial_Dir_Text.Text;
            openFileDialog1.Filter =
                "Excel Files|*.xls;*.xlsx;*.xlsm";

            // Allow the user to select multiple images.
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "My Image Browser";
        }

        private void selectFiles()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        SelectedFiles.Add(file);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot open the file: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }

        private void Change_Tab_Name()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                var excel = new Excel.Application();
                foreach (String file in openFileDialog1.FileNames)
                {
                    var workbook = excel.Workbooks.Open(file);
                    try
                    {
                        for (int i = 1; i <= workbook.Sheets.Count; i++)
                        {
                            var sheet = (Excel.Worksheet)workbook.Worksheets.Item[i];
                            sheet.Name = sheet.Name.Replace(Old_Text_Tab.Text, New_Tab_Text.Text);
                        }
                        Console.WriteLine(file);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot open the file: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
                excel.Quit();
            }
        }

        //        [STAThread]
        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
//            selectFiles();
            Thread threadGetFile = new Thread(new ThreadStart(selectFiles));
            threadGetFile.ApartmentState = ApartmentState.STA;
            threadGetFile.Start();
            threadGetFile.Join();
            foreach (var file in SelectedFiles)
            {
                listView1.Items.Add(file);
            }
            listView1.Update();
            listView1.Refresh();
            SelectedFiles.Clear();
        }

        private void Cng_Tab_Name_Btn_Click(object sender, EventArgs e)
        {
            var excel = new Excel.Application();
            foreach (ListViewItem file in listView1.Items)
            {
                var workbook = excel.Workbooks.Open(file.Text);
                try
                {
                    for (int i = 1; i <= workbook.Sheets.Count; i++)
                    {
                        var sheet = (Excel.Worksheet)workbook.Worksheets.Item[i];
                        sheet.Name = sheet.Name.Replace(Old_Text_Tab.Text, New_Tab_Text.Text);
                    }
                    Console.WriteLine(file);
                }
                catch (SecurityException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }
                catch (Exception ex)
                {
                    // Could not load the image - probably related to Windows file system permissions.
                    MessageBox.Show("Cannot open the file: " + file.Text.Substring(file.Text.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                }
            }
            excel.Quit();
        }

        private void Add_Columns_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Added_Range_Text.Text);
            var excel = new Excel.Application();
            foreach (ListViewItem file in listView1.Items)
            {
                var workbook = excel.Workbooks.Open(file.Text);
                try
                {
                    for (int i = 1; i <= workbook.Sheets.Count; i++)
                    {
                        var sheet = (Excel.Worksheet)workbook.Worksheets.Item[i];
                        if (sheet.Name.Contains(Key_Word_Text.Text))
                        {
                            //                            sheet.Columns.Insert(1, 2);
                            sheet.Range[Added_Range_Text.Text].Insert(Excel.XlInsertShiftDirection.xlShiftToRight);
//                            sheet.Range[Added_Range.Text].Insert(Excel.XlInsertShiftDirection.xlShiftToRight);
                            //                            sheet.Columns.Insert(Start_Col.Text, No_Columns.Text);
                        }
                    }
                    Console.WriteLine(file);
                }
                catch (SecurityException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }
                catch (Exception ex)
                {
                    // Could not load the image - probably related to Windows file system permissions.
                    MessageBox.Show("Cannot open the file: " + file.Text.Substring(file.Text.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                }
            }
            excel.Quit();
        }

        private void Mod_Form_Btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Selected_Cell_Text.Text);
            var excel = new Excel.Application();
            foreach (ListViewItem file in listView1.Items)
            {
                var workbook = excel.Workbooks.Open(file.Text);
                try
                {
                    for (int i = 1; i <= workbook.Sheets.Count; i++)
                    {
                        var sheet = (Excel.Worksheet)workbook.Worksheets.Item[i];
                        if (sheet.Name.Contains(Key_Word_Text.Text))
                        {
                            //                            sheet.Columns.Insert(1, 2);
                            sheet.Range[Selected_Cell_Text.Text].Formula = Input_Form_Text.Text;
                            //                            sheet.Range[Added_Range.Text].Insert(Excel.XlInsertShiftDirection.xlShiftToRight);
                            //                            sheet.Columns.Insert(Start_Col.Text, No_Columns.Text);
                        }
                    }
                    Console.WriteLine(file);
                }
                catch (SecurityException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }
                catch (Exception ex)
                {
                    // Could not load the image - probably related to Windows file system permissions.
                    MessageBox.Show("Cannot open the file: " + file.Text.Substring(file.Text.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                }
            }
            excel.Quit();
        }

        private void Rep_Form_Rep_Click(object sender, EventArgs e)
        {
            Console.WriteLine(From_Cell_Text.Text);
            var excel = new Excel.Application();
            foreach (ListViewItem file in listView1.Items)
            {
                var workbook = excel.Workbooks.Open(file.Text);
                try
                {
                    for (int i = 1; i <= workbook.Sheets.Count; i++)
                    {
                        var sheet = (Excel.Worksheet)workbook.Worksheets.Item[i];
                        if (sheet.Name.Contains(Key_Word_Text.Text))
                        {
                            //                            sheet.Columns.Insert(1, 2);
                            sheet.Range[From_Cell_Text.Text].AutoFill(sheet.Range[To_Range_Text.Text], Excel.XlAutoFillType.xlFillCopy);
                           
                            //                            sheet.Range[Added_Range.Text].Insert(Excel.XlInsertShiftDirection.xlShiftToRight);
                            //                            sheet.Columns.Insert(Start_Col.Text, No_Columns.Text);
                        }
                    }
                    Console.WriteLine(file);
                }
                catch (SecurityException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }
                catch (Exception ex)
                {
                    // Could not load the image - probably related to Windows file system permissions.
                    MessageBox.Show("Cannot open the file: " + file.Text.Substring(file.Text.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                }
            }
            excel.Quit();
        }
    }
}
