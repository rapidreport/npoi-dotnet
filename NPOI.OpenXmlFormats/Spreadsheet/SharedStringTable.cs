// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using jp.co.systembase.NPOI.OpenXml4Net.Util;

namespace jp.co.systembase.NPOI.OpenXmlFormats.Spreadsheet
{






    public enum FontElementNameType
    {
        b,
        charset,
        color,
        condense,
        extend,
        family,
        i,
        name,
        outline,
        rFont,
        scheme,
        shadow,
        strike,
        sz,
        u,
        vertAlign
    }


    /// <summary>
    /// Rich Text Phonetic Run
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main",
        ElementName = "rPh",
        IsNullable = false)]
    public class CT_PhoneticRun
    {

        private string tField;

        private uint sbField;

        private uint ebField;
        [XmlAttribute]
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
        [XmlAttribute]
        public uint sb
        {
            get
            {
                return this.sbField;
            }
            set
            {
                this.sbField = value;
            }
        }
        [XmlAttribute]
        public uint eb
        {
            get
            {
                return this.ebField;
            }
            set
            {
                this.ebField = value;
            }
        }
        public static CT_PhoneticRun Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PhoneticRun ctObj = new CT_PhoneticRun();
            ctObj.t = XmlHelper.ReadString(node.Attributes["t"]);
            ctObj.sb = XmlHelper.ReadUInt(node.Attributes["sb"]);
            ctObj.eb = XmlHelper.ReadUInt(node.Attributes["eb"]);
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "t", this.t);
            XmlHelper.WriteAttribute(sw, "sb", this.sb);
            XmlHelper.WriteAttribute(sw, "eb", this.eb);
            sw.Write("/>");
        }

    }

    /// <summary>
    /// Properties of the Rich Text Phonetic Run
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main",
        ElementName = "phoneticPr",
        IsNullable = false)]
    public class CT_PhoneticPr
    {
        private uint fontIdField;

        private ST_PhoneticType typeField;

        private ST_PhoneticAlignment alignmentField;

        public static CT_PhoneticPr Parse(XmlNode node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PhoneticPr ctObj = new CT_PhoneticPr();
            ctObj.fontId = XmlHelper.ReadUInt(node.Attributes["fontId"]);
            if (node.Attributes["type"] != null)
                ctObj.type = (ST_PhoneticType)Enum.Parse(typeof(ST_PhoneticType), node.Attributes["type"].Value);
            if (node.Attributes["alignment"] != null)
                ctObj.alignment = (ST_PhoneticAlignment)Enum.Parse(typeof(ST_PhoneticAlignment), node.Attributes["alignment"].Value);
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "fontId", this.fontId,true);
            XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
            if(this.alignment!= ST_PhoneticAlignment.left)
                XmlHelper.WriteAttribute(sw, "alignment", this.alignment.ToString());
            sw.Write("/>");
        }


        public CT_PhoneticPr()
        {
            this.typeField = ST_PhoneticType.fullwidthKatakana;
            this.alignmentField = ST_PhoneticAlignment.left;
        }
        [XmlAttribute]
        public uint fontId
        {
            get
            {
                return this.fontIdField;
            }
            set
            {
                this.fontIdField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(ST_PhoneticType.fullwidthKatakana)]
        public ST_PhoneticType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(ST_PhoneticAlignment.left)]
        public ST_PhoneticAlignment alignment
        {
            get
            {
                return this.alignmentField;
            }
            set
            {
                this.alignmentField = value;
            }
        }
    }

    public enum ST_PhoneticType
    {


        halfwidthKatakana,


        fullwidthKatakana,


        Hiragana,


        noConversion,
    }

    public enum ST_PhoneticAlignment
    {


        noControl,


        left,


        center,


        distributed,
    }
}
