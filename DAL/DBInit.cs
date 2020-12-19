using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Oppgave3.Models;

namespace Oppgave3.DAL
{
    public static class DBInit
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SpoersmaalContext>();

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var spoersmaal1 = new Spoersmaalene
                {
                    Spoersmaalet = "Hvordan bestiller man billett?",
                    Svar = "Man velger fra-stasjon, til-stasjon, reisedato, tid og lagrer bestillingen før man bestiller med kort."
                };

                var innSpoersmaal1 = new InnSpoersmaalene
                {
                    Spoersmaalet = "Hvor mange stasjoner kan man velge mellom?",
                    Navn = "Lars Hansen",
                    Epost = "larhan@icloud.com"
                };

                context.Spoersmaalene.Add(spoersmaal1);
                context.InnSpoersmaalene.Add(innSpoersmaal1);
                context.SaveChanges();
            }
        }



    }
}
