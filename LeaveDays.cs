namespace TodoApi;

public enum LeaveType
{
    PaidTimeOff,
    MaternalLeave,
    MedicalLeave,
}

public class LeaveRequest
{
    public DateOnly StartDate { get; set; }
    
    public DateOnly EndDate { get; set; }
    
    public LeaveType Type { get; set; }
}
