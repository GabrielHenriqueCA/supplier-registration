// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('.close-alert').click(function () {
    $('.alert').hide('hide');
});

$(document).ready(function () {
    $('#inputCep').on('blur', function () {
        var cep = $(this).val().replace(/\D/g, '');
        if (cep.length === 8) {
            $.getJSON(`https://viacep.com.br/ws/${cep}/json/`, function (data) {
                if (!data.erro) {
                    $('#inputAddress').val(data.logradouro);
                    $('#errorCep').hide();
                } else {
                    $('#inputAddress').val('');
                    $('#errorCep').show();
                }
            });
        }
    });
});