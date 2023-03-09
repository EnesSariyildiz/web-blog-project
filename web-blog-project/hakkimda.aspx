<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="hakkimda.aspx.cs" Inherits="web_blog_project.hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label1" runat="server" Text="Adınız:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" ></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="Soyadınız:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label3" runat="server" Text="Adresiniz:"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label4" runat="server" Text="Mailiniz:"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label5" runat="server" Text="Telefonunuz:"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label6" runat="server" Text="Kısa Notunuz:"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label7" runat="server" Text="Fotoğrafınız:"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" />

        </div>
    </form>


</asp:Content>
