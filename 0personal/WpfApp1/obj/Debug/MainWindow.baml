   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   -clr-namespace:WpfApp1.modelWpfApp1.model  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -modelclr-namespace:WpfApp1.model     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5         Default ?? 
TargetType ?? Property ?? Value  DiffBtnStyle  ExtendedStyle ?? BasedOn   WpfApp1.model.Exp 
 izrazi*   $WpfApp1.model.BaseExponentExpression   BaseNum   Exponent ?? DataType	 ? ColumnDefinitions
 ?? Path??%-  &	        &	 p     &	 ?     7  &	 0    (?? ?    5!      *, +)?? 5   
   " ??6    .?5      ??  ? ??
 ?   ?6+   ?? 5       ? ??
 ??  ?6+   5      ?? 5   
   " ??6   .?5      ??  ? ??
 ????6+   ?? 5       ? ??
 ?????6+   5      ?? 5   
   " ??6   8   .?5      ??  ? ??$ Heavy"?6+   5        5   
     5      $ 2Q?6+   $ 3Q?67     5      $ 76Q?6+   $ 1Q?68     5      $	 133Q?6+   $ 2Q?69   5       ?? 5!   
   "  6   .R?5"      ? 	 5#      ?? 5$      $
??auto ?6'   ?? 5%      $
??auto ?6'   .+?5'      ?? ??6   ?? $
 BaseNum??? 5(      $??1??5)      $??8(?6,   $	??Top=?69   $
??Left=?6Q   ??5(      ?? $
 Exponent?5)   Q   5*      5+      5-      .??50      ?  ? ShowGridLines . 	 52   
   ?? 53      6!   ?? 54      6!    ? RowDefinitions 56   
   ?? 57      6   ?? 58      6   .+?5;   
   ?? $??106,44,56,35q?6   $??1??6(    5<      ??%h   '??       ?? 5=      " ??6   .?5?      ??  ?@??CornerRadius$ 50??65   5A      5B      5D      5E      ?? 5F   
   $??Button??6   $
??Left=?6#   $??
88,110,0,0q?6>   $	??Top=?6R   $	??122??6j   $??44??6v   $??1??6?   ?? 5G   
   #??[ 6   $??Button1??67   $??106,116,160,62q?6I   $??0??6a   ? 5H   
   $??1??6   $??1??6    ? DataContext# [ 6,   .+?5I      ?? ??6   ?? 5J      5L      5N      