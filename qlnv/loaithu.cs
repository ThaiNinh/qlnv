using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace qlnv
{
    public partial class frmloaithu : Form
    {
        public frmloaithu()
        {
            InitializeComponent();
        }
        DataTable tbllt;
        private void frmloaithu_Load(object sender, EventArgs e)
        {
            txtmathu.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            loaddatagrid();
            function.ketnoi();
            function.fillcombo("select maloai, tenloai from tblloai", cbomaloai, "maloai", "tenloai");
            cbomaloai.SelectedIndex = -1;
        }
        private void loaddatagrid()
        {
            string sql;
            sql = "select mathu, tenthu, maloai, soluong, gioitinh, tuoitho from tblthu";
            tbllt = function.getdatatotable(sql);
            dtgrloaithu.DataSource = tbllt;
            dtgrloaithu.Columns[0].HeaderText = "Mã thú";
            dtgrloaithu.Columns[1].HeaderText = "Tên thú";
            dtgrloaithu.Columns[2].HeaderText = "Mã loài";
            dtgrloaithu.Columns[3].HeaderText = "Số lượng";
            dtgrloaithu.Columns[4].HeaderText = "Giới tính";
            dtgrloaithu.Columns[5].HeaderText = "Tuổi thọ";

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            cbomaloai.SelectedIndex = -1;
            txtmathu.Enabled = true;
            txtmathu.Focus();

        }
        private void resetvalue()
        {
            txtmathu.Text = "";
            txttenthu.Text = "";
            txtsoluong.Text = "0";
            txttuoitho.Text = "0";
            txtgioitinh.Text = "";
            cbomaloai.Text = "";

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {

            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = false;
            txtmathu.Enabled = false;
            resetvalue();

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void dtgrloaithu_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm thú mới", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmathu.Focus();
                return;
            }
            if (dtgrloaithu.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //đủ
            txtmathu.Text = dtgrloaithu.CurrentRow.Cells["mathu"].Value.ToString();
            txttenthu.Text = dtgrloaithu.CurrentRow.Cells["tenthu"].Value.ToString();
            ma = dtgrloaithu.CurrentRow.Cells["maloai"].Value.ToString();
            cbomaloai.Text =function.GetFieldValues("select tenloai from tblloai where maloai = N'" + ma + "'");
            txtsoluong.Text = dtgrloaithu.CurrentRow.Cells["soluong"].Value.ToString();
            txtgioitinh.Text = dtgrloaithu.CurrentRow.Cells["gioitinh"].Value.ToString();        
            txttuoitho.Text = dtgrloaithu.CurrentRow.Cells["tuoitho"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }


        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmathu.Text == "")
            {
                MessageBox.Show("bạn phải nhập mã thú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmathu.Focus();
                return;
            }
            if (txttenthu.Text == "")
            {
                MessageBox.Show("bạn phải nhập tên thú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenthu.Focus();
                return;
            }
            if (txtsoluong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return;
            }
            if (cbomaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã loài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaloai.Focus();
                return;
            }
            if (txttuoitho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tuổi thọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttuoitho.Focus();
                return;
            }
            if (txtgioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttuoitho.Focus();
                return;
            }
            string sql;
            sql = "select mathu from tblthu where mathu=N'" + txtmathu.Text.Trim() + "'";
            if (function.ktratrungma(sql))
            {
                MessageBox.Show("bị trùng mã thú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmathu.Text = "";
                txtmathu.Focus();
                return;
            }
            //đủ
            sql = "insert into tblthu(mathu,tenthu, maloai, soluong,gioitinh, tuoitho) values (N'" +
            txtmathu.Text.Trim() + "',N'" + txttenthu.Text.Trim() + "',N'" + cbomaloai.SelectedValue + "',N'" 
             + txtsoluong.Text.Trim() + "',N'" + txtgioitinh.Text.Trim() + "',N'"+ txttuoitho.Text + "')";
            function.Runsql(sql);
            loaddatagrid();
            resetvalue();
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmathu.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbllt.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmathu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenthu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenthu.Focus();
                return;
            }
            if (cbomaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã loài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaloai.Focus();
                return;
            }
            if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return;
            }
            if (txttuoitho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tuổi thọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttuoitho.Focus();
                return;
            }
            if (txtgioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttuoitho.Focus();
                return;
            }
            //đủ
            sql = "update tblthu set  tenthu=N'" + txttenthu.Text.Trim().ToString()+ "',maloai='"+ cbomaloai.SelectedValue
                  + "',soluong='" + txtsoluong.Text.Trim().ToString() + "',gioitinh=N'" + txtgioitinh.Text.ToString() + "',tuoitho='" + 
               txttuoitho.Text.ToString() +"' where mathu=N'" + txtmathu.Text + "'";
            function.Runsql(sql);
            loaddatagrid();
            resetvalue();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbllt.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmathu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblthu where mathu=N'" + txtmathu.Text + "'";
                function.Runsql(sql);
                loaddatagrid();
                resetvalue();
            }
        }
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, "[0-9]");
            else return true;
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtsoluong.Text) != true)
            {
                MessageBox.Show("Hãy nhập số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
            }
        }

        private void txttuoitho_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txttuoitho.Text) != true)
            {
                MessageBox.Show("Hãy nhập số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttuoitho.Text = "";
            }
        }
    }
}
