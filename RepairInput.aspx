<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="RepairInput.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 150px;


        }
    </style>



</head>



<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="整改单编号"></asp:Label>
        <asp:TextBox ID="Text_RepairNum" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="主题"></asp:Label>
        <asp:TextBox ID="Text_Subject" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="发起人"></asp:Label>
        <asp:TextBox ID="Text_UserName" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="发起单位"></asp:Label>
        <asp:TextBox ID="Text_Sponsored_unit" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="Label5" runat="server" Text="产品系列"></asp:Label>
        <asp:TextBox ID="Text_Product_line" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="原因分类"></asp:Label>
        <asp:ListBox ID="ListBox_Cause_classification" runat="server" Height="22px" Width="113px">
            <asp:ListItem>设计</asp:ListItem>
            <asp:ListItem>外协</asp:ListItem>
            <asp:ListItem>工艺</asp:ListItem>
            <asp:ListItem>设备</asp:ListItem>
            <asp:ListItem>制造</asp:ListItem>
            <asp:ListItem>检测</asp:ListItem>
        </asp:ListBox>
        <asp:Label ID="Label7" runat="server" Text="发起时间"></asp:Label>
        <asp:TextBox ID="Text_Starting_time" runat="server"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="生产班组"></asp:Label>
        <asp:TextBox ID="TextBox_Production_team" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="问题点区域"></asp:Label>
        <asp:TextBox ID="Text_Problem_area" runat="server"></asp:TextBox>
        <asp:Label ID="Label10" runat="server" Text="项目来源"></asp:Label>
        <asp:TextBox ID="Text_Project_source" runat="server"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" Text="产品型号"></asp:Label>
        <asp:TextBox ID="Text_Product_model" runat="server"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" Text="附件"></asp:Label>
        <asp:TextBox ID="Text_Enclosure" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label13" runat="server" Text="问题描述"></asp:Label>
        <asp:TextBox ID="Text_Problem_description" runat="server"></asp:TextBox>
        <asp:Label ID="Label14" runat="server" Text="整改要求及目标"></asp:Label>
        <asp:TextBox ID="Text_Rectification_requirements_and_obje" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label15" runat="server" Text="主导单位"></asp:Label>
        <asp:TextBox ID="Text_Dominant_unit_1" runat="server"></asp:TextBox>
        <asp:Label ID="Label16" runat="server" Text="主导人"></asp:Label>
        <asp:TextBox ID="Text_Leader_1" runat="server"></asp:TextBox>
        <asp:Label ID="Label17" runat="server" Text="截止时间"></asp:Label>
        <asp:TextBox ID="Text_Expiration_date_1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label18" runat="server" Text="整改目标及要求"></asp:Label>
        <asp:TextBox ID="TextBox17" runat="server" Height="20px" Width="80px"></asp:TextBox>
        <br />
        <div style="text-align:center; margin:20px 0px 50px 50px;">
        <asp:Button ID="Button1" runat="server" Text="提交"   style="text-align:right" OnClick="Button1_Click" />
            </div>

    </form>
</body>
</html>
