<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Delete participant</title>



</head>
<body>

    <a href=".">Back to index</a>   

    <?php
    //including connection variables - remember to update these if you are using XAMPP    
    include 'dbconnect.php';

            try {
                $conn = new PDO("mysql:host=$servername;port=$port;dbname=$database", $username, $password); //building a new connection object
                // set the PDO error mode to exception
                $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

                $conn = new PDO("mysql:host=$servername;port=$port;dbname=$database", $username, $password); //building a new connection object
                // set the PDO error mode to exception
                $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);



                // prepare statement
                $result = $conn->prepare("DELETE FROM participant WHERE id = ?");

                // bind values
                $result -> bindValue(1, $_GET['id']);

                // execute statement
                $result -> execute();

                echo "You have deleted participant #" . $_GET['id'];


                }
            catch(PDOException $e)
                {
                echo $e->getMessage(); //If we are not successful we will see an error
                }


        
        ?>


</body>
</html>