<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="GraphRepresentationStockItem.aspx.cs" Inherits="Buyit.GraphRepresentationStockItem" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div style="margin-left:18%; margin-top:-15%;">
      <%--<asp:Chart ID="Chart1" runat="server" Width="1000px" Height="500px">
          
      </asp:Chart>--%>

      <asp:Chart ID="Chart1" runat="server" Palette="EarthTones" Height="400px" Width="400px"> 
<Series> 
<asp:Series Name="Series1" ChartType="StackedColumn" XValueMember="ItemName" YValueMembers="Column1"> 
</asp:Series> 
</Series> 
<ChartAreas> 
<asp:ChartArea Name="ChartArea1"> 
</asp:ChartArea> 
</ChartAreas> 
</asp:Chart> 
    </div>


</asp:Content>
