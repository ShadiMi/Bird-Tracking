using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using DataTable = System.Data.DataTable;

namespace Final_Project_205674047_208078212
{
    public partial class birdForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private System.Windows.Forms.ListBox searchResultListBox;
        private System.Windows.Forms.Label resultCountLabel;

        private static string directoryPath = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
        private string filePath = Path.Combine(directoryPath, "BirdsDatabase.xlsx");

        private readonly string[] validSpecies = { "gouldian american", "gouldian european", "gouldian australian" };
        private readonly string[] validSubspeciesAmerican = { "northern american", "central american", "southern american" };
        private readonly string[] validSubspeciesEuropean = { "eastern european", "western european" };
        private readonly string[] validSubspeciesAustralian = { "central australian", "coastal forests" };

        public birdForm()
        {
            InitializeComponent();
            birdsGrid.CellEndEdit += birdsGrid_CellEndEdit;
            cagesGrid.CellEndEdit += cagesGrid_CellEndEdit;
            cagesGrid.CellClick += CagesGrid_CellClick;
        }

        private void birdForm_Load(object sender, EventArgs e)
        {
            ShowBirds();
            ShowCages();
        }

        private void AddBird()
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
                    bool cageExists = CheckCageExists(package.Workbook.Worksheets["Cages"], cageSN);

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

