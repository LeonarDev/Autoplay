let tabela = document.querySelector("#tabela-pacientes");

tabela.addEventListener("dblclick", ({ target }) => {
    target.parentNode.classList.add("fadeOut");

    setTimeout(() => {
        target.parentNode.remove();
    }, 500);

});
