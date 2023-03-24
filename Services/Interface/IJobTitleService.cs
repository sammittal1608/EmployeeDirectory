using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IJobTitleService
    {
        public JobTitle AddJobTitle(JobTitle jobTitle);
        public List<JobTitle> GetAllJobTitles();
        public JobTitle GetJobTitleById(int id);

    }
}
