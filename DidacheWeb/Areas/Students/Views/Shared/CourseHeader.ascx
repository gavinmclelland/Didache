﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%
	Course course = Courses.GetCourseBySlug(ViewContext.RouteData.Values["slug"].ToString());
 %>

<div id="course-header">
	<h2><%: course.CourseCode %><%: course.Section%> - <%: course.Name%></h2>
	<h3><%: course.Session.Name%> <%: course.Campus.Name%></h3>
	<p><%: course.Description%></p>
</div>