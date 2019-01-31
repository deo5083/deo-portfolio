<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication2.Models.index" %>

<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link href="Style/customCSS.css" rel="stylesheet" />

    <title>David Ortiz</title>
  </head>
    <body>
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="container d-flex flex-grow-1">
                <a class="navbar-brand d-lg-inline-block" href="#">David Ortiz</a>
                <div class="w-50 text-right">
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                </div>
                <div class="collapse navbar-collapse flex-grow-1 text-right" id="navbarNav">
                    <ul class="navbar-nav w-100 justify-content-center">
                        <li class="nav-item active">
                            <a class="nav-link" href="#">Overview <span class="sr-only">(current)</span></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Education</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Experience</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Skills</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
          
        <div class="container">
            
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
                                    The Pennsylvania State University, Center Valley, PA Fall 2019 <br />
                                    Bachelor of Science in Information Sciences and Technology, Design and Development – 3.89 GPA
                                </p>
                                <%--<a href="#" class="btn btn-primary" onclick="window.open('images/Resume_DavidOrtiz.pdf');">Download resume</a>--%>
                                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" data-whatever="@mdo">View resume</button>

                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>

    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true" >
  <div class="modal-dialog modal-lg" role="document">
    <div class="modal-content">
      <div class="modal-body modalResume" >
        
          <embed src="images/Resume_DavidOrtiz.pdf" style="height:100%; width:100%;"/>
<%--          <iframe src="images/Resume_DavidOrtiz.pdf" style="width:100%; height:100%;" ></iframe>--%>

      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary" onclick="window.open('images/Resume_DavidOrtiz.pdf');">Download</button>
      </div>
    </div>
  </div>
</div>


    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
</html>