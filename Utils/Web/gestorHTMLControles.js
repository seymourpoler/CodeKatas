
//objeto que describe cada uno de los 
//options del Select|Combo
function ComboOption(texto, valor) {
    this.texto = texto;
    this.valor = valor;
}

//Gestiona ñas posibles operaciones sobre el control
//HTML <select></select>
function GestorCombo(idCombo) {
    this.combo = document.getElementById(idCombo);
    if (this.combo == null) { return; }

    this.borrarTodasLasOpciones = function () {

        var i;
        for (i = this.combo.length - 1; i >= 0; i--) {
            if (this.combo.options[i].selected) {
                this.combo.remove(i);
            }
        }
    }

    this.aniadirOption = function (option) {
        this.combo.options[this.combo.options.length] = new Option(option.texto, option.valor);
    }

    this.conseguirValorSeleccionado = function () {
        var resultado = '';
        if ((this.combo.selectedIndex > -1) && (this.combo.options.length > 0)) {
            resultado = this.combo.options[this.combo.selectedIndex].value;
        }
        return resultado;
    }

    this.seleccionarOption = function (valor) {
        for (i = 0; i < this.combo.options.length; i++) {
            if (this.combo.options[i].value == valor) { break; } 
        }
        this.combo.options.selectedIndex = i;
    }
}
