   M S B A M L   `   `   `  ����G  CDataImporter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DataImporterDataImporter  5   	       DataImporter.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DataImporter     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��871��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��15* �6   �� 5      $
��200* �6   �� 5      $
��227* �6   �� 5      $
��126* �6   �� 5      $	��15* �6    � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $
��153* �6   .+�5   
   �� $��0��6   $��1��6   $��Center=�6-   $��15(�6H   $
��Bold"�6V   $!��Text importer / parser tool��6h   $��2��6�   $��81,12,10,11q�6�   �� 5   
   $��3��6   $��1��6   $��Center=�6-   $��15(�6H   $��30��6V   $��
0,12,10,12q�6b   $��Folder locations:��6v   �� 5   
   -   5         ��Name$ lbFilePaths��5      $��4��6'   $��1��64   $��2��6D   .@�5      �� .��6   20\\pcma2060\D\CW\manuser\HistoricalWaferDataLogs\6L   �� 5      .��6   20\\pcma3020\D\CW\manuser\HistoricalWaferDataLogs\6L   �� 5       .��6   20\\pcma3076\D\CW\manuser\HistoricalWaferDataLogs\6L   �� 5!      .��6   20\\pcma3210\D\CW\manuser\HistoricalWaferDataLogs\6L   �� 5#      .��6   20\\pcma3378\D\CW\manuser\HistoricalWaferDataLogs\6L   �� 5$      .��6   20\\pcma3880\D\CW\manuser\HistoricalWaferDataLogs\6L   �� 5%      .��6   20\\pcma4259\D\CW\manuser\HistoricalWaferDataLogs\6L   �� 5&      .��6   20\\pcma4319\D\CW\manuser\HistoricalWaferDataLogs\6L   5*      �� 5,   
   $��1��6   $��3��6   $��15(�6-   .��6;   File extension:6L   �� 5-   
   -   5        $��txtExtension��5-      $��2��6&   $��3��63   $��Center=�6C   $��Center=�6e   $��15(�6�   $	��txt��6�   ���	#FFDEE9F76�   � 50   
   $��3��6   $��1��6   $��1��6,    51      �� 52      $
��121* �6#   �� 53      $
��240* �6#   56      �� 57   
   -   5         ��Name$ btnStop��57      $��Stop Import��6"   $��2��68   $��2��6H   
�������$��
184,2,0,52q�6~   $��2��6�   ��58      �� 59       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5:      �  � Color$ 	#FFC10000��6#    � Offset$ 1Q�65   � 5;      $ 	#FFAE0404��6#   5<      5>      �� 5?   
   -   5        $ lboxInfo��5?      $��2��6$   $��4��64   $��2��6A   ���	#FFDEE8EA6U   �� 5@   
   -   5        $ btnStart��5@      $��Start Import��6#   $��2��6:   
�������$��	5,1,157,0q�6t   $��2��6�   ��5A      �� 5B      $ 0.5,1&�6&   $ 0.5,0&�67   .��5C      � $ 	#FF08B200��6#   $ 0Q�65   � 5D      $ 	#FF056600��6#   $ 1Q�65   5E      5G      5H      5I      