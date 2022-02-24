## Event Registration System [ERS] - .NET 6 API

## SETUP

1. Install Microsoft SQL Server and Vistual Studio.

2. Open `appsettings.json` and find `DefaultConnection` and replace `DefaultConnection` value with your database connection.

```
{
  "ConnectionStrings": {
    "BloggingDatabase": "Server=(localdb)\\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;"
  },
}
```

3. Open `Package Manager Console` and run `update-database` to run Migration, <br>
Code first will generate database and seeding data such as User, Role, Event.
Code first will provide starter data
    3.1 User (1 User)
        Username: ADMIN
        Password: 12345678
    3.2 Role (1 Role)
        ADMIN 
    3.3 Event (2 Events)
    3.4 UserRole 
    3.5 Ticket


4. Run Solution.

## API

1.

2.

3.
