var listCharacter = new Array();

addEventListener('load', function(){ // ao carregar a página, ele chama a função
    getAPI(URL_API_CHARACTER, criaListaCharacter); 
    console.log("API CARREGADA");
});

const criaListaCharacter = (data) => {
    let main = getElement('main');
    console.log(data); // printa os itens da API
    //listCharacter = new Array();
    data.forEach(character => {
        console.log(character);
        let html = document.createElement('div');// cria a tag html no documento de origem
        html.classList.add('card', 'col-3', 'my-4', 'ms-1', 'bg-dark'); // atribui as classe à tag // tem que ser passado como um array ao invés de uma única string
        html.addEventListener('click', ()=> mostraDetalhesCharacter(character)); // quando clicar, executa a arrow function

        let htmlBody = `
        <div class="card-header meu-card">
            <img class="card-img-top" src="${character.imageUrl}" alt="${character.firstName}">
        </div>
        <div class="card-body bg-dark">
            <h1 class="text-white text-center">${character.firstName}</h1>
        </div>`; // cria o HTML do card inteiro

        html.innerHTML = htmlBody; // adiciona a string 'htmlBody' dentro do html
        main.appendChild(html); // adicionando os cards (filhos) na tag main
        listCharacter.push(character);
    });
}

const mostraDetalhesCharacter = (character) => {
    console.log(character);
    let div = document.createElement('div');
    getElement('#modal-body').innerHTML = ""; // apaga o último modal aberto, fazendo com que não haja repetição no modal
    div.classList.add('card', 'col12', 'my-4');

    let cardBody = `
    <div class="card-header">
        <img class="card-img-top" src="${character.imageUrl}" alt="${character.firstName}">
    </div>
    <div class="card-body bg-white">
        <h1 class="text-primary text-center">${character.firstName}</h1>
        <article>
            <ul class="list-group">
                <li class="list-group-item">Nome completo: ${character.fullName}</li>
                <li class="list-group-item">Título: ${character.title}</li>
                <li class="list-group-item">Família: ${character.family}</li>
              </ul>
        </article>
    </div>`;
    
    div.innerHTML = cardBody;
    getElement('#modal-body').appendChild(div);

    $('#charModal').modal('show');

}