using System;

namespace Shop.Application.Customers.Commands
{
    public class CreateCustomerResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateaAt { get; set; }

    }
}