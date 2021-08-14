using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_DBFirst_StoredProcedureDemo.Migrations
{
    public partial class sp_GetAllDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create proc sp_GetAllDepartments
                                as
                                begin
                                select * from Department
                                End";
            migrationBuilder.Sql(procedure);           
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"drop proc sp_GetAllDepartments";
            migrationBuilder.Sql(procedure);
            
        }
    }
}
