namespace MauiApp2;

public class MarsApplicationStateManager : IMarsApplicationStateManager
{
    public MarsApplicationStateManager(ReportStateContainer reportState)
    { 
        _reportState = reportState;
    }
    private ReportStateContainer _reportState;
    
    public ReportStateContainer ReportState
    {
        get
        {
            return _reportState ?? (_reportState = new ReportStateContainer());
        }
        set
        {
            _reportState = value;
        }
    }
}