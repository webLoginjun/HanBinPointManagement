﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using iCMS.Common.Component.Data.Request.DiagnosticAnalysis.MonitorTree;
using iCMS.Common.Component.Tool;
using iCMS.Common.Component.Tool.Extensions;
using iCMS.Common.Component.Data.Request;
using iCMS.Common.Component.Data.Base;
using iCMS.Common.Component.Data.Request.SystemInitSets;
using iCMS.Common.Component.Data.Request.DiagnosticControl;
using iCMS.Common.Component.Data.Request.WirelessSensors;

using iCMS.Common.Component.Data.Request.DiagnosticAnalysis;
using iCMS.Common.Component.Data.Request.Cloud;
using iCMS.Common.Component.Data.Enum;

using iCMS.Common.Component.Data.Request.DevicesConfig;
using iCMS.Common.Component.Data.Request.Statistics;

namespace TESTConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("http://localhost:2892/Web/StatisticsService");

            string method = "GetWSMaintainReportSimpleInfo";

            GetWSMaintainReportSimpleInfoParameter param = new GetWSMaintainReportSimpleInfoParameter();
            param.UserID = 1011;
            string json = param.ToClientString();

            string retPost = client.Post(json, method);

            Console.WriteLine("post请求：" + retPost);
            Console.ReadKey();
        }

        static Tuple<string, string, string> GetNames()
        {
            return new Tuple<string, string, string>("a", "b", "c");
        }
    }
}