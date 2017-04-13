﻿// Copyright (c) 2017 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT licence. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Chapter07Listings.EfClasses;

namespace Test.Chapter07Listings.EFCode.Configurations
{
    public static class PersonConfig
    {
        public static void Configure
            (this EntityTypeBuilder<Person> entity)
        {
            entity.HasOne(p => p.ContactInfo)
                .WithOne()
                .HasForeignKey<ContactInfo>(p => p.EmailAddress)
                .HasPrincipalKey<Person>(c => c.UserId);
        }

    }
}