
namespace qlnv
{
    partial class frmloaithu
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
            this.cbomaloai = new System.Windows.Forms.ComboBox();
            this.txttenthu = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttuoitho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgrloaithu = new System.Windows.Forms.DataGridView();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmathu = new System.Windows.Forms.TextBox();
            this.lbltenthu = new System.Windows.Forms.Label();
            this.lblmaloai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrloaithu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbomaloai
            // 
            this.cbomaloai.FormattingEnabled = true;
            this.cbomaloai.Location = new System.Drawing.Point(362, 172);
            this.cbomaloai.Name = "cbomaloai";
            this.cbomaloai.Size = new System.Drawing.Size(155, 24);
            this.cbomaloai.TabIndex = 98;
            // 
            // txttenthu
            // 
            this.txttenthu.Location = new System.Drawing.Point(362, 136);
            this.txttenthu.Name = "txttenthu";
            this.txttenthu.Size = new System.Drawing.Size(155, 22);
            this.txttenthu.TabIndex = 96;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(362, 213);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(155, 22);
            this.txtsoluong.TabIndex = 95;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            // 
            // txttuoitho
            // 
            this.txttuoitho.Location = new System.Drawing.Point(362, 252);
            this.txttuoitho.Name = "txttuoitho";
            this.txttuoitho.Size = new System.Drawing.Size(155, 22);
            this.txttuoitho.TabIndex = 94;
            this.txttuoitho.TextChanged += new System.EventHandler(this.txttuoitho_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 93;
            this.label5.Text = "Tuổi thọ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 92;
            this.label3.Text = "Mã Thú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "Số lượng";
            // 
            // dtgrloaithu
            // 
            this.dtgrloaithu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrloaithu.Location = new System.Drawing.Point(12, 329);
            this.dtgrloaithu.Name = "dtgrloaithu";
            this.dtgrloaithu.RowHeadersWidth = 51;
            this.dtgrloaithu.RowTemplate.Height = 24;
            this.dtgrloaithu.Size = new System.Drawing.Size(935, 146);
            this.dtgrloaithu.TabIndex = 90;
            this.dtgrloaithu.Click += new System.EventHandler(this.dtgrloaithu_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(698, 493);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 89;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(575, 493);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 88;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(454, 493);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 87;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(347, 493);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 86;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(233, 493);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 85;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(126, 493);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 84;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmathu
            // 
            this.txtmathu.Location = new System.Drawing.Point(362, 99);
            this.txtmathu.Name = "txtmathu";
            this.txtmathu.Size = new System.Drawing.Size(155, 22);
            this.txtmathu.TabIndex = 83;
            // 
            // lbltenthu
            // 
            this.lbltenthu.AutoSize = true;
            this.lbltenthu.Location = new System.Drawing.Point(276, 136);
            this.lbltenthu.Name = "lbltenthu";
            this.lbltenthu.Size = new System.Drawing.Size(57, 17);
            this.lbltenthu.TabIndex = 82;
            this.lbltenthu.Text = "Tên thú";
            // 
            // lblmaloai
            // 
            this.lblmaloai.AutoSize = true;
            this.lblmaloai.Location = new System.Drawing.Point(277, 175);
            this.lblmaloai.Name = "lblmaloai";
            this.lblmaloai.Size = new System.Drawing.Size(53, 17);
            this.lblmaloai.TabIndex = 81;
            this.lblmaloai.Text = "Mã loài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 59);
            this.label1.TabIndex = 80;
            this.label1.Text = "DANH MỤC LOÀI THÚ";
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(362, 292);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(155, 22);
            this.txtgioitinh.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Giới tính ";
            // 
            // frmloaithu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 538);
            this.Controls.Add(this.txtgioitinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbomaloai);
            this.Controls.Add(this.txttenthu);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txttuoitho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgrloaithu);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmathu);
            this.Controls.Add(this.lbltenthu);
            this.Controls.Add(this.lblmaloai);
            this.Controls.Add(this.label1);
            this.Name = "frmloaithu";
            this.Text = "danh mục loài thú";
            this.Load += new System.EventHandler(this.frmloaithu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrloaithu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbomaloai;
        private System.Windows.Forms.TextBox txttenthu;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttuoitho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgrloaithu;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmathu;
        private System.Windows.Forms.Label lbltenthu;
        private System.Windows.Forms.Label lblmaloai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.Label label4;
    }
}

