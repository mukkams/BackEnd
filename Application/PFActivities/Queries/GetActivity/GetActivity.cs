using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Models.ProcessFlow;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;


namespace Application.PFActivities.Queries.GetActivities
{
    public class GetActiivity
    {
        public class Query : IRequest<PFActivity>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, PFActivity>
        {
            private readonly ProcessFlowDataContext _context;

            public Handler(ProcessFlowDataContext context)
            {
                _context = context;
                //_mapper = mapper;
            }



            //private readonly IApplicationDbContext _context;
            //private readonly IMapper _mapper;

            //public GetTodosQueryHandler(IApplicationDbContext context, IMapper mapper)
            //{
            //    _context = context;
            //    _mapper = mapper;
            //}

            //public async Task<TodosVm> Handle(GetTodosQuery request, CancellationToken cancellationToken)
            //{
            //    return new TodosVm
            //    {
            //        PriorityLevels = Enum.GetValues(typeof(PriorityLevel))
            //            .Cast<PriorityLevel>()
            //            .Select(p => new PriorityLevelDto { Value = (int)p, Name = p.ToString() })
            //            .ToList(),

            //        Lists = await _context.TodoLists
            //            .ProjectTo<TodoListDto>(_mapper.ConfigurationProvider)
            //            .OrderBy(t => t.Title)
            //            .ToListAsync(cancellationToken)
            //    };
            //}
            public async Task<PFActivity> Handle(Query request,
                CancellationToken cancellationToken)
            {
                return await _context.PFActivities.FindAsync(request.Id);
            }
        }
    }
}
