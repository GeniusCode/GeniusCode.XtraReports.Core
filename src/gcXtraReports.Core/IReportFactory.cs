using System;
using System.Collections.Generic;
using System.Linq;
﻿using DevExpress.XtraReports.UI;

namespace GeniusCode.XtraReports
{
    public interface IReportFactory
    {
        XtraReport GetReportByKey(string key);
        byte[] GetSerializedReportByKey(string key);
        IEnumerable<string> GetAvailableReportKeys();
    }
}
