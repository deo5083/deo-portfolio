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

                        <div class="text-center">
                            <ul class="list-unstyled">
                                <li class="text-left contact_li"><a href="https://www.google.com/maps/place/Bethlehem,+PA+18018/@40.6238902,-75.3958695,17z/data=!3m1!4b1!4m5!3m4!1s0x89c43e569cd272cb:0x2bc60930265d77ab!8m2!3d40.6238902!4d-75.3936808" target="_blank" class="contact_link"> <i class="fa fa fa-map-marker"></i> Bethlehem, PA 18018, USA</a></li>
                                <li class="text-left contact_li">
                                    <div runat="server" id="not_mobile">
                                        <a class="contact_link"> <i class="fa fa fa-phone"></i> 301-785-8538</a>
                                    </div>
                                    <div runat="server" id="mobile"> 
                                        <a href="tel:+13017858538"class="contact_link"> <i class="fa fa fa-phone"></i> 301-785-8538</a>
                                    </div>
                                </li>
                                <li class="text-left contact_li"><a href="mailto:davide_ortiz9@hotmail.com?Subject=FromOnlineResume:%20" class="contact_link"> <i class="fa fa fa-envelope"></i> davide_ortiz9@hotmail.com</a></li>
                            </ul>
                        </div>
                        <div class="text-center">
                            <a href="#" class="btn btn-dark" onclick="window.open('images/Resume_DavidOrtiz.pdf');">View resume</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
            

</asp:Content>