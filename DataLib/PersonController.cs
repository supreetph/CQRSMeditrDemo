using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataLib.Commands;
using DataLib.Model;
using MediatR;

namespace DataLib
{
  public  class PersonController
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<Person> Post(Person person)
        {
           // CancellationToken cancellationToken;
            var command = new Command
            {
                City = person.City,
                Name = person.Name
            };
            var response =await  mediator.Send(command);
            return response;
          

        }
    }
}
