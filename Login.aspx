<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AssuranceApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

    
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- ////////////////////////// Css /////////////////////////-->
    <link href="asset/bs/css/bootstrap.min.css" rel="stylesheet" />
    <link href="asset/css/jquery.dataTables.min.css" rel="stylesheet" />
    <!-- ////////////////////////// End Css /////////////////////////-->
    <title>AssuranceApp</title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- ////////////////////////// Login Form /////////////////////////-->
        <div class="container mt-5">
            <div class="row mt-5">
                <div class="col-md-4 col-sm-12"></div>
                <div class="col-md-4 col-sm-12">
                    <div class="card mt-5">
                        <div class="card-body">
                            <h1 class="text-center">Login</h1>
                            <!-- ////////////////////////// Login input /////////////////////////-->
                              <div class="form-group">
                                <label for="exampleInputEmail1">Username</label>
                                  <asp:TextBox ID="txtUser" CssClass="form-control" placeholder="Enter Username" runat="server" ></asp:TextBox>
                              </div>
                              <div class="form-group">
                                <label for="exampleInputPassword1">Password</label>
                                  <asp:TextBox ID="txtPass" CssClass="form-control" placeholder="Enter Password" runat="server" TextMode="password"></asp:TextBox>
                              </div>
                            <asp:Button ID="btnLogin" OnClick="btnLogin_Click" CssClass="btn btn-primary" runat="server" Text="Login" />
                            <asp:Label ID="LblWarning" CssClass="text-warning" runat="server" Text=""></asp:Label>
                            <!-- ////////////////////////// end Login input /////////////////////////-->
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-12"></div>
            </div>
        </div>
        <!-- ////////////////////////// end Login Form /////////////////////////-->
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
