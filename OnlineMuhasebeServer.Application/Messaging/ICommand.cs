using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace OnlineMuhasebeServer.Application.Messaging
{
    public interface ICommand<out TResponse>:IRequest<TResponse>
    {
    }
}
