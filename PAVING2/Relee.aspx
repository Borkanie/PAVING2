<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Relee.aspx.cs" Inherits="PAVING2.ReleeView" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                          <asp:Button runat="server" OnClick="btn1_Click"  Id="btn1" Text="Releu1"/>
                          <asp:CheckBox runat="server" ID="CHeckBox1" />
                    </td>
                  </tr>
                  <tr>
                     <td>
                          <asp:Button runat="server" OnClick="btn2_Click"  Id="btn2" Text="Releu2"/>
                         <asp:CheckBox runat="server" ID="CHeckBox2" />
                    </td>
                  </tr>
                  <tr>
                     <td>
                          <asp:Button runat="server" OnClick="btn3_Click"  Id="btn3" Text="Releu3"/>
                         <asp:CheckBox runat="server" ID="CHeckBox3" />
                    </td>
                  </tr>
                  <tr>
                     <td>
                          <asp:Button runat="server" OnClick="btn4_Click"  Id="btn4" Text="Releu4"/>
                         <asp:CheckBox runat="server" ID="CHeckBox4" />
                    </td>
                  </tr>
                  <tr>
                     <td>
                          <asp:Button runat="server" OnClick="btn5_Click"  Id="btn5" Text="Releu5"/>
                         <asp:CheckBox runat="server" ID="CHeckBox5" />
                    </td>
                </tr>
            </table>
        </div>
    </form>    
</body>

</html>
