//put this content in a file called update_view.php

<?php

// Get the entry ID from the URL
$entry_id = $_GET['id'];

// Read the entries from the json file
$entries = json_decode(file_get_contents('entries.json'), true);

// Find the entry with the matching ID
foreach ($entries as &$entry) {
  if ($entry['id'] == $entry_id) {
    // Increment the number of likes
    $entry['view']++;
    break;
  }
}

// Write the entries back to the json file
file_put_contents('entries.json', json_encode($entries, JSON_PRETTY_PRINT));

// Redirect back to the entry detail page
header('Location: entry.php?id=' . $entry_id);

?>