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
            btnAdd = new Button();
            btnView = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtSaleId = new TextBox();
            txtProductId = new TextBox();
            txtQuantity = new TextBox();
            txtTotalAmount = new TextBox();
            dgvSales = new DataGridView();
            lblSaleId = new Label();
            lblProductId = new Label();
            lblQuantity = new Label();
            lblTotalAmount = new Label();
            txtSearchSaleId = new TextBox();
            lblSearchSaleId = new Label();
            txtDeleteSaleId = new TextBox();
            lblDeleteSaleId = new Label();
            txtUpdateSaleId = new TextBox();
            lblUpdateSaleId = new Label();
            txtUpdateProductId = new TextBox();
            txtUpdateQuantity = new TextBox();
            txtUpdateTotalAmount = new TextBox();
            lblUpdateProductId = new Label();
            lblUpdateQuantity = new Label();
            lblUpdateTotalAmount = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaptionText;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(83, 330);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ActiveCaptionText;
            btnView.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(177, 330);
            btnView.Margin = new Padding(4, 3, 4, 3);
            btnView.Name = "btnView";
            btnView.Size = new Size(88, 27);
            btnView.TabIndex = 1;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaptionText;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(894, 454);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaptionText;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(894, 490);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaptionText;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(469, 330);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtSaleId
            // 
            txtSaleId.Location = new Point(151, 194);
            txtSaleId.Margin = new Padding(4, 3, 4, 3);
            txtSaleId.Name = "txtSaleId";
            txtSaleId.Size = new Size(144, 23);
            txtSaleId.TabIndex = 5;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(151, 224);
            txtProductId.Margin = new Padding(4, 3, 4, 3);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(144, 23);
            txtProductId.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(151, 254);
            txtQuantity.Margin = new Padding(4, 3, 4, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(144, 23);
            txtQuantity.TabIndex = 7;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(151, 284);
            txtTotalAmount.Margin = new Padding(4, 3, 4, 3);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(144, 23);
            txtTotalAmount.TabIndex = 8;
            // 
            // dgvSales
            // 
            dgvSales.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(677, 191);
            dgvSales.Margin = new Padding(4, 3, 4, 3);
            dgvSales.Name = "dgvSales";
            dgvSales.Size = new Size(600, 242);
            dgvSales.TabIndex = 9;
            // 
            // lblSaleId
            // 
            lblSaleId.AutoSize = true;
            lblSaleId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSaleId.Location = new Point(57, 197);
            lblSaleId.Margin = new Padding(4, 0, 4, 0);
            lblSaleId.Name = "lblSaleId";
            lblSaleId.Size = new Size(46, 15);
            lblSaleId.TabIndex = 10;
            lblSaleId.Text = "Sale ID";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProductId.Location = new Point(57, 227);
            lblProductId.Margin = new Padding(4, 0, 4, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(67, 15);
            lblProductId.TabIndex = 11;
            lblProductId.Text = "Product ID";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQuantity.Location = new Point(57, 257);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(55, 15);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Quantity";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(57, 287);
            lblTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(82, 15);
            lblTotalAmount.TabIndex = 13;
            lblTotalAmount.Text = "Total Amount";
            // 
            // txtSearchSaleId
            // 
            txtSearchSaleId.Location = new Point(756, 454);
            txtSearchSaleId.Margin = new Padding(4, 3, 4, 3);
            txtSearchSaleId.Name = "txtSearchSaleId";
            txtSearchSaleId.Size = new Size(116, 23);
            txtSearchSaleId.TabIndex = 14;
            // 
            // lblSearchSaleId
            // 
            lblSearchSaleId.AutoSize = true;
            lblSearchSaleId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearchSaleId.Location = new Point(682, 457);
            lblSearchSaleId.Margin = new Padding(4, 0, 4, 0);
            lblSearchSaleId.Name = "lblSearchSaleId";
            lblSearchSaleId.Size = new Size(61, 15);
            lblSearchSaleId.TabIndex = 15;
            lblSearchSaleId.Text = "Search ID";
            // 
            // txtDeleteSaleId
            // 
            txtDeleteSaleId.Location = new Point(756, 490);
            txtDeleteSaleId.Margin = new Padding(4, 3, 4, 3);
            txtDeleteSaleId.Name = "txtDeleteSaleId";
            txtDeleteSaleId.Size = new Size(116, 23);
            txtDeleteSaleId.TabIndex = 16;
            // 
            // lblDeleteSaleId
            // 
            lblDeleteSaleId.AutoSize = true;
            lblDeleteSaleId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeleteSaleId.Location = new Point(682, 492);
            lblDeleteSaleId.Margin = new Padding(4, 0, 4, 0);
            lblDeleteSaleId.Name = "lblDeleteSaleId";
            lblDeleteSaleId.Size = new Size(61, 15);
            lblDeleteSaleId.TabIndex = 17;
            lblDeleteSaleId.Text = "Delete ID";
            lblDeleteSaleId.Click += lblDeleteSaleId_Click;
            // 
            // txtUpdateSaleId
            // 
            txtUpdateSaleId.Location = new Point(478, 191);
            txtUpdateSaleId.Margin = new Padding(4, 3, 4, 3);
            txtUpdateSaleId.Name = "txtUpdateSaleId";
            txtUpdateSaleId.Size = new Size(139, 23);
            txtUpdateSaleId.TabIndex = 18;
            // 
            // lblUpdateSaleId
            // 
            lblUpdateSaleId.AutoSize = true;
            lblUpdateSaleId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdateSaleId.Location = new Point(365, 197);
            lblUpdateSaleId.Margin = new Padding(4, 0, 4, 0);
            lblUpdateSaleId.Name = "lblUpdateSaleId";
            lblUpdateSaleId.Size = new Size(64, 15);
            lblUpdateSaleId.TabIndex = 19;
            lblUpdateSaleId.Text = "Update ID";
            // 
            // txtUpdateProductId
            // 
            txtUpdateProductId.Location = new Point(478, 221);
            txtUpdateProductId.Margin = new Padding(4, 3, 4, 3);
            txtUpdateProductId.Name = "txtUpdateProductId";
            txtUpdateProductId.Size = new Size(139, 23);
            txtUpdateProductId.TabIndex = 20;
            // 
            // txtUpdateQuantity
            // 
            txtUpdateQuantity.Location = new Point(478, 251);
            txtUpdateQuantity.Margin = new Padding(4, 3, 4, 3);
            txtUpdateQuantity.Name = "txtUpdateQuantity";
            txtUpdateQuantity.Size = new Size(139, 23);
            txtUpdateQuantity.TabIndex = 21;
            // 
            // txtUpdateTotalAmount
            // 
            txtUpdateTotalAmount.Location = new Point(478, 281);
            txtUpdateTotalAmount.Margin = new Padding(4, 3, 4, 3);
            txtUpdateTotalAmount.Name = "txtUpdateTotalAmount";
            txtUpdateTotalAmount.Size = new Size(139, 23);
            txtUpdateTotalAmount.TabIndex = 22;
            // 
            // lblUpdateProductId
            // 
            lblUpdateProductId.AutoSize = true;
            lblUpdateProductId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdateProductId.Location = new Point(365, 227);
            lblUpdateProductId.Margin = new Padding(4, 0, 4, 0);
            lblUpdateProductId.Name = "lblUpdateProductId";
            lblUpdateProductId.Size = new Size(88, 15);
            lblUpdateProductId.TabIndex = 23;
            lblUpdateProductId.Text = "Update ProdId";
            // 
            // lblUpdateQuantity
            // 
            lblUpdateQuantity.AutoSize = true;
            lblUpdateQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdateQuantity.Location = new Point(365, 257);
            lblUpdateQuantity.Margin = new Padding(4, 0, 4, 0);
            lblUpdateQuantity.Name = "lblUpdateQuantity";
            lblUpdateQuantity.Size = new Size(71, 15);
            lblUpdateQuantity.TabIndex = 24;
            lblUpdateQuantity.Text = "Update Qty";
            // 
            // lblUpdateTotalAmount
            // 
            lblUpdateTotalAmount.AutoSize = true;
            lblUpdateTotalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdateTotalAmount.Location = new Point(365, 287);
            lblUpdateTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblUpdateTotalAmount.Name = "lblUpdateTotalAmount";
            lblUpdateTotalAmount.Size = new Size(105, 15);
            lblUpdateTotalAmount.TabIndex = 25;
            lblUpdateTotalAmount.Text = "Update Total Amt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(667, 103);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 26;
            label1.Text = "SALES";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1334, 577);
            Controls.Add(label1);
            Controls.Add(lblUpdateTotalAmount);
            Controls.Add(lblUpdateQuantity);
            Controls.Add(lblUpdateProductId);
            Controls.Add(txtUpdateTotalAmount);
            Controls.Add(txtUpdateQuantity);
            Controls.Add(txtUpdateProductId);
            Controls.Add(lblUpdateSaleId);
            Controls.Add(txtUpdateSaleId);
            Controls.Add(lblDeleteSaleId);
            Controls.Add(txtDeleteSaleId);
            Controls.Add(lblSearchSaleId);
            Controls.Add(txtSearchSaleId);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblQuantity);
            Controls.Add(lblProductId);
            Controls.Add(lblSaleId);
            Controls.Add(dgvSales);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductId);
            Controls.Add(txtSaleId);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Sales Management App";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSaleId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblSaleId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtSearchSaleId;
        private System.Windows.Forms.Label lblSearchSaleId;
        private System.Windows.Forms.TextBox txtDeleteSaleId;
        private System.Windows.Forms.Label lblDeleteSaleId;
        private System.Windows.Forms.TextBox txtUpdateSaleId;
        private System.Windows.Forms.Label lblUpdateSaleId;
        private System.Windows.Forms.TextBox txtUpdateProductId;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private System.Windows.Forms.TextBox txtUpdateTotalAmount;
        private System.Windows.Forms.Label lblUpdateProductId;
        private System.Windows.Forms.Label lblUpdateQuantity;
        private System.Windows.Forms.Label lblUpdateTotalAmount;
        private Label label1;
    }
}
