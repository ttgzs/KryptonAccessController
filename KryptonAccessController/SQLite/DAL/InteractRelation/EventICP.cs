﻿/**  版本信息模板在安装目录下，可自行修改。
* EventICP.cs
*
* 功 能： N/A
* 类 名： EventICP
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:10:09   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace KryptonAccessController.SQLite.DAL.InteractRelation
{
	/// <summary>
	/// 数据访问类:EventICP
	/// </summary>
	public partial class EventICP
	{
		public EventICP()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("EventICPID", "EventICP"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EventICPID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EventICP");
			strSql.Append(" where EventICPID=@EventICPID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventICPID", DbType.Int32,4)			};
			parameters[0].Value = EventICPID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KryptonAccessController.SQLite.Model.InteractRelation.EventICP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EventICP(");
			strSql.Append("EventICPID,EventICPName,EventICPEnable,PointType,PointID,EventCodeID,ICPID)");
			strSql.Append(" values (");
			strSql.Append("@EventICPID,@EventICPName,@EventICPEnable,@PointType,@PointID,@EventCodeID,@ICPID)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventICPID", DbType.Int32,4),
					new SQLiteParameter("@EventICPName", DbType.String),
					new SQLiteParameter("@EventICPEnable", DbType.Boolean,1),
					new SQLiteParameter("@PointType", DbType.Int32,4),
					new SQLiteParameter("@PointID", DbType.Int32,4),
					new SQLiteParameter("@EventCodeID", DbType.Int32,4),
					new SQLiteParameter("@ICPID", DbType.Int32,4)};
			parameters[0].Value = model.EventICPID;
			parameters[1].Value = model.EventICPName;
			parameters[2].Value = model.EventICPEnable;
			parameters[3].Value = model.PointType;
			parameters[4].Value = model.PointID;
			parameters[5].Value = model.EventCodeID;
			parameters[6].Value = model.ICPID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(KryptonAccessController.SQLite.Model.InteractRelation.EventICP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EventICP set ");
			strSql.Append("EventICPName=@EventICPName,");
			strSql.Append("EventICPEnable=@EventICPEnable,");
			strSql.Append("PointType=@PointType,");
			strSql.Append("PointID=@PointID,");
			strSql.Append("EventCodeID=@EventCodeID,");
			strSql.Append("ICPID=@ICPID");
			strSql.Append(" where EventICPID=@EventICPID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventICPName", DbType.String),
					new SQLiteParameter("@EventICPEnable", DbType.Boolean,1),
					new SQLiteParameter("@PointType", DbType.Int32,4),
					new SQLiteParameter("@PointID", DbType.Int32,4),
					new SQLiteParameter("@EventCodeID", DbType.Int32,4),
					new SQLiteParameter("@ICPID", DbType.Int32,4),
					new SQLiteParameter("@EventICPID", DbType.Int32,4)};
			parameters[0].Value = model.EventICPName;
			parameters[1].Value = model.EventICPEnable;
			parameters[2].Value = model.PointType;
			parameters[3].Value = model.PointID;
			parameters[4].Value = model.EventCodeID;
			parameters[5].Value = model.ICPID;
			parameters[6].Value = model.EventICPID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int EventICPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventICP ");
			strSql.Append(" where EventICPID=@EventICPID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventICPID", DbType.Int32,4)			};
			parameters[0].Value = EventICPID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string EventICPIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EventICP ");
			strSql.Append(" where EventICPID in ("+EventICPIDlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KryptonAccessController.SQLite.Model.InteractRelation.EventICP GetModel(int EventICPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select EventICPID,EventICPName,EventICPEnable,PointType,PointID,EventCodeID,ICPID from EventICP ");
			strSql.Append(" where EventICPID=@EventICPID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@EventICPID", DbType.Int32,4)			};
			parameters[0].Value = EventICPID;

			KryptonAccessController.SQLite.Model.InteractRelation.EventICP model=new KryptonAccessController.SQLite.Model.InteractRelation.EventICP();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KryptonAccessController.SQLite.Model.InteractRelation.EventICP DataRowToModel(DataRow row)
		{
			KryptonAccessController.SQLite.Model.InteractRelation.EventICP model=new KryptonAccessController.SQLite.Model.InteractRelation.EventICP();
			if (row != null)
			{
				if(row["EventICPID"]!=null && row["EventICPID"].ToString()!="")
				{
					model.EventICPID=int.Parse(row["EventICPID"].ToString());
				}
				if(row["EventICPName"]!=null)
				{
					model.EventICPName=row["EventICPName"].ToString();
				}
				if(row["EventICPEnable"]!=null && row["EventICPEnable"].ToString()!="")
				{
					if((row["EventICPEnable"].ToString()=="1")||(row["EventICPEnable"].ToString().ToLower()=="true"))
					{
						model.EventICPEnable=true;
					}
					else
					{
						model.EventICPEnable=false;
					}
				}
				if(row["PointType"]!=null && row["PointType"].ToString()!="")
				{
					model.PointType=int.Parse(row["PointType"].ToString());
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["EventCodeID"]!=null && row["EventCodeID"].ToString()!="")
				{
					model.EventCodeID=int.Parse(row["EventCodeID"].ToString());
				}
				if(row["ICPID"]!=null && row["ICPID"].ToString()!="")
				{
					model.ICPID=int.Parse(row["ICPID"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select EventICPID,EventICPName,EventICPEnable,PointType,PointID,EventCodeID,ICPID ");
			strSql.Append(" FROM EventICP ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM EventICP ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.EventICPID desc");
			}
			strSql.Append(")AS Row, T.*  from EventICP T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.Boolean),
					new SQLiteParameter("@OrderType", DbType.Boolean),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "EventICP";
			parameters[1].Value = "EventICPID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

