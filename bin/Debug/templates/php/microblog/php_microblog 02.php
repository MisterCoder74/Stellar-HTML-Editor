//put this code in a file named entry.php
//add your styling and other html contents

<?php
$entries = json_decode(file_get_contents('entries.json'), true);
$entry = null;

if (isset($_GET['id'])) {
  foreach ($entries as $e) {
    if ($e['id'] == $_GET['id']) {
      $entry = $e;
      
      break;
    }
  }
}

if (!$entry) {
  header('Location: blog.php');
  exit;
}

?>
<!DOCTYPE html>
<html>
<head>
  <title>Blog - <?php echo $entry['title']; ?></title>
  <link rel="stylesheet" type="text/css" href="blogstyle.css">
</head>
<body>
<center>
  <h1>Blog</h1>
  <div class="entry">
    <h2><?php echo $entry['title']; ?></h2>
    <div class="author">By <?php echo $entry['author']; ?></div>
    <div class="date"><?php echo $entry['date']; ?></div>
    <div class="content"><?php echo $entry['content']; ?></div>
    <hr>
    <div class="date">
    Likes: <?php echo ($entry['like']); ?><br>
    Reads: <?php echo ($entry['view']); ?> </div> <hr>
    <a id="sharer" target="_blank">Share on Facebook</a> // <a id="liker" onclick="location.href='update_like.php?id=<?php echo $entry['id']; ?>'">Give a Like</a> // 
    <a id="viewer" onclick="location.href='update_view.php?id=<?php echo $entry['id']; ?>'">Grant as read</a>
  </div>
  <hr>
  <a href="blog.php">Back to entries list</a>
  <hr>
  </center>
  <script>
    var x = window.location.href;
document.getElementById("sharer").href = "http://www.facebook.com/share.php?u="+encodeURIComponent(x);
    </script>
</body>
</html>