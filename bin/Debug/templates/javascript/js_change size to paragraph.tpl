<!-- Use all in the body section  -->
<p id="(insert paragraph ID)">This is the text you want to change color to</p>

<button onclick="toBigger()">Change to bigger!</button>
<button onclick="toNormal()">Reset to normal!</button>
<button onclick="toSmaller()">Change to smaller!</button>

<script>
function toBigger() {
  let x = document.getElementById("(insert paragraph ID)");
  x.style.fontSize = "large"; 
}
function toNormal() {
  let x = document.getElementById("(insert paragraph ID)");
  x.style.fontSize = "medium"; 
}
function toSmaller() {
  let x = document.getElementById("(insert paragraph ID)");
  x.style.fontSize = "small"; 
}
</script>
