   M S B A M L   `   `   `  ���� 
  ETSevk    ETSevk.PageBarkod   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -   $	��314��$	��234��$	��314��$	��234��  � 
ResizeMode$  NoResize=� � WindowStyle$ 
ToolWindow=� � Topmost . 
 � Top$ 0�� � Left$ 0�� � Title �� *
MusteriAdi+.���  � ColumnDefinitions �� $	��93* ��� $
��119* � � RowDefinitions �� $	��31* ��� $
��196* ��� $��25 ��� $	��27* �.+�&   System.Windows.Controls.DataGrid  -   $��DGridOkutulan��   AutoGenerateColumns .  	   
IsReadOnly	 . $��1��$��2��
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Barkod��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Barkod+  $ Tip No�� �� *TipNo+  $ Brüt Metre�� �� *Metre+  $ Renk No�� �� *RenkNo+  $
 Tür�� �� *Tur+  $ Parça Metreler��4  .System.Windows.Controls.DataGridCheckBoxColumn  $ Parça Sayısı��  $ 
Tam Parça��  $ 	Net Metre�� �� *
NetMetre+  $ Dye Batch No���� -   $��	TxtBarkod��$��28��$	��0,1q�$��2���� -   $��BtnBarkodSil��$	��Sil��$��59,0,0,0q�$��3��$��1���� -   $��
BtnKontrol��$��Kontrol��$��3��$��0��$
��Left=�$��50���� -   $��TxtCount��$��2��$
��Left=�$��50��$��11(��� -   $��TxtSum��$��2��$��1��$
��Left=�$	��100��$��11(