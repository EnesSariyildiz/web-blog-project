<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="AdminDeneyimler.aspx.cs" Inherits="web_blog_project.AdminDeneyimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>Başlık</th>
                <th>Alt Başlık</th>
                <th>Açıklama</th>
                <th>Tarih</th>
                <th>İşlemler</th>

            </tr>
            <tbody>
                <%--tbody table'ın bodysidir. Yani verilerin geleceği alandır.--%>

                <asp:Repeater ID="Repeater1" runat="server">
                    <itemtemplate>
                        <tr>
                            <td><%# Eval("ID") %></td>
                            <td><%# Eval("BASLIK") %></td>
                            <td><%# Eval("ALTBASLIK") %></td>
                            <td><%# Eval("ACIKLAMA") %></td>
                            <td><%# Eval("TARIH") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminDeneyimGuncelle.aspx?=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminDeneyimSil.aspx?=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>

                            </td>
                        </tr>
                    </itemtemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-info" Text="Deneyim Eke" />



    </form>
</asp:Content>
