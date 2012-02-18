using System.Linq;
using System.Collections.Generic;

namespace GeniusCode.XtraReports
{
    public interface IReportDatasourceFactory
    {
        IEnumerable<IReportDatasourceMetadata> GetReportDatasources();
        object GetReportDatasource(string uniqueId);
    }
}
