<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DETALLE
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FECHAREGISTROLabel As System.Windows.Forms.Label
        Dim IDPRODUCTOSLabel As System.Windows.Forms.Label
        Dim IDEMPLEADOSLabel As System.Windows.Forms.Label
        Dim IDCATEGORIASLabel As System.Windows.Forms.Label
        Dim IDPROVEEDORLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DETALLE))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btngrabar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.ALMACEN_FARMACIADataSet = New PRUEBA.ALMACEN_FARMACIADataSet()
        Me.DETALLE_DE_ALMACENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DETALLE_DE_ALMACENTableAdapter = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.DETALLE_DE_ALMACENTableAdapter()
        Me.TableAdapterManager = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.TableAdapterManager()
        Me.DETALLE_DE_ALMACENBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DETALLE_DE_ALMACENBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DETALLE_DE_ALMACENDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAREGISTRODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IDPRODUCTOSTextBox = New System.Windows.Forms.TextBox()
        Me.IDEMPLEADOSTextBox = New System.Windows.Forms.TextBox()
        Me.IDCATEGORIASTextBox = New System.Windows.Forms.TextBox()
        Me.IDPROVEEDORTextBox = New System.Windows.Forms.TextBox()
        Me.GRUPO1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GRUPO2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PROVEEDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GRUPO3 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.EMPLEADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GRUPO4 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.CATEGORIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PRODUCTOSTableAdapter = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.PRODUCTOSTableAdapter()
        Me.PROVEEDORTableAdapter = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.PROVEEDORTableAdapter()
        Me.EMPLEADOSTableAdapter = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.EMPLEADOSTableAdapter()
        Me.CATEGORIASTableAdapter = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.CATEGORIASTableAdapter()
        FECHAREGISTROLabel = New System.Windows.Forms.Label()
        IDPRODUCTOSLabel = New System.Windows.Forms.Label()
        IDEMPLEADOSLabel = New System.Windows.Forms.Label()
        IDCATEGORIASLabel = New System.Windows.Forms.Label()
        IDPROVEEDORLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ALMACEN_FARMACIADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLE_DE_ALMACENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLE_DE_ALMACENBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DETALLE_DE_ALMACENBindingNavigator.SuspendLayout()
        CType(Me.DETALLE_DE_ALMACENDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRUPO1.SuspendLayout()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRUPO2.SuspendLayout()
        CType(Me.PROVEEDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRUPO3.SuspendLayout()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRUPO4.SuspendLayout()
        CType(Me.CATEGORIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FECHAREGISTROLabel
        '
        FECHAREGISTROLabel.AutoSize = True
        FECHAREGISTROLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FECHAREGISTROLabel.Location = New System.Drawing.Point(216, 36)
        FECHAREGISTROLabel.Name = "FECHAREGISTROLabel"
        FECHAREGISTROLabel.Size = New System.Drawing.Size(126, 16)
        FECHAREGISTROLabel.TabIndex = 18
        FECHAREGISTROLabel.Text = "FECHAREGISTRO:"
        '
        'IDPRODUCTOSLabel
        '
        IDPRODUCTOSLabel.AutoSize = True
        IDPRODUCTOSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDPRODUCTOSLabel.Location = New System.Drawing.Point(232, 69)
        IDPRODUCTOSLabel.Name = "IDPRODUCTOSLabel"
        IDPRODUCTOSLabel.Size = New System.Drawing.Size(110, 16)
        IDPRODUCTOSLabel.TabIndex = 20
        IDPRODUCTOSLabel.Text = "IDPRODUCTOS:"
        '
        'IDEMPLEADOSLabel
        '
        IDEMPLEADOSLabel.AutoSize = True
        IDEMPLEADOSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDEMPLEADOSLabel.Location = New System.Drawing.Point(441, 69)
        IDEMPLEADOSLabel.Name = "IDEMPLEADOSLabel"
        IDEMPLEADOSLabel.Size = New System.Drawing.Size(107, 16)
        IDEMPLEADOSLabel.TabIndex = 22
        IDEMPLEADOSLabel.Text = "IDEMPLEADOS:"
        '
        'IDCATEGORIASLabel
        '
        IDCATEGORIASLabel.AutoSize = True
        IDCATEGORIASLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDCATEGORIASLabel.Location = New System.Drawing.Point(437, 97)
        IDCATEGORIASLabel.Name = "IDCATEGORIASLabel"
        IDCATEGORIASLabel.Size = New System.Drawing.Size(111, 16)
        IDCATEGORIASLabel.TabIndex = 24
        IDCATEGORIASLabel.Text = "IDCATEGORIAS:"
        '
        'IDPROVEEDORLabel
        '
        IDPROVEEDORLabel.AutoSize = True
        IDPROVEEDORLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDPROVEEDORLabel.Location = New System.Drawing.Point(232, 97)
        IDPROVEEDORLabel.Name = "IDPROVEEDORLabel"
        IDPROVEEDORLabel.Size = New System.Drawing.Size(110, 16)
        IDPROVEEDORLabel.TabIndex = 26
        IDPROVEEDORLabel.Text = "IDPROVEEDOR:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnregresar)
        Me.Panel1.Controls.Add(Me.btneditar)
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.txtbuscar)
        Me.Panel1.Controls.Add(Me.btngrabar)
        Me.Panel1.Controls.Add(Me.btnbuscar)
        Me.Panel1.Controls.Add(Me.btnagregar)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-3, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 371)
        Me.Panel1.TabIndex = 15
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(3, 81)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(203, 59)
        Me.btncancelar.TabIndex = 13
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        Me.btncancelar.Visible = False
        '
        'btnregresar
        '
        Me.btnregresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregresar.Location = New System.Drawing.Point(3, 307)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(203, 59)
        Me.btnregresar.TabIndex = 12
        Me.btnregresar.Text = "REGRESAR"
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.Location = New System.Drawing.Point(3, 252)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(203, 59)
        Me.btneditar.TabIndex = 12
        Me.btneditar.Text = "EDITAR"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(3, 195)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(203, 59)
        Me.btneliminar.TabIndex = 11
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(18, 43)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(174, 26)
        Me.txtbuscar.TabIndex = 9
        '
        'btngrabar
        '
        Me.btngrabar.Enabled = False
        Me.btngrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngrabar.Location = New System.Drawing.Point(3, 138)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(203, 59)
        Me.btngrabar.TabIndex = 10
        Me.btngrabar.Text = "GRABAR"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(3, 5)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(203, 31)
        Me.btnbuscar.TabIndex = 8
        Me.btnbuscar.Text = "BUSCAR"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(3, 81)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(203, 59)
        Me.btnagregar.TabIndex = 9
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'ALMACEN_FARMACIADataSet
        '
        Me.ALMACEN_FARMACIADataSet.DataSetName = "ALMACEN_FARMACIADataSet"
        Me.ALMACEN_FARMACIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DETALLE_DE_ALMACENBindingSource
        '
        Me.DETALLE_DE_ALMACENBindingSource.DataMember = "DETALLE_DE_ALMACEN"
        Me.DETALLE_DE_ALMACENBindingSource.DataSource = Me.ALMACEN_FARMACIADataSet
        '
        'DETALLE_DE_ALMACENTableAdapter
        '
        Me.DETALLE_DE_ALMACENTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORIASTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_DE_ALMACENTableAdapter = Me.DETALLE_DE_ALMACENTableAdapter
        Me.TableAdapterManager.EMPLEADOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.PROVEEDORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DETALLE_DE_ALMACENBindingNavigator
        '
        Me.DETALLE_DE_ALMACENBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DETALLE_DE_ALMACENBindingNavigator.BindingSource = Me.DETALLE_DE_ALMACENBindingSource
        Me.DETALLE_DE_ALMACENBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DETALLE_DE_ALMACENBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DETALLE_DE_ALMACENBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DETALLE_DE_ALMACENBindingNavigatorSaveItem})
        Me.DETALLE_DE_ALMACENBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DETALLE_DE_ALMACENBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DETALLE_DE_ALMACENBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DETALLE_DE_ALMACENBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DETALLE_DE_ALMACENBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DETALLE_DE_ALMACENBindingNavigator.Name = "DETALLE_DE_ALMACENBindingNavigator"
        Me.DETALLE_DE_ALMACENBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DETALLE_DE_ALMACENBindingNavigator.Size = New System.Drawing.Size(793, 25)
        Me.DETALLE_DE_ALMACENBindingNavigator.TabIndex = 16
        Me.DETALLE_DE_ALMACENBindingNavigator.Text = "BindingNavigator1"
        Me.DETALLE_DE_ALMACENBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DETALLE_DE_ALMACENBindingNavigatorSaveItem
        '
        Me.DETALLE_DE_ALMACENBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DETALLE_DE_ALMACENBindingNavigatorSaveItem.Image = CType(resources.GetObject("DETALLE_DE_ALMACENBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DETALLE_DE_ALMACENBindingNavigatorSaveItem.Name = "DETALLE_DE_ALMACENBindingNavigatorSaveItem"
        Me.DETALLE_DE_ALMACENBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DETALLE_DE_ALMACENBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DETALLE_DE_ALMACENDataGridView
        '
        Me.DETALLE_DE_ALMACENDataGridView.AutoGenerateColumns = False
        Me.DETALLE_DE_ALMACENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLE_DE_ALMACENDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DETALLE_DE_ALMACENDataGridView.DataSource = Me.DETALLE_DE_ALMACENBindingSource
        Me.DETALLE_DE_ALMACENDataGridView.Location = New System.Drawing.Point(219, 148)
        Me.DETALLE_DE_ALMACENDataGridView.Name = "DETALLE_DE_ALMACENDataGridView"
        Me.DETALLE_DE_ALMACENDataGridView.Size = New System.Drawing.Size(640, 200)
        Me.DETALLE_DE_ALMACENDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDDETALLE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDDETALLE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FECHAREGISTRO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FECHAREGISTRO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IDPRODUCTOS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IDPRODUCTOS"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDEMPLEADOS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IDEMPLEADOS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IDCATEGORIAS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IDCATEGORIAS"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IDPROVEEDOR"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IDPROVEEDOR"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'FECHAREGISTRODateTimePicker
        '
        Me.FECHAREGISTRODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DETALLE_DE_ALMACENBindingSource, "FECHAREGISTRO", True))
        Me.FECHAREGISTRODateTimePicker.Enabled = False
        Me.FECHAREGISTRODateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FECHAREGISTRODateTimePicker.Location = New System.Drawing.Point(348, 31)
        Me.FECHAREGISTRODateTimePicker.Name = "FECHAREGISTRODateTimePicker"
        Me.FECHAREGISTRODateTimePicker.Size = New System.Drawing.Size(271, 22)
        Me.FECHAREGISTRODateTimePicker.TabIndex = 19
        '
        'IDPRODUCTOSTextBox
        '
        Me.IDPRODUCTOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_DE_ALMACENBindingSource, "IDPRODUCTOS", True))
        Me.IDPRODUCTOSTextBox.Enabled = False
        Me.IDPRODUCTOSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDPRODUCTOSTextBox.Location = New System.Drawing.Point(348, 66)
        Me.IDPRODUCTOSTextBox.Name = "IDPRODUCTOSTextBox"
        Me.IDPRODUCTOSTextBox.Size = New System.Drawing.Size(61, 22)
        Me.IDPRODUCTOSTextBox.TabIndex = 21
        Me.IDPRODUCTOSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDEMPLEADOSTextBox
        '
        Me.IDEMPLEADOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_DE_ALMACENBindingSource, "IDEMPLEADOS", True))
        Me.IDEMPLEADOSTextBox.Enabled = False
        Me.IDEMPLEADOSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDEMPLEADOSTextBox.Location = New System.Drawing.Point(554, 66)
        Me.IDEMPLEADOSTextBox.Name = "IDEMPLEADOSTextBox"
        Me.IDEMPLEADOSTextBox.Size = New System.Drawing.Size(65, 22)
        Me.IDEMPLEADOSTextBox.TabIndex = 23
        Me.IDEMPLEADOSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDCATEGORIASTextBox
        '
        Me.IDCATEGORIASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_DE_ALMACENBindingSource, "IDCATEGORIAS", True))
        Me.IDCATEGORIASTextBox.Enabled = False
        Me.IDCATEGORIASTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDCATEGORIASTextBox.Location = New System.Drawing.Point(554, 94)
        Me.IDCATEGORIASTextBox.Name = "IDCATEGORIASTextBox"
        Me.IDCATEGORIASTextBox.Size = New System.Drawing.Size(65, 22)
        Me.IDCATEGORIASTextBox.TabIndex = 25
        Me.IDCATEGORIASTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDPROVEEDORTextBox
        '
        Me.IDPROVEEDORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_DE_ALMACENBindingSource, "IDPROVEEDOR", True))
        Me.IDPROVEEDORTextBox.Enabled = False
        Me.IDPROVEEDORTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDPROVEEDORTextBox.Location = New System.Drawing.Point(348, 94)
        Me.IDPROVEEDORTextBox.Name = "IDPROVEEDORTextBox"
        Me.IDPROVEEDORTextBox.Size = New System.Drawing.Size(61, 22)
        Me.IDPROVEEDORTextBox.TabIndex = 27
        Me.IDPROVEEDORTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GRUPO1
        '
        Me.GRUPO1.Controls.Add(Me.TextBox1)
        Me.GRUPO1.Controls.Add(Me.ComboBox1)
        Me.GRUPO1.Controls.Add(Me.Label2)
        Me.GRUPO1.Controls.Add(Me.Label1)
        Me.GRUPO1.Enabled = False
        Me.GRUPO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRUPO1.Location = New System.Drawing.Point(641, 26)
        Me.GRUPO1.Name = "GRUPO1"
        Me.GRUPO1.Size = New System.Drawing.Size(200, 100)
        Me.GRUPO1.TabIndex = 28
        Me.GRUPO1.TabStop = False
        Me.GRUPO1.Text = "ELIGE PRODUCTO:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PRODUCTOSBindingSource, "NOMBRE", True))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "NOMBRE", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(51, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 22)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PRODUCTOSBindingSource
        '
        Me.PRODUCTOSBindingSource.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource.DataSource = Me.ALMACEN_FARMACIADataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PRODUCTOSBindingSource
        Me.ComboBox1.DisplayMember = "IDPRODUCTOS"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(51, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(93, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PRO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'GRUPO2
        '
        Me.GRUPO2.Controls.Add(Me.TextBox2)
        Me.GRUPO2.Controls.Add(Me.ComboBox2)
        Me.GRUPO2.Controls.Add(Me.Label3)
        Me.GRUPO2.Controls.Add(Me.Label4)
        Me.GRUPO2.Enabled = False
        Me.GRUPO2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRUPO2.Location = New System.Drawing.Point(894, 26)
        Me.GRUPO2.Name = "GRUPO2"
        Me.GRUPO2.Size = New System.Drawing.Size(200, 100)
        Me.GRUPO2.TabIndex = 29
        Me.GRUPO2.TabStop = False
        Me.GRUPO2.Text = "ELIGE PROVEEDOR:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PROVEEDORBindingSource, "NOMBRE", True))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORBindingSource, "NOMBRE", True))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(51, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 22)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PROVEEDORBindingSource
        '
        Me.PROVEEDORBindingSource.DataMember = "PROVEEDOR"
        Me.PROVEEDORBindingSource.DataSource = Me.ALMACEN_FARMACIADataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.PROVEEDORBindingSource
        Me.ComboBox2.DisplayMember = "IDPROVEEDOR"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(51, 30)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(93, 24)
        Me.ComboBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PRV:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID:"
        '
        'GRUPO3
        '
        Me.GRUPO3.Controls.Add(Me.TextBox3)
        Me.GRUPO3.Controls.Add(Me.ComboBox3)
        Me.GRUPO3.Controls.Add(Me.Label5)
        Me.GRUPO3.Controls.Add(Me.Label6)
        Me.GRUPO3.Enabled = False
        Me.GRUPO3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRUPO3.Location = New System.Drawing.Point(894, 139)
        Me.GRUPO3.Name = "GRUPO3"
        Me.GRUPO3.Size = New System.Drawing.Size(200, 100)
        Me.GRUPO3.TabIndex = 30
        Me.GRUPO3.TabStop = False
        Me.GRUPO3.Text = "ELIGE EMPLEADO:"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.EMPLEADOSBindingSource, "NOMBRE", True))
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "NOMBRE", True))
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(51, 61)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(143, 22)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EMPLEADOSBindingSource
        '
        Me.EMPLEADOSBindingSource.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource.DataSource = Me.ALMACEN_FARMACIADataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.EMPLEADOSBindingSource
        Me.ComboBox3.DisplayMember = "IDEMPLEADOS"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(51, 30)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(93, 24)
        Me.ComboBox3.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "EMP:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ID:"
        '
        'GRUPO4
        '
        Me.GRUPO4.Controls.Add(Me.TextBox4)
        Me.GRUPO4.Controls.Add(Me.ComboBox4)
        Me.GRUPO4.Controls.Add(Me.Label7)
        Me.GRUPO4.Controls.Add(Me.Label8)
        Me.GRUPO4.Enabled = False
        Me.GRUPO4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRUPO4.Location = New System.Drawing.Point(894, 255)
        Me.GRUPO4.Name = "GRUPO4"
        Me.GRUPO4.Size = New System.Drawing.Size(200, 100)
        Me.GRUPO4.TabIndex = 29
        Me.GRUPO4.TabStop = False
        Me.GRUPO4.Text = "ELIGE CATEGORIA:"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CATEGORIASBindingSource, "NOMBRES", True))
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CATEGORIASBindingSource, "NOMBRES", True))
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(51, 61)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(143, 22)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CATEGORIASBindingSource
        '
        Me.CATEGORIASBindingSource.DataMember = "CATEGORIAS"
        Me.CATEGORIASBindingSource.DataSource = Me.ALMACEN_FARMACIADataSet
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.CATEGORIASBindingSource
        Me.ComboBox4.DisplayMember = "IDCATEGORIAS"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(51, 30)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(93, 24)
        Me.ComboBox4.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "CAT:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ID:"
        '
        'PRODUCTOSTableAdapter
        '
        Me.PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'PROVEEDORTableAdapter
        '
        Me.PROVEEDORTableAdapter.ClearBeforeFill = True
        '
        'EMPLEADOSTableAdapter
        '
        Me.EMPLEADOSTableAdapter.ClearBeforeFill = True
        '
        'CATEGORIASTableAdapter
        '
        Me.CATEGORIASTableAdapter.ClearBeforeFill = True
        '
        'DETALLE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PRUEBA.My.Resources.Resources.fondo_detalle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1119, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.GRUPO4)
        Me.Controls.Add(Me.GRUPO3)
        Me.Controls.Add(Me.GRUPO2)
        Me.Controls.Add(Me.GRUPO1)
        Me.Controls.Add(FECHAREGISTROLabel)
        Me.Controls.Add(Me.FECHAREGISTRODateTimePicker)
        Me.Controls.Add(IDPRODUCTOSLabel)
        Me.Controls.Add(Me.IDPRODUCTOSTextBox)
        Me.Controls.Add(IDEMPLEADOSLabel)
        Me.Controls.Add(Me.IDEMPLEADOSTextBox)
        Me.Controls.Add(IDCATEGORIASLabel)
        Me.Controls.Add(Me.IDCATEGORIASTextBox)
        Me.Controls.Add(IDPROVEEDORLabel)
        Me.Controls.Add(Me.IDPROVEEDORTextBox)
        Me.Controls.Add(Me.DETALLE_DE_ALMACENDataGridView)
        Me.Controls.Add(Me.DETALLE_DE_ALMACENBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "DETALLE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ALMACEN_FARMACIADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLE_DE_ALMACENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLE_DE_ALMACENBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DETALLE_DE_ALMACENBindingNavigator.ResumeLayout(False)
        Me.DETALLE_DE_ALMACENBindingNavigator.PerformLayout()
        CType(Me.DETALLE_DE_ALMACENDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRUPO1.ResumeLayout(False)
        Me.GRUPO1.PerformLayout()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRUPO2.ResumeLayout(False)
        Me.GRUPO2.PerformLayout()
        CType(Me.PROVEEDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRUPO3.ResumeLayout(False)
        Me.GRUPO3.PerformLayout()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRUPO4.ResumeLayout(False)
        Me.GRUPO4.PerformLayout()
        CType(Me.CATEGORIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnregresar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btngrabar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents ALMACEN_FARMACIADataSet As ALMACEN_FARMACIADataSet
    Friend WithEvents DETALLE_DE_ALMACENBindingSource As BindingSource
    Friend WithEvents DETALLE_DE_ALMACENTableAdapter As ALMACEN_FARMACIADataSetTableAdapters.DETALLE_DE_ALMACENTableAdapter
    Friend WithEvents TableAdapterManager As ALMACEN_FARMACIADataSetTableAdapters.TableAdapterManager
    Friend WithEvents DETALLE_DE_ALMACENBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DETALLE_DE_ALMACENBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DETALLE_DE_ALMACENDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents FECHAREGISTRODateTimePicker As DateTimePicker
    Friend WithEvents IDPRODUCTOSTextBox As TextBox
    Friend WithEvents IDEMPLEADOSTextBox As TextBox
    Friend WithEvents IDCATEGORIASTextBox As TextBox
    Friend WithEvents IDPROVEEDORTextBox As TextBox
    Friend WithEvents GRUPO1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GRUPO2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GRUPO3 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GRUPO4 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PRODUCTOSBindingSource As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter As ALMACEN_FARMACIADataSetTableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents PROVEEDORBindingSource As BindingSource
    Friend WithEvents PROVEEDORTableAdapter As ALMACEN_FARMACIADataSetTableAdapters.PROVEEDORTableAdapter
    Friend WithEvents EMPLEADOSBindingSource As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter As ALMACEN_FARMACIADataSetTableAdapters.EMPLEADOSTableAdapter
    Friend WithEvents CATEGORIASBindingSource As BindingSource
    Friend WithEvents CATEGORIASTableAdapter As ALMACEN_FARMACIADataSetTableAdapters.CATEGORIASTableAdapter
End Class
