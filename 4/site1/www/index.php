<?php
	mysql_connect('localhost', 'root', '');
	mysql_select_db('test1');

	$result = mysql_query("SELECT * FROM rates WHERE name='USD'");
	$row = mysql_fetch_assoc($result);

	$rate = $row['value'];

	$curs_evro = 40;

	if(isset($_POST['bucks']))
		$bucks = $_POST['bucks'];
	else
		$bucks = 0;

	
?>


<!DOCTYPE html>
<html>
	<head>
		<title>My site</title>
		<meta charset="cp1251"/>
	</head>
	<body>
		<form method="post">
			<input type="text" name="bucks" value="<?php echo $bucks;?>" size="5"/> $
			<input type="submit" value="="/> <?php echo $rate * $bucks;?> MD.
			
		</form>
	</body>
</html>