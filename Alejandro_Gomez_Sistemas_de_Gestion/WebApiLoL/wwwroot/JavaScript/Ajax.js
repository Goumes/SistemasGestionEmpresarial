window.onload = funcionPrincipal;
/* Para que la correción sea más sencilla voy a explicar cómo funciona el programa de antemano.
 * Primero hago un get a la api para conseguir los personajes y luego creo la tabla en un bucle con su checkbox.
 * Dentro del change del checkbox hago 3 cosas.
 * 1. Valido que no se puedan seleccionar más de 4 personajes a la vez
 * 2. Cuando seleccionas un personaje, se crea un div con sus detalles y se oculta.
 * 3. Cuando deseleccionas un personaje hace una marca en el id del div para borrarlo cuando le des otra vez a mostrar.

 * El botón de mostrar tiene dos bucles. El primero para borrar todos los div que tengan la marca y el segundo para mostrar todos los div que estén creados.
 */

function funcionPrincipal()
{
    var contador = 0;
    var xml = new XMLHttpRequest();
    var body = document.getElementById("body");
    if (xml) {
        xml.open('GET', '../api/personajes');
        xml.onreadystatechange = function () {
            if (xml.readyState == 4 && xml.status == 200) {
                var arrayPersonajes = JSON.parse(xml.responseText);

                var miTabla = document.createElement("table");
                var filaCabecera = miTabla.appendChild(document.createElement("tr"));


                miTabla.style.border = "1px solid black"

                filaCabecera.style.backgroundColor = "gray";

                filaCabecera.appendChild(document.createElement("th")).appendChild(document.createTextNode("Nombre"));
                filaCabecera.appendChild(document.createElement("th")).appendChild(document.createTextNode("Detalles"));

                for (var i = 0; i < arrayPersonajes.length; i++)
                {
                    var tr = document.createElement('tr'),
                        td1 = document.createElement('td'),
                        checkbox = document.createElement('input');

                    checkbox.setAttribute('type', 'checkbox');
                    checkbox.setAttribute('value', 'Detalles');
                    checkbox.setAttribute('class', 'checkbox');
                    //Lo he hecho de esta manera porque no me cogía la clase. Sino habría creado aqui un personaje y lo habría pasado por parámetros al método.
                    checkbox.setAttribute('id', arrayPersonajes[i].idPersonaje);
                    checkbox.setAttribute('nombre', arrayPersonajes[i].nombre);
                    checkbox.setAttribute('alias', arrayPersonajes[i].alias);
                    checkbox.setAttribute('regeneracion', arrayPersonajes[i].regeneracion);
                    checkbox.setAttribute('vida', arrayPersonajes[i].vida);
                    checkbox.setAttribute('danno', arrayPersonajes[i].danno);
                    checkbox.setAttribute('armadura', arrayPersonajes[i].armadura);
                    checkbox.setAttribute('velAtaque', arrayPersonajes[i].velAtaque);
                    checkbox.setAttribute('resistencia', arrayPersonajes[i].resistencia);
                    checkbox.setAttribute('velMovimiento', arrayPersonajes[i].velMovimiento);
                    

                    ///Metodo dedicado a crear y borrar los divs según el checkbox seleccionado.
                    checkbox.addEventListener('change', function () {

                        var id = this.getAttribute('id');
                        var nombre = this.getAttribute('nombre');
                        var alias = this.getAttribute('alias');
                        var regeneracion = this.getAttribute('regeneracion');
                        var vida = this.getAttribute('vida');
                        var danno = this.getAttribute('danno');
                        var armadura = this.getAttribute('armadura');
                        var velAtaque = this.getAttribute('velAtaque');
                        var resistencia = this.getAttribute('resistencia');
                        var velMovimiento = this.getAttribute('velMovimiento');

                        if (this.checked && contador < 4) {
                            contador++;

                            var div = body.appendChild(document.createElement("div"));
                            var hr = body.appendChild(document.createElement("hr"));

                            hr.id = ("hr " + id);
                            div.id = ("div " + id);
                            div.appendChild(document.createElement("h1")).textContent = nombre;
                            div.appendChild(document.createElement("img")).src = "../Imagenes/"+nombre+".png";
                            div.appendChild(document.createElement("p")).textContent = "Alias: " + alias;
                            div.appendChild(document.createElement("p")).textContent = "Regeneracion: " + regeneracion;
                            div.appendChild(document.createElement("p")).textContent = "Vida: " + vida;
                            div.appendChild(document.createElement("p")).textContent = "Daño: " + danno;
                            div.appendChild(document.createElement("p")).textContent = "Armadura: " + armadura;
                            div.appendChild(document.createElement("p")).textContent = "Velocidad de ataque: " + velAtaque;
                            div.appendChild(document.createElement("p")).textContent = "Resistencia: " + resistencia;
                            div.appendChild(document.createElement("p")).textContent = "Velocidad de movimiento: " + velMovimiento;
                            div.hidden = true;
                            hr.hidden = true;
                        }

                        else if (!this.checked)
                        {
                            var div = document.getElementById("div " + id);
                            var hr = document.getElementById("hr " + id);

                            //Estaba haciendo un borrado por marca pero cuando le cambio el id al div, este no se cambia luego cuando salgo de aqui.
                            //Si eso funcionara todo estaría bien. Como no funciona dejo esta parte comentada y el borrado lo dejo por uncheck. Para que 
                            //Compruebes que funcionaría si la marca se guardara.

                            //div.id = div.id + "*";//Esto se descomentaria
                            //div.hr = div.hr + "*";//Esto se descomentaria
                            div.parentNode.removeChild(div);//Esto se comentaria
                            hr.parentNode.removeChild(hr); //Esto se comentaria
                            contador--;
                        }

                        else if (contador >= 4)
                        {
                            alert ("No se pueden seleccionar más de 4 personajes a la vez");
                            this.checked = false;
                        }
                    }, false);

                    tr.appendChild(td1);
                    tr.appendChild(checkbox);

                    td1.innerHTML = arrayPersonajes[i].nombre;

                    miTabla.appendChild(tr);
                }

                document.getElementById("tabla").appendChild(miTabla);

                var btnMostrar = document.createElement("input");
                btnMostrar.setAttribute("id", "btnMostrar");
                btnMostrar.setAttribute('type', 'button');
                btnMostrar.setAttribute('value', 'Mostrar detalles');
                btnMostrar.setAttribute('class', 'btnDelete');

                //Metodo dedicado a mostrar los detalles de los personajes al hacer click.
                btnMostrar.addEventListener('click', function () {
                    for (var i = 1; i < arrayPersonajes.length + 1; i++) {
                        //Esto comentado sería como lo borraría si el div guardara la marca.
                        /*
                        if (document.getElementById("hr " + i + "*") != null && document.getElementById("div " + i + "*") != null) {
                            var hr = document.getElementById("hr " + i)
                            var div = document.getElementById("div " + i)
                            div.parentNode.removeChild(div);
                            hr.parentNode.removeChild(hr);
                        }
                        */
                        //Este if de abajo se comentaría
                        if (document.getElementById("hr " + i) != null && document.getElementById("div " + i) != null) {
                            document.getElementById("hr " + i).hidden = true;
                            document.getElementById("div " + i).hidden = true;
                        }

                    }

                    for (var i = 1; i < arrayPersonajes.length + 1; i++) {
                        if (document.getElementById("hr " + i) != null && document.getElementById("div " + i) != null) {
                            document.getElementById("hr " + i).hidden = false;
                            document.getElementById("div " + i).hidden = false;
                        }
                    }
                }, false);

                body.appendChild(document.createElement("br"));
                body.appendChild(btnMostrar);

            }
        }
        xml.send();
    }
}
