using Microsoft.EntityFrameworkCore.Migrations;

namespace DbFirstApproachDemo.Migrations
{
    public partial class sp_GetAllDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create proc sp_GetAllDepartments1
                                as
                                begin
                                select * from Department
                                End";
            migrationBuilder.Sql(procedure);
            //migrationBuilder.CreateTable(
            //    name: "Department",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
            //        Location = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Department", x => x.Id);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"drop proc sp_GetAllDepartments1";
            migrationBuilder.Sql(procedure);
        }
    }
}
