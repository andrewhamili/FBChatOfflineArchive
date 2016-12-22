<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Messages
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBoxCoversationThreadList = New System.Windows.Forms.ListBox()
        Me.btnAddNewConversation = New System.Windows.Forms.Button()
        Me.btnEditConversation = New System.Windows.Forms.Button()
        Me.btnDeleteConversation = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 39)
        Me.Panel1.TabIndex = 1
        '
        'ListBoxCoversationThreadList
        '
        Me.ListBoxCoversationThreadList.FormattingEnabled = True
        Me.ListBoxCoversationThreadList.ItemHeight = 18
        Me.ListBoxCoversationThreadList.Location = New System.Drawing.Point(0, 82)
        Me.ListBoxCoversationThreadList.Name = "ListBoxCoversationThreadList"
        Me.ListBoxCoversationThreadList.Size = New System.Drawing.Size(243, 310)
        Me.ListBoxCoversationThreadList.TabIndex = 2
        '
        'btnAddNewConversation
        '
        Me.btnAddNewConversation.Location = New System.Drawing.Point(0, 390)
        Me.btnAddNewConversation.Name = "btnAddNewConversation"
        Me.btnAddNewConversation.Size = New System.Drawing.Size(243, 23)
        Me.btnAddNewConversation.TabIndex = 3
        Me.btnAddNewConversation.Text = "Add New Conversation Thread"
        Me.btnAddNewConversation.UseVisualStyleBackColor = True
        '
        'btnEditConversation
        '
        Me.btnEditConversation.Location = New System.Drawing.Point(0, 419)
        Me.btnEditConversation.Name = "btnEditConversation"
        Me.btnEditConversation.Size = New System.Drawing.Size(243, 23)
        Me.btnEditConversation.TabIndex = 4
        Me.btnEditConversation.Text = "Edit Conversation Thread"
        Me.btnEditConversation.UseVisualStyleBackColor = True
        '
        'btnDeleteConversation
        '
        Me.btnDeleteConversation.Location = New System.Drawing.Point(0, 450)
        Me.btnDeleteConversation.Name = "btnDeleteConversation"
        Me.btnDeleteConversation.Size = New System.Drawing.Size(243, 23)
        Me.btnDeleteConversation.TabIndex = 5
        Me.btnDeleteConversation.Text = "Delete Conversation Thread"
        Me.btnDeleteConversation.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Conversation Threads"
        '
        'Messages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 485)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteConversation)
        Me.Controls.Add(Me.btnEditConversation)
        Me.Controls.Add(Me.btnAddNewConversation)
        Me.Controls.Add(Me.ListBoxCoversationThreadList)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Messages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Messages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBoxCoversationThreadList As System.Windows.Forms.ListBox
    Friend WithEvents btnAddNewConversation As System.Windows.Forms.Button
    Friend WithEvents btnEditConversation As System.Windows.Forms.Button
    Friend WithEvents btnDeleteConversation As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
