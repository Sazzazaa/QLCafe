using System;
using System.Linq;
using System.Windows.Forms;
using CafeManagement.BLL;
using DAL.Models;

namespace CafeManagement.GUI
{
    public partial class frmOrderDetail : Form
    {
        private OrderDetailBLL orderDetailBLL = new OrderDetailBLL();

        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadOrderDetailsToGrid();
        }

        private void LoadOrderDetailsToGrid()
        {
            var list = orderDetailBLL.GetOrderDetailsLight();
            dgvOrderDetails.DataSource = list;
        }

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvOrderDetails.Rows[e.RowIndex];
                txtOrderDetailID.Text = selectedRow.Cells["OrderDetailID"].Value?.ToString();
                txtOrderID.Text = selectedRow.Cells["OrderID"].Value?.ToString();
                txtProductSizeID.Text = selectedRow.Cells["ProductSizeID"].Value?.ToString();
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value?.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetail newOD = new OrderDetail()
                {
                    // OrderDetailID tự generate (IDENTITY) khi Insert
                    OrderID = int.Parse(txtOrderID.Text),
                    ProductSizeID = int.Parse(txtProductSizeID.Text),
                    Quantity = int.Parse(txtQuantity.Text)
                };

                bool result = orderDetailBLL.InsertOrderDetail(newOD);
                if (result)
                {
                    MessageBox.Show("Thêm mới OrderDetail thành công!");
                    LoadOrderDetailsToGrid();
                }
                else
                {
                    MessageBox.Show("Thêm mới OrderDetail thất bại!");
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
                if (string.IsNullOrEmpty(txtOrderDetailID.Text))
                {
                    MessageBox.Show("Chưa chọn OrderDetail để sửa!");
                    return;
                }

                int orderDetailId = int.Parse(txtOrderDetailID.Text);
                OrderDetail od = new OrderDetail()
                {
                    OrderDetailID = orderDetailId,
                    OrderID = int.Parse(txtOrderID.Text),
                    ProductSizeID = int.Parse(txtProductSizeID.Text),
                    Quantity = int.Parse(txtQuantity.Text)
                };

                bool result = orderDetailBLL.UpdateOrderDetail(od);
                if (result)
                {
                    MessageBox.Show("Cập nhật OrderDetail thành công!");
                    LoadOrderDetailsToGrid();
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
                if (string.IsNullOrEmpty(txtOrderDetailID.Text))
                {
                    MessageBox.Show("Chưa chọn OrderDetail để xóa!");
                    return;
                }

                int orderDetailId = int.Parse(txtOrderDetailID.Text);
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    bool result = orderDetailBLL.DeleteOrderDetail(orderDetailId);
                    if (result)
                    {
                        MessageBox.Show("Xóa OrderDetail thành công!");
                        LoadOrderDetailsToGrid();
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
    }
}