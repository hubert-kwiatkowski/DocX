/*************************************************************************************

   DocX – DocX is the community edition of Xceed Words for .NET

   Copyright (C) 2009-2016 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   For more features and fast professional support,
   pick up Xceed Words for .NET at https://xceed.com/xceed-words-for-net/

  ***********************************************************************************/

using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace DocXStandard
{
    public class TableCellBorder
    {
        public Dictionary<TableCellBorderType, Border> Collection { get; private set; } = new Dictionary<TableCellBorderType, Border>();

        public Border Top
        {
            get { return Collection.ContainsKey(TableCellBorderType.Top) ? Collection[TableCellBorderType.Top] : null; }
            set { Collection[TableCellBorderType.Top] = value; }
        }

        public Border Bottom
        {
            get { return Collection.ContainsKey(TableCellBorderType.Bottom) ? Collection[TableCellBorderType.Bottom] : null; }
            set { Collection[TableCellBorderType.Bottom] = value; }
        }

        public Border Left
        {
            get { return Collection.ContainsKey(TableCellBorderType.Left) ? Collection[TableCellBorderType.Left] : null; }
            set { Collection[TableCellBorderType.Left] = value; }
        }

        public Border Right
        {
            get { return Collection.ContainsKey(TableCellBorderType.Right) ? Collection[TableCellBorderType.Right] : null; }
            set { Collection[TableCellBorderType.Right] = value; }
        }

        public Border InsideH
        {
            get { return Collection.ContainsKey(TableCellBorderType.InsideH) ? Collection[TableCellBorderType.InsideH] : null; }
            set { Collection[TableCellBorderType.InsideH] = value; }
        }

        public Border InsideV
        {
            get { return Collection.ContainsKey(TableCellBorderType.InsideV) ? Collection[TableCellBorderType.InsideV] : null; }
            set { Collection[TableCellBorderType.InsideV] = value; }
        }

        public Border TopLeftToBottomRight
        {
            get { return Collection.ContainsKey(TableCellBorderType.TopLeftToBottomRight) ? Collection[TableCellBorderType.TopLeftToBottomRight] : null; }
            set { Collection[TableCellBorderType.TopLeftToBottomRight] = value; }
        }

        public Border TopRightToBottomLeft
        {
            get { return Collection.ContainsKey(TableCellBorderType.TopRightToBottomLeft) ? Collection[TableCellBorderType.TopRightToBottomLeft] : null; }
            set { Collection[TableCellBorderType.TopRightToBottomLeft] = value; }
        }
    }

    public class TableBorder
    {
        public Dictionary<TableBorderType, Border> Collection { get; private set; } = new Dictionary<TableBorderType, Border>();

        public Border Top
        {
            get { return Collection.ContainsKey(TableBorderType.Top) ? Collection[TableBorderType.Top] : null; }
            set { Collection[TableBorderType.Top] = value; }
        }

        public Border Bottom
        {
            get { return Collection.ContainsKey(TableBorderType.Bottom) ? Collection[TableBorderType.Bottom] : null; }
            set { Collection[TableBorderType.Bottom] = value; }
        }

        public Border Left
        {
            get { return Collection.ContainsKey(TableBorderType.Left) ? Collection[TableBorderType.Left] : null; }
            set { Collection[TableBorderType.Left] = value; }
        }

        public Border Right
        {
            get { return Collection.ContainsKey(TableBorderType.Right) ? Collection[TableBorderType.Right] : null; }
            set { Collection[TableBorderType.Right] = value; }
        }

        public Border InsideH
        {
            get { return Collection.ContainsKey(TableBorderType.InsideH) ? Collection[TableBorderType.InsideH] : null; }
            set { Collection[TableBorderType.InsideH] = value; }
        }

        public Border InsideV
        {
            get { return Collection.ContainsKey(TableBorderType.InsideV) ? Collection[TableBorderType.InsideV] : null; }
            set { Collection[TableBorderType.InsideV] = value; }
        }
    }

}
