﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtBoxUUID = New System.Windows.Forms.TextBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pnlBanners = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlAvatars = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(426, 205)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtBoxUUID
        '
        Me.txtBoxUUID.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtBoxUUID.Location = New System.Drawing.Point(12, 208)
        Me.txtBoxUUID.Name = "txtBoxUUID"
        Me.txtBoxUUID.Size = New System.Drawing.Size(408, 20)
        Me.txtBoxUUID.TabIndex = 2
        '
        'pb1
        '
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(420, 200)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb1.TabIndex = 0
        Me.pb1.TabStop = False
        '
        'pnlBanners
        '
        Me.pnlBanners.AutoScroll = True
        Me.pnlBanners.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBanners.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlBanners.Location = New System.Drawing.Point(819, 0)
        Me.pnlBanners.Name = "pnlBanners"
        Me.pnlBanners.Size = New System.Drawing.Size(445, 681)
        Me.pnlBanners.TabIndex = 6
        Me.pnlBanners.WrapContents = False
        '
        'pnlAvatars
        '
        Me.pnlAvatars.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlAvatars.Location = New System.Drawing.Point(595, 0)
        Me.pnlAvatars.Name = "pnlAvatars"
        Me.pnlAvatars.Size = New System.Drawing.Size(227, 698)
        Me.pnlAvatars.TabIndex = 7
        Me.pnlAvatars.WrapContents = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.txtBoxUUID)
        Me.Controls.Add(Me.pnlAvatars)
        Me.Controls.Add(Me.pnlBanners)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pb1)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb1 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtBoxUUID As TextBox
    Friend WithEvents pnlBanners As FlowLayoutPanel
    Friend WithEvents pnlAvatars As FlowLayoutPanel
End Class
