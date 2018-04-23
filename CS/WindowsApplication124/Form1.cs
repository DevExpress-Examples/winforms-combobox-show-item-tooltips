using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors;
using DevExpress.Utils.Win;

namespace WindowsApplication124 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void comboBoxEdit1_Popup(object sender, EventArgs e) {
			PopupListBoxForm form = (sender as IPopupControl).PopupWindow as PopupListBoxForm;
			form.ListBox.MouseMove += ListBox_MouseMove;
			form.ListBox.MouseLeave += ListBox_MouseLeave; 

		}

		private void ListBox_MouseLeave(object sender, EventArgs e) {
			toolTipController1.HideHint();
		}

		private void ListBox_MouseMove(object sender, MouseEventArgs e) {
			PopupListBox listBoxControl = sender as PopupListBox;
			ComboBoxEdit cmb = listBoxControl.OwnerEdit as ComboBoxEdit;
			int index = listBoxControl.IndexFromPoint(new Point(e.X, e.Y));
			if(index == -1) {
				toolTipController1.HideHint();
			} else {
				string item = cmb.Properties.Items[index].ToString();
				toolTipController1.ShowHint(item, listBoxControl.PointToScreen(new Point(e.X, e.Y)));
			}

		} 

	}
}