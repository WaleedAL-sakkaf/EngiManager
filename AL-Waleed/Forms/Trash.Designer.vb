<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trash
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DatabaseDataSet = New AL_Waleed.DatabaseDataSet
        Me.DeliveredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveredTableAdapter = New AL_Waleed.DatabaseDataSetTableAdapters.DeliveredTableAdapter
        Me.الاسمDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الموديDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعالجهازDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.التاريخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.السعرDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الرقمDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الخللDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bold Italic Art", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 39)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "الجرد الاشهري"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(82, 311)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView2.Size = New System.Drawing.Size(775, 154)
        Me.DataGridView2.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bold Italic Art", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 39)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "الاجهزة التي تمت استلامها "
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.الاسمDataGridViewTextBoxColumn, Me.الموديDataGridViewTextBoxColumn, Me.نوعالجهازDataGridViewTextBoxColumn, Me.التاريخDataGridViewTextBoxColumn, Me.السعرDataGridViewTextBoxColumn, Me.الرقمDataGridViewTextBoxColumn, Me.الخللDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DeliveredBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(82, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(775, 151)
        Me.DataGridView1.TabIndex = 37
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeliveredBindingSource
        '
        Me.DeliveredBindingSource.DataMember = "Delivered"
        Me.DeliveredBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DeliveredTableAdapter
        '
        Me.DeliveredTableAdapter.ClearBeforeFill = True
        '
        'الاسمDataGridViewTextBoxColumn
        '
        Me.الاسمDataGridViewTextBoxColumn.DataPropertyName = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn.HeaderText = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn.Name = "الاسمDataGridViewTextBoxColumn"
        '
        'الموديDataGridViewTextBoxColumn
        '
        Me.الموديDataGridViewTextBoxColumn.DataPropertyName = "المودي"
        Me.الموديDataGridViewTextBoxColumn.HeaderText = "المودي"
        Me.الموديDataGridViewTextBoxColumn.Name = "الموديDataGridViewTextBoxColumn"
        '
        'نوعالجهازDataGridViewTextBoxColumn
        '
        Me.نوعالجهازDataGridViewTextBoxColumn.DataPropertyName = "نوع الجهاز"
        Me.نوعالجهازDataGridViewTextBoxColumn.HeaderText = "نوع الجهاز"
        Me.نوعالجهازDataGridViewTextBoxColumn.Name = "نوعالجهازDataGridViewTextBoxColumn"
        '
        'التاريخDataGridViewTextBoxColumn
        '
        Me.التاريخDataGridViewTextBoxColumn.DataPropertyName = "التاريخ"
        Me.التاريخDataGridViewTextBoxColumn.HeaderText = "التاريخ"
        Me.التاريخDataGridViewTextBoxColumn.Name = "التاريخDataGridViewTextBoxColumn"
        '
        'السعرDataGridViewTextBoxColumn
        '
        Me.السعرDataGridViewTextBoxColumn.DataPropertyName = "السعر"
        DataGridViewCellStyle1.Format = "C0"
        Me.السعرDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.السعرDataGridViewTextBoxColumn.HeaderText = "السعر"
        Me.السعرDataGridViewTextBoxColumn.Name = "السعرDataGridViewTextBoxColumn"
        '
        'الرقمDataGridViewTextBoxColumn
        '
        Me.الرقمDataGridViewTextBoxColumn.DataPropertyName = "الرقم"
        Me.الرقمDataGridViewTextBoxColumn.HeaderText = "الرقم"
        Me.الرقمDataGridViewTextBoxColumn.Name = "الرقمDataGridViewTextBoxColumn"
        '
        'الخللDataGridViewTextBoxColumn
        '
        Me.الخللDataGridViewTextBoxColumn.DataPropertyName = "الخلل"
        Me.الخللDataGridViewTextBoxColumn.HeaderText = "الخلل"
        Me.الخللDataGridViewTextBoxColumn.Name = "الخللDataGridViewTextBoxColumn"
        '
        'Trash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(962, 530)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Trash"
        Me.Text = "trash"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseDataSet As AL_Waleed.DatabaseDataSet
    Friend WithEvents DeliveredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveredTableAdapter As AL_Waleed.DatabaseDataSetTableAdapters.DeliveredTableAdapter
    Friend WithEvents الاسمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الموديDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعالجهازDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents التاريخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents السعرDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الرقمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الخللDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
