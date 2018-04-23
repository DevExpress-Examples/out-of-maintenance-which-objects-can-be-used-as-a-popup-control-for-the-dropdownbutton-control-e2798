using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DXPopupMenu menu = new DXPopupMenu();
            menu.Items.Add(new DXMenuItem("Test1"));
            menu.Items.Add(new DXMenuItem("Test2"));
            menu.Items.Add(new DXMenuItem("Test3"));
            dropDownButton1.DropDownControl = menu;
            dropDownButton2.DropDownControl = new MyPopupControl(new XtraUserControl1());
            PopupContainerControl container = new PopupContainerControl();
            XtraUserControl1 uc = new XtraUserControl1();
            uc.Dock = DockStyle.Fill;
            container.Controls.Add(uc);
            popupContainerEdit1.Properties.PopupControl = container;
        }
    }
}