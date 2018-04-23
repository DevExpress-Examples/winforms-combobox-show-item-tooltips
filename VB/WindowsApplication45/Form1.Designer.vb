Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication45
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.Location = New System.Drawing.Point(21, 80)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Properties.Items.AddRange(New Object() { "1", "2", "3", "4", "5"})
			Me.comboBoxEdit1.Size = New System.Drawing.Size(203, 20)
			Me.comboBoxEdit1.TabIndex = 2
'			Me.comboBoxEdit1.Popup += New System.EventHandler(Me.comboBoxEdit1_Popup);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(402, 348)
			Me.Controls.Add(Me.comboBoxEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private toolTipController1 As DevExpress.Utils.ToolTipController
		Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace

