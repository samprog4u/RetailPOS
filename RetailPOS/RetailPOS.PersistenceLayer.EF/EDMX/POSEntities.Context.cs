//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;
using RetailPOS.PersistenceLayer.Repository.Entities;
namespace RetailPOS.PersistenceLayer.EF.EDMX
{
    public partial class posEntities : ObjectContext
    {
        public const string ConnectionString = "name=posEntities";
        public const string ContainerName = "posEntities";
    
        #region Constructors
    
        public posEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public posEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public posEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<address> addresses
        {
            get { return _addresses  ?? (_addresses = CreateObjectSet<address>("addresses")); }
        }
        private ObjectSet<address> _addresses;
    
        public ObjectSet<country> countries
        {
            get { return _countries  ?? (_countries = CreateObjectSet<country>("countries")); }
        }
        private ObjectSet<country> _countries;
    
        public ObjectSet<customer> customers
        {
            get { return _customers  ?? (_customers = CreateObjectSet<customer>("customers")); }
        }
        private ObjectSet<customer> _customers;
    
        public ObjectSet<customer_pay_card_details> customer_pay_card_details
        {
            get { return _customer_pay_card_details  ?? (_customer_pay_card_details = CreateObjectSet<customer_pay_card_details>("customer_pay_card_details")); }
        }
        private ObjectSet<customer_pay_card_details> _customer_pay_card_details;
    
        public ObjectSet<customer_pay_cheque_details> customer_pay_cheque_details
        {
            get { return _customer_pay_cheque_details  ?? (_customer_pay_cheque_details = CreateObjectSet<customer_pay_cheque_details>("customer_pay_cheque_details")); }
        }
        private ObjectSet<customer_pay_cheque_details> _customer_pay_cheque_details;
    
        public ObjectSet<customer_pay_history> customer_pay_history
        {
            get { return _customer_pay_history  ?? (_customer_pay_history = CreateObjectSet<customer_pay_history>("customer_pay_history")); }
        }
        private ObjectSet<customer_pay_history> _customer_pay_history;
    
        public ObjectSet<customer_status> customer_status
        {
            get { return _customer_status  ?? (_customer_status = CreateObjectSet<customer_status>("customer_status")); }
        }
        private ObjectSet<customer_status> _customer_status;
    
        public ObjectSet<customer_type> customer_type
        {
            get { return _customer_type  ?? (_customer_type = CreateObjectSet<customer_type>("customer_type")); }
        }
        private ObjectSet<customer_type> _customer_type;
    
        public ObjectSet<department> departments
        {
            get { return _departments  ?? (_departments = CreateObjectSet<department>("departments")); }
        }
        private ObjectSet<department> _departments;
    
        public ObjectSet<designation> designations
        {
            get { return _designations  ?? (_designations = CreateObjectSet<designation>("designations")); }
        }
        private ObjectSet<designation> _designations;
    
        public ObjectSet<display_properties> display_properties
        {
            get { return _display_properties  ?? (_display_properties = CreateObjectSet<display_properties>("display_properties")); }
        }
        private ObjectSet<display_properties> _display_properties;
    
        public ObjectSet<email_history> email_history
        {
            get { return _email_history  ?? (_email_history = CreateObjectSet<email_history>("email_history")); }
        }
        private ObjectSet<email_history> _email_history;
    
        public ObjectSet<email_templates> email_templates
        {
            get { return _email_templates  ?? (_email_templates = CreateObjectSet<email_templates>("email_templates")); }
        }
        private ObjectSet<email_templates> _email_templates;
    
        public ObjectSet<general_settings> general_settings
        {
            get { return _general_settings  ?? (_general_settings = CreateObjectSet<general_settings>("general_settings")); }
        }
        private ObjectSet<general_settings> _general_settings;
    
        public ObjectSet<locality> localities
        {
            get { return _localities  ?? (_localities = CreateObjectSet<locality>("localities")); }
        }
        private ObjectSet<locality> _localities;
    
        public ObjectSet<login_history> login_history
        {
            get { return _login_history  ?? (_login_history = CreateObjectSet<login_history>("login_history")); }
        }
        private ObjectSet<login_history> _login_history;
    
        public ObjectSet<measure_unit> measure_unit
        {
            get { return _measure_unit  ?? (_measure_unit = CreateObjectSet<measure_unit>("measure_unit")); }
        }
        private ObjectSet<measure_unit> _measure_unit;
    
        public ObjectSet<measure_unit_conversion> measure_unit_conversion
        {
            get { return _measure_unit_conversion  ?? (_measure_unit_conversion = CreateObjectSet<measure_unit_conversion>("measure_unit_conversion")); }
        }
        private ObjectSet<measure_unit_conversion> _measure_unit_conversion;
    
        public ObjectSet<openid_server> openid_server
        {
            get { return _openid_server  ?? (_openid_server = CreateObjectSet<openid_server>("openid_server")); }
        }
        private ObjectSet<openid_server> _openid_server;
    
