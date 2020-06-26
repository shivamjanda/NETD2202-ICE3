<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAverageUnitsShipped))
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.tbUnits = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.tbDisplay = New System.Windows.Forms.TextBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.tpControls = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnit
        '
        Me.lblUnit.Location = New System.Drawing.Point(66, 28)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(49, 18)
        Me.lblUnit.TabIndex = 0
        Me.lblUnit.Text = "Units:"
        '
        'tbUnits
        '
        Me.tbUnits.Location = New System.Drawing.Point(143, 28)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.Size = New System.Drawing.Size(61, 22)
        Me.tbUnits.TabIndex = 1
        Me.tpControls.SetToolTip(Me.tbUnits, "Enter your values of your units. Make sure that your units are whole numbers and " &
        "between the number 0 and 5000!")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 338)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(103, 32)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "E&nter"
        Me.tpControls.SetToolTip(Me.btnEnter, "You can hit enter by clicking on the enter button, hitting the enter button on yo" &
        "ur keyboard and hitting alt n on your keyboard! In order to enter your units!")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(131, 338)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(108, 32)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.tpControls.SetToolTip(Me.btnReset, "You can reset the program by hitting the reset button with your mouse, tabbing to" &
        " the reset button and hitting enter, pressing alt r on your keyboard or by simpl" &
        "y hitting the esc key!")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(253, 338)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 32)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.tpControls.SetToolTip(Me.btnExit, resources.GetString("btnExit.ToolTip"))
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(60, 275)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(253, 43)
        Me.lblAverage.TabIndex = 4
        Me.lblAverage.Text = "Average per day:"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbDisplay
        '
        Me.tbDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbDisplay.Location = New System.Drawing.Point(60, 70)
        Me.tbDisplay.Multiline = True
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.ReadOnly = True
        Me.tbDisplay.Size = New System.Drawing.Size(253, 179)
        Me.tbDisplay.TabIndex = 3
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(242, 29)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(49, 17)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "Day: 1"
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(370, 388)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.tbDisplay)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbUnits)
        Me.Controls.Add(Me.lblUnit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnit As Label
    Friend WithEvents tbUnits As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAverage As Label
    Friend WithEvents tbDisplay As TextBox
    Friend WithEvents lblDays As Label
    Friend WithEvents tpControls As ToolTip
End Class
