﻿/************************************************************************************
 * Copyright (c) @ILine All Rights Reserved.
 *命名空间：
 *文件名：  
 *创建人：  QXM
 *创建时间：2016/7/21 10:10:13
 *描述：
/************************************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using iCMS.Common.Component.Data.Base.DB;

namespace iCMS.Frameworks.Core.DB.Models
{
    /// <summary>
    /// 连接状态类型表
    /// </summary>
    [Table("T_DICT_CONNECT_STATUS_TYPE")]
    public class ConnectStatusType : EntityBase
    {
        #region Model

        /// <summary>
        /// 主键ID
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 连接状态类型名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        public string Describe { get; set; }

        /// <summary>
        /// 0不可用，1可用
        /// </summary>
        public int IsUsable { get; set; }

        /// <summary>
        /// 0系统初始状态，1其它状态
        /// </summary>
        public int IsDefault { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int OrderNo { get; set; }

        #endregion Model
    }
}