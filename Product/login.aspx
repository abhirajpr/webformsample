<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Product.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" type="text/css" rel="stylesheet">
</head>
<body class="container">



  <%--  <div class="form-group">
        <label   ID="Label1" class="col-sm-2 control-label">Name</label>
        <div class="col-sm-4">
          <input type="text" class="form-control" id="TextBox1" placeholder="Name">
        </div>
      </div>
    <div class="form-group">
        <label  class="col-sm-2 control-label" id="Label2">Password</label>
        <div class="col-sm-3">
          <input type="password" class="form-control" id="inputPassword1" placeholder="Password">
        </div>
      </div>--%>

    <form id="form1" runat="server">
    <div>
        <%--<div cssclass="form-group">--%>
        <asp:Label ID="Label1" runat="server" Text="Username" ></asp:Label>
        <%-- <div cssclass="col-sm-4">--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" c runat="server"></asp:TextBox>
             
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        <%--<input id="TextBox2" type="password" />--%>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
