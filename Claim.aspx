<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Claim.aspx.cs" Inherits="AssuranceApp.Claim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- ////////////////////////// Css /////////////////////////-->
    <link href="asset/bs/css/bootstrap.min.css" rel="stylesheet" />
    <link href="asset/css/jquery.dataTables.min.css" rel="stylesheet" />
    <!-- ////////////////////////// End Css /////////////////////////-->
    <title>Claim</title>
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
                <div class="col-sm-12">
                    <div class="card">
                        <div class="card-body">
                            <h3>Claim Asuransi</h3>
                            <hr />
                            <div class="row">
                                <!-- ////////////////////////// form /////////////////////////-->
                                <div class="col-sm-6">
                                    <h5 class="text-center">Data Claim</h5>
                                    <hr />
                                    <asp:TextBox ID="txtIdPolis" Style="display: none" runat="server"></asp:TextBox>
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Nama Rumah Sakit</label>
                                        <asp:TextBox ID="txtHpName" CssClass="form-control"  runat="server" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Alamat Rumah Sakit</label>
                                        <asp:TextBox ID="txtHpAddress" CssClass="form-control"  runat="server" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">No Telp Rumah Sakit</label>
                                        <asp:TextBox ID="txtHpNumber" CssClass="form-control"  runat="server" TextMode="Number" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">No Pasien</label>
                                        <asp:TextBox ID="txtNoPasien" CssClass="form-control"  runat="server" TextMode="Number" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Banyak Claim</label>
                                        <asp:TextBox ID="txtBanyakClaim" CssClass="form-control"  runat="server" TextMode="Number" required></asp:TextBox>
                                    </div>
                                </div>
                                <!-- ////////////////////////// End form /////////////////////////-->
                                <!-- ////////////////////////// info asuransi /////////////////////////-->
                                <div class="col-sm-6">
                                    <h5 class="text-center">Info Asuransi</h5>
                                    <hr />
                                    <asp:Repeater ID="showAssurance" runat="server">
                                        <HeaderTemplate></HeaderTemplate>
                                        <ItemTemplate>
                                            <p>Nama Assuransi : <%# Eval("AssuranceName") %></p>
                                            <p>Policy Number : <%# Eval("PolicyNumber") %></p>
                                            <p>Status : <%# Eval("StatusPolis") %></p>
                                            <p>Benefit : <%# Eval("DetailProduct")  %></p>
                                            <p>Date Start : <%# ((DateTime)Eval("DateStart")).ToString("yyyy/MM//dd")%></p>
                                            <p>Date Expired : <%# ((DateTime)Eval("DateExp")).ToString("yyyy/MM//dd") %></p>
                                            <p>Max claim : <%# Eval("MaxClaim") %></p>
                                        </ItemTemplate>
                                        <FooterTemplate></FooterTemplate>
                                    </asp:Repeater>
                                    
                                </div>
                                <!-- ////////////////////////// End navbar /////////////////////////-->
                            </div>
                            <asp:Button ID="btnSumbit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" runat="server" Text="Claim" />
                            <a href="dashboardnasabah.aspx" class="btn btn-secondary">Kembali</a>
                            <asp:Label ID="lblWarning" runat="server" CssClass="text-danger" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <!-- ////////////////////////// End Card /////////////////////////-->
            
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
