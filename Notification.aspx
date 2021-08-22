<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Notification.aspx.cs" Inherits="AssuranceApp.Notifikasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- ////////////////////////// Css /////////////////////////-->
    <link href="asset/bs/css/bootstrap.min.css" rel="stylesheet" />
    <link href="asset/css/jquery.dataTables.min.css" rel="stylesheet" />
    <!-- ////////////////////////// End Css /////////////////////////-->
    <title>Notifikasi</title>
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
            <!-- ////////////////////////// content /////////////////////////-->
            <div class="row">
                <div class="col-sm-12">
                    <div class="card">
                        <div class="card-body">
                            <h1>Notifikasi</h1>
                            <hr />
                            <table class="table_id" class="display">
                                <thead>
                                    <tr>
                                        <th>Column 1</th>
                                        <th>Column 2</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Row 1 Data 1</td>
                                        <td>Row 1 Data 2</td>
                                    </tr>
                                    <tr>
                                        <td>Row 2 Data 1</td>
                                        <td>Row 2 Data 2</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <!-- ////////////////////////// End content /////////////////////////-->
        </div>
        
    </form>
    <!-- ////////////////////////// JS /////////////////////////-->
    <script src="asset/js/jquery-3.5.1.slim.min.js"></script>
    <script src="asset/bs/js/bootstrap.min.js"></script>
    <script src="asset/js/popper.min.js"></script>
    <script src="asset/js/jquery.dataTables.min.js"></script>
    <script src="asset/js/dtTable.js"></script>
    <!-- ////////////////////////// end JS /////////////////////////-->
</body>
</html>
