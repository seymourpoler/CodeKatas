
//Devuelve solo el nombre de la página que se está ejecutando actualmente
function conseguirNombreDeLaPagina() {
    var sPath = window.location.pathname;
    var resultado = sPath.substring(sPath.lastIndexOf('/') + 1);
    return resultado;
}

//Devuelve las variables pasadas por el querystring en un hash key-value 
function getUrlVars() {
    var vars = [], hash;
    var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
    for (var i = 0; i < hashes.length; i++) {
        hash = hashes[i].split('=');
        vars.push(hash[0]);
        vars[hash[0]] = hash[1];
    }
    return vars;
}

//Devuelve el valor, que está asociado a la clave
//en el QueryString
function conseguirValorDelQueryString(clave) {
    var queryString = getUrlVars();
    return queryString[clave];
}

//Trata el json para meterlo al jaquery-dataTable
function ConvertObjectToArray(obj) {
    var arr = [];

    for (cont = 0; cont < obj.length; cont++) {
        var t = 0;
        arr[cont] = [obj.length];

        for (var propiedad in obj[cont]) {
            arr[cont][t] = obj[cont][propiedad];
            t++;
        }
    }

    return arr;
}

function isFloat(numero) {
    if ((numero == '') || (numero == null) || (numero.indexOf(",") < 0)) {
        return false;
    }
    var valor = parseFloat(numero);
    return !isNaN(valor);
}

function isInteger(numero) {
    return (numero != null) && (numero != '') && (!isNaN(numero));
}


function postToUrl(path, params, method) {
    method = method || "post"; // Set method to post by default, if not specified.

    // The rest of this code assumes you are not using a library.
    // It can be made less wordy if you use one.
    var form = document.createElement("form");
    form.setAttribute("method", method);
    form.setAttribute("action", path);

    for (var key in params) {
        if (params.hasOwnProperty(key)) {
            var hiddenField = document.createElement("input");
            hiddenField.setAttribute("type", "hidden");
            hiddenField.setAttribute("name", key);
            hiddenField.setAttribute("value", params[key]);

            form.appendChild(hiddenField);
        }
    }

    document.body.appendChild(form);
    form.submit();
}
