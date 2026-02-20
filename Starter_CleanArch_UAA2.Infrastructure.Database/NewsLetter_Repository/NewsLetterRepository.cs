using Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Repositories;
using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter_CleanArch_UAA2.Infrastructure.Database.NewsLetter_Repository
{
    public class NewsLetterRepository : INewsLetterRepository
    {
        public bool Delete(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsLetterSample> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public NewsLetterSample GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsLetterSample> GetMany(int inset, int offset)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsLetterSample> CreateSubscription(NewsLetterSample sample)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsLetterSample> DeleteSubscription(NewsLetterSample sample)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsLetterSample> UpdateSubscription(NewsLetterSample sample)
        {
            throw new NotImplementedException();
        }
    }
}
