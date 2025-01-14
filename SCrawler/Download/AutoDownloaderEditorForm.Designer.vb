﻿' Copyright (C) 2022  Andy
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY
Namespace DownloadObjects
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Friend Class AutoDownloaderEditorForm : Inherits System.Windows.Forms.Form
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
        Private components As System.ComponentModel.IContainer
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim CONTAINER_MAIN As System.Windows.Forms.ToolStripContainer
            Dim ActionButton1 As PersonalUtilities.Forms.Controls.Base.ActionButton = New PersonalUtilities.Forms.Controls.Base.ActionButton()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoDownloaderEditorForm))
            Dim ActionButton2 As PersonalUtilities.Forms.Controls.Base.ActionButton = New PersonalUtilities.Forms.Controls.Base.ActionButton()
            Dim TP_MODE As System.Windows.Forms.TableLayoutPanel
            Dim ActionButton3 As PersonalUtilities.Forms.Controls.Base.ActionButton = New PersonalUtilities.Forms.Controls.Base.ActionButton()
            Dim TT_MAIN As System.Windows.Forms.ToolTip
            Me.DEF_GROUP = New SCrawler.DownloadObjects.Groups.GroupDefaults()
            Me.TXT_GROUPS = New PersonalUtilities.Forms.Controls.TextBoxExtended()
            Me.OPT_ALL = New System.Windows.Forms.RadioButton()
            Me.OPT_DEFAULT = New System.Windows.Forms.RadioButton()
            Me.OPT_SPEC = New System.Windows.Forms.RadioButton()
            Me.OPT_DISABLED = New System.Windows.Forms.RadioButton()
            Me.OPT_GROUP = New System.Windows.Forms.RadioButton()
            Me.CH_NOTIFY = New System.Windows.Forms.CheckBox()
            Me.TXT_TIMER = New PersonalUtilities.Forms.Controls.TextBoxExtended()
            Me.LBL_LAST_TIME_UP = New System.Windows.Forms.Label()
            CONTAINER_MAIN = New System.Windows.Forms.ToolStripContainer()
            TP_MODE = New System.Windows.Forms.TableLayoutPanel()
            TT_MAIN = New System.Windows.Forms.ToolTip(Me.components)
            CONTAINER_MAIN.ContentPanel.SuspendLayout()
            CONTAINER_MAIN.SuspendLayout()
            Me.DEF_GROUP.SuspendLayout()
            CType(Me.TXT_GROUPS, System.ComponentModel.ISupportInitialize).BeginInit()
            TP_MODE.SuspendLayout()
            CType(Me.TXT_TIMER, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'CONTAINER_MAIN
            '
            '
            'CONTAINER_MAIN.ContentPanel
            '
            CONTAINER_MAIN.ContentPanel.Controls.Add(Me.DEF_GROUP)
            CONTAINER_MAIN.ContentPanel.Size = New System.Drawing.Size(476, 217)
            CONTAINER_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
            CONTAINER_MAIN.LeftToolStripPanelVisible = False
            CONTAINER_MAIN.Location = New System.Drawing.Point(0, 0)
            CONTAINER_MAIN.Name = "CONTAINER_MAIN"
            CONTAINER_MAIN.RightToolStripPanelVisible = False
            CONTAINER_MAIN.Size = New System.Drawing.Size(476, 242)
            CONTAINER_MAIN.TabIndex = 0
            CONTAINER_MAIN.TopToolStripPanelVisible = False
            '
            'DEF_GROUP
            '
            Me.DEF_GROUP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
            Me.DEF_GROUP.ColumnCount = 1
            Me.DEF_GROUP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.DEF_GROUP.Controls.Add(Me.TXT_GROUPS, 0, 4)
            Me.DEF_GROUP.Controls.Add(TP_MODE, 0, 0)
            Me.DEF_GROUP.Controls.Add(Me.CH_NOTIFY, 0, 5)
            Me.DEF_GROUP.Controls.Add(Me.TXT_TIMER, 0, 6)
            Me.DEF_GROUP.Controls.Add(Me.LBL_LAST_TIME_UP, 0, 7)
            Me.DEF_GROUP.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DEF_GROUP.Location = New System.Drawing.Point(0, 0)
            Me.DEF_GROUP.Name = "DEF_GROUP"
            Me.DEF_GROUP.RowCount = 9
            Me.DEF_GROUP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.DEF_GROUP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.DEF_GROUP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.DEF_GROUP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.DEF_GROUP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.DEF_GROUP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.DEF_GROUP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.DEF_GROUP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.DEF_GROUP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.DEF_GROUP.Size = New System.Drawing.Size(476, 217)
            Me.DEF_GROUP.TabIndex = 0
            '
            'TXT_GROUPS
            '
            ActionButton1.BackgroundImage = CType(resources.GetObject("ActionButton1.BackgroundImage"), System.Drawing.Image)
            ActionButton1.Index = 0
            ActionButton1.Name = "BTT_EDIT"
            ActionButton2.BackgroundImage = CType(resources.GetObject("ActionButton2.BackgroundImage"), System.Drawing.Image)
            ActionButton2.Index = 1
            ActionButton2.Name = "BTT_CLEAR"
            Me.TXT_GROUPS.Buttons.Add(ActionButton1)
            Me.TXT_GROUPS.Buttons.Add(ActionButton2)
            Me.TXT_GROUPS.CaptionText = "Groups"
            Me.TXT_GROUPS.CaptionWidth = 50.0R
            Me.TXT_GROUPS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TXT_GROUPS.Location = New System.Drawing.Point(4, 111)
            Me.TXT_GROUPS.Name = "TXT_GROUPS"
            Me.TXT_GROUPS.Size = New System.Drawing.Size(468, 22)
            Me.TXT_GROUPS.TabIndex = 4
            '
            'TP_MODE
            '
            TP_MODE.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
            TP_MODE.ColumnCount = 5
            TP_MODE.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            TP_MODE.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            TP_MODE.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            TP_MODE.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            TP_MODE.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            TP_MODE.Controls.Add(Me.OPT_ALL, 1, 0)
            TP_MODE.Controls.Add(Me.OPT_DEFAULT, 2, 0)
            TP_MODE.Controls.Add(Me.OPT_SPEC, 3, 0)
            TP_MODE.Controls.Add(Me.OPT_DISABLED, 0, 0)
            TP_MODE.Controls.Add(Me.OPT_GROUP, 4, 0)
            TP_MODE.Dock = System.Windows.Forms.DockStyle.Fill
            TP_MODE.Location = New System.Drawing.Point(1, 1)
            TP_MODE.Margin = New System.Windows.Forms.Padding(0)
            TP_MODE.Name = "TP_MODE"
            TP_MODE.RowCount = 1
            TP_MODE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            TP_MODE.Size = New System.Drawing.Size(474, 25)
            TP_MODE.TabIndex = 8
            '
            'OPT_ALL
            '
            Me.OPT_ALL.AutoSize = True
            Me.OPT_ALL.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OPT_ALL.Location = New System.Drawing.Point(98, 4)
            Me.OPT_ALL.Name = "OPT_ALL"
            Me.OPT_ALL.Size = New System.Drawing.Size(87, 17)
            Me.OPT_ALL.TabIndex = 1
            Me.OPT_ALL.TabStop = True
            Me.OPT_ALL.Text = "ALL"
            TT_MAIN.SetToolTip(Me.OPT_ALL, "Download all users")
            Me.OPT_ALL.UseVisualStyleBackColor = True
            '
            'OPT_DEFAULT
            '
            Me.OPT_DEFAULT.AutoSize = True
            Me.OPT_DEFAULT.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OPT_DEFAULT.Location = New System.Drawing.Point(192, 4)
            Me.OPT_DEFAULT.Name = "OPT_DEFAULT"
            Me.OPT_DEFAULT.Size = New System.Drawing.Size(87, 17)
            Me.OPT_DEFAULT.TabIndex = 2
            Me.OPT_DEFAULT.TabStop = True
            Me.OPT_DEFAULT.Text = "Default"
            TT_MAIN.SetToolTip(Me.OPT_DEFAULT, "All users marked ""Ready for download""")
            Me.OPT_DEFAULT.UseVisualStyleBackColor = True
            '
            'OPT_SPEC
            '
            Me.OPT_SPEC.AutoSize = True
            Me.OPT_SPEC.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OPT_SPEC.Location = New System.Drawing.Point(286, 4)
            Me.OPT_SPEC.Name = "OPT_SPEC"
            Me.OPT_SPEC.Size = New System.Drawing.Size(87, 17)
            Me.OPT_SPEC.TabIndex = 3
            Me.OPT_SPEC.TabStop = True
            Me.OPT_SPEC.Text = "Specified"
            TT_MAIN.SetToolTip(Me.OPT_SPEC, "Select parameters")
            Me.OPT_SPEC.UseVisualStyleBackColor = True
            '
            'OPT_DISABLED
            '
            Me.OPT_DISABLED.AutoSize = True
            Me.OPT_DISABLED.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OPT_DISABLED.Location = New System.Drawing.Point(4, 4)
            Me.OPT_DISABLED.Name = "OPT_DISABLED"
            Me.OPT_DISABLED.Size = New System.Drawing.Size(87, 17)
            Me.OPT_DISABLED.TabIndex = 0
            Me.OPT_DISABLED.TabStop = True
            Me.OPT_DISABLED.Text = "Disabled"
            TT_MAIN.SetToolTip(Me.OPT_DISABLED, "Automation disabled")
            Me.OPT_DISABLED.UseVisualStyleBackColor = True
            '
            'OPT_GROUP
            '
            Me.OPT_GROUP.AutoSize = True
            Me.OPT_GROUP.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OPT_GROUP.Location = New System.Drawing.Point(380, 4)
            Me.OPT_GROUP.Name = "OPT_GROUP"
            Me.OPT_GROUP.Size = New System.Drawing.Size(90, 17)
            Me.OPT_GROUP.TabIndex = 4
            Me.OPT_GROUP.TabStop = True
            Me.OPT_GROUP.Text = "Groups"
            TT_MAIN.SetToolTip(Me.OPT_GROUP, "Download groups")
            Me.OPT_GROUP.UseVisualStyleBackColor = True
            '
            'CH_NOTIFY
            '
            Me.CH_NOTIFY.AutoSize = True
            Me.CH_NOTIFY.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CH_NOTIFY.Location = New System.Drawing.Point(4, 140)
            Me.CH_NOTIFY.Name = "CH_NOTIFY"
            Me.CH_NOTIFY.Size = New System.Drawing.Size(468, 19)
            Me.CH_NOTIFY.TabIndex = 12
            Me.CH_NOTIFY.Text = "Show notifications"
            Me.CH_NOTIFY.UseVisualStyleBackColor = True
            '
            'TXT_TIMER
            '
            ActionButton3.BackgroundImage = CType(resources.GetObject("ActionButton3.BackgroundImage"), System.Drawing.Image)
            ActionButton3.Index = 0
            ActionButton3.Name = "BTT_REFRESH"
            Me.TXT_TIMER.Buttons.Add(ActionButton3)
            Me.TXT_TIMER.CaptionText = "Timer"
            Me.TXT_TIMER.CaptionWidth = 50.0R
            Me.TXT_TIMER.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TXT_TIMER.Location = New System.Drawing.Point(4, 166)
            Me.TXT_TIMER.Name = "TXT_TIMER"
            Me.TXT_TIMER.Size = New System.Drawing.Size(468, 22)
            Me.TXT_TIMER.TabIndex = 16
            '
            'LBL_LAST_TIME_UP
            '
            Me.LBL_LAST_TIME_UP.AutoSize = True
            Me.LBL_LAST_TIME_UP.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_LAST_TIME_UP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.LBL_LAST_TIME_UP.Location = New System.Drawing.Point(4, 192)
            Me.LBL_LAST_TIME_UP.Name = "LBL_LAST_TIME_UP"
            Me.LBL_LAST_TIME_UP.Size = New System.Drawing.Size(468, 25)
            Me.LBL_LAST_TIME_UP.TabIndex = 20
            Me.LBL_LAST_TIME_UP.Text = "Last download date: "
            Me.LBL_LAST_TIME_UP.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'AutoDownloaderEditorForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(476, 242)
            Me.Controls.Add(CONTAINER_MAIN)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(492, 281)
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(492, 281)
            Me.Name = "AutoDownloaderEditorForm"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.Text = "AutoDownloader settings"
            CONTAINER_MAIN.ContentPanel.ResumeLayout(False)
            CONTAINER_MAIN.ResumeLayout(False)
            CONTAINER_MAIN.PerformLayout()
            Me.DEF_GROUP.ResumeLayout(False)
            Me.DEF_GROUP.PerformLayout()
            CType(Me.TXT_GROUPS, System.ComponentModel.ISupportInitialize).EndInit()
            TP_MODE.ResumeLayout(False)
            TP_MODE.PerformLayout()
            CType(Me.TXT_TIMER, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents DEF_GROUP As DownloadObjects.Groups.GroupDefaults
        Private WithEvents TXT_GROUPS As PersonalUtilities.Forms.Controls.TextBoxExtended
        Private WithEvents OPT_ALL As RadioButton
        Private WithEvents OPT_DEFAULT As RadioButton
        Private WithEvents OPT_SPEC As RadioButton
        Private WithEvents OPT_DISABLED As RadioButton
        Private WithEvents CH_NOTIFY As CheckBox
        Friend WithEvents TXT_TIMER As PersonalUtilities.Forms.Controls.TextBoxExtended
        Private WithEvents OPT_GROUP As RadioButton
        Private WithEvents LBL_LAST_TIME_UP As Label
    End Class
End Namespace