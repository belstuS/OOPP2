   M S B A M L   `   `   `  ����G  CTextRedactor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TextRedactorTextRedactor  5   	       TextRedactor.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TextRedactor     5   	     � Icon$4  .Resources/img/Wordpad_icon-icons.com_55518.ico��5   	    � Cursor$$ Resources/img/794063d49b02.cur��5	   	      m_Title � Title# �   5
   	   $	��350��6+   $	��525��68   .��5      � -   5         �Name$
 grip��5      $
��Auto��6   $
��Auto��6&    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��302* �6   �� 5      $
��Auto �6   .+�5   
   o�   Menu#���  6   $��0��6.   menu��.@�5      m�  
 m_File#���  6   $
��Auto��69   .@�5      m�  	 m_New#���  6    m� Command$ ApplicationCommands.New��6<   $
��Left=�6^   $	��160��6y    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5      -   5           Command$	 New��5   )   68   5      m� 5       
 m_Open#���  6   $ ApplicationCommands.Open��6=   $
��Left=�6`   $	��160��6{    5        5      -   5        $
 Open��5   )   69   5      m� 5       
 m_Save#���  6   $ ApplicationCommands.Save��6=   $
��Left=�6a   $	��160��6|    5        5       -   5        $
 Save��5    )   68   5"      5#      m� 5$       
 m_Edit#���  6   $
��Auto��69   .@�5%      m�  
 m_Copy#���  6   $ ApplicationCommands.Copy��6=   $
��Left=�6�   $	��180��6�    m� CommandTarget 6`   �� 	 �� ElementName$	 GG��6�   m� 5&        m_Paste#���  6   $ ApplicationCommands.Paste��6>   $
��Left=�6�   $	��180��6�    6b   �� $	 GG��6�   m� 5'       
	 m_Undo#��� 	 6   $ ApplicationCommands.Undo��6=   $
��Left=�6�   $	��180��6�    6`   �� $	 GG��6�   m� 5(       

 m_Redo#��� 
 6   $ ApplicationCommands.Redo��6=   $
��Left=�6`   $	��180��6{   m� 5)       	 m_Cut#���  6   $ ApplicationCommands.Cut��6<   $
��Left=�6�   $	��180��6�    6^   �� $	 GG��6�   5*      �� 5+      -   5        $��comboBoxLanguage��5+        ComboBox#���  6/   
 �� SelectedIndex$
 0��6R   $��21��6d   $��67��6p   6{   5,      c� 5-   
     ToolBar#���  6   $��1��65   $	��Top=�6B   $��0,0,0,73q�6a   .@�5/      �� d� 50      -   5        $��btnBold��50   @   $ ��EditingCommands.ToggleBold��6   .��51      �� $(��"Resources/img/format_text_bold.png��6   $��23��6D   $��23��6O   52      d� 53      -   5        $��	btnItalic��53   B   $"��EditingCommands.ToggleItalic��6   .��54      �� $*��$Resources/img/format_text_italic.png��6   $��23��6F   $��23��6Q   55      d� 56      -   5        $��btnUnderline��56   E   $%��EditingCommands.ToggleUnderline��6   .��57      �� $-��'Resources/img/format_text_underline.png��6   $��23��6I   $��23��6T   58      �� 59      �� 5;      -	   5        $��ComboFontType��5;      #���  6,   $
 0��6O   $	��150��6a   6m   �� 5<      -
   5        $��ComboFontSize��5<      #���  6,   $
 0��6O   $��50��6a    �� 
IsEditable . 6~   5=      � 5?   
   $��1��6   $��0,34,0,0q�6   $��2��6.   $
��Auto=�6?   $
��Auto=�6q   z�5@      V� 5A      .~�5B      �� $
��Auto=�5E      $
��Auto=�6G    �� ScaleY 5C      ��  �� Path$ Value�$	 slider�� �� ScaleX 5D      �� $ Value�$	 slider��5E   G   5F      .+�5H      �� -   5        $��
rchTextBox��5H      $��Center=�6,   $��Center=�6N   $��Visible=�6�   ��.  J� 	AllowDrop . $ �� HorizontalScrollBarVisibility$
 Auto=�6"  " �� VerticalScrollBarVisibility$
 Auto=�6G  ��6  Z� 6G  5I      c� 5J   
   #���  6   $��Bottom=�64   $��3��6L   .@�5K      �� -   5         ��Name$ positionLabel��5K        
m_Position#���  6+   $��26��6R   $
��Auto��6^   �� 5L      -   5        $ labelCountSymbols��5L      $��0��6/   $��26��6;   $
��Auto��6G   �� 5M      -   5         ��Name$ slider��5M       � Minimum$ 1Q�6%   $	��130��61   $��0,4,0,0q�6=   �� 5N      -   5        $ 	pathLabel��5N       
 m_Path#���  6'   $��24��6J   $	��Top=�6V   $��37��6n   $y�Hidden=�6y   �� 5O      -   5        $ 
pathString��5O      $�� ��6(   $��25��63   $��0,1,0,0q�6?   $	��Top=�6P   $
��Auto��6h   5P      5Q      5R      