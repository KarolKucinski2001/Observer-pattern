# Observer-pattern
This project is a simple spreadsheet application implemented in C# that allows cells to store integer data ranging from 0 to 255 (byte). 
The spreadsheet also supports basic chart functionality. If the value of the cell observed by the chart changes, the chart is redrawn accordingly. 
A cell can also observe another cell, so if, for instance, cell B1 observes cell A1, the value of cell B1 will automatically update when the value of A1 changes.
