namespace InventoryManagementApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnView = new Button();
            dgvInventory = new DataGridView();
            lblLogId = new Label();
            txtLogId = new TextBox();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblAction = new Label();
            txtAction = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblTimestamp = new Label();
            txtTimestamp = new TextBox();
            btnAdd = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.BackColor = Color.Black;
            btnView.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(551, 223);
            btnView.Margin = new Padding(4, 3, 4, 3);
            btnView.Name = "btnView";
            btnView.Size = new Size(88, 27);
            btnView.TabIndex = 0;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.BackgroundColor = Color.Black;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(725, 223);
            dgvInventory.Margin = new Padding(4, 3, 4, 3);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(539, 346);
            dgvInventory.TabIndex = 1;
            // 
            // lblLogId
            // 
            lblLogId.AutoSize = true;
            lblLogId.BackColor = Color.Black;
            lblLogId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLogId.ForeColor = Color.White;
            lblLogId.Location = new Point(168, 223);
            lblLogId.Margin = new Padding(4, 0, 4, 0);
            lblLogId.Name = "lblLogId";
            lblLogId.Size = new Size(46, 15);
            lblLogId.TabIndex = 2;
            lblLogId.Text = "Log ID:";
            // 
            // txtLogId
            // 
            txtLogId.Location = new Point(257, 223);
            txtLogId.Margin = new Padding(4, 3, 4, 3);
            txtLogId.Name = "txtLogId";
            txtLogId.Size = new Size(181, 23);
            txtLogId.TabIndex = 3;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.BackColor = Color.Black;
            lblProductId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProductId.ForeColor = Color.White;
            lblProductId.Location = new Point(168, 263);
            lblProductId.Margin = new Padding(4, 0, 4, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(70, 15);
            lblProductId.TabIndex = 4;
            lblProductId.Text = "Product ID:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(257, 263);
            txtProductId.Margin = new Padding(4, 3, 4, 3);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(181, 23);
            txtProductId.TabIndex = 5;
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.BackColor = Color.Black;
            lblAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAction.ForeColor = Color.White;
            lblAction.Location = new Point(168, 306);
            lblAction.Margin = new Padding(4, 0, 4, 0);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(46, 15);
            lblAction.TabIndex = 6;
            lblAction.Text = "Action:";
            // 
            // txtAction
            // 
            txtAction.Location = new Point(257, 306);
            txtAction.Margin = new Padding(4, 3, 4, 3);
            txtAction.Name = "txtAction";
            txtAction.Size = new Size(181, 23);
            txtAction.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Black;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(168, 347);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(58, 15);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(257, 347);
            txtQuantity.Margin = new Padding(4, 3, 4, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(181, 23);
            txtQuantity.TabIndex = 9;
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.BackColor = Color.Black;
            lblTimestamp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTimestamp.ForeColor = Color.White;
            lblTimestamp.Location = new Point(168, 389);
            lblTimestamp.Margin = new Padding(4, 0, 4, 0);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(72, 15);
            lblTimestamp.TabIndex = 10;
            lblTimestamp.Text = "Timestamp:";
            // 
            // txtTimestamp
            // 
            txtTimestamp.Location = new Point(257, 389);
            txtTimestamp.Margin = new Padding(4, 3, 4, 3);
            txtTimestamp.Name = "txtTimestamp";
            txtTimestamp.Size = new Size(181, 23);
            txtTimestamp.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(168, 447);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(551, 300);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 27);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(551, 377);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(350, 447);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(614, 101);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 16;
            label1.Text = "INVENTORY";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1263, 663);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(txtTimestamp);
            Controls.Add(lblTimestamp);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtAction);
            Controls.Add(lblAction);
            Controls.Add(txtProductId);
            Controls.Add(lblProductId);
            Controls.Add(txtLogId);
            Controls.Add(lblLogId);
            Controls.Add(dgvInventory);
            Controls.Add(btnView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblLogId;
        private System.Windows.Forms.TextBox txtLogId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.TextBox txtTimestamp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private Label label1;
    }
}
