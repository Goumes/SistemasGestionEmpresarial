window.addEventListener("load", inicia);

function inicia() {
    document.getElementById("btnListar").addEventListener("click", pintaTabla, false);
    
}

function pintaTabla() {
    var xml = new XMLHttpRequest();
    document.getElementById("divLista").innerHTML = "cargando...";
    if (xml) {
        xml.open('GET', '../api/personas');
        xml.onreadystatechange = function () {
            
            if (xml.readyState == 4 && xml.status == 200) {
                document.getElementById("divLista").innerHTML = xml.responseText;
                var arrayPersonas = Json.parse(xml.responseText);
                
            }
        }
    }
    xml.send();
}