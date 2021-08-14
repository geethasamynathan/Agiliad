using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_DBFirst_StoredProcedureDemo.Migrations
{
    public partial class Sp_insertDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create proc sp_InsertNewEmployee
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
            string procedure = @"frop proc sp_InsertNewEmployee";
            migrationBuilder.Sql(procedure);
        }
    }
}
