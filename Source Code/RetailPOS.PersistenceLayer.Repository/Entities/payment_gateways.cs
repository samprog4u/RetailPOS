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
    public partial class payment_gateways : EntityBase
    {
        #region Primitive Properties
    
        public virtual string gateway
        {
            get;
            set;
        }
    
        public virtual string setting
        {
            get;
            set;
        }
    
        public virtual string value
        {
            get;
            set;
        }
    
        public virtual int sortorder
        {
            get;
            set;
        }

        #endregion
    }
}