Items Comparing (ASP.NET Core MVC v2.2)

I created manual list of 6 items like Lisy<Item>, where Item is class with needed attributes (integer: Position, string: Name, integer: Score).
That's how I understood your colleague. 
I used Repository pattern to manipulate with data which is stored in ItemRepository class and set ItemRepository class as Singleton.

That I would have to use a database, I'd use EF Core ORM, LINQ and MSSQL. For more logic, I'd user service leyer for bussines logic.

