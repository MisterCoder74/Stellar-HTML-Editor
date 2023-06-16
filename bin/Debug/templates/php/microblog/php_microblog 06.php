//put this content in a file called write.php

<?php
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
  $entries = json_decode(file_get_contents('entries.json'), true);
  $entry = [
    'id' => uniqid(),
    'author' => $_POST['author'],
    'title' => $_POST['title'],
    'content' => $_POST['content'],
    'date' => date('Y-m-d H:i:s'),
    'status' => "approved",
    'like' => 0,
    'view' => 0,
  ];
  $entries[] = $entry;
  file_put_contents('entries.json', json_encode($entries, JSON_PRETTY_PRINT));
  header('Location: blog.php');
  exit;
}
?>
<!DOCTYPE html>
<html>
<head>
  <title>Blog System</title>
  <link rel="stylesheet" type="text/css" href="blogstyle.css">
</head>
<body>
  <h1>Write a new post</h1>
  <form action="write.php" method="post">
    <div>
      <label for="author">Author:</label>
      <input type="text" id="author" name="author">
    </div>
    <div>
      <label for="title">Title:</label>
      <input type="text" id="title" name="title">
    </div>
    <div>
      <label for="content">Content:</label>
      <textarea id="content" name="content" cols=30 rows=8></textarea>
    </div>
    <div>
<br>
      <input type="submit" value="Send">
    </div>
  </form>
</body>
</html>
