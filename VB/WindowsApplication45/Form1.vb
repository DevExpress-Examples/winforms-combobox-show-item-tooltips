Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.Utils.Win

Namespace WindowsApplication45
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub comboBoxEdit1_Popup(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.Popup
			Dim form As PopupListBoxForm = TryCast((TryCast(sender, IPopupControl)).PopupWindow, PopupListBoxForm)
			AddHandler form.ListBox.MouseMove, AddressOf ListBox_MouseMove
			AddHandler form.ListBox.MouseLeave, AddressOf ListBox_MouseLeave
		End Sub

		Private Sub ListBox_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			toolTipController1.HideHint()
		End Sub

		Private Sub ListBox_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim listBoxControl As PopupListBox = TryCast(sender, PopupListBox)
			Dim cmb As ComboBoxEdit = TryCast(listBoxControl.OwnerEdit, ComboBoxEdit)
			Dim index As Integer = listBoxControl.IndexFromPoint(New Point(e.X, e.Y))
			If index = -1 Then
				toolTipController1.HideHint()
			Else
				Dim item As String = cmb.Properties.Items(index).ToString()
				toolTipController1.ShowHint(item, listBoxControl.PointToScreen(New Point(e.X, e.Y)))

			End If
		End Sub
	End Class
End Namespace