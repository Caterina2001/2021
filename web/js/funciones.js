  
const buttons = document.querySelectorAll('p');

for(let i = 0; i < buttons.length ; i++) {
  buttons[i].addEventListener('click', addName);
  var num = 1;
}
function addName() {
    let para = document.createElement('p');
    let name = prompt('Introduce el nombre')
    para.textContent = 'Player '+num+": "+ name;
    document.body.appendChild(para);
    num++
  }