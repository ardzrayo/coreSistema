using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace coreSistema.AccesoDatos.Migrations
{
    public partial class CreacionEntidadesyRelaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfigMail",
                columns: table => new
                {
                    Idperiodo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nameperiodo = table.Column<string>(maxLength: 50, nullable: false),
                    Dia = table.Column<int>(nullable: false),
                    Asunto = table.Column<string>(nullable: true),
                    Cuerpomail = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigMail", x => x.Idperiodo);
                });

            migrationBuilder.CreateTable(
                name: "NetworkBond",
                columns: table => new
                {
                    Idnw = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nwbond = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkBond", x => x.Idnw);
                });

            migrationBuilder.CreateTable(
                name: "NotifiHisto",
                columns: table => new
                {
                    Idhisto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(nullable: true),
                    Destinatarios = table.Column<string>(nullable: true),
                    Asunto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifiHisto", x => x.Idhisto);
                });

            migrationBuilder.CreateTable(
                name: "Notifivps",
                columns: table => new
                {
                    Idnotivps = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idvps = table.Column<int>(nullable: false),
                    Vmname = table.Column<string>(nullable: true),
                    Idclient = table.Column<int>(nullable: false),
                    Clientname = table.Column<string>(nullable: true),
                    Clientcontact = table.Column<string>(nullable: true),
                    Emailcontact_tecnico = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifivps", x => x.Idnotivps);
                });

            migrationBuilder.CreateTable(
                name: "OSFamily",
                columns: table => new
                {
                    Idos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Osfamilyname = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OSFamily", x => x.Idos);
                });

            migrationBuilder.CreateTable(
                name: "Pool",
                columns: table => new
                {
                    Idpool = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Poolname = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pool", x => x.Idpool);
                });

            migrationBuilder.CreateTable(
                name: "SQLFamily",
                columns: table => new
                {
                    Idsql = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mssql = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SQLFamily", x => x.Idsql);
                });

            migrationBuilder.CreateTable(
                name: "VMClient",
                columns: table => new
                {
                    Idclient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clientname = table.Column<string>(maxLength: 50, nullable: false),
                    Clientfullname = table.Column<string>(maxLength: 150, nullable: false),
                    Clientemail = table.Column<string>(nullable: false),
                    Clientphone = table.Column<string>(nullable: false),
                    Clientcontact = table.Column<string>(nullable: false),
                    Emailcontact_tecnico = table.Column<string>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VMClient", x => x.Idclient);
                });

            migrationBuilder.CreateTable(
                name: "VMType",
                columns: table => new
                {
                    Idvmtype = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vmtypename = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VMType", x => x.Idvmtype);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OSVersion",
                columns: table => new
                {
                    Idosversion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idos = table.Column<int>(nullable: false),
                    Osversion = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OSVersion", x => x.Idosversion);
                    table.ForeignKey(
                        name: "FK_OSVersion_OSFamily_Idos",
                        column: x => x.Idos,
                        principalTable: "OSFamily",
                        principalColumn: "Idos",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SQLVersion",
                columns: table => new
                {
                    Idsqlversion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idsql = table.Column<int>(nullable: false),
                    MSsqlversion = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SQLVersion", x => x.Idsqlversion);
                    table.ForeignKey(
                        name: "FK_SQLVersion_SQLFamily_Idsql",
                        column: x => x.Idsql,
                        principalTable: "SQLFamily",
                        principalColumn: "Idsql",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VPS",
                columns: table => new
                {
                    Idvps = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idclient = table.Column<int>(nullable: false),
                    Vmname = table.Column<string>(maxLength: 50, nullable: false),
                    Vmuuid = table.Column<string>(nullable: true),
                    Vcpus = table.Column<int>(nullable: true),
                    Ram = table.Column<int>(nullable: true),
                    Hdisk = table.Column<int>(nullable: true),
                    Bandw = table.Column<int>(nullable: true),
                    Idnw = table.Column<int>(nullable: false),
                    Idosversion = table.Column<int>(nullable: false),
                    Idsqlversion = table.Column<int>(nullable: false),
                    Internal_ip = table.Column<string>(nullable: true),
                    External_ip = table.Column<string>(nullable: true),
                    createon = table.Column<string>(nullable: true),
                    Dnsname = table.Column<string>(nullable: true),
                    Idvmtype = table.Column<int>(nullable: false),
                    Idpool = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Rmtaccesssal = table.Column<int>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VPS", x => x.Idvps);
                    table.ForeignKey(
                        name: "FK_VPS_VMClient_Idclient",
                        column: x => x.Idclient,
                        principalTable: "VMClient",
                        principalColumn: "Idclient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VPS_NetworkBond_Idnw",
                        column: x => x.Idnw,
                        principalTable: "NetworkBond",
                        principalColumn: "Idnw",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VPS_OSVersion_Idosversion",
                        column: x => x.Idosversion,
                        principalTable: "OSVersion",
                        principalColumn: "Idosversion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VPS_Pool_Idpool",
                        column: x => x.Idpool,
                        principalTable: "Pool",
                        principalColumn: "Idpool",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VPS_SQLVersion_Idsqlversion",
                        column: x => x.Idsqlversion,
                        principalTable: "SQLVersion",
                        principalColumn: "Idsqlversion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VPS_VMType_Idvmtype",
                        column: x => x.Idvmtype,
                        principalTable: "VMType",
                        principalColumn: "Idvmtype",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OSVersion_Idos",
                table: "OSVersion",
                column: "Idos");

            migrationBuilder.CreateIndex(
                name: "IX_SQLVersion_Idsql",
                table: "SQLVersion",
                column: "Idsql");

            migrationBuilder.CreateIndex(
                name: "IX_VPS_Idclient",
                table: "VPS",
                column: "Idclient");

            migrationBuilder.CreateIndex(
                name: "IX_VPS_Idnw",
                table: "VPS",
                column: "Idnw");

            migrationBuilder.CreateIndex(
                name: "IX_VPS_Idosversion",
                table: "VPS",
                column: "Idosversion");

            migrationBuilder.CreateIndex(
                name: "IX_VPS_Idpool",
                table: "VPS",
                column: "Idpool");

            migrationBuilder.CreateIndex(
                name: "IX_VPS_Idsqlversion",
                table: "VPS",
                column: "Idsqlversion");

            migrationBuilder.CreateIndex(
                name: "IX_VPS_Idvmtype",
                table: "VPS",
                column: "Idvmtype");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ConfigMail");

            migrationBuilder.DropTable(
                name: "NotifiHisto");

            migrationBuilder.DropTable(
                name: "Notifivps");

            migrationBuilder.DropTable(
                name: "VPS");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "VMClient");

            migrationBuilder.DropTable(
                name: "NetworkBond");

            migrationBuilder.DropTable(
                name: "OSVersion");

            migrationBuilder.DropTable(
                name: "Pool");

            migrationBuilder.DropTable(
                name: "SQLVersion");

            migrationBuilder.DropTable(
                name: "VMType");

            migrationBuilder.DropTable(
                name: "OSFamily");

            migrationBuilder.DropTable(
                name: "SQLFamily");
        }
    }
}
