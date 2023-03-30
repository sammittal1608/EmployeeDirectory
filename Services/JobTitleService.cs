using AutoMapper;
using Models.DBModels;
using Models;
using Repository.Interface;
using Services.Interface;

public class JobTitleService : IJobTitleService
{
    private readonly IJobTitleRepository _jobTitleRepository;
    private readonly IMapper _mapper;

    public JobTitleService(IJobTitleRepository jobTitleRepository, IMapper mapper)
    {
        _jobTitleRepository = jobTitleRepository;
        _mapper = mapper;
    }

    public async Task<JobTitle> AddJobTitle(JobTitle jobTitle)
    {
        var dbJobTitle = _mapper.Map<DBJobTitle>(jobTitle);
        dbJobTitle = await _jobTitleRepository.Add(dbJobTitle);
        var addedJobTitle = _mapper.Map<JobTitle>(dbJobTitle);
        return addedJobTitle;
    }

    public async Task<List<JobTitle>> GetAllJobTitles()
    {
        List<DBJobTitle> dbjobTitles = await _jobTitleRepository.GetAll();
        List<JobTitle> jobTitles = dbjobTitles.Select(dbjobTitle => _mapper.Map<JobTitle>(dbjobTitle)).ToList();
        return jobTitles;
    }



    public async Task<JobTitle> GetJobTitleById(int id)
    {
        var dbJobTitle = await _jobTitleRepository.GetById(id);
        var jobTitle = _mapper.Map<JobTitle>(dbJobTitle);
        return jobTitle;
    }
}
