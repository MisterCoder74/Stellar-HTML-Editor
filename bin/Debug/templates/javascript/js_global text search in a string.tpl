<!-- adattare per leggere la stringa e la parola da cercare da due textbox -->
<p>Click the button to perfom a global (/g) search for the letters "ain" (/ain) in a string, and display the matches.</p>

<button onclick="myFunction()">Try it</button>

<p id="demo"></p>

<script>
function myFunction() {
  var str = "The rain in SPAIN stays mainly in the plain"; 
  var res = str.match(/ain/g);
  document.getElementById("demo").innerHTML = res;
}
</script>