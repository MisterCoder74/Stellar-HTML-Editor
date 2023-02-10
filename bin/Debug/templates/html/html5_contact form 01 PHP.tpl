<!-- works with PHP file php_contact form 01 and with CSS template CSS_contact form 01 PHP -->
<!-- insert in a table width = 800 -->

<h3>Contact us</h3>
<form id="fcf-form-id" class="fcf-form-class" method="post" action="contact-form-process.php">
<br>
<label for="Name" class="fcf-label">Your name</label>
<div class="fcf-input-group">
<input type="text" id="Name" name="Name" class="fcf-form-control" required>
</div>
<div class="fcf-form-group">
<br>
<label for="Email" class="fcf-label">Your email address</label>
<div class="fcf-input-group">
<input type="email" id="Email" name="Email" class="fcf-form-control" required>
</div>
<div class="fcf-form-group">
<br>
<label for="Message" class="fcf-label">Your message</label>
<div class="fcf-input-group">
<textarea id="Message" name="Message" class="fcf-form-control" rows="6" maxlength="3000" required></textarea>
</div>
</div>
<div class="fcf-form-group">
<button type="submit"  class="btn btn-primary">Send</button>
</div>
