Public Class DETALLE
    'Private Sub DETALLE_DE_ALMACENBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBase_DE_ALMACENBindingNavigatorSaveItem.Click, MyBase_DE_ALMACENBindingNavigatorSaveItem.Click, MyBase_DE_ALMACENBindingNavigatorSaveItem.Click, MyBase_DE_ALMACENBindingNavigatorSaveItem.Click
    'Me.Validate()
    'Me.DETALLE_DE_ALMACENBindingSource.EndEdit()
    'Me.TableAdapterManager.UpdateAll(Me.ALMACEN_FARMACIADataSet)

    'End Sub

    Private Sub DETALLE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.CATEGORIAS' Puede moverla o quitarla según sea necesario.
        Me.CATEGORIASTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.CATEGORIAS)
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOSTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.EMPLEADOS)
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.PROVEEDOR' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.PROVEEDOR)
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.PRODUCTOS)
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.DETALLE_DE_ALMACEN' Puede moverla o quitarla según sea necesario.
        Me.DETALLE_DE_ALMACENTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.DETALLE_DE_ALMACEN)

    End Sub
    Private Sub Activar()
        FECHAREGISTRODateTimePicker.Enabled = True
        GRUPO1.Enabled = True
        GRUPO2.Enabled = True
        GRUPO3.Enabled = True
        GRUPO4.Enabled = True
        btnagregar.Visible = False
        btncancelar.Visible = True
        btngrabar.Enabled = True
    End Sub
    Private Sub Desactivar()
        FECHAREGISTRODateTimePicker.Enabled = False
        GRUPO1.Enabled = False
        GRUPO2.Enabled = False
        GRUPO3.Enabled = False
        GRUPO4.Enabled = False
        btnagregar.Visible = True
        btncancelar.Visible = False
        btngrabar.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        IDPRODUCTOSTextBox.Text = ComboBox1.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        IDPROVEEDORTextBox.Text = ComboBox2.Text
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        IDEMPLEADOSTextBox.Text = ComboBox3.Text
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        IDCATEGORIASTextBox.Text = ComboBox4.Text
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Activar()
        Me.Validate()
        Me.DETALLE_DE_ALMACENBindingSource.AddNew()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Desactivar()
        Me.Validate()
        Me.DETALLE_DE_ALMACENBindingSource.CancelEdit()
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        Me.Validate()
        Me.DETALLE_DE_ALMACENBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(ALMACEN_FARMACIADataSet)
        Me.DETALLE_DE_ALMACENTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.DETALLE_DE_ALMACEN)
        MsgBox("DETALLE DE ALMACEN REGISTRADO", vbInformation, "ALMACEN FARMACIA")
        Desactivar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Me.DETALLE_DE_ALMACENTableAdapter.ELIMINAR_DETALLE(FECHAREGISTRODateTimePicker.Text)
        Me.DETALLE_DE_ALMACENTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.DETALLE_DE_ALMACEN)
        MsgBox("LOS DATOS DEL EMPLEADO FUERON ELIMINADOS", vbInformation, "ALMACEN FARMACIA")
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
        Me.DETALLE_DE_ALMACENTableAdapter.BUSCAR_DETALLE(ALMACEN_FARMACIADataSet.DETALLE_DE_ALMACEN, txtbuscar.Text)
    End Sub
End Class