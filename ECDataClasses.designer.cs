﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnvironmentMonitor
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EC")]
	public partial class ECDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertEnvironmentRecord(EnvironmentRecord instance);
    partial void UpdateEnvironmentRecord(EnvironmentRecord instance);
    partial void DeleteEnvironmentRecord(EnvironmentRecord instance);
    #endregion
		
		public ECDataClassesDataContext() : 
				base(global::EnvironmentMonitor.Properties.Settings.Default.ECConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ECDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ECDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ECDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ECDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EnvironmentRecord> EnvironmentRecord
		{
			get
			{
				return this.GetTable<EnvironmentRecord>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EnvironmentRecord")]
	public partial class EnvironmentRecord : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ID;
		
		private System.DateTime _CreateTime;
		
		private bool _DHTState;
		
		private string _ErrorMsg;
		
		private System.Nullable<int> _Humidity;
		
		private System.Nullable<int> _Temperature;
		
		private System.Nullable<int> _FlameValue;
		
		private System.Nullable<int> _MQValue;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(long value);
    partial void OnIDChanged();
    partial void OnCreateTimeChanging(System.DateTime value);
    partial void OnCreateTimeChanged();
    partial void OnDHTStateChanging(bool value);
    partial void OnDHTStateChanged();
    partial void OnErrorMsgChanging(string value);
    partial void OnErrorMsgChanged();
    partial void OnHumidityChanging(System.Nullable<int> value);
    partial void OnHumidityChanged();
    partial void OnTemperatureChanging(System.Nullable<int> value);
    partial void OnTemperatureChanged();
    partial void OnFlameValueChanging(System.Nullable<int> value);
    partial void OnFlameValueChanged();
    partial void OnMQValueChanging(System.Nullable<int> value);
    partial void OnMQValueChanged();
    #endregion
		
		public EnvironmentRecord()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateTime", DbType="DateTime NOT NULL")]
		public System.DateTime CreateTime
		{
			get
			{
				return this._CreateTime;
			}
			set
			{
				if ((this._CreateTime != value))
				{
					this.OnCreateTimeChanging(value);
					this.SendPropertyChanging();
					this._CreateTime = value;
					this.SendPropertyChanged("CreateTime");
					this.OnCreateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DHTState", DbType="Bit NOT NULL")]
		public bool DHTState
		{
			get
			{
				return this._DHTState;
			}
			set
			{
				if ((this._DHTState != value))
				{
					this.OnDHTStateChanging(value);
					this.SendPropertyChanging();
					this._DHTState = value;
					this.SendPropertyChanged("DHTState");
					this.OnDHTStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorMsg", DbType="NVarChar(150)")]
		public string ErrorMsg
		{
			get
			{
				return this._ErrorMsg;
			}
			set
			{
				if ((this._ErrorMsg != value))
				{
					this.OnErrorMsgChanging(value);
					this.SendPropertyChanging();
					this._ErrorMsg = value;
					this.SendPropertyChanged("ErrorMsg");
					this.OnErrorMsgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Humidity", DbType="Int")]
		public System.Nullable<int> Humidity
		{
			get
			{
				return this._Humidity;
			}
			set
			{
				if ((this._Humidity != value))
				{
					this.OnHumidityChanging(value);
					this.SendPropertyChanging();
					this._Humidity = value;
					this.SendPropertyChanged("Humidity");
					this.OnHumidityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Temperature", DbType="Int")]
		public System.Nullable<int> Temperature
		{
			get
			{
				return this._Temperature;
			}
			set
			{
				if ((this._Temperature != value))
				{
					this.OnTemperatureChanging(value);
					this.SendPropertyChanging();
					this._Temperature = value;
					this.SendPropertyChanged("Temperature");
					this.OnTemperatureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FlameValue", DbType="Int")]
		public System.Nullable<int> FlameValue
		{
			get
			{
				return this._FlameValue;
			}
			set
			{
				if ((this._FlameValue != value))
				{
					this.OnFlameValueChanging(value);
					this.SendPropertyChanging();
					this._FlameValue = value;
					this.SendPropertyChanged("FlameValue");
					this.OnFlameValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MQValue", DbType="Int")]
		public System.Nullable<int> MQValue
		{
			get
			{
				return this._MQValue;
			}
			set
			{
				if ((this._MQValue != value))
				{
					this.OnMQValueChanging(value);
					this.SendPropertyChanging();
					this._MQValue = value;
					this.SendPropertyChanged("MQValue");
					this.OnMQValueChanged();
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