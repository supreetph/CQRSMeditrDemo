using DataLib.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Commands
{
  public  class Command: IRequest<Person>
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}
