<%@ Page Title="Education"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Education.aspx.cs" Inherits="WebApplication2.Education" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
            
    <br />

    <div runat="server" id="cards_div" class="list-group"></div>



    <br /><br /><br />
    <div class="table-responsive" runat="server" style="max-height:700px; min-height:300px; width:100%;">
        <asp:GridView ID="GridView_Education" runat="server" CssClass="table"></asp:GridView>
    </div>


    <br />

</asp:Content>
