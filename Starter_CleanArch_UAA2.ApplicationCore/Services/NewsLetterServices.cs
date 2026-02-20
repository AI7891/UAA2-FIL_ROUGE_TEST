using Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Services;
using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter_CleanArch_UAA2.ApplicationCore.Services
{
    public class NewsLetterServices : INewsLetterServices
    {
        public NewsLetterSample GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsLetterSample> Subscribe(NewsLetterSample sample)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsLetterSample> Unsubscribe(NewsLetterSample sample)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsLetterSample> UpdateSubs(NewsLetterSample newsLetterSample)
        {
            throw new NotImplementedException();
        }
    }
}
