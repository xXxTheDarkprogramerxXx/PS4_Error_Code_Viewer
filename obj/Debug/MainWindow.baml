   M S B A M L   `   `   `  ����P  LPS4_Error_Code_Viewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PS4_Error_Code_ViewerPS4_Error_Code_Viewer  5   	   &     PS4_Error_Code_Viewer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PS4_Error_Code_Viewer     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $��721.8��6)    � Icon$$ Resources/Playstation Icon.ico��5	   	   .��5      (� .��5   
   � $��721.5��6   .+�5   
   �� -   5         ��Name$ label��5      $��Search :��6   $
��Left=�62   $��	10,10,0,0q�6M   $	��Top=�6`   �� 5   
   -   5         ��Name$ 	txtSearch��5      $
��Left=�6%   $��23��6@   $��	66,10,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��645��6�   6�   �� 5   
   -   5        $ lblCopy��5      $��by xDPx��6!   $
��Left=�63   $��
16,291,0,0q�6N   $	��Top=�6b   
����  �6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dataGrid��5         AutoGenerateColumns .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6E   $
��Left=�6m   $��	10,38,0,0q�6�   $	��Top=�6�   $	��248��6�   $	��702��6�   ��6U   �� 6�   5      5      5      