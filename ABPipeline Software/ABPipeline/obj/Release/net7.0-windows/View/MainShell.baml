   M S B A M L   `   `   `  ???? G  CAlbert.Win32, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS9clr-namespace:Albert.Win32.Controls;assembly=Albert.Win32Albert.Win32.Controls  A0clr-namespace:Albert.Win32;assembly=Albert.Win32Albert.Win32  E AABPipeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ABPipeline.ControlsABPipeline.Controls    ABPipeline.View.MainShell   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Gc9clr-namespace:Albert.Win32.Controls;assembly=Albert.Win32     >w0clr-namespace:Albert.Win32;assembly=Albert.Win32     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:ABPipeline.Controls     $	??450??$	??800??  ? Title  ?? *Title+.???  ? RowDefinitions ?? $
??auto ??? ?? $
??auto ?.+?o? -    o?Name$ mainMenu??.@?m? $
??File??.@?m?  m? Command$	 New??m? $
 Open??m? $
 Save??m? $ w:DesktopCommands.SaveAs???? m? $ w:DesktopCommands.Import??m? $ w:DesktopCommands.Export???? m? $ w:DesktopCommands.Quit??m? $
??Edit??.@?m? $	 Cut??m? $
 Copy??m? $ Paste???? m? $ 	SelectAll??m? $
??View??.@?m? -    m?Name$ statusMenuItem?? m? 	IsChecked$
 True?? m? IsCheckable$
 True??$??Show StatusBar??m? $??Tools??.@?m? $ w:DesktopCommands.LogInfo??m? $??Window??.@?m? $??Design Pipeline??
 ? Tag$ Design??m? $??Media Pipeline??$ Media??m? $??Notes Pipeline??$ Notes??m? $??YouTube Pipeline??$ YouTube??m? $
??Help??.@?m? $ w:DesktopCommands.About??%   Albert.Win32.Controls.ViewFrame  -     Name$ 	mainFrame??$??1???? -   	 ??Name$	 	statusBar??$??2??.@??? $??Status:???? -   
 ??Name$
 statusTextBlock??