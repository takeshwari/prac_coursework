﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHome
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
        Me.panelUser = New System.Windows.Forms.Panel()
        Me.btnCreateOrder = New System.Windows.Forms.Button()
        Me.lblUserPanel = New System.Windows.Forms.Label()
        Me.panelAdmin = New System.Windows.Forms.Panel()
        Me.btnBackupLogins = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.lblAdminPanel = New System.Windows.Forms.Label()
        Me.panelUserSettings = New System.Windows.Forms.Panel()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblUserSettings = New System.Windows.Forms.Label()
        Me.panelCurrentOrders = New System.Windows.Forms.Panel()
        Me.lblItemAmount = New System.Windows.Forms.Label()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.btnRefreshOrders = New System.Windows.Forms.Button()
        Me.listOrders = New System.Windows.Forms.ListBox()
        Me.lblCurrentOrders = New System.Windows.Forms.Label()
        Me.btnFulfilOrder = New System.Windows.Forms.Button()
        Me.panelUser.SuspendLayout()
        Me.panelAdmin.SuspendLayout()
        Me.panelUserSettings.SuspendLayout()
        Me.panelCurrentOrders.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelUser
        '
        Me.panelUser.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelUser.Controls.Add(Me.btnCreateOrder)
        Me.panelUser.Controls.Add(Me.lblUserPanel)
        Me.panelUser.Location = New System.Drawing.Point(12, 15)
        Me.panelUser.Name = "panelUser"
        Me.panelUser.Size = New System.Drawing.Size(270, 183)
        Me.panelUser.TabIndex = 0
        '
        'btnCreateOrder
        '
        Me.btnCreateOrder.Location = New System.Drawing.Point(3, 19)
        Me.btnCreateOrder.Name = "btnCreateOrder"
        Me.btnCreateOrder.Size = New System.Drawing.Size(264, 23)
        Me.btnCreateOrder.TabIndex = 1
        Me.btnCreateOrder.Text = "Create Order"
        Me.btnCreateOrder.UseVisualStyleBackColor = True
        '
        'lblUserPanel
        '
        Me.lblUserPanel.AutoSize = True
        Me.lblUserPanel.Location = New System.Drawing.Point(104, 3)
        Me.lblUserPanel.Name = "lblUserPanel"
        Me.lblUserPanel.Size = New System.Drawing.Size(59, 13)
        Me.lblUserPanel.TabIndex = 0
        Me.lblUserPanel.Text = "User Panel"
        '
        'panelAdmin
        '
        Me.panelAdmin.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelAdmin.Controls.Add(Me.btnBackupLogins)
        Me.panelAdmin.Controls.Add(Me.btnCreateAccount)
        Me.panelAdmin.Controls.Add(Me.lblAdminPanel)
        Me.panelAdmin.Location = New System.Drawing.Point(288, 15)
        Me.panelAdmin.Name = "panelAdmin"
        Me.panelAdmin.Size = New System.Drawing.Size(200, 100)
        Me.panelAdmin.TabIndex = 1
        Me.panelAdmin.Visible = False
        '
        'btnBackupLogins
        '
        Me.btnBackupLogins.Location = New System.Drawing.Point(3, 48)
        Me.btnBackupLogins.Name = "btnBackupLogins"
        Me.btnBackupLogins.Size = New System.Drawing.Size(194, 23)
        Me.btnBackupLogins.TabIndex = 2
        Me.btnBackupLogins.Text = "Backup Logins"
        Me.btnBackupLogins.UseVisualStyleBackColor = True
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(3, 19)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(194, 23)
        Me.btnCreateAccount.TabIndex = 1
        Me.btnCreateAccount.Text = "Create New Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'lblAdminPanel
        '
        Me.lblAdminPanel.AutoSize = True
        Me.lblAdminPanel.Location = New System.Drawing.Point(69, 3)
        Me.lblAdminPanel.Name = "lblAdminPanel"
        Me.lblAdminPanel.Size = New System.Drawing.Size(66, 13)
        Me.lblAdminPanel.TabIndex = 0
        Me.lblAdminPanel.Text = "Admin Panel"
        '
        'panelUserSettings
        '
        Me.panelUserSettings.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelUserSettings.Controls.Add(Me.btnChangePassword)
        Me.panelUserSettings.Controls.Add(Me.btnLogOut)
        Me.panelUserSettings.Controls.Add(Me.lblUserSettings)
        Me.panelUserSettings.Location = New System.Drawing.Point(12, 398)
        Me.panelUserSettings.Name = "panelUserSettings"
        Me.panelUserSettings.Size = New System.Drawing.Size(200, 100)
        Me.panelUserSettings.TabIndex = 2
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(3, 48)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(194, 23)
        Me.btnChangePassword.TabIndex = 2
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(3, 19)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(194, 23)
        Me.btnLogOut.TabIndex = 1
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'lblUserSettings
        '
        Me.lblUserSettings.AutoSize = True
        Me.lblUserSettings.Location = New System.Drawing.Point(60, 3)
        Me.lblUserSettings.Name = "lblUserSettings"
        Me.lblUserSettings.Size = New System.Drawing.Size(70, 13)
        Me.lblUserSettings.TabIndex = 0
        Me.lblUserSettings.Text = "User Settings"
        '
        'panelCurrentOrders
        '
        Me.panelCurrentOrders.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelCurrentOrders.Controls.Add(Me.btnFulfilOrder)
        Me.panelCurrentOrders.Controls.Add(Me.lblItemAmount)
        Me.panelCurrentOrders.Controls.Add(Me.lblItemID)
        Me.panelCurrentOrders.Controls.Add(Me.lblOrderID)
        Me.panelCurrentOrders.Controls.Add(Me.btnRefreshOrders)
        Me.panelCurrentOrders.Controls.Add(Me.listOrders)
        Me.panelCurrentOrders.Controls.Add(Me.lblCurrentOrders)
        Me.panelCurrentOrders.Location = New System.Drawing.Point(288, 135)
        Me.panelCurrentOrders.Name = "panelCurrentOrders"
        Me.panelCurrentOrders.Size = New System.Drawing.Size(200, 334)
        Me.panelCurrentOrders.TabIndex = 3
        '
        'lblItemAmount
        '
        Me.lblItemAmount.AutoSize = True
        Me.lblItemAmount.Location = New System.Drawing.Point(131, 29)
        Me.lblItemAmount.Name = "lblItemAmount"
        Me.lblItemAmount.Size = New System.Drawing.Size(66, 13)
        Me.lblItemAmount.TabIndex = 5
        Me.lblItemAmount.Text = "Item Amount"
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Location = New System.Drawing.Point(72, 29)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(41, 13)
        Me.lblItemID.TabIndex = 4
        Me.lblItemID.Text = "‪Item ID"
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(3, 29)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(47, 13)
        Me.lblOrderID.TabIndex = 3
        Me.lblOrderID.Text = "Order ID"
        '
        'btnRefreshOrders
        '
        Me.btnRefreshOrders.Location = New System.Drawing.Point(6, 305)
        Me.btnRefreshOrders.Name = "btnRefreshOrders"
        Me.btnRefreshOrders.Size = New System.Drawing.Size(191, 23)
        Me.btnRefreshOrders.TabIndex = 2
        Me.btnRefreshOrders.Text = "Refresh Orders"
        Me.btnRefreshOrders.UseVisualStyleBackColor = True
        '
        'listOrders
        '
        Me.listOrders.FormattingEnabled = True
        Me.listOrders.Location = New System.Drawing.Point(3, 45)
        Me.listOrders.Name = "listOrders"
        Me.listOrders.Size = New System.Drawing.Size(194, 225)
        Me.listOrders.TabIndex = 1
        '
        'lblCurrentOrders
        '
        Me.lblCurrentOrders.AutoSize = True
        Me.lblCurrentOrders.Location = New System.Drawing.Point(58, 3)
        Me.lblCurrentOrders.Name = "lblCurrentOrders"
        Me.lblCurrentOrders.Size = New System.Drawing.Size(75, 13)
        Me.lblCurrentOrders.TabIndex = 0
        Me.lblCurrentOrders.Text = "Current Orders"
        '
        'btnFulfilOrder
        '
        Me.btnFulfilOrder.Location = New System.Drawing.Point(6, 276)
        Me.btnFulfilOrder.Name = "btnFulfilOrder"
        Me.btnFulfilOrder.Size = New System.Drawing.Size(191, 23)
        Me.btnFulfilOrder.TabIndex = 6
        Me.btnFulfilOrder.Text = "Fulfil Order"
        Me.btnFulfilOrder.UseVisualStyleBackColor = True
        '
        'formHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 510)
        Me.Controls.Add(Me.panelCurrentOrders)
        Me.Controls.Add(Me.panelUserSettings)
        Me.Controls.Add(Me.panelAdmin)
        Me.Controls.Add(Me.panelUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formHome"
        Me.Text = "formHome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelUser.ResumeLayout(False)
        Me.panelUser.PerformLayout()
        Me.panelAdmin.ResumeLayout(False)
        Me.panelAdmin.PerformLayout()
        Me.panelUserSettings.ResumeLayout(False)
        Me.panelUserSettings.PerformLayout()
        Me.panelCurrentOrders.ResumeLayout(False)
        Me.panelCurrentOrders.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelUser As Panel
    Friend WithEvents panelAdmin As Panel
    Friend WithEvents lblAdminPanel As Label
    Friend WithEvents lblUserPanel As Label
    Friend WithEvents panelUserSettings As Panel
    Friend WithEvents lblUserSettings As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnBackupLogins As System.Windows.Forms.Button
    Friend WithEvents btnCreateOrder As Button
    Friend WithEvents panelCurrentOrders As Panel
    Friend WithEvents lblCurrentOrders As Label
    Friend WithEvents btnRefreshOrders As Button
    Friend WithEvents listOrders As ListBox
    Friend WithEvents lblItemID As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblItemAmount As Label
    Friend WithEvents btnFulfilOrder As Button
End Class
