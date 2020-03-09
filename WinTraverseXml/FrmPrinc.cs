using GenMenuBE;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WinTraverseXml
{
    public partial class FrmPrincipal : Form
    {
        TreeNode curNode;
        long idTreeNode;

        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            txtXml.Text =
                  @"<menuDef> " + Environment.NewLine +
                @"<menu id =""menu0"" label=""Menu1""> " + Environment.NewLine +
                @" <menu id=""menu1"" label = ""Menu11""> " + Environment.NewLine +
                @"   <item id=""item2"" label= ""item2"" invoker=""""/> " + Environment.NewLine +
                @"   <item id=""item3"" label= ""item3"" invoker=""""/>" + Environment.NewLine +
                @" </menu> " + Environment.NewLine +
                @" <item id=""item4"" label= ""item4"" invoker=""""/> " + Environment.NewLine +
                @" <item id=""item5"" label= ""item5"" invoker=""""/>" + Environment.NewLine +
                @" <item id=""item6"" label= ""item6"" invoker=""""/>" + Environment.NewLine +
                @" <item id=""item7"" label= ""item7"" invoker=""""/>" + Environment.NewLine +
                @" </menu> " + Environment.NewLine +
                @"</menuDef> ";
            /*
            @"<menuDef> " + Environment.NewLine +
             @" <menu id=""item1"" invoker=""x"">item1</menu> " + Environment.NewLine +
             @"  <menu> " + Environment.NewLine +
             @"    <menu id="" label=""> " + Environment.NewLine +
             @"      <item id=""item2"" invoker="""">item2</item> " + Environment.NewLine +
             @"      <item id=""item3"" invoker="""">item3</item> " + Environment.NewLine +
             @"    </menu> " + Environment.NewLine +
             @"    <item id=""item2"" invoker=""""></item> " + Environment.NewLine +
             @"    <item id=""item2"" invoker=""""></item> " + Environment.NewLine +
             @"    <item id=""item2"" invoker=""""></item> " + Environment.NewLine +
             @"    <item id=""item2"" invoker=""""></item> " + Environment.NewLine +
             @"    <menu id=""""  label="""">El nombre de la rosa</menu> " + Environment.NewLine +
             @"  </menu> " + Environment.NewLine +
               " </menuDef> ";
                        */
            lblCurNode.Text = string.Empty;
        }

        private void butDo_Click(object sender, EventArgs e)
        {
            var doc = new XmlDocument();

            doc.LoadXml(txtXml.Text);
            txtOutput.Text = string.Empty;
            TraverseNodes(doc.ChildNodes);

        }

        private void TraverseNodes(XmlNodeList nodes)
        {
            foreach (XmlNode node in nodes)
            {
                // Do something 
                PrintNode(node);
                TraverseNodes(node.ChildNodes);
            }
        }

        private void PrintNode(XmlNode node)
        {

            Console.Write(node.Name + " => ");
            txtOutput.Text += (node.Name + " => ");
            switch (node.NodeType)
            {
                case XmlNodeType.Attribute:
                    break;
                case XmlNodeType.CDATA:
                    break;
                case XmlNodeType.Comment:
                    break;
                case XmlNodeType.Document:
                    break;
                case XmlNodeType.DocumentFragment:
                    break;
                case XmlNodeType.DocumentType:
                    break;
                case XmlNodeType.Element:
                    break;
                case XmlNodeType.EndElement:
                    break;
                case XmlNodeType.EndEntity:
                    break;
                case XmlNodeType.Entity:
                    break;
                case XmlNodeType.EntityReference:
                    break;
                case XmlNodeType.None:
                    break;
                case XmlNodeType.Notation:
                    break;
                case XmlNodeType.ProcessingInstruction:
                    break;
                case XmlNodeType.SignificantWhitespace:
                    break;
                case XmlNodeType.Text:
                    if (node.Value != null)
                    {
                        Console.WriteLine(node.Value.ToString());
                        txtOutput.Text += (node.Value + Environment.NewLine);
                    }
                    break;
                case XmlNodeType.Whitespace:
                    break;
                case XmlNodeType.XmlDeclaration:
                    break;
                default:
                    break;
            }
        }

        private void AddNodeBut_Click(object sender, EventArgs e)
        {
            try
            {
                this.idTreeNode = 0;
                if (XmlTrV.Nodes.Count <= 0) // put root
                {
                    this.curNode = XmlTrV.Nodes.Add("First Node");
                }
                else  // ya hay nodos
                {
                    if (curNode != null)
                    {
                        string nodeText = Interaction.InputBox("Node Text: ", "Write Node Text", string.Empty, -1, -1);
                        nodeText = (nodeText.Length <= 0 ? "Other Node" : nodeText);
                        this.curNode.Nodes.Add(nodeText);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void XmlTrV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.curNode = e.Node;
            lblCurNode.Text = e.Node.Text;
        }

        private TreeNode MakeTreeNodeFromXmlNode(XmlNode xmlNode)
        {
            TreeNode res = null;
            Console.Write(xmlNode.Name + " => ");
            switch (xmlNode.NodeType)
            {
                case XmlNodeType.Attribute:
                    break;
                case XmlNodeType.CDATA:
                    break;
                case XmlNodeType.Comment:
                    break;
                case XmlNodeType.Document:
                    break;
                case XmlNodeType.DocumentFragment:
                    break;
                case XmlNodeType.DocumentType:
                    break;
                case XmlNodeType.Element:
                    MenuOption mnuOpt;
                    ItemOption itmOpt;
                    string scrap = "Prueba";
                    scrap = xmlNode.Name + (Convert.ToString(this.idTreeNode++));
                    res = new TreeNode();
                    // process attributes
                    if (xmlNode.Name.CompareTo("menu") == 0)
                    {
                        mnuOpt = new MenuOption(scrap, string.Empty);
                        if (xmlNode.Attributes.Count > 0)
                        {
                            mnuOpt.IdMenuOption = xmlNode.Attributes["id"].Value;
                            mnuOpt.Label = xmlNode.Attributes["label"].Value;

                        }
                        res.Name = mnuOpt.IdMenuOption;
                        res.Text = mnuOpt.Label;
                        res.Tag = mnuOpt;
                    }
                    else
                    {
                        // itmOpt = new ItemOption(scrap, string.Empty, "InvokerTest");
                        if (xmlNode.Attributes.Count > 0)
                        {
                          //  itmOpt.IdItemOption = xmlNode.Attributes["id"].Value;
                           // itmOpt.Label = xmlNode.Attributes["label"].Value;

                        }
                        /*
                        res.Name = itmOpt.IdItemOption;
                        res.Text = itmOpt.Label;
                        res.Tag = itmOpt;
                         * */
                    }
                    /*
                    if (xmlNode.Attributes.Count > 0)
                    {
                        
                        bool ft = true;
                        for (int i = 0; i < xmlNode.Attributes.Count; i++)
                        {
                            
                            scrap += ((!ft ? ", " : string.Empty) + xmlNode.Attributes[i].Name + "=" + xmlNode.Attributes[i].Value);
                            ft = false;
                        }
                        
                        scrap = " {" + scrap + "}";
                        res.Text += scrap;
                    }
                    */
                    break;
                case XmlNodeType.EndElement:
                    break;
                case XmlNodeType.EndEntity:
                    break;
                case XmlNodeType.Entity:
                    break;
                case XmlNodeType.EntityReference:
                    break;
                case XmlNodeType.None:
                    break;
                case XmlNodeType.Notation:
                    break;
                case XmlNodeType.ProcessingInstruction:
                    break;
                case XmlNodeType.SignificantWhitespace:
                    break;
                case XmlNodeType.Text:
                    if (xmlNode.Value != null)
                    {
                        Console.WriteLine(xmlNode.Value.ToString());
                        res = new TreeNode(xmlNode.Value.ToString());
                    }
                    break;
                case XmlNodeType.Whitespace:
                    break;
                case XmlNodeType.XmlDeclaration:
                    break;
                default:
                    break;
            }

            return res;
        }

        private void LoadXmlToTree(TreeNode treeNode, XmlNodeList xmlNodeList)
        {

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                TreeNode tn = MakeTreeNodeFromXmlNode(xmlNode);
                treeNode.Nodes.Add(tn);
                LoadXmlToTree(tn, xmlNode.ChildNodes);
            }

        }

        private void LoadXmlBut_Click(object sender, EventArgs e)
        {
            TreeNode tn;
            XmlTrV.Nodes.Clear();
            var doc = new XmlDocument();
            doc.LoadXml(txtXml.Text);
            

            if (XmlTrV.Nodes.Count <= 0)
            {

                //tn = XmlTrV.Nodes.Add(doc.ToString());
                tn = XmlTrV.Nodes.Add("Root");
                foreach (XmlNode item in doc.ChildNodes)
                {
                    if (item.Name.CompareTo("menuDef") == 0)
                    {
                        LoadXmlToTree(tn, item.ChildNodes);
                    }
                }
                /*
                if (doc.ChildNodes[0].Name.CompareTo("menuDef") == 0)
                {
                    LoadXmlToTree(tn, doc.ChildNodes[0].ChildNodes);
                } */


                //tn = XmlTrV.Nodes.Add("First Node");
            }
            XmlTrV.ExpandAll();

        }
    }
}
