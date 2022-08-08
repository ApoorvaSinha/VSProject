<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Theater.aspx.cs" Inherits="MovieWebApp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Theater Entry</h2>
    <hr />
    <div class="form-group">
        <label> Theater Id</label>
        <asp:TextBox runat="server" ID="txtTheaterId" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label> Theater Name</label>
        <asp:TextBox runat="server" ID="txtTheaterName" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label> Theater Description</label>
        <asp:TextBox runat="server" ID="txtTheaterDesc" CssClass="form-control" OnTextChanged="txtTheaterDesc_TextChanged" />
    </div>
    <div class="form-group">
        <label> Theater Type</label>
        <asp:TextBox runat="server" ID="txtTheaterType" CssClass="form-control" />
    </div>

    <asp:Button runat="server" ID="btnSave" Text="Save" CssClass="btn btn-success" OnClick="btnSave_Click" />
    <asp:Button runat="server" ID="btnEdit" Text="Edit" CssClass="btn btn-info" OnClick="btnEdit_Click" />
    <asp:Button runat="server" ID="btnUpdate" Text="Update" CssClass="btn btn-info" OnClick="btnUpdate_Click" />
    <asp:Button runat="server" ID="btnDelete" Text="Delete" CssClass="btn btn-info" OnClick="btnDelete_Click" />

    <asp:Button runat="server" ID="btnReset" Text="Reset" CssClass="btn btn-danger" OnClick="btnReset_Click" />
    <hr />
    <asp:Label runat="server" ID="lblMsg"></asp:Label>
    <hr />

    <div>
        <asp:GridView ID="gvTheaterDetails" runat="server" CssClass="table table-bordered table-striped" OnSelectedIndexChanged="gvTheaterDetails_SelectedIndexChanged"></asp:GridView>
    </div>

</asp:Content>

