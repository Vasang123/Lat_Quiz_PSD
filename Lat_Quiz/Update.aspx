<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Lat_Quiz.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Update Form
             <br/>
            <asp:Label ID="songNameLabel" runat="server" Text="Song Name"></asp:Label>
            <br />
            <asp:TextBox ID="songName" runat="server" ></asp:TextBox>
             <br/>
            <asp:Label ID="artistNameLabel" runat="server" Text="Artist Name"></asp:Label>
            <br />
            <asp:TextBox ID="artistName" runat="server" ></asp:TextBox>
            <br/>
            <asp:Label ID="dateLabel" runat="server" Text="Release Date"></asp:Label>
            <br />
            <asp:TextBox ID="date" runat="server" TextMode="Date" ></asp:TextBox>
            <br/>
            <asp:Label ID="descriptionLabel" runat="server" Text="Song Description"></asp:Label>
            <br />
            <asp:TextBox ID="description" runat="server" TextMode="MultiLine" ></asp:TextBox>
            <br/>
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
            <br/>
           <asp:Button ID="updateSong" runat="server" Text="Update" OnClick="updateSong_Click"/>
        </div>
    </form>
</body>
</html>
