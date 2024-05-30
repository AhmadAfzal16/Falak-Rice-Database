using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SalesManagementApp
{
    public partial class MainForm : Form
    {
        private IMongoCollection<BsonDocument> _productsCollection;

        public MainForm()
        {
            InitializeComponent();
            InitializeMongoDB();
            dgvProducts.ColumnCount = 7;
            dgvProducts.Columns[0].Name = "productId";
            dgvProducts.Columns[1].Name = "name";
            dgvProducts.Columns[2].Name = "description";
            dgvProducts.Columns[3].Name = "price";
            dgvProducts.Columns[4].Name = "quantityInStock";
            dgvProducts.Columns[5].Name = "supplierId";
            dgvProducts.Columns[6].Name = "dateAddedUpdated";
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Al_Fatah_Rice");
            _productsCollection = database.GetCollection<BsonDocument>("products");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add new product
            var product = new BsonDocument
            {
                { "productId", txtProductId.Text },
                { "name", txtName.Text },
                { "description", txtDescription.Text },
                { "price", Convert.ToDouble(txtPrice.Text) },
                { "quantityInStock", Convert.ToInt32(txtQuantityInStock.Text) },
                { "supplierId", txtSupplierId.Text },
                { "dateAddedUpdated", DateTime.UtcNow }
            };

            _productsCollection.InsertOne(product);
            MessageBox.Show("Product added successfully!");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // View all products
            var products = _productsCollection.Find(new BsonDocument()).ToList();
            DisplayProducts(products);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search for a product
            var filter = Builders<BsonDocument>.Filter.Eq("productId", txtSearchProductId.Text);
            var product = _productsCollection.Find(filter).FirstOrDefault();
            if (product != null)
            {
                var products = new List<BsonDocument> { product };
                DisplayProducts(products);
            }
            else
            {
                MessageBox.Show("Product not found!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete a product
            var filter = Builders<BsonDocument>.Filter.Eq("productId", txtDeleteProductId.Text);
            var result = _productsCollection.DeleteOne(filter);
            if (result.DeletedCount > 0)
            {
                MessageBox.Show("Product deleted successfully!");
            }
            else
            {
                MessageBox.Show("Product not found!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update a product
            var filter = Builders<BsonDocument>.Filter.Eq("productId", txtUpdateProductId.Text);
            var update = Builders<BsonDocument>.Update
                .Set("name", txtName.Text)
                .Set("description", txtDescription.Text)
                .Set("price", Convert.ToDouble(txtPrice.Text))
                .Set("quantityInStock", Convert.ToInt32(txtQuantityInStock.Text))
                .Set("supplierId", txtSupplierId.Text)
                .Set("dateAddedUpdated", DateTime.UtcNow);
            var result = _productsCollection.UpdateOne(filter, update);
            if (result.ModifiedCount > 0)
            {
                MessageBox.Show("Product updated successfully!");
            }
            else
            {
                MessageBox.Show("Product not found!");
            }
        }

        private void DisplayProducts(List<BsonDocument> products)
        {
            // Display products in DataGridView
            dgvProducts.Rows.Clear();
            foreach (var product in products)
            {
                dgvProducts.Rows.Add(
                    product.GetValue("productId"),
                    product.GetValue("name"),
                    product.GetValue("description"),
                    product.GetValue("price"),
                    product.GetValue("quantityInStock"),
                    product.GetValue("supplierId"),
                    product.GetValue("dateAddedUpdated")
                );
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
