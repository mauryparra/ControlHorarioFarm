<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectEmpleado
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewEmpleados = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewEmpleados
        '
        Me.DataGridViewEmpleados.AllowUserToAddRows = False
        Me.DataGridViewEmpleados.AllowUserToDeleteRows = False
        Me.DataGridViewEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Apellido})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewEmpleados.MultiSelect = False
        Me.DataGridViewEmpleados.Name = "DataGridViewEmpleados"
        Me.DataGridViewEmpleados.ReadOnly = True
        Me.DataGridViewEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewEmpleados.Size = New System.Drawing.Size(380, 140)
        Me.DataGridViewEmpleados.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 50
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 120
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 120
        '
        'SelectEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridViewEmpleados)
        Me.Name = "SelectEmpleado"
        Me.Size = New System.Drawing.Size(380, 140)
        CType(Me.DataGridViewEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
