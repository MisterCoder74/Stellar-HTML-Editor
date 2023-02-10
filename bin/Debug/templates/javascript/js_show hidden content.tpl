<!-- Use all in the body section  -->
<button onclick="showContent()">Show hidden content</button>

<!-- defines hidden template  -->
<template>
<h2>(text here></h2>
<!-- remove image if you don't want it  -->
<img src="(put image url)" width= height= >
</template>

<script>
function showContent() {
var temp = document.getElementsByTagName("template")[0];
var clon = temp.content.cloneNode(true);
document.body.appendChild(clon);
}
</script>