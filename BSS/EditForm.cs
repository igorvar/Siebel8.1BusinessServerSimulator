using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BSS
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            Image img = node.TreeView.ImageList.Images[node.ImageIndex];
            Icon icn = Icon.FromHandle(((Bitmap)img).GetHicon());
            this.Icon = icn;
            SiebProperty prop = (SiebProperty)(Node.Tag);
            switch (prop.Type)
            {
                case SiebProperty.PropertyType.Property:
                    lblName.Text = "Name";
                    break;
                case SiebProperty.PropertyType.PropertySet:
                    lblName.Text = "Type";
                    break;
            }
            if (prop.Value.IndexOf("\r\n") > -1) Multilined();
            txtValue.Text = prop.Value;
            txtName.Text = prop.Name;
            txtName.ReadOnly = txtValue.ReadOnly = IsReadOnly;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            SiebProperty prop = (SiebProperty)Node.Tag;
            prop.Value = txtValue.Text;
            prop.Name = txtName.Text;
            prop.ToTreeNode(Node);
            this.DialogResult = DialogResult.OK;
        }
        private void btnMultiline_Click(object sender, EventArgs e)
        {
            Multilined();
        }
        private void Multilined()
        {
            txtValue.Multiline = true;
            //this.Size = new Size(this.Size.Width, 280);
            this.Size = new Size(600, 350);
            this.AcceptButton = null;
            //this.btnMultiline.Enabled = false;
            this.btnMultiline.Visible = false;
            txtValue.Width = txtName.Width;
            txtValue.Font = new System.Drawing.Font("Courier New", 8.25F);//txtInvisible.Font;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private TreeNode node;
        public TreeNode Node
        {
            get { return node; }
            set { node = value; }
        }

        private bool isReadOnly;
        public bool IsReadOnly
        {
            get { return isReadOnly; }
            set { isReadOnly = value; }
        }

        


	
	
    }
}