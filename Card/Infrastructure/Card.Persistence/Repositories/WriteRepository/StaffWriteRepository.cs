﻿using BaseProject.Domain.Entities.Card.Definitions;
using BaseProject.Persistence.Contexts;
using Card.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace Card.Persistence.Repositories.WriteRepository
{
    public class StaffWriteRepository : T.WriteRepository<BaseProjectDbContext, Staff>, IStaffWriteRepository
    {
        public StaffWriteRepository(BaseProjectDbContext context) : base(context)
        {

        }
    }
}