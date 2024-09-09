select * from "Status";
select * from "Product";
select * from "PickUpPoint";
select * from "UserRole";
select * from "Shop";
select * from "User";
select * from "Order";
select * from "Order_Product";

/////"Order"."Id", "StoreAddress",S."Id",, U."Name"
select O."Id","StoreAddress",S."Id",U."Name"
FROM "Order" as O
JOIN "Shop" as S ON  O."ShopId" = S."Id"
JOIN "User" as U ON S."Id" = U."ShopId";

select * from "Product"
join "Order_Product" on "Product"."Id" = "ProductId"
join "Order" on "Order"."Id" = "OrderId"
join "Shop" on "Shop"."Id" = "Order"."ShopId"
join  "User" on  "Shop"."Id" = "User"."ShopId"  

select *
from "User"
left join "Shop" on "Shop"."Id" = "User"."ShopId"
left join "Order" on "Order"."Id" = "Order"."ShopId"
left join "UserRole" on "UserRole"."Id" = "User"."RoleId"
left join "Order_Product" on "Order"."Id" = "OrderId"
left join "Product" on "Product"."Id" = "ProductId"
left join "PickUpPoint" on "PickUpPoint"."Id" = "PickUpPointId"
left join "Status" on "Status"."Id" = "Order"."StatusId"

select *
from "Product" as P
left join "Order_Product" as OP on P."Id" = "ProductId"
left join "Order" as O on O."Id" = "OrderId"
left join "Shop" as S on S."Id" = O."ShopId"
left join "User" as U on S."Id" = U."ShopId"
left join "UserRole" as UR on UR."Id" = U."RoleId"
left join "Status" as ST on ST."Id" = O."StatusId"

select*
from "User"
left join "Order" on "User"."ShopId" = "Order"."ShopId"

select O."Id",P."Name",OP."Count"
from "Order" as O
join "Order_Product" as OP on O."Id" = "OrderId"
join "Product" as P on P."Id" = "ProductId"

select "Name" from "Product" 
where  "IsActive" = true 
and    "IsDeleted" = false

select*
from "Order"
 join "User" on "User"."ShopId" = "Order"."ShopId"

select *
from "Shop"
join "User" on "Shop"."Id" = "User"."ShopId"

select *
from "User"
left join "Order" on "User"."ShopId" = "Order"."ShopId"


select *
from "Order" as O
left join "Order_Product" as OP on O."Id" = "OrderId"
left join "Product" as P on P."Id" = OP."ProductId"



select U."Id",U."Name",
O."Id",O."Date"
from "User" as U
left join "Order" as O on O."ShopId" = U."ShopId"

select O."Id".
from "Order" as O
left join "Order_Product" as OP on O."Id" = "OrderId"
left join "Product" as P on P."Id" = OP."ProductId"

update "Order" set  
"StatusId" = 3 
where "Id"= 3