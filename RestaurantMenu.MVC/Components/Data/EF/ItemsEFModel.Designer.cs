﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace DotNetNuclear.Modules.DataAccess.Components.EF
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ItemEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ItemEntities object using the connection string found in the 'ItemEntities' section of the application configuration file.
        /// </summary>
        public ItemEntities() : base("name=ItemEntities", "ItemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ItemEntities object.
        /// </summary>
        public ItemEntities(string connectionString) : base(connectionString, "ItemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ItemEntities object.
        /// </summary>
        public ItemEntities(EntityConnection connection) : base(connection, "ItemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Item> Items
        {
            get
            {
                if ((_Items == null))
                {
                    _Items = base.CreateObjectSet<Item>("Items");
                }
                return _Items;
            }
        }
        private ObjectSet<Item> _Items;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Items EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToItems(Item item)
        {
            base.AddObject("Items", item);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Item")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Item : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Item object.
        /// </summary>
        /// <param name="itemId">Initial value of the ItemId property.</param>
        /// <param name="itemName">Initial value of the ItemName property.</param>
        /// <param name="itemDescription">Initial value of the ItemDescription property.</param>
        /// <param name="moduleId">Initial value of the ModuleId property.</param>
        /// <param name="createdOnDate">Initial value of the CreatedOnDate property.</param>
        /// <param name="createdByUserId">Initial value of the CreatedByUserId property.</param>
        /// <param name="lastModifiedOnDate">Initial value of the LastModifiedOnDate property.</param>
        /// <param name="lastModifiedByUserId">Initial value of the LastModifiedByUserId property.</param>
        public static Item CreateItem(global::System.Int32 itemId, global::System.String itemName, global::System.String itemDescription, global::System.Int32 moduleId, global::System.DateTime createdOnDate, global::System.Int32 createdByUserId, global::System.DateTime lastModifiedOnDate, global::System.Int32 lastModifiedByUserId)
        {
            Item item = new Item();
            item.ItemId = itemId;
            item.ItemName = itemName;
            item.ItemDescription = itemDescription;
            item.ModuleId = moduleId;
            item.CreatedOnDate = createdOnDate;
            item.CreatedByUserId = createdByUserId;
            item.LastModifiedOnDate = lastModifiedOnDate;
            item.LastModifiedByUserId = lastModifiedByUserId;
            return item;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ItemId
        {
            get
            {
                return _ItemId;
            }
            set
            {
                if (_ItemId != value)
                {
                    OnItemIdChanging(value);
                    ReportPropertyChanging("ItemId");
                    _ItemId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ItemId");
                    OnItemIdChanged();
                }
            }
        }
        private global::System.Int32 _ItemId;
        partial void OnItemIdChanging(global::System.Int32 value);
        partial void OnItemIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ItemName
        {
            get
            {
                return _ItemName;
            }
            set
            {
                OnItemNameChanging(value);
                ReportPropertyChanging("ItemName");
                _ItemName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ItemName");
                OnItemNameChanged();
            }
        }
        private global::System.String _ItemName;
        partial void OnItemNameChanging(global::System.String value);
        partial void OnItemNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ItemDescription
        {
            get
            {
                return _ItemDescription;
            }
            set
            {
                OnItemDescriptionChanging(value);
                ReportPropertyChanging("ItemDescription");
                _ItemDescription = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ItemDescription");
                OnItemDescriptionChanged();
            }
        }
        private global::System.String _ItemDescription;
        partial void OnItemDescriptionChanging(global::System.String value);
        partial void OnItemDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> AssignedUserId
        {
            get
            {
                return _AssignedUserId;
            }
            set
            {
                OnAssignedUserIdChanging(value);
                ReportPropertyChanging("AssignedUserId");
                _AssignedUserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AssignedUserId");
                OnAssignedUserIdChanged();
            }
        }
        private Nullable<global::System.Int32> _AssignedUserId;
        partial void OnAssignedUserIdChanging(Nullable<global::System.Int32> value);
        partial void OnAssignedUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ModuleId
        {
            get
            {
                return _ModuleId;
            }
            set
            {
                OnModuleIdChanging(value);
                ReportPropertyChanging("ModuleId");
                _ModuleId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModuleId");
                OnModuleIdChanged();
            }
        }
        private global::System.Int32 _ModuleId;
        partial void OnModuleIdChanging(global::System.Int32 value);
        partial void OnModuleIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreatedOnDate
        {
            get
            {
                return _CreatedOnDate;
            }
            set
            {
                OnCreatedOnDateChanging(value);
                ReportPropertyChanging("CreatedOnDate");
                _CreatedOnDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreatedOnDate");
                OnCreatedOnDateChanged();
            }
        }
        private global::System.DateTime _CreatedOnDate;
        partial void OnCreatedOnDateChanging(global::System.DateTime value);
        partial void OnCreatedOnDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CreatedByUserId
        {
            get
            {
                return _CreatedByUserId;
            }
            set
            {
                OnCreatedByUserIdChanging(value);
                ReportPropertyChanging("CreatedByUserId");
                _CreatedByUserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreatedByUserId");
                OnCreatedByUserIdChanged();
            }
        }
        private global::System.Int32 _CreatedByUserId;
        partial void OnCreatedByUserIdChanging(global::System.Int32 value);
        partial void OnCreatedByUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastModifiedOnDate
        {
            get
            {
                return _LastModifiedOnDate;
            }
            set
            {
                OnLastModifiedOnDateChanging(value);
                ReportPropertyChanging("LastModifiedOnDate");
                _LastModifiedOnDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastModifiedOnDate");
                OnLastModifiedOnDateChanged();
            }
        }
        private global::System.DateTime _LastModifiedOnDate;
        partial void OnLastModifiedOnDateChanging(global::System.DateTime value);
        partial void OnLastModifiedOnDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 LastModifiedByUserId
        {
            get
            {
                return _LastModifiedByUserId;
            }
            set
            {
                OnLastModifiedByUserIdChanging(value);
                ReportPropertyChanging("LastModifiedByUserId");
                _LastModifiedByUserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastModifiedByUserId");
                OnLastModifiedByUserIdChanged();
            }
        }
        private global::System.Int32 _LastModifiedByUserId;
        partial void OnLastModifiedByUserIdChanging(global::System.Int32 value);
        partial void OnLastModifiedByUserIdChanged();

        #endregion

    
    }

    #endregion

    
}