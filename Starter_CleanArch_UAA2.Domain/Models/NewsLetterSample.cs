using Starter_CleanArch_UAA2.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;

namespace Starter_CleanArch_UAA2.Domain.Models
{
    public class NewsLetterSample
    {
        #region Properties
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public NewsLetterChoices newsLetter { get; private set; }
        #endregion
        #region Builders
        public NewsLetterSample() { }

        public NewsLetterSample( string name, string lastName, string email, NewsLetterChoices choices )
        {
            if (string.IsNullOrEmpty(email) || MailAddress.TryCreate(email, out _))
            {
                throw new ArgumentException("the email is not valid", nameof(email));
            }

            Name = name;
            LastName = lastName;
            Email = email;
            newsLetter = choices;
        }

        #endregion


    }
}
