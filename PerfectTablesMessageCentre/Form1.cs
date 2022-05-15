using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace PerfectTablesMessageCentre
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            ListBox[] lstBox;
            Label[] lbl;
            Button[] btnEdit;
            Button[] btnDelete;
            Button[] btnCopy;

            string xmlDoc = "responses.xml";
            int i = 0;
            int space = 20;

            if (File.Exists(xmlDoc))
            {
                XDocument xDoc = XDocument.Load(xmlDoc);
                int count = xDoc.Descendants("Response").Count();
                lstBox = new ListBox[count];
                lbl = new Label[count];
                btnEdit = new Button[count];
                btnDelete = new Button[count];
                btnCopy = new Button[count];

                foreach (XElement xe in xDoc.Descendants("Response"))
                {
                    string id = xe.Attribute("id").Value;
                    lstBox[i] = new ListBox();
                    lstBox[i].Name = "txtMessage" + id;
                    foreach (string s in xe.Element("Message").Value.Split("\n"))
                    {
                        lstBox[i].Items.Add(s);
                    }
                    lstBox[i].Location = new Point(12, 78 + space);
                    lstBox[i].Size = new Size(340, 55);
                    lbl[i] = new Label();
                    lbl[i].Name = "lblTitle" + id;
                    lbl[i].Text = xe.Element("Title").Value;
                    lbl[i].Location = new Point(12, 58 + space);
                    btnEdit[i] = new Button();
                    btnEdit[i].Name = "btnEdit" + id;
                    btnEdit[i].Text = "Edit Response";
                    btnEdit[i].Location = new Point(12, 139 + space);
                    btnEdit[i].Size = new Size(99, 27);
                    btnEdit[i].Click += new EventHandler(btnEdit_Click);
                    btnDelete[i] = new Button();
                    btnDelete[i].Name = "btnDelete" + id;
                    btnDelete[i].Text = "Delete Response";
                    btnDelete[i].Location = new Point(238, 139 + space);
                    btnDelete[i].Size = new Size(114, 27);
                    btnDelete[i].Click += new EventHandler(btnDelete_Click);
                    btnCopy[i] = new Button();
                    btnCopy[i].Name = "btnCopy" + id;
                    btnCopy[i].Text = "Copy";
                    btnCopy[i].Location = new Point(357, 78 + space);
                    btnCopy[i].Size = new Size(46, 55);
                    btnCopy[i].Click += new EventHandler(btnCopy_Click);

                    this.Controls.Add(lstBox[i]);
                    this.Controls.Add(lbl[i]);
                    this.Controls.Add(btnEdit[i]);
                    this.Controls.Add(btnDelete[i]);
                    this.Controls.Add(btnCopy[i]);

                    space += 110;
                    i++;
                }
            }

            InitializeComponent();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id = Int32.Parse(Regex.Match(button.Name, @"\d+").Value);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id = Int32.Parse(Regex.Match(button.Name, @"\d+").Value);
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id = Int32.Parse(Regex.Match(button.Name, @"\d+").Value);
        }
        private void btnAddResponse_Click(object sender, EventArgs e)
        {
            frmAddResponse form = new frmAddResponse();
            form.Show();
        }
    }
}