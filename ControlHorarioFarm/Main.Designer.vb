﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.ComboBoxTurnos = New System.Windows.Forms.ComboBox()
        Me.DataGridViewReg = New System.Windows.Forms.DataGridView()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelTurno = New System.Windows.Forms.Label()
        Me.ButtonMarcar = New System.Windows.Forms.Button()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.ButtonConfig = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.DataGridViewReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.IsSplitterFixed = True
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonConfig)
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonCerrar)
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonMarcar)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelTurno)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelNombre)
        Me.SplitContainer.Panel1.Controls.Add(Me.TextBoxNombre)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelHora)
        Me.SplitContainer.Panel1.Controls.Add(Me.ComboBoxTurnos)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.DataGridViewReg)
        Me.SplitContainer.Size = New System.Drawing.Size(494, 277)
        Me.SplitContainer.SplitterDistance = 120
        Me.SplitContainer.TabIndex = 0
        '
        'ComboBoxTurnos
        '
        Me.ComboBoxTurnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTurnos.FormattingEnabled = True
        Me.ComboBoxTurnos.Location = New System.Drawing.Point(12, 79)
        Me.ComboBoxTurnos.Name = "ComboBoxTurnos"
        Me.ComboBoxTurnos.Size = New System.Drawing.Size(158, 28)
        Me.ComboBoxTurnos.TabIndex = 1
        '
        'DataGridViewReg
        '
        Me.DataGridViewReg.AllowUserToAddRows = False
        Me.DataGridViewReg.AllowUserToDeleteRows = False
        Me.DataGridViewReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewReg.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewReg.Name = "DataGridViewReg"
        Me.DataGridViewReg.ReadOnly = True
        Me.DataGridViewReg.Size = New System.Drawing.Size(494, 153)
        Me.DataGridViewReg.TabIndex = 0
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.Location = New System.Drawing.Point(172, 22)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(151, 37)
        Me.LabelHora.TabIndex = 10
        Me.LabelHora.Text = "00:00:00"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(12, 32)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(158, 26)
        Me.TextBoxNombre.TabIndex = 0
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(12, 11)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(54, 13)
        Me.LabelNombre.TabIndex = 3
        Me.LabelNombre.Text = "Nombre:"
        '
        'LabelTurno
        '
        Me.LabelTurno.AutoSize = True
        Me.LabelTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTurno.Location = New System.Drawing.Point(12, 63)
        Me.LabelTurno.Name = "LabelTurno"
        Me.LabelTurno.Size = New System.Drawing.Size(44, 13)
        Me.LabelTurno.TabIndex = 4
        Me.LabelTurno.Text = "Turno:"
        '
        'ButtonMarcar
        '
        Me.ButtonMarcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMarcar.Location = New System.Drawing.Point(329, 13)
        Me.ButtonMarcar.Name = "ButtonMarcar"
        Me.ButtonMarcar.Size = New System.Drawing.Size(153, 44)
        Me.ButtonMarcar.TabIndex = 2
        Me.ButtonMarcar.Text = "&Marcar"
        Me.ButtonMarcar.UseVisualStyleBackColor = True
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCerrar.Location = New System.Drawing.Point(329, 69)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(153, 44)
        Me.ButtonCerrar.TabIndex = 3
        Me.ButtonCerrar.Text = "&Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'ButtonConfig
        '
        Me.ButtonConfig.Location = New System.Drawing.Point(228, 69)
        Me.ButtonConfig.Name = "ButtonConfig"
        Me.ButtonConfig.Size = New System.Drawing.Size(38, 44)
        Me.ButtonConfig.TabIndex = 4
        Me.ButtonConfig.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 277)
        Me.Controls.Add(Me.SplitContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Control Horarios Farmacias"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel1.PerformLayout()
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.DataGridViewReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ComboBoxTurnos As System.Windows.Forms.ComboBox
    Friend WithEvents LabelTurno As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents LabelHora As System.Windows.Forms.Label
    Friend WithEvents DataGridViewReg As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonConfig As System.Windows.Forms.Button
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
    Friend WithEvents ButtonMarcar As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
