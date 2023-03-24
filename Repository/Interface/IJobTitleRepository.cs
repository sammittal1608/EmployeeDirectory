﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IJobTitleRepository
    {
        public JobTitle Add(JobTitle jobTitle);
        public JobTitle GetById(int JobTitleId);
        public List<JobTitle> GetAll();
    }
}
