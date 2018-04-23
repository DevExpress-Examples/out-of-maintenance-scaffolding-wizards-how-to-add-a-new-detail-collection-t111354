Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Scaffolding.DetailCollections.Common.Utils
Imports Scaffolding.DetailCollections.DepartmentContextDataModel
Imports Scaffolding.DetailCollections.Common.DataModel
Imports Scaffolding.DetailCollections.Model
Imports Scaffolding.DetailCollections.Common.ViewModel

Namespace Scaffolding.DetailCollections.ViewModels
    ''' <summary>
    ''' Represents the single Department object view model.
    ''' </summary>
    Partial Public Class DepartmentViewModel
        Inherits SingleObjectViewModel(Of Department, Integer, IDepartmentContextUnitOfWork)

        ''' <summary>
        ''' Creates a new instance of DepartmentViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDepartmentContextUnitOfWork) = Nothing) As DepartmentViewModel
            Return ViewModelSource.Create(Function() New DepartmentViewModel(unitOfWorkFactory))
        End Function

        ''' <summary>
        ''' Initializes a new instance of the DepartmentViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the DepartmentViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDepartmentContextUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Departments, Function(x) x.Name)
        End Sub

        ''' <summary>
        ''' The view model for the DepartmentCourses detail collection.
        ''' </summary>
        Public ReadOnly Property DepartmentCoursesDetails() As CollectionViewModel(Of Course, Integer, IDepartmentContextUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(x As DepartmentViewModel) x.DepartmentCoursesDetails, Function(x) x.Courses, Function(x) x.DepartmentID, Sub(x, key) x.DepartmentID = key)
            End Get
        End Property

        ''' <summary>
        ''' The view model for the DepartmentEmployees detail collection.
        ''' </summary>
        Public ReadOnly Property DepartmentEmployeesDetails() As CollectionViewModel(Of Employee, Integer, IDepartmentContextUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(x As DepartmentViewModel) x.DepartmentEmployeesDetails, Function(x) x.Employees, Function(x) x.DepartmentID, Sub(x, key) x.DepartmentID = key)
            End Get
        End Property
    End Class
End Namespace
