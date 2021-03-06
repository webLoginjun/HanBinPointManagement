﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iCMS.Common.Component.Data.Base;

namespace iCMS.Common.Component.Data.Request.DAUAgent
{
    /// <summary>
    /// DAU Agent下发测量定义请求参数类
    /// </summary>
    public class SetDAUAgentMDFParameter : BaseRequest
    {
        public List<DAUAgentMDFParameter> DAUAgentMDFParams { get; set; }

        public SetDAUAgentMDFParameter()
        {
            DAUAgentMDFParams = new List<DAUAgentMDFParameter>();
        }
    }

    public class DAUAgentMDFParameter
    {
        /// <summary>
        /// DAU ID
        /// </summary>
        public int DAUID { get; set; }
        /// <summary>
        /// 波形测量定义
        /// </summary>
        public List<WaveMDF> WaveMDFList { get; set; }
        /// <summary>
        /// 转速测量定义
        /// </summary>
        public List<SpdMDF> SpdMDFList { get; set; }
        /// <summary>
        /// 温度测量定义
        /// </summary>
        public List<TemperatureMDF> TemperatureMDFList { get; set; }

        public DAUAgentMDFParameter()
        {
            this.WaveMDFList = new List<WaveMDF>();
            this.SpdMDFList = new List<SpdMDF>();
            this.TemperatureMDFList = new List<TemperatureMDF>();
        }
    }

    public class WaveMDF
    {
        /// <summary>
        /// 测点ID
        /// </summary>
        public int MSiteID { get; set; }

        /// <summary>
        /// 振动信号类型
        /// </summary>
        public int VibSingalType { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：通道ID
        /// </summary>
        public int ChannelId { get; set; }

        /// <summary>
        /// 关联通道ID（默认65535）
        /// </summary>
        public int RelateChnId { get; set; }

        /// <summary>
        /// 传感器校准系数A
        /// </summary>
        public float? SenserCalibrateparamaA { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：传感器校准系数B
        /// </summary>
        public float? SenserCalibrateparamaB { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：传感器灵敏度系数
        /// </summary>
        public float? SensorCoefficient { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：加速度采样时间
        /// </summary>
        public int? ACCSamplingTimePeriod { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：加速度下限频率
        /// </summary>
        public int? ACCFreqLowerLimit { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：加速度上限频率
        /// </summary>
        public int? ACCFreqUpperLimit { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：速度采样时间
        /// </summary>
        public int? VELSamplingTimePeriod { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：速度下限频率
        /// </summary>
        public int? VELFreqLowerLimit { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：速度上限频率
        /// </summary>
        public int? VELFreqUpperLimit { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：包络采样时间
        /// </summary>
        public int? ENVLSamplingTimePeriod { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：包络滤波器下限频率
        /// </summary>
        public int? ENVLFilterLowerLimit { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：包络滤波器上限频率
        /// </summary>
        public int? ENVLFilterUpperLimit { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：包络带宽
        /// </summary>
        public int? ENVLBand { get; set; }
    }

    public class SpdMDF
    {
        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：测量位置ID
        /// </summary>
        public int MSiteID { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：通道ID
        /// </summary>
        public int ChannelId { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-01-10
        /// 创建记录：脉冲数
        /// </summary>
        public float PulsNumPerP { get; set; }
    }

    /// <summary>
    /// 创建人：张辽阔
    /// 创建时间：2018-05-20
    /// 创建记录：温度测量定义
    /// </summary>
    public class TemperatureMDF
    {
        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-05-20
        /// 创建记录：寄存器的地址
        /// </summary>
        public int RegisterAddress { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-05-20
        /// 创建记录：寄存器存储方式（默认：2）
        /// </summary>
        public int StrEnumRegisterStorageMode { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-05-20
        /// 创建记录：寄存器存储字节序列模式（默认：2）
        /// </summary>
        public int StrEnumRegisterStorageSequenceMode { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-05-20
        /// 创建记录：寄存器类型（默认：1）
        /// </summary>
        public int StrEnumRegisterType { get; set; }

        /// <summary>
        /// 创建人：张辽阔
        /// 创建时间：2018-05-20
        /// 创建记录：寄存器的描述信息（默认：0）
        /// </summary>
        public int StrEnumRegisterInformation { get; set; }
    }
}