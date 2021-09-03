<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="AssuranceApp.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- ////////////////////////// Css /////////////////////////-->
    <link href="asset/bs/css/bootstrap.min.css" rel="stylesheet" />
    <link href="asset/css/jquery.dataTables.min.css" rel="stylesheet" />
    <!-- ////////////////////////// End Css /////////////////////////-->
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- ////////////////////////// Register Form /////////////////////////-->
        <div class="container mt-5">
            <div class="row mt-5">
                <div class="col-md-12 col-sm-12">
                    <div class="card mt-5">
                        <div class="card-body">
                            <h1 class="text-center">Register</h1>
                            <hr />
                         <!-- ////////////////////////// register input /////////////////////////-->
                            <div class="row">
                                <div class="col-sm-6">
                                    <h3 class="text-center">Data Pribadi</h3>
                                    <hr />
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">NIK</label>
                                         <asp:TextBox ID="txtNIK" CssClass="form-control" runat="server" TextMode="Number"  required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Nama Lengkap</label>
                                        <asp:TextBox ID="txtNamaLengkap" CssClass="form-control"  runat="server"  required></asp:TextBox>
                                    </div>
                                    <div class="row">   
                                        <div class="col-sm-6">
                                           <div class="form-group">
                                                <label for="exampleInputEmail1">Tanggal Lahir</label>
                                                <asp:TextBox ID="txtTglLahir" CssClass="form-control"  runat="server" TextMode="Date"  required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Tempat Lahir</label>
                                                <asp:TextBox ID="txtTmptLahir" CssClass="form-control"  runat="server"  required></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Jenis Kelamin</label>
                                        <asp:DropDownList ID="ddwnJK" runat="server" CssClass="form-control">
                                            <asp:ListItem Text="Laki-Laki" />
                                            <asp:ListItem Text="Perempuan" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Status Pernikahan</label>
                                        <asp:DropDownList ID="ddwnStatusPernikahan" runat="server" CssClass="form-control">
                                            <asp:ListItem Text="Single" />
                                            <asp:ListItem Text="Married" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Nomor Telp</label>
                                                <asp:TextBox ID="txtNoTelp" CssClass="form-control"  runat="server" TextMode="Number"  required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Nomor Telp Rumah</label>
                                                <asp:TextBox ID="txtNoTelpRumah" CssClass="form-control"  runat="server" TextMode="Number"  required></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    
                                    
                                    <div class="form-group">
                                        <label for="exampleInputEmail1">Alamat</label>
                                        <asp:TextBox ID="txtAlamat" CssClass="form-control"  runat="server"  required></asp:TextBox>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Kelurahan</label>
                                                <asp:TextBox ID="txtKelurahan" CssClass="form-control"  runat="server"  required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label for="exampleInputEmail1">kecamatan</label>
                                                <asp:TextBox ID="txtKecamatan" CssClass="form-control"  runat="server"  required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Kota</label>
                                                <asp:TextBox ID="txtKota" CssClass="form-control"  runat="server"  required></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    
                                </div>
                                <div class="col-sm-6">
                                    <h3 class="text-center">Data Akun</h3>
                                    <hr />
                                     <div class="form-group">
                                        <label for="exampleInputEmail1">Username</label>
                                         <asp:TextBox ID="txtUsername" CssClass="form-control"  runat="server"  required></asp:TextBox>
                                    </div>
                                     <div class="form-group">
                                        <label for="exampleInputEmail1">Password</label>
                                         <asp:TextBox ID="txtPassword" CssClass="form-control" TextMode="Password"  runat="server"  required></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                         <!-- ////////////////////////// register input /////////////////////////-->
                            <hr class="mb-5" />
                            <asp:Button ID="btnSumbit" OnClick="btnSumbit_Click" CssClass="btn btn-primary" runat="server" Text="Sumbit" />
                            <asp:HyperLink ID="HyperLink3" runat="server" CssClass="btn btn-secondary" NavigateUrl="~/login.aspx" Text="Kembali" />
                            <asp:Label ID="lblWarning" CssClass="text-danger" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- ////////////////////////// End Register form /////////////////////////-->
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
