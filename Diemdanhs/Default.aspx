<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Tenlop" DataValueField="Malop">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:strConn %>" SelectCommand="SELECT * FROM [Lop]"></asp:SqlDataSource>
        <br />
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="MaSV" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="MaSV" HeaderText="MaSV" ReadOnly="True" SortExpression="MaSV" />
                <asp:BoundField DataField="Hoten" HeaderText="Hoten" SortExpression="Hoten" />
                <asp:TemplateField HeaderText="Anh sinh vien">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("MaSV")+".jpg" %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Diem danh">
                    <ItemTemplate>
                        <asp:RadioButton ID="R1" runat="server" Text="1 ngay" GroupName="A" Checked="true"/>
                        <asp:RadioButton ID="R2" runat="server" Text="Nua ngay" GroupName="A"/>
                        <asp:RadioButton ID="R3" runat="server" Text="Nghi" GroupName="A"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:strConn %>" SelectCommand="SELECT [MaSV], [Hoten] FROM [Sinhvien] WHERE ([Malop] = @Malop)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="Malop" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ghi vao database" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
