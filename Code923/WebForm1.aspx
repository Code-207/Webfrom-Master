<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Code923.WebForm1" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>        
14

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater runat="server" ID="repuserlist">
                <ItemTemplate>
                    <p>id:'<%# Eval("Users_Account") %>'</p>
                    <p>id:'<%# Eval("Users_Password") %>'</p>
                    <p>id:'<%# Eval("Users_NickName") %>'</p>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <%--<webdiyer:AspNetPager ID="AspNetPager1" CssClass="pages" CurrentPageButtonClass="cpb"
                              CustomInfoTextAlign="Left" HorizontalAlign="Right" PageIndexBoxType="TextBox"
                              ShowCustomInfoSection="Left" ShowMoreButtons="False" ShowNavigationToolTip="True"
                              ShowPageIndexBox="Always"
                              runat="server" AlwaysShow="Teorue" PageSize="8" ShowInputBox="Always"
                              LayoutType="Table" OnPageChanging="AspNetPager1_PageChanging"
                              FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"
                              PagingButtonSpacing="2px"></webdiyer:AspNetPager>--%>
        <form>

        </form>

    </form>
</body>
</html>
