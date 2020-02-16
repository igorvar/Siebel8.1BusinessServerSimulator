using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace BSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            new SiebProperty("", "", SiebProperty.PropertyType.PropertySet).ToTreeNode(tvIps.Nodes[0]);
            new SiebProperty("", "", SiebProperty.PropertyType.PropertySet).ToTreeNode(tvOps.Nodes[0]);
            new SiebProperty("", "", SiebProperty.PropertyType.PropertySet).ToTreeNode(tvLog.Nodes[0]);

        }
        

        private void btnRun_Click(object sender, EventArgs e)
        {
            RunFunction();
        }
        private void RunFunction()
        {
            SiebelWrapper sw = new SiebelWrapper();
            SiebelWrapper.PropertySet ips = new SiebelWrapper.PropertySet();
            SiebelAnswer answer;

            GetPs(ref ips, tvIps.Nodes[0], false);

            //ops = sw.InvokeMethod(txtService.Text, txtFunction.Text, ips);
            answer = sw.InvokeMethod(txtService.Text, txtFunction.Text, ips.GetChild(0));

            tvOps.Nodes[0].Nodes.Clear();
            (new SiebProperty("", "", SiebProperty.PropertyType.PropertySet)).ToTreeNode(tvOps.Nodes[0]);
            tvLog.Nodes[0].Nodes.Clear();
            SetPs(tvLog.Nodes[0], answer.InvokeMethodResult);
            tvLog.ExpandAll();

            if (answer.IsError)
                MessageBox.Show(answer.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SetPs(tvOps.Nodes[0], answer.FunctionResult);
                tvOps.ExpandAll();
                txtService.AutoCompleteCustomSource.Add(txtService.Text);
                txtFunction.AutoCompleteCustomSource.Add(txtFunction.Text);
            }
        }
        private void GetPs(ref SiebelWrapper.PropertySet mainPs, TreeNode node, bool namesWitoutValues)
        {
            SiebProperty siebProp = (SiebProperty)node.Tag;
            SiebelWrapper.PropertySet ps = new SiebelWrapper.PropertySet();
            if (siebProp.Type == SiebProperty.PropertyType.PropertySet)
            {

                //ps.SetPsType(siebProp.Name);
                ps.PsType = siebProp.Name;
                if (!namesWitoutValues) ps.PsValue = siebProp.Value;
                foreach (TreeNode n in node.Nodes)
                    GetPs(ref ps, n, namesWitoutValues);
                mainPs.AddChild(ps);
            }
            else
                if (namesWitoutValues)
                    //mainPs.SetProperty(siebProp.Name, "");
                    mainPs.Property(siebProp.Name,"");
                    
                    //mainPs.
                else
                    //mainPs.SetProperty(siebProp.Name, siebProp.Value);
                    mainPs.Property(siebProp.Name, siebProp.Value);
        }
        private void SetPs(TreeNode node, SiebelWrapper.PropertySet ps)
        {
            //SiebProperty prop = new SiebProperty( ps.GetType(), ps.GetValue(), SiebProperty.PropertyType.PropertySet);
            SiebProperty prop = new SiebProperty(ps.PsType, ps.PsValue, SiebProperty.PropertyType.PropertySet);
            string propName = "";
            prop.ToTreeNode(node);
            //for (int i = 0; i < ps.GetPropertyCount(); i++)
            for (int i = 0; i < ps.PropertyCount; i++)
            {
                if (i == 0) propName = ps.GetFirstProperty(); else propName = ps.GetNextProperty();
                //node.Nodes.Add(new SiebProperty(propName, ps.GetProperty(propName)).ToTreeNode());
                node.Nodes.Add(new SiebProperty(propName, ps.Property(propName)).ToTreeNode());
            }
            //for (int i = 0; i < ps.GetChildCount(); i++)
            for (int i = 0; i < ps.ChildCount; i++)
            {
                //SIEBELHTMLLib.SiebelPropertySet n = ps.GetChild(i);
                SiebelWrapper.PropertySet n = ps.GetChild(i);
                TreeNode tn = new TreeNode();
                SetPs(tn, n);
                node.Nodes.Add(tn);
            }
        }
        private void btnCloseIpsInputForm_Click(object sender, EventArgs e)
        {
            //this.Parent
            //this.Container
            splitIps.Panel1Collapsed = !splitIps.Panel1Collapsed;
            /*if (splitIps.Panel1Collapsed)
                btnCloseIpsInputForm.Cursor = System.Windows.Forms.Cursors.PanSouth;
            else
                btnCloseIpsInputForm.Cursor = System.Windows.Forms.Cursors.PanNorth;*/
        }

        private void btnAddProp_Click(object sender, EventArgs e)
        {
            SiebProperty p = new SiebProperty(txtPropName.Text, txtPropValue.Text);
            TreeNode propNode = p.ToTreeNode();
            tvIps.Focus();
            TreeNode addTo = null;
            if (tvIps.SelectedNode == null)
                addTo = tvIps.Nodes[0];
            else if (((SiebProperty)(tvIps.SelectedNode.Tag)).Type == SiebProperty.PropertyType.PropertySet)
                addTo = tvIps.SelectedNode;
            else
                addTo = tvIps.SelectedNode.Parent;
            addTo.Nodes.Add(propNode);
            tvIps.SelectedNode = propNode;
        }

        private void btvAddChild_Click(object sender, EventArgs e)
        {
            SiebProperty p = new SiebProperty(txtPropName.Text, txtPropValue.Text, SiebProperty.PropertyType.PropertySet);
            TreeNode propNode = p.ToTreeNode();
            tvIps.Focus();
            TreeNode addTo = null;
            if (tvIps.SelectedNode == null)
                addTo = tvIps.Nodes[0];
            else if (((SiebProperty)(tvIps.SelectedNode.Tag)).Type == SiebProperty.PropertyType.PropertySet)
                addTo = tvIps.SelectedNode;
            else addTo = tvIps.SelectedNode.Parent;
            addTo.Nodes.Add(propNode);
            tvIps.SelectedNode = propNode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tvIps.SelectedNode == null) return;
            RemoveNode(tvIps.SelectedNode);
        }
        private void RemoveNode(TreeNode n)
        {
            if (tvIps.SelectedNode.Parent == null) return;
            tvIps.SelectedNode.Remove();
        }

        private void splitIpsOps_SplitterMoved(object sender, SplitterEventArgs e)
        {
            btnCloseIpsInputForm.Width = splitIpsOps.Panel1.Width;
        }

        private void tvIps_DoubleClick(object sender, EventArgs e)
        {
            EditNode(tvIps.SelectedNode);
        }
        

        private void tvOps_DoubleClick(object sender, EventArgs e)
        {
            ViewNode(tvOps.SelectedNode);
        }
        private void tvLog_DoubleClick(object sender, EventArgs e)
        {
            ViewNode(tvLog.SelectedNode);
        }
        private void ViewNode(TreeNode n)
        {
            EditForm ef = new EditForm();
            ef.IsReadOnly = true;
            ef.Node = n;
            ef.ShowDialog();
        }

        private void EditNode(TreeNode n)
        {
            EditForm ef = new EditForm();
            ef.IsReadOnly = false;
            ef.Node = n;
            ef.ShowDialog();
            tvIps.Update();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;
            if (String.IsNullOrEmpty(fileName)) return;
            SaveContextToXML().Save(fileName);
        }
