   M S B A M L   `   `   `  ????T  PRabbit-Minecraft-Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Rabbit_Minecraft_LauncherRabbit_Minecraft_Launcher  5   	   *    $Rabbit_Minecraft_Launcher.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Rabbit_Minecraft_Launcher     5   	   A =Wpf.Ui, Version=2.0.3.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5   	     ? Title$  Rabbit Minecraft Launcher??5	   	   $	??530??6+   $	??950??68    ? Cursor$  ??6D    ? 
ResizeMode$ CanMinimize=?6N   .??5
      ? $??8q?6    ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   .+?5   
   %  Wpf.Ui.Controls.NavigationStore  $??0??5      /  )Wpf.Ui.Controls.Navigation.NavigationBase   SelectedPageIndex$ 0??5         Frame 5      ??  ?? ElementName$ 	MainFrame??   Items 5      $  Wpf.Ui.Controls.NavigationItem  $??主页??5         Icon$ Home24=?5      	   PageTag$
	 home??5      
   PageType-   'Rabbit_Minecraft_Launcher.DashboardPage"
  5        5      $??下载??5      $ AppFolder24=?5      $	 download??5      ,   &Rabbit_Minecraft_Launcher.DownloadPage"
  5        5      $??新闻??5      $ Mail24=?5       $
	 news??5!      (   "Rabbit_Minecraft_Launcher.NewsPage"
  5"         Footer 5%        $??关于??5&      $ 	Library24=?5'      $	 about??5(      )   #Rabbit_Minecraft_Launcher.AboutPage"
  5)        5*      $??设置??5+      $ 
Settings24=?5,      $	 settings??5-      ,   &Rabbit_Minecraft_Launcher.SettingsPage"
  5.      50       ? 51   
   -   5          ?Name$ 	MainFrame??52      $??1??53      $??8,0,0,0q?54      56      57      