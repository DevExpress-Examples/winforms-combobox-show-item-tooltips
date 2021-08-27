<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1334)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication124/Form1.cs)
* [Program.cs](./CS/WindowsApplication124/Program.cs)
<!-- default file list end -->
# How to show a tooltip for a ComboBoxEdit item


<p>You should use the ToolTipController.ShowHint method to show an item tooltip. To get the item the mouse pointer is hovering 
<br />
over, use the PopupListBox.IndexFromPoint method. In the ListBox.MouseMove event handler, show your tooltip.</p>

<br/>


