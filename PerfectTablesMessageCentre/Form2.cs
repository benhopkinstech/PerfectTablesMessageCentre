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
            string message = txtResponse.Text;
            string xmlDoc = "responses.xml";

            if (File.Exists(xmlDoc))
            {
                XDocument xDoc = XDocument.Load(xmlDoc);
                XElement ttl = new XElement("Title", title);
                XElement msg = new XElement("Message", message);
                xDoc.Root.Add(ttl);
                xDoc.Root.Add(msg);
                xDoc.Save(xmlDoc);
            }
            else
            {
                XElement response = new XElement("Responses",
                new XElement("Title", title),
                new XElement("Message", message));
                response.Save("responses.xml");
            }
            
        }
    }
}
