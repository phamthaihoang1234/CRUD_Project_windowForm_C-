using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagment
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        CategoryDAO cateDao;
        public Form1()
        {
            cateDao = new CategoryDAO();
            InitializeComponent();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(unit.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn vị sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                unit.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(quantity.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng của sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                quantity.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(price.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                price.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(time.Text))
            {
                MessageBox.Show("Bạn chưa nhập thời gian tạo sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                time.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboCategory.Text))
            {
                MessageBox.Show("Bạn chưa nhập loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCategory.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(disc.Text))
            {
                MessageBox.Show("Bạn chưa nhập Discontinued loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disc.Focus();
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                loadCategories();
                dgvProduct.DataSource = cateDao.getAllProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadCategories()
        {
            cboCategory.DataSource = new CategoryDAO().getAllCategory().Tables[0];
            cboCategory.ValueMember = "CategoryId";
            cboCategory.DisplayMember = "CategoryName";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void add_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Product p = new Product();
                p.ProductId = id.Text;
                p.ProductName = name.Text;
                p.Unit = unit.Text;
                p.Quantity = int.Parse(quantity.Text);
                p.Price = int.Parse(price.Text);
                p.Discontinued = disc.Text;
                p.CreateDate = time.Text;
                p.CategoryId = (string)cboCategory.SelectedValue;
                
                if (cateDao.insert(p))
                {
                    dgvProduct.DataSource = cateDao.getAllProduct();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin hãy thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        String Productid;
        private void dataGridViewProduct_cellContent(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                Productid = dgvProduct.Rows[index].Cells["idV"].Value.ToString();
                id.Text = dgvProduct.Rows[index].Cells["idV"].Value.ToString();
                name.Text = dgvProduct.Rows[index].Cells["nameV"].Value.ToString();
                unit.Text = dgvProduct.Rows[index].Cells["unitV"].Value.ToString();
                quantity.Text = dgvProduct.Rows[index].Cells["quantityV"].Value.ToString();
                price.Text = dgvProduct.Rows[index].Cells["priceV"].Value.ToString();
                disc.Text = dgvProduct.Rows[index].Cells["discon"].Value.ToString();
                time.Text = dgvProduct.Rows[index].Cells["timeV"].Value.ToString();
                cboCategory.Text = dgvProduct.Rows[index].Cells["CateV"].Value.ToString();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {

            if (CheckData())
            {
                Product p = new Product();
                p.ProductId = id.Text;
                p.ProductName = name.Text;
                p.Unit = unit.Text;
                p.Quantity = int.Parse(quantity.Text);
                p.Price = int.Parse(price.Text);
                p.Discontinued = disc.Text;
                p.CreateDate = time.Text;
                p.CategoryId = (string)cboCategory.SelectedValue;

                if (cateDao.update(p))
                {
                    dgvProduct.DataSource = cateDao.getAllProduct();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin hãy thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }



        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Product p = new Product();
                p.ProductId = Productid;
                if (cateDao.delete(p))
                {
                    dgvProduct.DataSource = cateDao.getAllProduct();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin hãy thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllocConsole();
            Console.WriteLine(id.Text);
            Console.WriteLine(name.Text);
            Console.WriteLine(unit.Text);
            Console.WriteLine(quantity.Text);
            Console.WriteLine(price.Text);
            Console.WriteLine(disc.Text);
            Console.WriteLine(time.Text);
            Console.WriteLine(cboCategory.SelectedValue);

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
