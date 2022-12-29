Public Class CATEGORIAS
    'Private Sub CATEGORIASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    'Me.Validate()
    'Me.CATEGORIASBindingSource.EndEdit()
    'Me.TableAdapterManager.UpdateAll(Me.ALMACEN_FARMACIADataSet)

    'End Sub

    Private Sub CATEGORIAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.CATEGORIAS' Puede moverla o quitarla según sea necesario.
        Me.CATEGORIASTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.CATEGORIAS)

    End Sub
    Private Sub Activar()
        NOMBRESTextBox.Enabled = True
        DESCRIPCIONTextBox.Enabled = True
        btnagregar.Visible = False
        btncancelar.Visible = True
        btngrabar.Enabled = True
    End Sub
    Private Sub Desactivar()
        NOMBRESTextBox.Enabled = False
        DESCRIPCIONTextBox.Enabled = False
        btnagregar.Visible = True
        btncancelar.Visible = False
        btngrabar.Enabled = False
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Activar()
        Me.Validate()
        Me.CATEGORIASBindingSource.AddNew()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Desactivar()
        Me.Validate()
        Me.CATEGORIASBindingSource.CancelEdit()
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        Me.Validate()
        Me.CATEGORIASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(ALMACEN_FARMACIADataSet)
        Me.CATEGORIASTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.CATEGORIAS)
        MsgBox("CATEGORÍA REGISTRADA", vbInformation, "ALMACEN FARMACIA")
        Desactivar()
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

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Activar()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Me.CATEGORIASTableAdapter.BUSCAR_CATEGORIA(ALMACEN_FARMACIADataSet.CATEGORIAS, txtbuscar.Text)
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Me.CATEGORIASTableAdapter.ELIMINAR_CATEGORIA(NOMBRESTextBox.Text)
        Me.CATEGORIASTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.CATEGORIAS)
        MsgBox("LOS DATOS DE LA CATEGORIA FUERON ELIMINADOS", vbInformation, "ALMACEN FARMACIA")
    End Sub
End Class