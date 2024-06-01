﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillingDAL
    {
        #region ---------- Code cua HungTuLenh 
        private static BillingDAL instance;

        public static BillingDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillingDAL();
                }
                return BillingDAL.instance;
            }
            private set { BillingDAL.instance = value; }
        }
        private BillingDAL() { }

        public List<BillingHis> loadBillList(DateTime ngaybd, DateTime ngaykt)
        {
            List<BillingHis> bl = new List<BillingHis>();
            string query = "GetBillByDate @ngaybd , @ngaykt";
            DataTable dt = Database.Instance.ExecuteQuery(query, new object[] { ngaybd, ngaykt });
            foreach (DataRow dr in dt.Rows)
            {
                BillingHis hd = new BillingHis(dr);
                bl.Add(hd);
            }
            return bl;
        }

        public void CheckOut(int billid, byte emid)
        {
            string query = string.Format("ProcCheckOut @billingid , @employeeid");
            Database.Instance.ExecuteNonQuery(query, new object[] { billid, emid });
        }

        public void CheckOutMaintainance(int billid, byte emid, decimal cost, byte comid)
        {
            string nonquery = string.Format("UPDATE Maintainance SET Cost = {0} WHERE billingid = {1}", cost, billid);
            Database.Instance.ExecuteNonQuery(nonquery);
            string query = string.Format("ProcCheckOut @billingid , @employeeid");
            Database.Instance.ExecuteNonQuery(query, new object[] { billid, emid });
            Database.Instance.ExecuteNonQuery("ProcComputerStatus @computerID , 0", new object[] { comid });
            #endregion
        }
    }
}

