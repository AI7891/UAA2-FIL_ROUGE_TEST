using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Identity.Client;
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
            List<NewsLetterSamples> query = _appDbContext.NewsLetterSamples
             .Where(user => user.Email == email)
             .AsEnumerable()
             .ToList();

            return query;   
        }
        
        public IEnumerable<NewsLetterSamples> GetMany(string email)
        {
            IEnumerable<NewsLetterSamples> NerwsLetters =  _appDbContext.NewsLetterSamples.Where(e => e.Email == email).AsTracking().ToList();

            return NerwsLetters;

        }

        public IEnumerable<NewsLetterSamples> CreateSubscription(NewsLetterSamples sample, string email)
        {
            NewsLetterSamples sampleToCreate = _appDbContext.NewsLetterSamples.SingleOrDefault(s => s.Email == email);


            NewsLetterSamples newsLetterSampleToCreate = new NewsLetterSamples(

                sampleToCreate.Name,
                sampleToCreate.LastName,
                sampleToCreate.Email,
                new List<NewsLetterChoices> { sampleToCreate.newsLetter }
                );

            EntityEntry<NewsLetterSamples> newElement = _appDbContext.Add(newsLetterSampleToCreate);

            _appDbContext.SaveChanges();

            return (IEnumerable<NewsLetterSamples>)newElement.Entity;
        }

        public IEnumerable<NewsLetterSamples> DeleteSubscription(NewsLetterSamples dBSample, string email)
        {
           IEnumerable<NewsLetterSamples> entityToErase = GetByEmail(email);
            if (!entityToErase.Any())
            {
                throw new ArgumentException($"The Email Provided { nameof(email) } does not exist, try again");
            }
            /*Removes the desired Email*/
            _appDbContext.NewsLetterSamples.RemoveRange(entityToErase);

            /*It saves the changes done on the DB*/
            _appDbContext.SaveChanges();

            return _appDbContext.NewsLetterSamples.ToList().AsEnumerable(); 
            
        }
        public IEnumerable<NewsLetterSamples> UpdateSubscription(NewsLetterSamples sample, string email)
        {
            EntityEntry<NewsLetterSamples> toUpdate = _appDbContext.Update(sample);

            _appDbContext.SaveChanges();

            return _appDbContext.NewsLetterSamples.ToList().AsEnumerable();
        }
       
        #endregion

    }
}
