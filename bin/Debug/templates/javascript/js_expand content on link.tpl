<!-- add this in the HEAD section -->
<style>
<style>
a:hover { background: #ff0; }
#toggleMe { background: #cfc; border-style: solid; border-color: black; display: none; margin: 20px 5; padding: 1em; }
</style>


<!-- add this in the BODY section -->
<h2><a id="showhide" href="#">Show content</a></h2>
        
<p id="toggleMe">(text to be shown when link is clicked).</p>
        
<script>
function changeDisplayState(id) {
var d = document.getElementById('showhide'),
e = document.getElementById(id);
if (e.style.display === 'none' || e.style.display === '') {
e.style.display = 'block';
d.innerHTML = 'Hide content';
} else {
e.style.display = 'none';
d.innerHTML = 'Show content';
}
}
document.getElementById('showhide').addEventListener('click', function (e) {
e.preventDefault();
changeDisplayState('toggleMe');
});
</script>
