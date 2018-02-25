﻿//window.addEventListener("load", init());

(function () {
    'use strict'; //No se que es esto

    var arrayPersonas;
    var idPersonaEditar;
    var xml = new XMLHttpRequest();

    var nameField = document.getElementById('name'),
        apellidoField = document.getElementById('apellido'),
        fechaNacField = new Date(document.getElementById('fechaNac')),
        telefonoField = document.getElementById('telefono'),
        direccionField = document.getElementById('direccion'),
        saveButton = document.getElementById('btnSave');

    // fecha = fecha.
    //   fechaNacField = document.getElementById('fechaNac')

    // Main function
    var init = function () {
        //updateTable();
        pintaTabla();

        var btnSave = document.getElementById('btnSave'),
            btnRefresh = document.getElementById('btnRefresh');

        btnSave.onclick = function () {
            // if (btnSave.getAttribute('data-update')) {
            //     updateData(btnSave.getAttribute('data-update'));
            // } else {
            saveData(btnSave.getAttribute('data-id'));
            // }
            refreshForm();
        };

        btnRefresh.onclick = function () {
            refreshForm();
        };
    };

    init(); //Intialize the table

    // Set form for data edit
    var updateForm = function (persona) {
        //console.log(userData[id].name);

        nameField.value = persona.name;
        apellidoField.value = persona.apellidos;
        fechaNacField.value = persona.fechaNac;
        telefonoField.value = persona.telefono;
        direccionField.value = persona.direccion;

        saveButton.value = 'Update';
        //saveButton.setAttribute('data-update', id);
    }

    // Save new data
    var saveData = function () {
        var personaNueva = new Persona(1, nameField, apellidoField, fechaNacField, telefonoField, direccionField);
        if (saveButton.value == 'Update') {
            if (xml) {
                //DA METODO NO PERMITIDO
                xml.open('PUT', '../api/personas/' + idPersonaEditar, true);

                xml.setRequestHeader("Content-type", "application/json");

                xml.onreadystatechange = function () {
                    if (xml.readyState == 4 && xml.status == 204) {
                        alert('actualizao');
                        pintaTabla();
                    }
                }
            }
            xml.send(JSON.stringify({ idpersona: 1, fechaNac: fechaNacField.value, nombre: nameField.value, apellidos: apellidoField.value, direccion: direccionField.value, telefono: telefonoField.value }))
        } else {
            if (xml) {
                xml.open('POST', '../api/personas', true);

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
        //var query = 'fechaNac=' + personaNueva.fechaNac + '&nombre=' + personaNueva.nombre + '&apellidos=' + personaNueva.apellidos + '&telefono=' + personaNueva.telefono + '&direccion=' + personaNueva.direccion;


        //xml.send(JSON.stringify({ idpersona: 1, fechaNac: 'aa', nombre: cono, apellidos: 'asdas', direccion: 'asdas', telefono: 'asdasd' }));
    }

    // Update data
	/*var updateData = function(id) {
		var upName = document.getElementById('name').value,
			upPhone = document.getElementById('phone').value;

		userData[id].name = upName;
        userData[id].phone = upPhone;
        pintaTabla();
	}*/

    // Reset the form
    var refreshForm = function () {
        var nameField = document.getElementById('name'),
            phoneField = document.getElementById('phone'),
            saveButton = document.getElementById('btnSave');

        nameField.value = '';
        telefonoField.value = '';
        apellidoField.value = '';
        direccionField.value = '';

        //No se que hacen estas dos lineas
        saveButton.value = 'Save';
        saveButton.removeAttribute('data-update');
    }



    function pintaTabla() {

        //document.getElementById("divLista").innerHTML = "cargando...";
        if (xml) {
            xml.open('GET', '../api/personas');
            xml.onreadystatechange = function () {
                if (xml.readyState == 4 && xml.status == 200) {
                    //document.getElementById("divLista").innerHTML = xml.responseText;
                    arrayPersonas = JSON.parse(xml.responseText);

                    //var updateTable = function () {
                    var dataTable = document.getElementById('table1');
                    var tableHead = document.getElementById('table-head');
                    var tbody = document.createElement('tbody');

                    while (dataTable.firstChild) {
                        dataTable.removeChild(dataTable.firstChild);
                    }

                    dataTable.appendChild(tableHead);

                    for (var i = 0; i < arrayPersonas.length; i++) {
                        var tr = document.createElement('tr'),
                            td0 = document.createElement('td'),
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
                        //btnDelete.setAttribute('value', 'Delete');
                        btnDelete.setAttribute('class', 'btnDelete');
                        btnDelete.setAttribute('id', i);
                        btnDelete.setAttribute('value', "DELETE");
                        btnDelete.setAttribute('name', arrayPersonas[i].idPersona);

                        btnEdit.setAttribute('type', 'button');
                        btnEdit.setAttribute('value', 'Edit');
                        btnEdit.setAttribute('id', i);
                        btnEdit.setAttribute('data-id', arrayPersonas[i].idPersona)
                        btnEdit.setAttribute('data-nombre', arrayPersonas[i].nombre);
                        btnEdit.setAttribute('data-apellidos', arrayPersonas[i].apellidos);
                        btnEdit.setAttribute('data-fechaNac', arrayPersonas[i].fechaNac);
                        btnEdit.setAttribute('data-telefono', arrayPersonas[i].telefono);
                        btnEdit.setAttribute('data-direccion', arrayPersonas[i].direccion);

                        tr.appendChild(td0);
                        tr.appendChild(td1);
                        tr.appendChild(td2);
                        tr.appendChild(td3);
                        tr.appendChild(td4);
                        tr.appendChild(td5);
                        tr.appendChild(td6);
                        tr.appendChild(td7);
                        tr.appendChild(td8);

                        td0.innerHTML = i + 1;
                        td1.innerHTML = arrayPersonas[i].idPersona;
                        td2.innerHTML = arrayPersonas[i].nombre;
                        td3.innerHTML = arrayPersonas[i].apellidos;
                        td4.innerHTML = arrayPersonas[i].fechaNac;
                        td5.innerHTML = arrayPersonas[i].telefono;
                        td6.innerHTML = arrayPersonas[i].direccion;
                        td7.appendChild(btnEdit);
                        td8.appendChild(btnDelete);

                        //AÑADE A CADA BOTON ELIMINAR UN LISTENER PARA EL METODO
                        btnDelete.addEventListener("click", deletePersona, false);

                        btnEdit.addEventListener("click", editPersona, false);

                        tbody.appendChild(tr);
                    }
                    dataTable.appendChild(tbody);
                    //}
                }
            }
        }
        xml.send();
    }

    function deletePersona() {
        if (confirm("Seguro que quieres borrar al cabesa este?")) {
            var deleteId = this.name;

            //userData.splice(deleteId, 1);
            xml.open('DELETE', '../api/personas/' + deleteId, true);
            xml.onreadystatechange = function () {
                if (xml.readyState == 4 && (xml.status == 200 || xml.status == 204)) {
                    //document.getElementById("divLista").innerHTML = xml.responseText;
                    alert("eliminao");

                    pintaTabla();
                    refreshForm();
                }
            }
            xml.send();


        }
    };

    function editPersona() {

        var editId = this.getAttribute('id');
        idPersonaEditar = this.getAttribute("data-id");
        var nombre = this.getAttribute("data-nombre");
        var apellidos = this.getAttribute("data-apellidos");
        var fechaNac = this.getAttribute("data-fechaNac");
        var telefono = this.getAttribute("data-telefono");
        var direccion = this.getAttribute("data-direccion");

        var personaEditar = new Persona(idPersonaEditar, nombre, apellidos, fechaNac, telefono, direccion);

        window.scrollTo({
            top: 0,
            left: 0,
            behavior: 'smooth'
        });
        updateForm(personaEditar);
    }

})();