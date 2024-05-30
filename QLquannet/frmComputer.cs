﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquannet
{
    public partial class frmComputer : Form
    {
        #region ---------- Code cua HungTuLenh 

        byte cid;
        int bid;
        public frmComputer()
        {
            InitializeComponent();
            LoadZone(1);
            ChangeColorZoneBtn(btnZone1, null);
        }

        #region Event
        private void btnZone1_Click(object sender, EventArgs e)
        {
            LoadZone(1);
            ChangeColorZoneBtn(btnZone1, null);
        }

        private void btnZone2_Click(object sender, EventArgs e)
        {
            LoadZone(2);
            ChangeColorZoneBtn(btnZone2, null);
        }

        private void btnZone3_Click(object sender, EventArgs e)
        {
            LoadZone(3);
            ChangeColorZoneBtn(btnZone3, null);
        }

        private void btnZone4_Click(object sender, EventArgs e)
        {
            LoadZone(4);
            ChangeColorZoneBtn(btnZone4, null);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            cid = ((sender as Button).Tag as Computer).ComId;

            ChangeColorComBtn((sender as Button), null);
            LoadUsageSession(cid);
            LoadFoodDetail(cid);

        }
        private void btnBatmay_Click(object sender, EventArgs e)
        {
            if (txtTT.Text == "Online")
            {
                MessageBox.Show("Máy đang online!");
            }
            else if (txtTT.Text == "Error")
            {
                MessageBox.Show("Máy đang bảo trì!");
            }
            else if (gbMay.Text == "")
            {
                MessageBox.Show("Chưa chọn máy!");
            }
            else
            {
                UsageSessionDAL.Instance.StartSession(cid);
                LoadUsageSession(cid);
                LoadZone(ComputerZone.zoneId);
            }
        }
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            int billid = UsageSessionDAL.Instance.GetUnCheckOutSession(cid); 
            if (txtTT.Text == "Offline")
            {
                MessageBox.Show(gbMay.Text + " đang offline!");
            }
            else if (gbMay.Text == "")
            {
                MessageBox.Show("Chưa chọn máy!");
            }
            else
            {
                if (billid != -1)
                {   
                    UsageSessionDAL.Instance.EndSesion(billid);
                    BillingDAL.Instance.CheckOut(billid, 1);
                    LoadZone(ComputerZone.zoneId);
                    MessageBox.Show("Thanh toán thành công cho " + gbMay.Text);
                    LoadUsageSession(cid);
                    LoadFoodDetail(cid);

                }
                
            }
        }
        #endregion

        #region Method
        void LoadZone(byte zoneid)
        {
            flpCom.Controls.Clear();
            ComputerZone.zoneId = zoneid;
            List<Computer> listCom = ComputerDAL.Instance.loadCom(zoneid);
            int online = 0;
            int offline = 0;
            foreach (Computer com in listCom)
            {
                Button btn = new Button()
                {
                    Width = ComputerDAL.ComWidth,
                    Height = ComputerDAL.ComHeight,
                };
                
                btn.Click += btn_Click;

                btn.FlatStyle = FlatStyle.Flat;

                btn.Tag = com;

                switch (com.ComStatus)
                {
                    case 0:
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 100);
                        btn.BackColor = Color.LightGray;
                        btn.Text = com.ComName + Environment.NewLine + "Offline";
                        offline++;
                        break;
                        
                    case 1:
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 228, 178);
                        btn.BackColor = Color.Aqua;
                        btn.Text = com.ComName + Environment.NewLine + "Online";
                        online++;
                        break;
                    /*default:
                        btn.BackColor = Color.OrangeRed;
                        btn.Text = com.ComName + Environment.NewLine + "Error";
                        break;*/
                }
                flpCom.Controls.Add(btn);

                gbZone.Text = com.ZoneName;
                txtPrice.Text = com.PricePh.ToString();
                txtAvailable.Text = offline.ToString();
                txtUsing.Text = online.ToString();
                txtCPU.Text = com.CpuModel;
                txtGPU.Text = com.Gpumodel;
                txtHDD.Text = com.HddModel;
                txtSSD.Text = com.SsdModel;
                txtMouse.Text = com.MouseModel;
                txtKey.Text = com.KeyboardModel;
                txtMonitor.Text = com.MonitorModel;

            }
        }
        void LoadUsageSession(byte comid)
        {
            UsageSession us = UsageSessionDAL.Instance.GetUsageSessionDetails(comid);

            gbMay.Text = us.ComName;
            if (us.STime.HasValue)
            {
                tpStime.Value = us.STime.Value;
            }
            else
            {
                tpStime.Value = DateTime.Now;
            }
            TimeSpan duration = DateTime.Now - tpStime.Value;
            string formatDuration = string.Format("{0:D2}:{1:D2}", (int)duration.TotalHours, duration.Minutes);
            txtTime.Text = formatDuration;

            int hours = int.Parse(formatDuration.Split(':')[0]);
            int minutes = int.Parse(formatDuration.Split(':')[1]);
            decimal tamTinh = (hours + (minutes / 60.0m)) * decimal.Parse(txtPrice.Text);
            txtTamtinh.Text = Math.Round(tamTinh, 2).ToString();

            if (us.ComStatus == 0)
            {
                txtTT.Text = "Offline";
            }
            else
            {
                txtTT.Text = "Online";
            }
            bid = us.BillId;
        }
        void LoadFoodDetail(byte comid)
        {
            lvFood.Items.Clear();
            List<FoodPerCom> fl = FoodPerComDAL.Instance.GetFoodDetail(comid);
            decimal fcost = 0m;
            foreach (FoodPerCom f in fl)
            {
                ListViewItem lvi = new ListViewItem(f.FoodName.ToString());
                lvi.SubItems.Add(f.Price.ToString());
                lvi.SubItems.Add(f.Count.ToString());
                lvi.SubItems.Add(f.Cost.ToString());

                fcost += f.Cost;
                lvFood.Items.Add(lvi);
            }
            txtFcost.Text = fcost.ToString();
            CultureInfo ct = new CultureInfo("vi-VN");
            txtTotal.Text = (decimal.Parse(txtTamtinh.Text) + decimal.Parse(txtFcost.Text)).ToString("c", ct);
        }
        void ChangeColorZoneBtn(object sender, EventArgs e )
        {
            foreach(Control c in pnlZone.Controls)
            {
                c.BackColor = Color.FromArgb(37, 42, 64);
            }
            Control cl = (Control)sender;
            cl.BackColor = Color.FromArgb(0, 126, 249);

        }
        void ChangeColorComBtn(object sender, EventArgs e)
        {
            foreach (Control c in flpCom.Controls)
            {
                if (c.Text.Contains("Online"))
                {
                    c.BackColor = Color.Aqua;
                }
                if (c.Text.Contains("Offline"))
                {
                    c.BackColor = Color.LightGray;
                }

            }
            Control cl = (Control)sender;
            if (cl.Text.Contains("Online"))
            {
                cl.BackColor = Color.FromArgb(100, 228, 178);
            }
            if (cl.Text.Contains("Offline"))
            {
                cl.BackColor = Color.FromArgb(200, 200, 100);
            }

        }


        #endregion

        #endregion

        
    }
}
