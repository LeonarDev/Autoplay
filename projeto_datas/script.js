carregar = () => {
  var message = document.getElementById("div_msg");
  var image = document.getElementById("img_dia");

  var date = new Date();
  var hour = date.getHours();

  message.innerHTML = `<br> Agora são ${hour} hours <br>`

  if(hour >= 0 && hour < 12) {
    image.src = "img/dia.png";
    document.body.style.background = "rgb(236, 225, 70)";
    message.innerHTML += `<br>Bom dia!`

  } else if (hour >= 12 && hour < 18) {
    image.src = "img/tarde.png";
    document.body.style.background = "rgb(218, 132, 4)";
    message.innerHTML += `<br>Boa tarde!`

  } else {
    image.src = "img/noite.png";
    document.body.style.background = "rgb(16, 3, 133)";
    message.innerHTML += `<br>Boa noite!`
  }
}
