Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Scaffolding.DetailCollections.Common.Utils
Imports Scaffolding.DetailCollections.Common.DataModel
Imports Scaffolding.DetailCollections.Common.DataModel.EntityFramework
Imports Scaffolding.DetailCollections.Model

Namespace Scaffolding.DetailCollections.DepartmentContextDataModel
    ''' <summary>
    ''' A DepartmentContextUnitOfWork instance that represents the run-time implementation of the IDepartmentContextUnitOfWork interface.
    ''' </summary>
    Public Class DepartmentContextUnitOfWork
        Inherits DbUnitOfWork(Of DepartmentContext)
        Implements IDepartmentContextUnitOfWork

        Public Sub New(ByVal contextFactory As Func(Of DepartmentContext))
            MyBase.New(contextFactory)
        End Sub

        Private ReadOnly Property IDepartmentContextUnitOfWork_Courses() As IRepository(Of Course, Integer) Implements IDepartmentContextUnitOfWork.Courses
            Get
                Return GetRepository(Function(x) x.Set(Of Course)(), Function(x) x.CourseID)
            End Get
        End Property

        Private ReadOnly Property IDepartmentContextUnitOfWork_Departments() As IRepository(Of Department, Integer) Implements IDepartmentContextUnitOfWork.Departments
            Get
                Return GetRepository(Function(x) x.Set(Of Department)(), Function(x) x.DepartmentID)
            End Get
        End Property

        Private ReadOnly Property IDepartmentContextUnitOfWork_Employees() As IRepository(Of Employee, Integer) Implements IDepartmentContextUnitOfWork.Employees
            Get
                Return GetRepository(Function(x) x.Set(Of Employee)(), Function(x) x.EmployeeID)
            End Get
        End Property
    End Class
End Namespace
