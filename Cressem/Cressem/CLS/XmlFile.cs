using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


//ini파일 대용, single-node 읽고,쓰기만 구현

namespace CLS
{
    public class CXmlFile
    {
        private XmlDocument m_doc = new XmlDocument();
        private string m_strPath;

        //---------------------------------------------------------------------
        public CXmlFile(string strPath)
        {
            // ex) string m_strDBfile = (System.Environment.CurrentDirectory) + @"\DB\IOPortMap.xml";
            m_strPath = System.IO.Path.GetFullPath(strPath); 
            m_doc.Load(m_strPath);
        }

        //---------------------------------------------------------------------
        // 해당 노드값을 반환
        public string GetNodeVal(string strNode)
        {
            // ex)  XmlNode Inputcount = m_doc.SelectSingleNode("MachineSetup/InputCount");
            XmlNode node = m_doc.SelectSingleNode(strNode);
            string strRet = node.InnerText;

            return (strRet);
        }


        //---------------------------------------------------------------------
        // 해당 노드값을 저장.
        public void SetNodeVal(string strNode, string strVal)
        {
            XmlNode node = m_doc.SelectSingleNode(strNode);
            node.InnerText = strVal;
            m_doc.Save(m_strPath);
        }

        //---------------------------------------------------------------------
        // 해당 노드의 Attribute값 반환
        public string GetAttrItemVal(string strNode, string strItem)
        {
            XmlNode node = m_doc.SelectSingleNode(strNode);
            XmlAttributeCollection attrCol = node.Attributes;
            string strRet = attrCol.GetNamedItem(strItem).Value;

            return (strRet);
        }

        //---------------------------------------------------------------------
        // 해당 노드의 Attribute값 저장
        public void SetAttrItemVal(string strNode, string strItem, string strVal)
        {
            XmlNode node = m_doc.SelectSingleNode(strNode);
            XmlAttributeCollection attrCol = node.Attributes;
            attrCol.GetNamedItem(strItem).Value = strVal;
            m_doc.Save(m_strPath);
        }

    }// end class
}// end namespace
