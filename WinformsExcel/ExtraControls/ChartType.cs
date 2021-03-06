﻿/* WinForms Excel library 
 * Copyright (c) 2020,  MSDN.WhiteKnight (https://github.com/MSDN-WhiteKnight) 
 * License: BSD 3-Clause */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Windows Forms Excel Library - ChartType enumeration
 http://smallsoft2.blogspot.ru/
 */

namespace ExtraControls
{
    /// <summary>
    /// Represents Excel chart type
    /// </summary>
    public enum ChartType
    {
        xlXYScatter = -4169,
        xlRadar = -4151,
        xlDoughnut = -4120,
        xl3DPie = -4102,
        xl3DLine = -4101,
        xl3DColumn = -4100,
        xl3DArea = -4098,
        xlArea = 1,
        xlLine = 4,
        xlPie = 5,
        xlBubble = 15,
        xlColumnClustered = 51,
        xlColumnStacked = 52,
        xlColumnStacked100 = 53,
        xl3DColumnClustered = 54,
        xl3DColumnStacked = 55,
        xl3DColumnStacked100 = 56,
        xlBarClustered = 57,
        xlBarStacked = 58,
        xlBarStacked100 = 59,
        xl3DBarClustered = 60,
        xl3DBarStacked = 61,
        xl3DBarStacked100 = 62,
        xlLineStacked = 63,
        xlLineStacked100 = 64,
        xlLineMarkers = 65,
        xlLineMarkersStacked = 66,
        xlLineMarkersStacked100 = 67,
        xlPieOfPie = 68,
        xlPieExploded = 69,
        xl3DPieExploded = 70,
        xlBarOfPie = 71,
        xlXYScatterSmooth = 72,
        xlXYScatterSmoothNoMarkers = 73,
        xlXYScatterLines = 74,
        xlXYScatterLinesNoMarkers = 75,
        xlAreaStacked = 76,
        xlAreaStacked100 = 77,
        xl3DAreaStacked = 78,
        xl3DAreaStacked100 = 79,
        xlDoughnutExploded = 80,
        xlRadarMarkers = 81,
        xlRadarFilled = 82,
        xlSurface = 83,
        xlSurfaceWireframe = 84,
        xlSurfaceTopView = 85,
        xlSurfaceTopViewWireframe = 86,
        xlBubble3DEffect = 87,
        xlStockHLC = 88,
        xlStockOHLC = 89,
        xlStockVHLC = 90,
        xlStockVOHLC = 91,
        xlCylinderColClustered = 92,
        xlCylinderColStacked = 93,
        xlCylinderColStacked100 = 94,
        xlCylinderBarClustered = 95,
        xlCylinderBarStacked = 96,
        xlCylinderBarStacked100 = 97,
        xlCylinderCol = 98,
        xlConeColClustered = 99,
        xlConeColStacked = 100,
        xlConeColStacked100 = 101,
        xlConeBarClustered = 102,
        xlConeBarStacked = 103,
        xlConeBarStacked100 = 104,
        xlConeCol = 105,
        xlPyramidColClustered = 106,
        xlPyramidColStacked = 107,
        xlPyramidColStacked100 = 108,
        xlPyramidBarClustered = 109,
        xlPyramidBarStacked = 110,
        xlPyramidBarStacked100 = 111,
        xlPyramidCol = 112,
    }
}
