<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeView.aspx.cs" Inherits="ListBindingErrorExample.HomeView" %>
<%@ Import Namespace="FubuMVC.Core.UI" %>
<%@ Import Namespace="ListBindingErrorExample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
		<h1>Home</h1>    
		<%=this.FormFor<AlbumModel>() %>
		
			<%=this.LabelFor<AlbumModel>(m => m.Title) %>
			<%=this.InputFor<AlbumModel>(m => m.Title) %>
			
			<label>Song 1</label>
			<input type="text" name="Songs[0]Title"/>
			
			<label>Song 2</label>
			<input type="text" name="Songs[1]Title"/>
			
			<label>Song 3</label>
			<input type="text" name="Songs[2]Title"/>
			
			<input type="submit" value="submit"/>

		<%=this.EndForm() %>
    </div>
</body>
</html>
