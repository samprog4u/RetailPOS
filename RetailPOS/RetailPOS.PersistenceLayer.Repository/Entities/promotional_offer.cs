//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RetailPOS.PersistenceLayer.Repository.Entities
{
    public partial class promotional_offer : EntityBase
    {
        #region Primitive Properties
    
        public virtual long id
        {
            get;
            set;
        }
    
        public virtual string name
        {
            get;
            set;
        }
    
        public virtual string description
        {
            get;
            set;
        }
    
        public virtual System.DateTime start_date
        {
            get;
            set;
        }
    
        public virtual System.DateTime end_date
        {
            get;
            set;
        }
    
        public virtual short purchase_quantity
        {
            get;
            set;
        }
    
        public virtual Nullable<short> offer_quantity
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> offer_percentage
        {
            get;
            set;
        }

        #endregion
    }
}
