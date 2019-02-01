<%@ Page Title="David Ortiz" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication2.Models.index" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
            
    <div class="jumbotron myJumbo">
        <div class="row">
            <div class="col-sm-6 text-center jumboImage" >
                <img src="images/avatar.png" alt="avatar" class="myImage" >
            </div>
            <div class="col-sm-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">David Ortiz</h5>
                        <p class="card-text">
                            The Pennsylvania State University <br />
                            Bachelor of Science in Information Sciences and Technology, Design and Development – 3.89 GPA
                        </p>
                        <a href="#" class="btn btn-primary" onclick="window.open('images/Resume_DavidOrtiz.pdf');">View resume</a>

                    </div>
                </div>
            </div>
        </div>
    </div>
            
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            
    

    <%--<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true" >
  <div class="modal-dialog modal-lg" role="document">
    <div class="modal-content">
      <div class="modal-body modalResume" >
        
          <embed src="images/Resume_DavidOrtiz.pdf" style="height:100%; width:100%;"/>
          <iframe src="images/Resume_DavidOrtiz.pdf" style="width:100%; height:100%;" ></iframe>

      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary" onclick="window.open('images/Resume_DavidOrtiz.pdf');">Download</button>
      </div>
    </div>
  </div>
</div>--%>

</asp:Content>