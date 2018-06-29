using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SwinnyVetAPI.Models;

namespace SwinnyVetAPI.DAL
{
    public class VetInitialiser : DropCreateDatabaseAlways<SwinnyVetContext>
    {
        public override void InitializeDatabase(SwinnyVetContext context)
        {
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, string.Format("ALTER DATABASE[{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));
            base.InitializeDatabase(context);
        }

        protected override void Seed(SwinnyVetContext context)
        {
            var owners = new List<Owner>
            {
                new Owner{OwnerID=1, GivenName="Frank", Surname="Sinatra", Phone="400111222"},
                new Owner{OwnerID=2, GivenName="Duke", Surname="Ellington", Phone="400222333"},
                new Owner{OwnerID=3, GivenName="Ella", Surname="Fitzgerald", Phone="400333444"}
            };

            owners.ForEach(o => context.Owners.Add(o));
            context.SaveChanges();

            var pets = new List<Pet>
            {
                new Pet{PetID=1, Name="Buster", Type="Dog", OwnerID=1},
                new Pet{PetID=2, Name="Fluffy", Type="Cat", OwnerID=1},
                new Pet{PetID=3, Name="Stew", Type="Rabbit", OwnerID=2},
                new Pet{PetID=4, Name="Buster", Type="Dog", OwnerID=3},
                new Pet{PetID=5, Name="Pooper", Type="Dog", OwnerID=3}
            };

            pets.ForEach(p => context.Pets.Add(p));
            context.SaveChanges();

            var procedure = new List<Procedure>
            {
                new Procedure{ProcedureID=01, Description="Rabies Vaccination", Price=24.00},
                new Procedure{ProcedureID=02, Description="Leg Amputation", Price=60.00},
                new Procedure{ProcedureID=03, Description="Nails Clipped", Price=24.00},
                new Procedure{ProcedureID=04, Description="Flu Shot", Price=22.00},
                new Procedure{ProcedureID=05, Description="Heart Worm Test", Price=25.00},
                new Procedure{ProcedureID=06, Description="Lobotomy", Price=24.00},
                new Procedure{ProcedureID=07, Description="Tick Treatment", Price=24.00},
                new Procedure{ProcedureID=08, Description="Tetanus Vaccination", Price=17.00},
                new Procedure{ProcedureID=09, Description="Cremation", Price=44.00},
                new Procedure{ProcedureID=10, Description="Examine and Treat Wound", Price=30.00}
            };

            procedure.ForEach(p => context.Procedures.Add(p));
            context.SaveChanges();

            var treatment = new List<Treatment>
            {
                new Treatment{TreatmentID=001, Date=DateTime.Parse("2017-06-20"), Notes="Routine Vaccination", PricePaid=22.00, PetID=1, ProcedureID=01},
                new Treatment{TreatmentID=002, Date=DateTime.Parse("2018-05-15"), Notes="Booster Shot", PricePaid=24.21, PetID=1, ProcedureID=01},
                new Treatment{TreatmentID=003, Date=DateTime.Parse("2018-05-10"), Notes="Wounds sustained in an apparent cat fight", PricePaid=30.00, PetID=2, ProcedureID=10},
                new Treatment{TreatmentID=004, Date=DateTime.Parse("2018-05-10"), Notes="Wounds sustained in an attempt to cook the stew", PricePaid=30.00, PetID=3, ProcedureID=10},
                new Treatment{TreatmentID=005, Date=DateTime.Parse("2018-05-18"), Notes="Routine Test", PricePaid=25.00, PetID=4, ProcedureID=05},
                new Treatment{TreatmentID=006, Date=DateTime.Parse("2018-05-14"), Notes="Hahaha", PricePaid=24.00, PetID=2, ProcedureID=06},
                new Treatment{TreatmentID=007, Date=DateTime.Parse("2018-06-30"), Notes="RIP", PricePaid=46.00, PetID=1, ProcedureID=09},
            };

            treatment.ForEach(t => context.Treatments.Add(t));
            context.SaveChanges();
        }

    }
}