<button onclick="confirmFunction()">Open confirmation box</button>

<p id="demo"></p>

<script>
function confirmFunction() {
  var txt;
  if (confirm("Press a button!")) {
    txt = "You pressed OK!";
  } else {
    txt = "You pressed Cancel!";
  }
  document.getElementById("demo").innerHTML = txt;
}
</script>
