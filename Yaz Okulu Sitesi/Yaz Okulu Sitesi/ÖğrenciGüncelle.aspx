<%@ Page Title="" Language="C#" MasterPageFile="~/AnaSayfa.master" AutoEventWireup="true" CodeFile="ÖğrenciGüncelle.aspx.cs" Inherits="ÖğrenciGüncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <form id="form1" runat="server">
        <table style="font-family:monospace" class="table table-bordered table-hover">
        <tr>
            <td class="modal-sm" style="width: 192px">ÖĞRENCİ ADI:</td>
            <td>
                <asp:TextBox ID="txtboxad" runat="server" Width="205px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 192px; height: 40px;">ÖĞRENCİ SOYADI:</td>
            <td style="height: 40px">
                <asp:TextBox ID="txtboxsoyad" runat="server" Width="206px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 192px">ÖĞRENCİ MAİL:</td>
            <td>
                <asp:TextBox ID="txtboxmail" runat="server" TextMode="Email" Width="204px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 192px">ÖĞRENCİ ŞİFRESİ:</td>
            <td>
                <asp:TextBox ID="txtboxsifre" runat="server" style="margin-bottom: 0" TextMode="Password" Width="207px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 192px">ÖĞRENCİ OKUL NUMARASI:</td>
            <td>
                <asp:TextBox ID="txtboxokulno" runat="server" Width="207px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm"  style="width: 192px">&nbsp;</td>
            <td class="text-left">
                <asp:Button  Font-Size="Large" ID="btnkayıtol" runat="server" Height="74px" Text="Güncelle" Width="168px" OnClick="btnkayıtol_Click"/>
            </td>
        </tr>
    </table>
    </form>
</asp:Content>

