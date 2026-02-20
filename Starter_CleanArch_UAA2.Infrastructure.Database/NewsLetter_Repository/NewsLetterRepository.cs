using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

        public IEnumerable<NewsLetterSamples> GetByEmail(string email)
        {
            return _appDbContext.NewsLetterSamples
                    .Where(user => user.Email == email)
                    .ToList();
        }
        
        public IEnumerable<NewsLetterSamples> GetMany(string email, NewsLetterChoices newsLetter)
        {
            IEnumerable<NewsLetterSamples> NerwsLetters =  _appDbContext.NewsLetterSamples.Where(e => e.Email == email).AsTracking().ToList();

            return NerwsLetters;

        }

        public IEnumerable<NewsLetterSamples> CreateSubscription(NewsLetterSamples sample, string email)
        {
            NewsLetterSamples sample1 = _appDbContext.NewsLetterSamples.SingleOrDefault(s => s.Email == email);


            NewsLetterSamples newsLetterSampleToCreate = new NewsLetterSamples(

                sample.Name,
                sample.LastName,
                sample.Email,
                new List<NewsLetterChoices> { sample.newsLetter }
                );

            EntityEntry<NewsLetterSamples> newElement = _appDbContext.Add(newsLetterSampleToCreate);

            _appDbContext.SaveChanges();

            return (IEnumerable<NewsLetterSamples>)newElement.Entity;
        }

        public IEnumerable<NewsLetterSamples> DeleteSubscription(NewsLetterSamples dBSample, string email)
        {
           IEnumerable<NewsLetterSamples> entityToErase = GetByEmail(email);
            if (entityToErase is null)
            {
                throw new ArgumentException($"The Email Provided { nameof(email) } does not exist, try again");
            }
            /*Removes the desired Email*/
            _appDbContext.Remove(entityToErase);
            
            /*It Updates the remaining data*/
            EntityEntry<NewsLetterSamples> result = _appDbContext.Update(dBSample);

            /*It saves the changes done on the DB*/
            _appDbContext.SaveChanges();


            return (IEnumerable<NewsLetterSamples>)result;
            
        }
        public IEnumerable<NewsLetterSamples> UpdateSubscription(NewsLetterSamples sample, string email)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
