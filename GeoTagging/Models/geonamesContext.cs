using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GeoTagging.Models
{
    public partial class geonamesContext : DbContext
    {

        public geonamesContext()
        {

        }

        public geonamesContext(DbContextOptions<geonamesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin1mapping> Admin1mapping { get; set; }
        public virtual DbSet<Admin2mapping> Admin2mapping { get; set; }
        public virtual DbSet<AltFiltered> AltFiltered { get; set; }
        public virtual DbSet<Alternatename> Alternatename { get; set; }
        public virtual DbSet<Capital> Capital { get; set; }
        public virtual DbSet<Continents> Continents { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Geoname> Geoname { get; set; }
        public virtual DbSet<MyCounty> MyCounty { get; set; }
        public virtual DbSet<MyNation> MyNation { get; set; }
        public virtual DbSet<MyState> MyState { get; set; }
        public virtual DbSet<TempCountry> TempCountry { get; set; }

        /// <summary>
        /// MAKE SURE you change the username and password to your OWN, otherwise it will NOT work!!
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Database=geonames;Host=localhost;Username=postgres;Password=E00618907_Mp;Persist Security Info=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("postgis");

            modelBuilder.Entity<Admin1mapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("admin1mapping");

                entity.HasIndex(e => e.Admin1)
                    .HasName("idx_admin1_mapping");

                entity.Property(e => e.Admin1)
                    .HasColumnName("admin1")
                    .HasMaxLength(20);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Geonameid).HasColumnName("geonameid");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Admin2mapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("admin2mapping");

                entity.HasIndex(e => new { e.Admin1, e.Admin2 })
                    .HasName("idx_admin2mapping");

                entity.Property(e => e.Admin1)
                    .HasColumnName("admin1")
                    .HasMaxLength(20);

                entity.Property(e => e.Admin2)
                    .HasColumnName("admin2")
                    .HasMaxLength(80);

                entity.Property(e => e.Admin2name)
                    .HasColumnName("admin2name")
                    .HasMaxLength(200);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Geonameid).HasColumnName("geonameid");
            });

            modelBuilder.Entity<AltFiltered>(entity =>
            {
                entity.HasKey(e => e.Alternatenameid)
                    .HasName("alt_filtered_pkey");

                entity.ToTable("alt_filtered");

                entity.HasIndex(e => e.Geonameid)
                    .HasName("idx_alt_filtered_geonameid");

                entity.Property(e => e.Alternatenameid)
                    .HasColumnName("alternatenameid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Alternatename)
                    .HasColumnName("alternatename")
                    .HasMaxLength(200);

                entity.Property(e => e.Geonameid).HasColumnName("geonameid");

                entity.Property(e => e.Isolanguage)
                    .HasColumnName("isolanguage")
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<Alternatename>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("alternatename");

                entity.Property(e => e.Alternatename1)
                    .HasColumnName("alternatename")
                    .HasMaxLength(200);

                entity.Property(e => e.Alternatenameid).HasColumnName("alternatenameid");

                entity.Property(e => e.Geonameid).HasColumnName("geonameid");

                entity.Property(e => e.Iscolloquial).HasColumnName("iscolloquial");

                entity.Property(e => e.Ishistoric).HasColumnName("ishistoric");

                entity.Property(e => e.Isolanguage)
                    .HasColumnName("isolanguage")
                    .HasMaxLength(7);

                entity.Property(e => e.Ispreferredname).HasColumnName("ispreferredname");

                entity.Property(e => e.Isshortname).HasColumnName("isshortname");

                entity.Property(e => e.TheFrom)
                    .HasColumnName("the_from")
                    .HasMaxLength(20);

                entity.Property(e => e.TheTo)
                    .HasColumnName("the_to")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Capital>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("capital");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20);

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Continents>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("continents");

                entity.Property(e => e.Geonameid).HasColumnName("geonameid");

                entity.Property(e => e.IsoCode)
                    .HasColumnName("iso_code")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(13);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("country");

                entity.HasIndex(e => e.IsoCode)
                    .HasName("idx_country");

                entity.Property(e => e.Geonameid).HasColumnName("geonameid");

                entity.Property(e => e.IsoCode)
                    .HasColumnName("iso_code")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Geoname>(entity =>
            {
                entity.ToTable("geoname");

                entity.HasIndex(e => e.Name)
                    .HasName("idx__name");

                entity.Property(e => e.Geonameid)
                    .HasColumnName("geonameid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Admin1)
                    .HasColumnName("admin1")
                    .HasMaxLength(20);

                entity.Property(e => e.Admin1Geonameid).HasColumnName("admin1_geonameid");

                entity.Property(e => e.Admin2)
                    .HasColumnName("admin2")
                    .HasMaxLength(80);

                entity.Property(e => e.Admin2Geonameid).HasColumnName("admin2_geonameid");

                entity.Property(e => e.Admin3)
                    .HasColumnName("admin3")
                    .HasMaxLength(20);

                entity.Property(e => e.Admin4)
                    .HasColumnName("admin4")
                    .HasMaxLength(20);

                entity.Property(e => e.Alternatenames)
                    .HasColumnName("alternatenames")
                    .HasMaxLength(6000);

                entity.Property(e => e.Asciiname)
                    .HasColumnName("asciiname")
                    .HasMaxLength(200);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(2);

                entity.Property(e => e.CountryGeonameid).HasColumnName("country_geonameid");

                entity.Property(e => e.Fclass).HasColumnName("fclass");

                entity.Property(e => e.Fcode)
                    .HasColumnName("fcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.Population).HasColumnName("population");
            });

            modelBuilder.Entity<MyCounty>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("my_county_pkey");

                entity.ToTable("my_county");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Affgeoid)
                    .HasColumnName("affgeoid")
                    .HasMaxLength(14);

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Countyfp)
                    .HasColumnName("countyfp")
                    .HasMaxLength(3);

                entity.Property(e => e.Countyns)
                    .HasColumnName("countyns")
                    .HasMaxLength(8);

                entity.Property(e => e.Geoid)
                    .HasColumnName("geoid")
                    .HasMaxLength(5);

                entity.Property(e => e.Lsad)
                    .HasColumnName("lsad")
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Statefp)
                    .HasColumnName("statefp")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<MyNation>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("my_nation_pkey");

                entity.ToTable("my_nation");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Affgeoid)
                    .HasColumnName("affgeoid")
                    .HasMaxLength(9);

                entity.Property(e => e.Geoid)
                    .HasColumnName("geoid")
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MyState>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("my_state_pkey");

                entity.ToTable("my_state");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Affgeoid)
                    .HasColumnName("affgeoid")
                    .HasMaxLength(11);

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Geoid)
                    .HasColumnName("geoid")
                    .HasMaxLength(2);

                entity.Property(e => e.Lsad)
                    .HasColumnName("lsad")
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Statefp)
                    .HasColumnName("statefp")
                    .HasMaxLength(2);

                entity.Property(e => e.Statens)
                    .HasColumnName("statens")
                    .HasMaxLength(8);

                entity.Property(e => e.Stusps)
                    .HasColumnName("stusps")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<TempCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_country");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Capital)
                    .HasColumnName("capital")
                    .HasMaxLength(200);

                entity.Property(e => e.Continent)
                    .HasColumnName("continent")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Currencycode).HasColumnName("currencycode");

                entity.Property(e => e.Currencyname).HasColumnName("currencyname");

                entity.Property(e => e.Equivalentfipscode).HasColumnName("equivalentfipscode");

                entity.Property(e => e.Fips)
                    .HasColumnName("fips")
                    .HasMaxLength(3);

                entity.Property(e => e.Geonameid).HasColumnName("geonameid");

                entity.Property(e => e.Iso3)
                    .HasColumnName("iso3")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.IsoCode)
                    .HasColumnName("iso_code")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.IsoNumeric).HasColumnName("iso_numeric");

                entity.Property(e => e.Languages).HasColumnName("languages");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.Neighbours).HasColumnName("neighbours");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Population).HasColumnName("population");

                entity.Property(e => e.Postal).HasColumnName("postal");

                entity.Property(e => e.Postalcoderegex).HasColumnName("postalcoderegex");

                entity.Property(e => e.Tld).HasColumnName("tld");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
