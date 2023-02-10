<p>A time-based greeting:</p>

<p id="demo">The greeting appears here</p>

<script>
const time = new Date().getHours();
let greeting;
if (time < 12) {
  greeting = "Good morning";
} else if (time < 18) {
  greeting = "Good afternoon";
} else if (time < 22) {
  greeting = "Good evening";
} else if (time < 24) {
  greeting = "Good night";
}
document.getElementById("demo").innerHTML = greeting;
</script>
