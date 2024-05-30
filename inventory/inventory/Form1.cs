using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace InventoryManagementApp
{
    public partial class MainForm : Form
    {
        private IMongoCollection<BsonDocument> _inventoryCollection;

        public MainForm()
        {
            InitializeComponent();
            InitializeMongoDB();
            dgvInventory.ColumnCount = 5;
            dgvInventory.Columns[0].Name = "LogId";
            dgvInventory.Columns[1].Name = "ProductId";
            dgvInventory.Columns[2].Name = "Action";
            dgvInventory.Columns[3].Name = "Quantity";
            dgvInventory.Columns[4].Name = "Timestamp";
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Al_Fatah_Rice"); // Replace with your actual database name
            _inventoryCollection = database.GetCollection<BsonDocument>("inventory");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // View all inventory logs
            var logs = _inventoryCollection.Find(new BsonDocument()).ToList();
            DisplayLogs(logs);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search for an inventory log
            var filter = Builders<BsonDocument>.Filter.Eq("logId", txtLogId.Text);
            var log = _inventoryCollection.Find(filter).FirstOrDefault();
            if (log != null)
            {
                var logs = new List<BsonDocument> { log };
                DisplayLogs(logs);
            }
            else
            {
                MessageBox.Show("Log not found!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add a new inventory log
            var log = new BsonDocument
            {
                { "logId", txtLogId.Text },
                { "productId", txtProductId.Text },
                { "action", txtAction.Text },
                { "quantity", Convert.ToInt32(txtQuantity.Text) },
                { "timestamp", DateTime.UtcNow }
            };

            _inventoryCollection.InsertOne(log);
            MessageBox.Show("Log added successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete an inventory log
            var filter = Builders<BsonDocument>.Filter.Eq("logId", txtLogId.Text);
            var result = _inventoryCollection.DeleteOne(filter);
            if (result.DeletedCount > 0)
            {
                MessageBox.Show("Log deleted successfully!");
            }
            else
            {
                MessageBox.Show("Log not found!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update an inventory log
            var filter = Builders<BsonDocument>.Filter.Eq("logId", txtLogId.Text);
            var update = Builders<BsonDocument>.Update
                .Set("productId", txtProductId.Text)
                .Set("action", txtAction.Text)
                .Set("quantity", Convert.ToInt32(txtQuantity.Text))
                .Set("timestamp", DateTime.UtcNow);
            var result = _inventoryCollection.UpdateOne(filter, update);
            if (result.ModifiedCount > 0)
            {
                MessageBox.Show("Log updated successfully!");
            }
            else
            {
                MessageBox.Show("Log not found!");
            }
        }

        private void DisplayLogs(List<BsonDocument> logs)
        {
            // Display inventory logs in DataGridView
            dgvInventory.Rows.Clear();
            foreach (var log in logs)
            {
                dgvInventory.Rows.Add(
                    log.GetValue("logId"),
                    log.GetValue("productId"),
                    log.GetValue("action"),
                    log.GetValue("quantity"),
                    log.GetValue("timestamp")
                );
            }
        }
    }
}
