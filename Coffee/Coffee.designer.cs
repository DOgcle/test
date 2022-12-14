#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coffee
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Coffee")]
	public partial class CoffeeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCoffee_(Coffee_ instance);
    partial void UpdateCoffee_(Coffee_ instance);
    partial void DeleteCoffee_(Coffee_ instance);
    #endregion
		
		public CoffeeDataContext() : 
				base(global::Coffee.Properties.Settings.Default.CoffeeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CoffeeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoffeeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoffeeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoffeeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Coffee_> Coffee_s
		{
			get
			{
				return this.GetTable<Coffee_>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Coffee$")]
	public partial class Coffee_ : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CofffeeID;
		
		private string _CoffeeName;
		
		private System.Nullable<System.DateTime> _ProductDate;
		
		private System.Nullable<System.DateTime> _OutOfDate;
		
		private System.Nullable<int> _Price;
		
		private string _ImageName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCofffeeIDChanging(string value);
    partial void OnCofffeeIDChanged();
    partial void OnCoffeeNameChanging(string value);
    partial void OnCoffeeNameChanged();
    partial void OnProductDateChanging(System.Nullable<System.DateTime> value);
    partial void OnProductDateChanged();
    partial void OnOutOfDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOutOfDateChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnImageNameChanging(string value);
    partial void OnImageNameChanged();
    #endregion
		
		public Coffee_()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CofffeeID", DbType="NVarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CofffeeID
		{
			get
			{
				return this._CofffeeID;
			}
			set
			{
				if ((this._CofffeeID != value))
				{
					this.OnCofffeeIDChanging(value);
					this.SendPropertyChanging();
					this._CofffeeID = value;
					this.SendPropertyChanged("CofffeeID");
					this.OnCofffeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoffeeName", DbType="NVarChar(255)")]
		public string CoffeeName
		{
			get
			{
				return this._CoffeeName;
			}
			set
			{
				if ((this._CoffeeName != value))
				{
					this.OnCoffeeNameChanging(value);
					this.SendPropertyChanging();
					this._CoffeeName = value;
					this.SendPropertyChanged("CoffeeName");
					this.OnCoffeeNameChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OutOfDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> OutOfDate
		{
			get
			{
				return this._OutOfDate;
			}
			set
			{
				if ((this._OutOfDate != value))
				{
					this.OnOutOfDateChanging(value);
					this.SendPropertyChanging();
					this._OutOfDate = value;
					this.SendPropertyChanged("OutOfDate");
					this.OnOutOfDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
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
