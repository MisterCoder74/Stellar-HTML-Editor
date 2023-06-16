  <!-- Put this code in a file called blog.php -->
  <!-- create a json file called 'entries.json' containing [] -->

<center>
  <h1>Mini Blog System</h1>
  <hr>
  <a href="write.php">Write new post</a>
  <hr>
  <div id="entries">
    <?php foreach ($entries as $entry): ?>
      <div class="entry">
        <h2><?php echo $entry['title']; ?></h2>
        <p class="author">by <?php echo $entry['author']; ?></p>
        <p class="date"><?php echo $entry['date']; ?></p>
        <p class="content"><?php echo substr($entry['content'], 0, 120); ?> <a title="Read article" href="entry.php?id=<?php echo $entry['id']; ?>">[...]</a></p>
        <hr>
        <p class="date">
	Likes: <?php echo ($entry['like']); ?><br>
        Reads: <?php echo ($entry['view']); ?></p>
        <hr>
        <p><a title="Load article" href="entry.php?id=<?php echo $entry['id']; ?>">Load full article</a></p>
      </div>
    <?php endforeach; ?>
  </div>
  <hr>
</center>