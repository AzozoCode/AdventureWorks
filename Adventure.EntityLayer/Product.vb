Imports System.ComponentModel.DataAnnotations


Public Class Product

    <Key>
    Public Property ProductId As Integer
    <Required>
    Public Property Name As String
    Public Property Catergory As String
    Public Property Price As Decimal
    Public Property ExpiryDate As Date


End Class
