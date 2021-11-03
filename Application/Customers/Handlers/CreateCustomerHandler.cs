using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Shop.Application.Customers.Commands;

namespace Shop.Application.Customers.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //validações
            //salva
            //açoes apos salvar

            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Alberto Barros",
                Email = "alberto.barros@email.com",
                CreateaAt = System.DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}