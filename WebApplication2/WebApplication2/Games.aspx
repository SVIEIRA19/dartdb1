<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Games.aspx.cs" Inherits="WebApplication2.Stats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 346px;
        }
        .newStyle1 {
            font-family: Calibri;
            font-size: large;
            font-weight: bold;
            font-variant: normal;
            color: #008080;
        }
        .newStyle2 {
            font-size: xx-large;
            font-family: Calibri;
            font-weight: bold;
            font-style: normal;
            font-variant: small-caps;
            color: #009933;
        }
        .newStyle3 {
            font-family: Calibri;
            font-size: x-large;
            font-weight: bold;
            font-style: oblique;
            font-variant: small-caps;
            text-transform: uppercase;
            color: #305FB6;
        }
        .newStyle4 {
            font-family: Calibri;
            font-size: large;
            font-weight: normal;
            font-variant: small-caps;
            text-transform: uppercase;
        }
        .auto-style18 {
            width: 45%;
            height: 110px;
        }
        .auto-style19 {
            height: 431px;
        }
        .auto-style20 {
            margin-left: 10px;
        }
        .auto-style32 {
            width: 107%;
        }
        .auto-style39 {
            width: 50px;
            height: 52px;
        }
        .auto-style45 {
            font-family: "Lucida Sans Typewriter";
            font-size: large;
            color: #2F5CB3;
        }
        .auto-style48 {
            padding: 1px 2px;
            border: 1px solid #008000;
            height: 86px;
            width: 446px;
            color: #C0C0C0;
        }
        .auto-style54 {
            width: 212px;
            height: 52px;
        }
        .auto-style58 {
            width: 22px;
            height: 52px;
        }
        .auto-style59 {
            height: 97px;
        }
        .auto-style62 {
            border: 1px solid #008080;
            height: 23px;
            width: 109px;
            font-family: "Lucida Sans Typewriter";
            text-transform: capitalize;
            color: #008000;
            background-color: #F0F0F0;
            text-align: center;
        }
        .auto-style65 {
            border: 1px solid #008080;
            height: 23px;
            width: 109px;
            text-align: center;
        }
        .auto-style66 {
            border: 1px solid #008080;
            height: 23px;
            width: 108px;
            font-family: "Lucida Sans Typewriter";
            text-transform: capitalize;
            color: #008000;
            background-color: #F0F0F0;
            text-align: center;
        }
        .auto-style67 {
            font-size: xx-large;
            font-family: Calibri;
            font-weight: bold;
            font-style: normal;
            font-variant: small-caps;
            color: #009933;
            margin-top: 0px;
        }
        .auto-style68 {
            height: 52px;
        }
        .auto-style71 {
            width: 180px;
            text-align: center;
        }
        .auto-style72 {
            font-family: Calibri;
            font-size: large;
            font-weight: bold;
            font-variant: normal;
            color: #008080;
            width: 10px;
        }
        .auto-style73 {
            width: 10px;
        }
        .auto-style77 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            font-family: Calibri;
            font-size: large;
            font-weight: bold;
            font-variant: normal;
            color: #008080;
            width: 90px;
            text-align: center;
        }
        .auto-style82 {
            padding: 0;
            width: 9px;
        }
        .auto-style83 {
            padding: 0;
            font-family: Calibri;
            font-size: large;
            font-weight: bold;
            font-variant: normal;
            color: #008080;
            width: 9px;
            text-align: center;
        }
        .auto-style84 {
            border-bottom-style: none;
        }
        </style>
