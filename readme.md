<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/417079715/21.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1036629)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Dashboard for WinForms - How to Aggregate Data by String Concatenation

This example shows how to use string concatenation to aggregate data in client mode.

<!-- default file list -->
## Files to Look At
* [Form1.cs](./CS/Dashboard_FirstValueAggregate/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_FirstValueAggregate/Form1.vb))
* [StringConcatFunction.cs](./CS/Dashboard_FirstValueAggregate/StringConcatFunction.cs) (VB: [StringConcatFunction.vb](./VB/Dashboard_FirstValueAggregate/StringConcatFunction.vb))
* [Program.cs](./CS/Dashboard_FirstValueAggregate/Program.cs#L23) (VB: [Program.vb](./VB/Dashboard_FirstValueAggregate/Program.vb#L23))
<!-- default file list end -->

## Overview

In this example, the [Grid](https://docs.devexpress.com/Dashboard/15150/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/dashboard-item-settings/grid) dashboard item displays the first _СontactName_ value by country. 

![first value function](images/firstvalue.png)

The following expression gets the first value of the _СontactName_ field:

| Calculated Field | Expression |
| --- | --- |
| First Contact Name | ``` FirstValue([ContactName]) ``` |

Call the [CriteriaOperator.RegisterCustomFunction](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(DevExpress.Data.Filtering.ICustomFunctionOperator)) method to register a custom function in your project (see [Program.cs](./CS/Dashboard_FirstValueAggregate/Program.cs#L24)/[Program.vb](./VB/Dashboard_FirstValueAggregate/Program.vb#L24)).


## Documentation

- [Expression Constants, Operators, and Functions](https://docs.devexpress.com/Dashboard/400122/common-features/advanced-analytics/expression-constants-operators-and-functions)
- [Grouping](https://docs.devexpress.com/Dashboard/116535/common-features/data-shaping/grouping)
- [ICustomFunctionOperatorBrowsable](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.ICustomFunctionOperatorBrowsable)
- [ICustomFunctionOperatorFormattable](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.ICustomFunctionOperatorFormattable)

## More Examples

- [Dashboard for WinForms - How to Calculate the Numeric Group Interval](https://github.com/DevExpress-Examples/winforms-dashboard-numeric-group-intervals)
- [Dashboard for WinForms - How to Calculate Fiscal Functions from Date-Time Data Fields](https://github.com/DevExpress-Examples/How-to-calculate-fiscal-functions-for-date-time-data-fields)
- [Dashboard for WinForms - How to Aggregate Data by String Concatenation](https://github.com/DevExpress-Examples/winforms-dashboard-custom-aggregates)
