using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations.ProcessFlowData
{
    public partial class InitialProcessFlow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PFActivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditScreenId = table.Column<Guid>(nullable: false),
                    ViewScreenId = table.Column<Guid>(nullable: false),
                    ProcessTypeId = table.Column<Guid>(nullable: false),
                    EnterEventId = table.Column<Guid>(nullable: true),
                    ExitEventId = table.Column<Guid>(nullable: true),
                    CanReloadWorkItem = table.Column<bool>(nullable: false),
                    ByUserHierarchy = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFActivity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PFProcessType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    ProcessTypeName = table.Column<string>(nullable: true),
                    ApplicationTypeId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    StartActivityId = table.Column<Guid>(nullable: true),
                    EndActivityId = table.Column<Guid>(nullable: true),
                    Islocked = table.Column<bool>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFProcessType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PFActivity");

            migrationBuilder.DropTable(
                name: "PFProcessType");
        }
    }
}
