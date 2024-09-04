CREATE TABLE IF NOT EXISTS "User" (
	"Id" SERIAL PRIMARY KEY,
	"Name" character varying(30),
     "Phone" integer,
	"RoleId" integer,
	"ShopId" integer
);

CREATE TABLE IF NOT EXISTS "Product" (
	"Id" serial PRIMARY KEY,
	"Name" character varying(30),
	"IsActive" boolean default true,
	"IsDeleted" boolean default false
);

CREATE TABLE IF NOT EXISTS "Order" (
	"Id" serial PRIMARY KEY,
	"Date" DATE,
	"AdminId" integer,
	"StatusId" integer,
	"ShopId" integer
);

CREATE TABLE IF NOT EXISTS "PickUpPoint" (
	"Id" serial PRIMARY KEY,
	"Adress" character varying(30)
);

CREATE TABLE IF NOT EXISTS "UserRole" (
	"Id" serial PRIMARY KEY,
	"Name" character varying(30)
);

CREATE TABLE IF NOT EXISTS "Order_Product" (
	"OrderId" serial,
	"ProductId" integer,
	"Count" integer
);

CREATE TABLE IF NOT EXISTS "Shop" (
	"Id" serial PRIMARY KEY,
	"StoreAddress" character varying(30),
	"PickUpPointId" integer
);

CREATE TABLE IF NOT EXISTS "Status" (
	"Id" serial PRIMARY KEY,
	"OrderStatus" character varying(30) 
);

ALTER TABLE "User" ADD CONSTRAINT "User_fk2" FOREIGN KEY ("RoleId") REFERENCES "UserRole"("Id");

ALTER TABLE "User" ADD CONSTRAINT "User_fk4" FOREIGN KEY ("ShopId") REFERENCES "Shop"("Id");

ALTER TABLE "Order" ADD CONSTRAINT "Order_fk2" FOREIGN KEY ("AdminId") REFERENCES "User"("Id");

ALTER TABLE "Order" ADD CONSTRAINT "Order_fk3" FOREIGN KEY ("StatusId") REFERENCES "Status"("Id");

ALTER TABLE "Order" ADD CONSTRAINT "Order_fk4" FOREIGN KEY ("ShopId") REFERENCES "Shop"("Id");

ALTER TABLE "Order_Product" ADD CONSTRAINT "Order_Product_fk0" FOREIGN KEY ("OrderId") REFERENCES "Order"("Id");

ALTER TABLE "Order_Product" ADD CONSTRAINT "Order_Product_fk1" FOREIGN KEY ("ProductId") REFERENCES "Product"("Id");

ALTER TABLE "Shop" ADD CONSTRAINT "Shop_fk2" FOREIGN KEY ("PickUpPointId") REFERENCES "PickUpPoint"("Id");


