<!-- This shall be used with the html5 glowing menu 01 (white bg) CSS template -->
<style>
body{
margin: 0;
padding: 0;
font-family: Verdana, Geneva, sans-serif;
display: flex;
justify-content:center;
align-items: center;
min-height: 100vh;
background: #fff;
}

.box{
position: relative;
width: 200px;
htight: 400px;
display: flex;
align-items: center;
background: #fff; 
}

.box:before{
content: ' ';
position: absolute;
top: -2px;
left: -2px;
right: -2px;
bottom: -2px;
background: #fff;
z-index: -1;
}

.box:after{
content: ' ';
position: absolute;
top: -2px;
left: -2px;
right: -2px;
bottom: -2px;
background: #fff;
z-index: -2;
filter: blur(40px);
}

.box:before, .box:after {
background: linear-gradient(235deg,#89ff00,#fff,#00bcd4); 
}

.content{
padding: 20px;
box-sizing: border-box;
color: #000;
}

h3{
 text-shadow: 2px 2px 5px #89ff00;
}

a{
text-shadow: 2px 2px 5px #89ff00;
text-decoration: none;
}

a:hover{
text-shadow: 2px 2px 5px #00bcd4;
text-decoration: underline;
}
</style>
