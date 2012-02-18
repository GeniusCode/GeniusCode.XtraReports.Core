using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.XtraReports
{
    public interface IReportControlActionFactory
    {
        IEnumerable<IReportControlAction> GetRuntimeActions();
    }
}
