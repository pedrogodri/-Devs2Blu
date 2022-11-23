var listCharacter = new Array();

addEventListener('load', function () {
    getAPI(URL_API_CHARACTER, criaListaCharacter);
});


const criaListaCharacter = (data) => {
    let main = getElement('main');
    console.log(data);
    listCharacter = new Array();

    data.results.forEach(character => {
        let html = document.createElement('div');
        html.classList.add('card', 'col-3', 'my-4', 'bg-dark', 'ms-1');
        html.addEventListener('click', () => mostraDetalhesCharacter(character))

        let htmlBody = `
        <div class="card-header">
            <img class="card-img-top" src="${character.image}" alt="${character.name}">
        </div>
        <div class="card-body bg-white">
            <h1 class="text-primary text-center">${character.name}</h1>
        </div>`;

        html.innerHTML = htmlBody;
        main.appendChild(html);
        listCharacter.push(character);
    });
    gerarPaginacao(data.info);
}

const mostraDetalhesCharacter = (character) => {
    console.log(character);
    let div = document.createElement('div');
    getElement('#modal-body').innerHTML = "";
    div.classList.add('card', 'col-12', 'my-4', 'bg-dark');

    let cardBody = `
            <div class="card-header">
                <img class="card-img-top" src="${character.image}" alt="Rick">
            </div>
            <div class="card-body bg-white">
                <h1 class="text-primary text-center">${character.name}</h1>
                <article>
                    <ul class="list-group">
                        <li class="list-group-item">${character.status}</li>
                        <li class="list-group-item">${character.species}</li>
                        <li class="list-group-item">${character.gender}</li>
                        <li class="list-group-item">${character.origin.name}</li>
                        <li class="list-group-item">${character.location.name}</li>
                        <li class="list-group-item">${character.url}</li>
                        <li class="list-group-item">${character.created}</li>
                    </ul>
                </article>
            </div>
        `;
    div.innerHTML = cardBody;
    getElement('#modal-body').appendChild(div);

    $('#charModal').modal('show');
}

const gerarPaginacao = (info) => {

    let pag = getElement('#pagination');
    let liItem = document.createElement('li');
    liItem.classList.add('page-item');

    let prevItem = document.createElement('li');
    prevItem.innerHTML = `<a onclick="irItemPaginacao(${info.prev})" class="page-link" href="#">Previous</a>`;
    pag.appendChild(prevItem);

    for (let index = 0; index < pag.pages; index++) {
        let liItemPag = document.createElement('li');
        prevItem.innerHTML = `<a onclick="irItemPaginacao(${URL_API_CHARACTER}?page=${index + 1})" 
                                class="page-link" href="#">${index + 1}</a>`;
        pag.appendChild(liitemPag);
    }

    let nextItem = document.createElement('li');
    nextItem.classList.add('page-item');
    nextItem.innerHTML = `<a onclick="irItemPaginacao(${info.next})" class="page-link" href="#">Previous</a></li>`;
    pag.appendChild(nextItem);
}

const novoItemPagination(url, index) => {
    let liItem = document.createElement('li');
    liItem.classList.add('page-item');
    prevItem = document.createElement('li');
    return liItem;
}

const irItemPaginacao = (url) => {
    let liItem = document.createElement('li');
}

let info = {
    count: 826,
    pages: 42,
    next: "https://rickandmortyapi.com/api/character?page=2",
    prev: null
}