<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opciones))
        Me.LabelSuc = New System.Windows.Forms.Label()
        Me.ComboBoxSuc = New System.Windows.Forms.ComboBox()
        Me.LabelActualPass = New System.Windows.Forms.Label()
        Me.LabelNewPass = New System.Windows.Forms.Label()
        Me.LabelNewPass2 = New System.Windows.Forms.Label()
        Me.TextBoxActualPass = New System.Windows.Forms.TextBox()
        Me.TextBoxNewPass = New System.Windows.Forms.TextBox()
        Me.TextBoxNewPass2 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.TextBoxVersion = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelSuc
        '
        Me.LabelSuc.AutoSize = True
        Me.LabelSuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSuc.Location = New System.Drawing.Point(76, 69)
        Me.LabelSuc.Name = "LabelSuc"
        Me.LabelSuc.Size = New System.Drawing.Size(75, 20)
        Me.LabelSuc.TabIndex = 2
        Me.LabelSuc.Text = "Sucursal:"
        '
        'ComboBoxSuc
        '
        Me.ComboBoxSuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSuc.FormattingEnabled = True
        Me.ComboBoxSuc.Location = New System.Drawing.Point(157, 66)
        Me.ComboBoxSuc.Name = "ComboBoxSuc"
        Me.ComboBoxSuc.Size = New System.Drawing.Size(149, 28)
        Me.ComboBoxSuc.TabIndex = 3
        '
        'LabelActualPass
        '
        Me.LabelActualPass.AutoSize = True
        Me.LabelActualPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelActualPass.Location = New System.Drawing.Point(12, 103)
        Me.LabelActualPass.Name = "LabelActualPass"
        Me.LabelActualPass.Size = New System.Drawing.Size(145, 20)
        Me.LabelActualPass.TabIndex = 4
        Me.LabelActualPass.Text = "Contraseña Actual:"
        '
        'LabelNewPass
        '
        Me.LabelNewPass.AutoSize = True
        Me.LabelNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNewPass.Location = New System.Drawing.Point(12, 135)
        Me.LabelNewPass.Name = "LabelNewPass"
        Me.LabelNewPass.Size = New System.Drawing.Size(145, 20)
        Me.LabelNewPass.TabIndex = 5
        Me.LabelNewPass.Text = "Contraseña Nueva:"
        '
        'LabelNewPass2
        '
        Me.LabelNewPass2.AutoSize = True
        Me.LabelNewPass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNewPass2.Location = New System.Drawing.Point(12, 167)
        Me.LabelNewPass2.Name = "LabelNewPass2"
        Me.LabelNewPass2.Size = New System.Drawing.Size(145, 20)
        Me.LabelNewPass2.TabIndex = 6
        Me.LabelNewPass2.Text = "Contraseña Nueva:"
        '
        'TextBoxActualPass
        '
        Me.TextBoxActualPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxActualPass.Location = New System.Drawing.Point(157, 100)
        Me.TextBoxActualPass.Name = "TextBoxActualPass"
        Me.TextBoxActualPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxActualPass.Size = New System.Drawing.Size(149, 26)
        Me.TextBoxActualPass.TabIndex = 7
        '
        'TextBoxNewPass
        '
        Me.TextBoxNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNewPass.Location = New System.Drawing.Point(157, 132)
        Me.TextBoxNewPass.Name = "TextBoxNewPass"
        Me.TextBoxNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNewPass.Size = New System.Drawing.Size(149, 26)
        Me.TextBoxNewPass.TabIndex = 8
        '
        'TextBoxNewPass2
        '
        Me.TextBoxNewPass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNewPass2.Location = New System.Drawing.Point(157, 164)
        Me.TextBoxNewPass2.Name = "TextBoxNewPass2"
        Me.TextBoxNewPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNewPass2.Size = New System.Drawing.Size(149, 26)
        Me.TextBoxNewPass2.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(157, 211)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(162, 39)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(84, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 31)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(75, 31)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.Location = New System.Drawing.Point(76, 15)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(67, 20)
        Me.LabelVersion.TabIndex = 11
        Me.LabelVersion.Text = "Versión:"
        '
        'TextBoxVersion
        '
        Me.TextBoxVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVersion.Location = New System.Drawing.Point(157, 12)
        Me.TextBoxVersion.Name = "TextBoxVersion"
        Me.TextBoxVersion.ReadOnly = True
        Me.TextBoxVersion.Size = New System.Drawing.Size(149, 26)
        Me.TextBoxVersion.TabIndex = 12
        '
        'Opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 262)
        Me.Controls.Add(Me.TextBoxVersion)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TextBoxNewPass2)
        Me.Controls.Add(Me.TextBoxNewPass)
        Me.Controls.Add(Me.TextBoxActualPass)
        Me.Controls.Add(Me.LabelNewPass2)
        Me.Controls.Add(Me.LabelNewPass)
        Me.Controls.Add(Me.LabelActualPass)
        Me.Controls.Add(Me.ComboBoxSuc)
        Me.Controls.Add(Me.LabelSuc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Opciones"
        Me.Text = "Opciones"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelSuc As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSuc As System.Windows.Forms.ComboBox
    Friend WithEvents LabelActualPass As System.Windows.Forms.Label
    Friend WithEvents LabelNewPass As System.Windows.Forms.Label
    Friend WithEvents LabelNewPass2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxActualPass As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewPass As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewPass2 As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents TextBoxVersion As System.Windows.Forms.TextBox
End Class
