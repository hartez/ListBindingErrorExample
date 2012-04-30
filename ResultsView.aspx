<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultsView.aspx.cs" Inherits="ListBindingErrorExample.ResultsView" %>
<%@ Import Namespace="FubuMVC.WebForms" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
		<h1>Results</h1>    
		<p>Songs: <%=Model.SongCount %></p>
		
		<p>Album Title: <%=Model.Album.Title %></p>
		
		<ul>
		<%=this.PartialForEach(m => m.Album.Songs) %>
		</ul>
    </div>
</body>
</html>
