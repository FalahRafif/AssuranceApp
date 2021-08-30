<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Store.aspx.cs" Inherits="AssuranceApp.Store" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- ////////////////////////// Css /////////////////////////-->
    <link href="asset/bs/css/bootstrap.min.css" rel="stylesheet" />
    <link href="asset/css/jquery.dataTables.min.css" rel="stylesheet" />
    <!-- ////////////////////////// End Css /////////////////////////-->
    <title>Toko</title>
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
                   <asp:HyperLink ID="Link1" runat="server" CssClass="nav-link" NavigateUrl="~/DashboardNasabah.aspx" Text="Home" />
                  </li>

                  <li class="nav-item active">

                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="nav-link" NavigateUrl="~/Store.aspx" Text="Store" />
                  </li>

                    </li>
                    <li class="nav-item active">
                        
                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass="nav-link" NavigateUrl="~/Notification.aspx" Text="Notifikasi" />
                  </li>

                </ul>
              </div>
            </nav>
            <!-- ////////////////////////// End navbar /////////////////////////-->
            <div class="jumbotron">
              <h1 class="display-4">Toko Asuransi</h1>
              <hr class="my-4">
              <p>Pilih asuransi yang sesuai dengan kebutuhan kamu <3</p>
            </div>
            <!-- ////////////////////////// content /////////////////////////-->
            <div class="row">
                <!-- ////////////////////////// card asuransi /////////////////////////-->
                <asp:Repeater ID="showAssurance" runat="server">
                    <HeaderTemplate></HeaderTemplate>
                    <ItemTemplate>
                        <div class="col-sm-6">
                            <div class="card mb-5">
                                <div class="card-body">
                                    <h3><%# Eval("AssuranceName") %></h3>
                                    <hr />
                                    <h3>Info asuransi</h3>
                                    <p>Premi : <%# Eval("Premi") %></p>                
                                    <p>Coverage : <%# Eval("CoverageMonth") %> Bulan</p>                
                                    <p>Benefit : <%# Eval("DetailProduct") %></p> 

                                    <a href="Checkout.aspx?idProduct=<%# Eval("IdProductAssurance") %>" class="btn btn-primary">Beli Asssuransi</a>              
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                    <FooterTemplate></FooterTemplate>
                    
                </asp:Repeater>
               
                
                <!-- ////////////////////////// end card asuransi /////////////////////////-->
            </div>
            <!-- ////////////////////////// End content /////////////////////////-->
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
