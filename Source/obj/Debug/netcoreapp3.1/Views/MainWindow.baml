   M S B A M L   `   `   `  ����=  9Me, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MeMe  5   	   -clr-namespace:Me.ExtensionsMe.Extensions  5   	       Me.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:Me     5   	   +extclr-namespace:Me.Extensions     5   	     � Title$  Vaduganathan��5	   	   $	��450��6   $	��800��6+    � Icon$ /Views/favicon.ico��67   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��100px �6   �� 5      $��8* �6   �� 5      $
��50px �6   �� 5      $��100px �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��50px �6   �� 5      $
��50px �6   �� 5      $
��50px �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��0��6   $��	Question:��6-   �� 5   
   $��1��6   $��1��6   ��6/   �� *
Question+ �� UpdateSourceTrigger$ PropertyChanged=�"   Me.Extensions.FocusExtension   	IsFocused 6n   �� *QuestionFocus+�� 5   
   $��2��6   $��0��6   $��Answer:��6-   �� 5   
   $��2��6   $��1��6   ��6/   �� *Answer+$ PropertyChanged=��� 5   
   $��2��6   $��2��6   $	��✔��6.    �� 	IsDefault$
 True��6A   ��6R   �� *SubmitCommand+�� 5   
   $��2��6   $��3��6   $
 True��6T   ��6.   �� *NextButtonContent+��6e   �� *NextAnswerCommand+y�6�   �� *NextButtonVisibility+�� 5    
   $��3��6   $��0��6   $��5��6/    �� TextWrapping$
 Wrap=�6C    �� AcceptsReturn$
 True��6W   $	 �� HorizontalScrollBarVisibility$	 Disabled=�6l   "
 �� VerticalScrollBarVisibility$

 Auto=�5!      $	��Top=�65   $��14(�6�   $��verdana)�6�   $��Light"�6�    5    �   �� *DisplayAreaFocus+��5!   T   �� *DisplayValue+$ PropertyChanged=�6�   5"      5#      