<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cancel.aspx.cs" Inherits="AssuranceApp.Cancel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- ////////////////////////// Css /////////////////////////-->
    <link href="asset/bs/css/bootstrap.min.css" rel="stylesheet" />
    <link href="asset/css/jquery.dataTables.min.css" rel="stylesheet" />
    <!-- ////////////////////////// End Css /////////////////////////-->
    <title>Cancel Assuransi</title>
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
            <!-- ////////////////////////// Card /////////////////////////-->
            <div class="row mt-5">
                <div class="col-md-3 col-sm-12"></div>
                <div class="col-md-6 col-sm-12">
                    <div class="card border-danger">
                        <div class="card-body">
                            <h3 class="text-center">Cancel Assuransi</h3>
                            <hr />
                            <asp:Repeater ID="showAssurance" runat="server">
                                <HeaderTemplate></HeaderTemplate>
                                <ItemTemplate>
                                    <!-- ////////////////////////// Card Info /////////////////////////-->
                                    <p class="text-danger">Apakah Anda Yakin Untuk Mengcancel Assuransi ini?</p>
                                    <p class="font-weight-bold">Jenis Asuransi : <%# Eval("AssuranceName") %> </p>
                                    <hr />
                                    <p class="font-weight-bold">Info asuransi :</p>
                                    <p>Premi : <%# Eval("Premi") %></p>                
                                    <p>Coverage : <%# Eval("CoverageMonth") %> Bulan</p>                
                                    <p class="mb-5">Benefit : <%# Eval("DetailProduct") %></p> 
                                    <!-- ////////////////////////// End Card Info /////////////////////////-->
                                </ItemTemplate>
                                <FooterTemplate></FooterTemplate>
                            </asp:Repeater>
                            <asp:TextBox ID="txtIdPolis" style="display: none" runat="server" Text=""></asp:TextBox>
                            <asp:HyperLink ID="HyperLink4" runat="server" CssClass="btn btn-success" NavigateUrl="~/DashboardNasabah.aspx" Text="Batal Cancel Assuransi" />
                            <asp:Button ID="btnCancel" OnClick="btnCancel_Click" CssClass="btn btn-danger" runat="server" Text="Cancel Assuransi" /> 
                        </div>
                    </div>
                </div>
                <div class="col-md-3 col-sm-12"></div>
            </div>
        </div>
        <!-- ////////////////////////// End Card /////////////////////////-->
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
