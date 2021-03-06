﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClasses
{
    /* 
        Author: Manish Sudani
    */

    // Travel Packages Class
    public class TravelPackage
    {
        // Private data for packages class
        private int pkgID;
        private string pkgName;
        private DateTime pkgStartDate;
        private DateTime pkgEndDate;
        private string pkgDesc;
        private decimal pkgBasePrice;
        private decimal pkgAgencyCommission;

        // Public getters and setters
        public int PkgID
        {
            get { return pkgID; }
            set { pkgID = value; }
        }
        public string PkgName
        {
            get { return pkgName; }
            set { pkgName = value; }
        }

        public DateTime PkgStartDate
        {
            get { return pkgStartDate; }
            set { pkgStartDate = value; }
        }

        public DateTime PkgEndDate
        {
            get { return pkgEndDate; }
            set { pkgEndDate = value; }
        }

        public string PkgDesc
        {
            get { return pkgDesc; }
            set { pkgDesc = value; }
        }

        public decimal PkgBasePrice
        {
            get { return pkgBasePrice; }
            set { pkgBasePrice = value; }
        }

        public decimal PkgAgencyCommission
        {
            get { return pkgAgencyCommission; }
            set { pkgAgencyCommission = value; }
        }

        // constructors, depricated
        //public TravelPackage (decimal ID, string name, string start, string end, string desc, decimal price, decimal commish)
        //{
        //    PkgID = ID;
        //    PkgName = name;
        //    PkgStartDate = start;
        //    PkgEndDate = end;
        //    PkgDesc = PkgDesc;
        //    PkgBasePrice = price;
        //    PkgAgencyCommission = commish;
        //}

        // Methods

        //write to file string method
        //public string ToFileString()
        //{
        //    return pkgName.ToString() + "," +
        //        pkgStartDate.ToString() + "," +
        //        pkgEndDate.ToString() + "," +
        //        pkgDesc.ToString() + "," +
        //        pkgBasePrice.ToString() + "," +
        //        pkgAgencyCommission.ToString();
        //}
    }
}
