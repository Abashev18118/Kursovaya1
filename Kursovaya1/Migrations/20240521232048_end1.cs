using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursovaya1.Migrations
{
    /// <inheritdoc />
    public partial class end1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: false),
                    PassportData = table.Column<string>(type: "text", nullable: false),
                    Phone_number = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dishes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    named = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<double>(type: "double precision", nullable: false),
                    Cost_price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mark_Up_Of_The_Dishes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    extra_charge = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mark_Up_Of_The_Dishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "menues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    number_menu = table.Column<int>(type: "integer", nullable: false),
                    name_menu = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    number_of_table = table.Column<int>(type: "integer", nullable: false),
                    number_of_possible_places = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "waiters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Salary = table.Column<double>(type: "double precision", nullable: false),
                    Service_tables = table.Column<string>(type: "text", nullable: false),
                    Service_Hall = table.Column<int>(type: "integer", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: false),
                    PassportData = table.Column<string>(type: "text", nullable: false),
                    Phone_number = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_waiters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dish_Margin_Of_Dishes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Dish_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DishId = table.Column<Guid>(type: "uuid", nullable: false),
                    Mark_up_of_the_dish_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Mark_up_of_the_dishId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish_Margin_Of_Dishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dish_Margin_Of_Dishes_dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dish_Margin_Of_Dishes_mark_Up_Of_The_Dishes_Mark_up_of_the_~",
                        column: x => x.Mark_up_of_the_dishId,
                        principalTable: "mark_Up_Of_The_Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menu_Mark_Up_Of_Dishes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Menu_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    Mark_up_of_the_dish_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Mark_up_of_the_dishId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu_Mark_Up_Of_Dishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Mark_Up_Of_Dishes_mark_Up_Of_The_Dishes_Mark_up_of_the~",
                        column: x => x.Mark_up_of_the_dishId,
                        principalTable: "mark_Up_Of_The_Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_Mark_Up_Of_Dishes_menues_MenuId",
                        column: x => x.MenuId,
                        principalTable: "menues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "halls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    number_of_hall = table.Column<int>(type: "integer", nullable: false),
                    square = table.Column<double>(type: "double precision", nullable: false),
                    number_of_tables = table.Column<int>(type: "integer", nullable: false),
                    FirstNameId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_halls_waiters_FirstNameId",
                        column: x => x.FirstNameId,
                        principalTable: "waiters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Waiter_Tables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Waiters_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WaiterId = table.Column<Guid>(type: "uuid", nullable: false),
                    Table_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waiter_Tables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Waiter_Tables_tables_TableId",
                        column: x => x.TableId,
                        principalTable: "tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Waiter_Tables_waiters_WaiterId",
                        column: x => x.WaiterId,
                        principalTable: "waiters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "restaurant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    res_number = table.Column<int>(type: "integer", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<double>(type: "double precision", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    Restaurant_hallid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_restaurant_halls_Restaurant_hallid",
                        column: x => x.Restaurant_hallid,
                        principalTable: "halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "shedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Restaurant_hallid = table.Column<Guid>(type: "uuid", nullable: false),
                    Waiterid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_shedules_halls_Restaurant_hallid",
                        column: x => x.Restaurant_hallid,
                        principalTable: "halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shedules_waiters_Waiterid",
                        column: x => x.Waiterid,
                        principalTable: "waiters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number_of_Order = table.Column<int>(type: "integer", nullable: false),
                    Date_of_Order = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Order_Status = table.Column<string>(type: "text", nullable: false),
                    Order_amount = table.Column<double>(type: "double precision", nullable: false),
                    Restaurant_hall = table.Column<int>(type: "integer", nullable: false),
                    Tableid = table.Column<Guid>(type: "uuid", nullable: false),
                    Restaurantiid = table.Column<Guid>(type: "uuid", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_tables_Tableid",
                        column: x => x.Tableid,
                        principalTable: "tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "compositions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Summ = table.Column<double>(type: "double precision", nullable: false),
                    Wishes = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Orderid = table.Column<Guid>(type: "uuid", nullable: false),
                    Dishid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_compositions_dishes_Dishid",
                        column: x => x.Dishid,
                        principalTable: "dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_compositions_orders_Orderid",
                        column: x => x.Orderid,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Client_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Orders_clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_Orders_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_compositions_Dishid",
                table: "compositions",
                column: "Dishid");

            migrationBuilder.CreateIndex(
                name: "IX_compositions_Orderid",
                table: "compositions",
                column: "Orderid");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Orders_ClientId",
                table: "Customer_Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Orders_OrderId",
                table: "Customer_Orders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Dish_Margin_Of_Dishes_DishId",
                table: "Dish_Margin_Of_Dishes",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_Dish_Margin_Of_Dishes_Mark_up_of_the_dishId",
                table: "Dish_Margin_Of_Dishes",
                column: "Mark_up_of_the_dishId");

            migrationBuilder.CreateIndex(
                name: "IX_halls_FirstNameId",
                table: "halls",
                column: "FirstNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Mark_Up_Of_Dishes_Mark_up_of_the_dishId",
                table: "Menu_Mark_Up_Of_Dishes",
                column: "Mark_up_of_the_dishId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Mark_Up_Of_Dishes_MenuId",
                table: "Menu_Mark_Up_Of_Dishes",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_RestaurantId",
                table: "orders",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Tableid",
                table: "orders",
                column: "Tableid");

            migrationBuilder.CreateIndex(
                name: "IX_restaurant_Restaurant_hallid",
                table: "restaurant",
                column: "Restaurant_hallid");

            migrationBuilder.CreateIndex(
                name: "IX_shedules_Restaurant_hallid",
                table: "shedules",
                column: "Restaurant_hallid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_shedules_Waiterid",
                table: "shedules",
                column: "Waiterid");

            migrationBuilder.CreateIndex(
                name: "IX_Waiter_Tables_TableId",
                table: "Waiter_Tables",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Waiter_Tables_WaiterId",
                table: "Waiter_Tables",
                column: "WaiterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "compositions");

            migrationBuilder.DropTable(
                name: "Customer_Orders");

            migrationBuilder.DropTable(
                name: "Dish_Margin_Of_Dishes");

            migrationBuilder.DropTable(
                name: "Menu_Mark_Up_Of_Dishes");

            migrationBuilder.DropTable(
                name: "shedules");

            migrationBuilder.DropTable(
                name: "Waiter_Tables");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "dishes");

            migrationBuilder.DropTable(
                name: "mark_Up_Of_The_Dishes");

            migrationBuilder.DropTable(
                name: "menues");

            migrationBuilder.DropTable(
                name: "restaurant");

            migrationBuilder.DropTable(
                name: "tables");

            migrationBuilder.DropTable(
                name: "halls");

            migrationBuilder.DropTable(
                name: "waiters");
        }
    }
}
