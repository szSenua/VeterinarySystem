   M S B A M L   `   `   `  ????A  =VetSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VetSysVetSys  5   	   =#clr-namespace:VetSys.MVVM.ViewModelVetSys.MVVM.ViewModel  5   	       VetSys.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:VetSys     5   	   9	viewModel#clr-namespace:VetSys.MVVM.ViewModel     5   	   $	??600??5	   	   $	??920??5
   	     ? WindowStyle$
  None=?5   	    ? 
ResizeMode$ NoResize=?5   	   
??????  ? AllowsTransparency .  ? WindowStartupLocation$ CenterScreen=?5   	    ? DataContext 5      )  #VetSys.MVVM.ViewModel.MainViewModel  5   
   .??5      ?? ???#272537 ?? CornerRadius$ 20??5      ._?5   
   ?  ? ColumnDefinitions 5      ?? 5      $	??200 ?6#   ?? 5       ? RowDefinitions 5!      ?? 5"      $??75 ?6    ?? 5#      .+?5'      ?? $??Elyon??6   $??Center=?5(      $
??Left=?5)      
???????$??22(?5+      $??20,0,0,0q?5,      ?? 5.      $??0??6   $??1??5/      $??Right=?50      $??	0,10,10,0q?51      $	??Top=?52      $??30??53      $??30??54      .??55      ?? $??/Images/top.png??6   56      ?? 5;      $??1??6   .+?5=      	? $
??Home??6   $??50??5>      
???????$??14(?5@         MenuButtonTheme#??[  5A       d? 	IsChecked$
 TrueY?5B      ??5C      ?? *HomeViewCommand+	? 5E      $??Search??6   $??50??5F      
???????$??14(?5H      #??[  5I      ??5J      ?? *SearchViewCommand+	? 5L      $??Mascota??6   $??50??5M      
???????$??14(?5O      #??[  5P      ??5Q      ?? *MascotaViewCommand+	? 5S      $??Registro??6   $??50??5T      
???????$??14(?5V      #??[  5W      ??5X      ?? *RegisterViewCommand+5Z      ?? 5^      $	??250??6   $??40??5_      $??Center=?5`      $
??Left=?5a      $??5q?5b      $??1??5c        ModernTextbox#??[ 5d      ?? 5f      $??1??6   $??1??5g      $??10q?5h      ??5i      ?? *CurrentView+5l      5p      5q      