using System.Linq;
using System;

namespace GeniusCode.XtraReports
{
    public interface IReportDatasourceMetadata
    {
        string UniqueId { get; }
        string Name { get; }
        string Description { get; }
        Type DataSourceType { get; }
    }

    public interface IReportDatasourceMetadataWithTraversal : IReportDatasourceMetadata
    {
        string TraversalPath { get; }
        Type TraversedDataSourceType { get; }
    }
}