
using GenMenuBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WinTraverseXml;


namespace ToolsGenMenu
{
    public partial class FrmPrincMenu : Form
    {
       // TreeNode curNode;
        long idTreeNode;
        string xmlContents;
        int idLastVisited;

        public FrmPrincMenu()
        {
            InitializeComponent();
            InitMyComponents();
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
                        itmOpt = new ItemOption(scrap, -1, string.Empty, string.Empty, string.Empty, "InvokerTest");
                        if (xmlNode.Attributes.Count > 0)
                        {
                            itmOpt.IdItemOption = xmlNode.Attributes["id"].Value;
                            itmOpt.Label = xmlNode.Attributes["label"].Value;
                            //itmOpt.ClassNameStr = string.Empty;
                            if (xmlNode.Attributes["assemblyFile"] != null)
                            {
                                itmOpt.AssemblyFile = xmlNode.Attributes["assemblyFile"].Value;
                            }

                            if (xmlNode.Attributes["class"] != null)
                            {
                                itmOpt.ClassNameStr = xmlNode.Attributes["class"].Value;
                            }
                        }
                        res.Name = itmOpt.IdItemOption;
                        res.Text = itmOpt.Label;
                        res.Tag = itmOpt;
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

        private void LoadXmlMenu(string xmlData)
        {
            TreeNode tn;
            xmlTrv.Nodes.Clear();
            var doc = new XmlDocument();
            doc.LoadXml(xmlData);


            if (xmlTrv.Nodes.Count <= 0)
            {

                //tn = XmlTrV.Nodes.Add(doc.ToString());
                tn = xmlTrv.Nodes.Add("Root");

                foreach (XmlNode item in doc.ChildNodes)
                {
                    if (item.Name.CompareTo("menuDef") == 0)
                    {
                        LoadXmlToTree(tn, item.ChildNodes);
                    }
                }




                //tn = XmlTrV.Nodes.Add("First Node");
            }
            xmlTrv.ExpandAll();
        }

        private void InitMyComponents()
        {
            try
            {
                string archMenu = ConfigurationManager.AppSettings["menuDefFile"];
                bool existeArch = File.Exists(archMenu);
                if (existeArch)
                {
                    XmlDocument doc = new XmlDocument();
                    string xmlFile = ConfigurationManager.AppSettings["menuDefFile"];
                    doc.Load(xmlFile);
                    this.xmlContents = doc.InnerXml;
                    LoadXmlMenu(this.xmlContents);
                    this.idLastVisited = -1;
                    this.Text = ConfigurationManager.AppSettings["ambiente"];                    
                }
                else
                {
                    MessageBox.Show("Archivo de configuracion de menu no existe");
                }

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void xmlTrv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {

                Form frm;
                Form lastFrm;
                TreeNode tn = ((TreeView)sender).SelectedNode;
                // MessageBox.Show(((TreeView)sender).SelectedNode.Text);
                Console.WriteLine(tn.Text);
                // obtener información de la clase
                object tag = tn.Tag;
                if (tag is ItemOption)
                {
                    ItemOption itop = (ItemOption)tag;
                    Console.WriteLine("soy un ItemOption");
                    Console.WriteLine(tag.ToString());
                    if (itop.ClassNameStr.CompareTo(string.Empty) != 0)
                    {

                        if (itop.IdNumeric == -1)  // no está creado el objeto
                        {
                            //splitContainer1.Panel2.Controls.Remove()
                            // Assembly assembly = Assembly.LoadFrom("GenMenuFrmUI.dll");
                            Assembly assembly = Assembly.LoadFrom(itop.AssemblyFile);

                            frm = (Form)assembly.CreateInstance(itop.ClassNameStr);
                            frm.TopLevel = false;
                            itop.IdNumeric = splitContainer1.Panel2.Controls.Count;
                            splitContainer1.Panel2.Controls.Add(frm);
                            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                            frm.Dock = DockStyle.Fill;
                            ((ItemOption)tag).FrmWork = frm;
                        }
                        else
                        {
                           
                            frm = (Form)itop.FrmWork;
                            Console.WriteLine("Current Form: " + frm.Name);
                        }
                        /*
                        if (splitContainer1.Panel2.Controls.Count > 0)
                        {
                            Form frmDel = (Form)splitContainer1.Panel2.Controls[0];
                            if (frmDel != null)
                            {
                                splitContainer1.Panel2.Controls.RemoveAt(0);
                            }                        
                        }
                        */
                        if (this.idLastVisited >= 0)
                        {
                            lastFrm = (Form)splitContainer1.Panel2.Controls[this.idLastVisited];
                            Console.WriteLine("Old Form: " + lastFrm.Name);
                            lastFrm.Hide();

                        }
                        frm.Show();
                        this.idLastVisited = itop.IdNumeric;
                    }
                }
                if (tag is MenuOption)
                {
                    Console.WriteLine("soy un MenuOption");
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show (ex.Message);
            }
         
        }

        private void ExitTlStrp_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
