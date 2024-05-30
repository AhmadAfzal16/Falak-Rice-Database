using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SalesManagementApp
{
    public partial class MainForm : Form
    {
        private IMongoCollection<BsonDocument> _ordersCollection;

        public MainForm()
        {
            InitializeComponent();
            InitializeMongoDB();
            dgvOrders.ColumnCount = 5;
            dgvOrders.Columns[0].Name = "OrderId";
            dgvOrders.Columns[1].Name = "customerId";
            dgvOrders.Columns[2].Name = "orderDate";
            dgvOrders.Columns[3].Name = "totalAmount";
            dgvOrders.Columns[4].Name = "status";
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Al_Fatah_Rice"); // Replace "YourDatabaseName" with your actual database name
            _ordersCollection = database.GetCollection<BsonDocument>("orders");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // View all orders
            var orders = _ordersCollection.Find(new BsonDocument()).ToList();
            DisplayOrders(orders);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search for an order
            var filter = Builders<BsonDocument>.Filter.Eq("orderId", txtSearchOrderId.Text);
            var order = _ordersCollection.Find(filter).FirstOrDefault();
            if (order != null)
            {
                var orders = new List<BsonDocument> { order };
                DisplayOrders(orders);
            }
            else
            {
                MessageBox.Show("Order not found!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add a new order
            var order = new BsonDocument
            {
                { "orderId", txtOrderId.Text },
                { "customerId", txtCustomerId.Text },
                { "orderDate", DateTime.UtcNow },
                { "totalAmount", Convert.ToDouble(txtTotalAmount.Text) },
                { "status", txtStatus.Text }
            };

            _ordersCollection.InsertOne(order);
            MessageBox.Show("Order added successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete an order
            var filter = Builders<BsonDocument>.Filter.Eq("orderId", txtDeleteOrderId.Text);
            var result = _ordersCollection.DeleteOne(filter);
            if (result.DeletedCount > 0)
            {
                MessageBox.Show("Order deleted successfully!");
            }
            else
            {
                MessageBox.Show("Order not found!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update an order
            var filter = Builders<BsonDocument>.Filter.Eq("orderId", txtUpdateOrderId.Text);
            var update = Builders<BsonDocument>.Update
                .Set("customerId", txtUpdateCustomerId.Text)
                .Set("orderDate", DateTime.UtcNow)
                .Set("totalAmount", Convert.ToDouble(txtUpdateTotalAmount.Text))
                .Set("status", txtUpdateStatus.Text);
            var result = _ordersCollection.UpdateOne(filter, update);
            if (result.ModifiedCount > 0)
            {
                MessageBox.Show("Order updated successfully!");
            }
            else
            {
                MessageBox.Show("Order not found!");
            }
        }

        private void DisplayOrders(List<BsonDocument> orders)
        {
            // Display orders in DataGridView
            dgvOrders.Rows.Clear();
            foreach (var order in orders)
            {
                dgvOrders.Rows.Add(
                    order.GetValue("orderId"),
                    order.GetValue("customerId"),
                    order.GetValue("orderDate"),
                    order.GetValue("totalAmount"),
                    order.GetValue("status")
                );
            }
        }

        private void lblUpdateCustomerId_Click(object sender, EventArgs e)
        {

        }

        private void lblUpdateStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerId_Click(object sender, EventArgs e)
        {

        }

        private void lblOrderId_Click(object sender, EventArgs e)
        {

        }

        private void lblUpdateCustomerId_Click_1(object sender, EventArgs e)
        {

        }

        private void lblUpdateOrderId_Click(object sender, EventArgs e)
        {

        }
    }
}
