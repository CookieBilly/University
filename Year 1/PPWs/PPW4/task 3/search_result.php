<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Search results</title>
    
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
            
            //checking which form has been posted
            if ($_POST['participant'] == "1") {

                // ensure that the input is set
                if(!empty($_POST["firstname"])) {

                    // run the query to check if the name exists in the database, then save the results to a variable
                    // tried using bind with fetchall, was throwing errors.
                    $result = $conn->query("SELECT * FROM participant WHERE firstname LIKE '%" . $_POST["firstname"] . "%' OR surname LIKE '%" . $_POST["firstname"] . "%'")->fetchall();

                    // loop through the results and print them to the person
                    foreach ($result as $row) {

                        echo "<br><br><b>". "Result Found! Participant #". $row['id']. "</b><br>First name: ".$row['firstname']."<br>Second Name: ".$row['surname']."<br>Email: ".$row['email']."<br>Power output: ".$row['power_output']."<br>Distance: ".$row['distance'];
                    }

                    // if nobody is found here, throw a sadface.
                    if(Count($result) < 1) {
                        echo "<br><br>No results found, please try again!";
                    }


                } else {
                    echo 'You need to ensure you input a name in the box!';
                }


            } else {

                // run as club

                // ensure that the input is set (not sure why it's called first name, but heyho)
                if(!empty($_POST["firstname"])) {


                    // run the query to check if the name exists in the database, then save the results to a variable
                   // $result = $conn->query("SELECT * FROM club WHERE name = " . $_POST["firstname"]);
                    $result = $conn->prepare("SELECT * FROM club WHERE name = ?");
                    $result -> bindValue(1, $_POST['firstname']);
                    $result -> execute();

                    // loop through the results and print them to the person
                    foreach ($result as $row) {

                        // if nobody is found here, throw a sadface.
                        if($row['id'] == "") {
                            echo "<br><br>No results found, please try again!";
                        }


                        // print the club information
                        echo "<br><br><b>". "Result Found! Club #". $row['id']. "</b><br>Club name: ".$row['name']."<br>Club Location: ".$row['location'];

                        // query to find all users with this club ID
                        $participants = $conn->query("SELECT * FROM participant WHERE club_id = ".$row['id'])->fetchall();

                        // set the total power and distance to 0 so it doesnt throw a hissy fit
                        $totalpower = 0;
                        $totaldistance = 0;

                        // loop through the people assigned to the club
                        foreach ($participants as $person) {

                            // add this person's power to total power
                            $totalpower =  $totalpower + $person['power_output'];

                            // add this person's distance
                            $totaldistance = $totaldistance + $person['distance'];

                            // give info about this person
                            echo "<br><br><b>". "Club Member: </b><br>Name: ".$person['firstname']." ".$person['surname']."</b><br>Distance: ".$person['distance']."</b><br>Power output: ".$person['power_output'];


                            }

                        // calculate averages (total / amount of people)
                        $averagepower =  $totalpower / Count($participants);
                        $avaragedistance = $totaldistance / Count($participants);

                        echo "<br><br><b>". "Club statistics:</b><br>Total power output: $averagepower<br>Total distance: $totaldistance<br>Average power output: $averagepower<br>Average distance: $avaragedistance";

                    }


                }

            }


            }
        catch(PDOException $e)
            {
            echo $result . "<br>" . $e->getMessage(); //If we are not successful in connecting or running the query we will see an error
            }
        ?>


</body>
</html>