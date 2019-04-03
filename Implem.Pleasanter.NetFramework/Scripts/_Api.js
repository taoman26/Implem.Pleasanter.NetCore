$p.apiUrl = function (id, action) {
    return $('#ApplicationPath').val() + 'api/items/' + id + '/' + action;
}

$p.apiGet = function (args) {
    $p.apiExec($p.apiUrl(args.id, 'get'), args);
}

$p.apiCreate = function (args) {
    $p.apiExec($p.apiUrl(args.id, 'create'), args);
}

$p.apiUpdate = function (args) {
    $p.apiExec($p.apiUrl(args.id, 'update'), args);
}

$p.apiDelete = function (args) {
    $p.apiExec($p.apiUrl(args.id, 'delete'), args);
}

$p.apiExec = function (url, args) {
    $.ajax({
        url: url,
        type: 'post',
        cache: false,
        data: JSON.stringify(args.data),
        contentType: 'application/json',
        dataType: 'json'
    })
        .done(args.done)
        .fail(args.fail)
        .always(args.always);
}