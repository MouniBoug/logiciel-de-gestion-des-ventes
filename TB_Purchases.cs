//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LGV
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Purchases
    {
        public int ID { get; set; }
        public Nullable<int> Category_id { get; set; }
        public Nullable<int> Supplier_id { get; set; }
        public string Purchase_Name { get; set; }
        public string Purchase_Type { get; set; }
        public string Purchase_Category { get; set; }
        public string Purchase_Supplier { get; set; }
        public string Purchase_Details { get; set; }
        public Nullable<double> Purchase__Buy { get; set; }
        public Nullable<double> Purchase_Sale { get; set; }
        public Nullable<double> Purchase_Qt { get; set; }
        public Nullable<double> Purchase_Tsell { get; set; }
        public Nullable<double> Purchase_Tbuy { get; set; }
        public Nullable<double> Purchase_Trev { get; set; }
    
        public virtual TB_Category TB_Category { get; set; }
        public virtual TB_Supp TB_Supp { get; set; }
    }
}
