using OfficeOpenXml;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Final_Project_205674047_208078212
{
    public partial class Login : Form
    {
        private static string directoryPath = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
        private string filePath = Path.Combine(directoryPath, "BirdsDatabase.xlsx");
        public static birdForm birds = new birdForm();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Login()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Users"];

                    // Get the values from the TextBoxes
                    string userName = usernameTbox.Text;
                    string password = passwordTbox.Text;

                    // Loop through the worksheet rows to find a match
                    for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        var usernameCellValue = worksheet.Cells[row, 1].Value;
                        var passwordCellValue = worksheet.Cells[row, 2].Value;

                        if (usernameCellValue != null && passwordCellValue != null)
                        {
                            string username = usernameCellValue.ToString();
                            string userPassword = passwordCellValue.ToString();

                            if (username == userName && userPassword == password)
                            {
                                // Username and password match                               
                                birds.Show();
                                this.Hide();
                                return;
                            }
                        }
                    }

                    // No match found
                    loginMsgLabel.Text = "Invalid username or password.";
                    loginMsgLabel.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while accessing the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            SignUp signupForm = new SignUp();
            signupForm.Show();
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
