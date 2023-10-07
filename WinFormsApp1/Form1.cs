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
        public Form1()
        {
            InitializeComponent();
        }
        public class StockData
        {
            public string Ticker { get; set; }
            public DateTime Date { get; set; }
            public decimal Open { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Close { get; set; }
            public long Volume { get; set; }
        }

        string folderPath = "";

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

        private void getInfoButton_Click(object sender, EventArgs e)
        {

        }
    }
}