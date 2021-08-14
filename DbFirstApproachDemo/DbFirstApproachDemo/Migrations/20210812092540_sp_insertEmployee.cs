using Microsoft.EntityFrameworkCore.Migrations;

namespace DbFirstApproachDemo.Migrations
{
    public partial class sp_insertEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create proc sp_InsertNewEmployee1
                                (@name varchar(20),
                                @location varchar(20))
                                as
                                begin
                                insert into department values (@name,@location)
                                End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"drop proc sp_InsertNewEmployee1";
            migrationBuilder.Sql(procedure);
        }

    }
    }

