namespace Flow.Core.DTOs.Response;

public class ApiResponse
{
    public bool IsSuccessful { get; set; }
    public object Data { get; set; } = null!;
}