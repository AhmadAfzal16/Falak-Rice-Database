using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SalesManagementApp
{
    public partial class MainForm : Form
    {
        private IMongoCollection<BsonDocument> _salesCollection;

        public MainForm()
        {
            InitializeComponent();
            InitializeMongoDB();
            InitializeDataGridView();
        }


        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Al_Fatah_Rice");
            _salesCollection = database.GetCollection<BsonDocument>("Sales");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add new sale
            var sale = new BsonDocument
            {
                { "saleId", txtSaleId.Text },
                { "productId", txtProductId.Text },
                { "quantitySold", Convert.ToInt32(txtQuantity.Text) },
                { "saleDate", DateTime.UtcNow },
                { "totalSaleAmount", Convert.ToDouble(txtTotalAmount.Text) }
            };

            _salesCollection.InsertOne(sale);
            MessageBox.Show("Sale added successfully!");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // View all sales
            var sales = _salesCollection.Find(new BsonDocument()).ToList();
            DisplaySales(sales);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search for a sale
            var filter = Builders<BsonDocument>.Filter.Eq("saleId", txtSearchSaleId.Text);
            var sale = _salesCollection.Find(filter).FirstOrDefault();
            if (sale != null)
            {
                var sales = new List<BsonDocument> { sale };
                DisplaySales(sales);
            }
            else
            {
                MessageBox.Show("Sale not found!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete a sale
            var filter = Builders<BsonDocument>.Filter.Eq("saleId", txtDeleteSaleId.Text);
            var result = _salesCollection.DeleteOne(filter);
            if (result.DeletedCount > 0)
            {
                MessageBox.Show("Sale deleted successfully!");
            }
            else
            {
                MessageBox.Show("Sale not found!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update a sale
            var filter = Builders<BsonDocument>.Filter.Eq("saleId", txtUpdateSaleId.Text);
            var update = Builders<BsonDocument>.Update
                .Set("productId", txtUpdateProductId.Text)
                .Set("quantitySold", Convert.ToInt32(txtUpdateQuantity.Text))
                .Set("saleDate", DateTime.UtcNow)
                .Set("totalSaleAmount", Convert.ToDouble(txtUpdateTotalAmount.Text));
            var result = _salesCollection.UpdateOne(filter, update);
            if (result.ModifiedCount > 0)
            {
                MessageBox.Show("Sale updated successfully!");
            }
            else
            {
                MessageBox.Show("Sale not found!");
            }
        }

        private void DisplaySales(List<BsonDocument> sales)
        {
            dgvSales.Rows.Clear();
            foreach (var sale in sales)
            {
                if (sale != null)
                {
                    dgvSales.Rows.Add(
                        sale.GetValue("saleId")?.AsString,
                        sale.GetValue("productId")?.AsString,
                        sale.GetValue("quantitySold")?.AsInt32,
                        sale.GetValue("saleDate")?.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"),
                        sale.GetValue("totalSaleAmount")?.AsDouble
                    );
                }
            }
        }
        private void InitializeDataGridView()
        {
            dgvSales.Columns.Clear(); // Clear existing columns (if any)

            // Add columns to the DataGridView
            dgvSales.Columns.Add("saleId", "Sale ID");
            dgvSales.Columns.Add("productId", "Product ID");
            dgvSales.Columns.Add("quantitySold", "Quantity Sold");
            dgvSales.Columns.Add("saleDate", "Sale Date");
            dgvSales.Columns.Add("totalSaleAmount", "Total Sale Amount");

            // Optionally, you can set column properties such as width, read-only, etc., if needed
            dgvSales.Columns["saleId"].Width = 100;
            dgvSales.Columns["productId"].Width = 100;
            dgvSales.Columns["quantitySold"].Width = 100;
            dgvSales.Columns["saleDate"].Width = 150;
            dgvSales.Columns["totalSaleAmount"].Width = 120;
            // Set other column properties as needed
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblDeleteSaleId_Click(object sender, EventArgs e)
        {

        }

        // Other event handlers and methods
    }

}

