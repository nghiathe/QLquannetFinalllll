﻿namespace QLquannet
{
    partial class frmBilling
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
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpBd = new System.Windows.Forms.DateTimePicker();
            this.tpKt = new System.Windows.Forms.DateTimePicker();
            this.rbKhoang = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbKhoang = new System.Windows.Forms.GroupBox();
            this.rbHai = new System.Windows.Forms.RadioButton();
            this.gbHai = new System.Windows.Forms.GroupBox();
            this.txtProfitOtherMonth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tpTe = new System.Windows.Forms.DateTimePicker();
            this.tpTs = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProfitMonth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbKhoang.SuspendLayout();
            this.gbHai.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.lvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBill.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(0, 36);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(762, 577);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ngày thanh toán";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nhân viên";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kiểu hóa đơn";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thu từ máy";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phí bảo trì";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng thu/chi đồ ăn";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tổng thu/chi";
            this.columnHeader8.Width = 103;
            // 
            // txtOut
            // 
            this.txtOut.Enabled = false;
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(85, 122);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(159, 22);
            this.txtOut.TabIndex = 64;
            this.txtOut.Text = "0";
            this.txtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(14, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tổng chi";
            // 
            // txtProfit
            // 
            this.txtProfit.Enabled = false;
            this.txtProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.Location = new System.Drawing.Point(85, 155);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(159, 22);
            this.txtProfit.TabIndex = 62;
            this.txtProfit.Text = "0";
            this.txtProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Lợi nhuận";
            // 
            // txtIn
            // 
            this.txtIn.Enabled = false;
            this.txtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(85, 89);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(159, 22);
            this.txtIn.TabIndex = 60;
            this.txtIn.Text = "0";
            this.txtIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tổng thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Từ ngày";
            // 
            // tpBd
            // 
            this.tpBd.CustomFormat = "dd/MM/yyyy HH:mm";
            this.tpBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpBd.Location = new System.Drawing.Point(85, 23);
            this.tpBd.Name = "tpBd";
            this.tpBd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpBd.Size = new System.Drawing.Size(159, 22);
            this.tpBd.TabIndex = 55;
            this.tpBd.Value = new System.DateTime(2024, 5, 25, 19, 10, 0, 0);
            this.tpBd.ValueChanged += new System.EventHandler(this.tpBd_ValueChanged);
            // 
            // tpKt
            // 
            this.tpKt.CustomFormat = "dd/MM/yyyy HH:mm";
            this.tpKt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpKt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpKt.Location = new System.Drawing.Point(85, 56);
            this.tpKt.Name = "tpKt";
            this.tpKt.Size = new System.Drawing.Size(159, 22);
            this.tpKt.TabIndex = 54;
            this.tpKt.Value = new System.DateTime(2024, 5, 26, 22, 11, 0, 0);
            this.tpKt.ValueChanged += new System.EventHandler(this.tpKt_ValueChanged);
            // 
            // rbKhoang
            // 
            this.rbKhoang.AutoSize = true;
            this.rbKhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKhoang.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbKhoang.Location = new System.Drawing.Point(785, 48);
            this.rbKhoang.Name = "rbKhoang";
            this.rbKhoang.Size = new System.Drawing.Size(186, 24);
            this.rbKhoang.TabIndex = 65;
            this.rbKhoang.TabStop = true;
            this.rbKhoang.Text = "Thống kê theo khoảng";
            this.rbKhoang.UseVisualStyleBackColor = true;
            this.rbKhoang.CheckedChanged += new System.EventHandler(this.rbKhoang_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvBill);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 615);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử thanh toán";
            // 
            // gbKhoang
            // 
            this.gbKhoang.Controls.Add(this.label1);
            this.gbKhoang.Controls.Add(this.tpKt);
            this.gbKhoang.Controls.Add(this.tpBd);
            this.gbKhoang.Controls.Add(this.txtOut);
            this.gbKhoang.Controls.Add(this.label2);
            this.gbKhoang.Controls.Add(this.label5);
            this.gbKhoang.Controls.Add(this.txtProfit);
            this.gbKhoang.Controls.Add(this.label3);
            this.gbKhoang.Controls.Add(this.label4);
            this.gbKhoang.Controls.Add(this.txtIn);
            this.gbKhoang.Enabled = false;
            this.gbKhoang.Location = new System.Drawing.Point(785, 78);
            this.gbKhoang.Name = "gbKhoang";
            this.gbKhoang.Size = new System.Drawing.Size(259, 200);
            this.gbKhoang.TabIndex = 67;
            this.gbKhoang.TabStop = false;
            // 
            // rbHai
            // 
            this.rbHai.AutoSize = true;
            this.rbHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHai.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbHai.Location = new System.Drawing.Point(785, 334);
            this.rbHai.Name = "rbHai";
            this.rbHai.Size = new System.Drawing.Size(174, 24);
            this.rbHai.TabIndex = 68;
            this.rbHai.TabStop = true;
            this.rbHai.Text = "Thống kê theo tháng";
            this.rbHai.UseVisualStyleBackColor = true;
            this.rbHai.CheckedChanged += new System.EventHandler(this.rbHai_CheckedChanged);
            // 
            // gbHai
            // 
            this.gbHai.Controls.Add(this.txtProfitOtherMonth);
            this.gbHai.Controls.Add(this.label8);
            this.gbHai.Controls.Add(this.label6);
            this.gbHai.Controls.Add(this.tpTe);
            this.gbHai.Controls.Add(this.tpTs);
            this.gbHai.Controls.Add(this.label7);
            this.gbHai.Controls.Add(this.txtProfitMonth);
            this.gbHai.Controls.Add(this.label10);
            this.gbHai.Enabled = false;
            this.gbHai.Location = new System.Drawing.Point(785, 364);
            this.gbHai.Name = "gbHai";
            this.gbHai.Size = new System.Drawing.Size(259, 184);
            this.gbHai.TabIndex = 68;
            this.gbHai.TabStop = false;
            // 
            // txtProfitOtherMonth
            // 
            this.txtProfitOtherMonth.Enabled = false;
            this.txtProfitOtherMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitOtherMonth.Location = new System.Drawing.Point(85, 130);
            this.txtProfitOtherMonth.Name = "txtProfitOtherMonth";
            this.txtProfitOtherMonth.Size = new System.Drawing.Size(159, 22);
            this.txtProfitOtherMonth.TabIndex = 64;
            this.txtProfitOtherMonth.Text = "0";
            this.txtProfitOtherMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(9, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 63;
            this.label8.Text = "Lợi nhuận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(21, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tháng";
            // 
            // tpTe
            // 
            this.tpTe.CustomFormat = "MM/yyyy";
            this.tpTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpTe.Location = new System.Drawing.Point(85, 102);
            this.tpTe.Name = "tpTe";
            this.tpTe.Size = new System.Drawing.Size(159, 22);
            this.tpTe.TabIndex = 54;
            this.tpTe.Value = new System.DateTime(2024, 5, 26, 22, 11, 0, 0);
            this.tpTe.ValueChanged += new System.EventHandler(this.tpTe_ValueChanged);
            // 
            // tpTs
            // 
            this.tpTs.CustomFormat = "MM/yyyy ";
            this.tpTs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpTs.Location = new System.Drawing.Point(85, 28);
            this.tpTs.Name = "tpTs";
            this.tpTs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpTs.Size = new System.Drawing.Size(159, 22);
            this.tpTs.TabIndex = 55;
            this.tpTs.Value = new System.DateTime(2024, 5, 25, 19, 10, 0, 0);
            this.tpTs.ValueChanged += new System.EventHandler(this.tpTs_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(24, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Tháng";
            // 
            // txtProfitMonth
            // 
            this.txtProfitMonth.Enabled = false;
            this.txtProfitMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitMonth.Location = new System.Drawing.Point(85, 56);
            this.txtProfitMonth.Name = "txtProfitMonth";
            this.txtProfitMonth.Size = new System.Drawing.Size(159, 22);
            this.txtProfitMonth.TabIndex = 62;
            this.txtProfitMonth.Text = "0";
            this.txtProfitMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(9, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "Lợi nhuận";
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1062, 615);
            this.Controls.Add(this.gbHai);
            this.Controls.Add(this.rbHai);
            this.Controls.Add(this.gbKhoang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbKhoang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBilling";
            this.Text = "frmHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.gbKhoang.ResumeLayout(false);
            this.gbKhoang.PerformLayout();
            this.gbHai.ResumeLayout(false);
            this.gbHai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tpBd;
        private System.Windows.Forms.DateTimePicker tpKt;
        private System.Windows.Forms.RadioButton rbKhoang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbKhoang;
        private System.Windows.Forms.RadioButton rbHai;
        private System.Windows.Forms.GroupBox gbHai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tpTe;
        private System.Windows.Forms.DateTimePicker tpTs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProfitMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProfitOtherMonth;
        private System.Windows.Forms.Label label8;
    }
}