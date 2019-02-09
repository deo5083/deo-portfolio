<%@ Page Title="Education"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Education.aspx.cs" Inherits="WebApplication2.Education" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    
    
    <div class="custom_parent">
      <div class="custom_wide text-center"><hr /></div>
      <div class="custom_narrow"><asp:Button ID="HiddenButton_selectDegree" OnClick="HiddenButton_selectDegree_Click" CssClass="hidebutton" runat="server" Text="" /></div>
    </div>

    <div runat="server" id="cards_div" class="list-group"></div>

    <hr />

    <div class="jumbotron jumbotron-fluid myJumbo">
        <div class="container">
            <div id="label_div" class="text-center">
                <h3>
                    <asp:Label ID="Label_school" runat="server" Text="Select a degree above to see more info!"></asp:Label>
                    <asp:Label ID="Label_Type" runat="server" Text="" CssClass="text-muted pull-right small" Visible="false"></asp:Label>
                </h3>
            </div>
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

                <div class="text-center">
                    <small style="color:grey">Related Coursework</small>
                </div>
                <hr />

                <div runat="server" id="panels_here"></div>

                <hr />

            </asp:Panel>

        </div>
    </div>

    <asp:HiddenField ID="HiddenField_selectDegree"  runat="server" />

</asp:Content>
