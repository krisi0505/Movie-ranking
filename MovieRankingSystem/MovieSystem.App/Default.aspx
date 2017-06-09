<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MovieSystem.App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Movies</h1>
    </div>

    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:GridView runat="server" ID="moviesGrid"
                ItemType="MovieSystem.App.Models.Movie" DataKeyNames="Id"
                SelectMethod="moviesGrid_GetData"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:DynamicField DataField="Title" />
                    <asp:DynamicField DataField="Director" />
                    <asp:DynamicField DataField="Description" />
                    <asp:DynamicField DataField="Rank"/>
                </Columns>
            </asp:GridView>

        </div>
    </section>

</asp:Content>
