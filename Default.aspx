		<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

	<!DOCTYPE html>

	<style>
		.grad1 {
			background: blue; /* For browsers that do not support gradients */
			background: -webkit-linear-gradient(darkblue, lightblue); /* For Safari 5.1 to 6.0 */
			background: -o-linear-gradient(darkblue, lightblue); /* For Opera 11.1 to 12.0 */
			background: -moz-linear-gradient(darkblue, lightblue); /* For Firefox 3.6 to 15 */
			background: linear-gradient(darkblue, lightblue); /* Standard syntax (must be last) */
		}

		.theTitle2 {
			color: black;
			background: red; /* For browsers that do not support gradients */
			background: -webkit-linear-gradient(red, lightblue); /* For Safari 5.1 to 6.0 */
			background: -o-linear-gradient(red, lightblue); /*For Opera 11.1 to 12.0 */
			background: -moz-linear-gradient(red, lightblue); /* For Firefox 3.6 to 15 */
			background: linear-gradient(red, lightblue); /* Standard syntax (must be last) */
			background-color: lightblue;
		}
		/*body {
			font-family: "Lato", sans-serif;
			background-color: lightblue;
		}*/

		/* Style the tab */
		div.tab {
			overflow: auto;
			border: 1px solid #ccc;
			background-color: #f1f1f1;
		}

			/* Style the links inside the tab */
			div.tab a {
				float: left;
				display: block;
				color: black;
				text-align: center;
				padding: 14px 16px;
				text-decoration: none;
				transition: 0.3s;
				font-size: 17px;
			}

				/* Change background color of links on hover */
				div.tab a:hover {
					background-color: #ddd;
				}

				/* Create an active/current tablink class */
				div.tab a:focus, .active {
					background-color: #ccc;
				}


		/* Style the tab content */
		.tabcontent {
			display: none;
			padding: 6px 12px;
			border: 1px solid #ccc;
			border-top: none;
		}

		h3 {
			font-size: 4.0vh;
			text-align: center;
		}
	</style>
  
	<html xmlns="http://www.w3.org/1999/xhtml" lang="en-ca">
	<script src="Scripts/jquery-3.1.1.js"></script>
	<script src="Scripts/jquery-3.1.1.min.js"></script>

	<script src="Scripts/bootstrap.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>

	<script>     
	
		$(document).ready(function() {
			initMap();
		});
		function initMap() { 

			var lblnm =  '<%=lblnm %>';
			var longitude =  '<%=FromServerlongitude %>';
			var latitude = '<%=FromServerlatitude %>'; 
			var comment = '<%=FromServercomment %>';
			var info = '<%=FromServerwiki %>';
			
			var startpoint = { lat:<%=FromServerlatitude %>, lng:<%=FromServerlongitude %>   };  
		   
			document.getElementById('infoLabel').style.display = 'block'; 
			var map = new google.maps.Map(document.getElementById('map'), {
				zoom: 14,
				center:  startpoint, 
				mapTypeId: 'satellite',
				fullscreenControl: true
			});  

			var marker = new google.maps.Marker({
				label: {
					color: 'white',
					fontWeight: 'bold',
					text: lblnm ,				
				},
				position:  startpoint,          
				map: map,
				
			}); 	         
	 
			var input = document.getElementById('pac-input');
			//var searchBox = new google.maps.places.SearchBox(input);
			map.controls[google.maps.ControlPosition.TOP_LEFT].push(input); 
			
			//map.addListener('bounds_changed', function () {
			//	searchBox.setBounds(map.getBounds());			   
			//}); 
			
			var markers = [];
			//searchBox.addListener('places_changed', function () {
			//	var places = searchBox.getPlaces();

			//	if (places.length == 0) {
				 
			//		return;
			//	}
			//	markers.forEach(function (marker) {
			//		marker.setMap(null);
			//	});
			//	markers = [];
				
			//	var bounds = new google.maps.LatLngBounds();
			//	places.forEach(function (place) {
			//		if (!place.geometry) {
			//			console.log("Returned place contains no geometry");
			//			return;
			//		}
			//		var icon = {
			//			url: place.icon,
			//			size: new google.maps.Size(71, 71),
			//			origin: new google.maps.Point(0, 0),
			//			anchor: new google.maps.Point(17, 34),
			//			scaledSize: new google.maps.Size(25, 25),                   
			//		};
				   
			//		markers.push(new google.maps.Marker({
			//			map: map,
			//			icon: icon,
			//			title: place.name,						
			//			position: place.geometry.location,
			//			label: {
			//				color: 'white',
			//				fontWeight: 'bold',
			//				text: place.name ,  				
			//			},
			//		}));  
			//		ClearAllControls();
			//		var location = place.geometry.location;
				
			//		var lat = location.lat();
			//		var lng = location.lng();

			//		var lati =  document.getElementById("TextBox2");  
			//		var long =  document.getElementById("TextBox1"); 

			//		lati.value = lat;
			//		long.value = lng; 
					
			//		if (place.geometry.viewport) {                   
			//			bounds.union(place.geometry.viewport);
			//			document.getElementById('infoLabel').style.display = 'none'; 	
			//			//document.getElementById('pac-input').style.display = 'block'; 
					 
			//		} 				 
			//	});				
			//	map.fitBounds(bounds)
			//}); 
	   
			$(function(){
				$('.test').tooltip({
					href: '.test'
				});
			});

			function ClearAllControls() 
			{		 
				for (i=0; i<document.forms[0].length; i++)
				{
					doc = document.forms[0].elements[i];					       
					switch (doc.type) 
					{					                             
						case "select-one" :
							doc.selectedIndex = -1;
							break;								
						default :
							break;
					}
				}
			} 
		}
	</script>

	 <script type="text/javascript"
		src="https://maps.googleapis.com/maps/api/js?key=AIzaSyC3hPcF2p9InbZv2GXLy9bAMlfiNvD8nyI&callback=initMap" async defer>
	</script>

	<head>
	
		<title></title>

		<style>
			#map {
				width: 99%;
				height: 400px;
				background-color: white;
			}

			p {
				font-size: 2px;
				font-size: 2.5vw;
			}
		</style>

		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
		<meta name="description" content="The description of my page" />
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

	</head>

	<body class="grad1">
		<form runat="server">
			<%--BCATP--%>
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BCATPConnectionString %>"
				SelectCommand="SELECT [name], [longitude], [latitude], [comment], [wiki] FROM [BCATP] union select null,null,null,null,null order by name"></asp:SqlDataSource>
			<%--DewLineData--%>
			<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BCATPConnectionString %>"
				SelectCommand="SELECT [name], [longitude], [latitude], [comment], [wiki] FROM [DewLine] union select null,null,null,null,null order by name"></asp:SqlDataSource>
			<%--PinetreeData--%>
			<asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BCATPConnectionString %>"
				SelectCommand="SELECT [name], [longitude], [latitude], [comment], [wiki] FROM [Pinetree] union select null,null,null,null,null order by name"></asp:SqlDataSource>
			<%--AirForce--%>
			<asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:BCATPConnectionString %>"
				SelectCommand="SELECT [name], [longitude], [latitude], [comment], [wiki] FROM [AirForce] union select null,null,null,null,null order by name"></asp:SqlDataSource>
			<%--Army--%>
			<asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:BCATPConnectionString %>"
				SelectCommand="SELECT [name], [longitude], [latitude], [comment], [wiki] FROM [Army] union select null,null,null,null,null order by name"></asp:SqlDataSource>
			<%--Navy--%>
			<asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:BCATPConnectionString %>"
				SelectCommand="SELECT [name], [longitude], [latitude], [comment], [wiki] FROM [Navy] union select null,null,null,null,null order by name"></asp:SqlDataSource>
			<%--Mid Canada--%>
			<asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:BCATPConnectionString %>"
				SelectCommand="SELECT [name], [longitude], [latitude], [comment], [wiki] FROM [MidCanada] union select null,null,null,null,null order by name"></asp:SqlDataSource>
			<%--DefunctBases--%>
			<asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:BCATPConnectionString %>"
				SelectCommand="SELECT [name], [longitude], [latitude], [comment], [wiki] FROM [Defunct] union select null,null,null,null,null order by name"></asp:SqlDataSource>
		
			<div class="row">
				<div class="col-xs-2 col-sm-2 col-md-2 col-lg-2">
					<img src="/Image/CanadianFlag.png" class="img-responsive" style="padding-top: 5px; float: right;" />
				</div>
				<div class="col-xs-8 col-sm-8 col-md-8  col-lg-8  ">
					<div id="theTitle" style="display: flex; align-items: center; justify-content: center; padding-top: 0px; font-weight: bold; color: white; padding-bottom: 0px; margin-top: 5px;" class="theTitle2   ">
						<p align="center">
							Canadian Military Installations
							<br />
							Past and Present
						</p>
					</div>
				</div>
				<div class="col-xs-2 col-sm-2 col-md-2  col-lg-2 ">
					<img src="/Image/Canadian Forces Ensign.png" class="img-responsive" style="padding-top: 5px; float: left;" />
				</div>
			</div>
			<br />
			<div class="container">

				<div class=" col-xs-4 col-sm-4 col-md-4 col-lg-4">
					<div class="panel-group">
						<div class="panel panel-default grad1">
							<div class="panel-body" style="text-align: right; border-color: blue; border-style: solid;">
								<asp:Button ID="BtnPrevious3" runat="server" Style="font-weight: bold; width: 80px;" Text="Previous" OnClick="BtnPrevious_Click" />
								<asp:Button ID="BtnNext3" runat="server" Style="font-weight: bold; width: 80px;" Text="Next" OnClick="BtnNext_Click" />
								<%--  <hr />--%>
								<br />
								<br />
								<div style="margin: 0 auto; text-align: right;">
									<a href="https://en.wikipedia.org/wiki/British_Commonwealth_Air_Training_Plan" target="_blank" style="font-weight: bold; color: white" class="test" title="Click here for more info">BCATP</a>

									<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" Width="45%"
										DataTextField="name" DataValueField="name"
										OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
										AutoPostBack="True"> 
									</asp:DropDownList>
									<br />
									<br />
									<a href="https://en.wikipedia.org/wiki/Distant_Early_Warning_Line" target="_blank" style="font-weight: bold; color: white" class="test" title="Click here for more info">Dew Line</a>

									<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" Width="45%"
										DataTextField="name" DataValueField="name"
										OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"
										AutoPostBack="True"> 
									</asp:DropDownList>
									<br />
									<br />
									<a href="https://en.wikipedia.org/wiki/Pinetree_Line" target="_blank" style="font-weight: bold; color: white" class="test" title="Click here for more info">Pinetree Line</a>

									<asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" Width="45%"
										DataTextField="name" DataValueField="name"
										OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"
										AutoPostBack="True"> 
									</asp:DropDownList>
									<br />
									<br />
									<a href="https://en.wikipedia.org/wiki/List_of_Royal_Canadian_Air_Force_stations" target="_blank" style="margin: 0 auto; text-align: center; font-weight: bold; color: white" class="test" title="Click here for more info">Air Force Bases</a>

									<asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource4" Width="45%"
										DataTextField="name" DataValueField="name"
										OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"
										AutoPostBack="True"> 
									</asp:DropDownList>
									<br />
									<br />
									<a href="https://en.wikipedia.org/wiki/Canadian_Forces_base" target="_blank" style="font-weight: bold; color: white" class="test" title="Click here for more info">Army Bases</a>

									<asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource5" Width="45%"
										DataTextField="name" DataValueField="name"
										OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged"
										AutoPostBack="True"> 
									</asp:DropDownList>

									<br />
									<br />
									<a href="https://en.wikipedia.org/wiki/List_of_Royal_Canadian_Navy_bases_(1911%E2%80%9368)" target="_blank" style="font-weight: bold; color: white" class="test" title="Click here for more info">Navy Bases</a>

									<asp:DropDownList ID="DropDownList6" runat="server" DataSourceID="SqlDataSource6" Width="45%"
										DataTextField="name" DataValueField="name"
										OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged"
										AutoPostBack="True"> 
									</asp:DropDownList>
									<br />
									<br />
									<a href="https://en.wikipedia.org/wiki/Mid-Canada_Line" target="_blank" style="font-weight: bold; color: white" class="test" title="Click here for more info">Mid Canada Line</a>

									<asp:DropDownList ID="DropDownList7" runat="server" DataSourceID="SqlDataSource7" Width="45%"
										DataTextField="name" DataValueField="name"
										OnSelectedIndexChanged="DropDownList7_SelectedIndexChanged"
										AutoPostBack="True"> 
									</asp:DropDownList>

									<br />
									<br />
									<a href="https://en.wikipedia.org/wiki/Canadian_Forces_base" target="_blank" style="font-weight: bold; color: white" class="test" title="Click here for more info">Defunct Bases/Stations</a>

									<asp:DropDownList ID="DropDownList8" runat="server" DataSourceID="SqlDataSource8" Width="45%"
										DataTextField="name" DataValueField="name"
										OnSelectedIndexChanged="DropDownList8_SelectedIndexChanged"
										AutoPostBack="True"> 
									</asp:DropDownList><br />
									<hr />
									<div style="margin: 0 auto; text-align: center;">
										<asp:Label runat="server" Style="font-size: small">Please report any discrepency to: </asp:Label>
										<a href="mailto:JRD.Consulting@hotmail.com" style="font-size: small; font-weight: bold;">
											<br />
											JRD.Consulting@hotmail.com</a>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class=" col-xs-8 col-sm-8 col-md-8 col-lg-8">
					<div class="panel-group">
						<div class="panel panel-default grad1">
							<div class="panel-body" style="border-style: solid; border-color: blue;">
								<div id="infoLabel" style="margin: 0 auto; display: inline-block;">
									<asp:HyperLink ID="linkInfo" runat="server" Style="color: white" Text=" " Target="_blank" Font-Bold="true"></asp:HyperLink>&nbsp&nbsp
									<asp:Label ID="lblName" runat="server" Style="color: red" ReadOnly="true" Font-Bold="true"></asp:Label>&nbsp&nbsp
									<asp:Label ID="TextBox3" runat="server" float="left" Style="color: white;" Font-Bold="true"></asp:Label>
							</div>
								<%--<input id="pac-input" class="controls" type="text" placeholder="Search Box" style="width: 150px; float: right">--%>
								


								<%-- <input id="pac-input" class="controls" type="text" placeholder="Search Box" style="width: 150px;"> --%>
								<div id="map" style="border-color: Black; border-style: Double"></div>
								Latitude:&nbsp<asp:TextBox ID="TextBox2" runat="server" ReadOnly="true" Style="font-weight: bold;" BackColor="transparent"></asp:TextBox>
								Longitude:&nbsp<asp:TextBox ID="TextBox1" runat="server" ReadOnly="true" Style="font-weight: bold;" BackColor="transparent"></asp:TextBox>
							</div>
						</div>
					</div>
				</div>
			</div>
			<%--</div>--%>
		</form>
	</body>
	</html>
