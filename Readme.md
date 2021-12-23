<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128551179/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3530)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Grid View for MVC - How to Bind a Grid to Standard In-Memory Data Sources (DataTable, List<T>)
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3530/)**
<!-- run online end -->

This example illustrate how to bind the [MVC GridView Extension](https://docs.devexpress.com/AspNetMvc/8966/components/grid-view)'s columns to data sources fields:

* The [ADO.NET DataTable](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/dataset-datatable-dataview/datatables) - DataTableDataBinding View / DataTableDataBindingPartial Partial View
* The Typed List ([List&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0)) - TypedListDataBinding View / TypedListDataBindingPartial Partial View

The following image shows a grid bound to a DataTable object:

![A grid displays data from a DataTable](images/resulting-grid.png)

Use the [Columns](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.GridViewSettings.Columns?p=netframework) property to access the collection of grid columns.

Then add four [columns](https://docs.devexpress.com/AspNetMvc/16149/components/grid-view/concepts/data-representation-basics/columns) and bind them to the "ID", "Text", "Quantity", "Price" data source fields:

```cshtml
settings.Columns.Add("ID");
settings.Columns.Add("Text");
settings.Columns.Add("Quantity");
settings.Columns.Add("Price");
```

You can also add an [unbound column](https://docs.devexpress.com/AspNetMvc/16859/components/grid-view/concepts/data-representation-basics/columns/unbound-columns) whose values are calculated based on the values of bound columns:

```cshtml
settings.Columns.Add(unboundColumn => {
    unboundColumn.FieldName = "UniqueFieldName";
    unboundColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
});
settings.CustomUnboundColumnData = (sender, e) => {
    if (e.Column.FieldName == "UniqueFieldName") {
        int quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
        decimal price = (decimal)e.GetListSourceFieldValue("Price");
        e.Value = quantity * price;
    }
};
```

## Files to Look At

* [HomeController.cs](./CS/CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/VB/Controllers/HomeController.vb))
* [Model.cs](./CS/CS/Models/Model.cs) (VB: [Model.vb](./VB/VB/Models/Model.vb))
* [DataTableDataBinding.cshtml](./CS/CS/Views/Home/DataTableDataBinding.cshtml)
* [DataTableDataBindingPartial.cshtml](./CS/CS/Views/Home/DataTableDataBindingPartial.cshtml)
* [Index.cshtml](./CS/CS/Views/Home/Index.cshtml)
* [TypedListDataBinding.cshtml](./CS/CS/Views/Home/TypedListDataBinding.cshtml)
* [TypedListDataBindingPartial.cshtml](./CS/CS/Views/Home/TypedListDataBindingPartial.cshtml)

## Documentation

* [MVC GridView Extension](https://docs.devexpress.com/AspNetMvc/8966/components/grid-view)
* [Grid View - Columns](https://docs.devexpress.com/AspNetMvc/16149/components/grid-view/concepts/data-representation-basics/columns)
* [Grid View - Binding to Data](https://docs.devexpress.com/AspNetMvc/14722/components/grid-view/concepts/binding-to-data)

## More Examples

* [GridView - How to Edit in Memory Data Source](https://github.com/DevExpress-Examples/gridview-how-to-edit-in-memory-data-source-e3983)
* [GridView - How to Specify a Custom EditForm Template](https://github.com/DevExpress-Examples/gridview-how-to-specify-a-custom-editform-template-e3998)