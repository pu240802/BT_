using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Airthmatic obj = new Airthmatic();  
    int a, b, c;
        double x, y, z;
    protected void Page_Load(object sender, EventArgs e)  
    {  
    }  
    protected void btnAdd_Click(object sender, EventArgs e)  
    {  
        a = Convert.ToInt32(txtFno.Text);  
        b = Convert.ToInt32(txtSno.Text);  
        c = obj.Add(a, b);  
        lblResult.Text = c.ToString();  
    }  
    protected void btnSub_Click(object sender, EventArgs e)  
    {  
        a = Convert.ToInt32(txtFno.Text);  
        b = Convert.ToInt32(txtSno.Text);  
        c = obj.Sub(a, b);  
        lblResult.Text = c.ToString();  
    }

        protected void BtnFac_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtFno.Text);
            c = obj.Fac(a);
            lblResult.Text = c.ToString();
        }

        protected void BtnMul_Click(object sender, EventArgs e)  
    {  
        a = Convert.ToInt32(txtFno.Text);  
        b = Convert.ToInt32(txtSno.Text);  
        c = obj.Mul(a, b);  
        lblResult.Text = c.ToString();  
    }  
    protected void btnDiv_Click(object sender, EventArgs e)  
    {  
        a = Convert.ToInt32(txtFno.Text);  
        b = Convert.ToInt32(txtSno.Text);  
        c = obj.Div(a, b);  
        lblResult.Text = c.ToString();  
    } 
   
    protected void btnExp_Click(object sender, EventArgs e)
    {
        x = Convert.ToDouble(txtFno.Text);
        y = Convert.ToDouble(txtSno.Text) ;
            z = obj.expoment(x, y);
        lblResult.Text = z.ToString();
    }
    }
}