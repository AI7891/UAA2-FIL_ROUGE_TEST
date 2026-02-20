using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Services
{
    public interface INewsLetterServices
    {
        NewsLetterSample GetByEmail(string email);
        IEnumerable<NewsLetterSample> Subscribe(NewsLetterSample sample);
        IEnumerable<NewsLetterSample> UpdateSubs(NewsLetterSample newsLetterSample);
        IEnumerable<NewsLetterSample> Unsubscribe(NewsLetterSample sample);

    }
}
