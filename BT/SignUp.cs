using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;

namespace Final_Project_205674047_208078212
{
    public partial class SignUp : Form
    {
        private static string directoryPath = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
        private string filePath = Path.Combine(directoryPath, "BirdsDatabase.xlsx");

        public SignUp()
        {
            InitializeComponent();
        }

        private void signupBtn_Click(object sender, EventArgs e)
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
                    string id = idTbox.Text;

                    // Check username length and character requirements
                    if (userName.Length < 6 || userName.Length > 8 || !IsValidUsername(userName))
                    {
                        MessageBox.Show("Invalid username. Username must be 6-8 characters long with at most 2 digits and rest should be English letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the user already exists in the worksheet
                    bool userExists = CheckUserExists(worksheet, userName);

                    if (userExists)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Find the next available row in the worksheet
                    int nextRow = worksheet.Dimension.Rows + 1;

                    // Write the values to the worksheet
                    worksheet.Cells[nextRow, 1].Value = userName;
                    worksheet.Cells[nextRow, 2].Value = password;
                    worksheet.Cells[nextRow, 3].Value = id;

                    // Save the changes to the Excel file
                    package.Save();

                    MessageBox.Show("User registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while accessing the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUsername(string username)
        {
            int digitCount = 0;
            int letterCount = 0;

            foreach (char c in username)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;

                    if (digitCount > 2)
                    {
                        return false; // More than 2 digits, invalid username
                    }
                }
                else if (char.IsLetter(c))
                {
                    letterCount++;
                }
                else
                {
                    return false; // Invalid character, invalid username
                }
            }

            return letterCount > 0; // At least one letter, valid username
        }

        private bool CheckUserExists(ExcelWorksheet worksheet, string username)
        {
            for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
            {
                var usernameCellValue = worksheet.Cells[row, 1].Value;
                if (usernameCellValue != null && usernameCellValue.ToString() == username)
                {
                    return true;
                }
            }
            return false;
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Access the login form instance
            Login loginForm = Program.GetLoginForm();

            // Use the login form instance as needed
            loginForm.Show();
        }
    }
}
