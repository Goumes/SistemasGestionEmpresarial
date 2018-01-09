window.onload = inicializaEventos;

function inicializaEventos()
{
    document.getElementById("btnHola").addEventListener ("click", saluda, false);
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
            document.getElementById("divSaludo").innerHTML = miPeticion.responseText;


            //alert(miPeticion.readyState + " " + miPeticion.status)
        }
    };

    //Paso 4 shavale. Enviar la solicitud.
    miPeticion.send();

}