                    // Validate species and subspecies
                    if (!validSpecies.Contains(species.ToLower()))
                    {
                        MessageBox.Show("Invalid species. Please select a valid species.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (species.ToLower() == "gouldian american" && !validSubspeciesAmerican.Contains(subSpecies.ToLower()))
                    {
                        MessageBox.Show("Invalid subspecies. Please select a valid subspecies for Gouldian American.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (species.ToLower() == "gouldian european" && !validSubspeciesEuropean.Contains(subSpecies.ToLower()))
                    {
                        MessageBox.Show("Invalid subspecies. Please select a valid subspecies for Gouldian European.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (species == "gouldian australian" && !validSubspeciesAustralian.Contains(subSpecies.ToLower()))
                    {
                        MessageBox.Show("Invalid subspecies. Please select a valid subspecies for Gouldian Australian.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!cageExists)
                    {
                        MessageBox.Show("Invalid Cage number. Please type the correct name or add a cage first if it does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Refresh the DataGridView to reflect the changes
                ShowBirds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddCage()
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Cages"];

                    // Get the values from the TextBoxes
                    string cageName = cageSnTbox.Text;
                    string height = heightTbox.Text;
                    string width = widthTbox.Text;
                    string length = lengthTbox.Text;
                    string cageType = materialCBox.Text;

                    // Validate the cage deminsions serial number
                    if (!IsDigitsOrDotOnly(height))
                    {
                        MessageBox.Show("Invalid height. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!IsDigitsOrDotOnly(width))
                    {
                        MessageBox.Show("Invalid width. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!IsDigitsOrDotOnly(length))
                    {
                        MessageBox.Show("Invalid length. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the Cages's serial number already exists in the worksheet
                    bool isSerialNumberUnique = IsSerialNumberUnique(worksheet, cageName);

                    if (!isSerialNumberUnique)
                    {
                        MessageBox.Show("Serial number already exists. Please enter a unique serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (IsSerialNumberCageType(cageName))
                    {
                        MessageBox.Show("Cage number is not valid. Please enter a new number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    // Find the next available row in the worksheet
                    int nextRow = worksheet.Dimension.Rows + 1;

                    // Write the values to the worksheet
                    worksheet.Cells[nextRow, 1].Value = cageName;
                    worksheet.Cells[nextRow, 2].Value = height;
                    worksheet.Cells[nextRow, 3].Value = width;
                    worksheet.Cells[nextRow, 4].Value = length;
                    worksheet.Cells[nextRow, 5].Value = cageType;


                    // Save the changes to the Excel file
                    package.Save();
                }

                MessageBox.Show("New cage data saved to Excel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView to reflect the changes
                ShowCages();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsWorksheetEmpty(ExcelWorksheet worksheet)
        {
            bool isEmpty = true;

            // Check if the worksheet contains any non-null cell value
            foreach (var cell in worksheet.Cells)
            {
                if (cell.Value != null)
                {
                    isEmpty = false;
                    break;
                }
            }

            return isEmpty;
        }

        private bool IsSerialNumberUnique(ExcelWorksheet worksheet, string serialNumber)
        {
            if (IsWorksheetEmpty(worksheet))
            {
                return true;
            }
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

        private bool IsSerialNumberCageType(string serialNumber)
        {
            serialNumber.ToLower();
            if (serialNumber == "wood" || serialNumber == "metal" || serialNumber == "plastic")
            {
                return true;
            }
            return false;
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
        private bool CheckCageExists(ExcelWorksheet worksheet, string serialNumber)
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

        private void birdBtn_Click(object sender, EventArgs e)
        {
            AddBird();
        }

        public void ShowBirds()
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Birds"];

                    DataTable dataTable = new DataTable();

                    // Loop through the rows and columns of the worksheet
                    for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        if (row == 1)
                        {
                            // Add column headers to the DataTable
                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                var cellValue = worksheet.Cells[row, col].Value;
                                dataTable.Columns.Add(cellValue != null ? cellValue.ToString() : "");
                            }
                        }
                        else
                        {
                            // Add data rows to the DataTable
                            DataRow dataRow = dataTable.NewRow();
                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                var cellValue = worksheet.Cells[row, col].Value;
                                dataRow[col - 1] = cellValue != null ? cellValue.ToString() : "";
                            }
                            dataTable.Rows.Add(dataRow);
                        }
                    }

                    // Bind the DataTable to the DataGridView
                    birdsGrid.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data from Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowCages()
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Cages"];

                    DataTable dataTable = new DataTable();

                    // Loop through the rows and columns of the worksheet
                    for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        if (row == 1)
                        {
                            // Add column headers to the DataTable
                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                var cellValue = worksheet.Cells[row, col].Value;
                                dataTable.Columns.Add(cellValue != null ? cellValue.ToString() : "");
                            }
                        }
                        else
                        {
                            // Add data rows to the DataTable
                            DataRow dataRow = dataTable.NewRow();
                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                var cellValue = worksheet.Cells[row, col].Value;
                                dataRow[col - 1] = cellValue != null ? cellValue.ToString() : "";
                            }
                            dataTable.Rows.Add(dataRow);
                        }
                    }

                    // Bind the DataTable to the DataGridView
                    cagesGrid.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data from Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cageBtn_Click(object sender, EventArgs e)
        {
            AddCage();
        }

        private void birdsearchBtn_Click(object sender, EventArgs e)
        {

            DataTable birdData = new DataTable();

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // Assuming the columns in the Excel sheet are: birdSN, species, hatchingDate, gender
                birdData.Columns.Add("birdSN", typeof(int));
                birdData.Columns.Add("species", typeof(string));
                birdData.Columns.Add("subspecies", typeof(string));
                birdData.Columns.Add("hatchingDate", typeof(DateTime));
                birdData.Columns.Add("gender", typeof(string));
                birdData.Columns.Add("fatherSN", typeof(string));
                birdData.Columns.Add("motherSN", typeof(string));

                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // Assuming data starts from row 2
                {
                    DataRow newRow = birdData.NewRow();
                    newRow["birdSN"] = worksheet.Cells[row, 1].Value.ToString(); // Assuming birdSN is in column 1
                    newRow["species"] = worksheet.Cells[row, 2].Value.ToString(); // Assuming species is in column 2
                    newRow["subspecies"] = worksheet.Cells[row, 3].Value.ToString(); // Assuming subspecies is in column 3
                    newRow["hatchingDate"] = DateTime.Parse(worksheet.Cells[row, 4].Value.ToString()); // Assuming hatchingDate is in column 4
                    newRow["gender"] = worksheet.Cells[row, 5].Value.ToString(); // Assuming gender is in column 5
                    newRow["fatherSN"] = worksheet.Cells[row, 6].Value.ToString(); // Assuming fatherSN is in column 6
                    newRow["motherSN"] = worksheet.Cells[row, 7].Value.ToString(); // Assuming motherSN is in column 1


                    birdData.Rows.Add(newRow);
                }
            }

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Birds"];

                    DataTable dataTable = new DataTable();

                    // Loop through the rows and columns of the worksheet
                    for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        if (row == 1)
                        {
                            // Add column headers to the DataTable
                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                var cellValue = worksheet.Cells[row, col].Value;
                                dataTable.Columns.Add(cellValue != null ? cellValue.ToString() : "");
                            }
                        }
                        else
                        {
                            // Add data rows to the DataTable
                            DataRow dataRow = dataTable.NewRow();
                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                var cellValue = worksheet.Cells[row, col].Value;
                                dataRow[col - 1] = cellValue != null ? cellValue.ToString() : "";
                            }
                            dataTable.Rows.Add(dataRow);
                        }
                    }

                    // Bind the DataTable to the DataGridView
                    birdsGrid.DataSource = dataTable;
                    birdsGrid.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data from Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Search by birdSN
            if (birdSNRadioBtn.Checked)
            {
                string birdSN = birdSearchTBox.Text;
                DataRow[] foundRows = birdData.Select($"birdSN = '{birdSN}'");
                if (foundRows.Length > 0)
                {
                    // Display the found rows in the DataGridView
                    DataTable searchResult = foundRows.CopyToDataTable();
                    birdsGrid.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Bird not found by birdSN");
                }
            }
            else if (speciesRadioBtn.Checked)
            {
                // Search by species
                string species = birdSearchTBox.Text;
                DataRow[] foundRows = birdData.Select($"species = '{species}'");
                if (foundRows.Length > 0)
                {
                    DataTable searchResult = foundRows.CopyToDataTable();
                    DataView searchResultView = searchResult.DefaultView;
                    searchResultView.Sort = "birdSN ASC"; // Sort by birdSN in ascending order
                    birdsGrid.DataSource = searchResultView;
                }
                else
                {
                    MessageBox.Show("Bird not found by species");
                }
            }
            else if (hatchingDateRadioBtn.Checked)
            {
                string hatchingDate = birdSearchTBox.Text;
                DateTime searchDate;

                if (DateTime.TryParseExact(hatchingDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out searchDate))
                {
                    DataRow[] foundRows = birdData.Select($"hatchingDate = #{searchDate.ToString("MM/dd/yyyy")}#");
                    if (foundRows.Length > 0)
                    {
                        DataTable searchResult = foundRows.CopyToDataTable();
                        DataView searchResultView = searchResult.DefaultView;
                        searchResultView.Sort = "birdSN ASC"; // Sort by birdSN in ascending order
                        birdsGrid.DataSource = searchResultView;
                    }
                    else
                    {
                        MessageBox.Show("Bird not found by hatching date");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid date format. Please enter a date in the format MM/dd/yyyy.");
                }
            }
            else if (genderRadioBtn.Checked)
            {
                // Search by gender
                string gender = birdSearchTBox.Text;
                DataRow[] foundRows = birdData.Select($"gender = '{gender}'");
                if (foundRows.Length > 0)
                {
                    DataTable searchResult = foundRows.CopyToDataTable();
                    DataView searchResultView = searchResult.DefaultView;
                    searchResultView.Sort = "birdSN ASC"; // Sort by birdSN in ascending order
                    birdsGrid.DataSource = searchResultView;
                }
                else
                {
                    MessageBox.Show("Bird not found by gender");
                }
            }
        }

        private void offspringBtn_Click(object sender, EventArgs e)
        {
            Offspring offspringForm = new Offspring();
            offspringForm.Show();
            if (birdsGrid.SelectedRows[0].Cells[4].Value.ToString() == "Male")
            {
                offspringForm.fatherSnTbox.Text = birdsGrid.SelectedRows[0].Cells[0].Value.ToString();
                offspringForm.fatherSnTbox.ReadOnly = true;
                offspringForm.cageNumTbox.Text = birdsGrid.SelectedRows[0].Cells[5].Value.ToString();
                offspringForm.cageNumTbox.ReadOnly = true;
                offspringForm.speciesTbox.Text = birdsGrid.SelectedRows[0].Cells[1].Value.ToString();
                offspringForm.speciesTbox.ReadOnly = true;
                offspringForm.subspeciesTbox.Text = birdsGrid.SelectedRows[0].Cells[2].Value.ToString();
                offspringForm.subspeciesTbox.ReadOnly = true;
            }
            else
            {
                offspringForm.motherSnTbox.Text = birdsGrid.SelectedRows[0].Cells[0].Value.ToString();
                offspringForm.motherSnTbox.ReadOnly = true;
                offspringForm.cageNumTbox.Text = birdsGrid.SelectedRows[0].Cells[5].Value.ToString();
                offspringForm.cageNumTbox.ReadOnly = true;
                offspringForm.speciesTbox.Text = birdsGrid.SelectedRows[0].Cells[1].Value.ToString();
                offspringForm.speciesTbox.ReadOnly = true;
                offspringForm.subspeciesTbox.Text = birdsGrid.SelectedRows[0].Cells[2].Value.ToString();
                offspringForm.subspeciesTbox.ReadOnly = true;
            }
            if (offspringForm.birdSnTbox.Text == "") offspringForm.snELabel.Visible = true;
            if (offspringForm.genderCbox.Text == "") offspringForm.genderLa.Visible = true;
            if (offspringForm.fatherSnTbox.Text == "") offspringForm.fatherELabel.Visible = true;
            if (offspringForm.motherSnTbox.Text == "") offspringForm.motherELabel.Visible = true;

            //offspringForm.motherSnTbox.Text = birdsGrid.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private bool changesMade = false;
        // Create a dictionary to store the changes
        private Dictionary<Tuple<int, int>, string> cellChanges = new Dictionary<Tuple<int, int>, string>();

        // Handle the CellEndEdit event of the DataGridView
        private void birdsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the row index, column index, and the new value
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            string newValue = birdsGrid.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            // Create a unique key for the cell using its row index and column index
            Tuple<int, int> cellKey = new Tuple<int, int>(rowIndex, columnIndex);

            // Update the dictionary with the new value or add a new entry if it doesn't exist
            if (cellChanges.ContainsKey(cellKey))
            {
                cellChanges[cellKey] = newValue;
            }
            else
            {
                cellChanges.Add(cellKey, newValue);
            }

            // Set the flag indicating that changes have been made
            changesMade = true;
        }

        // Handle the Click event of the Save Changes button
        private void changesBtn_Click(object sender, EventArgs e)
        {
            if (cellChanges.Count > 0)
            {
                try
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets["Birds"];

                        // Apply the changes to the worksheet
                        foreach (var change in cellChanges)
                        {
                            int rowIndex = change.Key.Item1;
                            int columnIndex = change.Key.Item2;
                            string newValue = change.Value;

                            // Update the cell value in the worksheet
                            worksheet.Cells[rowIndex + 2, columnIndex + 1].Value = newValue;
                        }

                        // Save the changes to the Excel file
                        package.Save();
                    }

                    MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the dictionary of cell changes
                    cellChanges.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No changes have been made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cagesSearchBtn_Click(object sender, EventArgs e)
        {
            string searchValue = cagesSearchTbox.Text.Trim().ToLower();
            DataTable searchData = new DataTable();

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Cages"];

                // Assuming the columns in the Excel sheet are: cageSN, height, width, length, cageType
                searchData.Columns.Add("cageSN", typeof(string));
                searchData.Columns.Add("height", typeof(string));
                searchData.Columns.Add("width", typeof(string));
                searchData.Columns.Add("length", typeof(string));
                searchData.Columns.Add("cageType", typeof(string));

                int rowCount = worksheet.Dimension.Rows;

                if (cagesRadioBtn.Checked)
                {
                    for (int row = 2; row <= rowCount; row++)
                    {
                        string cageSN = worksheet.Cells[row, 1].Value?.ToString()?.ToLower();
                        string cageType = worksheet.Cells[row, 5].Value?.ToString()?.ToLower();

                        if (cageSN.Contains(searchValue))
                        {
                            DataRow dataRow = searchData.NewRow();
                            dataRow["cageSN"] = cageSN;
                            dataRow["height"] = worksheet.Cells[row, 2].Value?.ToString();
                            dataRow["width"] = worksheet.Cells[row, 3].Value?.ToString();
                            dataRow["length"] = worksheet.Cells[row, 4].Value?.ToString();
                            dataRow["cageType"] = cageType;
                            searchData.Rows.Add(dataRow);
                            cageBirdsListView(cageSN);
                        }
                    }
                }
                else if (cageMaterialRadioBtn.Checked)
                {
                    for (int row = 2; row <= rowCount; row++)
                    {
                        string cageSN = worksheet.Cells[row, 1].Value?.ToString()?.ToLower();
                        string cageType = worksheet.Cells[row, 5].Value?.ToString()?.ToLower();

                        if (cageType.Contains(searchValue))
                        {
                            DataRow dataRow = searchData.NewRow();
                            dataRow["cageSN"] = cageSN;
                            dataRow["height"] = worksheet.Cells[row, 2].Value?.ToString();
                            dataRow["width"] = worksheet.Cells[row, 3].Value?.ToString();
                            dataRow["length"] = worksheet.Cells[row, 4].Value?.ToString();
                            dataRow["cageType"] = cageType;
                            searchData.Rows.Add(dataRow);
                        }
                    }
                }
            }

            DisplayCageSearchResults(searchData);
        }

        private void DisplayCageSearchResults(DataTable data)
        {
            // Sort the search results by cageSN
            DataView sortedView = data.DefaultView;
            sortedView.Sort = "cageSN ASC";
            DataTable sortedData = sortedView.ToTable();

            // Bind the sorted search results to the DataGridView
            cagesGrid.DataSource = sortedData;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void applyChangesCages_Click(object sender, EventArgs e)
        {
            if (cellChanges.Count > 0)
            {
                try
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets["Cages"];

                        // Apply the changes to the worksheet
                        foreach (var change in cellChanges)
                        {
                            int rowIndex = change.Key.Item1;
                            int columnIndex = change.Key.Item2;
                            string newValue = change.Value;

                            // Update the cell value in the worksheet
                            worksheet.Cells[rowIndex + 2, columnIndex + 1].Value = newValue;
                        }

                        // Save the changes to the Excel file
                        package.Save();
                    }

                    MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the dictionary of cell changes
                    cellChanges.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No changes have been made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cagesGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the row index, column index, and the new value
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            string newValue = cagesGrid.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            // Create a unique key for the cell using its row index and column index
            Tuple<int, int> cellKey = new Tuple<int, int>(rowIndex, columnIndex);

            // Update the dictionary with the new value or add a new entry if it doesn't exist
            if (cellChanges.ContainsKey(cellKey))
            {
                cellChanges[cellKey] = newValue;
            }
            else
            {
                cellChanges.Add(cellKey, newValue);
            }

            // Set the flag indicating that changes have been made

        }

        private void CagesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row index is selected
            {
                DataGridViewRow selectedRow = cagesGrid.Rows[e.RowIndex];

                // Get the selected cage serial number from the first cell in the selected row
                string cageSerialNum = selectedRow.Cells[0].Value.ToString();

                // Call the cageBirdsListView function with the selected cage serial number
                cageBirdsListView(cageSerialNum);
            }
        }
        private void cageBirdsListView(string cellValue)
        {
            // Clear the existing items in the ListView
            cageBirdsList.Items.Clear();

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Birds"];

                int rowCount = worksheet.Dimension.Rows;

                List<ListViewItem> items = new List<ListViewItem>(); // Create a list to hold the ListView items

                for (int row = 2; row <= rowCount; row++)
                {
                    string birdCageSN = worksheet.Cells[row, 6].Value?.ToString()?.ToLower();

                    if (birdCageSN == cellValue.ToLower())
                    {
                        string birdSN = worksheet.Cells[row, 1].Value?.ToString();
                        string birdSpecies = worksheet.Cells[row, 2].Value?.ToString();
                        string birdSubspecies = worksheet.Cells[row, 3].Value?.ToString();
                        string birdDate = worksheet.Cells[row, 4].Value?.ToString();
                        string birdGender = worksheet.Cells[row, 5].Value?.ToString();
                        string birdFather = worksheet.Cells[row, 6].Value?.ToString();
                        string birdMother = worksheet.Cells[row, 7].Value?.ToString();

                        // Create a new ListViewItem with the bird details
                        ListViewItem item = new ListViewItem(new[] { birdSN, birdSpecies, birdSubspecies, birdDate, birdGender, birdFather, birdMother });

                        items.Add(item); // Add the item to the list
                    }
                }

                // Sort the items based on birdSN
                items.Sort((x, y) => string.Compare(x.SubItems[0].Text, y.SubItems[0].Text));

                // Add the sorted items to the ListView
                cageBirdsList.Items.AddRange(items.ToArray());

                cageBirdsList.Refresh();
                cageBirdsList.Show();
            }
        }        
    }
}
