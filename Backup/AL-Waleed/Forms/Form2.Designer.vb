<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.الاسمDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الموديلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعالجهازDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.التاريخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.السعرDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الرقمDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الخللDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New AL_Waleed.DatabaseDataSet
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.الاسمDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الموديلDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعالجهازDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.التاريخDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.السعرDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الرقمDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الخللDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.PhonesTableAdapter = New AL_Waleed.DatabaseDataSetTableAdapters.phonesTableAdapter
        Me.DoneTableAdapter = New AL_Waleed.DatabaseDataSetTableAdapters.DoneTableAdapter
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.الاسمDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الموديلDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعالجهازDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.التاريخDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.السعرDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الرقمDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الخللDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.الاسمDataGridViewTextBoxColumn, Me.الموديلDataGridViewTextBoxColumn, Me.نوعالجهازDataGridViewTextBoxColumn, Me.التاريخDataGridViewTextBoxColumn, Me.السعرDataGridViewTextBoxColumn, Me.الرقمDataGridViewTextBoxColumn, Me.الخللDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PhonesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(106, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(745, 130)
        Me.DataGridView1.TabIndex = 0
        '
        'الاسمDataGridViewTextBoxColumn
        '
        Me.الاسمDataGridViewTextBoxColumn.DataPropertyName = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn.HeaderText = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn.Name = "الاسمDataGridViewTextBoxColumn"
        '
        'الموديلDataGridViewTextBoxColumn
        '
        Me.الموديلDataGridViewTextBoxColumn.DataPropertyName = "الموديل"
        Me.الموديلDataGridViewTextBoxColumn.HeaderText = "الموديل"
        Me.الموديلDataGridViewTextBoxColumn.Name = "الموديلDataGridViewTextBoxColumn"
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
        DataGridViewCellStyle2.Format = "N0"
        Me.الرقمDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.الرقمDataGridViewTextBoxColumn.HeaderText = "الرقم"
        Me.الرقمDataGridViewTextBoxColumn.Name = "الرقمDataGridViewTextBoxColumn"
        '
        'الخللDataGridViewTextBoxColumn
        '
        Me.الخللDataGridViewTextBoxColumn.DataPropertyName = "الخلل"
        Me.الخللDataGridViewTextBoxColumn.HeaderText = "الخلل"
        Me.الخللDataGridViewTextBoxColumn.Name = "الخللDataGridViewTextBoxColumn"
        '
        'PhonesBindingSource
        '
        Me.PhonesBindingSource.DataMember = "phones"
        Me.PhonesBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 4
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(547, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 31)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "بحث "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bold Italic Art", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 39)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "الأجهزة التي تحتاج لصيانة "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(422, 241)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 22)
        Me.TextBox1.TabIndex = 35
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.الاسمDataGridViewTextBoxColumn2, Me.الموديلDataGridViewTextBoxColumn2, Me.نوعالجهازDataGridViewTextBoxColumn2, Me.التاريخDataGridViewTextBoxColumn2, Me.السعرDataGridViewTextBoxColumn2, Me.الرقمDataGridViewTextBoxColumn2, Me.الخللDataGridViewTextBoxColumn2})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView2.DataSource = Me.DoneBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(106, 341)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView2.Size = New System.Drawing.Size(745, 140)
        Me.DataGridView2.TabIndex = 0
        '
        'DoneBindingSource
        '
        Me.DoneBindingSource.DataMember = "Done"
        Me.DoneBindingSource.DataSource = Me.DatabaseDataSet
        '
        'الاسمDataGridViewTextBoxColumn1
        '
        Me.الاسمDataGridViewTextBoxColumn1.DataPropertyName = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn1.HeaderText = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn1.Name = "الاسمDataGridViewTextBoxColumn1"
        '
        'الموديلDataGridViewTextBoxColumn1
        '
        Me.الموديلDataGridViewTextBoxColumn1.DataPropertyName = "الموديل"
        Me.الموديلDataGridViewTextBoxColumn1.HeaderText = "الموديل"
        Me.الموديلDataGridViewTextBoxColumn1.Name = "الموديلDataGridViewTextBoxColumn1"
        '
        'نوعالجهازDataGridViewTextBoxColumn1
        '
        Me.نوعالجهازDataGridViewTextBoxColumn1.DataPropertyName = "نوع الجهاز"
        Me.نوعالجهازDataGridViewTextBoxColumn1.HeaderText = "نوع الجهاز"
        Me.نوعالجهازDataGridViewTextBoxColumn1.Name = "نوعالجهازDataGridViewTextBoxColumn1"
        '
        'التاريخDataGridViewTextBoxColumn1
        '
        Me.التاريخDataGridViewTextBoxColumn1.DataPropertyName = "التاريخ"
        Me.التاريخDataGridViewTextBoxColumn1.HeaderText = "التاريخ"
        Me.التاريخDataGridViewTextBoxColumn1.Name = "التاريخDataGridViewTextBoxColumn1"
        '
        'السعرDataGridViewTextBoxColumn1
        '
        Me.السعرDataGridViewTextBoxColumn1.DataPropertyName = "السعر"
        Me.السعرDataGridViewTextBoxColumn1.HeaderText = "السعر"
        Me.السعرDataGridViewTextBoxColumn1.Name = "السعرDataGridViewTextBoxColumn1"
        '
        'الرقمDataGridViewTextBoxColumn1
        '
        Me.الرقمDataGridViewTextBoxColumn1.DataPropertyName = "الرقم"
        Me.الرقمDataGridViewTextBoxColumn1.HeaderText = "الرقم"
        Me.الرقمDataGridViewTextBoxColumn1.Name = "الرقمDataGridViewTextBoxColumn1"
        '
        'الخللDataGridViewTextBoxColumn1
        '
        Me.الخللDataGridViewTextBoxColumn1.DataPropertyName = "الخلل"
        Me.الخللDataGridViewTextBoxColumn1.HeaderText = "الخلل"
        Me.الخللDataGridViewTextBoxColumn1.Name = "الخللDataGridViewTextBoxColumn1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bold Italic Art", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 39)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "الأجهزة التي تم اصلاحها "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.FlatAppearance.BorderSize = 4
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(265, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 31)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "تم الاصلاح"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PhonesTableAdapter
        '
        Me.PhonesTableAdapter.ClearBeforeFill = True
        '
        'DoneTableAdapter
        '
        Me.DoneTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 4
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(148, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 31)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "بحث "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 4
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(547, 488)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 31)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "بحث "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button5.FlatAppearance.BorderSize = 4
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(265, 487)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 31)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "تم التسليم"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(422, 496)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(119, 22)
        Me.TextBox2.TabIndex = 35
        '
        'الاسمDataGridViewTextBoxColumn2
        '
        Me.الاسمDataGridViewTextBoxColumn2.DataPropertyName = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn2.HeaderText = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn2.Name = "الاسمDataGridViewTextBoxColumn2"
        '
        'الموديلDataGridViewTextBoxColumn2
        '
        Me.الموديلDataGridViewTextBoxColumn2.DataPropertyName = "الموديل"
        Me.الموديلDataGridViewTextBoxColumn2.HeaderText = "الموديل"
        Me.الموديلDataGridViewTextBoxColumn2.Name = "الموديلDataGridViewTextBoxColumn2"
        '
        'نوعالجهازDataGridViewTextBoxColumn2
        '
        Me.نوعالجهازDataGridViewTextBoxColumn2.DataPropertyName = "نوع الجهاز"
        Me.نوعالجهازDataGridViewTextBoxColumn2.HeaderText = "نوع الجهاز"
        Me.نوعالجهازDataGridViewTextBoxColumn2.Name = "نوعالجهازDataGridViewTextBoxColumn2"
        '
        'التاريخDataGridViewTextBoxColumn2
        '
        Me.التاريخDataGridViewTextBoxColumn2.DataPropertyName = "التاريخ"
        Me.التاريخDataGridViewTextBoxColumn2.HeaderText = "التاريخ"
        Me.التاريخDataGridViewTextBoxColumn2.Name = "التاريخDataGridViewTextBoxColumn2"
        '
        'السعرDataGridViewTextBoxColumn2
        '
        Me.السعرDataGridViewTextBoxColumn2.DataPropertyName = "السعر"
        DataGridViewCellStyle3.Format = "C0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.السعرDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.السعرDataGridViewTextBoxColumn2.HeaderText = "السعر"
        Me.السعرDataGridViewTextBoxColumn2.Name = "السعرDataGridViewTextBoxColumn2"
        '
        'الرقمDataGridViewTextBoxColumn2
        '
        Me.الرقمDataGridViewTextBoxColumn2.DataPropertyName = "الرقم"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.الرقمDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.الرقمDataGridViewTextBoxColumn2.HeaderText = "الرقم"
        Me.الرقمDataGridViewTextBoxColumn2.Name = "الرقمDataGridViewTextBoxColumn2"
        '
        'الخللDataGridViewTextBoxColumn2
        '
        Me.الخللDataGridViewTextBoxColumn2.DataPropertyName = "الخلل"
        Me.الخللDataGridViewTextBoxColumn2.HeaderText = "الخلل"
        Me.الخللDataGridViewTextBoxColumn2.Name = "الخللDataGridViewTextBoxColumn2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(962, 530)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IssueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Friend WithEvents الاسمDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الموديلDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعالجهازDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents التاريخDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents السعرDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الرقمDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الخللDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DatabaseDataSet As AL_Waleed.DatabaseDataSet
    Friend WithEvents PhonesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PhonesTableAdapter As AL_Waleed.DatabaseDataSetTableAdapters.phonesTableAdapter
    Friend WithEvents DoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoneTableAdapter As AL_Waleed.DatabaseDataSetTableAdapters.DoneTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents الاسمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الموديلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعالجهازDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents التاريخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents السعرDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الرقمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الخللDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الاسمDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الموديلDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعالجهازDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents التاريخDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents السعرDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الرقمDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الخللDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
