namespace CafeManagement.GUI
{
    partial class frmOrderDetail
    {
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.txtOrderDetailID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtProductSizeID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblOrderDetailID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblProductSizeID = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(12, 112);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Size = new System.Drawing.Size(560, 240);
            this.dgvOrderDetails.TabIndex = 0;
            this.dgvOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellClick);
            // 
            // txtOrderDetailID
            // 
            this.txtOrderDetailID.Location = new System.Drawing.Point(98, 12);
            this.txtOrderDetailID.Name = "txtOrderDetailID";
            this.txtOrderDetailID.ReadOnly = true;
            this.txtOrderDetailID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderDetailID.TabIndex = 1;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(98, 38);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 2;
            // 
            // txtProductSizeID
            // 
            this.txtProductSizeID.Location = new System.Drawing.Point(98, 64);
            this.txtProductSizeID.Name = "txtProductSizeID";
            this.txtProductSizeID.Size = new System.Drawing.Size(100, 20);
            this.txtProductSizeID.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(300, 12);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(80, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(282, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(346, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblOrderDetailID
            // 
            this.lblOrderDetailID.AutoSize = true;
            this.lblOrderDetailID.Location = new System.Drawing.Point(12, 15);
            this.lblOrderDetailID.Name = "lblOrderDetailID";
            this.lblOrderDetailID.Size = new System.Drawing.Size(77, 13);
            this.lblOrderDetailID.TabIndex = 8;
            this.lblOrderDetailID.Text = "OrderDetail ID:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(12, 41);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(50, 13);
            this.lblOrderID.TabIndex = 9;
            this.lblOrderID.Text = "Order ID:";
            // 
            // lblProductSizeID
            // 
            this.lblProductSizeID.AutoSize = true;
            this.lblProductSizeID.Location = new System.Drawing.Point(12, 67);
            this.lblProductSizeID.Name = "lblProductSizeID";
            this.lblProductSizeID.Size = new System.Drawing.Size(81, 13);
            this.lblProductSizeID.TabIndex = 10;
            this.lblProductSizeID.Text = "ProductSize ID:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(249, 15);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(52, 13);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity: ";
            // 
            // frmOrderDetail
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductSizeID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblOrderDetailID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductSizeID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtOrderDetailID);
            this.Controls.Add(this.dgvOrderDetails);
            this.Name = "frmOrderDetail";
            this.Text = "Quản lý Order Detail";
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.TextBox txtOrderDetailID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtProductSizeID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblOrderDetailID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblProductSizeID;
        private System.Windows.Forms.Label lblQuantity;
    }
}
