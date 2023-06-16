//place on very top of every file that must be user-restricted, and make sure the
//forms for login and registration use the 'user' variable

<?php
// Start the session and check if the user is logged in
session_start();
if (!isset($_SESSION['user'])) {

// modify with the name of your login page
  header('Location: login.php');
  exit;
}

// Get the user object from the session
$user = $_SESSION['user'];
?>