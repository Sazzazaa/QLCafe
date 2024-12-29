using System;
using System.Linq;
using System.Windows.Forms;
using BLL;
using CafeManagement.BLL;
using DAL;
using DAL.Models;

namespace CafeManagement.GUI
{
    public partial class frmOrder : Form
    {
        private OrderBLL orderBLL = new OrderBLL();
        private TableBLL tableBLL = new TableBLL();


        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            cbbStatus.Items.Add("Chưa thanh toán");
            cbbStatus.Items.Add("Đã thanh toán");
            LoadOrdersToGrid();
            LoadTablesToComboBox();
        }
        private void LoadTablesToComboBox()
        {
            var list = tableBLL.GetAllTables();
            cbbTableID.DataSource = list;
            cbbTableID.DisplayMember = "TableName";
            cbbTableID.ValueMember = "TableID";
        }

        private void LoadOrdersToGrid()
        {
            var ordersLight = orderBLL.GetOrdersLight();
            dgvOrders.DataSource = ordersLight;
        }
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvOrders.Rows[e.RowIndex];

                // OrderID
                txtOrderID.Text = selectedRow.Cells["OrderID"].Value?.ToString();

                // Status
                cbbStatus.Text = selectedRow.Cells["Status"].Value?.ToString();

                // TableID
                var tableIdValue = selectedRow.Cells["TableID"].Value;
                if (tableIdValue != null)
                {
                    // Gán lại cho ComboBox => ComboBox sẽ hiện "Bàn 1" hay "Bàn 2"
                    cbbTableID.SelectedValue = tableIdValue.ToString();
                }

                // DateCheckIn
                var dateCheckInValue = selectedRow.Cells["DateCheckIn"].Value;
                if (dateCheckInValue != null)
                {
                    DateTime dci = Convert.ToDateTime(dateCheckInValue);
                    dtpDateCheckIn.Value = dci;
                }

                // DateCheckOut
                var dateCheckOutValue = selectedRow.Cells["DateCheckOut"].Value;
                if (dateCheckOutValue != null)
                {
                    DateTime dco = Convert.ToDateTime(dateCheckOutValue);
                    dtpDateCheckOut.Value = dco;
                }
                else
                {
                    dtpDateCheckOut.Value = DateTime.Now;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Order newOrder = new Order()
                {
                    DateCheckIn = dtpDateCheckIn.Value,
                    DateCheckOut = dtpDateCheckOut.Value,
                    Status = cbbStatus.Text,
                    TableID = cbbTableID.SelectedValue.ToString()
                };

                bool result = orderBLL.InsertOrder(newOrder);
                if (result)
                {
                    MessageBox.Show("Thêm mới Order thành công!");
                    LoadOrdersToGrid();
                }
                else
                {
                    MessageBox.Show("Thêm mới Order thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOrderID.Text))
                {
                    MessageBox.Show("Chưa chọn Order để update!");
                    return;
                }

                int orderId = int.Parse(txtOrderID.Text);

                Order updateOrder = new Order()
                {
                    OrderID = orderId,
                    DateCheckIn = dtpDateCheckIn.Value,
                    DateCheckOut = dtpDateCheckOut.Value,
                    Status = cbbStatus.Text,
                    TableID = cbbTableID.SelectedValue.ToString()
                };

                bool result = orderBLL.UpdateOrder(updateOrder);
                if (result)
                {
                    MessageBox.Show("Cập nhật Order thành công!");
                    LoadOrdersToGrid();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOrderID.Text))
                {
                    MessageBox.Show("Chưa chọn Order để xóa!");
                    return;
                }

                int orderId = int.Parse(txtOrderID.Text);
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    bool result = orderBLL.DeleteOrder(orderId);
                    if (result)
                    {
                        MessageBox.Show("Xóa Order thành công!");
                        LoadOrdersToGrid();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date;

            var ordersLight = orderBLL.SearchOrdersByDateLight(fromDate, toDate);
            dgvOrders.DataSource = ordersLight;
        }
    }
}