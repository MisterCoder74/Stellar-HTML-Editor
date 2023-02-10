<!-- Put in the HEAD section -->
<script type="text/javascript"> 
function display_c(){
var refresh=1000; // Refresh rate in milli seconds
mytime=setTimeout('display_ct()',refresh)
}

function display_ct() {
var x = new Date()
document.getElementById('ct').innerHTML = x;
display_c();
 }
</script>

<!-- Put in the BODY section -->
<body onload=display_ct();>
<span id='ct' ></span>
