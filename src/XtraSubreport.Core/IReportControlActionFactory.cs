using System.Collections.Generic;

namespace GeniusCode.XtraReports
{
    public interface IReportControlActionFactory
    {
        IEnumerable<IReportControlAction> GetRuntimeActions();
    }
}
