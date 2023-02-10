<!-- modificare in modo che legga Text2 da una casella di testo -->
<p>Replace Text1 with Text2 in the paragraph below:</p>

<button onclick="wordReplace()">Try it</button>

<p id="demo">This paragraph now contains Text1</p>

<script>
function wordReplace() {
  let text = document.getElementById("demo").innerHTML;
  document.getElementById("demo").innerHTML =
  text.replace("Text1","Text2");
}
</script>
