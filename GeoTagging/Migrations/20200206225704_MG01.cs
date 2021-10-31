using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GeoTagging.Migrations
{
    public partial class MG01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.CreateTable(
                name: "admin1mapping",
                columns: table => new
                {
                    admin1 = table.Column<string>(maxLength: 20, nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: true),
                    geonameid = table.Column<int>(nullable: true),
                    country = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "admin2mapping",
                columns: table => new
                {
                    country = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
                    admin1 = table.Column<string>(maxLength: 20, nullable: true),
                    admin2 = table.Column<string>(maxLength: 80, nullable: true),
                    admin2name = table.Column<string>(maxLength: 200, nullable: true),
                    geonameid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "alt_filtered",
                columns: table => new
                {
                    alternatenameid = table.Column<int>(nullable: false),
                    geonameid = table.Column<int>(nullable: true),
                    isolanguage = table.Column<string>(maxLength: 7, nullable: true),
                    alternatename = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("alt_filtered_pkey", x => x.alternatenameid);
                });

            migrationBuilder.CreateTable(
                name: "alternatename",
                columns: table => new
                {
                    alternatenameid = table.Column<int>(nullable: true),
                    geonameid = table.Column<int>(nullable: true),
                    isolanguage = table.Column<string>(maxLength: 7, nullable: true),
                    alternatename = table.Column<string>(maxLength: 200, nullable: true),
                    ispreferredname = table.Column<bool>(nullable: true),
                    isshortname = table.Column<bool>(nullable: true),
                    iscolloquial = table.Column<bool>(nullable: true),
                    ishistoric = table.Column<bool>(nullable: true),
                    the_from = table.Column<string>(maxLength: 20, nullable: true),
                    the_to = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "capital",
                columns: table => new
                {
                    state = table.Column<string>(maxLength: 20, nullable: true),
                    city = table.Column<string>(maxLength: 20, nullable: true),
                    latitude = table.Column<double>(nullable: true),
                    longitude = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "continents",
                columns: table => new
                {
                    geonameid = table.Column<int>(nullable: true),
                    iso_code = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
                    name = table.Column<string>(maxLength: 13, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    geonameid = table.Column<int>(nullable: true),
                    iso_code = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
                    name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "geoname",
                columns: table => new
                {
                    geonameid = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: true),
                    asciiname = table.Column<string>(maxLength: 200, nullable: true),
                    alternatenames = table.Column<string>(maxLength: 6000, nullable: true),
                    latitude = table.Column<double>(nullable: true),
                    longitude = table.Column<double>(nullable: true),
                    fclass = table.Column<char>(nullable: true),
                    fcode = table.Column<string>(maxLength: 10, nullable: true),
                    country = table.Column<string>(maxLength: 2, nullable: true),
                    admin1 = table.Column<string>(maxLength: 20, nullable: true),
                    admin2 = table.Column<string>(maxLength: 80, nullable: true),
                    admin3 = table.Column<string>(maxLength: 20, nullable: true),
                    admin4 = table.Column<string>(maxLength: 20, nullable: true),
                    population = table.Column<long>(nullable: true),
                    admin1_geonameid = table.Column<int>(nullable: true),
                    admin2_geonameid = table.Column<int>(nullable: true),
                    country_geonameid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_geoname", x => x.geonameid);
                });

            migrationBuilder.CreateTable(
                name: "my_county",
                columns: table => new
                {
                    gid = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    statefp = table.Column<string>(maxLength: 2, nullable: true),
                    countyfp = table.Column<string>(maxLength: 3, nullable: true),
                    countyns = table.Column<string>(maxLength: 8, nullable: true),
                    affgeoid = table.Column<string>(maxLength: 14, nullable: true),
                    geoid = table.Column<string>(maxLength: 5, nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    lsad = table.Column<string>(maxLength: 2, nullable: true),
                    aland = table.Column<double>(nullable: true),
                    awater = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("my_county_pkey", x => x.gid);
                });

            migrationBuilder.CreateTable(
                name: "my_nation",
                columns: table => new
                {
                    gid = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    affgeoid = table.Column<string>(maxLength: 9, nullable: true),
                    geoid = table.Column<string>(maxLength: 2, nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("my_nation_pkey", x => x.gid);
                });

            migrationBuilder.CreateTable(
                name: "my_state",
                columns: table => new
                {
                    gid = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    statefp = table.Column<string>(maxLength: 2, nullable: true),
                    statens = table.Column<string>(maxLength: 8, nullable: true),
                    affgeoid = table.Column<string>(maxLength: 11, nullable: true),
                    geoid = table.Column<string>(maxLength: 2, nullable: true),
                    stusps = table.Column<string>(maxLength: 2, nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    lsad = table.Column<string>(maxLength: 2, nullable: true),
                    aland = table.Column<double>(nullable: true),
                    awater = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("my_state_pkey", x => x.gid);
                });

            migrationBuilder.CreateTable(
                name: "temp_country",
                columns: table => new
                {
                    iso_code = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
                    iso3 = table.Column<string>(fixedLength: true, maxLength: 3, nullable: true),
                    iso_numeric = table.Column<int>(nullable: true),
                    fips = table.Column<string>(maxLength: 3, nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: true),
                    capital = table.Column<string>(maxLength: 200, nullable: true),
                    area = table.Column<double>(nullable: true),
                    population = table.Column<int>(nullable: true),
                    continent = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
                    tld = table.Column<string>(nullable: true),
                    currencycode = table.Column<string>(nullable: true),
                    currencyname = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    postal = table.Column<string>(nullable: true),
                    postalcoderegex = table.Column<string>(nullable: true),
                    languages = table.Column<string>(nullable: true),
                    geonameid = table.Column<int>(nullable: true),
                    neighbours = table.Column<string>(nullable: true),
                    equivalentfipscode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "idx_admin1_mapping",
                table: "admin1mapping",
                column: "admin1");

            migrationBuilder.CreateIndex(
                name: "idx_admin2mapping",
                table: "admin2mapping",
                columns: new[] { "admin1", "admin2" });

            migrationBuilder.CreateIndex(
                name: "idx_alt_filtered_geonameid",
                table: "alt_filtered",
                column: "geonameid");

            migrationBuilder.CreateIndex(
                name: "idx_country",
                table: "country",
                column: "iso_code");

            migrationBuilder.CreateIndex(
                name: "idx__name",
                table: "geoname",
                column: "name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin1mapping");

            migrationBuilder.DropTable(
                name: "admin2mapping");

            migrationBuilder.DropTable(
                name: "alt_filtered");

            migrationBuilder.DropTable(
                name: "alternatename");

            migrationBuilder.DropTable(
                name: "capital");

            migrationBuilder.DropTable(
                name: "continents");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "geoname");

            migrationBuilder.DropTable(
                name: "my_county");

            migrationBuilder.DropTable(
                name: "my_nation");

            migrationBuilder.DropTable(
                name: "my_state");

            migrationBuilder.DropTable(
                name: "temp_country");
        }
    }
}
