<form id="frm1" action="/action_page.php">
First name: <input type="text" name="fname"><br>
Last name: <input type="text" name="lname"><br><br>
<input type="button" onclick="submitFunction()" value="Submit">
<input type="button" onclick="resetFunction()" value="Reset">
</form>

<script>
function submitFunction() {
  document.getElementById("frm1").submit();
}function resetFunction() {
  document.getElementById("frm1").reset();
}
</script>
