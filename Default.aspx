<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <div class="jumbotron">
        <h1>File Transfer App</h1>
        <p class="lead">Simple web application to copy files </p>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="Button2" class="btn btn-primary btn-lg" runat="server" Font-Bold="False" Text="Copy" Width="100px" OnClick="Transfer_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="" class="success"></asp:Label>
        </ContentTemplate>
        </asp:UpdatePanel>
        
    </div>
    
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
            copying files please wait...
            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/prog.gif" />
        </ProgressTemplate>
        
    </asp:UpdateProgress>
   

</asp:Content>
