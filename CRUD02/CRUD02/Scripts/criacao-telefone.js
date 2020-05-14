$(function () {
    var quantidadeTelefones = 0;

    $("#btn-adicionar-telefone").click(function (e) {
        e.preventDefault();

        var blocoTelefone = '<div class="row">' +
            '    <div class="col-md-2">' +
            '        <input type="number" name="Telefones[' + quantidadeTelefones + '].DDD" maxlength="2" placeholder="DDD" class ="form-control txt-ddd" />' +
            '    </div> ' +
            '    <div class="col-md-6">' +
            '       <input type="text" name="Telefones[' + quantidadeTelefones + '].Numero" placeholder"Número" class="form-control txt-numero" />' +
            '    </div>' +
            '    <div class="col-md-3">' +
            '       <select name="Telefones[' + quantidadeTelefones + '].Tipo" class="form-control sel-tipo">' +
            '            <option value="0">Residêncial</option>' +
            '            <option value="1">Comercial</option>' +
            '            <option value="2">Celular</option>' +
            '            <option value="3">Recado</option>' +
            '        </select>' +
            '    </div>' +
            '    <div class="col-md-1">' +
            '        <button class="btn btn-danger btn-remover-telefone">' +
            '            <span class="glyphicon glyphicon-trash"></span>' +
            '        </button>' +
            '    </div>' +
            '</div >';
        $("#div-telefones").append(blocoTelefone);
        quantidadeTelefones++;
    });

    $("#div-telefones").on("click", ".btn-remover-telefone", function (e) {
        e.preventDefault();

        $(this).parent().parent().remove();

        quantidadeTelefones--;

        $("#div-telefones .row").each(function (indice, elemento) {
            $(elemento).find(".txt-ddd").attr("name", "Telefone[" + indice + "].DDD");
            $(elemento).find(".txt-numero").attr("name", "Telefone[" + indice + "].Numero");
            $(elemento).find(".sel-tipo").attr("name", "Telefone[" + indice + "].Tipo");
        });
    });
});