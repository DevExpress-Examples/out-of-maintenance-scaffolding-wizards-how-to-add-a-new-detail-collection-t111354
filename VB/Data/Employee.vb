Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace Scaffolding.DetailCollections.Model
	Public Class Employee
		Private privateEmployeeID As Integer
		Public Property EmployeeID() As Integer
			Get
				Return privateEmployeeID
			End Get
			Set(ByVal value As Integer)
				privateEmployeeID = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateDepartmentID As Integer
		Public Property DepartmentID() As Integer
			Get
				Return privateDepartmentID
			End Get
			Set(ByVal value As Integer)
				privateDepartmentID = value
			End Set
		End Property
		Private privateDepartment As Department
		Public Overridable Property Department() As Department
			Get
				Return privateDepartment
			End Get
			Set(ByVal value As Department)
				privateDepartment = value
			End Set
		End Property
	End Class
End Namespace