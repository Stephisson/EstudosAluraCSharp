var jogadorUm = {
    nome: 'Jogador Um',
    vitoria: 0,
    empate: 0,
    derrota: 0,
    pontos: 0
};

var jogadorDois = {
    nome: 'Jogador Dois',
    vitoria: 0,
    empate: 0,
    derrota: 0,
    pontos: 0
};

var elementoTabela = document.getElementById("tabelaJogadores");

exibirNaTela();

function exibirNaTela(){
    elementoTabela.innerHTML = 
        `
            <tr>
                <td>${jogadorUm.nome}</td>
                <td>${jogadorUm.vitoria}</td>
                <td>${jogadorUm.empate}</td>
                <td>${jogadorUm.derrota}</td>
                <td>${jogadorUm.pontos}</td>
                <td><button onClick="adicionarVitoria(jogadorUm)">Vitória</button></td>
                <td><button onClick="adicionarEmpate(jogadorUm)">Empate</button></td>
                <td><button onClick="adicionarDerrota(jogadorUm)">Derrota</button></td>
            </tr>
        `;
}
function adicionarVitoria(jogador) {
    jogador.vitoria++;
    jogador.pontos = jogador.pontos + 3;
    exibirNaTela();
}

function adicionarEmpate(jogador) {
    jogador.empate++;
    jogador.pontos++;
    exibirNaTela();
}

function adicionarDerrota(jogador) {
    jogador.derrota++;
    exibirNaTela();
}