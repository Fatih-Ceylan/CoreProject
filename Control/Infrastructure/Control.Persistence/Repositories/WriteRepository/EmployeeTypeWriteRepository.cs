﻿using BaseProject.Domain.Entities.GControl.Definitions;
using BaseProject.Persistence.Contexts;
using GControl.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GControl.Persistence.Repositories.WriteRepository
{
    public class EmployeeTypeWriteRepository : T.WriteRepository<BaseProjectDbContext, EmployeeType>, IEmployeeTypeWriteRepository
    {
        public EmployeeTypeWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}