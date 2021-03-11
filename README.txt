Items Comparing (ASP.NET Core MVC v2.2)

I created manual list of 6 items like Lisy<Item> in code, where Item is class with needed attributes (integer: Position, string: Name, integer: Score).
Too, I created 15 combinations of items, without combination with itself, and without Item1 Item2, I considered like same combination Item2 Item1.
  
That's how I understood your colleague. 

I used Repository pattern to manipulate with data which is stored in ItemRepository class and set ItemRepository class as Singleton.

That I would have to use a database, I'd use EF Core ORM, LINQ and MSSQL. For more logic, I'd user service leyer for bussines logic.

I have more expirience with asp.net Core Web Api. I'm doing the MVC Core for the first time, so I'm having problems with View, but it is interesting.