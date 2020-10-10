using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations.WorkflowData
{
    public partial class InitialWorkflow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FristName = table.Column<string>(maxLength: 255, nullable: false),
                    LastName = table.Column<string>(maxLength: 255, nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WFActivityTransitionEmail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    ActivityTransitionId = table.Column<Guid>(nullable: false),
                    EmailTo = table.Column<string>(nullable: true),
                    EmailCc = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    EmailBody = table.Column<string>(nullable: true),
                    IsHtmlbody = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WFActivityTransitionEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WfapplicationType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfapplicationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WfbusinessRuleClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfbusinessRuleClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WfbusinessRuleSeverity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    Severity = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfbusinessRuleSeverity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WfemailClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfemailClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wfevent",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wfevent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WfpreprocessorClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfpreprocessorClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WfsendEmailNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    ActivityTransitionEmailId = table.Column<Guid>(nullable: false),
                    EmailTo = table.Column<string>(nullable: true),
                    EmailCc = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    EmailBody = table.Column<string>(nullable: true),
                    IsHtmlbody = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StatusMessage = table.Column<string>(nullable: true),
                    RetryCount = table.Column<int>(nullable: true),
                    WorkItemId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    CreatedByUserId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfsendEmailNotification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WfuploadAmendmentTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    Filename = table.Column<string>(nullable: true),
                    TemplateType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FileData = table.Column<byte[]>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfuploadAmendmentTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Address1 = table.Column<string>(maxLength: 255, nullable: false),
                    Address2 = table.Column<string>(maxLength: 255, nullable: false),
                    Address3 = table.Column<string>(nullable: true),
                    Address4 = table.Column<string>(nullable: true),
                    Address5 = table.Column<string>(nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    State = table.Column<string>(maxLength: 100, nullable: false),
                    Postcode = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 255, nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Email_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WFActivityScreenName",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    ClassName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ApplicationTypeId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WFActivityScreenName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WFActivityScreenName_WfapplicationType_ApplicationTypeId",
                        column: x => x.ApplicationTypeId,
                        principalTable: "WfapplicationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfbusinessRule",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    ClassId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MessageToUser = table.Column<string>(nullable: true),
                    MessageToReviewer = table.Column<string>(nullable: true),
                    SeverityId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfbusinessRule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfbusinessRule_WfbusinessRuleClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "WfbusinessRuleClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WfbusinessRule_WfbusinessRuleSeverity_SeverityId",
                        column: x => x.SeverityId,
                        principalTable: "WfbusinessRuleSeverity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfemailDefinition",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    ClassId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    HtmlBody = table.Column<string>(nullable: true),
                    TextBody = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfemailDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfemailDefinition_WfemailClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "WfemailClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfbusinessRuleEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    BusinessRuleId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfbusinessRuleEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfbusinessRuleEvent_WfbusinessRule_BusinessRuleId",
                        column: x => x.BusinessRuleId,
                        principalTable: "WfbusinessRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WfbusinessRuleEvent_Wfevent_EventId",
                        column: x => x.EventId,
                        principalTable: "Wfevent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfemailEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    WfemailDefinitionId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfemailEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfemailEvent_Wfevent_EventId",
                        column: x => x.EventId,
                        principalTable: "Wfevent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WfemailEvent_WfemailDefinition_WfemailDefinitionId",
                        column: x => x.WfemailDefinitionId,
                        principalTable: "WfemailDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WFActivityPermission",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    ActivityId = table.Column<Guid>(nullable: false),
                    DealId = table.Column<Guid>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WFActivityPermission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WFActivityTransition",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    ActivityIdFrom = table.Column<Guid>(nullable: false),
                    ActivityIdTo = table.Column<Guid>(nullable: false),
                    Action = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    DealId = table.Column<Guid>(nullable: true),
                    TransitionEventId = table.Column<Guid>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    ActivityIdFromNavigationId = table.Column<Guid>(nullable: true),
                    ActivityIdToNavigationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WFActivityTransition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WFActivityTransition_Wfevent_TransitionEventId",
                        column: x => x.TransitionEventId,
                        principalTable: "Wfevent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WfprocessType",
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
                    table.PrimaryKey("PK_WfprocessType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfprocessType_WfapplicationType_ApplicationTypeId",
                        column: x => x.ApplicationTypeId,
                        principalTable: "WfapplicationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WFActivity",
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
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    WFActivityScreenNameId = table.Column<Guid>(nullable: true),
                    WFActivityScreenNameId1 = table.Column<Guid>(nullable: true),
                    WFEventId = table.Column<Guid>(nullable: true),
                    WFEventId1 = table.Column<Guid>(nullable: true),
                    WFProcessTypeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WFActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WFActivity_WFActivityScreenName_WFActivityScreenNameId",
                        column: x => x.WFActivityScreenNameId,
                        principalTable: "WFActivityScreenName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WFActivity_WFActivityScreenName_WFActivityScreenNameId1",
                        column: x => x.WFActivityScreenNameId1,
                        principalTable: "WFActivityScreenName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WFActivity_Wfevent_WFEventId",
                        column: x => x.WFEventId,
                        principalTable: "Wfevent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WFActivity_Wfevent_WFEventId1",
                        column: x => x.WFEventId1,
                        principalTable: "Wfevent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WFActivity_WfprocessType_WFProcessTypeId",
                        column: x => x.WFProcessTypeId,
                        principalTable: "WfprocessType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WfprocessTypeAutoListedBrule",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    ProcessTypeId = table.Column<Guid>(nullable: false),
                    DealId = table.Column<Guid>(nullable: false),
                    ClassId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfprocessTypeAutoListedBrule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfprocessTypeAutoListedBrule_WfbusinessRuleClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "WfbusinessRuleClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WfprocessTypeAutoListedBrule_WfprocessType_ProcessTypeId",
                        column: x => x.ProcessTypeId,
                        principalTable: "WfprocessType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfprocessTypePreprocessor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    ProcessTypeId = table.Column<Guid>(nullable: false),
                    ClassId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RunBeforeFileLoad = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfprocessTypePreprocessor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfprocessTypePreprocessor_WfpreprocessorClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "WfpreprocessorClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WfprocessTypePreprocessor_WfprocessType_ProcessTypeId",
                        column: x => x.ProcessTypeId,
                        principalTable: "WfprocessType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfworkItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    ProcessTypeId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    ActivityId = table.Column<Guid>(nullable: false),
                    DealId = table.Column<Guid>(nullable: true),
                    AsOfDate = table.Column<DateTime>(nullable: true),
                    LockByUserId = table.Column<Guid>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    CreatedByUserId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    WorkItemType = table.Column<string>(nullable: true),
                    WorkItemDescription = table.Column<string>(nullable: true),
                    ReuploadedByUserId = table.Column<Guid>(nullable: true),
                    ReuploadedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfworkItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfworkItem_WFActivity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "WFActivity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WfworkItem_WfprocessType_ProcessTypeId",
                        column: x => x.ProcessTypeId,
                        principalTable: "WfprocessType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfbusinessRuleMessage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    BusinessRuleId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    WorkItemId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfbusinessRuleMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfbusinessRuleMessage_WfbusinessRule_BusinessRuleId",
                        column: x => x.BusinessRuleId,
                        principalTable: "WfbusinessRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WfbusinessRuleMessage_WfworkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalTable: "WfworkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WflineBasedRuleMessage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    BusinessRuleId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    WorkItemId = table.Column<Guid>(nullable: false),
                    LineId = table.Column<Guid>(nullable: false),
                    TableName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WflineBasedRuleMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WflineBasedRuleMessage_WfbusinessRule_BusinessRuleId",
                        column: x => x.BusinessRuleId,
                        principalTable: "WfbusinessRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WflineBasedRuleMessage_WfworkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalTable: "WfworkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfworkItemAttachedDocument",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    WorkItemId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FileData = table.Column<byte[]>(nullable: true),
                    CreatedByUserId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfworkItemAttachedDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfworkItemAttachedDocument_WfworkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalTable: "WfworkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfworkItemLockTrail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    WorkItemId = table.Column<Guid>(nullable: false),
                    LockByUserId = table.Column<Guid>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    ActionBy = table.Column<string>(nullable: true),
                    ActionOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfworkItemLockTrail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfworkItemLockTrail_WfworkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalTable: "WfworkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfworkItemLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    WorkItemId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfworkItemLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfworkItemLog_WfworkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalTable: "WfworkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfworkItemTrail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    WorkItemId = table.Column<Guid>(nullable: false),
                    ActivityTransitionId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    ActionBy = table.Column<string>(nullable: true),
                    ActionOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfworkItemTrail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfworkItemTrail_WFActivityTransition_ActivityTransitionId",
                        column: x => x.ActivityTransitionId,
                        principalTable: "WFActivityTransition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WfworkItemTrail_WfworkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalTable: "WfworkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfworkItemUploadTrail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    WorkItemId = table.Column<Guid>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    FileData = table.Column<byte[]>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    DealId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    CreatedByUserId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ActionBy = table.Column<string>(nullable: true),
                    ActionOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfworkItemUploadTrail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfworkItemUploadTrail_WfworkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalTable: "WfworkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfworkItemVersionMap",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    WorkItemId = table.Column<Guid>(nullable: false),
                    VersionId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfworkItemVersionMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfworkItemVersionMap_WfworkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalTable: "WfworkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfbusinessRuleReviewMessage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    BusinessRuleMessageId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfbusinessRuleReviewMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfbusinessRuleReviewMessage_WfbusinessRuleMessage_BusinessRuleMessageId",
                        column: x => x.BusinessRuleMessageId,
                        principalTable: "WfbusinessRuleMessage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WfworkItemAttachDocRevMessage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalId = table.Column<string>(nullable: true),
                    AltExternalId = table.Column<string>(nullable: true),
                    WorkItemAttachDocumentId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WfworkItemAttachDocRevMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WfworkItemAttachDocRevMessage_WfworkItemAttachedDocument_WorkItemAttachDocumentId",
                        column: x => x.WorkItemAttachDocumentId,
                        principalTable: "WfworkItemAttachedDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Email_UserId",
                table: "Email",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WFActivity_WFActivityScreenNameId",
                table: "WFActivity",
                column: "WFActivityScreenNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WFActivity_WFActivityScreenNameId1",
                table: "WFActivity",
                column: "WFActivityScreenNameId1");

            migrationBuilder.CreateIndex(
                name: "IX_WFActivity_WFEventId",
                table: "WFActivity",
                column: "WFEventId");

            migrationBuilder.CreateIndex(
                name: "IX_WFActivity_WFEventId1",
                table: "WFActivity",
                column: "WFEventId1");

            migrationBuilder.CreateIndex(
                name: "IX_WFActivity_WFProcessTypeId",
                table: "WFActivity",
                column: "WFProcessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WFActivityPermission_ActivityId",
                table: "WFActivityPermission",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_WFActivityScreenName_ApplicationTypeId",
                table: "WFActivityScreenName",
                column: "ApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WFActivityTransition_ActivityIdFromNavigationId",
                table: "WFActivityTransition",
                column: "ActivityIdFromNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_WFActivityTransition_ActivityIdToNavigationId",
                table: "WFActivityTransition",
                column: "ActivityIdToNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_WFActivityTransition_TransitionEventId",
                table: "WFActivityTransition",
                column: "TransitionEventId");

            migrationBuilder.CreateIndex(
                name: "IX_WfbusinessRule_ClassId",
                table: "WfbusinessRule",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_WfbusinessRule_SeverityId",
                table: "WfbusinessRule",
                column: "SeverityId");

            migrationBuilder.CreateIndex(
                name: "IX_WfbusinessRuleEvent_BusinessRuleId",
                table: "WfbusinessRuleEvent",
                column: "BusinessRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_WfbusinessRuleEvent_EventId",
                table: "WfbusinessRuleEvent",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_WfbusinessRuleMessage_BusinessRuleId",
                table: "WfbusinessRuleMessage",
                column: "BusinessRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_WfbusinessRuleMessage_WorkItemId",
                table: "WfbusinessRuleMessage",
                column: "WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WfbusinessRuleReviewMessage_BusinessRuleMessageId",
                table: "WfbusinessRuleReviewMessage",
                column: "BusinessRuleMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_WfemailDefinition_ClassId",
                table: "WfemailDefinition",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_WfemailEvent_EventId",
                table: "WfemailEvent",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_WfemailEvent_WfemailDefinitionId",
                table: "WfemailEvent",
                column: "WfemailDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_WflineBasedRuleMessage_BusinessRuleId",
                table: "WflineBasedRuleMessage",
                column: "BusinessRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_WflineBasedRuleMessage_WorkItemId",
                table: "WflineBasedRuleMessage",
                column: "WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WfprocessType_ApplicationTypeId",
                table: "WfprocessType",
                column: "ApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WfprocessType_EndActivityId",
                table: "WfprocessType",
                column: "EndActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_WfprocessType_StartActivityId",
                table: "WfprocessType",
                column: "StartActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_WfprocessTypeAutoListedBrule_ClassId",
                table: "WfprocessTypeAutoListedBrule",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_WfprocessTypeAutoListedBrule_ProcessTypeId",
                table: "WfprocessTypeAutoListedBrule",
                column: "ProcessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WfprocessTypePreprocessor_ClassId",
                table: "WfprocessTypePreprocessor",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_WfprocessTypePreprocessor_ProcessTypeId",
                table: "WfprocessTypePreprocessor",
                column: "ProcessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WfworkItem_ActivityId",
                table: "WfworkItem",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_WfworkItem_ProcessTypeId",
                table: "WfworkItem",
                column: "ProcessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WfworkItemAttachDocRevMessage_WorkItemAttachDocumentId",
                table: "WfworkItemAttachDocRevMessage",
                column: "WorkItemAttachDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_WfworkItemAttachedDocument_WorkItemId",
                table: "WfworkItemAttachedDocument",
                column: "WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WfworkItemLockTrail_WorkItemId",
                table: "WfworkItemLockTrail",
                column: "WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WfworkItemLog_WorkItemId",
                table: "WfworkItemLog",
                column: "WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WfworkItemTrail_ActivityTransitionId",
                table: "WfworkItemTrail",
                column: "ActivityTransitionId");

            migrationBuilder.CreateIndex(
                name: "IX_WfworkItemTrail_WorkItemId",
                table: "WfworkItemTrail",
                column: "WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WfworkItemUploadTrail_WorkItemId",
                table: "WfworkItemUploadTrail",
                column: "WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WfworkItemVersionMap_WorkItemId",
                table: "WfworkItemVersionMap",
                column: "WorkItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_WFActivityPermission_WFActivity_ActivityId",
                table: "WFActivityPermission",
                column: "ActivityId",
                principalTable: "WFActivity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WFActivityTransition_WFActivity_ActivityIdFromNavigationId",
                table: "WFActivityTransition",
                column: "ActivityIdFromNavigationId",
                principalTable: "WFActivity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WFActivityTransition_WFActivity_ActivityIdToNavigationId",
                table: "WFActivityTransition",
                column: "ActivityIdToNavigationId",
                principalTable: "WFActivity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WfprocessType_WFActivity_EndActivityId",
                table: "WfprocessType",
                column: "EndActivityId",
                principalTable: "WFActivity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WfprocessType_WFActivity_StartActivityId",
                table: "WfprocessType",
                column: "StartActivityId",
                principalTable: "WFActivity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WFActivity_WFActivityScreenName_WFActivityScreenNameId",
                table: "WFActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_WFActivity_WFActivityScreenName_WFActivityScreenNameId1",
                table: "WFActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_WFActivity_Wfevent_WFEventId",
                table: "WFActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_WFActivity_Wfevent_WFEventId1",
                table: "WFActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_WFActivity_WfprocessType_WFProcessTypeId",
                table: "WFActivity");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "WFActivityPermission");

            migrationBuilder.DropTable(
                name: "WFActivityTransitionEmail");

            migrationBuilder.DropTable(
                name: "WfbusinessRuleEvent");

            migrationBuilder.DropTable(
                name: "WfbusinessRuleReviewMessage");

            migrationBuilder.DropTable(
                name: "WfemailEvent");

            migrationBuilder.DropTable(
                name: "WflineBasedRuleMessage");

            migrationBuilder.DropTable(
                name: "WfprocessTypeAutoListedBrule");

            migrationBuilder.DropTable(
                name: "WfprocessTypePreprocessor");

            migrationBuilder.DropTable(
                name: "WfsendEmailNotification");

            migrationBuilder.DropTable(
                name: "WfuploadAmendmentTemplates");

            migrationBuilder.DropTable(
                name: "WfworkItemAttachDocRevMessage");

            migrationBuilder.DropTable(
                name: "WfworkItemLockTrail");

            migrationBuilder.DropTable(
                name: "WfworkItemLog");

            migrationBuilder.DropTable(
                name: "WfworkItemTrail");

            migrationBuilder.DropTable(
                name: "WfworkItemUploadTrail");

            migrationBuilder.DropTable(
                name: "WfworkItemVersionMap");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WfbusinessRuleMessage");

            migrationBuilder.DropTable(
                name: "WfemailDefinition");

            migrationBuilder.DropTable(
                name: "WfpreprocessorClass");

            migrationBuilder.DropTable(
                name: "WfworkItemAttachedDocument");

            migrationBuilder.DropTable(
                name: "WFActivityTransition");

            migrationBuilder.DropTable(
                name: "WfbusinessRule");

            migrationBuilder.DropTable(
                name: "WfemailClass");

            migrationBuilder.DropTable(
                name: "WfworkItem");

            migrationBuilder.DropTable(
                name: "WfbusinessRuleClass");

            migrationBuilder.DropTable(
                name: "WfbusinessRuleSeverity");

            migrationBuilder.DropTable(
                name: "WFActivityScreenName");

            migrationBuilder.DropTable(
                name: "Wfevent");

            migrationBuilder.DropTable(
                name: "WfprocessType");

            migrationBuilder.DropTable(
                name: "WfapplicationType");

            migrationBuilder.DropTable(
                name: "WFActivity");
        }
    }
}
