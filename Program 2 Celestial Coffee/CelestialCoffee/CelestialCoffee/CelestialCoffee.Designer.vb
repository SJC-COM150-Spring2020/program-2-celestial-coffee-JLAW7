<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CelestialCoffee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CelestialCoffee))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblSts = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblCoffee = New System.Windows.Forms.Label()
        Me.lblRegular = New System.Windows.Forms.Label()
        Me.lblDecaf = New System.Windows.Forms.Label()
        Me.txtRegular = New System.Windows.Forms.TextBox()
        Me.txtDecaf = New System.Windows.Forms.TextBox()
        Me.lblLBS = New System.Windows.Forms.Label()
        Me.lblLBS2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtConfirmation = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblCelestial = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Jokerman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(95, 588)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Jokerman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(96, 620)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(62, 20)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.BackColor = System.Drawing.Color.Transparent
        Me.lblCity.Font = New System.Drawing.Font("Jokerman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.White
        Me.lblCity.Location = New System.Drawing.Point(96, 652)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(36, 20)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "City"
        '
        'lblSts
        '
        Me.lblSts.AutoSize = True
        Me.lblSts.BackColor = System.Drawing.Color.Transparent
        Me.lblSts.Font = New System.Drawing.Font("Jokerman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSts.ForeColor = System.Drawing.Color.White
        Me.lblSts.Location = New System.Drawing.Point(95, 683)
        Me.lblSts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSts.Name = "lblSts"
        Me.lblSts.Size = New System.Drawing.Size(42, 20)
        Me.lblSts.TabIndex = 3
        Me.lblSts.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.BackColor = System.Drawing.Color.Transparent
        Me.lblZip.Font = New System.Drawing.Font("Jokerman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.ForeColor = System.Drawing.Color.White
        Me.lblZip.Location = New System.Drawing.Point(96, 716)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(67, 20)
        Me.lblZip.TabIndex = 4
        Me.lblZip.Text = "Zip Code"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(208, 586)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(132, 22)
        Me.txtName.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(208, 618)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(132, 22)
        Me.txtAddress.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(208, 650)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(132, 22)
        Me.txtCity.TabIndex = 7
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(208, 682)
        Me.txtState.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(132, 22)
        Me.txtState.TabIndex = 8
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(208, 714)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(132, 22)
        Me.txtZip.TabIndex = 9
        '
        'lblCoffee
        '
        Me.lblCoffee.AutoSize = True
        Me.lblCoffee.BackColor = System.Drawing.Color.Transparent
        Me.lblCoffee.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoffee.ForeColor = System.Drawing.Color.White
        Me.lblCoffee.Location = New System.Drawing.Point(172, 158)
        Me.lblCoffee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCoffee.Name = "lblCoffee"
        Me.lblCoffee.Size = New System.Drawing.Size(508, 26)
        Me.lblCoffee.TabIndex = 10
        Me.lblCoffee.Text = "Please Input Coffee Amount Desired, Then Click Calculate."
        '
        'lblRegular
        '
        Me.lblRegular.AutoSize = True
        Me.lblRegular.BackColor = System.Drawing.Color.Transparent
        Me.lblRegular.Font = New System.Drawing.Font("Jokerman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegular.ForeColor = System.Drawing.Color.White
        Me.lblRegular.Location = New System.Drawing.Point(96, 228)
        Me.lblRegular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegular.Name = "lblRegular"
        Me.lblRegular.Size = New System.Drawing.Size(60, 20)
        Me.lblRegular.TabIndex = 11
        Me.lblRegular.Text = "Regular"
        '
        'lblDecaf
        '
        Me.lblDecaf.AutoSize = True
        Me.lblDecaf.BackColor = System.Drawing.Color.Transparent
        Me.lblDecaf.Font = New System.Drawing.Font("Jokerman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecaf.ForeColor = System.Drawing.Color.White
        Me.lblDecaf.Location = New System.Drawing.Point(96, 295)
        Me.lblDecaf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDecaf.Name = "lblDecaf"
        Me.lblDecaf.Size = New System.Drawing.Size(44, 20)
        Me.lblDecaf.TabIndex = 12
        Me.lblDecaf.Text = "Decaf"
        '
        'txtRegular
        '
        Me.txtRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegular.Location = New System.Drawing.Point(208, 228)
        Me.txtRegular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRegular.Name = "txtRegular"
        Me.txtRegular.Size = New System.Drawing.Size(132, 22)
        Me.txtRegular.TabIndex = 13
        Me.txtRegular.Text = "0"
        Me.txtRegular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDecaf
        '
        Me.txtDecaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecaf.Location = New System.Drawing.Point(208, 295)
        Me.txtDecaf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDecaf.Name = "txtDecaf"
        Me.txtDecaf.Size = New System.Drawing.Size(132, 22)
        Me.txtDecaf.TabIndex = 14
        Me.txtDecaf.Text = "0"
        Me.txtDecaf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLBS
        '
        Me.lblLBS.AutoSize = True
        Me.lblLBS.BackColor = System.Drawing.Color.Transparent
        Me.lblLBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLBS.ForeColor = System.Drawing.Color.Black
        Me.lblLBS.Location = New System.Drawing.Point(351, 232)
        Me.lblLBS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLBS.Name = "lblLBS"
        Me.lblLBS.Size = New System.Drawing.Size(29, 16)
        Me.lblLBS.TabIndex = 15
        Me.lblLBS.Text = "lbs"
        '
        'lblLBS2
        '
        Me.lblLBS2.AutoSize = True
        Me.lblLBS2.BackColor = System.Drawing.Color.Transparent
        Me.lblLBS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLBS2.ForeColor = System.Drawing.Color.Black
        Me.lblLBS2.Location = New System.Drawing.Point(351, 300)
        Me.lblLBS2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLBS2.Name = "lblLBS2"
        Me.lblLBS2.Size = New System.Drawing.Size(29, 16)
        Me.lblLBS2.TabIndex = 16
        Me.lblLBS2.Text = "lbs"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Jokerman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(95, 425)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(79, 20)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "Total Price"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(177, 354)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 35)
        Me.btnCalculate.TabIndex = 19
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(208, 423)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(132, 22)
        Me.txtTotal.TabIndex = 20
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(260, 537)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(328, 26)
        Me.lblInfo.TabIndex = 21
        Me.lblInfo.Text = "Please Enter Your Information Below."
        '
        'txtConfirmation
        '
        Me.txtConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmation.Location = New System.Drawing.Point(487, 588)
        Me.txtConfirmation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtConfirmation.Multiline = True
        Me.txtConfirmation.Name = "txtConfirmation"
        Me.txtConfirmation.Size = New System.Drawing.Size(239, 148)
        Me.txtConfirmation.TabIndex = 22
        Me.txtConfirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(177, 769)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(100, 35)
        Me.btnConfirm.TabIndex = 23
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblCelestial
        '
        Me.lblCelestial.AutoSize = True
        Me.lblCelestial.BackColor = System.Drawing.Color.Transparent
        Me.lblCelestial.Font = New System.Drawing.Font("Jokerman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelestial.ForeColor = System.Drawing.Color.White
        Me.lblCelestial.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCelestial.Location = New System.Drawing.Point(291, 71)
        Me.lblCelestial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelestial.Name = "lblCelestial"
        Me.lblCelestial.Size = New System.Drawing.Size(297, 51)
        Me.lblCelestial.TabIndex = 24
        Me.lblCelestial.Text = "Celestial Coffee"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(477, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'CelestialCoffee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 827)
        Me.Controls.Add(Me.lblCelestial)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtConfirmation)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblLBS2)
        Me.Controls.Add(Me.lblLBS)
        Me.Controls.Add(Me.txtDecaf)
        Me.Controls.Add(Me.txtRegular)
        Me.Controls.Add(Me.lblDecaf)
        Me.Controls.Add(Me.lblRegular)
        Me.Controls.Add(Me.lblCoffee)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblSts)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Jokerman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CelestialCoffee"
        Me.Text = "Celestial Coffee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblSts As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents lblCoffee As Label
    Friend WithEvents lblRegular As Label
    Friend WithEvents lblDecaf As Label
    Friend WithEvents txtRegular As TextBox
    Friend WithEvents txtDecaf As TextBox
    Friend WithEvents lblLBS As Label
    Friend WithEvents lblLBS2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents txtConfirmation As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblCelestial As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
