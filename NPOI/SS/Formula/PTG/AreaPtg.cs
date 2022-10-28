/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) Under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You Under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed Under the License is distributed on an "AS Is" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations Under the License.
==================================================================== */

namespace jp.co.systembase.NPOI.SS.Formula.PTG
{
    using System;
    using jp.co.systembase.NPOI.Util;
    using jp.co.systembase.NPOI.SS.Util;

    /**
     * Specifies a rectangular area of cells A1:A4 for instance.
     * @author Jason Height (jheight at chariot dot net dot au)
     */
    [Serializable]
    public class AreaPtg : Area2DPtgBase
    {

        public const byte sid = 0x25;

        public AreaPtg(int firstRow, int lastRow, int firstColumn, int lastColumn, bool firstRowRelative, bool lastRowRelative, bool firstColRelative, bool lastColRelative)
            : base(firstRow, lastRow, firstColumn, lastColumn, firstRowRelative, lastRowRelative, firstColRelative, lastColRelative)
        {

        }
        public AreaPtg(ILittleEndianInput in1)
            : base(in1)
        {

        }
        public AreaPtg(String arearef)
            : base(arearef)
        {

        }
        public AreaPtg(AreaReference areaRef):base(areaRef)
        {
            
        }
        protected override byte Sid
        {
            get { return sid; }
        }
    }
}