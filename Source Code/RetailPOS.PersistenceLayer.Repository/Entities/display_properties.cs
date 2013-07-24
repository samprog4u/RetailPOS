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
    public partial class display_properties : EntityBase
    {
        #region Primitive Properties
    
        public virtual short product_id
        {
            get { return _product_id; }
            set
            {
                if (_product_id != value)
                {
                    if (product != null && product.id != value)
                    {
                        product = null;
                    }
                    _product_id = value;
                }
            }
        }
        private short _product_id;
    
        public virtual string text_color
        {
            get;
            set;
        }
    
        public virtual short font_size
        {
            get;
            set;
        }
    
        public virtual bool text_bold
        {
            get;
            set;
        }
    
        public virtual bool display_in_screen
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual product product
        {
            get { return _product; }
            set
            {
                if (!ReferenceEquals(_product, value))
                {
                    var previousValue = _product;
                    _product = value;
                    Fixupproduct(previousValue);
                }
            }
        }
        private product _product;

        #endregion
        #region Association Fixup
    
        private void Fixupproduct(product previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.display_properties, this))
            {
                previousValue.display_properties = null;
            }
    
            if (product != null)
            {
                product.display_properties = this;
                if (product_id != product.id)
                {
                    product_id = product.id;
                }
            }
        }

        #endregion
    }
}
