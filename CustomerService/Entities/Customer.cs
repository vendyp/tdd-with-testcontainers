namespace CustomerService.Entities;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;
} 