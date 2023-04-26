Imports System.Configuration
Imports Adventure.EntityLayer
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.IdentityModel.Protocols

Public Class DataContext
    Inherits DbContext
    Sub New()
        MyBase.New()
    End Sub
    Public Overridable Property Products As DbSet(Of Product)
    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)
        modelBuilder.Entity(Of Product)()
    End Sub

End Class
