namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'204854c0-8ebe-469a-a1db-66270927986f', N'guest@winterstore.com', 0, N'AJDEQFGc0FoqCQiM7RNDa8EV2Xl8NAGCmx+IxdkvJ6fXIvkBfrbvxKbgyYh7XWbujw==', N'90a7fa2e-7775-4c8b-9552-1d357aeafdc1', NULL, 0, 0, NULL, 1, 0, N'guest@winterstore.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'57bdc4e6-e7bd-4bdd-84b6-dcb701351db4', N'admin@winterstore.com', 0, N'AIx9nH5bJ/Y/3sUA3BXO7pOsIkrwvIjEK3TGq4ulHyUfiiWLqgrJ2qLhFZkY3XIosg==', N'cc882f7b-3022-48e1-beb2-043768312a82', NULL, 0, 0, NULL, 1, 0, N'admin@winterstore.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ac88590a-d88e-43d0-b873-40fc08cecb92', N'customersperson@winterstore.com', 0, N'AJDaPRGwS6U9tTbULMyN8PFsPg6kwT0wjeEhOZ29tCcox6wooz1YRGNqJdyj+ZF07Q==', N'd7be5a6f-7498-41b8-946a-f127362d7f58', NULL, 0, 0, NULL, 1, 0, N'customersperson@winterstore.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f140c5bb-d7c3-4c84-9cea-4e46d6335f9c', N'equipmentperson@winterstore.com', 0, N'APpTY6vFoBPqZSTENuuOoR0zA9XooK2wvAGsRKq1UkVl+hWuKilfoVLpuobvrlFH4Q==', N'a5f2f863-1882-49ba-ab6c-938daf8d8fec', NULL, 0, 0, NULL, 1, 0, N'equipmentperson@winterstore.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f42a7162-f0b2-4bba-b866-e14ea1317fc5', N'rentalperson@winterstore.com', 0, N'ALIxTlOMFmO7YF4Z8U2v8ubNB+wdi9Ls4oNRXerWtByFBtO7D1qrzswCMSUaFqYgJQ==', N'71de3ef4-a262-4bdc-a8b4-15549abf9521', NULL, 0, 0, NULL, 1, 0, N'rentalperson@winterstore.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b6a08a9a-8321-46f5-8a1a-affd654a25f2', N'Admin')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c17a6904-e8c2-4928-8673-ad7dc25ef674', N'CanAddCustomers')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7eb46b8c-97b6-4fd7-ac12-0c4603a47ab9', N'CanAddEquipment')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'81405116-ded2-4b9a-9066-21d78ddb5525', N'CanRent')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f140c5bb-d7c3-4c84-9cea-4e46d6335f9c', N'7eb46b8c-97b6-4fd7-ac12-0c4603a47ab9')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f42a7162-f0b2-4bba-b866-e14ea1317fc5', N'81405116-ded2-4b9a-9066-21d78ddb5525')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'57bdc4e6-e7bd-4bdd-84b6-dcb701351db4', N'b6a08a9a-8321-46f5-8a1a-affd654a25f2')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ac88590a-d88e-43d0-b873-40fc08cecb92', N'c17a6904-e8c2-4928-8673-ad7dc25ef674')
"
                );
        }
        
        public override void Down()
        {
        }
    }
}
