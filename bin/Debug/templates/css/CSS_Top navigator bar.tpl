<!-- Top navigation bar to be used in pair with "html5_top navigator bar CSS" snippet... -->
<!-- Put this code in your HEAD section... -->
<style>
.hovernav-bar {
  width: 100%; /* Full-width - reduce if you want it shorter */
  background-color: #555; /* Dark-grey background */
  overflow: auto; /* Overflow due to float */
}

.hovernav-bar a {
  float: left; /* Float links side by side */
  text-align: center; /* Center-align text */
  width: 20%; /* Equal width (5 icons with 20% width each = 100%) */
  padding: 12px 0; /* Some top and bottom padding */
  transition: all 0.3s ease; /* Add transition for hover effects */
  color: white; /* White text color */
  font-size: 36px; /* Increased font size */
  text-decoration: none; /* Removes underlining fro link text*/
}

.hovernav-bar a:hover {
  background-color: #000; /* Add a hover color */
}

.active {
  background-color: #04AA6D; /* Add an active/current color */
}
</style>

