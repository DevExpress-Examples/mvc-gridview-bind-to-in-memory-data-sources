<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128551179/11.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3530)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/VB/Controllers/HomeController.vb))
* [Model.cs](./CS/CS/Models/Model.cs) (VB: [Model.vb](./VB/VB/Models/Model.vb))
* [DataTableDataBinding.cshtml](./CS/CS/Views/Home/DataTableDataBinding.cshtml)
* [DataTableDataBindingPartial.cshtml](./CS/CS/Views/Home/DataTableDataBindingPartial.cshtml)
* [Index.cshtml](./CS/CS/Views/Home/Index.cshtml)
* [TypedListDataBinding.cshtml](./CS/CS/Views/Home/TypedListDataBinding.cshtml)
* [TypedListDataBindingPartial.cshtml](./CS/CS/Views/Home/TypedListDataBindingPartial.cshtml)
<!-- default file list end -->
# How to bind GridView with standard in-memory data sources (DataTable, List<T>)
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128551179/)**
<!-- run online end -->


<p>This example illustrate how to bind the MVC GridView Extension with the standard in-memory data sources:</p><p>- The ADO.NET DataTable - DataTableDataBinding View / DataTableDataBindingPartial Partial View;</p><p>- The Typed List (List<T>) - TypedListDataBinding View / TypedListDataBindingPartial Partial View.</p><br />
<p>The GridView's definition contains:</p><p>- Set of Data Columns whose values are retrieved from the underlying datasource (the /*Data-Bound Columns*/ section);</p><p>- A single Unbound Column (the /*Unbound Columns*/ section) whose values are computed based on the bound columns' values (the /*Unbound Column Calculating*/ section).</p><br />
<p>Both data sources (Models) have the same set of fields. These Models are defined within the /Models/Model code file.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E3983">E3983: GridView - How to edit in memory data source</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E3998">E3998: GridView - How to specify a custom EditForm Template</a></p>

<br/>


