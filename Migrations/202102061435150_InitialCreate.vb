Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.AdminLogs",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .icon_id = c.Int(nullable := False),
                        .icon_color = c.String(),
                        .title = c.String(),
                        .subtitle = c.String(),
                        .created_at = c.DateTime(nullable := False),
                        .updated_at = c.DateTime(nullable := False),
                        .admin_id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("dbo.Admins", Function(t) t.admin_id) _
                .Index(Function(t) t.admin_id)
            
            CreateTable(
                "dbo.Admins",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .fullname = c.String(),
                        .username = c.String(),
                        .password = c.String(),
                        .created_at = c.DateTime(nullable := False),
                        .updated_at = c.DateTime(nullable := False),
                        .role_id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("dbo.Roles", Function(t) t.role_id) _
                .Index(Function(t) t.role_id)
            
            CreateTable(
                "dbo.Roles",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .name = c.String(),
                        .created_at = c.DateTime(nullable := False),
                        .updated_at = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.id)
            
            CreateTable(
                "dbo.ApplicationInfoes",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .key = c.String(),
                        .value = c.String(),
                        .created_at = c.DateTime(nullable := False),
                        .updated_at = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.id)
            
            CreateTable(
                "dbo.Books",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .title = c.String(),
                        .author = c.String(),
                        .publisher = c.String(),
                        .published_at = c.DateTime(nullable := False),
                        .is_featured = c.Boolean(nullable := False),
                        .stock = c.Int(nullable := False),
                        .created_at = c.DateTime(nullable := False),
                        .updated_at = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.id)
            
            CreateTable(
                "dbo.Kelas",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .name = c.String(),
                        .created_at = c.DateTime(nullable := False),
                        .updated_at = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.id)
            
            CreateTable(
                "dbo.Customers",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .name = c.String(),
                        .address = c.String(),
                        .fines_per_day = c.Int(nullable := False),
                        .created_at = c.DateTime(nullable := False),
                        .updated_at = c.DateTime(nullable := False),
                        .return_at = c.DateTime(nullable := False),
                        .is_returned = c.Boolean(nullable := False),
                        .identifier_id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("dbo.Kelas", Function(t) t.identifier_id) _
                .Index(Function(t) t.identifier_id)
            
            CreateTable(
                "dbo.Loans",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .quantity = c.Int(nullable := False),
                        .created_at = c.DateTime(nullable := False),
                        .updated_at = c.DateTime(nullable := False),
                        .book_id = c.Int(),
                        .Customer_id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("dbo.Books", Function(t) t.book_id) _
                .ForeignKey("dbo.Customers", Function(t) t.Customer_id) _
                .Index(Function(t) t.book_id) _
                .Index(Function(t) t.Customer_id)
            
            CreateTable(
                "dbo.LoginAttempts",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .attempts = c.Int(nullable := False),
                        .last_login = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Loans", "Customer_id", "dbo.Customers")
            DropForeignKey("dbo.Loans", "book_id", "dbo.Books")
            DropForeignKey("dbo.Customers", "identifier_id", "dbo.Kelas")
            DropForeignKey("dbo.AdminLogs", "admin_id", "dbo.Admins")
            DropForeignKey("dbo.Admins", "role_id", "dbo.Roles")
            DropIndex("dbo.Loans", New String() { "Customer_id" })
            DropIndex("dbo.Loans", New String() { "book_id" })
            DropIndex("dbo.Customers", New String() { "identifier_id" })
            DropIndex("dbo.Admins", New String() { "role_id" })
            DropIndex("dbo.AdminLogs", New String() { "admin_id" })
            DropTable("dbo.LoginAttempts")
            DropTable("dbo.Loans")
            DropTable("dbo.Customers")
            DropTable("dbo.Kelas")
            DropTable("dbo.Books")
            DropTable("dbo.ApplicationInfoes")
            DropTable("dbo.Roles")
            DropTable("dbo.Admins")
            DropTable("dbo.AdminLogs")
        End Sub
    End Class
End Namespace
