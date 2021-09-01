<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalityTest.aspx.cs" Inherits="PersonalityTest.Web.PersonalityTest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            <h2>Test: Are you an introvert or an extrovert?</h2>
            <asp:Button ID="btnStart" runat="server" Text="Start" PostBackUrl="~/QuestionView.aspx" />
        </div>
</asp:Content>
