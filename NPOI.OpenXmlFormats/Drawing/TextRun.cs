// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NPOI.OpenXmlFormats.Dml</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace jp.co.systembase.NPOI.OpenXmlFormats.Dml
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using jp.co.systembase.NPOI.OpenXml4Net.Util;
    using System.Xml;
    using System.IO;


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public partial class CT_RegularTextRun
    {

        private CT_TextCharacterProperties rPrField;

        private string tField;
        public static CT_RegularTextRun Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_RegularTextRun ctObj = new CT_RegularTextRun();
            
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.LocalName == "rPr")
                    ctObj.rPr = CT_TextCharacterProperties.Parse(childNode, namespaceManager);
                else if (childNode.LocalName == "t")
                    ctObj.t = childNode.InnerText;
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            sw.Write(">");
            if (this.rPr != null)
                this.rPr.Write(sw, "rPr");
            if(this.t !=null)
            {
                sw.Write("<a:t>");
                sw.Write(XmlHelper.EncodeXml(t));
                sw.Write("</a:t>");
            }
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        public CT_RegularTextRun()
        {
            
        }
        public CT_TextCharacterProperties AddNewRPr()
        {
            this.rPrField = new CT_TextCharacterProperties();
            return rPrField;
        }
        [XmlElement(Order = 0)]
        public CT_TextCharacterProperties rPr
        {
            get
            {
                return this.rPrField;
            }
            set
            {
                this.rPrField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string t
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
            }
        }
    }

}
