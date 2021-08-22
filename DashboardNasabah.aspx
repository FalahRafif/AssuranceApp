<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashboardNasabah.aspx.cs" Inherits="AssuranceApp.DashboardNasabah" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- ////////////////////////// Css /////////////////////////-->
    <link href="asset/bs/css/bootstrap.min.css" rel="stylesheet" />
    <link href="asset/css/jquery.dataTables.min.css" rel="stylesheet" />
    <!-- ////////////////////////// End Css /////////////////////////-->
    <title>Dashboard</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container"> 
            <!-- ////////////////////////// Navbar /////////////////////////-->
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
              <a class="navbar-brand font-weight-bold" href="#">Aplikasi Asuransi</a>
              <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
              </button>

              <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                  <li class="nav-item active">
                    <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
                  </li>
                  <li class="nav-item active">
                    <a class="nav-link" href="#">Store</a>
                  </li>
                    </li>
                    <li class="nav-item active">
                    <a class="nav-link" href="#">Notifikasi</a>
                  </li>
                </ul>
              </div>
            </nav>
            <!-- ////////////////////////// End navbar /////////////////////////-->
            <!-- ////////////////////////// Jumbotron /////////////////////////-->
            <div class="jumbotron">
              <h1 class="display-4">Selamat Datang Nasabah</h1>
              <p class="lead">selalu waspada pada setiap situasi yang ada</p>
              <hr class="my-4">
              <p>Tapi tidak perlu khawatir kami selalu ada untuk kamu <3</p>
            </div>
            <!-- ////////////////////////// End Jumbotron /////////////////////////-->
            <div class="row">   
                <div class="col-sm-12">
                    <!-- ////////////////////////// content /////////////////////////-->
                    <div class="card  ">
                        <div class="card-body">
                            <h1>Asuransi Aktif</h1>
                            <hr />
                            <!-- ////////////////////////// card asuransi /////////////////////////-->
                            <div class="row">
                                <div class="col-sm-12">
                                    <div class="card border-primary mb-5">
                                        <div class="card-header">Asuransi A</div>
                                        <div class="card-body">
                                            <h3>Info asuransi</h3>
                                            <p>Policy Number 2344-2342-2342</p>
                                            <p>Status : inforce</p>
                                            <p>Benefit : 200000</p>
                                            <p>Exp : 2021-10-12</p>
                                            <p>Max claim : 5</p>
                                            <p>Total Claim : 5</p>
                                            <button class="btn btn-primary">Claim Asuransi</button>
                                        </div>
                                       
                                    </div>
                                </div>
                                <div class="col-sm-12">
                                    <div class="card border-primary mb-5">
                                        <div class="card-header">Asuransi A</div>
                                        <div class="card-body">
                                            <h3>Info asuransi</h3>
                                            <p>Policy Number 2344-2342-2342</p>
                                            <p>Status : inforce</p>
                                            <p>Benefit : 200000</p>
                                            <p>Exp : 2021-10-12</p>
                                            <p>Max claim : 5</p>
                                            <p>Total Claim : 5</p>
                                            <button class="btn btn-primary">Claim Asuransi</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- ////////////////////////// end card asuransi /////////////////////////-->
                        </div>
                    </div>
                    <!-- ////////////////////////// end content /////////////////////////-->
                </div>
            </div>
        </div>
    </form>
    <!-- ////////////////////////// JS /////////////////////////-->
    <script src="asset/js/jquery-3.5.1.slim.min.js"></script>
    <script src="asset/js/popper.min.js"></script>
    <script src="asset/bs/js/bootstrap.min.js"></script>
    <script src="asset/js/dtTable.js"></script>
    <script src="asset/js/jquery.dataTables.min.js"></script>
    <!-- ////////////////////////// end JS /////////////////////////-->
</body>
</html>
