<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <link rel="stylesheet" href="./css/styles_main.css">
    <title>Komunikator-Teksrowy</title>
  </head>
  <body>

    <div id="top">
    <h1>Komunikator-Tekstowy
    </div>

    <div id="viewpanel">
<h1>Panel widoku

    </div>

    <div id="buttonpanel">
<form action="main.php" method="post">
<input type="submit" name="logout" value="Wyloguj">

<?php
if (isset($_POST['logout']))
{
    header('Location: index.php');
}

?>


    </div>

    <div id="userpanel">
<h1>Panel użytkowników

    </div>

    <div id="enterpanel">
<h1> Panle Wprowadzenia

    </div>



  </body>
</html>