function Edit(id) {
    $.ajax({
        url: '/Ajax/Edit?id=' + id,
        type: 'Get',
        contentType: 'application/json;charset=utf-8',
        dataType: 'json',
        success: function(response) {

            $('#EmployeeMadal').modal('show');
            $('#Id').val(response.id);
            $('#Name').val(response.name);
            $('#City').val(response.city);
            $('#State').val(response.state);
            $('#Salary').val(response.salary);
            $('#AddEmployee').hide();
            $('#btnUpdate').show();
            $('#empHeading').text('Update Record');

        },
        error: function() {
            alert('Data Not Found');
        }
    });
}
