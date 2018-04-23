Imports System
Imports System.Web.Mvc
Imports VB.Models

Namespace VB.Controllers
    Public Class HomeController
        Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function

		'DataTable
		Public Function DataTableDataBinding() As ActionResult
			If Session("DataTableModel") Is Nothing Then
				Session("DataTableModel") = InMemoryModel.GetDataTableModel()
			End If

			Return View(Session("DataTableModel"))
		End Function
		Public Function DataTableDataBindingPartial() As ActionResult
			Return PartialView(Session("DataTableModel"))
		End Function
		'

		'Typed List
		Public Function TypedListDataBinding() As ActionResult
			If Session("TypedListModel") Is Nothing Then
				Session("TypedListModel") = InMemoryModel.GetTypedListModel()
			End If

			Return View(Session("TypedListModel"))
		End Function
		Public Function TypedListDataBindingPartial() As ActionResult
			Return PartialView(Session("TypedListModel"))
		End Function
		'
    End Class
End Namespace