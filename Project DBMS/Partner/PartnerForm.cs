using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_DBMS.Partner.PartnerControl;

namespace Project_DBMS.Partner
{
    public partial class PartnerForm : Form
    {
        bool version;
        public PartnerForm()
        {
            InitializeComponent();
        }

        public PartnerForm(string partnerID)
        {
            InitializeComponent();

            partnerID_Label.Text = partnerID;

            BranchControl uc = new BranchControl();
            addUserControl(uc);
        }

        public PartnerForm(string partnerID, bool ver)
        {
            InitializeComponent();

            partnerID_Label.Text = partnerID;

            BranchControl uc = new BranchControl();
            addUserControl(uc);

            version = ver;
        }

        // 1 cach khac de gui du lieu giua 2 form
        //public string Value { get; set; } 

        private void addUserControl(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Partner_Load(object sender, EventArgs e)
        {

        }

        private void QL_DonHang_Click(object sender, EventArgs e)
        {
            // gui ma doi tac toi form quan li don hang
            OrderControl uc = new OrderControl(partnerID_Label.Text, version);
            addUserControl(uc);
        }

        private void QL_ThucDon_button_Click(object sender, EventArgs e)
        {
            MenuControl uc = new MenuControl(partnerID_Label.Text, version);
            addUserControl(uc);
        }

        private void QL_ChiNhanh_button_Click(object sender, EventArgs e)
        {
            BranchControl uc = new BranchControl(partnerID_Label.Text, version);
            addUserControl(uc);
        }

        private void QL_HopDong_Click(object sender, EventArgs e)
        {
            ContractControl uc = new ContractControl(partnerID_Label.Text, version);
            addUserControl(uc);
        }
    }
}
