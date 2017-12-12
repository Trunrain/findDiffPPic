<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="out.aspx.cs" Inherits="diffWebApp._out" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>result</title>
    <link rel="stylesheet" href="css/style1.css">
</head>
<body>
    <form id="form1" runat="server">

    	<div class="container_12">
					<div class="grid_6">
						<div class="p1_box left cl1">
                            <asp:Image ID="Image3" runat="server" />
						</div>
						<div class="p1_box left cl3 pos1">
                            <asp:Image ID="Image1" runat="server" ImageUrl="/out/out1.bmp"/>
						</div>
					</div>
					<div class="grid_6">
						<div class="p1_box right cl1">
                            <asp:Image ID="Image4" runat="server" />
						</div>
						<div class="p1_box right cl3">
							<asp:Image ID="Image2" runat="server" ImageUrl="/out/out2.bmp"/>
						</div>
					</div>
				</div>
			</div>	
		</div>
    </form>
    
</body>
</html>
