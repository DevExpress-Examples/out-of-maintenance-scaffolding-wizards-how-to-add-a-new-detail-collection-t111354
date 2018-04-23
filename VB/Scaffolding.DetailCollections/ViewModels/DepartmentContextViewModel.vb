Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Scaffolding.DetailCollections.Common.DataModel
Imports Scaffolding.DetailCollections.Common.ViewModel
Imports Scaffolding.DetailCollections.DepartmentContextDataModel
Imports Scaffolding.DetailCollections.Model

Namespace Scaffolding.DetailCollections.ViewModels
    ''' <summary>
    ''' Represents the root POCO view model for the DepartmentContext data model.
    ''' </summary>
    Partial Public Class DepartmentContextViewModel
        Inherits DocumentsViewModel(Of DepartmentContextModuleDescription, IDepartmentContextUnitOfWork)

        Private Const TablesGroup As String = "Tables"

        Private Const ViewsGroup As String = "Views"

        ''' <summary>
        ''' Creates a new instance of DepartmentContextViewModel as a POCO view model.
        ''' </summary>
        Public Shared Function Create() As DepartmentContextViewModel
            Return ViewModelSource.Create(Function() New DepartmentContextViewModel())
        End Function

        ''' <summary>
        ''' Initializes a new instance of the DepartmentContextViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the DepartmentContextViewModel type without the POCO proxy factory.
        ''' </summary>
        Protected Sub New()
            MyBase.New(UnitOfWorkSource.GetUnitOfWorkFactory())
        End Sub

        Protected Overrides Function CreateModules() As DepartmentContextModuleDescription()
            Return New DepartmentContextModuleDescription() { _
                New DepartmentContextModuleDescription("Courses", "CourseCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Courses)), _
                New DepartmentContextModuleDescription("Departments", "DepartmentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Departments)), _
                New DepartmentContextModuleDescription("Employees", "EmployeeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Employees)) _
            }
        End Function


    End Class

    Partial Public Class DepartmentContextModuleDescription
        Inherits ModuleDescription(Of DepartmentContextModuleDescription)

        Public Sub New(ByVal title As String, ByVal documentType As String, ByVal group As String, Optional ByVal peekCollectionViewModelFactory As Func(Of DepartmentContextModuleDescription, Object) = Nothing)
            MyBase.New(title, documentType, group, peekCollectionViewModelFactory)
        End Sub
    End Class
End Namespace