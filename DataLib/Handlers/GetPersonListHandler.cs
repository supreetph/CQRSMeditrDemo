using DataLib.DataAccess;
using DataLib.Model;
using DataLib.Read;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataLib.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<Person>>
    {
        private readonly IDemoDataAccess dataAccess;

        public GetPersonListHandler(IDemoDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<List<Person>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
           return  Task.FromResult(dataAccess.GetPeople());
        }
    }
}
