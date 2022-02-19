using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PAVING2
{
    public partial class ReleeView : System.Web.UI.Page
    {
        public Releu Releu1 = new Releu();
        public Releu Releu2 = new Releu();
        public Releu Releu3 = new Releu();
        public Releu Releu4 = new Releu();
        public Releu Releu5 = new Releu();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Releu1.Clicked();
            CHeckBox1.Checked =!CHeckBox1.Checked;
        }
        protected void btn2_Click(object sender, EventArgs e)
        {
            Releu2.Clicked();
            CHeckBox2.Checked = !CHeckBox2.Checked;
        }
        protected void btn3_Click(object sender, EventArgs e)
        {
            Releu3.Clicked();
            CHeckBox3.Checked = !CHeckBox3.Checked;
        }
        protected void btn4_Click(object sender, EventArgs e)
        {
            Releu4.Clicked();
            CHeckBox4.Checked = !CHeckBox4.Checked;
        }
        protected void btn5_Click(object sender, EventArgs e)
        {
            Releu5.Clicked();
            CHeckBox5.Checked = !CHeckBox5.Checked;
        }
    }
}