﻿using iCMS.Common.Component.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCMS.Common.Component.Data.Request.Cloud
{
    public class MonitorTreeListByMTTypeParameter : BaseRequest
    {
        public int MonitorTreeTypeID { get; set; }
    }
}
