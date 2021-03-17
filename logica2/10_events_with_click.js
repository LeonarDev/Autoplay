let canvasScreen = document.querySelector('canvas');
let paintbrush = canvasScreen.getContext('2d');
let colors = ['blue', 'red', 'green'];
let colorIndex = 0;
let ray = 10;

paintbrush.fillStyle = 'lightgrey';
paintbrush.fillRect(0, 0, 600, 400);

drawCircles = (event) => {
  let x = event.pageX - canvasScreen.offsetLeft;
  let y = event.pageY - canvasScreen.offsetTop;
  
  if (event.shiftKey && ray <= 40) {
    ray += 10;
  }

  if (event.altKey && ray >= 10) {
    ray -= 5;
  }

  paintbrush.fillStyle = colors[colorIndex];
  paintbrush.beginPath();
  paintbrush.arc(x, y, ray, 0, 2 * 3.14);
  paintbrush.fill();

  
  console.log(`Position of the click: ${x} ${y}`)
}

changeColor = (event) => {
  colorIndex++;

  if (colorIndex >= colors.length) {
    colorIndex = 0;
  }
  return false;
}

canvasScreen.onclick = drawCircles;
canvasScreen.oncontextmenu = changeColor;