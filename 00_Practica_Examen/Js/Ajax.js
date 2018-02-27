window.onload = inicializaEventos;

function inicializaEventos() {
    document.getElementById("btnLista").addEventListener("click", listaPersonas, false);
    pintarTabla();
    var btnSave = document.getElementById('btnSave'),
        btnRefresh = document.getElementById('btnRefresh');

    btnSave.onclick = function () {
        saveData();
        refreshForm();
    };

    btnRefresh.onclick = function () {
        refreshForm();
    };
}

function listaPersonas()
{
    var xml = new XMLHttpRequest();
        //document.getElementById("divLista").innerHTML = "cargando...";
    if (xml)
    {
        xml.open('GET', 'http://localhost:50461/api/personas');
            xml.onreadystatechange = function ()
            {
                document.getElementById("divLista").innerHTML = "Cargando...";
                if (xml.readyState == 4 && xml.status == 200)
                {
                    document.getElementById("divLista").innerHTML = xml.responseText;
                    //arrayPersonas = JSON.parse(xml.responseText);
                }
            }
        xml.send();
    }
}

function pintarTabla()
{
    var xml = new XMLHttpRequest();
    if (xml)
    {
        xml.open('GET', 'http://localhost:50461/api/personas');
        xml.onreadystatechange = function ()
        {
            if (xml.readyState == 4 && xml.status == 200)
            {
                var arrayPersonas = JSON.parse(xml.responseText);

                //var numeroRandom = Math.random() * 1000 (Math.random() + 7 % 12);
                //xml.open("GET", ".../api/personas?random=" + numeroRandom); Para recargar la pagina hay que hacer esto

                var miTabla = document.createElement("table");
                var filaValues = miTabla.appendChild(document.createElement("tr"));

                miTabla.style.border = "1px solid black"

                filaValues.style.backgroundColor = "gray";
                filaValues.appendChild(document.createElement("th")).appendChild(document.createTextNode("Id"));
                filaValues.appendChild(document.createElement("th")).appendChild(document.createTextNode("Nombre"));
                filaValues.appendChild(document.createElement("th")).appendChild(document.createTextNode("Apellidos"));
                filaValues.appendChild(document.createElement("th")).appendChild(document.createTextNode("fechaNac"));
                filaValues.appendChild(document.createElement("th")).appendChild(document.createTextNode("telefono"));
                filaValues.appendChild(document.createElement("th")).appendChild(document.createTextNode("direccion"));
                filaValues.appendChild(document.createElement("th")).appendChild(document.createTextNode("Editar"));
                filaValues.appendChild(document.createElement("th")).appendChild(document.createTextNode("Borrar"));

                for (var i = 0; i < arrayPersonas.length; i++)
                {
                    var tr = document.createElement('tr'),
                        td1 = document.createElement('td'),
                        td2 = document.createElement('td'),
                        td3 = document.createElement('td'),
                        td4 = document.createElement('td'),
                        td5 = document.createElement('td'),
                        td6 = document.createElement('td'),
                        td7 = document.createElement('td'),
                        td8 = document.createElement('td'),
                        btnDelete = document.createElement('input'),
                        btnEdit = document.createElement('input');

                    btnDelete.setAttribute('type', 'button');
                    btnDelete.setAttribute('value', 'Delete');
                    btnDelete.setAttribute('class', 'btnDelete');
                    btnDelete.setAttribute('id', arrayPersonas[i].idPersona);

                    btnEdit.setAttribute('type', 'button');
                    btnEdit.setAttribute('value', 'Edit');
                    btnEdit.setAttribute('id', arrayPersonas[i].idPersona);
                    btnEdit.setAttribute('nombre', arrayPersonas[i].nombre);
                    btnEdit.setAttribute('apellidos', arrayPersonas[i].apellidos);
                    btnEdit.setAttribute('fechaNac', arrayPersonas[i].fechaNac);
                    btnEdit.setAttribute('telefono', arrayPersonas[i].telefono);
                    btnEdit.setAttribute('direccion', arrayPersonas[i].direccion);

                    tr.appendChild(td1);
                    tr.appendChild(td2);
                    tr.appendChild(td3);
                    tr.appendChild(td4);
                    tr.appendChild(td5);
                    tr.appendChild(td6);
                    tr.appendChild(td7);
                    tr.appendChild(td8);

                    btnDelete.addEventListener('click', function () {
                        var deleteId = this.getAttribute('id');

                        if (confirm("Seguro que quieres borrar al cabesa este?"))
                        {
                            xml.open('DELETE', 'http://localhost:50461/api/personas/' + deleteId);
                            xml.onreadystatechange = function () {
                                if (xml.readyState == 4 && xml.status == 200) {
                                    //document.getElementById("divLista").innerHTML = xml.responseText;
                                    alert("eliminado");
                                }
                            }
                            xml.send();
                        }
                    }, false);

                    btnEdit.addEventListener('click', function ()
                    {
                        //this.parentElement.parentElement.childNodes[0].nodeValue = 'valor del node 0';//Aqui estoy añadiendole este valor a la columna 0 de la fila en la que estoy
                        var persona = new Persona(this.getAttribute('id'), this.getAttribute('nombre'), this.getAttribute('apellidos'), this.getAttribute('fechaNac').split("T", 1), this.getAttribute('telefono'), this.getAttribute('direccion'));
                        updateForm(persona);
                    }, false);

                    td1.innerHTML = arrayPersonas[i].idPersona;
                    td2.innerHTML = arrayPersonas[i].nombre;
                    td3.innerHTML = arrayPersonas[i].apellidos;
                    td4.innerHTML = arrayPersonas[i].fechaNac.split("T", 1);
                    td5.innerHTML = arrayPersonas[i].telefono;
                    td6.innerHTML = arrayPersonas[i].direccion;
                    td7.appendChild(btnEdit);
                    td8.appendChild(btnDelete);

                    miTabla.appendChild(tr);
                }

                document.getElementById("divTabla").appendChild(miTabla);
            }

        }
               
    }
    xml.send();
}

