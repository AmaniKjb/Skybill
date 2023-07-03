Imports System.ComponentModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form replaces the Dispose method to clean up the list of components.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtBOQ = New System.Windows.Forms.DateTimePicker()
        Me.txtBOQFor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBOQNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbill = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtW = New System.Windows.Forms.TextBox()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTaxeRate = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTVA = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnBilling = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btnBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 36)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Skybill.My.Resources.Resources.Icon_Best
        Me.PictureBox2.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(39, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 17)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "SkyBill"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.Skybill.My.Resources.Resources.close_window_64px
        Me.PictureBox1.Location = New System.Drawing.Point(962, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(16, 231)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(970, 202)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.FillWeight = 40.0!
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "Item"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 40
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.FillWeight = 40.0!
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 280
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "Unit"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 51
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = "No"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 40
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = "Lenght"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column7.HeaderText = "Width"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 70
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column8.HeaderText = "Depth"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 70
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column9.HeaderText = "Qty"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 90
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column10.HeaderText = "Unite_Price"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column11.HeaderText = "Total"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column12.HeaderText = ""
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 5
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column13.HeaderText = ""
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtBOQ)
        Me.GroupBox1.Controls.Add(Me.txtBOQFor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBOQNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtbill)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 109)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'dtBOQ
        '
        Me.dtBOQ.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBOQ.Location = New System.Drawing.Point(772, 46)
        Me.dtBOQ.Name = "dtBOQ"
        Me.dtBOQ.Size = New System.Drawing.Size(188, 20)
        Me.dtBOQ.TabIndex = 13
        '
        'txtBOQFor
        '
        Me.txtBOQFor.Location = New System.Drawing.Point(61, 71)
        Me.txtBOQFor.Name = "txtBOQFor"
        Me.txtBOQFor.Size = New System.Drawing.Size(898, 20)
        Me.txtBOQFor.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "BOQ For"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(61, 45)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(326, 20)
        Me.txtaddress.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Address"
        '
        'txtBOQNo
        '
        Me.txtBOQNo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtBOQNo.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.txtBOQNo.ForeColor = System.Drawing.Color.Crimson
        Me.txtBOQNo.Location = New System.Drawing.Point(771, 19)
        Me.txtBOQNo.Name = "txtBOQNo"
        Me.txtBOQNo.Size = New System.Drawing.Size(188, 22)
        Me.txtBOQNo.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(709, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "BOQ Date"
        '
        'txtbill
        '
        Me.txtbill.Location = New System.Drawing.Point(61, 19)
        Me.txtbill.Name = "txtbill"
        Me.txtbill.Size = New System.Drawing.Size(326, 20)
        Me.txtbill.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(725, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "BOQ #"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bill To"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox2.Controls.Add(Me.txtQty)
        Me.GroupBox2.Controls.Add(Me.txtD)
        Me.GroupBox2.Controls.Add(Me.txtW)
        Me.GroupBox2.Controls.Add(Me.txtL)
        Me.GroupBox2.Controls.Add(Me.txtNo)
        Me.GroupBox2.Controls.Add(Me.txtItem)
        Me.GroupBox2.Controls.Add(Me.txtUnit)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(970, 67)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(890, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 20)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Add To List"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Description"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(777, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(704, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Unite Price"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(629, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Qty"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(557, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Depth"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(485, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Width"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(413, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Lenght"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(370, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "No."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Item"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(327, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Unit"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(49, 32)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(275, 20)
        Me.txtDescription.TabIndex = 13
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.LightCyan
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtTotal.Location = New System.Drawing.Point(780, 32)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(104, 20)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(707, 32)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(67, 20)
        Me.txtUnitPrice.TabIndex = 13
        Me.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(632, 32)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(69, 20)
        Me.txtQty.TabIndex = 13
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtD
        '
        Me.txtD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD.Location = New System.Drawing.Point(560, 32)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(66, 20)
        Me.txtD.TabIndex = 13
        Me.txtD.Text = "1"
        '
        'txtW
        '
        Me.txtW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtW.Location = New System.Drawing.Point(488, 32)
        Me.txtW.Name = "txtW"
        Me.txtW.Size = New System.Drawing.Size(66, 20)
        Me.txtW.TabIndex = 13
        Me.txtW.Text = "1"
        '
        'txtL
        '
        Me.txtL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL.Location = New System.Drawing.Point(416, 32)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(66, 20)
        Me.txtL.TabIndex = 13
        Me.txtL.Text = "1"
        '
        'txtNo
        '
        Me.txtNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo.Location = New System.Drawing.Point(373, 32)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(37, 20)
        Me.txtNo.TabIndex = 13
        Me.txtNo.Text = "1"
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(12, 32)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(31, 20)
        Me.txtItem.TabIndex = 13
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(330, 32)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(37, 20)
        Me.txtUnit.TabIndex = 13
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(787, 439)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(199, 20)
        Me.txtSubTotal.TabIndex = 13
        Me.txtSubTotal.Text = "0,00"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(719, 442)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Sub Total"
        '
        'txtTaxeRate
        '
        Me.txtTaxeRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxeRate.Location = New System.Drawing.Point(787, 465)
        Me.txtTaxeRate.Name = "txtTaxeRate"
        Me.txtTaxeRate.ReadOnly = True
        Me.txtTaxeRate.Size = New System.Drawing.Size(199, 20)
        Me.txtTaxeRate.TabIndex = 13
        Me.txtTaxeRate.Text = "16,00"
        Me.txtTaxeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(701, 468)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Tax Rate (%)"
        '
        'txtTVA
        '
        Me.txtTVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTVA.Location = New System.Drawing.Point(787, 491)
        Me.txtTVA.Name = "txtTVA"
        Me.txtTVA.ReadOnly = True
        Me.txtTVA.Size = New System.Drawing.Size(199, 20)
        Me.txtTVA.TabIndex = 13
        Me.txtTVA.Text = "0,00"
        Me.txtTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(723, 494)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "16% TVA"
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Location = New System.Drawing.Point(787, 517)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(199, 20)
        Me.txtGrandTotal.TabIndex = 13
        Me.txtGrandTotal.Text = "0,00"
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(734, 520)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "TOTAL"
        '
        'btnBilling
        '
        Me.btnBilling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBilling.Image = Global.Skybill.My.Resources.Resources.add_file_64px
        Me.btnBilling.Location = New System.Drawing.Point(35, 476)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(41, 41)
        Me.btnBilling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBilling.TabIndex = 15
        Me.btnBilling.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(25, 520)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 13)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Add To List"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(998, 571)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnBilling)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtTVA)
        Me.Controls.Add(Me.txtTaxeRate)
        Me.Controls.Add(Me.txtGrandTotal)
        Me.Controls.Add(Me.txtSubTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btnBilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtBOQ As DateTimePicker
    Friend WithEvents txtBOQFor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBOQNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents txtW As TextBox
    Friend WithEvents txtL As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTaxeRate As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTVA As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents Label19 As Label

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' digits
            Case 44 ' comma
            Case 8 ' backspace
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' digits
            Case 44 ' comma
            Case 8 ' backspace
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' digits
            Case 44 ' comma
            Case 8 ' backspace
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtL.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' digits
            Case 44 ' comma
            Case 8 ' backspace
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtW_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtW.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' digits
            Case 44 ' comma
            Case 8 ' backspace
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' digits
            Case 44 ' comma
            Case 8 ' backspace
            Case Else
                e.Handled = True
        End Select
    End Sub

    Function GetBOQ() As String
        Try
            Dim sdate As String = Now.ToString("MMddyy")
            cn.Open()
            cm = New SqlCommand("select top 1 boqNo from Tablebill where boqNo like '" & sdate & "%' order by id desc", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then GetBOQ = CLng(dr.Item("boqNo").ToString) + 1 Else GetBOQ = sdate & "1001"
            dr.Close()
            cn.Close()

            Return GetBOQ
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
    End Sub

    Friend WithEvents btnBilling As PictureBox

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        txtBOQNo.Text = GetBOQ()
    End Sub

    Sub UpdateBill()
        Dim found As Boolean = False

        cn.Open()
        cm = New SqlCommand("select * from dbo.Tablebill where boqNo like'" & txtBOQNo.Text & "'", cn)
        dr = cm.ExecuteReader
        If dr.HasRows Then found = True Else found = False
        dr.Close()
        cn.Close()

        If found = True Then
            cn.Open()
            cm = New SqlCommand("update dbo.Tablebill set boqDate = @boqDate, billTo = @billTo, address = @address, boqFor = @boqFor, subTotal = @subTotal, taxRate = @taxRate, grandTotal = @grandTotal where @boqNo = @@boqNo", cn)
            With cm.Parameters
                .AddWithValue("@boqDate", dtBOQ.Value)
                .AddWithValue("@billTo", txtbill.Text)
                .AddWithValue("@address", txtaddress.Text)
                .AddWithValue("@boqFor", txtBOQFor.Text)
                .AddWithValue("@subTotal", CDbl(txtSubTotal.Text))
                .AddWithValue("@taxRate", CDbl(txtTaxeRate.Text))
                .AddWithValue("@grandTotal", CDbl(txtGrandTotal.Text))
                .AddWithValue("@boqNo", txtBOQNo.Text)
            End With
            cm.ExecuteNonQuery()
            cn.Close()
        Else
            cn.Open()
            cm = New SqlCommand("insert into dbo.Tablebill (@boqNo, @boqDate, @billTo, @boqFor, @subTotal, @taxRate, @grandTotal, )", cn)
            With cm.Parameters
                .AddWithValue("@boqNo", txtBOQNo.Text)
                .AddWithValue("@boqDate", dtBOQ.Value)
                .AddWithValue("@billTo", txtbill.Text)
                .AddWithValue("@address", txtaddress.Text)
                .AddWithValue("@boqFor", txtBOQFor.Text)
                .AddWithValue("@subTotal", CDbl(txtSubTotal.Text))
                .AddWithValue("@taxRate", CDbl(txtTaxeRate.Text))
                .AddWithValue("@grandTotal", CDbl(txtGrandTotal.Text))
            End With
            cm.ExecuteNonQuery()
            cn.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtbill.Text = String.Empty Or txtaddress.Text = String.Empty Or txtBOQNo.Text = String.Empty Or txtBOQFor.Text = String.Empty Then
                MsgBox("Required missing Field", vbCritical)
                Return
            End If

            If txtItem.Text = String.Empty Or txtDescription.Text = String.Empty Or txtUnit.Text = String.Empty Or txtNo.Text = String.Empty Or txtL.Text = String.Empty Or txtW.Text = String.Empty Or txtD.Text = String.Empty Or txtQty.Text = String.Empty Or txtUnitPrice.Text = String.Empty Or txtTotal.Text = String.Empty Then
                MsgBox("Required missing Field", vbCritical)
                Return
            End If
            cn.Open()
            cm = New SqlCommand("insert into dbo.TableBill_Items (boqNo, Item, Description, unit, no, l, w, d, qty, unitPrice, Total) values (@boqNo, @Item, @Description, @unit, @no, @l, @w, @d, @qty, @unitPrice, @Total)", cn)
            With cm.Parameters
                .AddWithValue("@boqNo", txtBOQNo.Text)
                .AddWithValue("@Item", txtItem.Text)
                .AddWithValue("@Description", txtDescription.Text)
                .AddWithValue("@unit", txtUnit.Text)
                .AddWithValue("@no", txtNo.Text)
                .AddWithValue("@l", txtL.Text)
                .AddWithValue("@w", txtW.Text)
                .AddWithValue("@d", txtD.Text)
                .AddWithValue("@qty", CDbl(txtQty.Text))
                .AddWithValue("@unitPrice", CDbl(txtUnitPrice.Text))
                .AddWithValue("@Total", CDbl(txtTotal.Text))
            End With
            cm.ExecuteNonQuery()
            cn.Close()

            Loadrecords()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Friend WithEvents Label21 As Label

    Sub CalculateTotal()
        Try
            Dim unitPrice As Decimal = Decimal.Parse(txtUnitPrice.Text)
            Dim qty As Decimal = Decimal.Parse(txtQty.Text)
            Dim total As Decimal = unitPrice * qty

            txtTotal.Text = total.ToString("N2")
        Catch ex As Exception
            txtTotal.Text = "0,00"
        End Try
    End Sub

    Dim result As Decimal = 0

    Sub CalculateResult()
        Try
            Dim tb1 As Decimal = Decimal.Parse(txtL.Text)
            Dim tb2 As Decimal = Decimal.Parse(txtW.Text)
            Dim tb3 As Decimal = Decimal.Parse(txtD.Text)
            Dim tb4 As Decimal = Decimal.Parse(txtNo.Text)
            result = tb1 * tb2 * tb3 * tb4
            txtQty.Text = result.ToString("N2")
        Catch ex As Exception
            txtQty.Text = "0,00"
        End Try
    End Sub


    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        CalculateTotal()
    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged
        CalculateTotal()
    End Sub

    Private Sub txtNo_TextChanged(sender As Object, e As EventArgs) Handles txtNo.TextChanged
        CalculateResult()
    End Sub

    Private Sub txtL_TextChanged(sender As Object, e As EventArgs) Handles txtL.TextChanged
        CalculateResult()
    End Sub

    Private Sub txtW_TextChanged(sender As Object, e As EventArgs) Handles txtW.TextChanged
        CalculateResult()
    End Sub

    Private Sub txtD_TextChanged(sender As Object, e As EventArgs) Handles txtD.TextChanged
        CalculateResult()
    End Sub

    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewButtonColumn
    Friend WithEvents Column13 As DataGridViewButtonColumn
    Private txtbill As Object

    Sub Loadrecords()
        Dim _subtotal As Double = 0
        DataGridView1.Rows.Clear()

        Dim i As Integer
        cn.Open()
        cm = New SqlCommand("select * frome dbo.TableBill_Items where boqNo = '" & txtBOQNo.Text & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            _subtotal += CDbl(dr.Item("Total").ToString)
            DataGridView1.Rows.Add(dr.Item("id").ToString, i, dr.Item("boqNo").ToString, dr.Item("Item").ToString, dr.Item("Description").ToString, dr.Item("unit").ToString, dr.Item("no").ToString, dr.Item("l").ToString, dr.Item("w").ToString, dr.Item("d").ToString, Format(CDbl(dr.Item("qty").ToString), "#,##0,00"), Format(CDbl(dr.Item("unitPrice").ToString), "#,##0,00"), Format(CDbl(dr.Item("Total").ToString), "#,##0,00"), "EDIT", "DELETE")
        End While
        dr.Close()
        cn.Close()

        txtSubTotal.Text = Format(_subtotal, "#,##0,00")

        CalculateBill()

    End Sub

    Sub CalculateBill()
        Try
            txtGrandTotal.Text = Format(CDbl(txtSubTotal.Text) + CDbl(txtTVA.Text), "#,##0,00")
        Catch ex As Exception
            txtGrandTotal.Text = "0,00"
        End Try
    End Sub

    Private Sub txtTaxeRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTaxeRate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            UpdateBill()
        End If
    End Sub

End Class
