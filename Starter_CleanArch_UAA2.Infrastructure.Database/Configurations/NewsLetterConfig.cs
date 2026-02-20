using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Starter_CleanArch_UAA2.Domain.Enum;
using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter_CleanArch_UAA2.Infrastructure.Database.Configurations
{
    public class NewsLetterConfig : IEntityTypeConfiguration<NewsLetterSample>
    {
        public void Configure(EntityTypeBuilder<NewsLetterSample> builder)
        {
            #region Table
            builder.ToTable("NEWS_LETTER");
            #endregion
            #region Keys
            builder.HasKey(e => e.Email)
                   .IsClustered();
            #endregion
            #region Table_Properties
            builder.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode()
                    .HasMaxLength(250);

            builder.Property(e => e.LastName)
                   .IsUnicode()
                   .HasMaxLength(250)
                   .IsRequired();

            builder.Property(e => e.Email)
                   .IsRequired()
                   .IsUnicode()
                   .HasMaxLength(400);

            builder.Property(e => e.newsLetter)
                   .IsRequired()
                   .HasDefaultValue(NewsLetterChoices.None);
            #endregion
            #region Indexer
            builder.HasIndex(e => new { e.Email, e.Name, e.LastName, e.newsLetter })
                   .IsUnique();
            #endregion

        }
    }
}
