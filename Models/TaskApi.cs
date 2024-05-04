namespace TodoApi.Models;

public class Task
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsMandatory { get; set; }
    public TimeSpan ExpectedTime { get; set; }
}