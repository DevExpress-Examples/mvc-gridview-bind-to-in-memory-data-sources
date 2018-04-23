@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gvDataTableDataBinding"
            settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "DataTableDataBindingPartial"}

            settings.KeyFieldName = "ID"

            settings.Columns.Add("ID")
            settings.Columns.Add("Text")
            settings.Columns.Add("Quantity")
            settings.Columns.Add("Price")

            'Unbound Columns
            settings.Columns.Add( _
                Sub(unboundColumn)
                        unboundColumn.FieldName = "UniqueFieldName"
                        unboundColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                End Sub
           )
            '
            
            'Unbound Column Calculating
            settings.CustomUnboundColumnData = _
                Sub(sender, e)
                        If e.Column.FieldName = "UniqueFieldName" Then
                            Dim quantity As Integer = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"))
                            Dim price As Decimal = CDec(e.GetListSourceFieldValue("Price"))

                            e.Value = quantity * price
                        End If
                End Sub
            '

    End Sub).Bind(Model).GetHtml()
