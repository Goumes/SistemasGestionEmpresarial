window.onload = inicializaEventos;

function inicializaEventos()
{
    document.getElementById("btnEnviar").addEventListener("click", enviar, false);
    document.getElementById("btnShavale").style.display = "none";
}

function saludo(/*txt*/) //txt por parametros para probar
{
    var nombre = document.getElementById("txtNombre").value;

    alert("Hola " + /*txt*/nombre);
}

function validarShavale()
{
    var nombre = document.getElementById("txtNombre");
    var apellidos = document.getElementById("txtApellidos");
    var edad = document.getElementById("txtEdad");

    if (nombre.value === "hola" && apellidos.value === "shavale" && edad.value === "2") {

        document.getElementById("btnShavale").style.display = "block";
    }

    else

    {
        document.getElementById("btnShavale").style.display = "none";
    }
}

function validarLiada()
{
    var nombre = document.getElementById("txtNombre");
    var apellidos = document.getElementById("txtApellidos");
    var edad = document.getElementById("txtEdad");

    if (nombre.value === "6" && apellidos.value === "6" && edad.value === "6")
    {
        for (var i = 0; i < 100; i++)
        {
            alert("rip");
        }
    }
}

function enviar()
{
    var nombre = document.getElementById("txtNombre");
    var apellidos = document.getElementById("txtApellidos");
    var edad = document.getElementById("txtEdad");
    var errorNombre = document.getElementById("lblErrorNombre");
    var errorApellidos = document.getElementById("lblErrorApellidos");
    var errorEdad = document.getElementById("lblErrorEdad");

    if (nombre.value === "")
    {
        errorNombre.innerHTML = "La has liado en el nombre crack";
    }

    else
    {
        errorNombre.innerHTML = "";
    }

    if (apellidos.value === "")
    {
        errorApellidos.innerHTML = "La has liado en los apellidos crack";
    }

    else
    {
        errorApellidos.innerHTML = "";
    }

    if (edad.value === "" || isNaN(edad.value))
    {
        if (edad.value === "") {
            errorEdad.innerHTML = "La has liado en la edad crack";
        }

        else
        {
            errorEdad.innerHTML = "La has liado en la edad crack. Tiene que ser numeros.";
        }
    }

    else
    {
        errorEdad.innerHTML = "";
    }

    validarShavale();
    validarLiada();
}

function shavalada()
{
    alert("Hola shavalada antes del Hola shavule");

    alert("Hola shavule");

    alert("Hola shavale despues del Hola shavule despues del Hola shavalada");

    alert("Hola shavalators despues del Hola shavale despues del Hola shavule despues del Hola shavalada");

    alert("Hola shavalines despues del Hola shavalators despues del Hola shavale despues del Hola shavule despues del Hola shavalada");

    alert("Hola shavaleria despues del Hola shavalines despues del Hola shavalators despues del Hola shavale despues del Hola shavule despues del Hola shavalada");

    alert("Hola shavalitos despues del Hola shavaleria despues del Hola shavalines despues del Hola shavalators despues del Hola shavale despues del Hola shavule despues del Hola shavalada");
}