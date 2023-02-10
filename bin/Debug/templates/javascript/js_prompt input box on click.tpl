<button onclick="promptFunction()">Click to insert text</button>

<p id="demo"></p>

<script>
function promptFunction() {
  let text;
  let person = prompt("Please enter your name:", "(Insert your name here)");
  if (person == null || person == "") {
    text = "User cancelled the prompt.";
  } else {
    text = "Hello " + person + ", how are you today?";
  }
  document.getElementById("demo").innerHTML = text;
}
</script>
