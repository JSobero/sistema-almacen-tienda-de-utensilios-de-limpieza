Public Class PROVEEDORES
    Private Sub PROVEEDORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PROVEEDORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PROVEEDORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ALMACEN_FARMACIADataSet)

    End Sub

    Private Sub PROVEEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.PROVEEDOR' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.PROVEEDOR)

    End Sub

    Private Sub Activar()
        NOMBRETextBox.Enabled = True
        DESCRIPCIONTextBox.Enabled = True
        DNITextBox.Enabled = True
        RUCTextBox.Enabled = True
        CORREOTextBox.Enabled = True
        DIRECCIONTextBox.Enabled = True
        btnagregar.Visible = False
        btncancelar.Visible = True
        btngrabar.Enabled = True
    End Sub
    Private Sub Desactivar()
        NOMBRETextBox.Enabled = False
        DESCRIPCIONTextBox.Enabled = False
        DNITextBox.Enabled = False
        RUCTextBox.Enabled = False
        CORREOTextBox.Enabled = False
        DIRECCIONTextBox.Enabled = False
        btnagregar.Visible = True
        btncancelar.Visible = False
        btngrabar.Enabled = False
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Activar()
        Me.Validate()
        Me.PROVEEDORBindingSource.AddNew()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Desactivar()
        Me.Validate()
        Me.PROVEEDORBindingSource.CancelEdit()
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        Me.Validate()
        Me.PROVEEDORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(ALMACEN_FARMACIADataSet)
        Me.PROVEEDORTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.PROVEEDOR)
        MsgBox("PROVEEDOR REGISTRADO", vbInformation, "ALMACEN FARMACIA")
        Desactivar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Me.PROVEEDORTableAdapter.BORRAR_PROVEEDOR(NOMBRETextBox.Text)
        Me.PROVEEDORTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.PROVEEDOR)
        MsgBox("LOS DATOS DEL PROVEEDOR FUERON ELIMINADOS", vbInformation, "ALMACEN FARMACIA")
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
        Me.PROVEEDORTableAdapter.BUSCAR_PROVEEDOR(ALMACEN_FARMACIADataSet.PROVEEDOR, txtbuscar.Text)
    End Sub
End Class