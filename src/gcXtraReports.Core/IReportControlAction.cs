using System;
using DevExpress.XtraReports.UI;

namespace GeniusCode.XtraReports
{
    public interface IReportControlAction<T> : IReportControlAction
        where T : XRControl
    {
        Func<T, bool> Predicate { get; }
        new Action<T> ActionToApply { get; }
    }

    public interface IReportControlAction
    {
        Func<XRControl, bool> ActionPredicate { get; }
        Action<XRControl> ActionToApply { get; }
        Type ApplyToControlType { get; }

        string Name { get; }
        string Description { get; }
    }
}
