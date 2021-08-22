<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AssuranceApp.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- ////////////////////////// Css /////////////////////////-->
    <link href="asset/bs/css/bootstrap.min.css" rel="stylesheet" />
    <link href="asset/css/jquery.dataTables.min.css" rel="stylesheet" />
    <!-- ////////////////////////// End Css /////////////////////////-->
    <title>Checkout</title>
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
                    <li class="nav-item active">
                    <a class="nav-link" href="#">Notifikasi</a>
                  </li>
                </ul>
              </div>
            </nav>
            <!-- ////////////////////////// End navbar /////////////////////////-->
            <div class="row mt-5">
                <div class="col-sm-12">
                    <div class="card">
                        <div class="card-body">
                            <h1>checkout</h1>
                            <hr />
                            <h4>Jenis Asuransi  </h4>
                            <hr />
                            <p>Asuransi Kesehatan Cepat Sembuh </p>
                            <p>info asuransi :</p>
                                            <p>Benefit : 200000</p>
                                            <p>Exp : 2021-10-12</p>
                                            <p>Max claim : 5</p>
                            <h4>Payment</h4>
                             <hr />
                            <div class="row">
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Pilih Payment</label>
                                        <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
                                      </div>
                                </div>
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Card Number</label>
                                        <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
                                      </div>
                                </div>
                               
                            </div>
                             <button class="btn btn-primary">Beli</button>
                        
                    </div>
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
