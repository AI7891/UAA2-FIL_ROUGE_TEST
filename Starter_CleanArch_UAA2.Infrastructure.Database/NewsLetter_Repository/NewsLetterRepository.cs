using Microsoft.EntityFrameworkCore;
using Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Repositories;
using Starter_CleanArch_UAA2.Domain.Enum;
using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter_CleanArch_UAA2.Infrastructure.Database.NewsLetter_Repository
{
    public class NewsLetterRepository : INewsLetterRepository
    {
        #region Dependency Injection
        private readonly AppDbContext _appDbContext;

        public NewsLetterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        #region Methods

        public IEnumerable<NewsLetterSample> GetByEmail(string email)
        {
            return _appDbContext.NewsLetterSamples
                    .Where(user => user.Email == email)
                    .ToList();
        }
        
        public IEnumerable<NewsLetterSample> GetMany(string email, NewsLetterChoices newsLetter)
        {
            IEnumerable<NewsLetterSample> NerwsLetters =  _appDbContext.NewsLetterSamples.Where(e => e.Email == email).AsTracking().ToList();

            return NerwsLetters;

        }

        public IEnumerable<NewsLetterSample> CreateSubscription(NewsLetterSample sample)
        {
            NewsLetterSample sample = _appDbContext.NewsLetterSamples.SingleOrDefault(s => s.Email == );


            NewsLetterSample newsLetterSample = new NewsLetterSample();

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
        public bool Delete(string email)
        {
            throw new NotImplementedException();
        } 
        #endregion

    }
}
