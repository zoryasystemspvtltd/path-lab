using IlabAuthentication.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IlabAuthentication.Data;


public class AuthenticationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
{
    public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        SeedData(builder);
    }

    private void SeedData(ModelBuilder builder)
    {
        var rootRoleId = 1;
        var superRoleId = 2;
        var adminRoleId = 3;
        var userRoleId = 4;
        var rootKey = "1536B022-C5C9-4358-BB6A-466F2075B7D4";

        builder.Entity<ApplicationRole>()
            .HasData(
                new ApplicationRole()
                {
                    Id = rootRoleId,
                    Name = "root",
                    ConcurrencyStamp = "1fbd204a-762b-4149-9a54-44ae6354d79c",
                    NormalizedName = "ROOT",
                    Key = rootKey,
                    Member = "root",
                },
                new ApplicationRole()
                {
                    Id = superRoleId,
                    Name = "Super Admin",
                    ConcurrencyStamp = "26E9A03B-E6BB-4567-A36B-E1DE6B6C1227",
                    NormalizedName = "SUPER",
                    Key = rootKey,
                    Member = "root",
                },
                new ApplicationRole()
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    ConcurrencyStamp = "d3dff883-d8ba-4f25-8529-29ef5f5343ce",
                    NormalizedName = "ADMIN",
                    Key = rootKey,
                    Member = "root",
                },
                new ApplicationRole()
                {
                    Id = userRoleId,
                    Name = "User",
                    ConcurrencyStamp = "c78c489a-fb53-4a42-aee6-60818a3be800",
                    NormalizedName = "USER",
                    Key = rootKey,
                    Member = "root",
                }
            );
        var systemUserId = 1;
        var superUserId = 2;

        builder.Entity<ApplicationUser>()
            .HasData(
                new ApplicationUser()
                {
                    Id = systemUserId,
                    FirstName = "Root",
                    LastName = "",
                    Email = "root",
                    UserName = "root",
                    NormalizedUserName = "ROOT",
                    NormalizedEmail = "ROOT",
                    PhoneNumber = "0000",
                    EmailConfirmed = true,
                    // Password Admin@123 // TODO Change Password
                    PasswordHash = "AQAAAAIAAYagAAAAELjslJJId5s/CZUdXozgD3Pr7IbgTUn+CiLkN8o1sf2+WTJWizU2wDKXb/IPyW35/Q==",
                    SecurityStamp = "3DMLAIZXSOSRUJWEQ2R7NTE7NGAAQYBA",
                    ConcurrencyStamp = "a7e26408-644a-48ca-a0a7-7cb94e41315d",
                    Key = rootKey,
                    Member = "root",
                },
                new ApplicationUser()
                {
                    Id = superUserId,
                    FirstName = "Super",
                    LastName = "Admin",
                    Email = "super@zorya.co.in",
                    UserName = "super@zorya.co.in",
                    NormalizedUserName = "SUPER",
                    NormalizedEmail = "SUPER@ZORYA.CO.IN",
                    PhoneNumber = "0000",
                    EmailConfirmed = true,
                    // Password Admin@123 // TODO Change Password
                    PasswordHash = "AQAAAAIAAYagAAAAELjslJJId5s/CZUdXozgD3Pr7IbgTUn+CiLkN8o1sf2+WTJWizU2wDKXb/IPyW35/Q==",
                    SecurityStamp = "3DMLAIZXSOSRUJWEQ2R7NTE7NGAAQYBA",
                    ConcurrencyStamp = "e6ac56cd-cb41-4059-b979-a0d7a7ac5fe0",
                    Key = rootKey,
                    Member = "root",
                    ParentId = systemUserId
                }
            );

        builder.Entity<IdentityUserRole<long>>()
            .HasData(
                new IdentityUserRole<long>()
                {
                    RoleId = rootRoleId,
                    UserId = systemUserId
                },
                new IdentityUserRole<long>()
                {
                    RoleId = superRoleId,
                    UserId = superUserId
                }
            );


        builder.Entity<Privilege>()
            .HasData(
                new Privilege()
                {
                    Id = 1,
                    Module = "user",
                    Name = "add",
                    RoleId = rootRoleId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 2,
                    Module = "user",
                    Name = "edit",
                    RoleId = rootRoleId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 3,
                    Module = "user",
                    Name = "delete",
                    RoleId = rootRoleId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 4,
                    Module = "user",
                    Name = "view",
                    RoleId = rootRoleId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 5,
                    Module = "user",
                    Name = "list",
                    RoleId = rootRoleId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 6,
                    Module = "role",
                    Name = "add",
                    RoleId = rootRoleId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 7,
                    Module = "role",
                    Name = "edit",
                    RoleId = rootRoleId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 8,
                    Module = "role",
                    Name = "delete",
                    RoleId = rootRoleId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 9,
                    Module = "role",
                    Name = "view",
                    RoleId = rootRoleId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 10,
                    Module = "role",
                    Name = "list",
                    RoleId = rootRoleId,
                    Key = rootKey,
                    Member = "root",
                },

                new Privilege()
                {
                    Id = 11,
                    Module = "user",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 12,
                    Module = "user",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 13,
                    Module = "user",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 14,
                    Module = "user",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 15,
                    Module = "user",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 16,
                    Module = "role",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 17,
                    Module = "role",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 18,
                    Module = "role",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 19,
                    Module = "role",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 20,
                    Module = "role",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 21,
                    Module = "enterprise",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 22,
                    Module = "enterprise",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 23,
                    Module = "enterprise",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 24,
                    Module = "enterprise",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 25,
                    Module = "enterprise",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 26,
                    Module = "businessunit",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 27,
                    Module = "businessunit",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 28,
                    Module = "businessunit",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 29,
                    Module = "businessunit",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 30,
                    Module = "businessunit",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 31,
                    Module = "vendor",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 32,
                    Module = "vendor",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 33,
                    Module = "vendor",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 34,
                    Module = "vendor",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 35,
                    Module = "vendor",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 36,
                    Module = "purchaseorder",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 37,
                    Module = "purchaseorder",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 38,
                    Module = "purchaseorder",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 39,
                    Module = "purchaseorder",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 40,
                    Module = "purchaseorder",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 41,
                    Module = "purchaseorderitem",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 42,
                    Module = "purchaseorderitem",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 43,
                    Module = "purchaseorderitem",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 44,
                    Module = "purchaseorderitem",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 45,
                    Module = "purchaseorderitem",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 46,
                    Module = "grn",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 47,
                    Module = "grn",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 48,
                    Module = "grn",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 49,
                    Module = "grn",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 50,
                    Module = "grn",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 51,
                    Module = "grnitem",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 52,
                    Module = "grnitem",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 53,
                    Module = "grnitem",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 54,
                    Module = "grnitem",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 55,
                    Module = "grnitem",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 56,
                    Module = "indent",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 57,
                    Module = "indent",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 58,
                    Module = "indent",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 59,
                    Module = "indent",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 60,
                    Module = "indent",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 61,
                    Module = "indentitem",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 62,
                    Module = "indentitem",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 63,
                    Module = "indentitem",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 64,
                    Module = "indentitem",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 65,
                    Module = "indentitem",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 66,
                    Module = "itemmaster",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 67,
                    Module = "itemmaster",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 68,
                    Module = "itemmaster",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 69,
                    Module = "itemmaster",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 70,
                    Module = "itemmaster",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 71,
                    Module = "store",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 72,
                    Module = "store",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 73,
                    Module = "store",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 74,
                    Module = "store",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 75,
                    Module = "store",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 76,
                    Module = "stockentry",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 77,
                    Module = "stockentry",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 78,
                    Module = "stockentry",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 79,
                    Module = "stockentry",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 80,
                    Module = "stockentry",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 81,
                    Module = "stockconsumption",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 82,
                    Module = "stockconsumption",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 83,
                    Module = "stockconsumption",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 84,
                    Module = "stockconsumption",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 85,
                    Module = "stockconsumption",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 86,
                    Module = "stockadjustment",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 87,
                    Module = "stockadjustment",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 88,
                    Module = "stockadjustment",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 89,
                    Module = "stockadjustment",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 90,
                    Module = "stockadjustment",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 91,
                    Module = "category",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 92,
                    Module = "category",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 93,
                    Module = "category",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 94,
                    Module = "category",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 95,
                    Module = "category",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 96,
                    Module = "unitofmeasure",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 97,
                    Module = "unitofmeasure",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 98,
                    Module = "unitofmeasure",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 99,
                    Module = "unitofmeasure",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 100,
                    Module = "unitofmeasure",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 101,
                    Module = "testmaster",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 102,
                    Module = "testmaster",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 103,
                    Module = "testmaster",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 104,
                    Module = "testmaster",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 105,
                    Module = "testmaster",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 106,
                    Module = "testparameter",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 107,
                    Module = "testparameter",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 108,
                    Module = "testparameter",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 109,
                    Module = "testparameter",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 110,
                    Module = "testparameter",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 111,
                    Module = "specimenmaster",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 112,
                    Module = "specimenmaster",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 113,
                    Module = "specimenmaster",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 114,
                    Module = "specimenmaster",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 115,
                    Module = "specimenmaster",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
				new Privilege()
                {
                    Id = 116,
                    Module = "department",
                    Name = "add",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 117,
                    Module = "department",
                    Name = "edit",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 118,
                    Module = "department",
                    Name = "delete",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 119,
                    Module = "department",
                    Name = "view",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                },
                new Privilege()
                {
                    Id = 120,
                    Module = "department",
                    Name = "list",
                    RoleId = superUserId,
                    Key = rootKey,
                    Member = "root",
                }
            );

    }
    public virtual DbSet<Privilege> Privileges { get; set; }
}

