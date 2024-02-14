<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblActualPassword = New System.Windows.Forms.Label()
        Me.LblNewPassword = New System.Windows.Forms.Label()
        Me.LblNewPasswordConfirm = New System.Windows.Forms.Label()
        Me.TxtActualPassword = New System.Windows.Forms.TextBox()
        Me.TxtNewPassword = New System.Windows.Forms.TextBox()
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCancel, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtConfirmPassword, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNewPassword, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblActualPassword, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblNewPassword, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblNewPasswordConfirm, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtActualPassword, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnConfirm, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(65, 47)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(396, 309)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LblActualPassword
        '
        Me.LblActualPassword.AutoSize = True
        Me.LblActualPassword.Location = New System.Drawing.Point(3, 0)
        Me.LblActualPassword.Name = "LblActualPassword"
        Me.LblActualPassword.Size = New System.Drawing.Size(98, 16)
        Me.LblActualPassword.TabIndex = 0
        Me.LblActualPassword.Text = "Your Password"
        '
        'LblNewPassword
        '
        Me.LblNewPassword.AutoSize = True
        Me.LblNewPassword.Location = New System.Drawing.Point(3, 77)
        Me.LblNewPassword.Name = "LblNewPassword"
        Me.LblNewPassword.Size = New System.Drawing.Size(97, 16)
        Me.LblNewPassword.TabIndex = 1
        Me.LblNewPassword.Text = "New Password"
        '
        'LblNewPasswordConfirm
        '
        Me.LblNewPasswordConfirm.AutoSize = True
        Me.LblNewPasswordConfirm.Location = New System.Drawing.Point(3, 154)
        Me.LblNewPasswordConfirm.Name = "LblNewPasswordConfirm"
        Me.LblNewPasswordConfirm.Size = New System.Drawing.Size(145, 16)
        Me.LblNewPasswordConfirm.TabIndex = 2
        Me.LblNewPasswordConfirm.Text = "Confirm New Password"
        '
        'TxtActualPassword
        '
        Me.TxtActualPassword.Location = New System.Drawing.Point(201, 3)
        Me.TxtActualPassword.Name = "TxtActualPassword"
        Me.TxtActualPassword.Size = New System.Drawing.Size(143, 22)
        Me.TxtActualPassword.TabIndex = 3
        Me.TxtActualPassword.UseSystemPasswordChar = True
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.Location = New System.Drawing.Point(201, 80)
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.Size = New System.Drawing.Size(143, 22)
        Me.TxtNewPassword.TabIndex = 4
        Me.TxtNewPassword.UseSystemPasswordChar = True
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(201, 157)
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(143, 22)
        Me.TxtConfirmPassword.TabIndex = 5
        Me.TxtConfirmPassword.UseSystemPasswordChar = True
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Location = New System.Drawing.Point(3, 234)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.BtnConfirm.TabIndex = 6
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(201, 234)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormChangePass
        '
        Me.AcceptButton = Me.BtnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(568, 437)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormChangePass"
        Me.Text = "FormChangePass"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblActualPassword As Label
    Friend WithEvents LblNewPassword As Label
    Friend WithEvents LblNewPasswordConfirm As Label
    Friend WithEvents TxtConfirmPassword As TextBox
    Friend WithEvents TxtNewPassword As TextBox
    Friend WithEvents TxtActualPassword As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnConfirm As Button
End Class
