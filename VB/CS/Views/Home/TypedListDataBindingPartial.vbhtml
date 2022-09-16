@Html.DevExpress().GridView(Sub(settings)
                                     settings.Name = "gvTypedListDataBinding"
                                     settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "TypedListDataBindingPartial"}

                                     settings.KeyFieldName = "ID"

                                     settings.Columns.Add("ID")
                                     settings.Columns.Add("Text")
                                     settings.Columns.Add("Quantity")
                                     settings.Columns.Add("Price")

                                     'Unbound Columns
                                     settings.Columns.Add(Sub(unboundColumn)
                                                              unboundColumn.FieldName = "UniqueFieldName"
                                                              unboundColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                                                          End Sub)


                                     'Unbound Column Calculating
                                     settings.CustomUnboundColumnData = Sub(sender, e)
                                                                            If e.Column.FieldName = "UniqueFieldName" Then
                                                                                Dim quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"))
                                                                                Dim price = DirectCast(e.GetListSourceFieldValue("Price"), Decimal)

                                                                                e.Value = quantity * price
                                                                            End If
                                                                        End Sub

                                 End Sub).Bind(Model).GetHtml()