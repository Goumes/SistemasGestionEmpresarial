window.onload = inicializaEventos;

function inicializaEventos()
{
    document.getElementById("btnHola").addEventListener("click", saluda, false);
    document.getElementById("btnListaXML").addEventListener("click", personasXml, false);
}

function personasXml()
{
    //Paso 1 shavale. Instanciar el objeto.
    var miPeticion = new XMLHttpRequest();

    //Paso 2 shavale. Preparar la petición.
    miPeticion.open("GET", "../Server/maracas.xml", true)

    //Paso 2.5 shavale. Cabeceras si hacen falta.

    //Paso 3 shavale. Preparar los cambios de estado.
    miPeticion.onreadystatechange = function () {

        //CARGANDO CUANDO TODAVIA NO HA LLEGADO LA INFORMACION
        document.getElementById("divMaracasXML").innerHTML = "Cargando...";

        if (miPeticion.readyState == 4 && miPeticion.status == 200) {
            document.getElementById("divMaracasXML").innerHTML = "";
            //Paso 5. Tratar de la información recibida.
            //document.getElementById("divMaracasXML").innerHTML = miPeticion.responseText;
            var datosXml = miPeticion.responseXML;
            var miTabla = document.createElement("table");
            var arrayMaracas = datosXml.getElementsByTagName("maraca");;
            var filaValues = miTabla.appendChild(document.createElement("tr"));
            var elementPrecio = miTabla.appendChild(document.createElement("tr"));
            var colores = ["red", "green", "yellow", "blue"];

            miTabla.style.border = "1px solid black"

            filaValues.style.backgroundColor = "gray";
            filaValues.appendChild(document.createElement("th")).appendChild(document.createTextNode("Nombre"));
            filaValues.appendChild(document.createElement("th")).appendChild(document.createTextNode("Precio"));

            for (var i = 0; i < arrayMaracas.length; i++)
            {
                var element = miTabla.appendChild(document.createElement("tr"));
                var tdNombre = element.appendChild(document.createElement("td"));
                var tdPrecio = element.appendChild(document.createElement("td"));
                var numero = Math.floor(Math.random() * 4); 

                tdNombre.style.backgroundColor = colores[numero];
                tdPrecio.style.backgroundColor = colores[numero];

                tdNombre.appendChild(document.createTextNode(arrayMaracas[i].getElementsByTagName("nombre")[0].firstChild.nodeValue));
                tdPrecio.appendChild(document.createTextNode(arrayMaracas[i].getElementsByTagName("precio")[0].firstChild.nodeValue));
            }

            document.getElementById("divSaludo").hidden = true;
            document.getElementById("divMaracas").hidden = true;
            document.getElementById("divMaracasXML").hidden = false;
            document.getElementById("divMaracasXML").appendChild(miTabla);
            
            
            //document.getElementById("divMaracasXML").innerHTML = datosXml.getElementsByTagName("maraca")[1].getElementsByTagName("nombre")[0].firstChild.nodeValue;
            


            //alert(miPeticion.readyState + " " + miPeticion.status)
        }
    };

    //Paso 4 shavale. Enviar la solicitud.
    miPeticion.send();
}

function saluda()
{
    //Paso 1 shavale. Instanciar el objeto.
    var miPeticion = new XMLHttpRequest();

    //Paso 2 shavale. Preparar la petición.
    miPeticion.open("GET", "../Server/HolaMundo.html", true)

    //Paso 2.5 shavale. Cabeceras si hacen falta.

    //Paso 3 shavale. Preparar los cambios de estado.
    miPeticion.onreadystatechange = function () {

        //CARGANDO CUANDO TODAVIA NO HA LLEGADO LA INFORMACION
        document.getElementById("divSaludo").innerHTML = "Cargando...";

        if (miPeticion.readyState == 4 && miPeticion.status == 200) {
            //Paso 5. Tratar de la información recibida.
            document.getElementById("divMaracasXML").hidden = true;
            document.getElementById("divMaracas").hidden = true;
            document.getElementById("divSaludo").hidden = false;
            document.getElementById("divSaludo").innerHTML = miPeticion.responseText;
            
            //alert(miPeticion.readyState + " " + miPeticion.status)
        }
    };

    //Paso 4 shavale. Enviar la solicitud.
    miPeticion.send();
}