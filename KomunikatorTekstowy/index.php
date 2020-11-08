<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <link rel="stylesheet" href="./css/styles.css">
    <title>Komunikator-Teksrowy-Logowanie</title>
  </head>
  <body>

    <div id="top">
    <h1>Komunikator Tekstowy
    </div>

    <div id="container">
      <form action="index.php" method="post">
        <h3>Podaj login
        <input type="text" name="login"><br>
        <h3>Podaj hasło
        <input type="password" name="haslo"><br>
        <input type="submit" name="login" value="Zaloguj"><br>
        <input type="submit" name="createaccount" value="Zarejestruj się"><br>

      </form>

    </div>

    <?php
      if (isset($_POST['login']))
      {
        // tutaj misi być warunek sprawdzajacy poprawność loginu i hasła z bazy danych ;)
        header('Location: main.php');

      }

      if (isset($_POST['createaccount']))
      {
        header('Location: register.php');
      }


    ?>

  </body>
</html>
