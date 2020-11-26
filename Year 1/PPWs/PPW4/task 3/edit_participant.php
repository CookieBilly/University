<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Update participants score</title>
</head>
<body>
<a href=".">Back to index</a>
    <?php
        
        //including connection variables - remember to update these if you are using XAMPP    
        include 'dbconnect.php';

        try {
            if($_SERVER['REQUEST_METHOD'] == 'POST') //has the user submitted the form and edited the order
            {
                //TODO - UPDATE section
                
                $conn = new PDO("mysql:host=$servername;port=$port;dbname=$database", $username, $password); //building a new connection object
                // set the PDO error mode to exception
                $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

                $result = $conn->prepare("UPDATE participant SET distance = ?, power_output = ? WHERE id = ?;");

                $result -> bindValue(1, $_POST['distance']);
                $result -> bindValue(2, $_POST['power_output']);
                $result -> bindValue(3, $_POST['id']);

                $result -> execute();

                echo "Updated participant #" . $_POST['id'] . " succesfully!";

            }
            else{
                //TODO - SELECT section

                $conn = new PDO("mysql:host=$servername;port=$port;dbname=$database", $username, $password); //building a new connection object
                // set the PDO error mode to exception
                $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);


                // prepare statement
                $result = $conn->prepare("SELECT * FROM participant WHERE id=?");

                // bind values
                $result -> bindValue(1, $_GET['id']);

                // execute statement
                $result -> execute();

                // fetch result and store in "row"
                $row = $result->fetch();
                include "edit_participant_form.php";

            }
        }
        catch(PDOException $e)
            {
            echo $e->getMessage(); //If we are not successful in connecting or running the query we will see an error
            }
        ?>


</body>
</html>