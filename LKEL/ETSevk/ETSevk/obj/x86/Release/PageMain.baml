   M S B A M L   `   `   `  ���� 
  ETSevk    ETSevk.PageMain   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $	��314��$	��234��$	��314��$	��234��$	��314��$	��234��  � 
ResizeMode$  NoResize=� � WindowStyle$ 
ToolWindow=� � Topmost . 
 � Top$ 0�� � Left$ 0�� � Title$ Sevkiyat��.���  � RowDefinitions �� $��26 ��� $��0 ��� $��0 ��� �� $��40 �.+�(  "System.Windows.Controls.DatePicker  -   $��DPBaslangic��$
��Left=�$��90��$��0,0,0,0q�  -   $��DPBitis��$
��Left=�$��90��$��92,0,1,0q��� -   $��BtnEkle��$
��Ekle��$��1��$��24��$
��Left=�$��1,3,0,0q�$	��Top=�$��50���� -   $��	BtnDuzelt��$��Düzelt��$��24��$
��Left=�$��54,3,0,0q�$	��Top=�$��50��$��1���� -   $��BtnSil��$	��Sil��$��24��$
��Left=�$��	107,3,0,0q�$	��Top=�$��50��$��1���� -   $��	BtnTazele��$��Tazele��$��24��$
��Left=�$��	186,1,0,0q�$	��Top=�$��0��&   System.Windows.Controls.DataGrid  -   $��DGridSevkBelge��   AutoGenerateColumns .  $��3��$��2q�   
IsReadOnly . 	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 Tarih��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Tarih+ �� StringFormat$ 
dd.MM.yyyy��  $
 Sipariş No�� �� *
SozlesmeNo+  $
 	Müşteri�� �� *
MusteriAdi+  $
 
Açıklama�� �� *
Aciklama+  $
 Personel�� �� *SevkEdenAdi+  $
 Belge No�� �� *	BelgeNo+4  .System.Windows.Controls.DataGridCheckBoxColumn  $
 Farklı Sipariş Kumaşı�� �� *FarkliSiparisOkut+  $
 Logoda�� �� *LogoAktarildiMi+  $
 Müşteri Kodu�� �� *MusteriKodu+�� -	   $��BtnKafes��$��Kafes��$��4��$
��Left=�$��52,1,0,0q�$��51���� -
   $��BtnSevkiyat��$��Sevkiyat��$��4��$
��Left=�$��0,1,0,0q�$��51���� -   $��BtnHamSayim��$��4��$��Right=�$��0,1,55,0q�$��54��.���� $
��Wrap=�$��
Ham Sayım�� �� TextAlignment$ Center=��� -   $��BtnMamulSayim��$��4��$��Right=�$��0,1,0,0q�$��55��.���� $
��Wrap=�$��Mamul Sayım��$ Center=