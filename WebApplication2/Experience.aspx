<%@ Page Title="Experience" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Experience.aspx.cs" Inherits="WebApplication2.WebForm1" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="row">
        
        <div class="col-sm-6 rounded ">
            <div class="accordion rounded" id="accordionOverview">
                <div class="card rounded">
                    <div class="card-header overview-divs rounded" id="headingOverviewOne" data-toggle="collapse" data-target="#collapseOverviewOne">
                        <div class="text-center">
                            <div>
                                <h5 class="mb-0">
                                    Quick Overview 
                                </h5>
                            </div>
                            <span class="mb-1">
                                Click to toggle
                            </span>
                        </div>
                    </div>

                    <div id="collapseOverviewOne" class="collapse" aria-labelledby="headingOverviewOne" data-parent="#accordionOverview">
                        <div class="card-body" id="overview_div" runat="server"></div>
                    </div>
                </div>
            </div>
        </div>

        <div class="col-sm-6 rounded">
            <div class="accordion rounded" id="accordionFavorites">
                <div class="card rounded">
                    <div class="card-header overview-divs rounded" id="headingFavoritesOne" data-toggle="collapse" data-target="#collapseFavoritesOne">
                        <div class="text-center">
                            <div>
                                <h5 class="mb-0">
                                    My Favorites
                                </h5>
                            </div>
                            <span class="mb-1">
                                Click to toggle
                            </span>
                        </div>
                    </div>

                    <div id="collapseFavoritesOne" class="collapse" aria-labelledby="headingFavoritesOne" data-parent="#accordionFavorites">
                        <div class="card-body" id="favorites_div" runat="server"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <br />
    <div class="collapse_content text-center">
        <span class="text-muted small">Jump to:</span>
        <a href="#work_exp" class="badge badge-light">Work Section</a> 
        <span>&#8226;</span>
        <a href="#project_exp" class="badge badge-light">Projects Section</a>
    </div>
   
    <div class="jumbotron myJumbo" id="work_exp"> 
        <p>Work Experience</p>
        <div id="div_workExp" runat="server"></div>
    </div>

    <div class="jumbotron myJumbo" id="project_exp"> 
        <p>Project Experience</p>
        <div id="div_projectExp" runat="server"></div>
    </div>
    
    <a href="#top_of_page" id="backToTopButton">Top</a>
    
    <script>

        window.onscroll = function () { scrollFunction() };
        
    </script>

</asp:Content>
