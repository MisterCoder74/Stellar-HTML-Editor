<!-- Use all in the body section  -->
<p id="(insert paragraph ID)">This is the text you want to change color to</p>

<button onclick="toRed()">Change to red!</button>
<button onclick="toBlack()">Reset to black!</button>

<script>
function toRed() {
  let x = document.getElementById("(insert paragraph ID)");
  x.style.color = "red"; 
}
function toBlack() {
  let x = document.getElementById("(insert paragraph ID)");
  x.style.color = "black"; 
}
</script>