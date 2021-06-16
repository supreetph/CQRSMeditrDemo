using DataLib.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Read
{
    public class GetPersonListQuery:IRequest<List<Person>>
    {

    }
}
