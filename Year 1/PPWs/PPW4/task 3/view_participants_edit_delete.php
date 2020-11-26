<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>View participants</title>

    <script>
        function deleteconfirm(id) {
            if(confirm("Are you sure want to delete this?")){
                document.location.href = 'delete.php?id='+id;
                }
            }
    </script>
</head>
<body>


<body>
    <h1>View all of the participants for edit or delete</h1>
    <a href=".">Back to index</a>
    <?php
        
    //including connection variables - remember to update these if you are using XAMPP    
    include 'dbconnect.php';
        
        try {
            $conn = new PDO("mysql:host=$servername;port=$port;dbname=$database", $username, $password); //building a new connection object
            // set the PDO error mode to exception
            $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

            //Selecting multiple rows from a MySQL database using the PDO::query function.
            $sql = $conn->query("SELECT * FROM participant")->fetchAll();

            // TODO - Possibly put into a table to make it look neater if I get time.
            foreach($sql as $row){

                // display results to person
                echo "<br><br><b>". "Participant #". $row['id']. "</b><br>First name: ".$row['firstname']."<br>Second Name: ".$row['surname']."<br>Email: ".$row['email']."<br>Power output: ".$row['power_output']."<br>Distance: ".$row['distance']."<br>";

                //these allow a user to edit / delete the participant by passing the id across on the URL
                // different line because " wont work due to the link
                echo '<a href="edit_participant.php?id='.$row['id'].'">Edit participant '.$row['id'].'</a> or <a href="javascript:deleteconfirm('.$row['id'].')">Delete participant '.$row['id'].'</a><br>';

                }

            }
        catch(PDOException $e)
            {
            echo $e->getMessage(); //If we are not successful we will see an error
            }
        ?>


</body>
</html>