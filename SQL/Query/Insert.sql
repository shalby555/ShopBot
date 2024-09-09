select * from "Status";
select * from "Product";
select * from "PickUpPoint";
select * from "UserRole";
select * from "Shop";
select * from "User";
select * from "Order";
select * from "Order_Product";

insert into "Status"("OrderStatus")
values ('Online'),('Priniat'),('Gotov'),('Dostavlen');

insert into "Product" ("Name")
values ('Jija'),('Noski'),('Puchki'),('SonyPS'),('Sigara');

insert into "PickUpPoint" ("Adress")
values ('Telmana'),('Kudrovo'),('Ozerki');

insert into "UserRole" ("Name")
values ('Admin'),('Manager'),('Kurier');

insert into "Shop" ("StoreAddress","PickUpPointId")
values ('Vaganovo',1),('Debenko',2),('Almazovo',3);

insert into "User" ("Name","Phone","RoleId","ShopId")
values ('Andrey',111,1,null),('Serg',123,2,1),('Robert',222,2,2),('Misha',234,3,2),('Nikita',456,2,3),
('Tomy',456,3,3);

insert into "Order" ("Date","StatusId","ShopId","AdminId")
values ('2024-01-26',1,null,1),('2023-02-14',2,2,1),('2021-12-31',3,3,null),('2022-12-22',2,3,null);

insert into "Order_Product" ("OrderId","ProductId","Count")
values (1,1,15),(2,2,30),(2,3,10),(3,4,1),(3,5,1);
