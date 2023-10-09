namespace CustomerService.Contracts.Requests;

public class CustomerRequest
{
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
}