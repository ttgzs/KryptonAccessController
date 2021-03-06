﻿/**  版本信息模板在安装目录下，可自行修改。
* MediaVideoGroup.cs
*
* 功 能： N/A
* 类 名： MediaVideoGroup
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/9 17:09:02   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace KryptonAccessController.SQLite.Model.LCDRelation
{
	/// <summary>
	/// MediaVideoGroup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MediaVideoGroup
	{
		public MediaVideoGroup()
		{}
		#region Model
		private int _mediavideogroupid;
		private string _mediavideogroupname;
		private string _mediavideogroupdes;
		/// <summary>
		/// 
		/// </summary>
		public int MediaVideoGroupID
		{
			set{ _mediavideogroupid=value;}
			get{return _mediavideogroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MediaVideoGroupName
		{
			set{ _mediavideogroupname=value;}
			get{return _mediavideogroupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MediaVideoGroupDes
		{
			set{ _mediavideogroupdes=value;}
			get{return _mediavideogroupdes;}
		}
		#endregion Model

	}
}

