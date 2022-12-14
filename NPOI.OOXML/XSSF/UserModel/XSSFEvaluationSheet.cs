/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

using jp.co.systembase.NPOI.SS.Formula;
using jp.co.systembase.NPOI.SS.UserModel;
namespace jp.co.systembase.NPOI.XSSF.UserModel
{

    /**
     * XSSF wrapper for a sheet under Evaluation
     * 
     * @author Josh Micich
     */
    public class XSSFEvaluationSheet : IEvaluationSheet
    {

        private XSSFSheet _xs;

        public XSSFEvaluationSheet(ISheet sheet)
        {
            _xs = (XSSFSheet)sheet;
        }

        public XSSFSheet GetXSSFSheet()
        {
            return _xs;
        }
        public IEvaluationCell GetCell(int rowIndex, int columnIndex)
        {
            IRow row = _xs.GetRow(rowIndex);
            if (row == null)
            {
                return null;
            }
            ICell cell = row.GetCell(columnIndex);
            if (cell == null)
            {
                return null;
            }
            return new XSSFEvaluationCell(cell, this);
        }
    }
}

