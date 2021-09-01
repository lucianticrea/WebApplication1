<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QuestionView.aspx.cs" Inherits="PersonalityTest.Web.QuestionView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>At work, is it you who gets noticed first or perhaps the other people around you? Do you feel compelled to take centre-stage or are you more comfortable back-stage? If it’s the former, then you are eager for contact — warm and happy human relations. If it’s the latter, then solitude suits and stimulates you more and hell is often other people…
    </h3>
    <asp:Label ID="lblHeaderTitle" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="lblQuestion" runat="server" Text="" Font-Size="Larger" Font-Bold="True" Font-Italic="True" />

    <asp:RadioButtonList ID="rblQuestions" runat="server" OnSelectedIndexChanged="rblQuestions_SelectedIndexChanged" ></asp:RadioButtonList>

    <asp:Button ID="btnPrevious" runat="server" Text="Previous" Visible="false" OnClick="btnPrevious_Click" />
    <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" />
    <asp:Button ID="btnFinish" runat="server" Text="Finish" Visible="false" OnClick="btnFinish_Click"  />
</asp:Content>
