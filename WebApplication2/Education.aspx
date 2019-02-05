<%@ Page Title="Education"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Education.aspx.cs" Inherits="WebApplication2.Education" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
            
    <br />

    <div runat="server" id="cards_div" class="list-group"></div>

    <hr />

    <div class="jumbotron jumbotron-fluid myJumbo">
        <div class="container">
            <h3>
                <asp:Label ID="Label_school" runat="server" Text="Select a degree above to see more info!"></asp:Label>
                <asp:Label ID="Label_Type" runat="server" Text="" CssClass="text-muted pull-right small" Visible="false"></asp:Label>
            </h3>
            
            <asp:Panel runat="server" ID="Panel_degreeInfo" Visible="false">
                
                <%--only show on mobile phones--%>
                <div class="d-lg-none"> 
                    <br /><br />
                </div>
                
                <div class="form-row">
                    <div class="form-group col-md-10">
                        <p class="lead">
                            <asp:Label ID="Label_Degree" runat="server" Text=""></asp:Label> - GPA: <asp:Label ID="Label_GPA" runat="server" Text=""></asp:Label>
                        </p>
                    </div>
                    <div class="form-group col-md-2">
                        <asp:Label ID="Label_gradDate" runat="server" Text="" CssClass="lead"></asp:Label>
                    </div>
                </div>

                <hr />

            </asp:Panel>

        </div>
    </div>




    <asp:HiddenField ID="HiddenField_selectDegree"  runat="server" />
    <asp:Button ID="HiddenButton_selectDegree" OnClick="HiddenButton_selectDegree_Click" runat="server" Text="" />

</asp:Content>
