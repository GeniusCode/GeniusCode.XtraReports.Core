using System;
using System.Linq;

namespace GeniusCode.XtraReports
{
    public interface IReportDatasourceMetadataWithTraversal : IReportDatasourceMetadata
    {
        string TraversalPath { get; }
        Type TraversedDataSourceType { get; }
    }
}