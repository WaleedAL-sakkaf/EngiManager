﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class parts
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.الاسمDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعالجهازDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اللونDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الكميةDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.السعرDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الاجماليDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PartsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New AL_Waleed.DatabaseDataSet
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.PartsTableAdapter = New AL_Waleed.DatabaseDataSetTableAdapters.partsTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.الاسمDataGridViewTextBoxColumn, Me.نوعالجهازDataGridViewTextBoxColumn, Me.اللونDataGridViewTextBoxColumn, Me.الكميةDataGridViewTextBoxColumn, Me.السعرDataGridViewTextBoxColumn, Me.الاجماليDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PartsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(205, 245)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(550, 122)
        Me.DataGridView1.TabIndex = 0
        '
        'الاسمDataGridViewTextBoxColumn
        '
        Me.الاسمDataGridViewTextBoxColumn.DataPropertyName = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn.HeaderText = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn.Name = "الاسمDataGridViewTextBoxColumn"
        '
        'نوعالجهازDataGridViewTextBoxColumn
        '
        Me.نوعالجهازDataGridViewTextBoxColumn.DataPropertyName = "نوع الجهاز"
        Me.نوعالجهازDataGridViewTextBoxColumn.HeaderText = "نوع الجهاز"
        Me.نوعالجهازDataGridViewTextBoxColumn.Name = "نوعالجهازDataGridViewTextBoxColumn"
        '
        'اللونDataGridViewTextBoxColumn
        '
        Me.اللونDataGridViewTextBoxColumn.DataPropertyName = "اللون"
        Me.اللونDataGridViewTextBoxColumn.HeaderText = "اللون"
        Me.اللونDataGridViewTextBoxColumn.Name = "اللونDataGridViewTextBoxColumn"
        '
        'الكميةDataGridViewTextBoxColumn
        '
        Me.الكميةDataGridViewTextBoxColumn.DataPropertyName = "الكمية"
        Me.الكميةDataGridViewTextBoxColumn.HeaderText = "الكمية"
        Me.الكميةDataGridViewTextBoxColumn.Name = "الكميةDataGridViewTextBoxColumn"
        Me.الكميةDataGridViewTextBoxColumn.Width = 60
        '
        'السعرDataGridViewTextBoxColumn
        '
        Me.السعرDataGridViewTextBoxColumn.DataPropertyName = "السعر"
        DataGridViewCellStyle1.Format = "C0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.السعرDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.السعرDataGridViewTextBoxColumn.HeaderText = "السعر"
        Me.السعرDataGridViewTextBoxColumn.Name = "السعرDataGridViewTextBoxColumn"
        Me.السعرDataGridViewTextBoxColumn.Width = 70
        '
        'الاجماليDataGridViewTextBoxColumn
        '
        Me.الاجماليDataGridViewTextBoxColumn.DataPropertyName = "الاجمالي"
        DataGridViewCellStyle2.Format = "C0"
        Me.الاجماليDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.الاجماليDataGridViewTextBoxColumn.HeaderText = "الاجمالي"
        Me.الاجماليDataGridViewTextBoxColumn.Name = "الاجماليDataGridViewTextBoxColumn"
        Me.الاجماليDataGridViewTextBoxColumn.Width = 70
        '
        'PartsBindingSource
        '
        Me.PartsBindingSource.DataMember = "parts"
        Me.PartsBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(536, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 20)
        Me.TextBox1.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(757, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 21)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "الاسم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(451, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "نوع الجهاز"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(217, 117)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 20)
        Me.TextBox2.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(757, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 21)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "اللون"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(451, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "الكمية"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(217, 152)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(201, 20)
        Me.TextBox4.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(569, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 21)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "بحث"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(335, 394)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(201, 20)
        Me.TextBox6.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(451, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 21)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "السعر"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(217, 195)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(201, 20)
        Me.TextBox5.TabIndex = 52
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 4
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(622, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 40)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "اضافه"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 4
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(483, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 40)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "تعديل"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 4
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(348, 439)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 40)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "حذف"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 4
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(212, 439)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 40)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "طباعة"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bold Italic Art", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(293, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(373, 39)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = " قسم قطع الغيار  و الاكسسوارات"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"اسود ", "ابيض ", "ازرق ", "ذهبي", "سماوي"})
        Me.ComboBox1.Location = New System.Drawing.Point(536, 161)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox1.TabIndex = 55
        '
        'PartsTableAdapter
        '
        Me.PartsTableAdapter.ClearBeforeFill = True
        '
        'parts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(962, 530)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "parts"
        Me.Text = "parts"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents الرقمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DatabaseDataSet As AL_Waleed.DatabaseDataSet
    Friend WithEvents PartsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartsTableAdapter As AL_Waleed.DatabaseDataSetTableAdapters.partsTableAdapter
    Friend WithEvents الاسمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعالجهازDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اللونDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الكميةDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents السعرDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الاجماليDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
