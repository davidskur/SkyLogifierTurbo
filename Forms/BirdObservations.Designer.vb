﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BirdObservations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BirdObservations))
        Me.lbObservedBirds = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbObservedBirds
        '
        Me.lbObservedBirds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbObservedBirds.FormattingEnabled = True
        Me.lbObservedBirds.HorizontalScrollbar = True
        Me.lbObservedBirds.Location = New System.Drawing.Point(10, 10)
        Me.lbObservedBirds.Name = "lbObservedBirds"
        Me.lbObservedBirds.Size = New System.Drawing.Size(502, 269)
        Me.lbObservedBirds.TabIndex = 0
        '
        'BirdObservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 289)
        Me.Controls.Add(Me.lbObservedBirds)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BirdObservations"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Recent Bird Observations"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbObservedBirds As ListBox
End Class
