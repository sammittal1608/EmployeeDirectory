using AutoMapper;
using Models;
using Models.DBModels;
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

    public async Task<JobTitle> GetJobTitleById(string id)
    {
        var dbJobTitle = await _jobTitleRepository.GetById(id);
        var jobTitle = _mapper.Map<JobTitle>(dbJobTitle);
        return jobTitle;
    }

    public async Task<bool> UpdateJobTitleCount(string newJobTitleId, string oldJobTitleId = null)
    {
        DBJobTitle dbNewJobTitle = await this._jobTitleRepository.GetById(newJobTitleId);
        dbNewJobTitle.Count++;
        await _jobTitleRepository.Update(dbNewJobTitle);

        if (oldJobTitleId != null)
        {
            DBJobTitle dbOldJobTitle = await this._jobTitleRepository.GetById(oldJobTitleId);
            dbOldJobTitle.Count--;
            await _jobTitleRepository.Update(dbOldJobTitle);
        }
        return true;
    }
}
