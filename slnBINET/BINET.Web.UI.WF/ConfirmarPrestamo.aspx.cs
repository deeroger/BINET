﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BINET.Web.UI.WF
{
    public partial class ConfirmarPrestamo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}