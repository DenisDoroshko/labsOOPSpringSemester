   M S B A M L   `   `   `  ���� =  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI      UI.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     "localclr-namespace:UI       � Title$  
MainWindow��$	��450��$	��800�� � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=�.��� -    �Name$
 Main�����	#FF4876D8.+�&   System.Windows.Controls.DataGrid  -     Name$ 	showTable��$��Center=�$	��184��$��119,95,103,0q�$	��Top=�$	��572��$��Disabled=�   
IsReadOnly .    ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � ��	 �� Value$	 Center=�
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$
 Name�  $ Owner organization��$	 140  �� $ OwnerOrganization�  $
 Cost��$	 140  �� $
 Cost�  $ Production year��$	 140  �� $ ProductionYear��� -    ��Name$ selectButton��$��Select file��$��Center=�$��441,367,213,0q�$	��Top=�$	��140��$��34��$��20(�$
��Bold"����	#FFDDDDDD�� -   $ deleteButton��$��Delete��$��Center=�$��551,299,103,0q�$	��Top=�$	��140��$��34��$��20(�$
��Bold"����	#FFDDDDDD�� -   $ 
saveButton��$
��Save��$��Center=�$��257,367,397,0q�$	��Top=�$	��140��$��34��$��20(�$
��Bold"� J� RenderTransformOrigin$ 0.8,0.5&����	#FFDDDDDD�� -   $ 	addButton��$	��Add��$��Center=�$��119,299,535,0q�$	��Top=�$	��140��$��34��$��20(�$
��Bold"����	#FFDDDDDD�� -   $ 
editButton��$
��Edit��$��Center=�$��329,299,325,0q�$	��Top=�$	��140��$��34��$��20(�$
��Bold"����	#FFDDDDDD�� $
��Left=�$��62��$	��Top=�$	��794�����	#FF145CA4.+��� $��Equipment guide�����	#FFE5E7F0$��30(�$
��Bold"�$��Center=�$��Center=