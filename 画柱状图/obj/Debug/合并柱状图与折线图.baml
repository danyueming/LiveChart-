   M S B A M L   `   `   `  ����G  C画柱状图, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:画柱状图画柱状图  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      .    (画柱状图.合并柱状图与折线图   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:画柱状图     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      .��5
      � .+�5   
   #  LiveCharts.Wpf.CartesianChart  -   5        $��chartSeries1��5        K� ZIndex$  1��62   
������ $��0,0,0,20q�6]   &   LiveCharts.Wpf.Charts.Base.Chart   AxisX 5        LiveCharts.Wpf.Axis     FontSize$ 16Q�6      
Foreground
 �   �   Labels9  3LiveCharts.Wpf.Converters.StringCollectionConverter$   6<      	Separator 5        LiveCharts.Wpf.Separator  5      -   5          Name$ X_Separator��5   (   5   C   5         AxisY 5        $ 16Q�6   
 �\\�� 5        5      -   5        $ ColumnY_Separator��5   (   6_   5         Series 5      !  LiveCharts.Wpf.ColumnSeries  -   5        	  Name$	 myColumn��5   #     LiveCharts.Wpf.Series
   Title$
  ��65      Fill
 ��+��   Values 5    #   �� *ColumnValues1+5!   #   5#        5$   
   -   5        $��chartSeries2��5$      $  0��62   
������  5&        $ 16Q�6   
 �   � 5'        5(      -   5        $ X_Separator2��5(   (   5*   C   5,       5/        $ 16Q�6   
 �\\��   Position$ RightTop=�6@    50        51      -   5        $ CurveY_Separator��51   (   6]   53       58        LiveCharts.Wpf.LineSeries  -   5          Name$ myLine��59   !   $
  ��61      PointGeometrySize$ 0Q�5;   !   $  2��5<   !      LineSmoothness$ 1Q�5=   !    5>   !   �� *LineValues2+5@      5A      5B      