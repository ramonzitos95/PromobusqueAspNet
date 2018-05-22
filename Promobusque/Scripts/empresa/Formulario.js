$(document).ready(function () {
    funcoes.ativaFormulario();
    $('#cnpj').mask('99.999.999/9999-99');
});

var funcoes = {
    ativaFormulario : function () {
        //Envia o formulário
        $('#btn-submit').click(function () {
            $.post(window.location.href + "/Gravar", $("#form").serialize())
                .done(function (data) {
                    //window.location.reload();
                })
                .fail(function (erro) { 
                    var mensagem = erro.responseJSON;
                    $('#mensagemErro').text(mensagem);
                });
        });
    }
}


