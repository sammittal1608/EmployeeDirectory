﻿using Models;
using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IJobTitleRepository
    {
        public Task<DBJobTitle> Add(DBJobTitle dbjobTitle);
        public Task<DBJobTitle> GetById(int JobTitleId);
        public Task<List<DBJobTitle>> GetAll();
        
    }
}
