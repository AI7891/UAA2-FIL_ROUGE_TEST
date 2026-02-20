using Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Services;
using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter_CleanArch_UAA2.ApplicationCore.Services
{
    public class NewsLetterServices : INewsLetterServices
    {
        public NewsLetterSamples GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsLetterSamples> Subscribe(NewsLetterSamples sample)
        {
            throw new NotImplementedException();
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
}
