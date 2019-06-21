using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        IList<IList<Object>> values = Form1.values;
        private BindingSource bindingSource1 = new BindingSource();
        public Form2()
        {
            InitializeComponent();
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void DataGridView_CellFormatting(object sender,
        System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }
//      Button to add a new row to DGV
        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add();
//            this.dataGridView1.DataSource = values;
//            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
//                foreach (var column in values[0])
//                {
//                    
//                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
                this.dataGridView1.SelectedRows[0].Index !=
                this.dataGridView1.Rows.Count - 1)
            {
                this.dataGridView1.Rows.RemoveAt(
                    this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void SetupDataGridView()
        {
            dataGridView1.ColumnCount = 5;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Name = "DGV";
            dataGridView1.Location = new Point(8, 8);
            dataGridView1.Size = new Size(500, 250);
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;

            int i = 0;
            dataGridView1.Columns[i].Name = values[1][i].ToString();
            foreach (var column in values[0])
            {
                dataGridView1.Columns[i].Name = column.ToString();
                i++;
            }

            dataGridView1.Columns[4].DefaultCellStyle.Font =
                new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Italic);

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Dock = DockStyle.Fill;

            dataGridView1.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                DataGridView_CellFormatting);
        }

        private void PopulateDataGridView()
        {
            dataGridView1.Rows.Add(values.Count - 1);
            int i = 0;
            foreach (var row in values.Skip(1))
            {
                for (int j = 0; j < dataGridView1.Rows[index: i].Cells.Count; j++){
//                    Console.WriteLine(row[j]);
                    dataGridView1.Rows[index: i].Cells[j].Value = row[j];
                }
//                dataGridView1.Rows[index: i].Cells[0].Value = row[0];
//                dataGridView1.Rows[index: i].Cells[1].Value = row[1];
//                dataGridView1.Rows[index: i].Cells[2].Value = row[2];
//                dataGridView1.Rows[index: i].Cells[3].Value = row[3];
//                dataGridView1.Rows[index: i].Cells[4].Value = row[4];
                i++;
            }

            dataGridView1.Columns[0].DisplayIndex = 0;
            dataGridView1.Columns[1].DisplayIndex = 1;
            dataGridView1.Columns[2].DisplayIndex = 2;
            dataGridView1.Columns[3].DisplayIndex = 3;
            dataGridView1.Columns[4].DisplayIndex = 4;
        }
        private void Grid_MouseUp(object sender, MouseEventArgs e)
        {
            // Create a HitTestInfo object using the HitTest method.

            // Get the DataGrid by casting sender.
            DataGridView myGrid = (DataGridView)sender;
            DataGridView.HitTestInfo myHitInfo = myGrid.HitTest(e.X, e.Y);
            Console.WriteLine(myHitInfo);
            Console.WriteLine(myHitInfo.Type);
            Console.WriteLine(myHitInfo.RowIndex);
            Console.WriteLine(myHitInfo.ColumnIndex);
        }


        //        Send query request to google sheets

        //        private static IList<IList<Object>> GenerateData()
        //        {
        //            List<IList<Object>> objNewRecords = new List<IList<Object>>();
        //            IList<Object> obj = new List<Object>();
        //            obj.Add("Column - 1");
        //            obj.Add("Column - 2");
        //            obj.Add("Column - 3");
        //            objNewRecords.Add(obj);
        //            return objNewRecords;
        //        }

        //        private static void UpdatGoogleSheet(IList<IList<Object>> values, string spreadsheetId, string newRange, SheetsService service)
        //        {
        //            SpreadsheetsResource.ValuesResource.AppendRequest request =
        //               service.Spreadsheets.Values.Append(new Google.Apis.Sheets.v4.Data.ValueRange() { Values = values }, spreadsheetId, newRange);
        //            request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
        //            request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
        //            var response = request.Execute();
        //        }


        //Only needed when calling components of another form
        //        public string LabelText
        //        {
        //            get
        //            {
        //                return this.Text;
        //            }
        //            set
        //            {
        //                this.Text = value;
        //            }
        //        }
    }
}
