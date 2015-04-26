using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;

namespace Registar.DataLayer
{
    public class BikeConfiguration : EntityTypeConfiguration<Bike>
    {
        public BikeConfiguration()
        {
            this.ToTable("Bikes").HasKey(x =>x.BikeId);

            //Properties & mapping to database
            this.Property(p => p.BikeId).HasColumnName("BikeId");
            this.Property(p => p.Model).HasColumnName("Model");
            this.Property(p => p.Producer).HasColumnName("Producer");
            this.Property(p => p.RegNumber).HasColumnName("RegNumber");
            this.Property(p => p.TypeOfBike).HasColumnName("TypeOfBike");
            this.Property(p => p.Colour).HasColumnName("Colour");
            this.Property(p => p.DateOfProduction).HasColumnName("DateOfProduction");
            this.Property(p => p.DateOfPurchase).HasColumnName("DateOfPurchase");



            //this.Ignore(p => p.IgnoreMe);
        }
    }
}
