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
    public class MyPopupControl : IDXDropDownControl
    {

        public MyPopupControl(Control customControl)
        {
            InitPopupForm(customControl);
        }

        private void InitPopupForm(Control customControl)
        {
            _Form = new Form();
            _Form.FormBorderStyle = FormBorderStyle.None;
            _Form.BackColor = Color.Black;
            _Form.Deactivate += new EventHandler(_Form_Deactivate);
            GroupControl gc = new GroupControl();
            gc.Dock = DockStyle.Fill;
            gc.Text = "Custom popup window";
            _Form.Controls.Add(gc);
            customControl.Dock = DockStyle.Fill;
            gc.Controls.Add(customControl);
        }

        void _Form_Deactivate(object sender, EventArgs e)
        {
            _Form.Hide();
        }


        private Form _Form;
        public Form Form
        {
            get { return _Form; }
            set { _Form = value; }
        }


        #region IDXDropDownControl Members


        void IDXDropDownControl.Hide()
        {
            Form.Hide();
        }

        void IDXDropDownControl.Show(IDXMenuManager manager, Control control, Point pos)
        {
            Form.Show();
            Form.Location = control.PointToScreen(pos);
        }

        bool IDXDropDownControl.Visible
        {
            get { return Form.Visible; }
        }

        #endregion
    }
}
