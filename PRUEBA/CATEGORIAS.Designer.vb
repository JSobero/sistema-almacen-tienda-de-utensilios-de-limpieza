<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CATEGORIAS
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
        Dim NOMBRESLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CATEGORIAS))
        Me.CATEGORIASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CATEGORIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALMACEN_FARMACIADataSet = New PRUEBA.ALMACEN_FARMACIADataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CATEGORIASDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRESTextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIPCIONTextBox = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btngrabar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.CATEGORIASTableAdapter = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.CATEGORIASTableAdapter()
        Me.TableAdapterManager = New PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.CATEGORIASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        NOMBRESLabel = New System.Windows.Forms.Label()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        CType(Me.CATEGORIASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CATEGORIASBindingNavigator.SuspendLayout()
        CType(Me.CATEGORIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALMACEN_FARMACIADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORIASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NOMBRESLabel
        '
        NOMBRESLabel.AutoSize = True
        NOMBRESLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMBRESLabel.Location = New System.Drawing.Point(276, 41)
        NOMBRESLabel.Name = "NOMBRESLabel"
        NOMBRESLabel.Size = New System.Drawing.Size(79, 16)
        NOMBRESLabel.TabIndex = 4
        NOMBRESLabel.Text = "NOMBRES:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DESCRIPCIONLabel.Location = New System.Drawing.Point(253, 81)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(102, 16)
        DESCRIPCIONLabel.TabIndex = 6
        DESCRIPCIONLabel.Text = "DESCRIPCION:"
        '
        'CATEGORIASBindingNavigator
        '
        Me.CATEGORIASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CATEGORIASBindingNavigator.BindingSource = Me.CATEGORIASBindingSource
        Me.CATEGORIASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CATEGORIASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CATEGORIASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CATEGORIASBindingNavigatorSaveItem})
        Me.CATEGORIASBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CATEGORIASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CATEGORIASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CATEGORIASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CATEGORIASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CATEGORIASBindingNavigator.Name = "CATEGORIASBindingNavigator"
        Me.CATEGORIASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CATEGORIASBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CATEGORIASBindingNavigator.TabIndex = 0
        Me.CATEGORIASBindingNavigator.Text = "BindingNavigator1"
        Me.CATEGORIASBindingNavigator.Visible = False
        '
        'CATEGORIASBindingSource
        '
        Me.CATEGORIASBindingSource.DataMember = "CATEGORIAS"
        Me.CATEGORIASBindingSource.DataSource = Me.ALMACEN_FARMACIADataSet
        '
        'ALMACEN_FARMACIADataSet
        '
        Me.ALMACEN_FARMACIADataSet.DataSetName = "ALMACEN_FARMACIADataSet"
        Me.ALMACEN_FARMACIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CATEGORIASDataGridView
        '
        Me.CATEGORIASDataGridView.AutoGenerateColumns = False
        Me.CATEGORIASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CATEGORIASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CATEGORIASDataGridView.DataSource = Me.CATEGORIASBindingSource
        Me.CATEGORIASDataGridView.Location = New System.Drawing.Point(245, 151)
        Me.CATEGORIASDataGridView.Name = "CATEGORIASDataGridView"
        Me.CATEGORIASDataGridView.Size = New System.Drawing.Size(342, 196)
        Me.CATEGORIASDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDCATEGORIAS"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDCATEGORIAS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRES"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRES"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'NOMBRESTextBox
        '
        Me.NOMBRESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CATEGORIASBindingSource, "NOMBRES", True))
        Me.NOMBRESTextBox.Enabled = False
        Me.NOMBRESTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRESTextBox.Location = New System.Drawing.Point(361, 38)
        Me.NOMBRESTextBox.Name = "NOMBRESTextBox"
        Me.NOMBRESTextBox.Size = New System.Drawing.Size(202, 22)
        Me.NOMBRESTextBox.TabIndex = 5
        Me.NOMBRESTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DESCRIPCIONTextBox
        '
        Me.DESCRIPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CATEGORIASBindingSource, "DESCRIPCION", True))
        Me.DESCRIPCIONTextBox.Enabled = False
        Me.DESCRIPCIONTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESCRIPCIONTextBox.Location = New System.Drawing.Point(361, 78)
        Me.DESCRIPCIONTextBox.Multiline = True
        Me.DESCRIPCIONTextBox.Name = "DESCRIPCIONTextBox"
        Me.DESCRIPCIONTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DESCRIPCIONTextBox.Size = New System.Drawing.Size(202, 45)
        Me.DESCRIPCIONTextBox.TabIndex = 7
        Me.DESCRIPCIONTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
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
        Me.Panel1.TabIndex = 11
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
        'CATEGORIASTableAdapter
        '
        Me.CATEGORIASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORIASTableAdapter = Me.CATEGORIASTableAdapter
        Me.TableAdapterManager.DETALLE_DE_ALMACENTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.PROVEEDORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRUEBA.ALMACEN_FARMACIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'CATEGORIASBindingNavigatorSaveItem
        '
        Me.CATEGORIASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CATEGORIASBindingNavigatorSaveItem.Image = CType(resources.GetObject("CATEGORIASBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CATEGORIASBindingNavigatorSaveItem.Name = "CATEGORIASBindingNavigatorSaveItem"
        Me.CATEGORIASBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CATEGORIASBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CATEGORIAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PRUEBA.My.Resources.Resources.fondo_categoria
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(NOMBRESLabel)
        Me.Controls.Add(Me.NOMBRESTextBox)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.DESCRIPCIONTextBox)
        Me.Controls.Add(Me.CATEGORIASDataGridView)
        Me.Controls.Add(Me.CATEGORIASBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CATEGORIAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CATEGORIAS"
        CType(Me.CATEGORIASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CATEGORIASBindingNavigator.ResumeLayout(False)
        Me.CATEGORIASBindingNavigator.PerformLayout()
        CType(Me.CATEGORIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALMACEN_FARMACIADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORIASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ALMACEN_FARMACIADataSet As ALMACEN_FARMACIADataSet
    Friend WithEvents CATEGORIASBindingSource As BindingSource
    Friend WithEvents CATEGORIASTableAdapter As ALMACEN_FARMACIADataSetTableAdapters.CATEGORIASTableAdapter
    Friend WithEvents TableAdapterManager As ALMACEN_FARMACIADataSetTableAdapters.TableAdapterManager
    Friend WithEvents CATEGORIASBindingNavigator As BindingNavigator
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
    Friend WithEvents CATEGORIASBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CATEGORIASDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRESTextBox As TextBox
    Friend WithEvents DESCRIPCIONTextBox As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btngrabar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnregresar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btncancelar As Button
End Class
