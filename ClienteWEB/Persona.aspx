<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Persona.aspx.cs" Inherits="ClienteWEB.Persona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <!--Formulario del CRUD para la tabla Persona-->
     <br />
    <h1>BUSCAR PERSONAS POR DNI:</h1>
    <br />
    <p>Ingrese DNI completo: <asp:TextBox runat="server" Id="txtId"/>
        <asp:RequiredFieldValidator ID="frvId" runat="server" ControlToValidate="txtId" ErrorMessage="Ingrese DNI Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="frvId2" runat="server" ControlToValidate="txtId" ErrorMessage="Ingrese DNI Obligatorio" ValidationGroup="B">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="rfvId3" runat="server" ControlToValidate="txtId" ErrorMessage="Ingrese DNI Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>
        <asp:Button ID="btnBuscar" runat="server"  class="btn btn-success " OnClick="btnBuscar_Click"  ValidationGroup="A" Text="BUSCAR" />
    </p>
    <p>
        <asp:GridView runat="server" Id="gvPersona" Width="575px"> </asp:GridView>
    </p>
    <p>
    </p>
    <asp:ValidationSummary ID="ValidationSummary3" runat="server" ValidationGroup="C" />
    <asp:ValidationSummary ID="ValidationSummary2" runat="server" ValidationGroup="B" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="A" />
</asp:Content>
