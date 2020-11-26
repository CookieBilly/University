<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Register your interest</title>
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

                // Has the user agreed to the terms?
                if (!empty($_POST['terms'])) {

                    // check to ensure all values are filled
                    if(!empty($_POST["firstname"]) && !empty($_POST["surname"]) && !empty($_POST["email"])) {



                        // Check that the email is an email address
                        if(strpos($_POST['email'], '@') !== false){

                            if(strpos($_POST['email'], '.') !== false){


                                // the sql statement - uses "1" as we've already ensured they agree, it's going to be static
                                $sql = $conn->prepare("INSERT INTO interest (firstname, surname, email, terms) VALUES (?, ?, ?, ?)");
                                $sql -> bindValue(1, $_POST["firstname"]);
                                $sql -> bindValue(2, $_POST["surname"]);
                                $sql -> bindValue(3, $_POST["email"]);
                                $sql -> bindValue(4, 1);

                                // run the sql on database
                                $sql -> execute();

                                echo 'You have successfully registered your interest! Thank you :)';

                            }


                        } else {
                            echo 'Please use a valid email address (for example: example@example.com)';
                        }



                    } else {

                        echo 'You have not filled in the entire form, please do this!';
                        // tell them not everything has been filled in

                    }

                } else {

                    // If they have not agreed, we must shout at them!
                    echo 'You need to accept our terms and conditions first!';

                }





                }
            catch(PDOException $e)
                {
                echo $e->getMessage(); //If we are not successful we will see an error
                }



        ?>


</body>
</html>