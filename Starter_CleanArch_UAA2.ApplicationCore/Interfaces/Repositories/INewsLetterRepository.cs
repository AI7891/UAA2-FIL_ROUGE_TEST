using Starter_CleanArch_UAA2.Domain.Enum;
using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Repositories
{
    public interface INewsLetterRepository
    {
        IEnumerable<NewsLetterSample> GetByEmail(string email);

        IEnumerable<NewsLetterSample> GetMany(string email, NewsLetterChoices newsLetter); 

        IEnumerable<NewsLetterSample> CreateSubscription(NewsLetterSample sample);
        IEnumerable<NewsLetterSample> UpdateSubscription (NewsLetterSample sample);

        IEnumerable<NewsLetterSample> DeleteSubscription(NewsLetterSample sample);

        bool Delete(string email);
    }
}
