using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace OnlineMuhasebeServer.Application.Messaging
{
    public interface IQueryHandler<in TQuery,TResponse>:IRequestHandler<TQuery,TResponse> where TQuery:IQuery<TResponse>
    {
    }
}
