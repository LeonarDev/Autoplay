load = () => {
  let date = new Date();
  let hour = date.getHours();
  let image = document.getElementById("image");
  let message = document.getElementById("message");
  message.innerHTML = `Agora são ${hour} horas <br>`

  day = () => {
    document.body.style.background = "rgb(236, 225, 70)";
    image.src = "img/dia.png";
    message.innerHTML += `<br>Bom dia!`
  }

  afternoon = () => {
    document.body.style.background = "rgb(218, 132, 4)";
    image.src = "img/tarde.png";
    message.innerHTML += `<br>Boa tarde!`
  }

  night = () => {
    document.body.style.background = "rgb(16, 3, 133)";
    image.src = "img/noite.png";
    message.innerHTML += `<br>Boa noite!`
  }

  hour < 12 ? day() : (hour >= 12 && hour < 18) ? afternoon() : night()  
}
