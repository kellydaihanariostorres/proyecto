using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIRestLab01.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    BodegaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.BodegaId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Edad = table.Column<int>(type: "int", maxLength: 99, nullable: false),
                    tipoDocumento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    numDocumento = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    FacturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IVACompra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.FacturaId);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    InventarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreProducto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdProducto = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    IdFactura = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    PrecioProducto = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CantidadProducto = table.Column<int>(type: "int", maxLength: 999, nullable: false),
                    MarcaProducto = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    ClasificacionProducto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.InventarioId);
                });

            migrationBuilder.CreateTable(
                name: "Nominas",
                columns: table => new
                {
                    NominaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CuentaBancaria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominas", x => x.NominaId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreProducto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrecioProducto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MarcaProducto = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ClasificacionProducto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    ProveedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    numDocumento = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Edad = table.Column<int>(type: "int", maxLength: 99, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    NombreEntidadBancaria = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NumeroCuentaBancaria = table.Column<int>(type: "int", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ProveedorId);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaInicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaFin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sueldo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    BodegaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleados_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "BodegaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bodegas",
                columns: new[] { "BodegaId", "Ciudad", "Direccion", "Estado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Medellin", "Calle 59 B Bis # 37-49", "Inactivo", "Paacifico" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Bogota D.C", "Calle 95#75-05", "Activo", "Candela" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Apellido", "Correo", "Edad", "Nombre", "numDocumento", "tipoDocumento" },
                values: new object[,]
                {
                    { new Guid("01fecba8-664d-4b20-b5de-024705497d4a"), "Rios", "rios.rios@gmail.com", 30, "Kelly", 1013102042, "CC" },
                    { new Guid("01fecbc1-664d-4b20-b5de-024705497d4a"), "Mahecha", "rios.rios@gmail.com", 21, "Luna", 1000257543, "CC" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "312 Forest Avenue, BF 923", "USA", "Admin_Solutions Ltd" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "583 Wall Dr. Gwynn Oak, MD 21207", "USA", "IT_Solutions Ltd" }
                });

            migrationBuilder.InsertData(
                table: "Facturas",
                columns: new[] { "FacturaId", "FechaCompra", "IVACompra", "Subtotal", "Total" },
                values: new object[,]
                {
                    { new Guid("64b512e7-46ae-4989-a049-a446118099c4"), new DateTime(2023, 9, 20, 2, 17, 30, 951, DateTimeKind.Local).AddTicks(9538), 0.18m, 100.00m, 118.00m },
                    { new Guid("fd713788-b5ae-49ff-8b2c-f311b9cb0cc4"), new DateTime(2023, 9, 20, 2, 17, 30, 951, DateTimeKind.Local).AddTicks(9519), 0.18m, 100.00m, 118.00m }
                });

            migrationBuilder.InsertData(
                table: "Inventarios",
                columns: new[] { "InventarioId", "CantidadProducto", "ClasificacionProducto", "IdFactura", "IdProducto", "MarcaProducto", "NombreProducto", "PrecioProducto" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 50, "Vino", 777, 222, "Gato Negro", "Gato Negro", "20000" });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "NominaId", "CuentaBancaria", "Direccion", "Email", "FechaCreacion", "Telefono" },
                values: new object[,]
                {
                    { new Guid("376d45c8-659d-4ace-b249-cfbf4f231915"), "1234567890", "456 Calle Secundaria", "otrocorreo@example.com", new DateTime(2023, 9, 20, 2, 17, 30, 952, DateTimeKind.Local).AddTicks(11), "555-987-6543" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"), "1234567890", "123 Calle Principal", "correo@example.com", new DateTime(2023, 9, 20, 2, 17, 30, 952, DateTimeKind.Local).AddTicks(5), "555-123-4567" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "ClasificacionProducto", "MarcaProducto", "NombreProducto", "PrecioProducto" },
                values: new object[,]
                {
                    { new Guid("80abbca4-664d-4b23-b5de-024705497d4a"), "whisky", "Jack Dniel's", "Jack Dniel's ", "50000" },
                    { new Guid("80abbca5-664d-4b22-b5de-024705497d4a"), "Vino", "Gato Negro", "Gato Negro ", "20000" },
                    { new Guid("80abbca8-664d-4b21-b5de-024705497d4a"), "Cerveza", "Poker", "Poker ", "3000" }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "ProveedorId", "Correo", "Direccion", "Edad", "Nombre", "NombreEntidadBancaria", "NumeroCuentaBancaria", "Telefono", "numDocumento" },
                values: new object[,]
                {
                    { new Guid("00abc238-664d-4b20-b5de-024705497d4a"), "Pedroxd@gmail.com", "Cll 10c #11-32", 30, "Pedro", "BancoBogotá", 51156, "3623568478", 1000257543 },
                    { new Guid("01bbcdef-664d-4b20-b5de-024705497d4a"), "Juan0212@gmail.com", "Cra 43i #50-32 sur", 30, "Juan", "Bancolombia", 478543462, "3512255454", 1013102042 }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "EmpleadoId", "Apellido", "BodegaId", "Cargo", "Documento", "FechaFin", "FechaInicio", "Nombre", "Sueldo" },
                values: new object[,]
                {
                    { new Guid("80abbca4-664d-4b20-b5de-024705497d4a"), "Rodriguez", new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Analista", "15684283", "29/10/2022", "25/09/2020", "Andres", "1500000" },
                    { new Guid("80abbca5-664d-4b20-b5de-024705497d4a"), "Murcia", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Analista", "348651384", "30/02/2023", "29/01/2020", "Johan", "20000000" },
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "Raiden", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Analista", "165813218", "30/02/2023", "15/03/2020", "Sam ", "55300000" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_BodegaId",
                table: "Empleados",
                column: "BodegaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Nominas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Bodegas");
        }
    }
}
