using CustomerService.Contracts.Requests;
using CustomerService.Database;
using CustomerService.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Controllers;

[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public CustomerController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("customers")]
    public async Task<List<Customer>> GetAll()
        => await _dbContext.Set<Customer>().ToListAsync();

    [HttpPost("customers")]
    public async Task<IActionResult> Create([FromBody] CustomerRequest customerRequest)
    {
        var customer = new Customer
        {
            Name = customerRequest.Name,
            Address = customerRequest.Address
        };

        _dbContext.Add(customer);

        await _dbContext.SaveChangesAsync();

        return Ok();
    }
}