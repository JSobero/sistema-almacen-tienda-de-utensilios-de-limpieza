Public Class PRODUCTOS
    Private Sub PRODUCTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PRODUCTOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PRODUCTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ALMACEN_FARMACIADataSet)

    End Sub

    Private Sub PROVEEDOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.PROVEEDOR' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.PROVEEDOR)
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.CATEGORIAS' Puede moverla o quitarla según sea necesario.
        Me.CATEGORIASTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.CATEGORIAS)
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.PRODUCTOS)

    End Sub
    Private Sub Activar()
        NOMBRETextBox.Enabled = True
        DESCRIPCIÓNTextBox.Enabled = True
        STOCKTextBox.Enabled = True
        PRECIOTextBox.Enabled = True
        GRUPO1.Enabled = True
        GRUPO2.Enabled = True
        btnagregar.Visible = False
        btncancelar.Visible = True
        btngrabar.Enabled = True
    End Sub
    Private Sub Desactivar()
        NOMBRETextBox.Enabled = False
        DESCRIPCIÓNTextBox.Enabled = False
        STOCKTextBox.Enabled = False
        PRECIOTextBox.Enabled = False
        GRUPO1.Enabled = False
        GRUPO2.Enabled = False
        btnagregar.Visible = True
        btncancelar.Visible = False
        btngrabar.Enabled = False
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Activar()
        Me.Validate()
        Me.PRODUCTOSBindingSource.AddNew()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Desactivar()
        Me.Validate()
        Me.PRODUCTOSBindingSource.CancelEdit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        IDCATEGORIASTextBox.Text = ComboBox1.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        IDPROVEEDORTextBox.Text = ComboBox2.Text
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        Me.Validate()
        Me.PRODUCTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(ALMACEN_FARMACIADataSet)
        Me.PRODUCTOSTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.PRODUCTOS)
        MsgBox("PRODUCTO REGISTRADO", vbInformation, "ALMACEN FARMACIA")
        Desactivar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Me.PRODUCTOSTableAdapter.ELIMINAR_PRODUCTO(NOMBRETextBox.Text)
        Me.PRODUCTOSTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.PRODUCTOS)
        MsgBox("LOS DATOS DEL PRODUCTO FUERON ELIMINADOS", vbInformation, "ALMACEN FARMACIA")
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Activar()
    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dim msg As MsgBoxResult
        msg = MsgBox("¿DESEA REGRESAR AL MENU?", vbYesNo, "ALMACEN FARMACIA")
        If msg = MsgBoxResult.Yes Then
            Me.Close()
            HOME.Show()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Me.PRODUCTOSTableAdapter.BUSCAR_PRODUCTO(ALMACEN_FARMACIADataSet.PRODUCTOS, txtbuscar.Text)
    End Sub
End Class