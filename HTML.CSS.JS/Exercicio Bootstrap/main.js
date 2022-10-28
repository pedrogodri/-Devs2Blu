$(document).ready(() => {
    console.log('JQuery is loaded')
    //Carregar pagina
    $('#conteudoInformacao').click((e) => {
        $.ajax({
            url: "conteudoInformacao.html",
            success: (data, textStatus, xhr) => {
                console.log(data);
                console.log(textStatus);
                console.log(xhr);
                $('#conteudo').html(data);
            }
        })
    });
});