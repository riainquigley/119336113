<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewOrders
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
        Me.LblDetails = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAddress1 = New System.Windows.Forms.Label()
        Me.LblTown = New System.Windows.Forms.Label()
        Me.LblCounty = New System.Windows.Forms.Label()
        Me.LblNumber = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtTown = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.GrpSelect = New System.Windows.Forms.GroupBox()
        Me.LblOrders = New System.Windows.Forms.Label()
        Me.CboShoes = New System.Windows.Forms.ComboBox()
        Me.TxtName = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCounty = New System.Windows.Forms.MaskedTextBox()
        Me.TxtNumber = New System.Windows.Forms.MaskedTextBox()
        Me.GrpSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblDetails
        '
        Me.LblDetails.AutoSize = True
        Me.LblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDetails.Location = New System.Drawing.Point(29, 9)
        Me.LblDetails.Name = "LblDetails"
        Me.LblDetails.Size = New System.Drawing.Size(226, 29)
        Me.LblDetails.TabIndex = 0
        Me.LblDetails.Text = "Customers Details"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(31, 59)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(82, 13)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Customer Name"
        '
        'LblAddress1
        '
        Me.LblAddress1.AutoSize = True
        Me.LblAddress1.Location = New System.Drawing.Point(31, 110)
        Me.LblAddress1.Name = "LblAddress1"
        Me.LblAddress1.Size = New System.Drawing.Size(77, 13)
        Me.LblAddress1.TabIndex = 2
        Me.LblAddress1.Text = "Address Line 1"
        '
        'LblTown
        '
        Me.LblTown.AutoSize = True
        Me.LblTown.Location = New System.Drawing.Point(31, 168)
        Me.LblTown.Name = "LblTown"
        Me.LblTown.Size = New System.Drawing.Size(66, 13)
        Me.LblTown.TabIndex = 3
        Me.LblTown.Text = "Town or City"
        '
        'LblCounty
        '
        Me.LblCounty.AutoSize = True
        Me.LblCounty.Location = New System.Drawing.Point(31, 230)
        Me.LblCounty.Name = "LblCounty"
        Me.LblCounty.Size = New System.Drawing.Size(40, 13)
        Me.LblCounty.TabIndex = 4
        Me.LblCounty.Text = "County"
        '
        'LblNumber
        '
        Me.LblNumber.AutoSize = True
        Me.LblNumber.Location = New System.Drawing.Point(31, 292)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(78, 13)
        Me.LblNumber.TabIndex = 5
        Me.LblNumber.Text = "Phone Number"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(31, 366)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(73, 13)
        Me.LblAddress.TabIndex = 6
        Me.LblAddress.Text = "Email Address"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(141, 110)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(100, 20)
        Me.TxtAddress.TabIndex = 8
        '
        'TxtTown
        '
        Me.TxtTown.Location = New System.Drawing.Point(141, 168)
        Me.TxtTown.Name = "TxtTown"
        Me.TxtTown.Size = New System.Drawing.Size(100, 20)
        Me.TxtTown.TabIndex = 9
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(141, 358)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(100, 20)
        Me.TxtEmail.TabIndex = 12
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(70, 399)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 13
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'GrpSelect
        '
        Me.GrpSelect.Controls.Add(Me.CboShoes)
        Me.GrpSelect.Location = New System.Drawing.Point(324, 59)
        Me.GrpSelect.Name = "GrpSelect"
        Me.GrpSelect.Size = New System.Drawing.Size(200, 71)
        Me.GrpSelect.TabIndex = 14
        Me.GrpSelect.TabStop = False
        Me.GrpSelect.Text = "Select Shoe"
        Me.GrpSelect.Visible = False
        '
        'LblOrders
        '
        Me.LblOrders.AutoSize = True
        Me.LblOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrders.Location = New System.Drawing.Point(359, 13)
        Me.LblOrders.Name = "LblOrders"
        Me.LblOrders.Size = New System.Drawing.Size(135, 25)
        Me.LblOrders.TabIndex = 15
        Me.LblOrders.Text = "New Orders"
        Me.LblOrders.Visible = False
        '
        'CboShoes
        '
        Me.CboShoes.FormattingEnabled = True
        Me.CboShoes.Location = New System.Drawing.Point(29, 20)
        Me.CboShoes.Name = "CboShoes"
        Me.CboShoes.Size = New System.Drawing.Size(121, 21)
        Me.CboShoes.TabIndex = 0
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(141, 59)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 20)
        Me.TxtName.TabIndex = 16
        '
        'TxtCounty
        '
        Me.TxtCounty.Location = New System.Drawing.Point(141, 230)
        Me.TxtCounty.Name = "TxtCounty"
        Me.TxtCounty.Size = New System.Drawing.Size(100, 20)
        Me.TxtCounty.TabIndex = 17
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(141, 292)
        Me.TxtNumber.Mask = "(999) 000-0000"
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumber.TabIndex = 18
        '
        'FrmNewOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.TxtCounty)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblOrders)
        Me.Controls.Add(Me.GrpSelect)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtTown)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.LblNumber)
        Me.Controls.Add(Me.LblCounty)
        Me.Controls.Add(Me.LblTown)
        Me.Controls.Add(Me.LblAddress1)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblDetails)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FrmNewOrders"
        Me.Text = "New Orders"
        Me.GrpSelect.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDetails As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblAddress1 As Label
    Friend WithEvents LblTown As Label
    Friend WithEvents LblCounty As Label
    Friend WithEvents LblNumber As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtTown As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnNext As Button
    Friend WithEvents GrpSelect As GroupBox
    Friend WithEvents LblOrders As Label
    Friend WithEvents CboShoes As ComboBox
    Friend WithEvents TxtName As MaskedTextBox
    Friend WithEvents TxtCounty As MaskedTextBox
    Friend WithEvents TxtNumber As MaskedTextBox
End Class
