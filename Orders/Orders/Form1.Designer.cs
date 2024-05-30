namespace SalesManagementApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnView = new Button();
            dgvOrders = new DataGridView();
            lblSearchOrderId = new Label();
            txtSearchOrderId = new TextBox();
            btnSearch = new Button();
            lblDeleteOrderId = new Label();
            txtDeleteOrderId = new TextBox();
            btnDelete = new Button();
            lblUpdateOrderId = new Label();
            txtUpdateOrderId = new TextBox();
            lblUpdateCustomerId = new Label();
            txtUpdateCustomerId = new TextBox();
            lblUpdateTotalAmount = new Label();
            txtUpdateTotalAmount = new TextBox();
            lblUpdateStatus = new Label();
            txtUpdateStatus = new TextBox();
            btnUpdate = new Button();
            lblOrderId = new Label();
            txtOrderId = new TextBox();
            lblCustomerId = new Label();
            txtCustomerId = new TextBox();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            lblStatus = new Label();
            txtStatus = new TextBox();
            btnAdd = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ActiveCaptionText;
            btnView.ForeColor = SystemColors.ButtonHighlight;
            btnView.Location = new Point(422, 576);
            btnView.Margin = new Padding(4);
            btnView.Name = "btnView";
            btnView.Size = new Size(88, 26);
            btnView.TabIndex = 0;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.BackgroundColor = SystemColors.ButtonHighlight;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(422, 178);
            dgvOrders.Margin = new Padding(4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(533, 346);
            dgvOrders.TabIndex = 1;
            // 
            // lblSearchOrderId
            // 
            lblSearchOrderId.AutoSize = true;
            lblSearchOrderId.Location = new Point(676, 553);
            lblSearchOrderId.Margin = new Padding(4, 0, 4, 0);
            lblSearchOrderId.Name = "lblSearchOrderId";
            lblSearchOrderId.Size = new Size(59, 15);
            lblSearchOrderId.TabIndex = 2;
            lblSearchOrderId.Text = "Order ID:";
            // 
            // txtSearchOrderId
            // 
            txtSearchOrderId.Location = new Point(743, 550);
            txtSearchOrderId.Margin = new Padding(4);
            txtSearchOrderId.Name = "txtSearchOrderId";
            txtSearchOrderId.Size = new Size(116, 23);
            txtSearchOrderId.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaptionText;
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(868, 548);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 26);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblDeleteOrderId
            // 
            lblDeleteOrderId.AutoSize = true;
            lblDeleteOrderId.Location = new Point(676, 587);
            lblDeleteOrderId.Margin = new Padding(4, 0, 4, 0);
            lblDeleteOrderId.Name = "lblDeleteOrderId";
            lblDeleteOrderId.Size = new Size(59, 15);
            lblDeleteOrderId.TabIndex = 5;
            lblDeleteOrderId.Text = "Order ID:";
            // 
            // txtDeleteOrderId
            // 
            txtDeleteOrderId.Location = new Point(743, 585);
            txtDeleteOrderId.Margin = new Padding(4);
            txtDeleteOrderId.Name = "txtDeleteOrderId";
            txtDeleteOrderId.Size = new Size(116, 23);
            txtDeleteOrderId.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaptionText;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(868, 582);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 26);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblUpdateOrderId
            // 
            lblUpdateOrderId.AutoSize = true;
            lblUpdateOrderId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdateOrderId.Location = new Point(1016, 186);
            lblUpdateOrderId.Margin = new Padding(4, 0, 4, 0);
            lblUpdateOrderId.Name = "lblUpdateOrderId";
            lblUpdateOrderId.Size = new Size(59, 15);
            lblUpdateOrderId.TabIndex = 8;
            lblUpdateOrderId.Text = "Order ID:";
            lblUpdateOrderId.Click += lblUpdateOrderId_Click;
            // 
            // txtUpdateOrderId
            // 
            txtUpdateOrderId.Location = new Point(1107, 178);
            txtUpdateOrderId.Margin = new Padding(4);
            txtUpdateOrderId.Name = "txtUpdateOrderId";
            txtUpdateOrderId.Size = new Size(149, 23);
            txtUpdateOrderId.TabIndex = 9;
            // 
            // lblUpdateCustomerId
            // 
            lblUpdateCustomerId.AutoSize = true;
            lblUpdateCustomerId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdateCustomerId.Location = new Point(1016, 217);
            lblUpdateCustomerId.Margin = new Padding(4, 0, 4, 0);
            lblUpdateCustomerId.Name = "lblUpdateCustomerId";
            lblUpdateCustomerId.Size = new Size(80, 15);
            lblUpdateCustomerId.TabIndex = 10;
            lblUpdateCustomerId.Text = "Customer ID:";
            lblUpdateCustomerId.Click += lblUpdateCustomerId_Click_1;
            // 
            // txtUpdateCustomerId
            // 
            txtUpdateCustomerId.Location = new Point(1107, 212);
            txtUpdateCustomerId.Margin = new Padding(4);
            txtUpdateCustomerId.Name = "txtUpdateCustomerId";
            txtUpdateCustomerId.Size = new Size(149, 23);
            txtUpdateCustomerId.TabIndex = 11;
            // 
            // lblUpdateTotalAmount
            // 
            lblUpdateTotalAmount.AutoSize = true;
            lblUpdateTotalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdateTotalAmount.Location = new Point(1016, 247);
            lblUpdateTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblUpdateTotalAmount.Name = "lblUpdateTotalAmount";
            lblUpdateTotalAmount.Size = new Size(85, 15);
            lblUpdateTotalAmount.TabIndex = 12;
            lblUpdateTotalAmount.Text = "Total Amount:";
            // 
            // txtUpdateTotalAmount
            // 
            txtUpdateTotalAmount.Location = new Point(1107, 243);
            txtUpdateTotalAmount.Margin = new Padding(4);
            txtUpdateTotalAmount.Name = "txtUpdateTotalAmount";
            txtUpdateTotalAmount.Size = new Size(149, 23);
            txtUpdateTotalAmount.TabIndex = 13;
            // 
            // lblUpdateStatus
            // 
            lblUpdateStatus.AutoSize = true;
            lblUpdateStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdateStatus.Location = new Point(1016, 280);
            lblUpdateStatus.Margin = new Padding(4, 0, 4, 0);
            lblUpdateStatus.Name = "lblUpdateStatus";
            lblUpdateStatus.Size = new Size(45, 15);
            lblUpdateStatus.TabIndex = 14;
            lblUpdateStatus.Text = "Status:";
            // 
            // txtUpdateStatus
            // 
            txtUpdateStatus.Location = new Point(1107, 277);
            txtUpdateStatus.Margin = new Padding(4);
            txtUpdateStatus.Name = "txtUpdateStatus";
            txtUpdateStatus.Size = new Size(149, 23);
            txtUpdateStatus.TabIndex = 15;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaptionText;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(1168, 315);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 26);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrderId.Location = new Point(113, 178);
            lblOrderId.Margin = new Padding(4, 0, 4, 0);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(59, 15);
            lblOrderId.TabIndex = 17;
            lblOrderId.Text = "Order ID:";
            lblOrderId.Click += lblOrderId_Click;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(204, 178);
            txtOrderId.Margin = new Padding(4);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(154, 23);
            txtOrderId.TabIndex = 18;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerId.Location = new Point(113, 212);
            lblCustomerId.Margin = new Padding(4, 0, 4, 0);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(80, 15);
            lblCustomerId.TabIndex = 19;
            lblCustomerId.Text = "Customer ID:";
            lblCustomerId.Click += lblCustomerId_Click;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(204, 209);
            txtCustomerId.Margin = new Padding(4);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(154, 23);
            txtCustomerId.TabIndex = 20;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(113, 243);
            lblTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(85, 15);
            lblTotalAmount.TabIndex = 21;
            lblTotalAmount.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(204, 240);
            txtTotalAmount.Margin = new Padding(4);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(154, 23);
            txtTotalAmount.TabIndex = 22;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(113, 279);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 23;
            lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(204, 271);
            txtStatus.Margin = new Padding(4);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(154, 23);
            txtStatus.TabIndex = 24;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaptionText;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(232, 315);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 26);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(635, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 32);
            label1.TabIndex = 26;
            label1.Text = "ORDERS";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1361, 641);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(txtStatus);
            Controls.Add(lblStatus);
            Controls.Add(txtTotalAmount);
            Controls.Add(lblTotalAmount);
            Controls.Add(txtCustomerId);
            Controls.Add(lblCustomerId);
            Controls.Add(txtOrderId);
            Controls.Add(lblOrderId);
            Controls.Add(btnUpdate);
            Controls.Add(txtUpdateStatus);
            Controls.Add(lblUpdateStatus);
            Controls.Add(txtUpdateTotalAmount);
            Controls.Add(lblUpdateTotalAmount);
            Controls.Add(txtUpdateCustomerId);
            Controls.Add(lblUpdateCustomerId);
            Controls.Add(txtUpdateOrderId);
            Controls.Add(lblUpdateOrderId);
            Controls.Add(btnDelete);
            Controls.Add(txtDeleteOrderId);
            Controls.Add(lblDeleteOrderId);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchOrderId);
            Controls.Add(lblSearchOrderId);
            Controls.Add(dgvOrders);
            Controls.Add(btnView);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblSearchOrderId;
        private System.Windows.Forms.TextBox txtSearchOrderId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDeleteOrderId;
        private System.Windows.Forms.TextBox txtDeleteOrderId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblUpdateOrderId;
        private System.Windows.Forms.TextBox txtUpdateOrderId;
        private System.Windows.Forms.Label lblUpdateCustomerId;
        private System.Windows.Forms.TextBox txtUpdateCustomerId;
        private System.Windows.Forms.Label lblUpdateTotalAmount;
        private System.Windows.Forms.TextBox txtUpdateTotalAmount;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.TextBox txtUpdateStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAdd;
        private Label label1;
    }
}

