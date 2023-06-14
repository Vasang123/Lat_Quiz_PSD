<asp:GridView runat="server"></asp:GridView>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Lat_Quiz.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="Create.aspx">Create</a>
           
            <asp:Label ID="test" runat="server" Text="Label"></asp:Label>
            <table border="1">
                <thead>
                    <th>Song Name</th>
                    <th>Artist Name</th>
                    <th>Release Date</th>
                    <th>Description</th>
                    <th>Option</th>
                </thead>
                <tbody>
                    <% foreach (var song in songs) {%>
                         <tr>
                            <td>
                                <%= song.SongName %>
                            </td>
                            <td>
                                <%= song.ArtistName %>
                            </td>
                            <td>
                                <%= song.ReleaseDate %>
                            </td>
                            <td>
                                <%= song.SongDescription %>
                            </td>
                            <td>
                                <a href="Update.aspx?id=<%= song.ID %>">Update</a>
                                <a href="Delete.aspx?id=<%= song.ID %>">Delete</a>
                            </td>
                        </tr>
                    <%} %>
                   
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
