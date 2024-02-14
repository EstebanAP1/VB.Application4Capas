<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Me.TblButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TblContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblPasswordConfirm = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblUserStatus = New System.Windows.Forms.Label()
        Me.LblUserType = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.CmbUserStatus = New System.Windows.Forms.ComboBox()
        Me.CmbUserType = New System.Windows.Forms.ComboBox()
        Me.DgvUsers = New System.Windows.Forms.DataGridView()
        Me.TblButtons.SuspendLayout()
        Me.TblContainer.SuspendLayout()
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblButtons
        '
        Me.TblButtons.ColumnCount = 5
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.Controls.Add(Me.BtnInsert, 0, 0)
        Me.TblButtons.Controls.Add(Me.BtnDelete, 1, 0)
        Me.TblButtons.Controls.Add(Me.BtnUpdate, 2, 0)
        Me.TblButtons.Controls.Add(Me.BtnSearch, 3, 0)
        Me.TblButtons.Controls.Add(Me.BtnClose, 4, 0)
        Me.TblButtons.Location = New System.Drawing.Point(21, 279)
        Me.TblButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.TblButtons.Name = "TblButtons"
        Me.TblButtons.RowCount = 1
        Me.TblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblButtons.Size = New System.Drawing.Size(528, 35)
        Me.TblButtons.TabIndex = 3
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(4, 4)
        Me.BtnInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(97, 27)
        Me.BtnInsert.TabIndex = 0
        Me.BtnInsert.Text = "&Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(109, 4)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(97, 27)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(214, 4)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(97, 27)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(319, 4)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(97, 27)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "&Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(424, 4)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 27)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TblContainer
        '
        Me.TblContainer.ColumnCount = 2
        Me.TblContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblContainer.Controls.Add(Me.LblUsername, 0, 0)
        Me.TblContainer.Controls.Add(Me.LblPassword, 0, 1)
        Me.TblContainer.Controls.Add(Me.LblPasswordConfirm, 0, 2)
        Me.TblContainer.Controls.Add(Me.LblName, 0, 3)
        Me.TblContainer.Controls.Add(Me.LblUserStatus, 0, 4)
        Me.TblContainer.Controls.Add(Me.LblUserType, 0, 5)
        Me.TblContainer.Controls.Add(Me.TxtUsername, 1, 0)
        Me.TblContainer.Controls.Add(Me.TxtPassword, 1, 1)
        Me.TblContainer.Controls.Add(Me.TxtPasswordConfirm, 1, 2)
        Me.TblContainer.Controls.Add(Me.TxtName, 1, 3)
        Me.TblContainer.Controls.Add(Me.CmbUserStatus, 1, 4)
        Me.TblContainer.Controls.Add(Me.CmbUserType, 1, 5)
        Me.TblContainer.Location = New System.Drawing.Point(21, 12)
        Me.TblContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.TblContainer.Name = "TblContainer"
        Me.TblContainer.RowCount = 6
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.Size = New System.Drawing.Size(528, 222)
        Me.TblContainer.TabIndex = 2
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(4, 0)
        Me.LblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(70, 16)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Username"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(4, 37)
        Me.LblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(67, 16)
        Me.LblPassword.TabIndex = 1
        Me.LblPassword.Text = "Password"
        '
        'LblPasswordConfirm
        '
        Me.LblPasswordConfirm.AutoSize = True
        Me.LblPasswordConfirm.Location = New System.Drawing.Point(4, 74)
        Me.LblPasswordConfirm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPasswordConfirm.Name = "LblPasswordConfirm"
        Me.LblPasswordConfirm.Size = New System.Drawing.Size(115, 16)
        Me.LblPasswordConfirm.TabIndex = 2
        Me.LblPasswordConfirm.Text = "Confirm Password"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(4, 111)
        Me.LblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(44, 16)
        Me.LblName.TabIndex = 3
        Me.LblName.Text = "Name"
        '
        'LblUserStatus
        '
        Me.LblUserStatus.AutoSize = True
        Me.LblUserStatus.Location = New System.Drawing.Point(4, 148)
        Me.LblUserStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUserStatus.Name = "LblUserStatus"
        Me.LblUserStatus.Size = New System.Drawing.Size(76, 16)
        Me.LblUserStatus.TabIndex = 4
        Me.LblUserStatus.Text = "User Status"
        '
        'LblUserType
        '
        Me.LblUserType.AutoSize = True
        Me.LblUserType.Location = New System.Drawing.Point(4, 185)
        Me.LblUserType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUserType.Name = "LblUserType"
        Me.LblUserType.Size = New System.Drawing.Size(71, 16)
        Me.LblUserType.TabIndex = 5
        Me.LblUserType.Text = "User Type"
        '
        'TxtUsername
        '
        Me.TxtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtUsername.Location = New System.Drawing.Point(268, 4)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsername.MaxLength = 30
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(160, 22)
        Me.TxtUsername.TabIndex = 7
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(268, 41)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.MaxLength = 30
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(160, 22)
        Me.TxtPassword.TabIndex = 8
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtPasswordConfirm
        '
        Me.TxtPasswordConfirm.Location = New System.Drawing.Point(268, 78)
        Me.TxtPasswordConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPasswordConfirm.MaxLength = 30
        Me.TxtPasswordConfirm.Name = "TxtPasswordConfirm"
        Me.TxtPasswordConfirm.Size = New System.Drawing.Size(160, 22)
        Me.TxtPasswordConfirm.TabIndex = 9
        Me.TxtPasswordConfirm.UseSystemPasswordChar = True
        '
        'TxtName
        '
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.Location = New System.Drawing.Point(268, 115)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtName.MaxLength = 100
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(160, 22)
        Me.TxtName.TabIndex = 10
        '
        'CmbUserStatus
        '
        Me.CmbUserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUserStatus.FormattingEnabled = True
        Me.CmbUserStatus.Location = New System.Drawing.Point(268, 152)
        Me.CmbUserStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbUserStatus.Name = "CmbUserStatus"
        Me.CmbUserStatus.Size = New System.Drawing.Size(160, 24)
        Me.CmbUserStatus.TabIndex = 11
        '
        'CmbUserType
        '
        Me.CmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUserType.FormattingEnabled = True
        Me.CmbUserType.Location = New System.Drawing.Point(268, 189)
        Me.CmbUserType.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbUserType.Name = "CmbUserType"
        Me.CmbUserType.Size = New System.Drawing.Size(160, 24)
        Me.CmbUserType.TabIndex = 12
        '
        'DgvUsers
        '
        Me.DgvUsers.AllowUserToAddRows = False
        Me.DgvUsers.AllowUserToDeleteRows = False
        Me.DgvUsers.AllowUserToResizeColumns = False
        Me.DgvUsers.AllowUserToResizeRows = False
        Me.DgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsers.Location = New System.Drawing.Point(593, 12)
        Me.DgvUsers.MultiSelect = False
        Me.DgvUsers.Name = "DgvUsers"
        Me.DgvUsers.ReadOnly = True
        Me.DgvUsers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvUsers.RowHeadersWidth = 51
        Me.DgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvUsers.RowTemplate.Height = 24
        Me.DgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsers.Size = New System.Drawing.Size(746, 362)
        Me.DgvUsers.TabIndex = 4
        '
        'FormUser
        '
        Me.AcceptButton = Me.BtnInsert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1351, 386)
        Me.Controls.Add(Me.DgvUsers)
        Me.Controls.Add(Me.TblButtons)
        Me.Controls.Add(Me.TblContainer)
        Me.Name = "FormUser"
        Me.Text = "FormUser"
        Me.TblButtons.ResumeLayout(False)
        Me.TblContainer.ResumeLayout(False)
        Me.TblContainer.PerformLayout()
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TblButtons As TableLayoutPanel
    Friend WithEvents BtnInsert As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents TblContainer As TableLayoutPanel
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblPasswordConfirm As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblUserStatus As Label
    Friend WithEvents LblUserType As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtPasswordConfirm As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents CmbUserStatus As ComboBox
    Friend WithEvents CmbUserType As ComboBox
    Friend WithEvents DgvUsers As DataGridView
End Class
