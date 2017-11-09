using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Admin_Manager;
using BLL.Admin_Properties;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;

namespace Buyit
{
    public partial class GraphRepresentationStockItem : System.Web.UI.Page
    {
        UserInterface UI = new UserInterface();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = UI.GetCurrentStock1();
            DataTableReader reader = dt.CreateDataReader();
            
            Chart1.DataSource = dt;
            Chart1.ChartAreas[0].AxisX.Title = "Complimentary Item";
            Chart1.ChartAreas[0].AxisY.Title = "Quantity";
            Chart1.DataBind();
            //using (DataTable result = new DataTable())
            //{
            //    result.Load(reader);
            //    if (result.Rows.Count > 0)
            //    {
            //        Chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            //        Chart1.BorderlineColor = System.Drawing.Color.FromArgb(26, 59, 105);
            //        Chart1.BorderlineWidth = 3;
            //        Chart1.BackColor = Color.NavajoWhite;

            //        Chart1.ChartAreas.Add("chtArea");
            //        Chart1.ChartAreas[0].AxisX.Title = "Complimentary Item";
            //        Chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Verdana", 11, System.Drawing.FontStyle.Bold);
            //        Chart1.ChartAreas[0].AxisY.Title = "Quantity";
            //        Chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Verdana", 11, System.Drawing.FontStyle.Bold);
            //        Chart1.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
            //        Chart1.ChartAreas[0].BorderWidth = 2;
            //        //Chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            //        //Chart1.ChartAreas[0].Area3DStyle.Inclination = 45;
            //        //Chart1.ChartAreas[0].Area3DStyle.Rotation = 45;
            //        //Chart1.ChartAreas[0].Area3DStyle.PointDepth = 100;
            //        //Chart1.ChartAreas[0].Area3DStyle.PointGapDepth = 1;

            //        Chart1.Legends.Add("Quantity");
            //        Chart1.Series.Add("Quantity");
            //        //Chart1.Series[0].Palette = ChartColorPalette.Bright;
            //        Chart1.Series[0].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Line;
            //        Chart1.Series[0].Points.DataBindXY(result.DefaultView, "ItemName", result.DefaultView, "Column1");

            //        //Chart1.Series[0].IsVisibleInLegend = true;
            //        Chart1.Series[0].IsValueShownAsLabel = true;
            //        Chart1.Series[0].ToolTip = "Data Point Y Value: #VALY{G}";

            //        // Setting Line Width
            //        Chart1.Series[0].BorderWidth = 3;
            //        Chart1.Series[0].Color = Color.Red;

            //        // Setting Line Shadow
            //        //Chart1.Series[0].ShadowOffset = 5;

            //        //Legend Properties
            //        Chart1.Legends[0].LegendStyle = LegendStyle.Table;
            //        Chart1.Legends[0].TableStyle = LegendTableStyle.Wide;
            //        Chart1.Legends[0].Docking = Docking.Bottom;
            //    }

            //}
        }
    }
}