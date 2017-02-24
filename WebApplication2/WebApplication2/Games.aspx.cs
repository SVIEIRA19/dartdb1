using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{

    public partial class Stats : System.Web.UI.Page
    {
        
        DartLeagueDataContext db = new DartLeagueDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            // If you not place this check then you will get the old values because GridView in Bind on every postback
            if (!Page.IsPostBack) 
            {
                DropDownList1.Items.Insert(0, "All Players");
                DropDownList1.SelectedIndex = 0;
                BindGridView(); // Bind you grid here
                nelsoncluster.Visible = false;
                sergiocluster.Visible = false;
                allplayerspic.Visible = true;
            }

            var query = from g in db.Games
                        select g;
            //Text2.Text = query.Count().ToString();
                       
            var q = from g in db.Games
                    where g.playerID.Equals(GetPlayerID())
                    select g;
            //PlayerGamesLabel.Text = q.Count().ToString();
        }

        //Add new game entries to database
        protected void AddButton_Click(object sender, EventArgs e)
        {
            Game g = new Game
            {
                rounds = int.Parse(Rounds.Text),
                bullsrounds = int.Parse(BRounds.Text),
                bulldarts = int.Parse(Bdarts.Text),
                zerorounds = int.Parse(Zero.Text),
                playerID = GetPlayerID()
            };

            //            if(DropDownList1.SelectedIndex != 0)
            //            {

            try
            {
                Player selected = db.Players.Single(p => p.PlayerName == DropDownList1.Text);
                selected.TotGames = selected.TotGames + 1;

                db.Games.InsertOnSubmit(g);
                db.SubmitChanges();
                BindGridViewPlayer();

                //Clear the inputted text
                Rounds.Text = null;
                BRounds.Text = null;
                Bdarts.Text = null;
                Zero.Text = null;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: No player selected')</script>");
                DropDownList1.Focus();
                DropDownList1.BackColor = System.Drawing.Color.Yellow;
            }

        }

        // Delete games gridview and DB
        protected void DelButton_Click(object sender, EventArgs e)
        {

            var query = from g in db.Games
                        where g.playerID == 1
                        select g;

            db.Games.DeleteAllOnSubmit(query);
            db.SubmitChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPlayerPic();
            DropDownList1.BackColor = System.Drawing.Color.White;
            BindGridViewPlayer();
        }

        protected void DropDownList1_SelectedIndex(object sender, EventArgs e)
        {
            
            BindGridViewPlayer();
        }


        // Gets the playerID the Player Table based on Dropdown selection
        private int GetPlayerID()
        {
            var player = from p in db.Players
                         where p.PlayerName == DropDownList1.Text
                         select p.PlayerID;

            return player.FirstOrDefault();
        }

        // Edit the Gridview's row
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;    
            BindGridViewNoAVG();
        }

        // Update the Gridview's row
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Find id to update the row
            int id = (int)GridView1.DataKeys[e.RowIndex].Value;

            // Select specific row from database table
            Game gedit = (from i in db.Games
                                   where i.gameID == id
                                   select i).First();

            //Retreive the new values inputted by the user on Update
            GridViewRow row = GridView1.Rows[e.RowIndex];
            gedit.rounds = int.Parse(((TextBox)row.Cells[2].Controls[0]).Text);
            gedit.bullsrounds = int.Parse(((TextBox)row.Cells[3].Controls[0]).Text);
            gedit.bulldarts = int.Parse(((TextBox)row.Cells[4].Controls[0]).Text);
            gedit.zerorounds = int.Parse(((TextBox)row.Cells[5].Controls[0]).Text);
            

            // Update changes in database table
            db.SubmitChanges();

            GridView1.EditIndex = -1;
            BindGridViewPlayer();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            GridView1.EditIndex = -1;
            //Bind data to the GridView control.
            BindGridViewPlayer();
        }

        // Delete row from database table
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Find game id for edit the row
            int id = (int)GridView1.DataKeys[e.RowIndex].Value;
            // Select specific row from database table
            Game deletegame = (from i in db.Games
                                   where i.gameID == id
                                   select i).First();

            // Delete row from database table
            db.Games.DeleteOnSubmit(deletegame);
            db.SubmitChanges();

            GridView1.EditIndex = -1;
            BindGridViewPlayer();
        }

        // Fill GridView NO Avg
        protected void BindGridViewNoAVG()
        {
            var data = from i in db.Games
                       where i.playerID == GetPlayerID()
                       select i;

            // Show when player selected
            if (DropDownList1.SelectedIndex != 0)
            {
                if (data != null)
                {
                    GridView1.DataSource = data;
                    GridView1.DataBind();
                }
            }
            //Show when All is selected
            else
            {
                BindGridNoAVGall();
            }
        }

        // Fill GridView
        protected void BindGridView()
        {
            var data = from i in db.Games
                       select i;
            if (data != null)
            {
                GridView1.DataSource = data;
                GridView1.DataBind();
                DisplayAverages();
            }
        }

        // Fill GridView
        protected void BindGridNoAVGall()
        {
            var data = from i in db.Games
                       select i;
            if (data != null)
            {
                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }

        // Fill GridView when Player is selected to filter results
        protected void BindGridViewPlayer()
        {   
            var data = from i in db.Games
                       where i.playerID == GetPlayerID()  select i;

            // Show when player selected
            if (DropDownList1.SelectedIndex != 0)
            {
                if (data != null)
                {
                    GridView1.DataSource = data;
                    GridView1.DataBind();
                    DisplayAverages();
                }
            }
            //Show when All is selected
            else
            {
                BindGridView();
                DisplayAverages();
            }

        }

        protected void DisplayAverages()
        {
            AvgRounds();
            AvgBullsRounds();
            AvgBdarts();
            AvgZeroRounds();
        }

        //Calculate Rounds average
        protected void AvgRounds()
        {
            double avg = 0;
            double total = 0;
            double ncounter = 0;

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                if (GridView1.Rows[i].Cells[1].Text.ToString() != " ")
                {
                    total += Convert.ToDouble(GridView1.Rows[i].Cells[1].Text);
                }
                else
                {
                    ncounter++;
                }
            }
            avg = total / GridView1.Rows.Count;
            gcount.Text = GridView1.Rows.Count.ToString();
            //Text2.Text = total.ToString();
            avgrounds.Text = avg.ToString("0.##");
        }

        //Calculate Bull Rounds average
        protected void AvgBullsRounds()
        {
            double avg = 0;
            double total = 0;
            double ncounter = 0;

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                if (GridView1.Rows[i].Cells[2].Text.ToString() != " ")
                {
                    total += Convert.ToDouble(GridView1.Rows[i].Cells[2].Text);
                }
                else
                { 
                    ncounter++;     
                }
            }
            avg = total / (GridView1.Rows.Count - ncounter);
            avgbrounds.Text = avg.ToString("0.##");
        }

        //Calculate Bull Darts average
        protected void AvgBdarts()
        {
            double avg = 0;
            double total = 0;
            double ncounter = 0;

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                if (GridView1.Rows[i].Cells[3].Text.ToString() != " ")
                {
                    total += Convert.ToDouble(GridView1.Rows[i].Cells[3].Text);
                }
                else
                {
                    ncounter++;
                }
            }
            avg = total / (GridView1.Rows.Count - ncounter);
            avgbdarts.Text = avg.ToString("0.##");
        }

        //Calculate Zero Rounds average
        protected void AvgZeroRounds()
        {
            double avg = 0;
            double total = 0;
            double ncounter = 0;

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                if (GridView1.Rows[i].Cells[4].Text.ToString() != " ")
                {
                    total += Convert.ToDouble(GridView1.Rows[i].Cells[4].Text);
                }
                else
                {
                    ncounter++;
                }           
            }
            avg = total / (GridView1.Rows.Count - ncounter);
            avgzrounds.Text = avg.ToString("0.##");
        }

        protected void SetPlayerPic()
        {
            if (GetPlayerID() == 0)
            {
                allplayerspic.Visible = true;
                sergiocluster.Visible = false;
                nelsoncluster.Visible = false;
            }

                if (GetPlayerID() == 1)
            {
                sergiocluster.Visible = true;
                nelsoncluster.Visible = false;
                allplayerspic.Visible = false;

            }
            if (GetPlayerID() == 2)
            {
                nelsoncluster.Visible = true;
                sergiocluster.Visible = false;
                allplayerspic.Visible = false;
            }

        }

    }
}