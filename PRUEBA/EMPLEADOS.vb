Public Class EMPLEADOS
    'Private Sub EMPLEADOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    'Me.Validate()
    'Me.EMPLEADOSBindingSource.EndEdit()
    'Me.TableAdapterManager.UpdateAll(Me.ALMACEN_FARMACIADataSet)

    'End Sub

    Private Sub EMPLEADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ALMACEN_FARMACIADataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOSTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.EMPLEADOS)

    End Sub

    Private Sub Activar()
        NOMBRETextBox.Enabled = True
        APELLIDOTextBox.Enabled = True
        DNITextBox.Enabled = True
        SEXOTextBox.Enabled = True
        DIRECCIONTextBox.Enabled = True
        CORREOTextBox.Enabled = True
        CELULARTextBox.Enabled = True
        btnagregar.Visible = False
        btncancelar.Visible = True
        btngrabar.Enabled = True
    End Sub
    Private Sub Desactivar()
        NOMBRETextBox.Enabled = False
        APELLIDOTextBox.Enabled = False
        DNITextBox.Enabled = False
        SEXOTextBox.Enabled = False
        DIRECCIONTextBox.Enabled = False
        CORREOTextBox.Enabled = False
        CELULARTextBox.Enabled = False
        btnagregar.Visible = True
        btncancelar.Visible = False
        btngrabar.Enabled = False
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Activar()
        Me.Validate()
        Me.EMPLEADOSBindingSource.AddNew()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Desactivar()
        Me.Validate()
        Me.EMPLEADOSBindingSource.CancelEdit()
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        Me.Validate()
        Me.EMPLEADOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(ALMACEN_FARMACIADataSet)
        Me.EMPLEADOSTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.EMPLEADOS)
        MsgBox("EMPLEADO REGISTRADO", vbInformation, "ALMACEN FARMACIA")
        Desactivar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Me.EMPLEADOSTableAdapter.ELIMINAR_EMPLEADOS(NOMBRETextBox.Text)
        Me.EMPLEADOSTableAdapter.Fill(Me.ALMACEN_FARMACIADataSet.EMPLEADOS)
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
        Me.EMPLEADOSTableAdapter.BUSCAR_EMPLEADO(ALMACEN_FARMACIADataSet.EMPLEADOS, txtbuscar.Text)
    End Sub
End Class