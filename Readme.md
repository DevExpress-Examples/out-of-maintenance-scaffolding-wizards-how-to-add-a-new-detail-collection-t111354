<!-- default file list -->
*Files to look at*:

* [Course.cs](./CS/Scaffolding.CodeFirst/Data/Course.cs) (VB: [Course.vb](./VB/Scaffolding.CodeFirst/Data/Course.vb))
* [Department.cs](./CS/Scaffolding.CodeFirst/Data/Department.cs) (VB: [DepartmentContext.vb](./VB/Scaffolding.CodeFirst/Data/DepartmentContext.vb))
* [DepartmentContext.cs](./CS/Scaffolding.CodeFirst/Data/DepartmentContext.cs) (VB: [DepartmentContext.vb](./VB/Scaffolding.CodeFirst/Data/DepartmentContext.vb))
* [DepartmentContextInitializer.cs](./CS/Scaffolding.CodeFirst/Data/DepartmentContextInitializer.cs) (VB: [DepartmentContextInitializer.vb](./VB/Scaffolding.CodeFirst/Data/DepartmentContextInitializer.vb))
* [Employee.cs](./CS/Scaffolding.CodeFirst/Data/Employee.cs) (VB: [Employee.vb](./VB/Scaffolding.CodeFirst/Data/Employee.vb))
* [DepartmentContextViewModel.cs](./CS/Scaffolding.CodeFirst/ViewModels/DepartmentContextViewModel.cs) (VB: [DepartmentContextViewModel.vb](./VB/Scaffolding.CodeFirst/ViewModels/DepartmentContextViewModel.vb))
* **[DepartmentContextView.xaml](./CS/Scaffolding.CodeFirst/Views/DepartmentContextView.xaml) (VB: [DepartmentContextView.xaml](./VB/Scaffolding.CodeFirst/Views/DepartmentContextView.xaml))**
<!-- default file list end -->
# Scaffolding Wizards - How to add a new detail collection


<p>This example demonstrates how to add a new detail collection to an existing project.. For more information, refer to the <a href="https://documentation.devexpress.com/#WPF/CustomDocument17156">corresponding</a> help topic.</p>
<p>You can encounter the following exception:</p>
<p><em>A first chance exception of type 'System.Data.SqlClient.SqlException' occurred in System.Data.dll</em></p>
<p><em>Additional information: A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 52 - Unable to locate a Local Database Runtime installation. Verify that SQL Server Express is properly installed and that the Local Database Runtime feature is enabled.)</em></p>
<p>This error is caused because the EntityFramework uses the missing LocalDB component.</p>
<p>To fix the issue, locate the <strong>App.config</strong> file within your application and open it. Change the defaultConnectionFactory in the following manner:<br /><br /></p>


```xaml
    <defaultConnectionFactory type="System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework" /> 
```



<br/>


