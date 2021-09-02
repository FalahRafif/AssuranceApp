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
            <!-- ////////////////////////// content /////////////////////////-->
            <div class="row">
                <div class="col-sm-12">
                    <div class="card">
                        <div class="card-body">
                            <h1>Notifikasi</h1>
                            <hr />
                            
                            <asp:Repeater ID="showNotif" runat="server">
                                <HeaderTemplate>
                                    <table class="table_id" class="display">
                                        <thead>
                                            <tr>
                                                <th>Tanggal</th>
                                                <th>Status</th>
                                                <th>Pesan</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    
                                            <tr>
                                                <td><%# Eval("NotifDate") %></td>
                                                <td><%# Eval("NotifStatus") %></td>
                                                <td><%# Eval("Msg") %></td>
                                            </tr>
                                           
                                </ItemTemplate>
                                <FooterTemplate>
                                     </tbody>
                                    </table>
                                </FooterTemplate>
                            </asp:Repeater>
                            
                                    
                                
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
