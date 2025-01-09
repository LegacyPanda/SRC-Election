<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSRC_Election
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSRC_Election))
        Me.btnCampus = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalcTotal = New System.Windows.Forms.Button()
        Me.btnCalcAverage = New System.Windows.Forms.Button()
        Me.btnCalcLowest = New System.Windows.Forms.Button()
        Me.btnCalcHighest = New System.Windows.Forms.Button()
        Me.txtLowest = New System.Windows.Forms.TextBox()
        Me.txtHighest = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCampus
        '
        Me.btnCampus.Location = New System.Drawing.Point(12, 12)
        Me.btnCampus.Name = "btnCampus"
        Me.btnCampus.Size = New System.Drawing.Size(213, 56)
        Me.btnCampus.TabIndex = 0
        Me.btnCampus.Text = "Which UJ Campus"
        Me.btnCampus.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(236, 95)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(163, 22)
        Me.txtTotal.TabIndex = 2
        '
        'btnCalcTotal
        '
        Me.btnCalcTotal.Location = New System.Drawing.Point(12, 78)
        Me.btnCalcTotal.Name = "btnCalcTotal"
        Me.btnCalcTotal.Size = New System.Drawing.Size(218, 56)
        Me.btnCalcTotal.TabIndex = 3
        Me.btnCalcTotal.Text = "Calculate Total Votes"
        Me.btnCalcTotal.UseVisualStyleBackColor = True
        '
        'btnCalcAverage
        '
        Me.btnCalcAverage.Location = New System.Drawing.Point(12, 140)
        Me.btnCalcAverage.Name = "btnCalcAverage"
        Me.btnCalcAverage.Size = New System.Drawing.Size(218, 56)
        Me.btnCalcAverage.TabIndex = 4
        Me.btnCalcAverage.Text = "Calculate Average Votes"
        Me.btnCalcAverage.UseVisualStyleBackColor = True
        '
        'btnCalcLowest
        '
        Me.btnCalcLowest.Location = New System.Drawing.Point(12, 264)
        Me.btnCalcLowest.Name = "btnCalcLowest"
        Me.btnCalcLowest.Size = New System.Drawing.Size(218, 56)
        Me.btnCalcLowest.TabIndex = 5
        Me.btnCalcLowest.Text = "Lowest Votes"
        Me.btnCalcLowest.UseVisualStyleBackColor = True
        '
        'btnCalcHighest
        '
        Me.btnCalcHighest.Location = New System.Drawing.Point(12, 202)
        Me.btnCalcHighest.Name = "btnCalcHighest"
        Me.btnCalcHighest.Size = New System.Drawing.Size(218, 56)
        Me.btnCalcHighest.TabIndex = 6
        Me.btnCalcHighest.Text = "Highest Votes"
        Me.btnCalcHighest.UseVisualStyleBackColor = True
        '
        'txtLowest
        '
        Me.txtLowest.Location = New System.Drawing.Point(236, 281)
        Me.txtLowest.Name = "txtLowest"
        Me.txtLowest.Size = New System.Drawing.Size(163, 22)
        Me.txtLowest.TabIndex = 8
        '
        'txtHighest
        '
        Me.txtHighest.Location = New System.Drawing.Point(236, 219)
        Me.txtHighest.Name = "txtHighest"
        Me.txtHighest.Size = New System.Drawing.Size(163, 22)
        Me.txtHighest.TabIndex = 9
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(236, 157)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(163, 22)
        Me.txtAverage.TabIndex = 10
        '
        'frmSRC_Election
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.txtHighest)
        Me.Controls.Add(Me.txtLowest)
        Me.Controls.Add(Me.btnCalcHighest)
        Me.Controls.Add(Me.btnCalcLowest)
        Me.Controls.Add(Me.btnCalcAverage)
        Me.Controls.Add(Me.btnCalcTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnCampus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSRC_Election"
        Me.Text = "SRC Election"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCampus As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalcTotal As Button
    Friend WithEvents btnCalcAverage As Button
    Friend WithEvents btnCalcLowest As Button
    Friend WithEvents btnCalcHighest As Button
    Friend WithEvents txtLowest As TextBox
    Friend WithEvents txtHighest As TextBox
    Friend WithEvents txtAverage As TextBox
End Class
