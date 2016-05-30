<?php
	if(!empty($_POST))
	{
		header('location: secret.php?key=' . $_POST['login']);
		exit();
	}
?>



<!DOCTYPE html>
<html>
	<head>
		<title>My site</title>
	</head>
	<body>
		<form method="post">
			Login:<br/>
			<input type="text" name="login" /><br/>
			<input type="submit" value="Access" />
		</form>
	</body>
</html>