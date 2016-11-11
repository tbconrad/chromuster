// ***********************************************************************
// Assembly         : WidgetTestService
// Author           : Tim Conrad
// Created          : 11-08-2016
//
// Last Modified By : Tim Conrad
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="WidgetInitializer.cs" company="Conrad Enterprise, Inc.">
//     Copyright Conrad Enterprise, Inc. ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
#pragma warning disable 1591
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using WidgetTestService.Models;

namespace WidgetTestService.DAL
{
    public class WidgetInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WidgetContext>
    {
        protected override void Seed(WidgetContext context)
        {
            context.TaxRates.AddOrUpdate(x => x.TaxRateId,
               new TaxRate() { TaxRateId = 1, TaxBaseRate = 0.00, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 2, TaxBaseRate = 1.00, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 3, TaxBaseRate = 1.25, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 4, TaxBaseRate = 1.50, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 5, TaxBaseRate = 1.75, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 6, TaxBaseRate = 2.00, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 7, TaxBaseRate = 2.25, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 8, TaxBaseRate = 2.50, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 9, TaxBaseRate = 2.75, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 10, TaxBaseRate = 3.00, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 11, TaxBaseRate = 3.25, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 12, TaxBaseRate = 3.50, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 13, TaxBaseRate = 3.75, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 14, TaxBaseRate = 4.00, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 15, TaxBaseRate = 4.25, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 16, TaxBaseRate = 4.50, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 17, TaxBaseRate = 4.75, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 18, TaxBaseRate = 5.00, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 19, TaxBaseRate = 5.25, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 20, TaxBaseRate = 5.50, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 21, TaxBaseRate = 5.75, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
               new TaxRate() { TaxRateId = 22, TaxBaseRate = 6.00, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") }
           );

            context.States.AddOrUpdate(x => x.StateId,
                new State() { StateId = 1, StateName = "Alabama", StateAbbreviation = "AL", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 2, StateName = "Alaska", StateAbbreviation = "AK", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 3, StateName = "Arizona", StateAbbreviation = "AZ", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 4, StateName = "Arkansas", StateAbbreviation = "AR", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 5, StateName = "California", StateAbbreviation = "CA", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 6, StateName = "Colorado", StateAbbreviation = "CO", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 7, StateName = "Connecticut", StateAbbreviation = "CT", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 8, StateName = "Delaware", StateAbbreviation = "DE", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 9, StateName = "Florida", StateAbbreviation = "FL", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), TaxRateId = 1 },
                new State() { StateId = 10, StateName = "Georgia", StateAbbreviation = "GA", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 11, StateName = "Hawaii", StateAbbreviation = "HI", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 12, StateName = "Idaho", StateAbbreviation = "ID", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 13, StateName = "Illinois", StateAbbreviation = "IL", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 14, StateName = "Indiana", StateAbbreviation = "IN", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 15, StateName = "Iowa", StateAbbreviation = "IA", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 16, StateName = "Kansas", StateAbbreviation = "KS", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 17, StateName = "Kentucky", StateAbbreviation = "KY", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 18, StateName = "Louisiana", StateAbbreviation = "LA", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 19, StateName = "Maine", StateAbbreviation = "ME", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 20, StateName = "Maryland", StateAbbreviation = "MD", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 21, StateName = "Massachusetts", StateAbbreviation = "MA", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 22, StateName = "Michigan", StateAbbreviation = "MI", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 23, StateName = "Minnesota", StateAbbreviation = "MN", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 24, StateName = "Mississippi", StateAbbreviation = "MS", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 25, StateName = "Missouri", StateAbbreviation = "MO", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 26, StateName = "Montana", StateAbbreviation = "MT", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 27, StateName = "Nebraska", StateAbbreviation = "NE", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 28, StateName = "Nevada", StateAbbreviation = "NV", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 29, StateName = "New Hampshire", StateAbbreviation = "NH", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 30, StateName = "New Jersey", StateAbbreviation = "NJ", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 31, StateName = "New Mexico", StateAbbreviation = "NM", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 32, StateName = "New York", StateAbbreviation = "NY", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 33, StateName = "North Carolina", StateAbbreviation = "NC", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 34, StateName = "North Dakota", StateAbbreviation = "ND", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 35, StateName = "Ohio", StateAbbreviation = "OH", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 36, StateName = "Oklahoma", StateAbbreviation = "OK", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 37, StateName = "Oregon", StateAbbreviation = "OR", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 38, StateName = "Pennsylvania", StateAbbreviation = "PA", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 39, StateName = "Rhode Island", StateAbbreviation = "RI", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 40, StateName = "South Carolina", StateAbbreviation = "SC", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 41, StateName = "South Dakota", StateAbbreviation = "SD", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 42, StateName = "Tennessee", StateAbbreviation = "TN", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 43, StateName = "Texas", StateAbbreviation = "TX", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), TaxRateId = 1 },
                new State() { StateId = 44, StateName = "Utah", StateAbbreviation = "UT", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 45, StateName = "Vermont", StateAbbreviation = "VT", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 46, StateName = "Virginia", StateAbbreviation = "VA", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 47, StateName = "Washington", StateAbbreviation = "WA", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 48, StateName = "West Virginia", StateAbbreviation = "WV", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 49, StateName = "Wisconsin", StateAbbreviation = "WI", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new State() { StateId = 50, StateName = "Wyoming", StateAbbreviation = "WY", CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") }
            );

            context.Discounts.AddOrUpdate(x => x.DiscountId,
                new Discount() { DiscountId = 1, DiscountPercentage = 5, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new Discount() { DiscountId = 2, DiscountPercentage = 10, Active = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new Discount() { DiscountId = 3, DiscountPercentage = 15, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new Discount() { DiscountId = 4, DiscountPercentage = 20, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new Discount() { DiscountId = 5, DiscountPercentage = 25, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new Discount() { DiscountId = 6, DiscountPercentage = 30, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new Discount() { DiscountId = 7, DiscountPercentage = 35, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new Discount() { DiscountId = 8, DiscountPercentage = 40, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new Discount() { DiscountId = 9, DiscountPercentage = 45, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new Discount() { DiscountId = 10, DiscountPercentage = 50, Active = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") }

            );

            context.Widgets.AddOrUpdate(x => x.WidgetId,
                new Widget() { WidgetId = 1, Name = "Fasecore-Widget", BasePrice = 34.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 2, Name = "Hothotit-Widget", BasePrice = 24.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 3, Name = "Indigo Hotstrong-Widget", BasePrice = 14.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 4, Name = "Kin Zumtop-Widget", BasePrice = 54.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 5, Name = "Run Ozebam-Widget", BasePrice = 27.95, DiscountAvailable = false, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016") },
                new Widget() { WidgetId = 6, Name = "Hotla-Widget", BasePrice = 36.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 7, Name = "White Ex-Widget", BasePrice = 134.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 8, Name = "Freshtex-Widget", BasePrice = 4.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 9, Name = "Mattintom-Widget", BasePrice = 64.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 11, Name = "Alpha Quocom-Widget", BasePrice = 14.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 11, Name = "Zonecof-Widget", BasePrice = 8.1095, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 12, Name = "Hayhold-Widget", BasePrice = 9.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 13, Name = "Lexitop-Widget", BasePrice = 334.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 14, Name = "Touch-Touch-Widget", BasePrice = 24.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 15, Name = "Goldenair-Widget", BasePrice = 12.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 16, Name = "Alphait-Widget", BasePrice = 74.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 17, Name = "Unadax-Widget", BasePrice = 21.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 18, Name = "Voltlab-Widget", BasePrice = 54.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 19, Name = "Labfax-Widget", BasePrice = 19.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 20, Name = "Holdron-Widget", BasePrice = 93.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 21, Name = "Freshtam-Widget", BasePrice = 89.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 22, Name = "X- Sandax-Widget", BasePrice = 3.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 23, Name = "Unalux-Widget", BasePrice = 27.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 24, Name = "Zotnimcof-Widget", BasePrice = 550.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 25, Name = "Grave Hotis-Widget", BasePrice = 114.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 26, Name = "Eco-Fix-Widget", BasePrice = 11.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 27, Name = "Good Air-Widget", BasePrice = 5.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 28, Name = "Rankfix-Widget", BasePrice = 24.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 29, Name = "RankfixPlus-Widget", BasePrice = 1024.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 },
                new Widget() { WidgetId = 30, Name = "Re-Nix-Widget", BasePrice = 42.95, DiscountAvailable = true, CreatedBy = "Tim Conrad", Created = DateTime.Parse("11/8/2016"), DiscountId = 2 }

              );

            context.SaveChanges();
        }
    }
}