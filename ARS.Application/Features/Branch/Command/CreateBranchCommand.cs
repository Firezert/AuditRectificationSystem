using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Application.Features.Branch.Command
{
    public class CreateBranchCommand:IRequest<int>
    {
        public string Name { get; set; }
        public string DistrictId { get; set; }
    }
}
