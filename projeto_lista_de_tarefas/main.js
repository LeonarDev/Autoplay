import CheckButton from './components/completeTask.js';
import DeleteButton from './components/deleteTask.js';

const createTask = (event) => {
  event.preventDefault();

  const list = document.querySelector('[data-list]');
  const input = document.querySelector('[data-form-input');
  const value = input.value;
  const task = document.createElement('li');
  const content = `<p class="content"> ${value} </p>`;
  
  task.innerHTML = content;
  task.classList.add('task');
  task.appendChild(CheckButton());
  task.appendChild(DeleteButton());
  list.appendChild(task);

  input.value = '';
}

const newTask = document.querySelector('[data-form-button]');
newTask.addEventListener('click', createTask);
