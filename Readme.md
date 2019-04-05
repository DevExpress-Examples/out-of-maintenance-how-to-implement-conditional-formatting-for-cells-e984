<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to: Implement conditional formatting for cells


<p>The following sample demonstrates how to change the appearance of grid cells in a certain column based upon some condition. For example, in this tutorial you can see that the background color of cells in the second column is gradually changed based on the value in this cell.</p>


<h3>Description</h3>

This is done by binding the <strong>Background</strong> property of a style, assigned to a column, to a color converter. This converter is represented by the <strong>ColorValueConverter</strong> class that implements the <strong>IValueConverter</strong> interface and returns a color based on the provided numerical value.

<br/>


