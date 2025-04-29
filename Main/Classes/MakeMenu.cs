using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.Main.Classes
{
    public static class MakeMenu
    {
        public static System.Windows.Forms.MenuStrip CreateMenu(Byte[] XmlBytes)
        {
            System.Windows.Forms.MenuStrip Menu = new System.Windows.Forms.MenuStrip();
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(XmlBytes))
            {
                System.Xml.XmlTextReader xmlReader = new System.Xml.XmlTextReader(ms);
                xmlReader.MoveToContent();
                System.Xml.XmlDocument document = new System.Xml.XmlDocument();
                document.Load(xmlReader);
                System.Xml.XmlElement element = document.DocumentElement;

                foreach (System.Xml.XmlNode node in document.FirstChild.ChildNodes)
                {
                    System.Windows.Forms.ToolStripMenuItem menuItem = new System.Windows.Forms.ToolStripMenuItem();

                    menuItem.Name = node.Attributes["Name"].Value;
                    menuItem.Text = node.Attributes["Text"].Value;

                    Menu.Items.Add(menuItem);
                    GenerateMenusFromXML(node, menuItem);
                }
            }
            return Menu;
        }

        public static List<Telerik.WinControls.UI.RadTreeNode> TreeNode(Byte[] XmlBytes)
        {
            List<Telerik.WinControls.UI.RadTreeNode> Nodes = new List<Telerik.WinControls.UI.RadTreeNode>();
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(XmlBytes))
            {
                System.Xml.XmlTextReader xmlReader = new System.Xml.XmlTextReader(ms);
                xmlReader.MoveToContent();
                System.Xml.XmlDocument document = new System.Xml.XmlDocument();
                document.Load(xmlReader);
                System.Xml.XmlElement element = document.DocumentElement;

                foreach (System.Xml.XmlNode node in document.FirstChild.ChildNodes)
                {
                    Telerik.WinControls.UI.RadTreeNode Node = new Telerik.WinControls.UI.RadTreeNode();

                    Node.Name = node.Attributes["Name"].Value;
                    Node.Text = node.Attributes["Text"].Value;
                    Node.CheckType = Telerik.WinControls.UI.CheckType.CheckBox;

                    Nodes.Add(Node);
                    GenerateNodeFromXML(node, Node);
                }
            }
            return Nodes;
        }

        public static void SelectNode(Byte[] XmlBytes, Telerik.WinControls.UI.RadTreeView TreeView)
        {
            List<String> Items = ConvertXmlToString(XmlBytes);

            foreach (Telerik.WinControls.UI.RadTreeNode node in TreeView.Nodes)
            {
                SelectNode(node, Items);
            }
        }

        public static Byte[] SaveNode(Telerik.WinControls.UI.RadTreeView TreeView)
        {
            System.IO.MemoryStream Ms = new System.IO.MemoryStream();
            using (System.Xml.XmlWriter writer = System.Xml.XmlTextWriter.Create(Ms))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("root");

                foreach (Telerik.WinControls.UI.RadTreeNode Item in TreeView.Nodes)
                {
                    if (Item.CheckState != Telerik.WinControls.Enumerations.ToggleState.Off)
                    {
                        writer.WriteStartElement("TopLevelMenu");
                        writer.WriteAttributeString("Name", Item.Name);
                        writer.WriteAttributeString("Text", Item.Text);
                        WriteChildElement(writer, Item);
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }

            return Ms.ToArray();
        }

        private static void WriteChildElement(System.Xml.XmlWriter writer, Telerik.WinControls.UI.RadTreeNode Node)
        {
            foreach (Telerik.WinControls.UI.RadTreeNode Item in Node.Nodes)
            {
                if (Item.CheckState != Telerik.WinControls.Enumerations.ToggleState.Off)
                {
                    writer.WriteStartElement("MenuItem");
                    writer.WriteAttributeString("Name", Item.Name);
                    writer.WriteAttributeString("Text", Item.Text);
                    WriteChildElement(writer, Item);
                    writer.WriteEndElement();
                }
            }
        }

        private static void GenerateMenusFromXML(System.Xml.XmlNode rootNode, System.Windows.Forms.ToolStripMenuItem menuItem)
        {
            System.Windows.Forms.ToolStripMenuItem item = null;

            foreach (System.Xml.XmlNode node in rootNode.ChildNodes)
            {
                item = new System.Windows.Forms.ToolStripMenuItem();
                item.Name = node.Attributes["Name"].Value;
                item.Text = node.Attributes["Text"].Value;

                menuItem.DropDownItems.Add(item);
                GenerateMenusFromXML(node, item);
            }
        }

        private static void GenerateNodeFromXML(System.Xml.XmlNode rootNode, Telerik.WinControls.UI.RadTreeNode Node)
        {
            Telerik.WinControls.UI.RadTreeNode item = null;

            foreach (System.Xml.XmlNode node in rootNode.ChildNodes)
            {
                item = new Telerik.WinControls.UI.RadTreeNode();
                item.Name = node.Attributes["Name"].Value;
                item.Text = node.Attributes["Text"].Value;
                item.CheckType = Telerik.WinControls.UI.CheckType.CheckBox;

                Node.Nodes.Add(item);
                GenerateNodeFromXML(node, item);
            }
        }

        private static List<String> ConvertXmlToString(Byte[] XmlBytes)
        {
            List<String> SelectedNode = new List<String>();

            if (XmlBytes != null)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(XmlBytes))
                {
                    System.Xml.XmlTextReader xmlReader = new System.Xml.XmlTextReader(ms);
                    xmlReader.MoveToContent();
                    System.Xml.XmlDocument document = new System.Xml.XmlDocument();
                    document.Load(xmlReader);
                    System.Xml.XmlElement element = document.DocumentElement;

                    foreach (System.Xml.XmlNode node in document.FirstChild.ChildNodes)
                    {
                        GenerateStringFromXML(node, SelectedNode);
                    }
                }
            }

            return SelectedNode;
        }

        private static void GenerateStringFromXML(System.Xml.XmlNode rootNode, List<String> SelectedNode)
        {
            foreach (System.Xml.XmlNode node in rootNode.ChildNodes)
            {
                SelectedNode.Add(node.Attributes["Name"].Value);
                GenerateStringFromXML(node, SelectedNode);
            }
        }

        private static void SelectNode(Telerik.WinControls.UI.RadTreeNode Node, List<String> Items)
        {
            foreach (Telerik.WinControls.UI.RadTreeNode node in Node.Nodes)
            {
                if (node.Nodes.Count == 0)
                {
                    if (Items.Count(row => row == node.Name) > 0)
                    {
                        node.Checked = true;
                    }
                    else
                    {
                        node.Checked = false;
                    }
                }
                else
                {
                    node.Checked = false;
                    SelectNode(node, Items);
                }
            }
        }
    }
}
