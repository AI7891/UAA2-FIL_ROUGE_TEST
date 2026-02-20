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

        public IEnumerable<NewsLetterSamples> Subscribe(NewsLetterSamples sample, string email)
        {
            if (sample == null)
            {
                throw new ArgumentNullException($"this {nameof(sample)} is invalid, do try again");
            }

            return _newsLetterRepository.CreateSubscription(sample, email).ToList();
 
        }

        public IEnumerable<NewsLetterSamples> Unsubscribe(NewsLetterSamples sample, string email)
        {
            if (sample == null)
            {
                throw new ArgumentNullException($"this {nameof(sample)} is invalid, do try again");
            }

            IEnumerable<NewsLetterSamples> toBeUnsuscribe = _newsLetterRepository.DeleteSubscription(sample, email);

            return toBeUnsuscribe;
            
        }

        public IEnumerable<NewsLetterSamples> UpdateSubs(NewsLetterSamples newsLetterSample, string email)
        {
            IEnumerable<NewsLetterSamples> toBeUpdated = _newsLetterRepository.GetByEmail(email);
            if (newsLetterSample == null)
            {
                throw new ArgumentNullException($"this {nameof(newsLetterSample)} is invalid, do try again");
            }

            return _newsLetterRepository.UpdateSubscription(newsLetterSample, email).ToList();
        }
    }
        #endregion    
}
