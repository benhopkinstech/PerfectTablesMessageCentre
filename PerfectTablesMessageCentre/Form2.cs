using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PerfectTablesMessageCentre
{
    public partial class frmAddResponse : Form
    {
        public frmAddResponse()
        {
            InitializeComponent();
        }

        private void btnAddNewResponse_Click(object sender, EventArgs e)
        {
            string title = txtResponseTitle.Text;
            string message = txtResponse.Text.Replace(Environment.NewLine, "\n");
            string xmlDoc = "responses.xml";
            
            if (File.Exists(xmlDoc))
            {
                XDocument xDoc = XDocument.Load(xmlDoc);
                string id = xDoc.Root.Elements("Response").Attributes("id").Last().Value.ToString();
                XElement response = new XElement("Response", new XAttribute("id", int.Parse(id) + 1),
                    new XElement("Title", title),
                    new XElement("Message", message));
                xDoc.Root.Add(response);
                xDoc.Save(xmlDoc);
            }
            else
            {
                XElement response = new XElement("Responses",
                    new XElement("Response", new XAttribute("id", 1),
                        new XElement("Title", title),
                        new XElement("Message", message)));
                response.Save("responses.xml");
            }

            MessageBox.Show("Response Added!");
            this.Hide();
            frmMain form = new frmMain();
            form.ShowDialog();
            this.Close();
        }
    }
}
