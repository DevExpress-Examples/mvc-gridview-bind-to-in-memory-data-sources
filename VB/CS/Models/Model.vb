Imports System
Imports System.Data
Imports System.Collections.Generic

Namespace CS.Models

    Public Class InMemoryModel

        Const DataItemsCount As Integer = 100

        Public Property ID As Integer

        Public Property Text As String

        Public Property Quantity As Integer

        Public Property Price As Decimal

        Public Shared Function GetTypedListModel() As List(Of InMemoryModel)
            Dim typedList As List(Of InMemoryModel) = New List(Of InMemoryModel)()
            Dim randomizer As Random = New Random()
            For index As Integer = 0 To DataItemsCount - 1
                typedList.Add(New InMemoryModel() With {.ID = index, .Text = "Text" & index.ToString(), .Quantity = randomizer.Next(1, 50), .Price = CDec(Math.Round((randomizer.NextDouble() * 100), 2))})
            Next

            Return typedList
        End Function

        Public Shared Function GetDataTableModel() As DataTable
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("ID", GetType(Integer))
            dataTable.Columns.Add("Text", GetType(String))
            dataTable.Columns.Add("Quantity", GetType(Integer))
            dataTable.Columns.Add("Price", GetType(Decimal))
            dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("ID")}
            Dim randomizer As Random = New Random()
            For index As Integer = 0 To DataItemsCount - 1
                dataTable.Rows.Add(index, "Text" & index.ToString(), randomizer.Next(1, 50), CDec(Math.Round((randomizer.NextDouble() * 100), 2)))
            Next

            Return dataTable
        End Function
    End Class
End Namespace
