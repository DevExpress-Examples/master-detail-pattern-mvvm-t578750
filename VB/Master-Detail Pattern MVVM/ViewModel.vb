Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports Windows.UI.Xaml.Controls
Public Class ViewModel
    Inherits ViewModelBase

    Public Property Source() As List(Of Employee)
        Get
            Return GetProperty(Of List(Of Employee))()
        End Get
        Set(ByVal value As List(Of Employee))
            SetProperty(value)
        End Set
    End Property
    Public Property SelectedEmployee() As Employee
        Get
            Return GetProperty(Of Employee)()
        End Get
        Set(ByVal value As Employee)
            SetProperty(value)
        End Set
    End Property
    Public Sub New()
        Source = EmployeeData.DataSource
        SelectedEmployee = Source(0)
    End Sub
End Class
Public Class Employee
    Public Property FirstName() As String
    Public Property LastName() As String
    Public Property Country() As String
    Public Property City() As String
    Public Property Address() As String
    Public Property JobTitle() As String
    Public Property Phone() As String
End Class
Public Class EmployeeData
    Inherits List(Of Employee)

    Public Shared ReadOnly Property DataSource() As List(Of Employee)
        Get
            Dim list As New List(Of Employee)()
            list.Add(New Employee() With {
                    .FirstName = "Nathan",
                    .LastName = "White",
                    .Country = "Spain",
                    .City = "Madrid",
                    .Address = "90 7th Street",
                    .JobTitle = "Sales Manager",
                    .Phone = "(417) 166-3268"
                })
            list.Add(New Employee() With {
                    .FirstName = "Sandra",
                    .LastName = "Oldman",
                    .Country = "United States",
                    .City = "LA",
                    .Address = "3687 Mohawk Street",
                    .JobTitle = "Marketing Manager",
                    .Phone = "(918) 161-3649"
                })
            list.Add(New Employee() With {
                    .FirstName = "Andrea",
                    .LastName = "Deville",
                    .Country = "United Kingdom",
                    .City = "London",
                    .Address = "14 Garrett Hill",
                    .JobTitle = "Accountant",
                    .Phone = "(303) 718-1654"
                })
            list.Add(New Employee() With {
                    .FirstName = "George",
                    .LastName = "Holloway",
                    .Country = "Canada",
                    .City = "Ottawa",
                    .Address = "23 Tsawassen Blvd.",
                    .JobTitle = "Accounts Manager",
                    .Phone = "(720) 971-3927"
                })
            list.Add(New Employee() With {
                    .FirstName = "Barbara",
                    .LastName = "Chinavare",
                    .Country = "Hungary",
                    .City = "Budapest",
                    .Address = "6688 Alhambra Ave",
                    .JobTitle = "Tool Designer",
                    .Phone = "(360) 186-4982"
                })
            Return list
        End Get
    End Property
End Class
