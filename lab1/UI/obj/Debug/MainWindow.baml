   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ CanMinimize=�65    � WindowStartupLocation$ CenterScreen=�6N   .��5	      � -   5         �Name$
 Main��5	      ���	#FF4876D8.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	showTable��5
      $��Center=�6&   $	��184��6C   $��119,95,103,0q�6P   $	��Top=�6f   $	��572��6~   $��Disabled=�6�      
IsReadOnly .    ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  �� Property � ��	 �� Value$	 Center=�6C   5      
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ��  �� Path$
 Name�6Q     5      $ Owner organization��6%   $	 140 6l    6A   �� $ OwnerOrganization�6l     5      $
 Cost��6%   $	 140 6Q    63   �� $
 Cost�6Q     5      $ Production year��6%   $	 140 6f    6>   �� $ ProductionYear�6f   5      �� 5   
   -   5         ��Name$ selectButton��5      $��Select file��6'   $��Center=�6=   $��441,367,213,0q�6Z   $	��Top=�6q   $	��140��6�   $��34��6�   $��20(�6�   $
��Bold"�6�   ���	#FFDDDDDD6�   �� 5   
   -   5        $ deleteButton��5      $��Delete��6'   $��Center=�68   $��551,299,103,0q�6U   $	��Top=�6l   $	��140��6�   $��34��6�   $��20(�6�   $
��Bold"�6�   ���	#FFDDDDDD6�   �� 5   
   -   5        $ 
saveButton��5      $
��Save��6%   $��Center=�64   $��257,367,397,0q�6Q   $	��Top=�6h   $	��140��6�   $��34��6�   $��20(�6�   $
��Bold"�6�    J� RenderTransformOrigin$ 0.8,0.5&�6�   ���	#FFDDDDDD6�   �� 5   
   -   5        $ 	addButton��5      $	��Add��6$   $��Center=�62   $��119,299,535,0q�6O   $	��Top=�6f   $	��140��6~   $��34��6�   $��20(�6�   $
��Bold"�6�   ���	#FFDDDDDD6�   �� 5   
   -   5        $ 
editButton��5      $
��Edit��6%   $��Center=�64   $��329,299,325,0q�6Q   $	��Top=�6h   $	��140��6�   $��34��6�   $��20(�6�   $
��Bold"�6�   ���	#FFDDDDDD6�   �� 5   
   $
��Left=�6   $��62��60   $	��Top=�6<   $	��794��6T   ���	#FF145CA4.+�5      �� $��Equipment guide��6   ���	#FFE5E7F0$��30(�6E   $
��Bold"�6S   $��Center=�6e   $��Center=�6�   5      5      5       