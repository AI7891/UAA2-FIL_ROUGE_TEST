using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Services
{
    public interface INewsLetterServices
    {
        IEnumerable<NewsLetterSamples> GetByEmail(string email);
        IEnumerable<NewsLetterSamples> Subscribe(NewsLetterSamples sample, string email);
        IEnumerable<NewsLetterSamples> UpdateSubs(NewsLetterSamples newsLetterSample, string email);
        IEnumerable<NewsLetterSamples> Unsubscribe(NewsLetterSamples sample, string email);

    }
}
