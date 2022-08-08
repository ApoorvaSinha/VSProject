using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TheaterWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TheaterDbConnection theaterDbConnection = new TheaterDbConnection();
                DataTable dtTheater = theaterDbConnection.GetAllTheater();
                gvTheaterDetails.DataSource = dtTheater;
                gvTheaterDetails.DataBind();
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            TheaterDbConnection theaterDbConnection = new TheaterDbConnection();
            TheaterData theaterData = new TheaterData();
            theaterData.TheaterName = txtTheaterName.Text;
            theaterData.TheaterDesc = txtTheaterDesc.Text;
            theaterData.TheaterType = txtTheaterType.Text;
            string msg = theaterDbConnection.InsertTheater(theaterData);
            if (msg != "")
            {
                lblMsg.Text = msg;
                DataTable dtMovies = theaterDbConnection.GetAllTheater();
                gvTheaterDetails.DataSource = dtMovies;
                gvTheaterDetails.DataBind();
            }
            else
                lblMsg.Text = "Failed";
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int theaterId = Convert.ToInt32(txtTheaterId.Text);
            TheaterDbConnection theaterDbConnection = new TheaterDbConnection();
            DataTable dtTheater = theaterDbConnection.GetTheaterById(theaterId);
            if (dtTheater != null && dtTheater.Rows.Count > 0)
            {

                txtTheaterName.Text = dtTheater.Rows[0][1].ToString();
                txtTheaterDesc.Text = dtTheater.Rows[0][2].ToString();
                txtTheaterType.Text = dtTheater.Rows[0][3].ToString();
            }
            else
                lblMsg.Text = "No data Found!";


        }

        protected void txtTheaterDesc_TextChanged(object sender, EventArgs e)
        {

        }

        protected void gvTheaterDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            TheaterDbConnection theaterDbConnection = new TheaterDbConnection();
            TheaterData theaterData = new TheaterData();
            theaterData.Id = Convert.ToInt32(txtTheaterId.Text);
            theaterData.TheaterName = txtTheaterName.Text;
            theaterData.TheaterDesc = txtTheaterDesc.Text;
            theaterData.TheaterType = txtTheaterType.Text;
            string msg = theaterDbConnection.UpdateTheater(theaterData);
            if (msg != "")
            {
                lblMsg.Text = msg;
                DataTable dtTheater = theaterDbConnection.GetAllTheater();
                gvTheaterDetails.DataSource = dtTheater;
                gvTheaterDetails.DataBind();
            }
            else
                lblMsg.Text = "Failed";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int theaterId = Convert.ToInt32(txtTheaterId.Text);
            TheaterDbConnection theaterDbConnection = new TheaterDbConnection();
            TheaterData theaterData = new TheaterData();
            theaterData.Id = Convert.ToInt32(txtTheaterId.Text);
            theaterData.TheaterName = null;
            theaterData.TheaterDesc = null;
            theaterData.TheaterType = null;
            string msg = theaterDbConnection.DeleteTheaterById(theaterId);
            if (msg != "")
            {
                lblMsg.Text = msg;
                DataTable dtTheater = theaterDbConnection.GetAllTheater();
                gvTheaterDetails.DataSource = dtTheater;
                gvTheaterDetails.DataBind();
            }
            else
                lblMsg.Text = "Failed";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtTheaterId.Text = "";
            txtTheaterName.Text = "";
            txtTheaterDesc.Text = "";
            txtTheaterType.Text = "";
        }

    }
}