using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Application.Features.Branch.Command
{
    public class CreateCommandCommandHadler:IRequestHandler<CreateBranchCommand,int>
    {
        public CreateCommandCommandHadler() 
        {
        }
        public async Task<int> Handle (CreateBranchCommand request, CancellationToken cancellationToken)
        {
            return 1;
        }
    }
}
