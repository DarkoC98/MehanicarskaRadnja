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

namespace Projekat
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Servis")]
	public partial class dataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertAutomobil(Automobil instance);
    partial void UpdateAutomobil(Automobil instance);
    partial void DeleteAutomobil(Automobil instance);
    #endregion
		
		public dataDataContext() : 
				base(global::Projekat.Properties.Settings.Default.ServisConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Automobil> Automobils
		{
			get
			{
				return this.GetTable<Automobil>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AdminID;
		
		private string _Ime;
		
		private int _AutoID;
		
		private string _Password;
		
		private EntityRef<Automobil> _Automobil;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdminIDChanging(int value);
    partial void OnAdminIDChanged();
    partial void OnImeChanging(string value);
    partial void OnImeChanged();
    partial void OnAutoIDChanging(int value);
    partial void OnAutoIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Admin()
		{
			this._Automobil = default(EntityRef<Automobil>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AdminID
		{
			get
			{
				return this._AdminID;
			}
			set
			{
				if ((this._AdminID != value))
				{
					this.OnAdminIDChanging(value);
					this.SendPropertyChanging();
					this._AdminID = value;
					this.SendPropertyChanged("AdminID");
					this.OnAdminIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ime", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Ime
		{
			get
			{
				return this._Ime;
			}
			set
			{
				if ((this._Ime != value))
				{
					this.OnImeChanging(value);
					this.SendPropertyChanging();
					this._Ime = value;
					this.SendPropertyChanged("Ime");
					this.OnImeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AutoID", DbType="Int NOT NULL")]
		public int AutoID
		{
			get
			{
				return this._AutoID;
			}
			set
			{
				if ((this._AutoID != value))
				{
					if (this._Automobil.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAutoIDChanging(value);
					this.SendPropertyChanging();
					this._AutoID = value;
					this.SendPropertyChanged("AutoID");
					this.OnAutoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Automobil_Admin", Storage="_Automobil", ThisKey="AutoID", OtherKey="AutoID", IsForeignKey=true)]
		public Automobil Automobil
		{
			get
			{
				return this._Automobil.Entity;
			}
			set
			{
				Automobil previousValue = this._Automobil.Entity;
				if (((previousValue != value) 
							|| (this._Automobil.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Automobil.Entity = null;
						previousValue.Admins.Remove(this);
					}
					this._Automobil.Entity = value;
					if ((value != null))
					{
						value.Admins.Add(this);
						this._AutoID = value.AutoID;
					}
					else
					{
						this._AutoID = default(int);
					}
					this.SendPropertyChanged("Automobil");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Automobil")]
	public partial class Automobil : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AutoID;
		
		private string _Marka;
		
		private string _Model;
		
		private int _Godiste;
		
		private string _Opis;
		
		private string _Registracija;
		
		private EntitySet<Admin> _Admins;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAutoIDChanging(int value);
    partial void OnAutoIDChanged();
    partial void OnMarkaChanging(string value);
    partial void OnMarkaChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnGodisteChanging(int value);
    partial void OnGodisteChanged();
    partial void OnOpisChanging(string value);
    partial void OnOpisChanged();
    partial void OnRegistracijaChanging(string value);
    partial void OnRegistracijaChanged();
    #endregion
		
		public Automobil()
		{
			this._Admins = new EntitySet<Admin>(new Action<Admin>(this.attach_Admins), new Action<Admin>(this.detach_Admins));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AutoID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AutoID
		{
			get
			{
				return this._AutoID;
			}
			set
			{
				if ((this._AutoID != value))
				{
					this.OnAutoIDChanging(value);
					this.SendPropertyChanging();
					this._AutoID = value;
					this.SendPropertyChanged("AutoID");
					this.OnAutoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Marka", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Marka
		{
			get
			{
				return this._Marka;
			}
			set
			{
				if ((this._Marka != value))
				{
					this.OnMarkaChanging(value);
					this.SendPropertyChanging();
					this._Marka = value;
					this.SendPropertyChanged("Marka");
					this.OnMarkaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Godiste", DbType="Int NOT NULL")]
		public int Godiste
		{
			get
			{
				return this._Godiste;
			}
			set
			{
				if ((this._Godiste != value))
				{
					this.OnGodisteChanging(value);
					this.SendPropertyChanging();
					this._Godiste = value;
					this.SendPropertyChanged("Godiste");
					this.OnGodisteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Opis", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Opis
		{
			get
			{
				return this._Opis;
			}
			set
			{
				if ((this._Opis != value))
				{
					this.OnOpisChanging(value);
					this.SendPropertyChanging();
					this._Opis = value;
					this.SendPropertyChanged("Opis");
					this.OnOpisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Registracija", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Registracija
		{
			get
			{
				return this._Registracija;
			}
			set
			{
				if ((this._Registracija != value))
				{
					this.OnRegistracijaChanging(value);
					this.SendPropertyChanging();
					this._Registracija = value;
					this.SendPropertyChanged("Registracija");
					this.OnRegistracijaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Automobil_Admin", Storage="_Admins", ThisKey="AutoID", OtherKey="AutoID")]
		public EntitySet<Admin> Admins
		{
			get
			{
				return this._Admins;
			}
			set
			{
				this._Admins.Assign(value);
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
		
		private void attach_Admins(Admin entity)
		{
			this.SendPropertyChanging();
			entity.Automobil = this;
		}
		
		private void detach_Admins(Admin entity)
		{
			this.SendPropertyChanging();
			entity.Automobil = null;
		}
	}
}
#pragma warning restore 1591
