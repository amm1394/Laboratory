using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateMenu.Classes
{
    public static class WriteXML
    {
        #region Create Xml File
        public static void WriteFile(String FileName, System.Windows.Forms.MenuStrip Menu)
        {
            using (System.Xml.XmlWriter writer = System.Xml.XmlTextWriter.Create(FileName))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("root");

                foreach (System.Windows.Forms.ToolStripMenuItem Item in Menu.Items)
                {
                    writer.WriteStartElement("TopLevelMenu");
                    writer.WriteAttributeString("Name", Item.Name);
                    writer.WriteAttributeString("Text", Item.Text);
                    WriteChildElement(writer, Item);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }

        private static void WriteChildElement(System.Xml.XmlWriter writer, System.Windows.Forms.ToolStripMenuItem MenuItem)
        {
            foreach (System.Windows.Forms.ToolStripMenuItem item in MenuItem.DropDownItems)
            {
                writer.WriteStartElement("MenuItem");
                writer.WriteAttributeString("Name", item.Name);
                writer.WriteAttributeString("Text", item.Text);
                if (item.DropDownItems.Count > 0)
                {
                    WriteChildElement(writer, item);
                }
                writer.WriteEndElement();
            }
        }
        #endregion

        #region Read Xml File
        public static System.Windows.Forms.MenuStrip ReadFile(String FileName)
        {
            System.Windows.Forms.MenuStrip Menu = new System.Windows.Forms.MenuStrip();
            System.Xml.XmlTextReader xmlReader = new System.Xml.XmlTextReader(FileName);
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
                GenerateMenusFromXML(node, (System.Windows.Forms.ToolStripMenuItem)Menu.Items[Menu.Items.Count - 1]);
            }
            return Menu;
        }

        private static void GenerateMenusFromXML(System.Xml.XmlNode rootNode, System.Windows.Forms.ToolStripMenuItem menuItem)
        {
            System.Windows.Forms.ToolStripItem item = null;

            foreach (System.Xml.XmlNode node in rootNode.ChildNodes)
            {
                item = new System.Windows.Forms.ToolStripMenuItem();
                item.Name = node.Attributes["Name"].Value;
                item.Text = node.Attributes["Text"].Value;

                menuItem.DropDownItems.Add(item);
                GenerateMenusFromXML(node, (System.Windows.Forms.ToolStripMenuItem)menuItem.DropDownItems[menuItem.DropDownItems.Count - 1]);
            }
        }
        #endregion
    }
}