        public ObjectSet<orderchild> orderchilds
        {
            get { return _orderchilds  ?? (_orderchilds = CreateObjectSet<orderchild>("orderchilds")); }
        }
        private ObjectSet<orderchild> _orderchilds;
    
        public ObjectSet<ordermaster> ordermasters
        {
            get { return _ordermasters  ?? (_ordermasters = CreateObjectSet<ordermaster>("ordermasters")); }
        }
        private ObjectSet<ordermaster> _ordermasters;
    
        public ObjectSet<postcode> postcodes
        {
            get { return _postcodes  ?? (_postcodes = CreateObjectSet<postcode>("postcodes")); }
        }
        private ObjectSet<postcode> _postcodes;
    
        public ObjectSet<product> products
        {
            get { return _products  ?? (_products = CreateObjectSet<product>("products")); }
        }
        private ObjectSet<product> _products;
    
        public ObjectSet<product_category> product_category
        {
            get { return _product_category  ?? (_product_category = CreateObjectSet<product_category>("product_category")); }
        }
        private ObjectSet<product_category> _product_category;
    
        public ObjectSet<product_promotional_offer> product_promotional_offer
        {
            get { return _product_promotional_offer  ?? (_product_promotional_offer = CreateObjectSet<product_promotional_offer>("product_promotional_offer")); }
        }
        private ObjectSet<product_promotional_offer> _product_promotional_offer;
    
        public ObjectSet<product_purchase_history_child> product_purchase_history_child
        {
            get { return _product_purchase_history_child  ?? (_product_purchase_history_child = CreateObjectSet<product_purchase_history_child>("product_purchase_history_child")); }
        }
        private ObjectSet<product_purchase_history_child> _product_purchase_history_child;
    
        public ObjectSet<product_purchase_history_master> product_purchase_history_master
        {
            get { return _product_purchase_history_master  ?? (_product_purchase_history_master = CreateObjectSet<product_purchase_history_master>("product_purchase_history_master")); }
        }
        private ObjectSet<product_purchase_history_master> _product_purchase_history_master;
    
        public ObjectSet<product_status> product_status
        {
            get { return _product_status  ?? (_product_status = CreateObjectSet<product_status>("product_status")); }
        }
        private ObjectSet<product_status> _product_status;
    
        public ObjectSet<promotional_offer> promotional_offer
        {
            get { return _promotional_offer  ?? (_promotional_offer = CreateObjectSet<promotional_offer>("promotional_offer")); }
        }
        private ObjectSet<promotional_offer> _promotional_offer;
    
        public ObjectSet<query> queries
        {
            get { return _queries  ?? (_queries = CreateObjectSet<query>("queries")); }
        }
        private ObjectSet<query> _queries;
    
        public ObjectSet<security_group> security_group
        {
            get { return _security_group  ?? (_security_group = CreateObjectSet<security_group>("security_group")); }
        }
        private ObjectSet<security_group> _security_group;
    
        public ObjectSet<shop_info> shop_info
        {
            get { return _shop_info  ?? (_shop_info = CreateObjectSet<shop_info>("shop_info")); }
        }
        private ObjectSet<shop_info> _shop_info;
    
        public ObjectSet<shop_product> shop_product
        {
            get { return _shop_product  ?? (_shop_product = CreateObjectSet<shop_product>("shop_product")); }
        }
        private ObjectSet<shop_product> _shop_product;
    
        public ObjectSet<staff> staffs
        {
            get { return _staffs  ?? (_staffs = CreateObjectSet<staff>("staffs")); }
        }
        private ObjectSet<staff> _staffs;
    
        public ObjectSet<staff_status> staff_status
        {
            get { return _staff_status  ?? (_staff_status = CreateObjectSet<staff_status>("staff_status")); }
        }
        private ObjectSet<staff_status> _staff_status;
    
        public ObjectSet<street> streets
        {
            get { return _streets  ?? (_streets = CreateObjectSet<street>("streets")); }
        }
        private ObjectSet<street> _streets;
    
        public ObjectSet<supplier> suppliers
        {
            get { return _suppliers  ?? (_suppliers = CreateObjectSet<supplier>("suppliers")); }
        }
        private ObjectSet<supplier> _suppliers;
    
        public ObjectSet<supplier_contact_person> supplier_contact_person
        {
            get { return _supplier_contact_person  ?? (_supplier_contact_person = CreateObjectSet<supplier_contact_person>("supplier_contact_person")); }
        }
        private ObjectSet<supplier_contact_person> _supplier_contact_person;
    
        public ObjectSet<town_city> town_city
        {
            get { return _town_city  ?? (_town_city = CreateObjectSet<town_city>("town_city")); }
        }
        private ObjectSet<town_city> _town_city;
    
        public ObjectSet<warranty> warranties
        {
            get { return _warranties  ?? (_warranties = CreateObjectSet<warranty>("warranties")); }
        }
        private ObjectSet<warranty> _warranties;
    
        public ObjectSet<working_record> working_record
        {
            get { return _working_record  ?? (_working_record = CreateObjectSet<working_record>("working_record")); }
        }
        private ObjectSet<working_record> _working_record;

        #endregion
    }
}
