//put this content in a file called get_entry.php

<?php

$entryId = intval($_GET["id"]);
$jsonFile = "entries.json";

$entries = json_decode(file_get_contents($jsonFile), true);

$entry = null;

foreach ($entries as $e) {
  if ($e["id"] === $entryId) {
    $entry = $e;
    break;
  }
}

if ($entry === null) {
  http_response_code(404);
  exit;
}

echo json_encode($entry);
?>