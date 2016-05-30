<?php
	if($_GET['key'] != "qwerty")
	{
		header('location: login.php');
		exit();
	}

	if(!empty($_POST))
	{
		mysql_connect('localhost', 'root', '');
		mysql_select_db('test1');

		$new_rate = $_POST['rate'];
		mysql_query("UPDATE rates SET value='$new_rate' WHERE name='USD'");
	}
?>


<!DOCTYPE html>
<html>
	<head>
		<title>My site</title>
	</head>
	<body>
			Change dollar rate:
		<form method="post">
			<input type="text" name="rate" /><br/>
			<input type="submit" value="Save" />
		</form>
	</body>
</html>