<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <link rel="stylesheet" href="./css/styles.css">
    <title>Komunikator-Teksrowy-Rejestracja</title>
  </head>
  <body>

    <div id="top">
    <h1>Komunikator-Tekstowy-Rejestracja
    </div>

    <div id="container">
      <form action="register.php" method="post">
        <h3>Podaj nazwe
        <input type="text" required="required" name="name"><br>
        <h3>Podaj email
        <input type="text" required="required" name="email"><br>
        <h3>Podaj hasło
        <input type="password" required="required" name="password"><br>
        <h3>Powtórz hasło
        <input type="password" required="required" name="repassword"><br>
        <input type="submit" name="register" value="Zarejestruj się">
    </div>

    <?php
    if (isset($_POST['register'])){
    $password = $_POST['password'];
    $repassword = $_POST['repassword'];

    if ($password != $repassword)
    {
      echo "Podane hasła nie są identyczne";
    }
    else
    {
      //kod do rejestracju użytkownika w bazie

    }

    }

    ?>

  </body>
</html>
