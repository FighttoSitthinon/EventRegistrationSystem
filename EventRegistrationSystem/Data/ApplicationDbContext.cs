using EventRegistrationSystem.BusinessLogics;
using EventRegistrationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EventRegistrationSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region RoleSeed
            var role = new Role()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                Name = "ADMIN",
                CreatedBy = "SYSTEM",
                CreatedDate = DateTime.UtcNow
            };
            modelBuilder.Entity<Role>().HasData(role);
            #endregion

            #region UserSeed
            string saltText = Guid.NewGuid().ToString().Replace("-", "");
            byte[] plainText = Encoding.ASCII.GetBytes("12345678");
            byte[] salt = Encoding.ASCII.GetBytes(saltText);

            PasswordManagement passwordManagement = new PasswordManagement();
            var saltHash = passwordManagement.GenerateSaltedHash(plainText, salt);

            var user = new User
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                Email = "ADMIN",
                PasswordSalt = salt,
                PasswordHash = saltHash,
                Status = (int)Status.Active,
                CreatedBy = "SYSTEM",
                CreatedDate = DateTime.UtcNow,
                UpdatedBy = "SYSTEM",
                UpdatedDate = DateTime.UtcNow,
            };
            modelBuilder.Entity<User>().HasData(user);
            #endregion

            #region UserRoleSeed
            var userRole = new UserRole()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                RoleId = role.Id,
                UserId = user.Id,
                CreatedBy = "SYSTEM",
                CreatedDate = DateTime.UtcNow,
                UpdatedBy = "SYSTEM",
                UpdatedDate = DateTime.UtcNow,
            };
            modelBuilder.Entity<UserRole>().HasData(userRole);
            #endregion

            #region EventSeed
            var events = new List<Event>() {
                new Event()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(100),
                Name = "ช้อปงานคราฟต์ เสพงานศิลป์",
                Description = "ต้อนรับความสุขในช่วงต้นปี ด้วยการชวนทุกคนมาสัมผัสบรรยากาศสุดอบอุ่นที่ “จริงใจ มาร์เก็ต เชียงใหม่” แหล่งรวมสินค้าทำมือ อาหารพื้นเมือง และวัฒนธรรมท้องถิ่น จากพ่อกาดแม่กาดที่ตั้งอกตั้งใจสร้างสรรค์สินค้าทำมือ ปลูกผักปลอดสาร และปรุงรสอาหารพื้นเมืองให้สะอาด อร่อย เหมือนทำให้คนในครอบครัวได้อิ่มอร่อยอย่างสุขใจ",
                Status = (int)Status.Active,
                Latitude = 18.8060580235494,
                Longitude = 98.9961832262694,
                CreatedBy = "SYSTEM",
                CreatedDate = DateTime.UtcNow,
                UpdatedBy = "SYSTEM",
                UpdatedDate = DateTime.UtcNow
            },
                new Event()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                StartDate = DateTime.UtcNow.AddDays(100),
                EndDate = DateTime.UtcNow.AddDays(200),
                Name = "Art Move : A Fundraising Exhibition for Bangkok Art and Culture Centre 2022",
                Description = "Join us in moving Thai contemporary art scene forward with Art Move: A Fundraising Exhibition for Bangkok Art and Culture Centre 2022, and acquire contemporary artworks by 49 leading Thai artists.",
                Status = (int)Status.Active,
                Latitude = 13.7466599,
                Longitude = 100.5302996,
                CreatedBy = "SYSTEM",
                CreatedDate = DateTime.UtcNow,
                UpdatedBy = "SYSTEM",
                UpdatedDate = DateTime.UtcNow
            }};
            modelBuilder.Entity<Event>().HasData(events);
            #endregion

            #region TicketSeed
            var tickets = new List<Ticket>() {
                new Ticket()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                TicketNumber = Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 15),
                Status = (int)Status.Active,
                Email = "test1@test01.com",
                PhoneNumber = "021234567",
                EventId = events[0].Id,
                 CreatedBy = "SYSTEM",
                CreatedDate = DateTime.UtcNow,
                UpdatedBy = "SYSTEM",
                UpdatedDate = DateTime.UtcNow
            }, 
                new Ticket()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                TicketNumber = Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 15),
                Status = (int)Status.Active,
                Email = "test2@test02.com",
                PhoneNumber = "021256788",
                EventId = events[0].Id,
                 CreatedBy = "SYSTEM",
                CreatedDate = DateTime.UtcNow,
                UpdatedBy = "SYSTEM",
                UpdatedDate = DateTime.UtcNow
            },
                new Ticket()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                TicketNumber = Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 15),
                Status = (int)Status.Active,
                Email = "test1@test01.com",
                PhoneNumber = "021234567",
                EventId = events[1].Id,
                 CreatedBy = "SYSTEM",
                CreatedDate = DateTime.UtcNow,
                UpdatedBy = "SYSTEM",
                UpdatedDate = DateTime.UtcNow
            }, 
                new Ticket()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
               TicketNumber = Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 15),
                Status = (int)Status.Active,
                Email = "test2@test02.com",
                PhoneNumber = "021256788",
                EventId = events[1].Id,
                CreatedBy = "SYSTEM",
                CreatedDate = DateTime.UtcNow,
                UpdatedBy = "SYSTEM",
                UpdatedDate = DateTime.UtcNow
            }};
            modelBuilder.Entity<Ticket>().HasData(tickets);
            #endregion
        }

        // CMD
        // Add-Migration [Migration Name] = create migration
        // Update-Database = Update migration into database
        // Remove-Migration = Remove lastest Migration
    }
}
