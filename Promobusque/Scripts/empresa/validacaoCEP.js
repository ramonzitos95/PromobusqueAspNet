$("#cep").blur(function () {

    //Nova variável "cep" somente com dígitos.
    var cep = $(this).val().replace(/\D/g, '');

    //Verifica se campo cep possui valor informado.
    if (cep != "") {

        //Expressão regular para validar o CEP.
        var validacep = /^[0-9]{8}$/;

        //Valida o formato do CEP.
        if (validacep.test(cep)) {

            //Preenche os campos com "..." enquanto consulta webservice.
            $("#endereco").val("...");
            $("#cidade").val("...");
            $("#estado").val("...");

            //Consulta o webservice viacep.com.br/
            $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {

                if (!("erro" in dados)) {
                    //Atualiza os campos com os valores da consulta.
                    $("#endereco").val(dados.logradouro);
                    $("#cidade").val(dados.bairro);
                    $("#estado").val(dados.localidade);
                }
                else {
                    //CEP pesquisado não foi encontrado.
                    alert("CEP não encontrado.");
                    limpaCamposRelacionadosCEP();
                }
            });
        }
        else {
            alert("Formato de CEP inválido.");
            limpaCamposRelacionadosCEP();
        }
    } //end if.
});

function limpaCamposRelacionadosCEP() {
    $('#cep').val("");
    $('#endereco').val("");
    $('#cidade').val("");
    $('#estado').val("");
    $('#cep').focus();
}