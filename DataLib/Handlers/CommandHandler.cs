using DataLib.Commands;
using DataLib.DataAccess;
using DataLib.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataLib.Handlers
{
    public class CommandHandler : IRequestHandler<Command, Person>
    {
        private readonly IDemoDataAccess db;

        public CommandHandler(IDemoDataAccess db)
        {
            this.db = db;
        }
        public Task<Person> Handle(Command request, CancellationToken cancellationToken)
        {
            return Task.FromResult(db.AddPerson(request.Name,request.City));
        }
    }
}
