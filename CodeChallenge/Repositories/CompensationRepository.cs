﻿using CodeChallenge.Data;
using CodeChallenge.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Repositories
{
    public class CompensationRepository : ICompensationRepository
    {
        private readonly CompensationContext _compensationContext;
        private readonly ILogger<ICompensationRepository> _logger;

        public CompensationRepository(ILogger<ICompensationRepository> logger, CompensationContext compensationContext)
        {
            _compensationContext = compensationContext;
            _logger = logger;
        }

        public Compensation Add(Compensation compensation)
        {
            _compensationContext.Compensations.Add(compensation);
            return compensation;
        }

        public Compensation GetById(string id)
        {
            return _compensationContext.Compensations.SingleOrDefault(c => c.employee == id);
        }

        public Compensation Remove(Compensation compensation)
        {
            return _compensationContext.Remove(compensation).Entity;
        }

        public Task SaveAsync()
        {
            return _compensationContext.SaveChangesAsync();
        }
    }
}
