using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Declare DataGridView as a class-level variable
        private DataGridView? dataGridViewResults;
        public Form1()
        {
            InitializeComponent();
            // Initialize the DataGridView and add it to the form's controls
            dataGridViewResults = new DataGridView();
            dataGridViewResults.Dock = DockStyle.Fill; // Adjust to your layout needs
            this.Controls.Add(dataGridViewResults);
        }
        public class StockData
        {
            public string Ticker { get; set; } = "";
            public DateTime Date { get; set; }
            public decimal Open { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Close { get; set; }
            public long Volume { get; set; }
            public string Interval { get; set; } = "";
        }

        string folderPath = "";

        // This function opens file browser to select CSV folder
        private void getFileButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                // Show the folder selection dialog
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Get the selected folder path and set it as folderPath
                    folderPath = folderBrowserDialog.SelectedPath;

                    // Display the selected folder path in a TextBox or Label, if needed
                    //textBoxFolderPath.Text = folderPath;
                }
            }
        }

        // This function stores user date from from in order to sort stock data
        private void getInfoButton_Click(object sender, EventArgs e)
        {
            string? selectedTicker = tickerSelectionBox.SelectedItem?.ToString();
            string selectedInterval = GetSelectedInterval(); // Implement this function to get the selected interval
            DateTime startDate = startTimePicker.Value;
            DateTime endDate = endTimePicker.Value;

            // Call CSV Folder Reading method to get data
            List<StockData> allStockData = ReadCSVFolder(folderPath);

            // Ensure selectedTicker is not null before passing it to the method
            if (selectedTicker != null)
            {
                // Filter and sort the data based on user-selected values
                List<StockData> filteredData = FilterAndSortStockData(allStockData, selectedTicker, selectedInterval, startDate, endDate);

                // Set the data source property of the data grid view to the filtered data
                // Check if dataGridViewResults is not null before setting its DataSource
                if (dataGridViewResults != null)
                {
                    dataGridViewResults.DataSource = filteredData;
                }
                else
                {
                    // Handle the case when dataGridViewResults is null
                    MessageBox.Show("The DataGridView is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle the case when selectedTicker is null
                MessageBox.Show("Please select a ticker.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Implement this function to get the selected interval from the RadioButton group
        private string GetSelectedInterval()
        {
            if (rbuttonDaily.Checked)
            {
                return "Daily";
            }
            else if (rbuttonWeekly.Checked)
            {
                return "Weekly";
            }
            else if (rbuttonMonthly.Checked)
            {
                return "Monthly";
            }
            else
            {
                // Handle the case when no interval is selected
                return string.Empty;
            }
        }

        public List<StockData> ReadCSVFile(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    return csv.GetRecords<StockData>().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<StockData>(); // Return an empty list on error
            }
        }
        public List<StockData> FilterAndSortStockData(List<StockData> data, string ticker, string interval, DateTime startDate, DateTime endDate)
        {
            // Filter the data by ticker, interval, and date range
            List<StockData> filteredData = data
                .Where(stock =>
                    stock.Ticker == ticker &&
                    stock.Interval == interval &&
                    stock.Date >= startDate &&
                    stock.Date <= endDate)
                .ToList();

            // Sort the filtered data by date
            filteredData.Sort((a, b) => a.Date.CompareTo(b.Date));

            return filteredData;
        }

        public List<StockData> ReadCSVFolder(string folderPath)
        {
            List<StockData> allStockData = new List<StockData>();

            try
            {
                // Get a list of all CSV file paths in the folder
                string[] csvFiles = Directory.GetFiles(folderPath, "*.csv");

                foreach (string file in csvFiles)
                {
                    // Read each CSV file and add its contents to the list
                    List<StockData> stockDataFromFile = ReadCSVFile(file);
                    allStockData.AddRange(stockDataFromFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading CSV folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return allStockData;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of the DataGridView to release resources
            dataGridViewResults?.Dispose();
        }
    }
}