<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MovieSystem.App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <asp:LoginView runat="server" ViewStateMode="Disabled">
        <AnonymousTemplate>
            <section>
                <div style="margin:5px;">
                    <asp:ValidationSummary ShowModelStateErrors="true" runat="server" CssClass="alert alert-danger" />
                    <asp:GridView runat="server" ID="moviesGrid" CssClass="table table-striped" GridLines="Horizontal"
                        ItemType="MovieSystem.App.Models.Movie" DataKeyNames="Id"
                        AllowSorting="true" AllowPaging="true" PageSize="8" PagerStyle-CssClass="page-link"
                        SelectMethod="moviesGrid_GetData"
                        AutoGenerateColumns="false">
                        <Columns>
                            <asp:DynamicField DataField="Title" />
                            <asp:DynamicField DataField="Director" />
                            <asp:DynamicField DataField="Description"/>
                        </Columns>
                    </asp:GridView>
                </div>
            </section>
        </AnonymousTemplate>
        <LoggedInTemplate>
            <section>
                <div style="margin: 5px;">
                    <asp:HyperLink NavigateUrl="~/AddMovie" Text="Add New Movie" CssClass="btn btn-success btn-lg btn-block" runat="server" />
                </div>
                <div>
                    <asp:ValidationSummary ShowModelStateErrors="true" runat="server" CssClass="alert alert-danger" />
                    <asp:GridView runat="server" ID="moviesGrid" CssClass="table table-striped" GridLines="Horizontal"
                        ItemType="MovieSystem.App.Models.Movie" DataKeyNames="Id"
                        AllowSorting="true" AllowPaging="true" PageSize="8" 
                        SelectMethod="moviesGrid_GetData"
                        UpdateMethod="moviesGrid_UpdateItem"
                        DeleteMethod="moviesGrid_DeleteItem"
                        AutoGenerateColumns="false">
                        <Columns>
                            <asp:DynamicField DataField="Title" />
                            <asp:DynamicField DataField="Director" />
                            <asp:DynamicField DataField="Description" ItemStyle-Wrap="true" />

                            <asp:CommandField ShowEditButton="true">
                                <ControlStyle CssClass="btn btn-info" />
                            </asp:CommandField>
                            <asp:CommandField ShowDeleteButton="true" ShowCancelButton="true">
                                <ControlStyle CssClass="btn btn-danger" />
                            </asp:CommandField>
                        </Columns>
                    </asp:GridView>
                </div>
            </section>
        </LoggedInTemplate>
    </asp:LoginView>


  
</asp:Content>
