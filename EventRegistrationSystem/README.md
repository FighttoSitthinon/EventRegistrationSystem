# Event Registration System [ERS] - .NET 6 API

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

3. Open `Package Manager Console` and run command `update-database` to run Migration, <br>
Code first will generate database and provide starter data in your database.

4. Run Solution.

## DATABASE 

![database image](https://i.ibb.co/QdNGT1p/ERS.png)

URL: https://dbdiagram.io/d/621724de485e4335430b6f4d

## MOCKUP DATA (FOR TEST)
### **User (1 row)** - _user Admin for test_ <br>

        username: ADMIN 
        password: 12345678 

### **Roles (1 row)** <br>
* ADMIN <br>

### **UserRoles (1 row)** <br>
* User="ADMIN", Role="ADMIN" <br>

### **Events (2 rows)** <br>
1. "ช้อปงานคราฟต์ เสพงานศิลป์" <br>
2. "Art Move : A Fundraising Exhibition for Bangkok Art and Culture Centre 2022" <br>

### **Tickets (4 rows)** <br>
1. TicketNumber="7D393E6F072D44C", Email="test1@test01.com", PhoneNumber="021234567", Event="ช้อปงานคราฟต์ เสพงานศิลป์" <br>
2. TicketNumber="37C093A113E346E", Email="test2@test02.com", PhoneNumber="021256788", Event="ช้อปงานคราฟต์ เสพงานศิลป์" <br>
3. TicketNumber="FD7BEBCDB4DD403", Email="test2@test02.com", PhoneNumber="021256788", Event="Art Move : A Fundraising Exhibition for Bangkok Art and Culture Centre 2022" <br>
4. TicketNumber="1E257458D8584A1", Email="test1@test01.com", PhoneNumber="021234567", Event="Art Move : A Fundraising Exhibition for Bangkok Art and Culture Centre 2022" <br>
