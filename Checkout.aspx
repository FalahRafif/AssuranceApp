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
                   <asp:HyperLink ID="Link1" runat="server" CssClass="nav-link" NavigateUrl="~/DashboardNasabah.aspx" Text="Home" />
                  </li>

                  <li class="nav-item active">

                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="nav-link" NavigateUrl="~/Store.aspx" Text="Store" />
                  </li>

                    </li>
                    <li class="nav-item active">
                        
                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass="nav-link" NavigateUrl="~/Notification.aspx" Text="Notifikasi" />
                  </li>
                    <li class="nav-item active">
                        
                    <asp:HyperLink ID="HyperLink3" runat="server" CssClass="nav-link" NavigateUrl="~/Logout.aspx" Text="Logout" />
                  </li>
                </ul>
              </div>
            </nav>
            <!-- ////////////////////////// End navbar /////////////////////////-->
            <div class="row mt-5">
                <div class="col-sm-12">
                    <div class="card">
                        <div class="card-body">
                            <!-- ////////////////////////// show data asuransi /////////////////////////-->
                            
                            <asp:Repeater ID="showAssurance"  runat="server">
                                <HeaderTemplate>
                                    <h1>checkout</h1>
                                    <hr />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <h4>Jenis Asuransi : <%# Eval("AssuranceName") %> </h4>
                                    <hr />
                                    <h4>Info asuransi :</h4>
                                    <p>Premi : <%# Eval("Premi") %></p>                
                                    <p>Coverage : <%# Eval("CoverageMonth") %> Bulan</p>                
                                    <p class="mb-5">Benefit : <%# Eval("DetailProduct") %></p> 
                                </ItemTemplate>
                                <FooterTemplate></FooterTemplate>
                            </asp:Repeater>

                             <!-- ////////////////////////// End show data asuransi /////////////////////////-->
                            <!-- ////////////////////////// Data payment /////////////////////////-->
                            <h4>Payment :</h4>
                             <hr />
                            <div class="row">
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Pilih Payment</label>

                                        <asp:TextBox ID="txtIdProduct" Style="display: none" runat="server"></asp:TextBox>

                                        <asp:DropDownList ID="ddwnPayment" CssClass="form-control" runat="server">
                                            <asp:ListItem Text="BCA" />
                                            <asp:ListItem Text="Mandiri" />
                                            <asp:ListItem Text="BRI (BRIVA)" />
                                            <asp:ListItem Text="BNI" />
                                            <asp:ListItem Text="Mandiri Syariah" />
                                        </asp:DropDownList>
                                      </div>
                                </div>
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Card Number</label>
                                        <asp:TextBox ID="txtCard" CssClass="form-control" runat="server" required></asp:TextBox>
                                      </div>
                                </div>
                               
                            </div>
                            <asp:Button ID="btnBeli" OnClick="btnBeli_Click" CssClass="btn btn-primary" runat="server" Text="Beli" />
                            <a href="Store.aspx" class="btn btn-secondary">Kembali</a>
                            <asp:Label ID="labelWarning" CssClass="text-danger" runat="server" Text=""></asp:Label>
                        <!-- ////////////////////////// EndData Payment /////////////////////////-->
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
