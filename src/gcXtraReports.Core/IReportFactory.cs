using DevExpress.XtraReports.UI;

namespace GeniusCode.XtraReports
{
    public interface IReportFactory
    {
        XtraReport GetReportByKey(string key);
    }
}
