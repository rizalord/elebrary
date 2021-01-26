Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class ElebraryContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ElebraryContext")
    End Sub

    Public Property Admins As DbSet(Of Admin)
    Public Property Roles As DbSet(Of Role)
    Public Property AdminLogs As DbSet(Of AdminLog)
    Public Property LoginAttempts As DbSet(Of LoginAttempt)
    Public Property ApplicationInfos As DbSet(Of ApplicationInfo)
    Public Property Books As DbSet(Of Book)
    Public Property Classes As DbSet(Of Kelas)
    Public Property Customers As DbSet(Of Customer)
    Public Property Loans As DbSet(Of Loan)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class
