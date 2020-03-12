//Funcion Abrir modal formulario para registrar nuevos usuarios
$("#btnNuevo").click(function (eve) {
    $("#modal-content").load("../Usuarios/AddOrEdit");
});

//Funcion Abrir modal formulario para Editar  usuarios

$(".btnEditar").click(function (eve) {
    $("#modal-content").load("../Usuarios/AddOrEdit/" + $(this).data("id"));
});