Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Common.Utils
Imports DepartmentContextDataModel
Imports Common.DataModel
Imports Scaffolding.DetailCollections.Model
Imports Common.ViewModel
Namespace ViewModels
    ''' <summary>
    ''' Represents the single Course object view model.
    ''' </summary>
    Partial Public Class CourseViewModel
        Inherits SingleObjectViewModel(Of Course, Integer, IDepartmentContextUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of CourseViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDepartmentContextUnitOfWork) = Nothing) As CourseViewModel
            Return ViewModelSource.Create(Function() New CourseViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the CourseViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the CourseViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDepartmentContextUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Courses, Function(x) x.Title)
        End Sub
        ''' <summary>
        ''' The look-up collection of Departments for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpDepartments As IList(Of Department)
            Get
                Return GetLookUpEntities(Function(x) x.Departments)
            End Get
        End Property
    End Class
End Namespace
