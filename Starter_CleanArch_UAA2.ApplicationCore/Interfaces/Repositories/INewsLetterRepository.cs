using Starter_CleanArch_UAA2.Domain.Enum;
using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Repositories
{
    public interface INewsLetterRepository
    {
        IEnumerable<NewsLetterSamples> GetByEmail(string email, bool Newsletter);

        IEnumerable<NewsLetterSamples> GetMany(string email, NewsLetterChoices newsLetter); 

        IEnumerable<NewsLetterSamples> CreateSubscription(NewsLetterSamples sample, string email);
        IEnumerable<NewsLetterSamples> UpdateSubscription (NewsLetterSamples sample, string email);

        IEnumerable<NewsLetterSamples> DeleteSubscription(NewsLetterSamples sample, string email);
       
    }
}
