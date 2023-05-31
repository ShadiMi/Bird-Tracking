using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Final_Project_205674047_208078212
{
    public partial class Offspring : Form
    {
        private static string directoryPath = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
        private string filePath = Path.Combine(directoryPath, "BirdsDatabase.xlsx");
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public Offspring()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void birdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Birds"];

                    // Get the values from the TextBoxes
                    string birdSN = birdSnTbox.Text;
                    DateTime hatchingDate = hatchingDatePicker.Value;
                    string motherSN = motherSnTbox.Text;
                    string fatherSN = fatherSnTbox.Text;
                    string cageSN = cageNumTbox.Text;
                    string subSpecies = subspeciesTbox.Text;
                    string species = speciesTbox.Text;
                    string gender = genderCbox.Text;

                    // Validate the bird serial number
                    if (!IsDigitsOnly(birdSN))
                    {
                        MessageBox.Show("Invalid bird serial number. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Check if the bird's serial number already exists in the worksheet
                    bool isSerialNumberUnique = IsSerialNumberUnique(worksheet, birdSN);
                    bool fatherExists = true;
                    if (fatherSN != "")
                    {
                        fatherExists = CheckBirdSerialNumberExists(worksheet, fatherSN);
                    }
                    bool motherExists = true;
                    if (motherSN != "")
                    {
                        motherExists = CheckBirdSerialNumberExists(worksheet, motherSN);
                    }


                    if (!fatherExists || !motherExists)
                    {
                        MessageBox.Show("Invalid fatherSN or motherSN. Please make sure they exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!isSerialNumberUnique)
                    {
                        MessageBox.Show("Serial number already exists. Please enter a unique serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    // Find the next available row in the worksheet
                    int nextRow = worksheet.Dimension.Rows + 1;

                    // Write the values to the worksheet
                    worksheet.Cells[nextRow, 1].Value = birdSN;
                    worksheet.Cells[nextRow, 2].Value = species;
                    worksheet.Cells[nextRow, 3].Value = subSpecies;
                    worksheet.Cells[nextRow, 4].Value = hatchingDate.ToShortDateString().ToString();
                    worksheet.Cells[nextRow, 5].Value = gender;
                    worksheet.Cells[nextRow, 6].Value = cageSN;
                    worksheet.Cells[nextRow, 7].Value = fatherSN;
                    worksheet.Cells[nextRow, 8].Value = motherSN;

                    // Save the changes to the Excel file
                    package.Save();
                }

                MessageBox.Show("New bird data saved to Excel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Login.birds.ShowBirds();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool IsSerialNumberUnique(ExcelWorksheet worksheet, string serialNumber)
        {
            // Loop through the rows and check if the serial number already exists
            for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
            {
                var cellValue = worksheet.Cells[row, 1].Value;
                if (cellValue != null && cellValue.ToString() == serialNumber)
                {
                    return false; // Serial number already exists
                }
            }

            return true; // Serial number is unique
        }


        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private bool IsDigitsOrDotOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c) && c != '.')
                    return false;
            }
            return true;
        }

        private bool CheckBirdSerialNumberExists(ExcelWorksheet worksheet, string serialNumber)
        {
            for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
            {
                var cellValue = worksheet.Cells[row, 1].Value;
                if (cellValue != null && cellValue.ToString() == serialNumber)
                {
                    return true;
                }
            }
            return false;
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
