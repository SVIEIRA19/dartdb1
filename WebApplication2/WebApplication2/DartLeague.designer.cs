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

namespace WebApplication2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dartdb")]
	public partial class DartLeagueDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGame(Game instance);
    partial void UpdateGame(Game instance);
    partial void DeleteGame(Game instance);
    partial void InsertPlayer(Player instance);
    partial void UpdatePlayer(Player instance);
    partial void DeletePlayer(Player instance);
    #endregion
		
		public DartLeagueDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dartdbConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DartLeagueDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DartLeagueDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DartLeagueDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DartLeagueDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Game> Games
		{
			get
			{
				return this.GetTable<Game>();
			}
		}
		
		public System.Data.Linq.Table<Player> Players
		{
			get
			{
				return this.GetTable<Player>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Game")]
	public partial class Game : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _rounds;
		
		private System.Nullable<int> _bullsrounds;
		
		private System.Nullable<int> _bulldarts;
		
		private System.Nullable<int> _zerorounds;
		
		private System.Nullable<int> _playerID;
		
		private int _gameID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnroundsChanging(System.Nullable<int> value);
    partial void OnroundsChanged();
    partial void OnbullsroundsChanging(System.Nullable<int> value);
    partial void OnbullsroundsChanged();
    partial void OnbulldartsChanging(System.Nullable<int> value);
    partial void OnbulldartsChanged();
    partial void OnzeroroundsChanging(System.Nullable<int> value);
    partial void OnzeroroundsChanged();
    partial void OnplayerIDChanging(System.Nullable<int> value);
    partial void OnplayerIDChanged();
    partial void OngameIDChanging(int value);
    partial void OngameIDChanged();
    #endregion
		
		public Game()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rounds", DbType="Int")]
		public System.Nullable<int> rounds
		{
			get
			{
				return this._rounds;
			}
			set
			{
				if ((this._rounds != value))
				{
					this.OnroundsChanging(value);
					this.SendPropertyChanging();
					this._rounds = value;
					this.SendPropertyChanged("rounds");
					this.OnroundsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bullsrounds", DbType="Int")]
		public System.Nullable<int> bullsrounds
		{
			get
			{
				return this._bullsrounds;
			}
			set
			{
				if ((this._bullsrounds != value))
				{
					this.OnbullsroundsChanging(value);
					this.SendPropertyChanging();
					this._bullsrounds = value;
					this.SendPropertyChanged("bullsrounds");
					this.OnbullsroundsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bulldarts", DbType="Int")]
		public System.Nullable<int> bulldarts
		{
			get
			{
				return this._bulldarts;
			}
			set
			{
				if ((this._bulldarts != value))
				{
					this.OnbulldartsChanging(value);
					this.SendPropertyChanging();
					this._bulldarts = value;
					this.SendPropertyChanged("bulldarts");
					this.OnbulldartsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zerorounds", DbType="Int")]
		public System.Nullable<int> zerorounds
		{
			get
			{
				return this._zerorounds;
			}
			set
			{
				if ((this._zerorounds != value))
				{
					this.OnzeroroundsChanging(value);
					this.SendPropertyChanging();
					this._zerorounds = value;
					this.SendPropertyChanged("zerorounds");
					this.OnzeroroundsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_playerID", DbType="Int")]
		public System.Nullable<int> playerID
		{
			get
			{
				return this._playerID;
			}
			set
			{
				if ((this._playerID != value))
				{
					this.OnplayerIDChanging(value);
					this.SendPropertyChanging();
					this._playerID = value;
					this.SendPropertyChanged("playerID");
					this.OnplayerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gameID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int gameID
		{
			get
			{
				return this._gameID;
			}
			set
			{
				if ((this._gameID != value))
				{
					this.OngameIDChanging(value);
					this.SendPropertyChanging();
					this._gameID = value;
					this.SendPropertyChanged("gameID");
					this.OngameIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Players")]
	public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PlayerID;
		
		private string _PlayerName;
		
		private int _TotGames;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlayerIDChanging(int value);
    partial void OnPlayerIDChanged();
    partial void OnPlayerNameChanging(string value);
    partial void OnPlayerNameChanged();
    partial void OnTotGamesChanging(int value);
    partial void OnTotGamesChanged();
    #endregion
		
		public Player()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PlayerID
		{
			get
			{
				return this._PlayerID;
			}
			set
			{
				if ((this._PlayerID != value))
				{
					this.OnPlayerIDChanging(value);
					this.SendPropertyChanging();
					this._PlayerID = value;
					this.SendPropertyChanged("PlayerID");
					this.OnPlayerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string PlayerName
		{
			get
			{
				return this._PlayerName;
			}
			set
			{
				if ((this._PlayerName != value))
				{
					this.OnPlayerNameChanging(value);
					this.SendPropertyChanging();
					this._PlayerName = value;
					this.SendPropertyChanged("PlayerName");
					this.OnPlayerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotGames", DbType="Int NOT NULL")]
		public int TotGames
		{
			get
			{
				return this._TotGames;
			}
			set
			{
				if ((this._TotGames != value))
				{
					this.OnTotGamesChanging(value);
					this.SendPropertyChanging();
					this._TotGames = value;
					this.SendPropertyChanged("TotGames");
					this.OnTotGamesChanged();
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
