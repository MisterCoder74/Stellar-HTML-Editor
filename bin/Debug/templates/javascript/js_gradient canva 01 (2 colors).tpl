<!-- works with the html5_gradient canva JS 01 (2 colors) snippet -->
<!-- place in the BODY section -->
<script>
var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");
// Create gradient
var grd = ctx.createLinearGradient(0,0,500,0);
grd.addColorStop(0,"red");
grd.addColorStop(1,"black");
// Fill with gradient
ctx.fillStyle = grd;
ctx.fillRect(0,0,500,80);
</script>
