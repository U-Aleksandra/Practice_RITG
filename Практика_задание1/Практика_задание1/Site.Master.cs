using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Практика_задание1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            //GridView1.DataBind(); //заного связать данные с источником данных

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                bool done = (bool)DataBinder.Eval(e.Row.DataItem, "Done");

                if(done == true)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        e.Row.Cells[i].BackColor = System.Drawing.Color.LawnGreen;
                        e.Row.Cells[i].ForeColor = System.Drawing.Color.DarkGreen;
                    }
                }

                if (done == false)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        e.Row.Cells[i].BackColor = System.Drawing.Color.White;
                        e.Row.Cells[i].ForeColor = System.Drawing.Color.Black;
                    }
                }

                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           SqlDataSource1.Insert();
            TextBoxTask.Text = "";
        }

      
    }
}