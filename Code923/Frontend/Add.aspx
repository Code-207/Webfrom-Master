<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/Site1.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Code923.Frontend.assets.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0">
    <!-- VENDOR CSS -->
    <link rel="stylesheet" href="assets/vendor/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="assets/vendor/font-awesome/css/font-awesome.min.css">
    <link rel="s
        tylesheet" href="assets/vendor/linearicons/style.css">
    <link rel="stylesheet" href="assets/vendor/chartist/css/chartist-custom.css">
    <!-- MAIN CSS -->
    <link rel="stylesheet" href="assets/css/main.css">
    <!-- FOR DEMO PURPOSES ONLY. You should remove this in your project -->
    <link rel="stylesheet" href="assets/css/demo.css">
    <!-- GOOGLE FONTS -->
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700" rel="stylesheet">
    <!-- ICONS -->
    <link rel="apple-touch-icon" sizes="76x76" href="assets/img/apple-icon.png">
    <link rel="icon" type="image/png" sizes="96x96" href="assets/img/favicon.png">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="main-content">
				<div class="container-fluid">
    <form>
        Name:<asp:TextBox runat="server" ID="name"/>
        <asp:RequiredFieldValidator ControlToValidate="name" runat="server"  ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:Button runat="server"/>
        <input id="Reset1" type="reset" value="reset" />
        <asp:FileUpload runat="server" BorderStyle="Ridge"></asp:FileUpload>
        <button type="submit">up</button>
    </form>
    </div>
        </div>
    </div>
    
</asp:Content>
