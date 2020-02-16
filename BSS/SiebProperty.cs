using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BSS
{
    class SiebProperty
    {
        private static Hashtable dictionary = new Hashtable();
        public SiebProperty()
        {
            dictionary.Add("_spc", " "); //Space
            dictionary.Add("_dqt", "\""); //Double Quote
            dictionary.Add("_sqt", "‘"); //Single Quote
            dictionary.Add("_cln", ":"); //Colon
            dictionary.Add("_scn", ";"); //Semicolon
            dictionary.Add("_lpr", "("); //Left Parenthesis
            dictionary.Add("_rpr", ")"); //Right Parenthesis
            dictionary.Add("_amp", "&"); //Ampersand
            dictionary.Add("_cma", ","); //Comma
            dictionary.Add("_pnd", "#"); //Pound symbol
            dictionary.Add("_slh", "/"); //(Forward) slash
            dictionary.Add("_qst", "?"); //Question Mark
            dictionary.Add("_lst", "<"); //Less Than
            dictionary.Add("_grt", ">"); //Greater Than
            //			dictionary.Add(@"__\d{4}", "UNICODE"); //Underscore Other illegal characters (1 before last)
            //			dictionary.Add("_und", "_"); //Underscore (last)
        }
        public static string RecoveNameFromXml(string name)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(name, "_")) return name;

            string n = name.Replace("__", "_");
            foreach (object k in dictionary.Keys)
                n = Regex.Replace(n, (string)k, (string)dictionary[k]);

            MatchCollection mc = Regex.Matches(n, "_([0-9,a-f,A-F]{4})");
            for (int i = 0; i < mc.Count; i++)
            {
                int charCode;
                charCode = Convert.ToInt32(mc[i].Groups[1].Value, 16);
                char ch = (char)charCode;
                n = Regex.Replace(n, mc[i].Value, ch.ToString());
            }

            n = Regex.Replace(n, "_und", "_");
            return n;
        }

        public enum PropertyType { Property = 0, PropertySet = 1 };
        PropertyType type = PropertyType.Property;
        public PropertyType Type
        {
            set { type = value; }
            get { return type; }
        }

        string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        string val;
        public string Value
        {
            set { val = value; }
            get { return val; }
        }
        public SiebProperty(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
        public SiebProperty(string Name, string Value, PropertyType type)
            : this(Name, Value)
        {
            this.Type = type;
        }
        public override string ToString()
        {
            if (this.Type == PropertyType.PropertySet)
                return "Type: " + Name + "; Value: " + Value;
            else
                return Name + " = " + Value;
            //return base.ToString ();
        }
        /// <summary>
        /// Update node of TreeView. Updating: Tag of node changed to current SiebProp, text and image index updated 
        /// </summary>
        /// <param name="node">node to update</param>
        public void ToTreeNode(TreeNode node)
        {
            node.Tag = this;
            node.Text = ToString();
            node.SelectedImageIndex = node.ImageIndex = (int)Type;
        }
        /// <summary>
        /// Create new TreeNode
        /// </summary>
        /// <returns></returns>
        public TreeNode ToTreeNode()
        {
            TreeNode n = new TreeNode();
            ToTreeNode(n);
            return n;
        }
    }
}
