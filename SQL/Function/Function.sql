Create  Function AddOrder(orderld integer,"date" date,"AdminId" integer,
"StatusId" integer,"ShopId" integer) 
returns integer 
As $$
begin
       insert into "Order"
       values(orderld,"date",adminid, statusid,ShopId);
       return orderld;
End;$$
language plpgsql;

Create  Function AddUser (userId integer,userName character varying (30),
phone integer, roleld integer,shopId integer) 
returns integer
	
As $$
begin
    insert into "User"
    values(userId,userName, phone,roleld,shopId);
    return userId;
End;$$
language plpgsql;


Create Function DeleteUserById (userId integer)
returns integer
As $$ begin
  delete from "User"
  where "Id" = userId;
  return userId;
End;$$
LANGUAGE plpgsql;


Create  Function DeleteOrderById (Orderld integer) 
returns integer 
As $$ begin
      delete from "Order" 
      where "Id" = Orderld;
      return Orderld;
End $$
language plpgsql;
