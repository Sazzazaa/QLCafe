namespace CafeManagement.GUI
{
    partial class frmOrder
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTableID = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblDateCheckIn = new System.Windows.Forms.Label();
            this.lblDateCheckOut = new System.Windows.Forms.Label();
            this.dtpDateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpDateCheckOut = new System.Windows.Forms.DateTimePicker();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.cbbTableID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 230);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.Size = new System.Drawing.Size(776, 208);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(105, 12);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(150, 26);
            this.txtOrderID.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(88, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(164, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(566, 180);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(130, 30);
            this.btnSearchByDate.TabIndex = 7;
            this.btnSearchByDate.Text = "Tìm kiếm theo ngày";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(394, 185);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(80, 26);
            this.dtpFromDate.TabIndex = 8;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(480, 185);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(80, 26);
            this.dtpToDate.TabIndex = 9;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(12, 15);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(74, 20);
            this.lblOrderID.TabIndex = 10;
            this.lblOrderID.Text = "Order ID:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 69);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.Location = new System.Drawing.Point(12, 95);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(73, 20);
            this.lblTableID.TabIndex = 12;
            this.lblTableID.Text = "Table ID:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(332, 188);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(81, 20);
            this.lblFromDate.TabIndex = 13;
            this.lblFromDate.Text = "Từ ngày  : ";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(477, 169);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(85, 20);
            this.lblToDate.TabIndex = 14;
            this.lblToDate.Text = "Đến ngày :";
            // 
            // lblDateCheckIn
            // 
            this.lblDateCheckIn.AutoSize = true;
            this.lblDateCheckIn.Location = new System.Drawing.Point(12, 43);
            this.lblDateCheckIn.Name = "lblDateCheckIn";
            this.lblDateCheckIn.Size = new System.Drawing.Size(115, 20);
            this.lblDateCheckIn.TabIndex = 15;
            this.lblDateCheckIn.Text = "DateCheckIn : ";
            // 
            // lblDateCheckOut
            // 
            this.lblDateCheckOut.AutoSize = true;
            this.lblDateCheckOut.Location = new System.Drawing.Point(12, 121);
            this.lblDateCheckOut.Name = "lblDateCheckOut";
            this.lblDateCheckOut.Size = new System.Drawing.Size(127, 20);
            this.lblDateCheckOut.TabIndex = 16;
            this.lblDateCheckOut.Text = "DateCheckOut : ";
            // 
            // dtpDateCheckIn
            // 
            this.dtpDateCheckIn.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpDateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCheckIn.Location = new System.Drawing.Point(105, 40);
            this.dtpDateCheckIn.Name = "dtpDateCheckIn";
            this.dtpDateCheckIn.Size = new System.Drawing.Size(150, 26);
            this.dtpDateCheckIn.TabIndex = 17;
            // 
            // dtpDateCheckOut
            // 
            this.dtpDateCheckOut.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpDateCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCheckOut.Location = new System.Drawing.Point(105, 118);
            this.dtpDateCheckOut.Name = "dtpDateCheckOut";
            this.dtpDateCheckOut.Size = new System.Drawing.Size(150, 26);
            this.dtpDateCheckOut.TabIndex = 18;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(105, 66);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(150, 28);
            this.cbbStatus.TabIndex = 19;
            // 
            // cbbTableID
            // 
            this.cbbTableID.FormattingEnabled = true;
            this.cbbTableID.Location = new System.Drawing.Point(105, 92);
            this.cbbTableID.Name = "cbbTableID";
            this.cbbTableID.Size = new System.Drawing.Size(150, 28);
            this.cbbTableID.TabIndex = 20;
            // 
            // frmOrder
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbTableID);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.dtpDateCheckOut);
            this.Controls.Add(this.dtpDateCheckIn);
            this.Controls.Add(this.lblDateCheckOut);
            this.Controls.Add(this.lblDateCheckIn);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblTableID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.dgvOrders);
            this.Name = "frmOrder";
            this.Text = "Quản lý Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblDateCheckIn;
        private System.Windows.Forms.Label lblDateCheckOut;
        private System.Windows.Forms.DateTimePicker dtpDateCheckIn;
        private System.Windows.Forms.DateTimePicker dtpDateCheckOut;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.ComboBox cbbTableID;
    }
}
