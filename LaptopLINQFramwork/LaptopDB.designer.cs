﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaptopLINQFramwork
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LaptopDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSheet1_(Sheet1_ instance);
    partial void UpdateSheet1_(Sheet1_ instance);
    partial void DeleteSheet1_(Sheet1_ instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LaptopLINQFramwork.Properties.Settings.Default.LaptopDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Sheet1_> Sheet1_s
		{
			get
			{
				return this.GetTable<Sheet1_>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sheet1$")]
	public partial class Sheet1_ : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _LaptopID;
		
		private string _LaptopName;
		
		private string _LaptopType;
		
		private System.Nullable<System.DateTime> _ProductDate;
		
		private string _Processor;
		
		private string _HDD;
		
		private string _RAM;
		
		private System.Nullable<double> _Price;
		
		private string _ImageName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLaptopIDChanging(string value);
    partial void OnLaptopIDChanged();
    partial void OnLaptopNameChanging(string value);
    partial void OnLaptopNameChanged();
    partial void OnLaptopTypeChanging(string value);
    partial void OnLaptopTypeChanged();
    partial void OnProductDateChanging(System.Nullable<System.DateTime> value);
    partial void OnProductDateChanged();
    partial void OnProcessorChanging(string value);
    partial void OnProcessorChanged();
    partial void OnHDDChanging(string value);
    partial void OnHDDChanged();
    partial void OnRAMChanging(string value);
    partial void OnRAMChanged();
    partial void OnPriceChanging(System.Nullable<double> value);
    partial void OnPriceChanged();
    partial void OnImageNameChanging(string value);
    partial void OnImageNameChanged();
    #endregion
		
		public Sheet1_()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaptopID", DbType="NVarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string LaptopID
		{
			get
			{
				return this._LaptopID;
			}
			set
			{
				if ((this._LaptopID != value))
				{
					this.OnLaptopIDChanging(value);
					this.SendPropertyChanging();
					this._LaptopID = value;
					this.SendPropertyChanged("LaptopID");
					this.OnLaptopIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaptopName", DbType="NVarChar(255)")]
		public string LaptopName
		{
			get
			{
				return this._LaptopName;
			}
			set
			{
				if ((this._LaptopName != value))
				{
					this.OnLaptopNameChanging(value);
					this.SendPropertyChanging();
					this._LaptopName = value;
					this.SendPropertyChanged("LaptopName");
					this.OnLaptopNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaptopType", DbType="NVarChar(255)")]
		public string LaptopType
		{
			get
			{
				return this._LaptopType;
			}
			set
			{
				if ((this._LaptopType != value))
				{
					this.OnLaptopTypeChanging(value);
					this.SendPropertyChanging();
					this._LaptopType = value;
					this.SendPropertyChanged("LaptopType");
					this.OnLaptopTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ProductDate
		{
			get
			{
				return this._ProductDate;
			}
			set
			{
				if ((this._ProductDate != value))
				{
					this.OnProductDateChanging(value);
					this.SendPropertyChanging();
					this._ProductDate = value;
					this.SendPropertyChanged("ProductDate");
					this.OnProductDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Processor", DbType="NVarChar(255)")]
		public string Processor
		{
			get
			{
				return this._Processor;
			}
			set
			{
				if ((this._Processor != value))
				{
					this.OnProcessorChanging(value);
					this.SendPropertyChanging();
					this._Processor = value;
					this.SendPropertyChanged("Processor");
					this.OnProcessorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HDD", DbType="NVarChar(255)")]
		public string HDD
		{
			get
			{
				return this._HDD;
			}
			set
			{
				if ((this._HDD != value))
				{
					this.OnHDDChanging(value);
					this.SendPropertyChanging();
					this._HDD = value;
					this.SendPropertyChanged("HDD");
					this.OnHDDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAM", DbType="NVarChar(255)")]
		public string RAM
		{
			get
			{
				return this._RAM;
			}
			set
			{
				if ((this._RAM != value))
				{
					this.OnRAMChanging(value);
					this.SendPropertyChanging();
					this._RAM = value;
					this.SendPropertyChanged("RAM");
					this.OnRAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageName", DbType="NVarChar(255)")]
		public string ImageName
		{
			get
			{
				return this._ImageName;
			}
			set
			{
				if ((this._ImageName != value))
				{
					this.OnImageNameChanging(value);
					this.SendPropertyChanging();
					this._ImageName = value;
					this.SendPropertyChanged("ImageName");
					this.OnImageNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