/// <summary>
/// return xml document, it contain bsName, function name and ips, 
/// </summary>
/// <returns></returns>
        private XmlDocument SaveContextToXML()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode n = doc.CreateElement("RunBS");
            SiebelWrapper.PropertySet ips = new SiebelWrapper.PropertySet();

            XmlNode attr = doc.CreateAttribute("BsName");
            attr.Value = this.txtService.Text;
            n.Attributes.SetNamedItem(attr);

            attr = doc.CreateAttribute("BsFunction");
            attr.Value = this.txtFunction.Text;
            n.Attributes.SetNamedItem(attr);

            SiebelWrapper sw = new SiebelWrapper();
            GetPs(ref ips, tvIps.Nodes[0], false);
            string xmlStr = sw.PsToXml(ips);

            XmlDocument resp = new XmlDocument();
            resp.LoadXml(xmlStr);

            attr = doc.CreateElement("PS");

            //attr.InnerXml = resp.DocumentElement.InnerXml;
            attr.InnerXml = resp.DocumentElement.OuterXml;
            n.AppendChild(attr);

            doc.AppendChild(n);
            return doc;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = this.openFileDialog1.FileName;
            if (fileName == "") return;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            LoadContextFromXML(doc);
        }

        private void LoadContextFromXML(XmlDocument doc)
        {
            XmlAttribute tmpA;

            tmpA = doc.DocumentElement.Attributes["BsName"];

            if (tmpA == null) this.txtService.Text = "";
            else this.txtService.Text = tmpA.Value;

            tmpA = doc.DocumentElement.Attributes["BsFunction"];
            if (tmpA == null) this.txtFunction.Text = "";
            else this.txtFunction.Text = tmpA.Value;

            tvIps.Nodes[0].Nodes.Clear();
            XmlNode psAsXml = doc.SelectSingleNode("/*/PS/*");
            if (psAsXml == null) return;

            //SetPs(tvIps.Nodes[0], psAsXml);
            SetPs(tvIps.Nodes[0], psAsXml.OuterXml);
            tvIps.ExpandAll();
        }
        /// <summary>
        /// Update tree node by xml representated siebel PS
        /// </summary>
        /// <param name="node">tree-node for updating</param>
        /// <param name="ps"> xml-node, represented ps or it child</param>
        private void SetPs(TreeNode node, XmlNode ps)
        {
            TreeNode tn = null;
            SiebProperty prop = new SiebProperty(SiebProperty.RecoveNameFromXml(ps.Name), "", SiebProperty.PropertyType.PropertySet);
            prop.ToTreeNode(node);
            if (ps.NodeType == XmlNodeType.Element) //else - if xml not correct
                foreach (XmlAttribute a in ps.Attributes)
                    node.Nodes.Add(new SiebProperty(SiebProperty.RecoveNameFromXml(a.Name), a.Value).ToTreeNode());

            foreach (XmlNode n in ps.ChildNodes)
                switch (n.NodeType)
                {
                    case XmlNodeType.Element:
                        tn = new TreeNode();
                        SetPs(tn, n);
                        node.Nodes.Add(tn);
                        break;
                    case XmlNodeType.Text:
                        prop.Value = n.Value;
                        prop.ToTreeNode(node);
                        break;
                }
        }
        private void SetPs (TreeNode t, string Xml)
        {
            SiebelWrapper sw = new SiebelWrapper();
            SiebelWrapper.PropertySet ps =sw.PsFromXml(Xml);
            
            
            //string xmlStr = sw.PsToXml(ips);
        }
    }
}