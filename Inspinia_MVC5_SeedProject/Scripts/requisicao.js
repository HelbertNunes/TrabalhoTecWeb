function get(rota, dado, sucesso, falha) {
    var _url = rota;

    $.ajax({
        url: _url,
        type: 'GET',
        data: JSON.stringify(dado),
        contentType: "application/json",
        dataType: 'json',
        success : sucesso,
        error : (jqXHR, _) => falha(jqXHR.responseText)
    })
}

function post(rota, dado, sucesso, falha) {
    var _url = rota;

    $.ajax({
        url: _url,
        type: 'POST',
        contentType: "application/json",
        dataType: 'json',
        data: JSON.stringify(dado),
        success : sucesso,
        error : (jqXHR, _) => falha(jqXHR.responseText)
    })
}

function del(rota, dado, sucesso, falha) {
    var _url = rota;

    $.ajax({
        url: _url,
        type: 'DELETE',
        data: JSON.stringify(dado),
        contentType: "application/json",
        dataType: 'json',
        success : sucesso,
        error : (jqXHR, _) => falha(jqXHR.responseText)
    })
}