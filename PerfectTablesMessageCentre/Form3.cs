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
    public partial class frmEditResponse : Form
    {
        public string title { get; set; }
        public string response { get; set; }
        public int id { get; set; }
        public frmEditResponse()
        {
            InitializeComponent();
        }
        private void frmEditResponse_Load(object sender, EventArgs e)
        {
            txtResponseTitle.Text = title;
            txtResponse.Text = response.Replace("\n", Environment.NewLine);
        }
        private void btnUpdateResponse_Click(object sender, EventArgs e)
        {
            string xmlDoc = "responses.xml";
            XDocument xDoc = XDocument.Load(xmlDoc);
            var update = xDoc.Descendants("Response")
                    .Where(x => (string)x.Attribute("id") == id.ToString())
                    .Single();
            update.Element("Title").Value = txtResponseTitle.Text;
            update.Element("Message").Value = txtResponse.Text.Replace(Environment.NewLine, "\n"); ;
            xDoc.Save(xmlDoc);
            MessageBox.Show("Response Updated!");
            this.Close();
            frmMain form = new frmMain();
            form.Show();
        }
    }
}
