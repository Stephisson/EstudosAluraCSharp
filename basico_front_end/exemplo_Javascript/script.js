function adicionar() {
    document.body.style.backgroundColor = 'blue';
}

function retirar() {
    document.body.style.backgroundColor = 'white';
}

function chamar() {
    window.location ="outra_pagina.html";
}

function voltar() {
    window.location ="index_2.html";
}

var texto = "Isso é um exemplo de texto com um 'apóstrofo'.";

function exibirTexto() {
    document.getElementById("textoParaExibir").textContent = texto;
    exibirTexto();
}


function removerApostrofo() {
    // Remover o caractere de apóstrofo (')
    texto = texto.replace(/'/g, "");
    exibirTexto(); // Atualize o texto exibido
}
exibirTexto();
alert('Estamos começando a imersão');