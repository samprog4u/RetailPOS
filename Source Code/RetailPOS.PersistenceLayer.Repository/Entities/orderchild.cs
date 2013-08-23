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
    public partial class orderchild : EntityBase
    {
        #region Primitive Properties
    
        public virtual long order_id
        {
            get { return _order_id; }
            set
            {
                if (_order_id != value)
                {
                    if (ordermaster != null && ordermaster.id != value)
                    {
                        ordermaster = null;
                    }
                    _order_id = value;
                }
            }
        }
        private long _order_id;
    
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
    
        public virtual decimal quantity
        {
            get;
            set;
        }
    
        public virtual short measure_unit_id
        {
            get { return _measure_unit_id; }
            set
            {
                if (_measure_unit_id != value)
                {
                    if (measure_unit != null && measure_unit.id != value)
                    {
                        measure_unit = null;
                    }
                    _measure_unit_id = value;
                }
            }
        }
        private short _measure_unit_id;
    
        public virtual decimal amount
        {
            get;
            set;
        }
    
        public virtual int taxed
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> Discount
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> Retail_price
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual measure_unit measure_unit
        {
            get { return _measure_unit; }
            set
            {
                if (!ReferenceEquals(_measure_unit, value))
                {
                    var previousValue = _measure_unit;
                    _measure_unit = value;
                    Fixupmeasure_unit(previousValue);
                }
            }
        }
        private measure_unit _measure_unit;
    
        public virtual ordermaster ordermaster
        {
            get { return _ordermaster; }
            set
            {
                if (!ReferenceEquals(_ordermaster, value))
                {
                    var previousValue = _ordermaster;
                    _ordermaster = value;
                    Fixupordermaster(previousValue);
                }
            }
        }
        private ordermaster _ordermaster;
    
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
    
        private void Fixupmeasure_unit(measure_unit previousValue)
        {
            if (previousValue != null && previousValue.orderchilds.Contains(this))
            {
                previousValue.orderchilds.Remove(this);
            }
    
            if (measure_unit != null)
            {
                if (!measure_unit.orderchilds.Contains(this))
                {
                    measure_unit.orderchilds.Add(this);
                }
                if (measure_unit_id != measure_unit.id)
                {
                    measure_unit_id = measure_unit.id;
                }
            }
        }
    
        private void Fixupordermaster(ordermaster previousValue)
        {
            if (previousValue != null && previousValue.orderchilds.Contains(this))
            {
                previousValue.orderchilds.Remove(this);
            }
    
            if (ordermaster != null)
            {
                if (!ordermaster.orderchilds.Contains(this))
                {
                    ordermaster.orderchilds.Add(this);
                }
                if (order_id != ordermaster.id)
                {
                    order_id = ordermaster.id;
                }
            }
        }
    
        private void Fixupproduct(product previousValue)
        {
            if (previousValue != null && previousValue.orderchilds.Contains(this))
            {
                previousValue.orderchilds.Remove(this);
            }
    
            if (product != null)
            {
                if (!product.orderchilds.Contains(this))
                {
                    product.orderchilds.Add(this);
                }
                if (product_id != product.id)
                {
                    product_id = product.id;
                }
            }
        }

        #endregion
    }
}
