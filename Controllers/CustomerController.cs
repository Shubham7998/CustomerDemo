using CustomerDemo.Data;
using CustomerDemo.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerDemo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerDbContext dbContext;

        public CustomerController(CustomerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return dbContext.Customers.ToList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return dbContext.Customers.Find(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer customer)
        {
            var oldCustomer = dbContext.Customers.Find(id);

            if (oldCustomer != null)
            {
                oldCustomer.Name = customer.Name;
                oldCustomer.Email = customer.Email;
                oldCustomer.Phone = customer.Phone;
                
                dbContext.Customers.Update(oldCustomer);
                dbContext.SaveChanges();
            }
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var oldCustomer = dbContext.Customers.Find(id);
            if (oldCustomer != null)
            {
                dbContext.Customers.Remove(oldCustomer);
                dbContext.SaveChanges();
            }
        }
    }
}
