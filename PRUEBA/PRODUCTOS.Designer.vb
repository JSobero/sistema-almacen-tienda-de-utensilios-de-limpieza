<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PRODUCTOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim DESCRIPCIÓNLabel As System.Windows.Forms.Label
        Dim IDCATEGORIASLabel As System.Windows.Forms.Label
        Dim IDPROVEEDORLabel As System.Windows.Forms.Label
        Dim STOCKLabel As System.Windows.Forms.Label
        Dim PRECIOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRODUCTOS))
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
        Me.PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOSTableAdapter = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.PRODUCTOSTableAdapter()
        Me.TableAdapterManager = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.TableAdapterManager()
        Me.PRODUCTOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PRODUCTOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIPCIÓNTextBox = New System.Windows.Forms.TextBox()
        Me.IDCATEGORIASTextBox = New System.Windows.Forms.TextBox()
        Me.IDPROVEEDORTextBox = New System.Windows.Forms.TextBox()
        Me.STOCKTextBox = New System.Windows.Forms.TextBox()
        Me.PRECIOTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCTOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRUPO1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CATEGORIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GRUPO2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PROVEEDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CATEGORIASTableAdapter = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.CATEGORIASTableAdapter()
        Me.PROVEEDORTableAdapter = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.PROVEEDORTableAdapter()
        NOMBRELabel = New System.Windows.Forms.Label()
        DESCRIPCIÓNLabel = New System.Windows.Forms.Label()
        IDCATEGORIASLabel = New System.Windows.Forms.Label()
        IDPROVEEDORLabel = New System.Windows.Forms.Label()
        STOCKLabel = New System.Windows.Forms.Label()
        PRECIOLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ALMACEN_FARMACIADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PRODUCTOSBindingNavigator.SuspendLayout()
        CType(Me.PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRUPO1.SuspendLayout()
        CType(Me.CATEGORIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRUPO2.SuspendLayout()
        CType(Me.PROVEEDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMBRELabel.Location = New System.Drawing.Point(271, 35)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(70, 16)
        NOMBRELabel.TabIndex = 15
        NOMBRELabel.Text = "NOMBRE:"
        '
        'DESCRIPCIÓNLabel
        '
        DESCRIPCIÓNLabel.AutoSize = True
        DESCRIPCIÓNLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DESCRIPCIÓNLabel.Location = New System.Drawing.Point(239, 62)
        DESCRIPCIÓNLabel.Name = "DESCRIPCIÓNLabel"
        DESCRIPCIÓNLabel.Size = New System.Drawing.Size(102, 16)
        DESCRIPCIÓNLabel.TabIndex = 17
        DESCRIPCIÓNLabel.Text = "DESCRIPCIÓN:"
        '
        'IDCATEGORIASLabel
        '
        IDCATEGORIASLabel.AutoSize = True
        IDCATEGORIASLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDCATEGORIASLabel.Location = New System.Drawing.Point(233, 135)
        IDCATEGORIASLabel.Name = "IDCATEGORIASLabel"
        IDCATEGORIASLabel.Size = New System.Drawing.Size(111, 16)
        IDCATEGORIASLabel.TabIndex = 19
        IDCATEGORIASLabel.Text = "IDCATEGORIAS:"
        '
        'IDPROVEEDORLabel
        '
        IDPROVEEDORLabel.AutoSize = True
        IDPROVEEDORLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDPROVEEDORLabel.Location = New System.Drawing.Point(565, 35)
        IDPROVEEDORLabel.Name = "IDPROVEEDORLabel"
        IDPROVEEDORLabel.Size = New System.Drawing.Size(110, 16)
        IDPROVEEDORLabel.TabIndex = 21
        IDPROVEEDORLabel.Text = "IDPROVEEDOR:"
        '
        'STOCKLabel
        '
        STOCKLabel.AutoSize = True
        STOCKLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STOCKLabel.Location = New System.Drawing.Point(619, 63)
        STOCKLabel.Name = "STOCKLabel"
        STOCKLabel.Size = New System.Drawing.Size(56, 16)
        STOCKLabel.TabIndex = 23
        STOCKLabel.Text = "STOCK:"
        '
        'PRECIOLabel
        '
        PRECIOLabel.AutoSize = True
        PRECIOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PRECIOLabel.Location = New System.Drawing.Point(614, 90)
        PRECIOLabel.Name = "PRECIOLabel"
        PRECIOLabel.Size = New System.Drawing.Size(61, 16)
        PRECIOLabel.TabIndex = 25
        PRECIOLabel.Text = "PRECIO:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.Panel1.Size = New System.Drawing.Size(206, 372)
        Me.Panel1.TabIndex = 12
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        'PRODUCTOSBindingSource
        '
        Me.PRODUCTOSBindingSource.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource.DataSource = Me.ALMACEN_FARMACIADataSet
        '
        'PRODUCTOSTableAdapter
        '
        Me.PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORIASTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_DE_ALMACENTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Me.PRODUCTOSTableAdapter
        Me.TableAdapterManager.PROVEEDORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PRODUCTOSBindingNavigator
        '
        Me.PRODUCTOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PRODUCTOSBindingNavigator.BindingSource = Me.PRODUCTOSBindingSource
        Me.PRODUCTOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PRODUCTOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PRODUCTOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PRODUCTOSBindingNavigatorSaveItem})
        Me.PRODUCTOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PRODUCTOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PRODUCTOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PRODUCTOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PRODUCTOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PRODUCTOSBindingNavigator.Name = "PRODUCTOSBindingNavigator"
        Me.PRODUCTOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PRODUCTOSBindingNavigator.Size = New System.Drawing.Size(638, 25)
        Me.PRODUCTOSBindingNavigator.TabIndex = 13
        Me.PRODUCTOSBindingNavigator.Text = "BindingNavigator1"
        Me.PRODUCTOSBindingNavigator.Visible = False
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
        'PRODUCTOSBindingNavigatorSaveItem
        '
        Me.PRODUCTOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PRODUCTOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("PRODUCTOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PRODUCTOSBindingNavigatorSaveItem.Name = "PRODUCTOSBindingNavigatorSaveItem"
        Me.PRODUCTOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PRODUCTOSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Enabled = False
        Me.NOMBRETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(347, 33)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(198, 22)
        Me.NOMBRETextBox.TabIndex = 16
        Me.NOMBRETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DESCRIPCIÓNTextBox
        '
        Me.DESCRIPCIÓNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "DESCRIPCIÓN", True))
        Me.DESCRIPCIÓNTextBox.Enabled = False
        Me.DESCRIPCIÓNTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESCRIPCIÓNTextBox.Location = New System.Drawing.Point(347, 59)
        Me.DESCRIPCIÓNTextBox.Multiline = True
        Me.DESCRIPCIÓNTextBox.Name = "DESCRIPCIÓNTextBox"
        Me.DESCRIPCIÓNTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DESCRIPCIÓNTextBox.Size = New System.Drawing.Size(198, 67)
        Me.DESCRIPCIÓNTextBox.TabIndex = 18
        Me.DESCRIPCIÓNTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDCATEGORIASTextBox
        '
        Me.IDCATEGORIASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "IDCATEGORIAS", True))
        Me.IDCATEGORIASTextBox.Enabled = False
        Me.IDCATEGORIASTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDCATEGORIASTextBox.Location = New System.Drawing.Point(347, 132)
        Me.IDCATEGORIASTextBox.Name = "IDCATEGORIASTextBox"
        Me.IDCATEGORIASTextBox.Size = New System.Drawing.Size(73, 22)
        Me.IDCATEGORIASTextBox.TabIndex = 20
        Me.IDCATEGORIASTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDPROVEEDORTextBox
        '
        Me.IDPROVEEDORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "IDPROVEEDOR", True))
        Me.IDPROVEEDORTextBox.Enabled = False
        Me.IDPROVEEDORTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDPROVEEDORTextBox.Location = New System.Drawing.Point(685, 33)
        Me.IDPROVEEDORTextBox.Name = "IDPROVEEDORTextBox"
        Me.IDPROVEEDORTextBox.Size = New System.Drawing.Size(68, 22)
        Me.IDPROVEEDORTextBox.TabIndex = 22
        Me.IDPROVEEDORTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'STOCKTextBox
        '
        Me.STOCKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "STOCK", True))
        Me.STOCKTextBox.Enabled = False
        Me.STOCKTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STOCKTextBox.Location = New System.Drawing.Point(685, 59)
        Me.STOCKTextBox.Name = "STOCKTextBox"
        Me.STOCKTextBox.Size = New System.Drawing.Size(68, 22)
        Me.STOCKTextBox.TabIndex = 24
        Me.STOCKTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PRECIOTextBox
        '
        Me.PRECIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "PRECIO", True))
        Me.PRECIOTextBox.Enabled = False
        Me.PRECIOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRECIOTextBox.Location = New System.Drawing.Point(685, 87)
        Me.PRECIOTextBox.Name = "PRECIOTextBox"
        Me.PRECIOTextBox.Size = New System.Drawing.Size(68, 22)
        Me.PRECIOTextBox.TabIndex = 26
        Me.PRECIOTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PRODUCTOSDataGridView
        '
        Me.PRODUCTOSDataGridView.AutoGenerateColumns = False
        Me.PRODUCTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCTOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PRODUCTOSDataGridView.DataSource = Me.PRODUCTOSBindingSource
        Me.PRODUCTOSDataGridView.Location = New System.Drawing.Point(347, 189)
        Me.PRODUCTOSDataGridView.Name = "PRODUCTOSDataGridView"
        Me.PRODUCTOSDataGridView.Size = New System.Drawing.Size(743, 152)
        Me.PRODUCTOSDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDPRODUCTOS"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDPRODUCTOS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DESCRIPCIÓN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIPCIÓN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDCATEGORIAS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IDCATEGORIAS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IDPROVEEDOR"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IDPROVEEDOR"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "STOCK"
        Me.DataGridViewTextBoxColumn6.HeaderText = "STOCK"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PRECIO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PRECIO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'GRUPO1
        '
        Me.GRUPO1.Controls.Add(Me.TextBox1)
        Me.GRUPO1.Controls.Add(Me.ComboBox1)
        Me.GRUPO1.Controls.Add(Me.Label2)
        Me.GRUPO1.Controls.Add(Me.Label1)
        Me.GRUPO1.Enabled = False
        Me.GRUPO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRUPO1.Location = New System.Drawing.Point(779, 26)
        Me.GRUPO1.Name = "GRUPO1"
        Me.GRUPO1.Size = New System.Drawing.Size(200, 100)
        Me.GRUPO1.TabIndex = 27
        Me.GRUPO1.TabStop = False
        Me.GRUPO1.Text = "ELIGE CATEGORIA:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CATEGORIASBindingSource, "NOMBRES", True))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CATEGORIASBindingSource, "NOMBRES", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(51, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 22)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CATEGORIASBindingSource
        '
        Me.CATEGORIASBindingSource.DataMember = "CATEGORIAS"
        Me.CATEGORIASBindingSource.DataSource = Me.ALMACEN_FARMACIADataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CATEGORIASBindingSource
        Me.ComboBox1.DisplayMember = "IDCATEGORIAS"
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
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CAT:"
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
        Me.GRUPO2.Location = New System.Drawing.Point(985, 26)
        Me.GRUPO2.Name = "GRUPO2"
        Me.GRUPO2.Size = New System.Drawing.Size(200, 100)
        Me.GRUPO2.TabIndex = 28
        Me.GRUPO2.TabStop = False
        Me.GRUPO2.Text = "ELIGE PROVEEDOR:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PROVEEDORBindingSource, "NOMBRE", True))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORBindingSource, "NOMBRE", True))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(61, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 22)
        Me.TextBox2.TabIndex = 4
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
        Me.ComboBox2.Location = New System.Drawing.Point(61, 30)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(90, 24)
        Me.ComboBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PROV:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID:"
        '
        'CATEGORIASTableAdapter
        '
        Me.CATEGORIASTableAdapter.ClearBeforeFill = True
        '
        'PROVEEDORTableAdapter
        '
        Me.PROVEEDORTableAdapter.ClearBeforeFill = True
        '
        'PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PRUEBA.My.Resources.Resources.fondo_productos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1194, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.GRUPO2)
        Me.Controls.Add(Me.GRUPO1)
        Me.Controls.Add(Me.PRODUCTOSDataGridView)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(DESCRIPCIÓNLabel)
        Me.Controls.Add(Me.DESCRIPCIÓNTextBox)
        Me.Controls.Add(IDCATEGORIASLabel)
        Me.Controls.Add(Me.IDCATEGORIASTextBox)
        Me.Controls.Add(IDPROVEEDORLabel)
        Me.Controls.Add(Me.IDPROVEEDORTextBox)
        Me.Controls.Add(STOCKLabel)
        Me.Controls.Add(Me.STOCKTextBox)
        Me.Controls.Add(PRECIOLabel)
        Me.Controls.Add(Me.PRECIOTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PRODUCTOSBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ALMACEN_FARMACIADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PRODUCTOSBindingNavigator.ResumeLayout(False)
        Me.PRODUCTOSBindingNavigator.PerformLayout()
        CType(Me.PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRUPO1.ResumeLayout(False)
        Me.GRUPO1.PerformLayout()
        CType(Me.CATEGORIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRUPO2.ResumeLayout(False)
        Me.GRUPO2.PerformLayout()
        CType(Me.PROVEEDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PRODUCTOSBindingSource As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter As ALMACEN_FARMACIADataSetTableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents TableAdapterManager As ALMACEN_FARMACIADataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRODUCTOSBindingNavigator As BindingNavigator
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
    Friend WithEvents PRODUCTOSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents DESCRIPCIÓNTextBox As TextBox
    Friend WithEvents IDCATEGORIASTextBox As TextBox
    Friend WithEvents IDPROVEEDORTextBox As TextBox
    Friend WithEvents STOCKTextBox As TextBox
    Friend WithEvents PRECIOTextBox As TextBox
    Friend WithEvents PRODUCTOSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
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
    Friend WithEvents CATEGORIASBindingSource As BindingSource
    Friend WithEvents CATEGORIASTableAdapter As ALMACEN_FARMACIADataSetTableAdapters.CATEGORIASTableAdapter
    Friend WithEvents PROVEEDORBindingSource As BindingSource
    Friend WithEvents PROVEEDORTableAdapter As ALMACEN_FARMACIADataSetTableAdapters.PROVEEDORTableAdapter
End Class
