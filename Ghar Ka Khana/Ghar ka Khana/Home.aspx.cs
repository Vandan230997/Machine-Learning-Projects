﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void order1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cust_registeration.aspx");
    }
    protected void order2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cust_registeration.aspx");
    }
}