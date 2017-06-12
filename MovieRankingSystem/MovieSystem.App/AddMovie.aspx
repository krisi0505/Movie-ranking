<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddMovie.aspx.cs" Inherits="MovieSystem.App.AddMovie" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:FormView runat="server" ID="addMovieForm"
        ItemType="MovieSystem.App.Models.Movie"
        InsertMethod="addMovieForm_InsertItem" DefaultMode="Insert"
        RenderOuterTable="false" OnItemInserted="addMovieForm_ItemInserted">
        <InsertItemTemplate>
            <fieldset>
                <ol>
                    <asp:DynamicEntity runat="server" Mode="Insert" />
                </ol>
                <asp:Button runat="server" Text="Insert" CommandName="Insert" />
                <asp:Button runat="server" Text="Cancel" CausesValidation="false" OnClick="cancelButton_Click" />
            </fieldset>
        </InsertItemTemplate>
    </asp:FormView>

</asp:Content>
