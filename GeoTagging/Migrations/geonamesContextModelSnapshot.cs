﻿// <auto-generated />
using System;
using GeoTagging.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GeoTagging.Migrations
{
    [DbContext(typeof(geonamesContext))]
    partial class geonamesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:postgis", ",,")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GeoTagging.Models.Admin1mapping", b =>
                {
                    b.Property<string>("Admin1")
                        .HasColumnName("admin1")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .HasColumnName("country")
                        .HasColumnType("character(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.Property<int?>("Geonameid")
                        .HasColumnName("geonameid")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.HasIndex("Admin1")
                        .HasName("idx_admin1_mapping");

                    b.ToTable("admin1mapping");
                });

            modelBuilder.Entity("GeoTagging.Models.Admin2mapping", b =>
                {
                    b.Property<string>("Admin1")
                        .HasColumnName("admin1")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Admin2")
                        .HasColumnName("admin2")
                        .HasColumnType("character varying(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Admin2name")
                        .HasColumnName("admin2name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Country")
                        .HasColumnName("country")
                        .HasColumnType("character(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.Property<int?>("Geonameid")
                        .HasColumnName("geonameid")
                        .HasColumnType("integer");

                    b.HasIndex("Admin1", "Admin2")
                        .HasName("idx_admin2mapping");

                    b.ToTable("admin2mapping");
                });

            modelBuilder.Entity("GeoTagging.Models.AltFiltered", b =>
                {
                    b.Property<int>("Alternatenameid")
                        .HasColumnName("alternatenameid")
                        .HasColumnType("integer");

                    b.Property<string>("Alternatename")
                        .HasColumnName("alternatename")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<int?>("Geonameid")
                        .HasColumnName("geonameid")
                        .HasColumnType("integer");

                    b.Property<string>("Isolanguage")
                        .HasColumnName("isolanguage")
                        .HasColumnType("character varying(7)")
                        .HasMaxLength(7);

                    b.HasKey("Alternatenameid")
                        .HasName("alt_filtered_pkey");

                    b.HasIndex("Geonameid")
                        .HasName("idx_alt_filtered_geonameid");

                    b.ToTable("alt_filtered");
                });

            modelBuilder.Entity("GeoTagging.Models.Alternatename", b =>
                {
                    b.Property<string>("Alternatename1")
                        .HasColumnName("alternatename")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<int?>("Alternatenameid")
                        .HasColumnName("alternatenameid")
                        .HasColumnType("integer");

                    b.Property<int?>("Geonameid")
                        .HasColumnName("geonameid")
                        .HasColumnType("integer");

                    b.Property<bool?>("Iscolloquial")
                        .HasColumnName("iscolloquial")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Ishistoric")
                        .HasColumnName("ishistoric")
                        .HasColumnType("boolean");

                    b.Property<string>("Isolanguage")
                        .HasColumnName("isolanguage")
                        .HasColumnType("character varying(7)")
                        .HasMaxLength(7);

                    b.Property<bool?>("Ispreferredname")
                        .HasColumnName("ispreferredname")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Isshortname")
                        .HasColumnName("isshortname")
                        .HasColumnType("boolean");

                    b.Property<string>("TheFrom")
                        .HasColumnName("the_from")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("TheTo")
                        .HasColumnName("the_to")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.ToTable("alternatename");
                });

            modelBuilder.Entity("GeoTagging.Models.Capital", b =>
                {
                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<double?>("Latitude")
                        .HasColumnName("latitude")
                        .HasColumnType("double precision");

                    b.Property<double?>("Longitude")
                        .HasColumnName("longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("State")
                        .HasColumnName("state")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.ToTable("capital");
                });

            modelBuilder.Entity("GeoTagging.Models.Continents", b =>
                {
                    b.Property<int?>("Geonameid")
                        .HasColumnName("geonameid")
                        .HasColumnType("integer");

                    b.Property<string>("IsoCode")
                        .HasColumnName("iso_code")
                        .HasColumnType("character(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(13)")
                        .HasMaxLength(13);

                    b.ToTable("continents");
                });

            modelBuilder.Entity("GeoTagging.Models.Country", b =>
                {
                    b.Property<int?>("Geonameid")
                        .HasColumnName("geonameid")
                        .HasColumnType("integer");

                    b.Property<string>("IsoCode")
                        .HasColumnName("iso_code")
                        .HasColumnType("character(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasIndex("IsoCode")
                        .HasName("idx_country");

                    b.ToTable("country");
                });

            modelBuilder.Entity("GeoTagging.Models.Geoname", b =>
                {
                    b.Property<int>("Geonameid")
                        .HasColumnName("geonameid")
                        .HasColumnType("integer");

                    b.Property<string>("Admin1")
                        .HasColumnName("admin1")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("Admin1Geonameid")
                        .HasColumnName("admin1_geonameid")
                        .HasColumnType("integer");

                    b.Property<string>("Admin2")
                        .HasColumnName("admin2")
                        .HasColumnType("character varying(80)")
                        .HasMaxLength(80);

                    b.Property<int?>("Admin2Geonameid")
                        .HasColumnName("admin2_geonameid")
                        .HasColumnType("integer");

                    b.Property<string>("Admin3")
                        .HasColumnName("admin3")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Admin4")
                        .HasColumnName("admin4")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Alternatenames")
                        .HasColumnName("alternatenames")
                        .HasColumnType("character varying(6000)")
                        .HasMaxLength(6000);

                    b.Property<string>("Asciiname")
                        .HasColumnName("asciiname")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Country")
                        .HasColumnName("country")
                        .HasColumnType("character varying(2)")
                        .HasMaxLength(2);

                    b.Property<int?>("CountryGeonameid")
                        .HasColumnName("country_geonameid")
                        .HasColumnType("integer");

                    b.Property<char?>("Fclass")
                        .HasColumnName("fclass")
                        .HasColumnType("character(1)");

                    b.Property<string>("Fcode")
                        .HasColumnName("fcode")
                        .HasColumnType("character varying(10)")
                        .HasMaxLength(10);

                    b.Property<double?>("Latitude")
                        .HasColumnName("latitude")
                        .HasColumnType("double precision");

                    b.Property<double?>("Longitude")
                        .HasColumnName("longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<long?>("Population")
                        .HasColumnName("population")
                        .HasColumnType("bigint");

                    b.HasKey("Geonameid");

                    b.HasIndex("Name")
                        .HasName("idx__name");

                    b.ToTable("geoname");
                });

            modelBuilder.Entity("GeoTagging.Models.MyCounty", b =>
                {
                    b.Property<int>("Gid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gid")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Affgeoid")
                        .HasColumnName("affgeoid")
                        .HasColumnType("character varying(14)")
                        .HasMaxLength(14);

                    b.Property<double?>("Aland")
                        .HasColumnName("aland")
                        .HasColumnType("double precision");

                    b.Property<double?>("Awater")
                        .HasColumnName("awater")
                        .HasColumnType("double precision");

                    b.Property<string>("Countyfp")
                        .HasColumnName("countyfp")
                        .HasColumnType("character varying(3)")
                        .HasMaxLength(3);

                    b.Property<string>("Countyns")
                        .HasColumnName("countyns")
                        .HasColumnType("character varying(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Geoid")
                        .HasColumnName("geoid")
                        .HasColumnType("character varying(5)")
                        .HasMaxLength(5);

                    b.Property<string>("Lsad")
                        .HasColumnName("lsad")
                        .HasColumnType("character varying(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Statefp")
                        .HasColumnName("statefp")
                        .HasColumnType("character varying(2)")
                        .HasMaxLength(2);

                    b.HasKey("Gid")
                        .HasName("my_county_pkey");

                    b.ToTable("my_county");
                });

            modelBuilder.Entity("GeoTagging.Models.MyNation", b =>
                {
                    b.Property<int>("Gid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gid")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Affgeoid")
                        .HasColumnName("affgeoid")
                        .HasColumnType("character varying(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Geoid")
                        .HasColumnName("geoid")
                        .HasColumnType("character varying(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Gid")
                        .HasName("my_nation_pkey");

                    b.ToTable("my_nation");
                });

            modelBuilder.Entity("GeoTagging.Models.MyState", b =>
                {
                    b.Property<int>("Gid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gid")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Affgeoid")
                        .HasColumnName("affgeoid")
                        .HasColumnType("character varying(11)")
                        .HasMaxLength(11);

                    b.Property<double?>("Aland")
                        .HasColumnName("aland")
                        .HasColumnType("double precision");

                    b.Property<double?>("Awater")
                        .HasColumnName("awater")
                        .HasColumnType("double precision");

                    b.Property<string>("Geoid")
                        .HasColumnName("geoid")
                        .HasColumnType("character varying(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Lsad")
                        .HasColumnName("lsad")
                        .HasColumnType("character varying(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Statefp")
                        .HasColumnName("statefp")
                        .HasColumnType("character varying(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Statens")
                        .HasColumnName("statens")
                        .HasColumnType("character varying(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Stusps")
                        .HasColumnName("stusps")
                        .HasColumnType("character varying(2)")
                        .HasMaxLength(2);

                    b.HasKey("Gid")
                        .HasName("my_state_pkey");

                    b.ToTable("my_state");
                });

            modelBuilder.Entity("GeoTagging.Models.TempCountry", b =>
                {
                    b.Property<double?>("Area")
                        .HasColumnName("area")
                        .HasColumnType("double precision");

                    b.Property<string>("Capital")
                        .HasColumnName("capital")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Continent")
                        .HasColumnName("continent")
                        .HasColumnType("character(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.Property<string>("Currencycode")
                        .HasColumnName("currencycode")
                        .HasColumnType("text");

                    b.Property<string>("Currencyname")
                        .HasColumnName("currencyname")
                        .HasColumnType("text");

                    b.Property<string>("Equivalentfipscode")
                        .HasColumnName("equivalentfipscode")
                        .HasColumnType("text");

                    b.Property<string>("Fips")
                        .HasColumnName("fips")
                        .HasColumnType("character varying(3)")
                        .HasMaxLength(3);

                    b.Property<int?>("Geonameid")
                        .HasColumnName("geonameid")
                        .HasColumnType("integer");

                    b.Property<string>("Iso3")
                        .HasColumnName("iso3")
                        .HasColumnType("character(3)")
                        .IsFixedLength(true)
                        .HasMaxLength(3);

                    b.Property<string>("IsoCode")
                        .HasColumnName("iso_code")
                        .HasColumnType("character(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.Property<int?>("IsoNumeric")
                        .HasColumnName("iso_numeric")
                        .HasColumnType("integer");

                    b.Property<string>("Languages")
                        .HasColumnName("languages")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Neighbours")
                        .HasColumnName("neighbours")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasColumnType("text");

                    b.Property<int?>("Population")
                        .HasColumnName("population")
                        .HasColumnType("integer");

                    b.Property<string>("Postal")
                        .HasColumnName("postal")
                        .HasColumnType("text");

                    b.Property<string>("Postalcoderegex")
                        .HasColumnName("postalcoderegex")
                        .HasColumnType("text");

                    b.Property<string>("Tld")
                        .HasColumnName("tld")
                        .HasColumnType("text");

                    b.ToTable("temp_country");
                });
#pragma warning restore 612, 618
        }
    }
}
