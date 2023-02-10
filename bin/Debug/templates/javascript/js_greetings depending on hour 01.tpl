<p>Display "Good day!" if the hour is less than 18:00 and "Good evening!"  if the hour is more than 18:00</p>

<p id="demo">The greeting appears here</p>

<script>
const hour = new Date().getHours(); 
let greeting;

if (hour < 18) {
  greeting = "Good day";
} else {
  greeting = "Good evening";
}

document.getElementById("demo").innerHTML = greeting;
</script>

