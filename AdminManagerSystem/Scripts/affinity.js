
$('#affinity').on('click', '.approve', function () {
    let id = $(this).closest('tr').attr('data-affinity-id')
    $.ajax({
        url: $('#approve_affinity_url').val(),
        method: 'POST',
        data: {
            'id': id,
        },
        success: function (data) {
            if (data.status == 'success') {
                new PNotify({
                    title: data.message_title,
                    text: '',
                    delay: 1000,
                    type: 'success',
                });
                
                let name = $('tr[data-affinity-id="' + id + '"] .name').text();
                $('tr[data-affinity-id="' + id + '"]').remove();
                append_affinity_approved(id, name);
                
                
            } else if (data.status == 'error') {
                new PNotify({
                    title: data.message_title,
                    text: '',
                    delay: 1000,
                    type: 'error',
                });
            }
        },
        error: function (e) {
            console.error('ERROR AJAX:', e)
        },
    })
})

$('#affinity').on('click', '.edit', function () {
    let id = $(this).closest('tr').attr('data-affinity-id')
    $.ajax({
        url: $('#edit_affinity_url').val(),
        method: 'POST',
        data: {
            'id': id,
        },
        success: function (data) {
            if (data.status == 'success') {
                new PNotify({
                    title: data.message_title,
                    text: '',
                    delay: 1000,
                    type: 'success',
                });
                

            } else if (data.status == 'error') {
                new PNotify({
                    title: data.message_title,
                    text: '',
                    delay: 1000,
                    type: 'error',
                });
            }
        },
        error: function (e) {
            console.error('ERROR AJAX:', e)
        },
    })
})

$('#affinity').on('click', '.trash', function () {
    let id = $(this).closest('tr').attr('data-affinity-id')
    $.ajax({
        url: $('#trash_affinity_url').val(),
        method: 'POST',
        data: {
            'id': id,
        },
        success: function (data) {
            if (data.status == 'success') {
                new PNotify({
                    title: data.message_title,
                    text: '',
                    delay: 1000,
                    type: 'success',
                });

                $('tr[data-affinity-id="' + id + '"]').remove();
    
            } else if (data.status == 'error') {
                new PNotify({
                    title: data.message_title,
                    text: '',
                    delay: 1000,
                    type: 'error',
                });
            }
        },
        error: function (e) {
            console.error('ERROR AJAX:', e)
        },
    })
})


function append_affinity_approved(id, name) {
    $('#tbody_affinity_approved').prepend('\
                                       <tr data-affinity-id="'+ id +'">\n' +
                                '            <th scope="row">5</th>\n' +
                                '            <td class="name">'+ name +'</td>\n' +
                                '            <td class="actions">\n' +
                                '                <a href="javascript:;" class="edit"data-placement="top" data-toggle="tooltip" data-original-title="Editar">\n' +
                                '                    <i class="os-icon os-icon-pencil-1"></i>\n' +
                                '                </a>\n' +
                                '                <a href="javascript:;" class="trash" data-placement="top" data-toggle="tooltip" data-original-title="Excluir">\n' +
                                '                    <i class="os-icon os-icon-ui-15"></i>\n' +
                                '                </a>\n' +
                                '            </td>\n' +
                                '        </tr>');

    $('[data-toggle="tooltip"]').tooltip('update')
}