function saveData()
{
    var nameField = document.getElementById('name'),
        apellidoField = document.getElementById('apellido'),
        fechaNacField = document.getElementById('fechaNac'),
        telefonoField = document.getElementById('telefono'),
        direccionField = document.getElementById('direccion'),
        saveButton = document.getElementById('btnSave');
    var xml = new XMLHttpRequest();

    var personaNueva = new Persona(1, nameField, apellidoField, fechaNacField, telefonoField, direccionField);

    if (saveButton.value == 'Save') {
        if (xml) {
            xml.open('POST', 'http://localhost:50461/api/personas/', true);

            xml.setRequestHeader("Content-type", "application/json");

            xml.onreadystatechange = function () {
                if (xml.readyState == 4 && xml.status == 204) {
                    //document.getElementById("divLista").innerHTML = xml.responseText;
                    alert('publicao');
                    pintaTabla();
                }
            }
        }
        //xml.send(query);
        xml.send(JSON.stringify({ idpersona: 1, fechaNac: fechaNacField.value, nombre: nameField.value, apellidos: apellidoField.value, direccion: direccionField.value, telefono: telefonoField.value }));
    }

    else {
        //Aqui iria el put
    }
   
}

function refreshForm()
{
    var nameField = document.getElementById('name'),
        apellidoField = document.getElementById('apellido'),
        fechaNacField = document.getElementById('fechaNac'),
        telefonoField = document.getElementById('telefono'),
        direccionField = document.getElementById('direccion'),
        saveButton = document.getElementById('btnSave');

    nameField.value = '';
    telefonoField.value = '';
    fechaNacField.value = '';
    apellidoField.value = '';
    direccionField.value = '';

    //No se que hacen estas dos lineas
    saveButton.value = 'Save';
    saveButton.removeAttribute('data-update');
}

function updateForm(persona)
{
    var nameField = document.getElementById('name'),
        apellidoField = document.getElementById('apellido'),
        fechaNacField = document.getElementById('fechaNac'),
        telefonoField = document.getElementById('telefono'),
        direccionField = document.getElementById('direccion'),
        saveButton = document.getElementById('btnSave');

    nameField.value = persona.nombre;
    telefonoField.value = persona.telefono;
    fechaNacField.value = persona.fechaNac;
    apellidoField.value = persona.apellidos;
    direccionField.value = persona.direccion;

    saveButton.value = 'Update';
}