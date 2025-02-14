using Application.Features.ExamResults.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ExamResults.Commands.Create;

public class CreateExamResultCommand : IRequest<CreatedExamResultResponse>
{
    public int ExamStatusId { get; set; }
    public int Correct { get; set; }
    public int Wrong { get; set; }
    public int Empty { get; set; }
    public int Point { get; set; }

    public class CreateExamResultCommandHandler : IRequestHandler<CreateExamResultCommand, CreatedExamResultResponse>
    {
        private readonly IMapper _mapper;
        private readonly IExamResultRepository _examResultRepository;
        private readonly ExamResultBusinessRules _examResultBusinessRules;

        public CreateExamResultCommandHandler(IMapper mapper, IExamResultRepository examResultRepository,
                                         ExamResultBusinessRules examResultBusinessRules)
        {
            _mapper = mapper;
            _examResultRepository = examResultRepository;
            _examResultBusinessRules = examResultBusinessRules;
        }

        public async Task<CreatedExamResultResponse> Handle(CreateExamResultCommand request, CancellationToken cancellationToken)
        {
            ExamResult examResult = _mapper.Map<ExamResult>(request);

            await _examResultRepository.AddAsync(examResult);

            CreatedExamResultResponse response = _mapper.Map<CreatedExamResultResponse>(examResult);
            return response;
        }
    }
}