</head>
<body style="height: 630px">
    <form id="form1" runat="server" class="auto-style19">
    <div>
        <strong class="newStyle3">&nbsp;&nbsp; DARTDB1 Web App<hr/>
        </strong>
    </div>
        <div>

                    &nbsp;&nbsp;&nbsp;

                    <img alt="" src="images/dartdb1.png" id="allplayerspic" runat="server" class="allplayerspic"/><img alt="" src="images/SergioCluster.png" id="sergiocluster" runat="server"/><img alt="" src="images/NelsonCluster.png" id="nelsoncluster" runat="server" class="nelsonpic"/></div>
        <table class="auto-style32">
            <tr>
                <td class="auto-style54">
        &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="LinqDataSource1" DataTextField="PlayerName" DataValueField="PlayerName" Height="50px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="200px" CssClass="auto-style67" TabIndex="6" AppendDataBoundItems="true">
        </asp:DropDownList>
        &nbsp;<asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="WebApplication2.DartLeagueDataContext" EntityTypeName="" GroupBy="PlayerName" Select="new (key as PlayerName, it as Players)" TableName="Players">
        </asp:LinqDataSource>
    
                </td>
                <td class="auto-style58">
                    </td>
                <td class="auto-style68">
                    <br/>
                    <div class="auto-style59">
                    <table class="auto-style48" align="left">
                        <tr>
                            <td class="auto-style62"><strong>Total Games</strong></td>
                            <td class="auto-style62"><strong>Rounds</strong></td>
                            <td class="auto-style66"><strong>Bull Rounds</strong></td>
                            <td class="auto-style62"><strong>Bull Darts</strong></td>
                            <td class="auto-style62"><strong>Zero Rounds</strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style65">
                                <asp:Label ID="gcount" runat="server" Text="gcount" CssClass="auto-style45"></asp:Label>
                            </td>
                            <td id="avgbrounds" class="auto-style65">
                                <asp:Label ID="avgrounds" runat="server" Text="avgrounds" CssClass="auto-style45"></asp:Label>
                            </td>
                            <td class="auto-style65">
                                <asp:Label ID="avgbrounds" runat="server" Text="avgbrounds" CssClass="auto-style45"></asp:Label>
                            </td>
                            <td class="auto-style65">
                                <asp:Label ID="avgbdarts" runat="server" Text="avgbdarts" CssClass="auto-style45"></asp:Label>
                            </td>
                            <td class="auto-style65">
                                <asp:Label ID="avgzrounds" runat="server" Text="avgzrounds" CssClass="auto-style45"></asp:Label>
                            </td>
                        </tr>
                        </table>
                    </div>
                </td>
                <td class="auto-style68">
                    &nbsp;</td>
                <td class="auto-style39">
                    </td>
            </tr>
            </table>
        &nbsp;
            
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <table class="auto-style18" title="TEST">
            <tr>
                <td class="auto-style72">
                    &nbsp;</td>
                <td class="auto-style77">
                    Round<span class="auto-style84">s</span></td>
                <td class="auto-style83">
                    &nbsp;</td>
                <td class="auto-style77">
                    Bulls Rounds</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style77">Bull Darts</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style77">Zero Rounds</td>
                <td class="auto-style71" rowspan="2">
                    <strong>
        <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Record New Game" TabIndex="5" Font-Bold="True" Height="50px" Width="149px" Font-Names="Calibri" Font-Size="Medium" ForeColor="#0C2D3D"/>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style73">
                    &nbsp;</td>
                <td class="auto-style77">
                    <asp:TextBox ID="Rounds" runat="server" Height="40px" style="font-size: larger" TextMode="Number" TabIndex="1" Width="75px" BorderColor="White" BorderStyle="None"></asp:TextBox>
                </td>
                <td class="auto-style82">
                    &nbsp;</td>
                <td class="auto-style77">
                    <asp:TextBox ID="BRounds" runat="server" Height="40px" style="font-size: larger" TextMode="Number" TabIndex="2" Width="75px" BorderStyle="None"></asp:TextBox>
                </td>
                <td class="auto-style82">
                    &nbsp;</td>
                <td class="auto-style77">
                    <asp:TextBox ID="Bdarts" runat="server" Height="40px" style="font-size: larger" TextMode="Number" TabIndex="3" Width="75px" BorderStyle="None"></asp:TextBox>
                </td>
                <td class="auto-style82">
                    &nbsp;</td>
                <td class="auto-style77">
                    <asp:TextBox ID="Zero" runat="server" Height="40px" style="font-size: larger" TextMode="Number" TabIndex="4" Width="75px" BorderStyle="None"></asp:TextBox>
                </td>
            </tr>
            </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateDeleteButton="False" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateEditButton="False" DataKeyNames="gameID" AutoGenerateColumns="False" CssClass="auto-style20">
        <Columns>                       
         <asp:TemplateField HeaderText="#" HeaderStyle-VerticalAlign="Top">   
            <ItemTemplate>
                     <%# Container.DataItemIndex + 1 %>   
             </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="rounds" HeaderText="Rounds" HeaderStyle-Wrap="True" HeaderStyle-Width="50" HeaderStyle-VerticalAlign="Top" ItemStyle-HorizontalAlign="Center" NullDisplayText=" "/>
            <asp:BoundField DataField="bullsrounds" HeaderText="Bull Rounds" HeaderStyle-Wrap="True" HeaderStyle-Width="50" ItemStyle-HorizontalAlign="Center" NullDisplayText=" "/>
            <asp:BoundField DataField="bulldarts" HeaderText="Bull Darts" HeaderStyle-Wrap="True" HeaderStyle-Width="50" ItemStyle-HorizontalAlign="Center" NullDisplayText=" "/>
            <asp:BoundField DataField="zerorounds" HeaderText="Zero Rounds" HeaderStyle-Wrap="True" HeaderStyle-Width="50" ItemStyle-HorizontalAlign="Center" NullDisplayText=" "/>
            <asp:BoundField DataField="gameID" HeaderText="Game ID" HeaderStyle-Width="50" ItemStyle-HorizontalAlign="Center"/>
            <asp:BoundField DataField="playerID" HeaderText="Player ID" HeaderStyle-Width="50" ItemStyle-HorizontalAlign="Center"/>
            <asp:CommandField ButtonType="Image" CancelImageUrl="~/Images/cancel.png" EditImageUrl="~/Images/edit.png" ShowEditButton="True" UpdateImageUrl="~/Images/edit.png" />
            <asp:CommandField ButtonType="Image" DeleteImageUrl="~/Images/Delete.png" ShowDeleteButton="True" />
            </Columns>
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#99CCFF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    
        <p>
        <asp:Button ID="DelButton" runat="server" OnClick="DelButton_Click" Text="Delete Game" Visible="False" />
        </p>
    </form>
</body>
</html>
