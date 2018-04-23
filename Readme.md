# How to show a tooltip for a ComboBoxEdit item


<p>You should use the ToolTipController.ShowHint method to show an item tooltip. To get the item the mouse pointer is hovering <br />
over, use the PopupListBox.IndexFromPoint method. In the ListBox.MouseMove event handler, show your tooltip.</p>

<br/>


