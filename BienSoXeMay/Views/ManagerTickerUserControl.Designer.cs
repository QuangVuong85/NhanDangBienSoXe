namespace NhậnDiệnBiểnSốXe.Views
{
    partial class ManagerTickerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtBienso = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.dateDeadline = new System.Windows.Forms.DateTimePicker();
            this.cbxIsActive = new System.Windows.Forms.ComboBox();
            this.btnChinhsua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tickersListView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tickersListView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtId.Location = new System.Drawing.Point(379, 154);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(252, 34);
            this.txtId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(173, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Biển Số Xe";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(173, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Thẻ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(173, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Chủ Xe";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(173, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chứng Minh Thư";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(752, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Loại Vé";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(752, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tình Trạng Vé";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(752, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ngày Hết Hạn";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.Navy;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(177, 419);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(188, 50);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtBienso
            // 
            this.txtBienso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBienso.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBienso.Location = new System.Drawing.Point(379, 215);
            this.txtBienso.Margin = new System.Windows.Forms.Padding(4);
            this.txtBienso.Name = "txtBienso";
            this.txtBienso.Size = new System.Drawing.Size(252, 34);
            this.txtBienso.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(379, 275);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 34);
            this.txtName.TabIndex = 16;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCmnd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCmnd.Location = new System.Drawing.Point(379, 344);
            this.txtCmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(252, 34);
            this.txtCmnd.TabIndex = 17;
            // 
            // cbxType
            // 
            this.cbxType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Vé Tháng",
            "Vé Ngày"});
            this.cbxType.Location = new System.Drawing.Point(939, 154);
            this.cbxType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(220, 24);
            this.cbxType.TabIndex = 18;
            // 
            // dateDeadline
            // 
            this.dateDeadline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateDeadline.Location = new System.Drawing.Point(939, 275);
            this.dateDeadline.Margin = new System.Windows.Forms.Padding(4);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new System.Drawing.Size(220, 22);
            this.dateDeadline.TabIndex = 19;
            // 
            // cbxIsActive
            // 
            this.cbxIsActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxIsActive.FormattingEnabled = true;
            this.cbxIsActive.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Không hoạt động"});
            this.cbxIsActive.Location = new System.Drawing.Point(939, 213);
            this.cbxIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.cbxIsActive.Name = "cbxIsActive";
            this.cbxIsActive.Size = new System.Drawing.Size(220, 24);
            this.cbxIsActive.TabIndex = 20;
            // 
            // btnChinhsua
            // 
            this.btnChinhsua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChinhsua.BackColor = System.Drawing.Color.Navy;
            this.btnChinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChinhsua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChinhsua.Location = new System.Drawing.Point(571, 419);
            this.btnChinhsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnChinhsua.Name = "btnChinhsua";
            this.btnChinhsua.Size = new System.Drawing.Size(188, 50);
            this.btnChinhsua.TabIndex = 21;
            this.btnChinhsua.Text = "Chỉnh sửa";
            this.btnChinhsua.UseVisualStyleBackColor = false;
            this.btnChinhsua.Click += new System.EventHandler(this.btnChinhsua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.Navy;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(972, 419);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(188, 50);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tickersListView
            // 
            this.tickersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tickersListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tickersListView.Location = new System.Drawing.Point(0, 519);
            this.tickersListView.Margin = new System.Windows.Forms.Padding(4);
            this.tickersListView.Name = "tickersListView";
            this.tickersListView.Size = new System.Drawing.Size(1320, 249);
            this.tickersListView.TabIndex = 23;
            this.tickersListView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tickersListView_CellClick);
            this.tickersListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tickersListView_CellContentClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(441, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(565, 46);
            this.label8.TabIndex = 24;
            this.label8.Text = "QUẢN LÝ THÔNG TIN VÉ  XE";
            // 
            // ManagerTickerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tickersListView);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhsua);
            this.Controls.Add(this.cbxIsActive);
            this.Controls.Add(this.dateDeadline);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.txtCmnd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBienso);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerTickerUserControl";
            this.Size = new System.Drawing.Size(1320, 772);
            ((System.ComponentModel.ISupportInitialize)(this.tickersListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtBienso;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.DateTimePicker dateDeadline;
        private System.Windows.Forms.ComboBox cbxIsActive;
        private System.Windows.Forms.Button btnChinhsua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView tickersListView;
        private System.Windows.Forms.Label label8;
    }
}
