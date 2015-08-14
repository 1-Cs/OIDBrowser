using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OIDBrowser
{
    public class OidPair : Object
    {
        public String name;
        public String oid;
        override public String ToString()
        {
            return name + '(' + oid + ')';
        }
    }
    public partial class Form1 : Form
    {
        static Form1 frm = null;
        static TreeNode root = null;
        String noun = "";
        String format = "" ; //= "xml";
        String item = "";
        HttpClient client = new HttpClient();
        String word = "";
        String oid = "";
        bool loaded
        {
            get;
            set;
        }
        public Form1()
        {
            InitializeComponent();
            dataBaseCombo.Items.Add("oido");
            dataBaseCombo.Items.Add("test");
            dataBaseCombo.SelectedIndex = 0;
            /*userNameCombo.Items.Add("Objects");
            userNameCombo.Items.Add("Categories");
            userNameCombo.Items.Add("Persons");
            userNameCombo.Items.Add("Databases");*/
            frm = this;
            
        }

        private void baseTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is String)
            {
                displayText.Text = e.Node.Tag.ToString();
            }
            else if(e.Node.Tag is Dictionary<String,String>)
            {
                displayText.Text = "";
                Dictionary<String, String> dict = (Dictionary<String, String>)e.Node.Tag;
                foreach (String key in dict.Keys)
                {
                    displayText.Text += key + "=" + dict[key] + "\r\n" ;
                }
            }
            else
                displayText.Text = "";

            if (e.Node.Parent != null && e.Node.Parent.Text == "Noun")
            {
                noun = e.Node.Text;
                item = "";
            }
            else if (e.Node.Parent != null && e.Node.Parent.Parent != null && e.Node.Parent.Parent.Text == noun)
                item = e.Node.Text;
            else
            {
                noun = "";
                item = "";
            }
        }

        private void dataBaseCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            //= dataBaseCombo.SelectedItem.ToString();                
        }
        async void downloaddelete()
        {
            String uri = "http://localhost/api/oido";
            if (noun != "" && noun != "None")
                uri += "/" + noun;
            if (noun != "" && item != "")
                uri += "/" + item;
            if (format.Length != 0)
                uri += "/" + format;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.ParseAdd("application/xml");
            if(checkLogRequest.Checked)
                client.DefaultRequestHeaders.Pragma.ParseAdd("log-request");
            HttpResponseMessage msg = await client.DeleteAsync(uri);
            if (msg.StatusCode == HttpStatusCode.OK)
            {

                String str = await msg.Content.ReadAsStringAsync();
                displayText.BeginInvoke((Action)(() =>
                {
                    displayText.Text = str;
                }
                ));
                root = null;
            }
            else
            {
                TreeNode node = new TreeNode(msg.StatusCode.ToString());
                node.Tag = msg;
                root = new TreeNode("ROOT");
                root.Nodes.Add(node);
            }
            baseTree.BeginInvoke((Action)(() => {
                baseTree.Nodes.Clear();
                if(root != null)
                    baseTree.Nodes.Add(root.Nodes[0]);
                baseTree.ExpandAll();
            }));
        }
        async void downloadput()
        {
            String uri = "http://localhost/api/oido";
            if (noun != "" && noun != "None")
                uri += "/" + noun;
            if (noun != "" && item != "")
                uri += "/" + item;
            if (format.Length != 0)
                uri += "/" + format;
            HttpClient client = new HttpClient();
            StringBuilder output = new StringBuilder();
            XmlWriter writer = XmlWriter.Create(output);
            writer.WriteStartDocument();
            if (noun == "Objects" || noun == "Categories")
                writer.WriteStartElement(noun);
            else
                writer.WriteStartElement("Oido");
            if (noun == "Objects")
            {
                writer.WriteStartElement("Object");
            }
            else if (noun == "Categories")
            {
                writer.WriteStartElement("Category");
            }
            else
            {
                writer.WriteStartElement("Oid");
            }
            writer.WriteStartAttribute("name");
            writer.WriteString("test");
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("oid");
            writer.WriteString("129.1.1");
            writer.WriteEndAttribute();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            String post = output.ToString();
            HttpContent content = new StringContent(post);
            if (checkLogRequest.Checked)
                client.DefaultRequestHeaders.Pragma.ParseAdd("log-request");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/xml");
            Task<HttpResponseMessage> first = client.PutAsync(uri, content);

            HttpResponseMessage msg = await first;
            if (true)
            {
                if (msg.StatusCode == HttpStatusCode.OK)
                {

                    String str = await msg.Content.ReadAsStringAsync();
                    displayText.BeginInvoke((Action)(() => {
                        displayText.Text = str;
                    }
                    ));
                    root = createTreeFromXml(str);
                }
                else
                {
                    TreeNode node = new TreeNode(msg.StatusCode.ToString());
                    node.Tag = msg;
                    root = new TreeNode("ROOT");
                    root.Nodes.Add(node);
                }
                baseTree.BeginInvoke((Action)(() => {
                    baseTree.Nodes.Clear();
                    baseTree.Nodes.Add(root.Nodes[0]);
                    baseTree.ExpandAll();
                }
                    ));
            }
        }
        async void downloadpost()
        {
            String uri = "http://localhost/api/oido";
            if (noun != "" && noun != "None")
                uri += "/" + noun;
            if (noun != "" && item != "")
                uri += "/" + item;
            if (format.Length != 0)
                uri += "/" + format;
            HttpClient client = new HttpClient();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UTF8Encoding(true);
            StringBuilder output = new StringBuilder();
            XmlWriter writer = XmlWriter.Create(output,settings);
            //writer.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"utf-16\"");
            writer.WriteStartDocument();
            if (noun == "Objects" || noun == "Categories" || noun == "Words")
                writer.WriteStartElement(noun);
            else
                writer.WriteStartElement("Oido");
            if(noun == "Objects")
            {
                writer.WriteStartElement("Object");
            }
            else if(noun == "Categories")
            {
                writer.WriteStartElement("Category");
            }
            else if(noun == "Words")
            {
                writer.WriteStartElement("Word");
            }
            else
            {
                writer.WriteStartElement("Oid");
            }
            writer.WriteStartAttribute("category");
            writer.WriteString(oid);
            writer.WriteEndAttribute();
            writer.WriteString(word);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            String post = output.ToString()  ;
            
            HttpContent content = new StringContent(post);
            //content.Headers.ContentType.MediaType = "application/xml;";
            if (checkLogRequest.Checked)
                client.DefaultRequestHeaders.Add("Pragma", "log-request");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/xml");
            Task<HttpResponseMessage> first = client.PostAsync(uri,content);

            HttpResponseMessage msg = await first;
            if (true)
            {
                if (msg.StatusCode == HttpStatusCode.OK)
                {

                    String str = await msg.Content.ReadAsStringAsync();
                    displayText.BeginInvoke((Action)(() => {
                        displayText.Text = str ;
                    }
                    ));
                    root = createTreeFromXml(str);
                }
                else
                {
                    TreeNode node = new TreeNode(msg.ReasonPhrase.ToString());
                    node.Tag = msg;
                    root = new TreeNode("ROOT");
                    root.Nodes.Add(node);
                }
                baseTree.BeginInvoke((Action)(() => {
                    baseTree.Nodes.Clear();
                    baseTree.Nodes.Add(root.Nodes[0]);
                    baseTree.ExpandAll();
                }
                    ));
            }
        }
         async void downloadget()
        {
            String uri = "http://localhost/api/oido";
            if(noun != "" && noun != "None")
                uri += "/" + noun ;
            if (noun != "" && item != "")
                uri += "/" + item;
            /*if(format.Length != 0)
                uri += "/" + format;*/
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.ParseAdd("application/xml");
            if (checkLogRequest.Checked)
                client.DefaultRequestHeaders.Pragma.ParseAdd("log-request");
            Task<HttpResponseMessage> first = client.GetAsync(uri);
            
            HttpResponseMessage msg = await first;
            if (true)
            {
                if (msg.StatusCode == HttpStatusCode.OK)
                {

                    String str = await msg.Content.ReadAsStringAsync();
                    root = createTreeFromXml(str);
                }
                else
                {
                    TreeNode node = new TreeNode(msg.StatusCode.ToString());
                    node.Tag = msg;
                    root = new TreeNode("ROOT");
                    root.Nodes.Add(node);
                }
                frm.loaded = true;
                
                
                baseTree.BeginInvoke((Action)(() => {
                        baseTree.Nodes.Clear();
                    baseTree.Nodes.Add(root.Nodes[0]);
                    baseTree.ExpandAll();
                    }
                    ));

            }
        }
        void syncGet(Action action)
        {
            Task t = new Task(action);
            t.Start();
           
        }
        TreeNode createTreeFromXml(String str)
        {
            TextReader textReader = new StringReader(str);
            XmlReader xml = XmlReader.Create(textReader);

            Stack<String> backStack = new Stack<String>();
            Stack<TreeNode> nodeStack = new Stack<TreeNode>();
            
            TreeNode node = new TreeNode("XML");
            TreeNode oldnode = null;
            
            while (true)
            {
                try
                {
                    if (!xml.Read())
                        break;
                }
                catch(XmlException e)
                {
                    node.Nodes.Add("Error").Tag = str;
                    break;
                }
                switch (xml.NodeType)
                {
                    case XmlNodeType.Element:
                        oldnode = node;
                        if (oldnode != null)
                            nodeStack.Push(oldnode);
                        node = new TreeNode(xml.Name);

                        node.Tag = new Dictionary<String, String>();
                        oldnode.Nodes.Add(node);
                        if (!xml.IsEmptyElement)
                            backStack.Push(xml.Name);
                        if (xml.HasAttributes)
                        {
                            xml.MoveToFirstAttribute();
                            do
                            {
                                ((Dictionary<String, String>)node.Tag).Add(xml.Name, xml.Value);
                                if (xml.Name == "oid")
                                {
                                    node.Text += "[" + xml.Value + "]";
                                    node.ContextMenuStrip = contextMenuTree;
                                }
                                if (xml.Name == "request")
                                    node.Text += "[" + xml.Value + "]";
                            }
                            while (xml.MoveToNextAttribute());
                        }
                        if (xml.IsEmptyElement)
                            node = nodeStack.Pop();
                        break;
                    case XmlNodeType.Text:
                        node.Nodes.Add(xml.Value).Tag = xml.Value;
                        break;
                    case XmlNodeType.Attribute:
                        ((Dictionary<String, String>)node.Tag).Add(xml.Name, xml.Value);
                        if (xml.Name == "oid")
                            node.Text += "[" + xml.Value + "]";
                        break;
                    case XmlNodeType.CDATA:
                        node.Nodes.Add("CDATA").Tag = xml.Value;
                        break;
                    case XmlNodeType.Comment:
                        node.Nodes.Add("Comment").Tag = xml.Value;
                        break;
                    case XmlNodeType.EndElement:
                        String nodeX = backStack.Pop();
                        if (nodeX != xml.Name)
                            throw new SyntaxErrorException();
                        node = nodeStack.Pop();
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        break;
                    default:
                        break;

                }
            }
            xml.Close();
            
            return node;
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            String user = userNameCombo.Text;
            String pass = passWord.Text;
            String host = hostCombo.Text;
            String db = dataBaseCombo.Text;
            if (baseTree.SelectedNode != null)
            {
                String myNoun = baseTree.SelectedNode.Text;
                if (!comboType.Items.Contains(myNoun))
                    comboType.Items.Add(myNoun);
            }
            baseTree.Nodes.Clear();
            syncGet(downloadget);
            panelText.Visible = true;
            panelDialog.Visible = false;

        }

        private void dataBaseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void userNameCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            noun = userNameCombo.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            noun = comboType.SelectedItem.ToString();
            object obj = comboCategory.SelectedItem;
            if(obj is OidPair)
            {
                OidPair opair = (OidPair)obj;
                oid = opair.oid;
            }
            word = textWord.Text;
            baseTree.Nodes.Clear();
            syncGet(downloadpost);
            panelText.Visible = true;
            panelDialog.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            baseTree.Nodes.Clear();
            syncGet(downloaddelete);
            panelText.Visible = true;
            panelDialog.Visible = false;
        }

        private void buttonPut_Click(object sender, EventArgs e)
        {
            baseTree.Nodes.Clear();
            syncGet(downloadput);
            panelText.Visible = true;
            panelDialog.Visible = false;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            panelText.Visible = false;
            panelDialog.Visible = true;
        }

        private void showWord_Click(object sender, EventArgs e)
        {
            word = textWord.Text;
            if (baseTree.SelectedNode.Tag is Dictionary<String, String>)
            {
                Dictionary<String, String> dict = (Dictionary<String, String>)baseTree.SelectedNode.Tag;
                noun = "Words";
                oid = dict["oid"];
            }
        }
        private void store_Click(object sender,EventArgs e,String def)
        {
            word = textWord.Text;
            if (baseTree.SelectedNode.Tag is Dictionary<String, String>)
            {
                Dictionary<String, String> dict = (Dictionary<String, String>)baseTree.SelectedNode.Tag;
                noun = comboType.Text.ToString();
                if (noun.Length == 0)
                    noun = def;
                try
                {
                    oid = dict["oid"];
                }
                catch (KeyNotFoundException ex)
                {
                    return;
                }
                try
                {
                    String category = baseTree.SelectedNode.Nodes[0].Text;
                    OidPair opair = new OidPair();
                    opair.name = category;
                    opair.oid = oid;
                    comboCategory.Items.Add(opair);
                }
                finally
                {

                }
            }
            baseTree.Nodes.Clear();
            syncGet(downloadpost);
            panelText.Visible = true;
            panelDialog.Visible = false;

        }
        private void storeWord_Click(object sender, EventArgs e)
        {
            store_Click(sender, e,"Words");
        }

        private void storeCategory_Click(object sender, EventArgs e)
        {
            store_Click(sender, e, "Categories");
        }

        private void listWords_Click(object sender, EventArgs e)
        {

        }

        private void listCategories_Click(object sender, EventArgs e)
        {

        }

        private void listObjects_Click(object sender, EventArgs e)
        {

        }

        private void recurseWords_Click(object sender, EventArgs e)
        {

        }

        private void recurseCategories_Click(object sender, EventArgs e)
        {

        }

        private void recurseObjects_Click(object sender, EventArgs e)
        {

        }

        private void baseTree_MouseUp(object sender, MouseEventArgs e)
        {
            baseTree.SelectedNode = baseTree.GetNodeAt(new Point(e.X, e.Y));
        }
    }
}
