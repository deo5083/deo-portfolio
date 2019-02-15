<%@ Page Title="Skills" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Skills.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="collapse_content text-center">
        <span class="text-muted small">Jump to:</span>
        <a href="#skill_a" class="badge badge-light">Skill Section</a> 
        <span>&#8226;</span>
        <a href="#tools_a" class="badge badge-light">Tools Section</a>
        <span>&#8226;</span>
        <a href="#knowledge_a" class="badge badge-light">Knowledge Section</a>
    </div>

    <%--only show on mobile phones--%>
    <div class="d-lg-none"> 
        <br />
    </div>

    <div id="skill_a">
        <i class=" fa fa-check-square-o" aria-hidden="true">
            <span class="h3">Skills</span>
        </i>
    </div>
    <hr />
    <div class="card-columns" id="cards_skills_div" runat="server"> </div>
    <br />  

    <div id="tools_a">
        <i class=" fa fa-wrench" aria-hidden="true">
            <span class="h3">Tools</span>
        </i>
    </div>
    <hr />
    <div class="card-columns" id="cards_tools_div" runat="server"> </div>
    <br />  

    <div id="knowledge_a">
        <i class=" fa fa-book" aria-hidden="true">
            <span class="h3">Knowledge</span>
        </i>
    </div>
    <hr />
    <div class="card-columns" id="cards_knowledge_div" runat="server"> </div>


    <a href="#top_of_page" id="backToTopButton">Top</a>

    <script>

        window.onscroll = function () { scrollFunction() };
        
    </script>

</asp:Content>
