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
            public string Period { get; set; } = "";
            public DateTime Date { get; set; }
            public decimal Open { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Close { get; set; }
            public long Volume { get; set; }
        }

        string folderPath = "";

        // This function opens file browser to select CSV folder
        private void getFileButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                // Set the file filter to limit selection to CSV files
                openFileDialog.Filter = "CSV Files|*.csv";
                openFileDialog.Title = "Select a CSV File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string filePath = openFileDialog.FileName;

                    // Read the selected CSV file
                    List<StockData> allStockData = ReadCSVFile(filePath);

                    // Get the selected start date from the UI control (replace with the actual control you're using)
                    DateTime startDate = startTimePicker.Value;

                    // Get the selected end date from the UI control (replace with the actual control you're using)
                    DateTime endDate = endTimePicker.Value;

                    // Apply filtering and sorting
                    List<StockData> filteredData = FilterAndSortStockData(allStockData, startDate, endDate);

                    // Display the filtered and sorted data in the DataGridView
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
        public List<StockData> FilterAndSortStockData(List<StockData> data, DateTime startDate, DateTime endDate)
        {
            // Filter the data based on date
            List<StockData> filteredData = data
                .Where(stock => stock.Date >= startDate && stock.Date <= endDate)
                .ToList();

            // Sort the filtered data by date
            filteredData.Sort((a, b) => a.Date.CompareTo(b.Date));

            return filteredData;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of the DataGridView to release resources
            dataGridViewResults?.Dispose();
        }
    }
}