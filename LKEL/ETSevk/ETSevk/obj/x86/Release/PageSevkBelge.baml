   M S B A M L   `   `   `  ���� 
  ETSevk    ETSevk.PageSevkBelge   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -   $	��314��$	��234��$	��314��$	��234��$	��314��$	��234��  � 
ResizeMode$  NoResize=� � WindowStyle$ 
ToolWindow=� � Topmost . 
 � Top$ 0�� � Left$ 0��.���  � RowDefinitions �� $��0 ��� $��28 ��� $��28 ��� $��28 ��� $��28 ��� $��28 ��� $��28 ��� $��0 ��� $��28 ��� $��28 ���  � ColumnDefinitions �� $��80 ��� .+��� $��Tarih :��$
��Bold"�$��1��$��28��$
��Left=�$	��Top=��� $��Açıklama :��$
��Bold"�$��2��$��28��$
��Left=�$	��Top=��� $��
Belge No :��$
��Bold"�$��3��$��28��$
��Left=�$	��Top=��� $��Sevk Eden :��$
��Bold"�$��4��$��28��$
��Left=�$	��Top=��� $��Müşteri :��$
��Bold"�$��5��$��28��$
��Left=�$	��Top=��� $��Sipariş No :��$
��Bold"�$��6��$��28��$
��Left=�$	��Top=�(  "System.Windows.Controls.DatePicker  -   $��DpTarih��$��1��$��1��$��25��$
��Left=�$	��Top=�$	��115��   SelectedDate �� *Tarih+�� -   $��TxtAciklama��$��1��$��2��$��23��$��0,3,5,0q�$	��Top=����� *
Aciklama+�� -   $��
TxtBelgeNo��$��1��$��3��$��23��$��0,3,5,0q�$	��Top=����� *	BelgeNo+�� -   $��CmbSevkEden�� �� DisplayMemberPath$	 Adi��	 �� SelectedValuePath$	 Id��$��1��$��4��$��23��$��0,3,5,0q�$	��Top=�
����ح�
 �� SelectedValue
 �� *
SevkEdenId+ �� UpdateSourceTrigger$ PropertyChanged=��� -   $��
CmbMusteri��$ FirmaAdi��$	 FirmaId��
����ح�$��23��$��0,3,5,0q�$	��Top=�$��1��$��5��
 �� *	MusteriId+$ PropertyChanged=��� -   $��
CmbSiparis��$ 
SozlesmeNo��$	 Id��
����ح�$��23��$��0,3,5,0q�$	��Top=�$��1��$��6��
 �� *	SiparisId+$ PropertyChanged=��� $��2��$��8�� �� Orientation$ 
Horizontal=�.+��� $,��&Farklı Siparişin Kumaşını sevk et��$
��Bold"��� -   $��CheckFarkliSiparisKumasi��$��0,8, 0,0q� d� 	IsChecked �� *FarkliSiparisOkut+$ PropertyChanged=��� $��2��$��9��$ 
Horizontal=�.+��� $)��#Tip/Renk No Kontrol devre dışı  ��$
��Bold"��� -	   $��CheckTipRenkDevreDisi��$	��0,6q� �� *TipRenkKontrolDevreDisi+$ PropertyChanged=��� -
   $��	BtnKaydet��$��Kaydet��$��10��$��37��$��Right=�$��0,8,97,0q�$	��Top=�$��75��$��2���� -   $��	BtnVazgec��$��Vazgeç��$��37��$��Right=�$��0,8,5,0q�$	��Top=�$��75��$��1��$��10��