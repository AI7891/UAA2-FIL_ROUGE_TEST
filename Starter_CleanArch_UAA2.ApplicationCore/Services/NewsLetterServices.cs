using Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Repositories;
using Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Services;
using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter_CleanArch_UAA2.ApplicationCore.Services
{
    public class NewsLetterServices : INewsLetterServices
    {
        #region Dependency Injection = INewsLetterRepository

        private INewsLetterRepository _newsLetterRepository;

        public NewsLetterServices(INewsLetterRepository newsLetterRepository)
        {
            _newsLetterRepository = newsLetterRepository;
        }
        #endregion

        #region Methods - Business Logic
        public IEnumerable<NewsLetterSamples> GetByEmail(string email)
        {
            return _newsLetterRepository.GetByEmail(email);
        }

        public IEnumerable<NewsLetterSamples> Subscribe(NewsLetterSamples sample)
        {
            if (sample == null)
            {
                throw new ArgumentNullException($"this {nameof(sample)} is invalid, do try again");
            }

            return _newsLetterRepository.CreateSubscription(sample).ToList();
 
        }

        public IEnumerable<NewsLetterSamples> Unsubscribe(NewsLetterSamples sample)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsLetterSamples> UpdateSubs(NewsLetterSamples newsLetterSample)
        {
            throw new NotImplementedException();
        }
    }
        #endregion    
}
