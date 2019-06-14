using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.Diagnostics;
using System.IO;
using System.Threading;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Define statics classes
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        public static IList<IList<Object>> values;

        // Define request parameters.
        public String spreadsheetId = "1FM0qTpYlfrWDAOlSUDV9vb6MEH1vZpn7gBCILuME3Hw";
        public String range = "User!A1:E";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserCredential credential;
            using (var stream =
               new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            // Prints the columns in a sample spreadsheet:
            ValueRange response = request.Execute();
            values = response.Values;

            var Username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Username = Username.Substring(Username.Length - 3);

            if (values != null && values.Count > 0)
            {
                int i = 0;
                foreach (var row in values)
                {
                    // Print columns A and E, which correspond to indices 0 and 1.
                    if (row[1].Equals(Username))
                    {
                        MessageBox.Show("Welcome " + row[2] + " " + Username);
                        this.Close();
                        formPopup frmPopup = new formPopup();
                        frmPopup.Show();
                        frmPopup.Text = Username;
                        i++;
                        break;
                    }
                    Console.WriteLine("{0}, {1}", row[0], row[1]);
                }
                if (i == 0)
                {
                    MessageBox.Show("Your profile is not  found");
                    this.Close();
                    formPopup frm3 = new formPopup();
                    frm3.Show();
                    frm3.Text = Username;
                }
            }
            else
            {
                Console.WriteLine("No data found."); ;
            }

            //            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain))
            //            if (pc.ValidateCredentials("zhj", "autumn19"))
            //                {
            //                    Debug.WriteLine("Validated");
            //                    /* Check group membership */
            //                }
        }
    }
}
